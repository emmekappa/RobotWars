namespace RobotWars.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arena = new Arena(5, 5);
            var robotA = new Robot(new Coordinate(1, 2), new NorthDirection(), new Arena(5, 5));
            var robotB = new Robot(new Coordinate(3, 3), new EastDirection(), new Arena(5, 5));

            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.MoveForward();

            robotB.MoveForward();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.MoveForward();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.RotateRight();
            robotB.MoveForward();

            System.Console.WriteLine("RobotA X: {0} Y: {1} Facing: {2}", robotA.Coordinate.X, robotA.Coordinate.Y,
                                     robotA.Direction);
            System.Console.WriteLine("RobotA X: {0} Y: {1} Facing: {2}", robotB.Coordinate.X, robotB.Coordinate.Y,
                                     robotB.Direction);
        }
    }
}