using System;
using System.Windows.Forms;
using WarPlane_Z.WarPlane_Z;

namespace WarPlane_Z
{
    public class GameForm : Form
    {
        private readonly MainAirPlane _airplane;
        private readonly MainAirPlaneController _controller;
        private readonly MainAirPlaneView _view;
        private System.Timers.Timer _timer;

        private const double FpsInterval = 60;

        public GameForm(MainAirPlane plane, MainAirPlaneController controller, MainAirPlaneView view)
        {
            _airplane = plane;
            _controller = controller;
            _view = view;
            _timer = new System.Timers.Timer(FpsInterval);

            Controls.Add(_view.AirPlanePicture);

            KeyDown += OnKeyPress;
            _timer.Elapsed += Timer_Tick;
            
            WindowState = FormWindowState.Maximized;
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            _controller.HandleInput(e.KeyCode);
            _view.Update();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _controller.Update();
            _view.Update();
        }
    }

}