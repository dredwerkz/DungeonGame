﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DungeonGame.Game.Extensions;
using DungeonGame.Game.Core.Interfaces;

namespace DungeonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddGameServices();
            })
            .Build();

            var game = host.Services.GetRequiredService<ITestGameService>();

            game.StartGame();
        }
    }
}
