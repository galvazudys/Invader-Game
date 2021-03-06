﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            try
            {
                Path path = new Path(
                    new[] {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    }

                    );

                IInvader[] invaders =
                    {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                };

                Tower[] towers =
                {
                    new SniperTower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3,map)),
                    new Tower(new MapLocation(5,3,map))
                };

                Level leve1 = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = leve1.Play();

                Console.WriteLine("Player" + (playerWon ? "won" : "lost"));




            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenceException)
            {
                Console.WriteLine("Unhandled TreehouseDefenceException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }

        }
    }
}
