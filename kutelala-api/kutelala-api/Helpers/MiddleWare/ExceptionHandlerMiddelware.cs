using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ar_helper_lib.MiddleWare
{
	public class ExceptionHandlerMiddelware
	{
        private readonly RequestDelegate _next;
		private readonly ILogger<ExceptionHandlerMiddelware> _logger;

		public ExceptionHandlerMiddelware(RequestDelegate next, ILogger<ExceptionHandlerMiddelware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Handle the exception and provide a custom response
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            var errorMessage = JsonConvert.SerializeObject(new { error = exception.Message });
            _logger.LogError(errorMessage);
            await context.Response.WriteAsync(errorMessage);
        }
    }
}
