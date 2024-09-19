using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Helpers;
using DungeonGame.Game.Services;
using DungeonGame.Game.Services.Character;
using DungeonGame.Game.Services.Dice;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonGame.Game.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGameServices(this IServiceCollection services)
        {
            services.AddTransient<ITestGameService, TestGameService>();
            services.AddTransient<ITestGameHelper, TestGameHelper>();
            services.AddTransient<IDiceService, DiceService>();
            services.AddTransient<IDiceHelper, DiceHelper>();
            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<ICharacterHelper, CharacterHelper>();

            return services;
        }
    }
}