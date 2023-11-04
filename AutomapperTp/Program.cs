using AutomapperTp.Profiles;
using AutomapperTp.Repositories;
using AutomapperTp.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IarticuloService, ArticuloService>();
builder.Services.AddScoped<IarticuloRepository, ArticuloRepository>();
builder.Services.AddAutoMapper(typeof(ArticuloProfile));


var app = builder.Build();

// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
