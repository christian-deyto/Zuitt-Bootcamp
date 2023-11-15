namespace AuthenticationServer.API.Models.Responses
{
    public class ErrorResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; }

        //Create 2 Constructors
        //This will holding a single error message.
        public ErrorResponse(string errorMessage) : this(new List<string>() { errorMessage }) { }

        //This will take a list of error messages.
        public ErrorResponse(IEnumerable<string> errorMessages) 
        { 
            ErrorMessages = errorMessages;
        } 


    }
}
