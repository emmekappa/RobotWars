namespace RobotWars.Console
{
    using System;
    using System.Collections.Generic;
    using Utilities;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Type Arena size (ex: 5 5)");
            Arena arena = ArenaParser.Parse(Console.ReadLine());

            var robotLocationParser = new RobotLocationParser(arena);

            Console.WriteLine("Type Robot A location (ex: 1 2 N)");
            Robot robotA = robotLocationParser.Parse(Console.ReadLine());
            Console.WriteLine("Type Robot A movements (ex: LMLRM)");
            IEnumerable<IMovement> robotAMovements = MovementParser.Parse(Console.ReadLine());
            robotAMovements.ForEach(x => x.ExecuteOn(robotA));

            Console.WriteLine("Type Robot B location (ex: 1 2 N)");
            Robot robotB = robotLocationParser.Parse(Console.ReadLine());
            Console.WriteLine("Type Robot B movements (ex: LMLRM)");
            IEnumerable<IMovement> robotBMovements = MovementParser.Parse(Console.ReadLine());
            robotBMovements.ForEach(x => x.ExecuteOn(robotB));

            Console.WriteLine("{0} {1} {2}", robotA.Coordinate.X, robotA.Coordinate.Y, robotA.Direction);
            Console.WriteLine("{0} {1} {2}", robotB.Coordinate.X, robotB.Coordinate.Y, robotB.Direction);

            Console.ReadLine();
        }
    }
}