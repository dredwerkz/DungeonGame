using DungeonGame.Game.Core.Interfaces;
using DungeonGame.Game.Helpers;
using DungeonGame.Game.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonGame.Game.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGameServices(this IServiceCollection services)
        {
            services.AddTransient<ITestGameStart, TestGameStart>();
            services.AddTransient<ITestGameHelper, TestGameHelper>();

            return services;
        }
    }
}