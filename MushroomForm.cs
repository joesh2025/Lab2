using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public bool LogoutRequested { get; private set; }

        public MushroomForm()
        {
            InitializeComponent();
        }

        private bool Ask(string question)
        {
            DialogResult answer = MessageBox.Show(question, "Mushroom guesser",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return answer == DialogResult.Yes;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string result;

            if (!Ask("Does your mushroom grow in a forest?"))
            {
                if (Ask("Does your mushroom have a convex cup?"))
                {
                    result = "Agaric jaunissant";
                }
                else
                {
                    result = "Coprin chevelu";
                }
            }
            else
            {
                if (Ask("Does your mushroom have a convex cup?"))
                {
                    if (Ask("Does your mushroom have a ring?"))
                    {
                        result = "Amanite tue-mouche";
                    }
                    else
                    {
                        result = "Pied bleu";
                    }
                }
                else
                {
                    if (Ask("Does your mushroom have gills?"))
                    {
                        result = "Girolle";
                    }
                    else
                    {
                        result = "Cepe de bordeaux";
                    }
                }
            }

            lblResult.Text = "Your mushroom is: " + result;

            MessageBox.Show("Your mushroom is: " + result, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested = true;
            Close();
        }
    }
}
