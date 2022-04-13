// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace SalesWebMvc
// {
//     public class Startup
//     {
//         public IConfiguration Configuration { get; }

//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration
//         }

//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.Configure<CookiePolicyOptions>(options =>
//             {
//                 options.CheckConsentNeeded = context => true;
//                 options.MinimumSameSitePolicy = SameSiteMode.None;
//             });

//             services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
//         }

//         public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Home/Error");
//                 app.UseHsts();
//             }

//             app.UseHttpsRedirection();
//             app.UseStaticFiles();
//             app.UseCookiePolicy();

//             app.UseMvc(routes =>
//             {
//                 routes.MapRoute(
//                     name: "default",
//                     template: "{controller=Home}/{action=Index}/{id?}"
//                 );
//             });
//         }
//     }
// }