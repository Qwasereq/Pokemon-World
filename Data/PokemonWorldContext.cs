#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonWorld.Models;

namespace PokemonWorld.Data
{
public class PokemonWorldContext : DbContext
{
    public PokemonWorldContext (DbContextOptions<PokemonWorldContext> options)
        : base(options)
    {
    }

    public DbSet<PokemonWorld.Models.Pokemon> Pokemon {
        get;
        set;
    }
}
}