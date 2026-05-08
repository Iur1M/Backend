using Microsoft.AspNetCore.Diagnostics;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Exceptions;
using System.Net;

namespace ProjectBackend.Exceptions
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            _logger.LogError(exception, exception.Message);

            switch (exception)
            {
                case ValidationException validationException:
                    {
                        httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                        await httpContext.Response.WriteAsJsonAsync(new
                        {
                            statusCode = 400,
                            titel = "Validation Error",
                            errors = validationException.Errors
                        }, cancellationToken);

                        return true;
                    }

                case BadHttpRequestException:
                    {
                        var response = new ErrorResponse
                        {
                            StatusCode = (int)HttpStatusCode.BadRequest,
                            Titel = exception.GetType().Name,
                            Message = exception.Message
                        };

                        httpContext.Response.StatusCode = response.StatusCode;
                        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
                        return true;
                    }

                default:
                    {
                        var response = new ErrorResponse
                        {
                            StatusCode = (int)HttpStatusCode.InternalServerError,
                            Titel = "Internal Server Error",
                            Message = exception.Message
                        };

                        httpContext.Response.StatusCode = response.StatusCode;
                        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
                        return true;
                    }
            }
        }
    }
}

