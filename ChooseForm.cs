using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public bool LogoutRequested { get; private set; }

        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Hide();

            using (BikeForm bike = new BikeForm())
            {
                bike.ShowDialog();

                if (bike.LogoutRequested)
                {
                    LogoutRequested = true;
                    Close();
                }
                else
                {
                    Show();
                }
            }
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Hide();

            using (MushroomForm mushroom = new MushroomForm())
            {
                mushroom.ShowDialog();

                if (mushroom.LogoutRequested)
                {
                    LogoutRequested = true;
                    Close();
                }
                else
                {
                    Show();
                }
            }
        }
    }
}
