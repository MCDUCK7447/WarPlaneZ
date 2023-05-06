using System.Windows.Forms;

namespace WarPlane_Z
{
    public class MainAirPlaneController
    {
        private MainAirPlane _airplane;

        public MainAirPlaneController(MainAirPlane airplane)
        {
            _airplane = airplane;
        }

        // Метод для обработки нажатий на клавиши управления
        public void HandleInput(Keys key)
        {
            switch (key)
            {
                case Keys.W:
                    _airplane.Accelerate();
                    break;
                case Keys.S:
                    _airplane.Decelerate();
                    break;
                case Keys.A:
                    _airplane.TurnLeft();
                    break;
                case Keys.D:
                    _airplane.TurnRight();
                    break;
            }
        }

        // Метод для обновления модели самолёта
        public void Update()
        {
            _airplane.Move(_airplane.X, _airplane.Y);
        }
    }
}