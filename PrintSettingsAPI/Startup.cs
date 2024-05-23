namespace PrintSettingsAPI;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseCors(builder => builder
            .WithOrigins("https://0.0.0.0")
            .AllowAnyMethod()
            .AllowAnyHeader()
            );

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
