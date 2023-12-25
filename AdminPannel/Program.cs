var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    //endpoints.MapAreaControllerRoute(
    // "AdminSite",
    // "AdminSite",
    // "Admin/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
         name: "default",
         pattern: "{controller=HomePage}/{action=Index}/{id?}");
});

app.MapRazorPages();


app.Run();
