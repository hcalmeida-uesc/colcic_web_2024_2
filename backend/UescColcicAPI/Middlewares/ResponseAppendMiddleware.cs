using System;

namespace UescColcicAPI.Middlewares;

public class ResponseAppendMiddleware
{
      private readonly RequestDelegate _next;
   
      public ResponseAppendMiddleware(RequestDelegate next)
      {
         _next = next;
      }
   
      public async Task Invoke(HttpContext context)
      {
         context.Response.Headers.Append("X-App-Name", "ColcicAPIUesc");
         Console.WriteLine("Segundo Middleware");
         
   
         //await _next.Invoke(context);
      }
}
