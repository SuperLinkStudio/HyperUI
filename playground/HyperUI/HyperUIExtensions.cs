using Microsoft.Extensions.FileProviders;

namespace HyperUI
{
    public static class HyperUIExtensions
    {
        /// <summary>
        /// Injects the HyperUI framework static assets into the application.
        /// </summary>
        public static IApplicationBuilder UseHyperUI(this WebApplication app)
        {
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(app.Environment.ContentRootPath, "HyperUI/Assets")
                ),
                RequestPath = "/hyperui"
            });

            return app;
        }
    }
}
