using Asp_Net_study.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// * Add custom component ? Seems no need in ASP.Net 6 ?
//builder.Services.AddServerSideBlazor();

// * Add custom api router
builder.Services.AddControllers();

// * Add custom service to the container.
builder.Services.AddTransient<JsonFileProductService>();

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

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// * Map customer api router
app.MapControllers();

// * Map customer component ? Seems no need in ASP.Net 6 ?
//app.MapBlazorHub();

app.Run();
