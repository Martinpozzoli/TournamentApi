using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Data;
using Model.Interface;
using Repository.UnitOfWork;
using TournamentApi.Middlewares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(
   /*
    options =>
    {
        options.Filters.Add<CustomExceptionFilter>();
    }
    */
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen();

//-------------------------- JWT Swagger ---------------------------------
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Tournament API", Version = "v0.1" });
    option.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Ingrese Token",
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
});
//-----------------------------------------------------------------------------

//-----------------------------JWT---------------------------------------------
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
//----------------------------------------------------------------------------

//--------------Services------------------------
builder.Services.AddDbContext<TournamentsDbContext>(
    op => op.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStringEF"))
);

/*
 * Contrib Claudio - REVISAR
 * builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Repository")));
 */

//--------------Injections----------------------
builder.Services.AddScoped<IClubRepository, ClubRepository>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IStadiumRepository, StadiumRepository>();
builder.Services.AddScoped<ITournamentRepository, TournamentRepository>();
builder.Services.AddScoped<IStandingRepository, StandingRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(
    x =>
        new UnitOfWork(
            x.GetRequiredService<TournamentsDbContext>(),
            x.GetRequiredService<IClubRepository>(),
            x.GetRequiredService<IMatchRepository>(),
            x.GetRequiredService<IPlayerRepository>(),
            x.GetRequiredService<IStadiumRepository>(),
            x.GetRequiredService<ITournamentRepository>(),
            x.GetRequiredService<IStandingRepository>(),
            x.GetRequiredService<IUserRepository>()
        )
);

//---------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<LoggingMiddleware>();

app.Run();
