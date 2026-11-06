namespace Lab2
{
    partial class ChooseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "What do you want to do?";
            this.btnBicycle.Location = new System.Drawing.Point(40, 95);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(150, 60);
            this.btnBicycle.TabIndex = 1;
            this.btnBicycle.Text = "Bicycle";
            this.btnBicycle.UseVisualStyleBackColor = true;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            this.btnMushroom.Location = new System.Drawing.Point(220, 95);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(150, 60);
            this.btnMushroom.TabIndex = 2;
            this.btnMushroom.Text = "Mushroom";
            this.btnMushroom.UseVisualStyleBackColor = true;
            this.btnMushroom.Click += new System.EventHandler(this.btnMushroom_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.btnMushroom);
            this.Controls.Add(this.btnBicycle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;
    }
}
