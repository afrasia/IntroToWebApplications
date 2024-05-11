namespace IntroToWebApplications.Static;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseDefaultFiles();

        app.UseStaticFiles();

        app.UseRouting();

        app.Run();
    }
}
