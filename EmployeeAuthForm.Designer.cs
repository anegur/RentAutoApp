namespace WinFormsApp1
{
    partial class EmployeeAuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            to_back_button = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-8, -2);
            label1.Name = "label1";
            label1.Size = new Size(752, 45);
            label1.TabIndex = 4;
            label1.Text = "Сотрудник";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-8, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 372);
            panel1.TabIndex = 5;
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(-8, -2);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(121, 45);
            to_back_button.TabIndex = 6;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // EmployeeAuthForm
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "EmployeeAuthForm";
            Text = "EmployeeAuthForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label to_back_button;
    }
}