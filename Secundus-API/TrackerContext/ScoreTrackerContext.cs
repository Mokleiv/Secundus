using Microsoft.EntityFrameworkCore;
using Secundus_API.Entities;

namespace Secundus_API.TrackerContext;

public class ScoreTrackerContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public ScoreTrackerContext(DbContextOptions<ScoreTrackerContext> options) : base(options) { }
}
