using Microsoft.EntityFrameworkCore;
using Secundus_API.Entities;
using Secundus_API.TrackerContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ScoreTrackerContext>(x => x.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ScoreTracker"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/Create", (ScoreTrackerContext Dbcontext) =>
{
    var Game = new Game() { SondreScore = 1, ErnstScore = 2, PetterScore = 0 };
    Dbcontext.Add(Game);
    Dbcontext.SaveChanges();
    return "kugnisse";
});

app.Run();