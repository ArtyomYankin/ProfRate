using Microsoft.EntityFrameworkCore;
using PR.Data;
using PR.Repository;
using PR.Repository.DataContext;
using PR.Repository.DisciplineRate;
using PR.Repository.DisciplineRepo;
using PR.Repository.TeacherRate;
using PR.Repository.TeacherRepo;
using PR.Service;
using PR.Service.DiciplineService;
using PR.Service.DisciplineService;
using PR.Service.EmailSender;
using PR.Service.TeacherRate;
using PR.Service.TeacherService;

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    optionsBuilder => optionsBuilder.MigrationsAssembly("ProffRate"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmailService, EmailSender>();
builder.Services.AddScoped<ITeacherRateRepo, TeacherRateRepo>();
builder.Services.AddScoped<ITeacherRateService, TeacherRateService>();
builder.Services.AddScoped<IDisciplineRepo, DisciplineRepo>();
builder.Services.AddScoped<IDisciplineRateRepo, DisciplineRateRepo>();
builder.Services.AddScoped<IDisciplineService, DisciplineService>();
builder.Services.AddScoped<IDisciplineRateService, DisciplineRateService>();
builder.Services.AddScoped<ITeacherDisciplineRepo, TeacherDisciplineRepo>();
builder.Services.AddScoped<ITeacherDisciplineService, TeacherDisciplineService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
        });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options =>
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
