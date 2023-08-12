using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Yolcu360.API.Middlewares;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Data;
using Yolcu360.Data.Repositories;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Implementations;
using Yolcu360.Service.Interfaces;
using Yolcu360.Service.Mail;
using Yolcu360.Service.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errors = context.ModelState.Where(x => x.Value?.Errors.Count() > 0)
            .Select(x => new RestExceptionErrorItem(x.Key, x.Value?.Errors.First().ErrorMessage)).ToList();

        return new BadRequestObjectResult(new { message = (string)null, errors = errors });

    };
});
builder.Services.AddDbContext<Yolcu360DbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequiredLength = 8;
}).AddDefaultTokenProviders().AddEntityFrameworkStores<Yolcu360DbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
   {
     new OpenApiSecurityScheme
     {
       Reference = new OpenApiReference
       {
         Type = ReferenceType.SecurityScheme,
         Id = "Bearer"
       }
      },
      new string[] { }
    }
  });
});
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<BrandCreateDtoValidator>();
builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ITypeRepository, TypeRepository>();
builder.Services.AddScoped<ITypeService, TypeService>();
builder.Services.AddTransient<IMailService, MailService>();
builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
builder.Services.AddTransient<IReviewService, ReviewService>();
builder.Services.AddTransient<ICountryRepository, CountryRepository>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IOfficeRepository, OfficeRepository>();
builder.Services.AddTransient<IOfficeService, OfficeService>();

builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddCors(opt => opt.AddDefaultPolicy(policy =>
{
    policy.AllowAnyMethod().AllowAnyHeader().AllowCredentials().SetIsOriginAllowed(origin => true);
}));
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidIssuer = builder.Configuration.GetSection("JWT:Issuer").Value,
        ValidAudience = builder.Configuration.GetSection("JWT:Audience").Value,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:Secret").Value))
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization(); 
app.UseStaticFiles();

app.MapControllers();
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();
