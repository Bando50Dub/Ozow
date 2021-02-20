using GameOfLife;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int columns;
            int rows;
            int generations; 
            if (int.TryParse(ConfigurationManager.AppSettings["cols"], out columns) &&
                int.TryParse(ConfigurationManager.AppSettings["rows"], out rows) &&
                int.TryParse(ConfigurationManager.AppSettings["generations"], out generations)
                )
            {
                LifeGame sim = new LifeGame(columns, rows);

                for (int g = 0; g < generations; g++)
                {
                    sim.DrawAndGrow();
                    System.Threading.Thread.Sleep(500);
                }
            }
            else
            {
                Console.WriteLine("Please configure the game first");
            }
            
            Console.ReadKey();
        }
    }
}
