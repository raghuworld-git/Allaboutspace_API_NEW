
namespace Core
{
    public class CustomException : Exception
    {

        public CustomException(int? customStatusCode, object? customMessage = null) =>
       (CustomStatusCode, CustomMessage) = (customStatusCode, customMessage);

        public CustomException(CustomException ex)
        {
            this.CustomStatusCode = ex.CustomStatusCode;
            this.CustomMessage = ex.CustomMessage;
        }
        public int? CustomStatusCode { get; set; }
        public object? CustomMessage { get; set; }
    }
}
