using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonWorld.Data;

namespace PokemonWorld.Migrations {
  [DbContext(typeof(PokemonWorldContext))]
  partial class PokemonWorldContextModelSnapshot : ModelSnapshot {
    protected override void BuildModel(ModelBuilder modelBuilder) {
      modelBuilder.HasAnnotation("ProductVersion", "6.0.1")
          .HasAnnotation("Relational:MaxIdentifierLength", 128);

      SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

      modelBuilder.Entity("PokemonWorld.Models.Pokemon", b => {
        b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("int");

        SqlServerPropertyBuilderExtensions.UseIdentityColumn(
            b.Property<int>("Id"), 1L, 1);

        b.Property<string>("Genre").HasColumnType("nvarchar(max)");

        b.Property<decimal>("Name").HasColumnType("nvarchar(max)");

        b.Property<DateTime>("PokemonReleaseDate").HasColumnType("datetime2");

        b.Property<string>("Strenght").HasColumnType("decimal(2,10)");

        b.HasKey("Id");

        b.ToTable("Pokemon");
      });
    }
  }
}