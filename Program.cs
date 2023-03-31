using Blog.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.LoadConfiguration();
builder.ConfigureAuthentication();
builder.ConfigureMvc();
builder.ConfigureServices();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogAPI", Version = "v1" });
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();
app.UseResponseCompression();

app.UseSwagger();
app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog V1");
	    opt.RoutePrefix = string.Empty;
    });

app.Run();