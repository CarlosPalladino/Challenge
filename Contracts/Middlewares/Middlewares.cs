namespace Contracts.Middlewares
{
    //public class Middlewares
    //{
    //    public class CustomMiddleware
    //    {
    //        private readonly RequestDelegate _next;
    //        private readonly ILogger<CustomMiddleware> _loger;

    //        public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> loger)
    //        {
    //            _next = next;
    //            _loger = loger;
    //        }

    //        public async Task Invoke(HttpContext context, IExceptionService exceptionService)
    //        {
    //            try
    //            {
    //                await _next(context);
    //            }
    //            catch (BadRequestException badRequestException)
    //            {
    //                await exceptionService.GetBadRequestExceptionResponseAsync(context, badRequestException);
    //            }
    //            catch (NotFoundException notFoundRequestException)
    //            {
    //                await exceptionService.GetNotFoundExceptionResponseAsync(context, notFoundRequestException);
    //            }
    //            catch
    //            {
    //                throw;
    //            }
    //        }

    //    }
    //}
}
