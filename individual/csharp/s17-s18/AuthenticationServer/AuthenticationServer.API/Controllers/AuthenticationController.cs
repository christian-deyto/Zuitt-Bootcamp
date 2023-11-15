using AuthenticationServer.API.Models;
using AuthenticationServer.API.Models.Request;
using AuthenticationServer.API.Models.Requests;
using AuthenticationServer.API.Models.Responses;
using AuthenticationServer.API.Services.Authenticators;
using AuthenticationServer.API.Services.PasswordHashers;
using AuthenticationServer.API.Services.RefreshTokenRepositories;
using AuthenticationServer.API.Services.TokenGenerators;
using AuthenticationServer.API.Services.TokenValidators;
using AuthenticationServer.API.Services.UserRepositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationServer.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        //private readonly AccessTokenGenerator _accessTokenGenerator; // _ indicates that is this is not an ordinary field
        //private readonly RefreshTokenGenerator _refreshTokenGenerator;
        private readonly RefreshTokenValidator _refreshTokenValidator;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly Authenticator _authenticator;

        public AuthenticationController(IUserRepository userRepository, IPasswordHasher passwordHasher, /*AccessTokenGenerator accessTokenGenerator, RefreshTokenGenerator refreshTokenGenerator,*/ RefreshTokenValidator refreshTokenValidator, IRefreshTokenRepository refreshTokenRepository, Authenticator authenticator)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            //_accessTokenGenerator = accessTokenGenerator;
            //_refreshTokenGenerator = refreshTokenGenerator;
            _refreshTokenValidator = refreshTokenValidator;
            _refreshTokenRepository = refreshTokenRepository;
            _authenticator = authenticator;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                //Here we will map throught error messages in the ModelState values.
                IEnumerable<string> errorMessages = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errorMessages);
            }
            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                return BadRequest(new ErrorResponse("Password does not match. Please confirm your password."));
            }

            User existingUserByEmail = await _userRepository.GetByEmail(registerRequest.Email);
            if (existingUserByEmail != null)
            {
                return Conflict(new ErrorResponse("Username already exist."));
            }


            User existingUserByUsername = await _userRepository.GetByUsername(registerRequest.Username);
            if (existingUserByUsername != null)
            {
                return Conflict();
            }

            string passwordHash = _passwordHasher.HashPassword(registerRequest.Password);

            User registrationUser = new User()
            {
                Email = registerRequest.Email,
                Username = registerRequest.Username,
                PasswordHash = passwordHash,
            };

            await _userRepository.Create(registrationUser);

            return Ok();


        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //This will get the user data and check if the user exist in our list.
            User user = await _userRepository.GetByUsername(loginRequest.Username);
            if (user == null)
            {
                return Unauthorized();
            }

            bool isCorrectPassword = _passwordHasher.VerifyPassword(loginRequest.Password, user.PasswordHash);
            if (!isCorrectPassword)
            {
                return Unauthorized();
            }


            AuthenticatedUserResponse response = await _authenticator.Authenticate(user);

            return Ok(response);

            //This was moved to the Authenticator Services.
            /*//Adding our token
            string accessToken = _accessTokenGenerator.GenerateToken(user);
            string refreshToken = _refreshTokenGenerator.GenerateToken();

            RefreshToken refreshtokenDTO = new RefreshToken()
            {
                Token = refreshToken,
                UserId = user.Id
            };

            await _refreshTokenRepository.Create(refreshtokenDTO);

            return Ok(new AuthenticatedUserResponse()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            });*/
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshRequest refreshRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequestModelState();
            }

            bool isValidRefreshToken = _refreshTokenValidator.Validate(refreshRequest.RefreshToken);
            if (!isValidRefreshToken)
            {
                return BadRequest(new ErrorResponse("Invalid refresh token"));
            }

            RefreshToken refreshTokenDTO = await _refreshTokenRepository.GetByToken(refreshRequest.RefreshToken);
            if (refreshTokenDTO == null)
            {
                return NotFound(new ErrorResponse("Invalid refresh token"));
            }

            User user = await _userRepository.GetById(refreshTokenDTO.UserId);
            if (user == null)
            {
                return NotFound(new ErrorResponse("User not found"));
            }

            AuthenticatedUserResponse response = await _authenticator.Authenticate(user);
            return Ok(response);
        }

        private IActionResult BadRequestModelState()
        {
            IEnumerable<string> errorMessages = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
            return BadRequest(errorMessages);
        }
    }
}
