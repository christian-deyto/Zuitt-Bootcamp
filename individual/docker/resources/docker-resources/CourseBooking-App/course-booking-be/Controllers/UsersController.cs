using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using course_booking_cs.Models;
using course_booking_cs.Data;

namespace course_booking_cs.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly CourseEnrollmentRepository _courseEnrollmentRepository;

        public UsersController(UserRepository userRepository, CourseEnrollmentRepository courseEnrollmentRepository)
        {
            _userRepository = userRepository;
            _courseEnrollmentRepository = courseEnrollmentRepository;
        }

        // Get all users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            try
            {
                List<User> users = _userRepository.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving users: " + ex.Message);
                return StatusCode(500, "An error occurred while retrieving users.");
            }
        }

        // Get user by ID
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            try
            {
                var user = _userRepository.GetUserById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving a user: " + ex.Message);
                return StatusCode(500, "An error occurred while retrieving a user.");
            }
        }

        // Log in a user
        [HttpPost("login")]
        public ActionResult<LoginResponse> Login(UserloginDTO userLoginDto)
        {
            try
            {
                var user = _userRepository.GetUserByEmail(userLoginDto.Email);

                if (user == null)
                {
                    return NotFound(new { result = "user_not_found" });
                }

                if (user.Password != userLoginDto.Password)
                {
                    return BadRequest(new { result = "incorrect_credentials" });
                }

                // Create a custom response object that includes the user information and login status
                var loginResponse = new LoginResponse
                {
                    email = user.Email,
                    isAdmin = user.IsAdmin,
                    token = user.Id
                };

                return Ok(loginResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving log in credentials: " + ex.Message);
                return StatusCode(500, "An error occurred while retrieving log in credentials.");
            }
        }

        // Register a new user
        [HttpPost("register")]
        public ActionResult<User> Register(UserRegisterDTO userRegisterDto)
        {
            var user = _userRepository.GetUserByEmail(userRegisterDto.Email);

            if (user != null)
            {
                return BadRequest(new { result = "user_already_exist" });
            }

            // Create a new User object from the provided details
            var newUser = new User
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                Email = userRegisterDto.Email,
                Password = userRegisterDto.Password,
                IsAdmin = userRegisterDto.IsAdmin
            };

            // Add the new user to the list
            _userRepository.InsertUser(newUser);

            // Return the newly created user
            return Ok(new { result = "added" });
        }

        // Enroll a user to a course
        [HttpPost("enroll")]
        public ActionResult<CourseEnrollment> EnrollCourse([FromBody] JsonElement payload)
        {
            int courseId = payload.GetProperty("courseId").GetInt32();

            // Retrieve the Authorization header from the request
            string? authorizationHeader = Request.Headers["Authorization"];
            string tokenValue = authorizationHeader.Replace("Bearer ", "");
            int UserId = int.Parse(tokenValue);

            // Check if the user is already enrolled in the course
            CourseEnrollment existingEnrollment = _courseEnrollmentRepository.GetCourseEnrollmentByCourseIdAndUserId(courseId, UserId);
            if (existingEnrollment != null)
            {
                return BadRequest(new { result = "already_enrolled" });
            }

            var enrollment = new CourseEnrollment
            {
                CourseId = courseId,
                UserId = UserId,
                DatetimeEnrolled = DateTime.UtcNow
            };

            // Add the enrollment to the list or database
            _courseEnrollmentRepository.InsertCourseEnrollment(enrollment);

            // Return the created enrollment object
            return Ok(new { result = "enrollment_successful" });
        }

    }

}
