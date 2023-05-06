using System;

namespace WarPlane_Z
{
    public class MainAirPlane
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        private float Speed { get; set; }

        public MainAirPlane(float x, float y, float speed)
        {
            X = x;
            Y = y;
            Speed = speed;
        }
        
        public void Move(float x, float y)
        {
            X += x;
            Y += y;
        }

        public void TurnLeft()
        {
            X -= Speed;
        }

        public void TurnRight()
        {
            X += Speed;
        }

        public void Accelerate()
        {
            Y -= Speed;
        }

        public void Decelerate()
        {
            Y += Speed;
        }
    }
}