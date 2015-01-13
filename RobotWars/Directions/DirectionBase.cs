namespace RobotWars
{
    /// <summary>
    ///     A Strategy rappresenting the Robot direction and his responses to the behaviors (moving and rotating).
    /// </summary>
    /// All methods are internal because they are wrapped by the Robot entity.
    /// <seealso cref="Robot" />
    public abstract class DirectionBase
    {
        protected internal abstract Coordinate MoveForward(Coordinate coordinate);
        protected internal abstract DirectionBase RotateRight();
        protected internal abstract DirectionBase RotateLeft();
    }
}