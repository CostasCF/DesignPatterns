using HealthChecks.UI.Client;
using HEMP_Demo;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();
// add healthChecks to the container
// Health status for URI's and custom checks using ToDoHealthCheck
builder.Services.AddHealthChecks()
    .AddUrlGroup(new Uri("https://www.google.gr/?hl=el"),name: "base URL", failureStatus: HealthStatus.Degraded)
    .AddCheck<TodoHealthCheck>("Todo Health Check", failureStatus: HealthStatus.Unhealthy);

// creating a UI to display json information nicely
builder.Services.AddHealthChecksUI(opt =>
{
    opt.SetEvaluationTimeInSeconds(10); //time in seconds between check    
    opt.MaximumHistoryEntriesPerEndpoint(60); //maximum history of checks    
    opt.SetApiMaxActiveRequests(1); //api requests concurrency    
    opt.AddHealthCheckEndpoint("default api", "/api/health"); //map health check api
})
.AddInMemoryStorage();

var app = builder.Build();
//Mapping Health Checks UI
//useful information
// https://localhost:7003/healthchecks-ui#/healthchecks
//https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks/issues/494
//https://www.c-sharpcorner.com/article/health-monitoring-in-asp-net-core/
app.MapHealthChecksUI(opt => { opt.ApiPath = "/hc-ui"; });

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// creating health status in json format

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    //adding a health check endpoint
    endpoints.MapHealthChecks("/api/health",
        //returning status in json format
        new HealthCheckOptions()
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.
                        WriteHealthCheckUIResponse
        });

});

//

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


