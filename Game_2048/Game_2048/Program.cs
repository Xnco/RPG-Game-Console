﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            GameManager game = new GameManager();
            game.InitMap();

            game.GameLogic();
        }
    }
}
