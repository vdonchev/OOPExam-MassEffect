﻿namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            var ship = this.GetStarshipByName(shipName);

            Console.WriteLine(ship.ToString());
        }
    }
}
