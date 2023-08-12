using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Exceptions
{
    public class RestException:Exception
    {
        public RestException(HttpStatusCode statusCode, List<RestExceptionErrorItem> errors, string message=null)
        {
            Message = message;
            StatusCode = statusCode;
            Errors = errors;
        }
        public RestException(HttpStatusCode statusCode,string key , string errorMessage,string message=null)
        {
            Message = message;
            StatusCode = statusCode;
            Errors = new List<RestExceptionErrorItem>() { new RestExceptionErrorItem(key, errorMessage) };
        }
        public RestException( HttpStatusCode statusCode, string message)
        {
            Message = message;
            StatusCode = statusCode;
        }

        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<RestExceptionErrorItem> Errors { get; set; }
    }
    public class RestExceptionErrorItem
    {
        public RestExceptionErrorItem(string key, string errorMessage)
        {
            Key = key;
            ErrorMessage = errorMessage;
        }
        public string Key { get; set; }
        public string ErrorMessage { get; set; }
    }
}
