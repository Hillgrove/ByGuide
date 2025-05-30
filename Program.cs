using ByGuide.Service;
using ByGuide.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPostService, PostService>();
builder.Services.AddSingleton<IExperienceService, ExperienceService>();
builder.Services.AddSingleton<ITuristService, TuristService>();
builder.Services.AddTransient<JsonFilePostService>();
builder.Services.AddTransient<JsonFileExperienceService>();
builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddTransient<JsonFileEventService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseStatusCodePagesWithReExecute("/NotFound");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
