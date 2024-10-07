using System;

namespace UescColcicAPI.Middlewares;

public class GetRequestHeaderMiddleware
{
      private readonly RequestDelegate _next;
   
      public GetRequestHeaderMiddleware(RequestDelegate next)
      {
         _next = next;
      }
   
      public async Task Invoke(HttpContext context)
      {
         var header = context.Request.Headers["X-App-Login-User"];

         DateTimeOffset now = DateTimeOffset.Now;

         Console.WriteLine("Primeiro Middleware + " + now);
   
         await _next.Invoke(context);

         now = DateTimeOffset.Now;
         Console.WriteLine("Primeiro Middleware pela segunda vez + " + now);
      }
}
