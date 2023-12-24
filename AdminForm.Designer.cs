namespace WinFormsApp1
{
    partial class AdminForm
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
            panel1 = new Panel();
            label1 = new Label();
            exitButton = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 370);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -2);
            label1.Name = "label1";
            label1.Size = new Size(752, 45);
            label1.TabIndex = 8;
            label1.Text = "Панель администратора";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OldLace;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Firebrick;
            exitButton.Location = new Point(610, -2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(121, 45);
            exitButton.TabIndex = 9;
            exitButton.Text = "Выйти";
            exitButton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label exitButton;
    }
}