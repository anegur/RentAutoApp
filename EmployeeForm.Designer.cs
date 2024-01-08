namespace WinFormsApp1
{
    partial class EmployeeForm
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
            exitButton = new Label();
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            client_button = new Button();
            rent_button = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OldLace;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Firebrick;
            exitButton.Location = new Point(613, -3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(121, 45);
            exitButton.TabIndex = 12;
            exitButton.Text = "Выйти";
            exitButton.TextAlign = ContentAlignment.MiddleCenter;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -3);
            label1.Name = "label1";
            label1.Size = new Size(752, 45);
            label1.TabIndex = 11;
            label1.Text = "Панель сотрудника";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 370);
            panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.MintCream;
            flowLayoutPanel1.Controls.Add(client_button);
            flowLayoutPanel1.Controls.Add(rent_button);
            flowLayoutPanel1.Location = new Point(152, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(438, 212);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // client_button
            // 
            client_button.ForeColor = SystemColors.ControlText;
            client_button.Location = new Point(3, 3);
            client_button.Name = "client_button";
            client_button.Size = new Size(211, 56);
            client_button.TabIndex = 0;
            client_button.Text = "Клиентская база";
            client_button.UseVisualStyleBackColor = true;
            client_button.Click += client_button_Click;
            // 
            // rent_button
            // 
            rent_button.ForeColor = SystemColors.ControlText;
            rent_button.Location = new Point(220, 3);
            rent_button.Name = "rent_button";
            rent_button.Size = new Size(211, 56);
            rent_button.TabIndex = 2;
            rent_button.Text = "Управление прокатами";
            rent_button.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 411);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label exitButton;
        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button client_button;
        private Button rent_button;
    }
}