namespace WinFormsApp1
{
    partial class ClientAuthForm
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
            to_back_button = new Label();
            panel1 = new Panel();
            authButton = new Button();
            label3 = new Label();
            ФИО = new Label();
            passTextBox = new TextBox();
            loginTextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(0, -4);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(121, 45);
            to_back_button.TabIndex = 10;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(authButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ФИО);
            panel1.Controls.Add(passTextBox);
            panel1.Controls.Add(loginTextBox);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 370);
            panel1.TabIndex = 9;
            // 
            // authButton
            // 
            authButton.Anchor = AnchorStyles.None;
            authButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authButton.ForeColor = Color.Black;
            authButton.Location = new Point(238, 214);
            authButton.Name = "authButton";
            authButton.Size = new Size(260, 42);
            authButton.TabIndex = 4;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = true;
            authButton.Click += authButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(238, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // ФИО
            // 
            ФИО.Anchor = AnchorStyles.None;
            ФИО.AutoSize = true;
            ФИО.ForeColor = SystemColors.GrayText;
            ФИО.Location = new Point(238, 57);
            ФИО.Name = "ФИО";
            ФИО.Size = new Size(34, 15);
            ФИО.TabIndex = 2;
            ФИО.Text = "ФИО";
            // 
            // passTextBox
            // 
            passTextBox.Anchor = AnchorStyles.None;
            passTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passTextBox.Location = new Point(238, 147);
            passTextBox.MaxLength = 15;
            passTextBox.Multiline = true;
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(260, 43);
            passTextBox.TabIndex = 6;
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.None;
            loginTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(238, 75);
            loginTextBox.Multiline = true;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(260, 44);
            loginTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -4);
            label1.Name = "label1";
            label1.Size = new Size(752, 45);
            label1.TabIndex = 8;
            label1.Text = "Клиент";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ClientAuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientAuthForm";
            Load += ClientAuthForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label to_back_button;
        private Panel panel1;
        private Button authButton;
        private Label label3;
        private Label ФИО;
        private TextBox passTextBox;
        private TextBox loginTextBox;
        private Label label1;
    }
}