using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;

namespace Graos_API.Configurations
{
    public class ApiLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private ILogRequisicoesRepository _apiLogService;

        public ApiLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ILogRequisicoesRepository apiLogService)
        {
            try
            {
                _apiLogService = apiLogService;

                var request = httpContext.Request;
                if (request.Method != "GET" && !request.Path.ToString().ToLower().Contains("login") && !request.Path.ToString().ToLower().Contains("swagger"))
                {
                    var stopWatch = Stopwatch.StartNew();
                    var requestTime = DateTime.UtcNow;
                    var requestBodyContent = await ReadRequestBody(request);
                    var originalBodyStream = httpContext.Response.Body;
                    using (var responseBody = new MemoryStream())
                    {
                        var response = httpContext.Response;
                        response.Body = responseBody;
                        await _next(httpContext);
                        stopWatch.Stop();

                        string responseBodyContent = null;
                        responseBodyContent = await ReadResponseBody(response);
                        await responseBody.CopyToAsync(originalBodyStream);

                        await SafeLog(requestTime,
                            stopWatch.ElapsedMilliseconds,
                            response.StatusCode,
                            request.Method,
                            request.Path,
                            request.QueryString.ToString(),
                            requestBodyContent,
                            responseBodyContent);

                        await apiLogService.Commit();
                    }
                }
                else
                {
                    await _next(httpContext);
                }
            }
            catch (Exception)
            {
                await _next(httpContext);
            }
        }

        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            request.EnableBuffering();
            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            var bodyAsText = Encoding.UTF8.GetString(buffer);
            request.Body.Seek(0, SeekOrigin.Begin);

            return bodyAsText;
        }

        private async Task<string> ReadResponseBody(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var bodyAsText = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0, SeekOrigin.Begin);

            return bodyAsText;
        }

        private Task SafeLog(DateTime requestTime,
                    long responseMillis,
                    int statusCode,
                    string method,
                    string path,
                    string queryString,
                    string requestBody,
                    string responseBody)
        {

            _apiLogService.Create(new LogRequisicoes_tb
            {
                RequestTime = requestTime,
                ResponseMillis = responseMillis,
                StatusCode = statusCode,
                Method = method,
                Path = path,
                QueryString = queryString,
                RequestBody = requestBody,
                ResponseBody = responseBody
            });

            return Task.CompletedTask;
        }
    }
}
