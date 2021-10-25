using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Genshin.Models
{
  public class GenshinContext : DbContext
  {
    public DbSet<Character> Characters { get; set; }

    public GenshinContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}