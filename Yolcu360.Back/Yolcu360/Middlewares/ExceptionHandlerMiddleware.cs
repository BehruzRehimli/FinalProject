using Yolcu360.Service.Exceptions;

namespace Yolcu360.API.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exp)
            {
                var response = context.Response;
                response.ContentType= "application/json";
                List<RestExceptionErrorItem> errors= new List<RestExceptionErrorItem>();
                string message=exp.Message;
                switch (exp)
                {
                    case RestException re:
                        response.StatusCode =(int)re.StatusCode;
                        errors=re.Errors;
                        message=re.Message;
                        break;
                    default:
                        response.StatusCode =500;
                        break;
                }
                await response.WriteAsJsonAsync(new { message, errors });
            }
        }
    }
}
