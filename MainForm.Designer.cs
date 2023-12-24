namespace WinFormsApp1
{
    partial class MainForm
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
            AdminButton = new Button();
            EmlpoyeeButton = new Button();
            ClientButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AdminButton
            // 
            AdminButton.Anchor = AnchorStyles.None;
            AdminButton.BackColor = SystemColors.ButtonFace;
            AdminButton.ForeColor = SystemColors.InfoText;
            AdminButton.Location = new Point(49, 136);
            AdminButton.Margin = new Padding(3, 2, 3, 2);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(165, 52);
            AdminButton.TabIndex = 0;
            AdminButton.Text = "Администратор";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += AdminButton_Click;
            // 
            // EmlpoyeeButton
            // 
            EmlpoyeeButton.Anchor = AnchorStyles.None;
            EmlpoyeeButton.BackColor = SystemColors.ButtonFace;
            EmlpoyeeButton.ForeColor = SystemColors.InfoText;
            EmlpoyeeButton.Location = new Point(290, 136);
            EmlpoyeeButton.Margin = new Padding(3, 2, 3, 2);
            EmlpoyeeButton.Name = "EmlpoyeeButton";
            EmlpoyeeButton.Size = new Size(165, 52);
            EmlpoyeeButton.TabIndex = 1;
            EmlpoyeeButton.Text = "Сотрудник";
            EmlpoyeeButton.UseVisualStyleBackColor = false;
            EmlpoyeeButton.Click += EmlpoyeeButton_Click;
            // 
            // ClientButton
            // 
            ClientButton.Anchor = AnchorStyles.None;
            ClientButton.BackColor = SystemColors.ButtonFace;
            ClientButton.BackgroundImageLayout = ImageLayout.None;
            ClientButton.FlatAppearance.BorderColor = Color.White;
            ClientButton.ForeColor = SystemColors.InfoText;
            ClientButton.Location = new Point(538, 136);
            ClientButton.Margin = new Padding(3, 2, 3, 2);
            ClientButton.Name = "ClientButton";
            ClientButton.RightToLeft = RightToLeft.No;
            ClientButton.Size = new Size(165, 52);
            ClientButton.TabIndex = 2;
            ClientButton.Text = "Клиент";
            ClientButton.UseVisualStyleBackColor = false;
            ClientButton.Click += ClientButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -2);
            label1.Name = "label1";
            label1.Size = new Size(752, 47);
            label1.TabIndex = 3;
            label1.Text = "Войти как:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(ClientButton);
            panel1.Controls.Add(AdminButton);
            panel1.Controls.Add(EmlpoyeeButton);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 378);
            panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(734, 411);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AdminButton;
        private Button EmlpoyeeButton;
        private Button ClientButton;
        private Label label1;
        private Panel panel1;
    }
}