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
            services.AddSingleton<ITestGameService, TestGameService>();
            services.AddSingleton<ITestGameHelper, TestGameHelper>();
            services.AddSingleton<IDiceService, DiceService>();
            services.AddSingleton<IDiceHelper, DiceHelper>();
            services.AddSingleton<ICharacterService, CharacterService>();
            services.AddSingleton<ICharacterHelper, CharacterHelper>();

            return services;
        }
    }
}