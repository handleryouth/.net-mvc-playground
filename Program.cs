using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseExceptionHandler("/Error/500");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();



}

//for redirecting using status code.
app.UseStatusCodePagesWithRedirects("/Error/{0}");


// app.Use(async (ctx, next) =>
// {
//     await next();

//     if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
//     {
//         //Re-execute the request so the user gets the error page
//         string originalPath = ctx.Request.Path.Value;
//         ctx.Items["originalPath"] = originalPath;
//         ctx.Request.Path = "/Error/404";
//         await next();
//     }
// });


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//routing format and default value if accessing the page without any format.
// for example: http://localhost:5081/
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
