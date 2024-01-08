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
            authButton = new Button();
            label3 = new Label();
            label2 = new Label();
            passTextBox = new TextBox();
            loginTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -3);
            label1.Name = "label1";
            label1.Size = new Size(859, 60);
            label1.TabIndex = 4;
            label1.Text = "Сотрудник";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 61);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 496);
            panel1.TabIndex = 5;
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(-9, -3);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(138, 60);
            to_back_button.TabIndex = 6;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // authButton
            // 
            authButton.Anchor = AnchorStyles.None;
            authButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authButton.ForeColor = Color.Black;
            authButton.Location = new Point(271, 351);
            authButton.Margin = new Padding(3, 4, 3, 4);
            authButton.Name = "authButton";
            authButton.Size = new Size(297, 56);
            authButton.TabIndex = 10;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = true;
            authButton.Click += authButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Honeydew;
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(271, 237);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Honeydew;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(271, 141);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "ФИО";
            // 
            // passTextBox
            // 
            passTextBox.Anchor = AnchorStyles.None;
            passTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passTextBox.Location = new Point(271, 261);
            passTextBox.Margin = new Padding(3, 4, 3, 4);
            passTextBox.MaxLength = 15;
            passTextBox.Multiline = true;
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(297, 56);
            passTextBox.TabIndex = 11;
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.None;
            loginTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(271, 165);
            loginTextBox.Margin = new Padding(3, 4, 3, 4);
            loginTextBox.Multiline = true;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(297, 57);
            loginTextBox.TabIndex = 7;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // EmployeeAuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 548);
            Controls.Add(authButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeAuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeAuthForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label to_back_button;
        private Button authButton;
        private Label label3;
        private Label label2;
        private TextBox passTextBox;
        private TextBox loginTextBox;
    }
}