using Contracts.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Contracts.Middlewares.MiddlewaresService
{
    public interface IExceptionService
    {
        Task GetBadRequestExceptionResponseAsync(HttpContext context, BadRequestException badRequestException);
        Task GetNotFoundExceptionResponseAsync(HttpContext context, NotFoundException notFoundRequestException);
    }
}
