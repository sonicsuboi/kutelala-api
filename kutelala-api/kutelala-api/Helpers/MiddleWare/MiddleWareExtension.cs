using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ar_helper_lib.MiddleWare
{
	public static class MiddleWareExtension
	{
		public static void UseMiddleWareExtension(this IApplicationBuilder app)
		{
			app.UseMiddleware<ExceptionHandlerMiddelware>();

		}

	}
}
