using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;

namespace WarPlane_Z
{
    using System.Drawing;
    using System.Windows.Forms;

    namespace WarPlane_Z
    {
        public class MainAirPlaneView
        {
            private PictureBox _airPlanePicture;
            private MainAirPlane _airplane;

            public MainAirPlaneView(MainAirPlane airplane, string imageFilePath, int width, int height)
            {
                _airplane = airplane;
                _airPlanePicture = new PictureBox();
                _airPlanePicture.Image = Image.FromFile(imageFilePath);
                _airPlanePicture.Size = new Size(width, height);
                _airPlanePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                _airPlanePicture.BackColor = Color.Transparent;
                _airPlanePicture.Location = new Point((int)_airplane.X - width / 2, (int)_airplane.Y - height / 2);
            }

            public PictureBox AirPlanePicture => _airPlanePicture;

            public void Update()
            {
                _airPlanePicture.Left = (int)_airplane.X - _airPlanePicture.Width / 2;
                _airPlanePicture.Top = (int)_airplane.Y - _airPlanePicture.Height / 2;
                _airPlanePicture.Invalidate();
            }
        }
    }
}