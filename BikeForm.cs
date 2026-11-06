using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BikeForm : Form
    {
        public bool LogoutRequested { get; private set; }

        public BikeForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start;
            int end;

            bool startOk = int.TryParse(txtStart.Text.Trim(), out start);
            bool endOk = int.TryParse(txtEnd.Text.Trim(), out end);

            if (!startOk || !endOk)
            {
                ShowError("Please enter whole numbers only (no decimals).");
                return;
            }

            if (start < 0 || start > 23)
            {
                ShowError("Start time must be between 0 and 23.");
                return;
            }

            if (end < 1 || end > 24)
            {
                ShowError("End time must be between 1 and 24.");
                return;
            }

            if (start >= end)
            {
                ShowError("Start time must be less than end time.");
                return;
            }

            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                int rate;

                if (hour < 7)
                {
                    rate = 500;
                }
                else if (hour < 14)
                {
                    rate = 1000;
                }
                else if (hour < 19)
                {
                    rate = 1500;
                }
                else if (hour < 21)
                {
                    rate = 1000;
                }
                else
                {
                    rate = 500;
                }

                total = total + rate;
            }

            txtTotal.Text = total.ToString();

            MessageBox.Show("Rental from " + start + "h to " + end + "h" + Environment.NewLine +
                "Total to pay: " + total + " RWF", "Bicycle renting",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message)
        {
            txtTotal.Clear();
            MessageBox.Show(message, "Input error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
