﻿using System.Collections.Generic;
using Attribulator.ModScript.API;

namespace Attribulator.Plugins.ModScript.Commands
{
    public class GameModScriptCommand : BaseModScriptCommand
    {
        public string Game { get; private set; }

        public override void Parse(List<string> parts)
        {
            Game = parts[1];
        }

        public override void Execute(DatabaseHelper databaseHelper)
        {
            //
        }
    }
}