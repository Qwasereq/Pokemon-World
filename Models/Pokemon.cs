using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonWorld.Models
{
public class Pokemon
{
    public int Id {
        get;
        set;
    }
    public string? Name {
        get;
        set;
    }
    public DateTime PokemonReleaseDate {
        get;
        set;
    }
    public string? Genre {
        get;
        set;
    }
    public decimal Strenght {
        get;
        set;
    }
}
}