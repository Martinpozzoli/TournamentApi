using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Data;
using Repository.Interface;
using Repository.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//--------------JWT----------------------------- 

    // TODO: JWT ...

//--------------Services------------------------ 
builder.Services.AddDbContext<TournamentsDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStringEF")));

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
builder.Services.AddScoped<IUserRepository, UserRepository>();



builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(x => new UnitOfWork(
    x.GetRequiredService<TournamentsDbContext>(),
    x.GetRequiredService<IClubRepository>(),
    x.GetRequiredService<IMatchRepository>(),
    x.GetRequiredService<IPlayerRepository>(),
    x.GetRequiredService<IStadiumRepository>(), 
    x.GetRequiredService<ITournamentRepository>(),
    x.GetRequiredService<IUserRepository>()
));
//---------------------------------------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
