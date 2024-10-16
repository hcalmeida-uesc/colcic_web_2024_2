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
         var header = context.Request.Headers["Authorization"];

         DateTimeOffset now = DateTimeOffset.Now;

         Console.WriteLine("Authorization: " + header.ToString());
   
         await _next.Invoke(context);

         now = DateTimeOffset.Now;
         Console.WriteLine("Primeiro Middleware pela segunda vez + " + now);
      }
}
