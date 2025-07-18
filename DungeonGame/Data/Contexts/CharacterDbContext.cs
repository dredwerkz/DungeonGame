using DungeonGame.Data.Core.Interfaces;
using DungeonGame.Game.Core.Models.Character;
using Microsoft.EntityFrameworkCore;

namespace DungeonGame.Data.Contexts;

public class CharacterDbContext(IDictionaryConverter dictionaryConverter) : DbContext
{
    public DbSet<PlayerCharacter> PlayerCharacters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dungeonGame.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlayerCharacter>(entity =>
        {
            entity.HasKey(pc => pc.Name);  // Assuming Name is unique

            entity.Property(pc => pc.PlayerClass).IsRequired();
            entity.Property(pc => pc.Level).IsRequired();
            entity.Property(pc => pc.Initiative).IsRequired();

            // Convert Dictionary to a string and store it in the database
            entity.Property(pc => pc.Attributes).HasConversion(
                v => dictionaryConverter.ConvertDictionaryToString(v),
                v => dictionaryConverter.ConvertStringToDictionary(v)
            );
        });
    }
}