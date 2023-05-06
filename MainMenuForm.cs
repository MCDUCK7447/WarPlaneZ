using System;
using System.Drawing;
using System.Windows.Forms;
using WarPlane_Z.WarPlane_Z;

namespace WarPlane_Z
{
    public partial class MainMenuForm : Form
    {
        private Button playButton;
        private Button recordsButton;
        private Button settingsButton;
        private Button exitButton;
        private MainAirPlane airplane;
        private MainAirPlaneController controller;
        private MainAirPlaneView view;

        public MainMenuForm()
        {
            InitializeComponent();
            InitializeButtons();
            WindowState = FormWindowState.Maximized;
            InitializeAirplane();
        }
        
        private void InitializeAirplane()
        {
            airplane = new MainAirPlane(900, 500, 10);
            controller = new MainAirPlaneController(airplane);
            view = new MainAirPlaneView(airplane, @"Models\mainAirPlane.png", 100, 100);
        }

        private void InitializeButtons()
        {
            const int buttonWidth = 300;
            const int buttonHeight = 100;

            // Play button
            playButton = new Button
            {
                Size = new Size(buttonWidth, buttonHeight),
                Text = "ИГРАТЬ",
                Location = new Point((Width - buttonWidth) / 2, 170)
            };
            playButton.Click += PlayButton_Click;
            Controls.Add(playButton);

            // Records button
            recordsButton = new Button
            {
                Size = new Size(buttonWidth, buttonHeight),
                Text = "РЕКОРДЫ",
                Location = new Point((Width - buttonWidth) / 2, playButton.Bottom + 50)
            };
            recordsButton.Click += RecordsButton_Click;
            Controls.Add(recordsButton);

            // Settings button
            settingsButton = new Button
            {
                Size = new Size(buttonWidth, buttonHeight),
                Text = "НАСТРОЙКИ",
                Location = new Point((Width - buttonWidth) / 2, recordsButton.Bottom + 50)
            };
            settingsButton.Click += SettingsButton_Click;
            Controls.Add(settingsButton);

            // Exit button
            exitButton = new Button
            {
                Size = new Size(buttonWidth, buttonHeight),
                Text = "ВЫХОД",
                Location = new Point((Width - buttonWidth) / 2, settingsButton.Bottom + 50)
            };
            exitButton.Click += ExitButton_Click;
            Controls.Add(exitButton);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm(airplane, controller, view);
            this.Hide();
            gameForm.Show();
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            // TODO: Handle records button click
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // TODO: Handle settings button click
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из игры?", "Выход", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
