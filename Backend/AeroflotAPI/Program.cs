using AeroflotAPI.Reporting.Services;
using AeroflotAPI.Repositories;
using AeroflotAPI.Services;
using AeroflotAPI.Services.RfId;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.ConfigureHttpsDefaults(options =>
        options.ClientCertificateMode = ClientCertificateMode.RequireCertificate);
});
builder.Services.AddDbContext<RfidContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("RfidConnection")));
builder.Services.AddDbContext<ReportContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("RfidConnection")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddApiVersioning();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Auth
builder.Services.AddTransient<IRepository, Repository>();
//Rfid
builder.Services.AddTransient<IRfidRepository, RfidRepository>();
builder.Services.AddScoped<IRfidService, RfidService>();
//Report
builder.Services.AddTransient<IReportRepository, ReportRepository>();
builder.Services.AddScoped<IReportService, ReportService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();