using InventoryCheckPlatform.Components;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace InventoryCheckPlatform
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options => {
                   options.Cookie.Name = "auth_token";
                   options.LoginPath = "/login";
                   options.Cookie.MaxAge = TimeSpan.FromMinutes(60);
                   options.AccessDeniedPath = "/access-denied";
               });
            builder.Services.AddAuthorization();
            builder.Services.AddCascadingAuthenticationState();

            builder.Services.AddBlazorBootstrap();

            var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAntiforgery();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
