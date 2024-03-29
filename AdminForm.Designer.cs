﻿namespace WinFormsApp1
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            car_button = new Button();
            fee_button = new Button();
            clients_button = new Button();
            rent_button = new Button();
            emp_button = new Button();
            label1 = new Label();
            exitButton = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-10, 61);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 493);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.MintCream;
            flowLayoutPanel1.Controls.Add(car_button);
            flowLayoutPanel1.Controls.Add(fee_button);
            flowLayoutPanel1.Controls.Add(clients_button);
            flowLayoutPanel1.Controls.Add(rent_button);
            flowLayoutPanel1.Controls.Add(emp_button);
            flowLayoutPanel1.Location = new Point(184, 108);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(497, 268);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // car_button
            // 
            car_button.ForeColor = SystemColors.ControlText;
            car_button.Location = new Point(3, 4);
            car_button.Margin = new Padding(3, 4, 3, 4);
            car_button.Name = "car_button";
            car_button.Size = new Size(157, 55);
            car_button.TabIndex = 0;
            car_button.Text = "Машины";
            car_button.UseVisualStyleBackColor = true;
            car_button.Click += car_button_Click;
            // 
            // fee_button
            // 
            fee_button.ForeColor = SystemColors.ControlText;
            fee_button.Location = new Point(166, 4);
            fee_button.Margin = new Padding(3, 4, 3, 4);
            fee_button.Name = "fee_button";
            fee_button.Size = new Size(157, 55);
            fee_button.TabIndex = 2;
            fee_button.Text = "Тарифы";
            fee_button.UseVisualStyleBackColor = true;
            fee_button.Click += fee_button_Click;
            // 
            // clients_button
            // 
            clients_button.ForeColor = SystemColors.ControlText;
            clients_button.Location = new Point(329, 4);
            clients_button.Margin = new Padding(3, 4, 3, 4);
            clients_button.Name = "clients_button";
            clients_button.Size = new Size(157, 55);
            clients_button.TabIndex = 1;
            clients_button.Text = "Клиенты";
            clients_button.UseVisualStyleBackColor = true;
            clients_button.Click += clients_button_Click;
            // 
            // rent_button
            // 
            rent_button.ForeColor = SystemColors.ControlText;
            rent_button.Location = new Point(3, 67);
            rent_button.Margin = new Padding(3, 4, 3, 4);
            rent_button.Name = "rent_button";
            rent_button.Size = new Size(157, 55);
            rent_button.TabIndex = 4;
            rent_button.Text = "Прокаты";
            rent_button.UseVisualStyleBackColor = true;
            rent_button.Click += rent_button_Click;
            // 
            // emp_button
            // 
            emp_button.ForeColor = SystemColors.ControlText;
            emp_button.Location = new Point(166, 67);
            emp_button.Margin = new Padding(3, 4, 3, 4);
            emp_button.Name = "emp_button";
            emp_button.Size = new Size(157, 55);
            emp_button.TabIndex = 3;
            emp_button.Text = "Сотрудники";
            emp_button.UseVisualStyleBackColor = true;
            emp_button.Click += emp_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-10, -3);
            label1.Name = "label1";
            label1.Size = new Size(859, 60);
            label1.TabIndex = 8;
            label1.Text = "Панель администратора";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            //label1.Click += this.label1_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OldLace;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Firebrick;
            exitButton.Location = new Point(701, -3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(138, 60);
            exitButton.TabIndex = 9;
            exitButton.Text = "Выйти";
            exitButton.TextAlign = ContentAlignment.MiddleCenter;
            exitButton.Click += exitButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 548);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label exitButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button car_button;
        private Button clients_button;
        private Button fee_button;
        private Button emp_button;
        private Button rent_button;
    }
}