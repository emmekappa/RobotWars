using System.Collections.Generic;
using RobotWars.Utilities;

namespace RobotWars.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Type Arena size (ex: 5 5)");
            Arena arena = ArenaParser.Parse(System.Console.ReadLine());

            var robotLocationParser = new RobotLocationParser(arena);

            System.Console.WriteLine("Type Robot A location (ex: 1 2 N)");
            Robot robotA = robotLocationParser.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Type Robot A movements (ex: LMLRM)");
            IEnumerable<IMovement> robotAMovements = MovementParser.Parse(System.Console.ReadLine());
            robotAMovements.ForEach(x => x.ExecuteOn(robotA));

            System.Console.WriteLine("Type Robot B location (ex: 1 2 N)");
            Robot robotB = robotLocationParser.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Type Robot B movements (ex: LMLRM)");
            IEnumerable<IMovement> robotBMovements = MovementParser.Parse(System.Console.ReadLine());
            robotBMovements.ForEach(x => x.ExecuteOn(robotB));

            System.Console.WriteLine("{0} {1} {2}", robotA.Coordinate.X, robotA.Coordinate.Y, robotA.Direction);
            System.Console.WriteLine("{0} {1} {2}", robotB.Coordinate.X, robotB.Coordinate.Y, robotB.Direction);

            System.Console.ReadLine();
        }
    }
}