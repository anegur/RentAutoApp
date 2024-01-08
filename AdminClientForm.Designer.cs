namespace WinFormsApp1
{
    partial class AdminClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            to_back_button = new Label();
            panel1 = new Panel();
            clientDGV = new DataGridView();
            clientid = new DataGridViewTextBoxColumn();
            fio = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            update_client_box = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            update_pass_tb = new TextBox();
            label11 = new Label();
            label7 = new Label();
            update_clientid_tb = new TextBox();
            label12 = new Label();
            update_fio_tb = new TextBox();
            update_table_button = new Button();
            update_cancel_button = new Button();
            update_email_tb = new TextBox();
            update_numb_tb = new TextBox();
            label6 = new Label();
            delete_button = new Button();
            update_button = new Button();
            insert_button = new Button();
            insert_client_box = new GroupBox();
            label4 = new Label();
            insert_pass_tb = new TextBox();
            label10 = new Label();
            insert_fio_tb = new TextBox();
            insert_table_button = new Button();
            insert_cancel_button = new Button();
            label8 = new Label();
            label9 = new Label();
            insert_mail_tb = new TextBox();
            insert_numb_tb = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientDGV).BeginInit();
            update_client_box.SuspendLayout();
            insert_client_box.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(115, 9);
            label2.Name = "label2";
            label2.Size = new Size(297, 36);
            label2.TabIndex = 16;
            label2.Text = "Таблица: Клиенты";
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(-10, -4);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(138, 60);
            to_back_button.TabIndex = 15;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(clientDGV);
            panel1.Controls.Add(update_client_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(insert_button);
            panel1.Controls.Add(insert_client_box);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-10, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 672);
            panel1.TabIndex = 14;
            // 
            // clientDGV
            // 
            clientDGV.AllowUserToAddRows = false;
            clientDGV.AllowUserToDeleteRows = false;
            clientDGV.AllowUserToResizeColumns = false;
            clientDGV.AllowUserToResizeRows = false;
            clientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDGV.Columns.AddRange(new DataGridViewColumn[] { clientid, fio, phone_number, email, password });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            clientDGV.DefaultCellStyle = dataGridViewCellStyle1;
            clientDGV.GridColor = SystemColors.WindowText;
            clientDGV.Location = new Point(16, 4);
            clientDGV.Margin = new Padding(3, 4, 3, 4);
            clientDGV.Name = "clientDGV";
            clientDGV.RowHeadersWidth = 51;
            clientDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientDGV.Size = new Size(645, 341);
            clientDGV.TabIndex = 19;
            // 
            // clientid
            // 
            clientid.DataPropertyName = "clientid";
            clientid.HeaderText = "ID Клиента";
            clientid.MinimumWidth = 6;
            clientid.Name = "clientid";
            clientid.Width = 125;
            // 
            // fio
            // 
            fio.DataPropertyName = "fio";
            fio.HeaderText = "ФИО";
            fio.MinimumWidth = 6;
            fio.Name = "fio";
            fio.Width = 200;
            // 
            // phone_number
            // 
            phone_number.DataPropertyName = "phone_number";
            phone_number.HeaderText = "Номер телефона";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.Width = 170;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "e-mail";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 170;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Пароль";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // update_client_box
            // 
            update_client_box.BackColor = Color.LightSteelBlue;
            update_client_box.Controls.Add(label5);
            update_client_box.Controls.Add(label3);
            update_client_box.Controls.Add(update_pass_tb);
            update_client_box.Controls.Add(label11);
            update_client_box.Controls.Add(label7);
            update_client_box.Controls.Add(update_clientid_tb);
            update_client_box.Controls.Add(label12);
            update_client_box.Controls.Add(update_fio_tb);
            update_client_box.Controls.Add(update_table_button);
            update_client_box.Controls.Add(update_cancel_button);
            update_client_box.Controls.Add(update_email_tb);
            update_client_box.Controls.Add(update_numb_tb);
            update_client_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_client_box.ForeColor = Color.Black;
            update_client_box.Location = new Point(451, 353);
            update_client_box.Margin = new Padding(3, 4, 3, 4);
            update_client_box.Name = "update_client_box";
            update_client_box.Padding = new Padding(3, 4, 3, 4);
            update_client_box.Size = new Size(432, 315);
            update_client_box.TabIndex = 16;
            update_client_box.TabStop = false;
            update_client_box.Text = "Изменение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(223, 27);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 23;
            label5.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(8, 172);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 20;
            label3.Text = "Е-мэил";
            // 
            // update_pass_tb
            // 
            update_pass_tb.Location = new Point(223, 59);
            update_pass_tb.Margin = new Padding(3, 4, 3, 4);
            update_pass_tb.MaxLength = 12;
            update_pass_tb.Name = "update_pass_tb";
            update_pass_tb.Size = new Size(198, 34);
            update_pass_tb.TabIndex = 22;
            update_pass_tb.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(223, 171);
            label11.Name = "label11";
            label11.Size = new Size(174, 28);
            label11.TabIndex = 20;
            label11.Text = "Номер телефона";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(13, 97);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 20;
            label7.Text = "ФИО";
            // 
            // update_clientid_tb
            // 
            update_clientid_tb.Location = new Point(13, 59);
            update_clientid_tb.Margin = new Padding(3, 4, 3, 4);
            update_clientid_tb.Name = "update_clientid_tb";
            update_clientid_tb.Size = new Size(113, 34);
            update_clientid_tb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(8, 27);
            label12.Name = "label12";
            label12.Size = new Size(114, 28);
            label12.TabIndex = 21;
            label12.Text = "ID клиента";
            // 
            // update_fio_tb
            // 
            update_fio_tb.Location = new Point(13, 129);
            update_fio_tb.Margin = new Padding(3, 4, 3, 4);
            update_fio_tb.Name = "update_fio_tb";
            update_fio_tb.Size = new Size(409, 34);
            update_fio_tb.TabIndex = 18;
            // 
            // update_table_button
            // 
            update_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_table_button.ForeColor = SystemColors.ControlText;
            update_table_button.Location = new Point(222, 249);
            update_table_button.Margin = new Padding(3, 4, 3, 4);
            update_table_button.Name = "update_table_button";
            update_table_button.Size = new Size(200, 60);
            update_table_button.TabIndex = 17;
            update_table_button.Text = "Изменить";
            update_table_button.UseVisualStyleBackColor = true;
            update_table_button.Click += update_table_button_Click;
            // 
            // update_cancel_button
            // 
            update_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_cancel_button.ForeColor = SystemColors.ControlText;
            update_cancel_button.Location = new Point(13, 249);
            update_cancel_button.Margin = new Padding(3, 4, 3, 4);
            update_cancel_button.Name = "update_cancel_button";
            update_cancel_button.Size = new Size(201, 60);
            update_cancel_button.TabIndex = 17;
            update_cancel_button.Text = "Отменить";
            update_cancel_button.UseVisualStyleBackColor = true;
            update_cancel_button.Click += update_cancel_button_Click;
            // 
            // update_email_tb
            // 
            update_email_tb.Location = new Point(13, 201);
            update_email_tb.Margin = new Padding(3, 4, 3, 4);
            update_email_tb.Name = "update_email_tb";
            update_email_tb.Size = new Size(201, 34);
            update_email_tb.TabIndex = 2;
            // 
            // update_numb_tb
            // 
            update_numb_tb.Location = new Point(223, 203);
            update_numb_tb.Margin = new Padding(3, 4, 3, 4);
            update_numb_tb.Name = "update_numb_tb";
            update_numb_tb.Size = new Size(198, 34);
            update_numb_tb.TabIndex = 1;
            update_numb_tb.TextChanged += update_numb_tb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(738, 17);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 18;
            label6.Text = "Вкладки";
            // 
            // delete_button
            // 
            delete_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delete_button.ForeColor = Color.Maroon;
            delete_button.Location = new Point(667, 251);
            delete_button.Margin = new Padding(3, 4, 3, 4);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(218, 60);
            delete_button.TabIndex = 15;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_button.ForeColor = SystemColors.ControlText;
            update_button.Location = new Point(667, 117);
            update_button.Margin = new Padding(3, 4, 3, 4);
            update_button.Name = "update_button";
            update_button.Size = new Size(218, 60);
            update_button.TabIndex = 14;
            update_button.Text = "Изменить";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // insert_button
            // 
            insert_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_button.ForeColor = SystemColors.ControlText;
            insert_button.Location = new Point(667, 51);
            insert_button.Margin = new Padding(3, 4, 3, 4);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(218, 60);
            insert_button.TabIndex = 13;
            insert_button.Text = "Добавить";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
            // 
            // insert_client_box
            // 
            insert_client_box.BackColor = Color.LightSteelBlue;
            insert_client_box.Controls.Add(label4);
            insert_client_box.Controls.Add(insert_pass_tb);
            insert_client_box.Controls.Add(label10);
            insert_client_box.Controls.Add(insert_fio_tb);
            insert_client_box.Controls.Add(insert_table_button);
            insert_client_box.Controls.Add(insert_cancel_button);
            insert_client_box.Controls.Add(label8);
            insert_client_box.Controls.Add(label9);
            insert_client_box.Controls.Add(insert_mail_tb);
            insert_client_box.Controls.Add(insert_numb_tb);
            insert_client_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_client_box.ForeColor = Color.Black;
            insert_client_box.Location = new Point(9, 353);
            insert_client_box.Margin = new Padding(3, 4, 3, 4);
            insert_client_box.Name = "insert_client_box";
            insert_client_box.Padding = new Padding(3, 4, 3, 4);
            insert_client_box.Size = new Size(435, 315);
            insert_client_box.TabIndex = 18;
            insert_client_box.TabStop = false;
            insert_client_box.Text = "Добавление";
            insert_client_box.Enter += insert_client_box_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(221, 27);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 21;
            label4.Text = "Пароль";
            // 
            // insert_pass_tb
            // 
            insert_pass_tb.Location = new Point(221, 59);
            insert_pass_tb.Margin = new Padding(3, 4, 3, 4);
            insert_pass_tb.Name = "insert_pass_tb";
            insert_pass_tb.Size = new Size(199, 34);
            insert_pass_tb.TabIndex = 20;
            insert_pass_tb.TextChanged += insert_pass_tb_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(15, 97);
            label10.Name = "label10";
            label10.Size = new Size(58, 28);
            label10.TabIndex = 19;
            label10.Text = "ФИО";
            // 
            // insert_fio_tb
            // 
            insert_fio_tb.Location = new Point(9, 129);
            insert_fio_tb.Margin = new Padding(3, 4, 3, 4);
            insert_fio_tb.Name = "insert_fio_tb";
            insert_fio_tb.Size = new Size(411, 34);
            insert_fio_tb.TabIndex = 18;
            // 
            // insert_table_button
            // 
            insert_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_table_button.ForeColor = SystemColors.ControlText;
            insert_table_button.Location = new Point(221, 251);
            insert_table_button.Margin = new Padding(3, 4, 3, 4);
            insert_table_button.Name = "insert_table_button";
            insert_table_button.Size = new Size(200, 60);
            insert_table_button.TabIndex = 17;
            insert_table_button.Text = "Добавить";
            insert_table_button.UseVisualStyleBackColor = true;
            insert_table_button.Click += insert_table_button_Click;
            // 
            // insert_cancel_button
            // 
            insert_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_cancel_button.ForeColor = SystemColors.ControlText;
            insert_cancel_button.Location = new Point(7, 249);
            insert_cancel_button.Margin = new Padding(3, 4, 3, 4);
            insert_cancel_button.Name = "insert_cancel_button";
            insert_cancel_button.Size = new Size(201, 60);
            insert_cancel_button.TabIndex = 17;
            insert_cancel_button.Text = "Отменить";
            insert_cancel_button.UseVisualStyleBackColor = true;
            insert_cancel_button.Click += insert_cancel_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(7, 173);
            label8.Name = "label8";
            label8.Size = new Size(77, 28);
            label8.TabIndex = 4;
            label8.Text = "Е-мэил";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(221, 172);
            label9.Name = "label9";
            label9.Size = new Size(174, 28);
            label9.TabIndex = 3;
            label9.Text = "Номер телефона";
            // 
            // insert_mail_tb
            // 
            insert_mail_tb.Location = new Point(9, 205);
            insert_mail_tb.Margin = new Padding(3, 4, 3, 4);
            insert_mail_tb.Name = "insert_mail_tb";
            insert_mail_tb.Size = new Size(198, 34);
            insert_mail_tb.TabIndex = 1;
            // 
            // insert_numb_tb
            // 
            insert_numb_tb.Location = new Point(221, 205);
            insert_numb_tb.Margin = new Padding(3, 4, 3, 4);
            insert_numb_tb.Name = "insert_numb_tb";
            insert_numb_tb.Size = new Size(201, 34);
            insert_numb_tb.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-10, -4);
            label1.Name = "label1";
            label1.Size = new Size(906, 60);
            label1.TabIndex = 13;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 728);
            Controls.Add(label2);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminClientForm";
            Load += AdminClientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientDGV).EndInit();
            update_client_box.ResumeLayout(false);
            update_client_box.PerformLayout();
            insert_client_box.ResumeLayout(false);
            insert_client_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label to_back_button;
        private Panel panel1;
        private DataGridView clientDGV;
        private GroupBox update_client_box;
        private TextBox update_clientid_tb;
        private Label label12;
        private TextBox update_fio_tb;
        private Button update_table_button;
        private Button update_cancel_button;
        private TextBox update_email_tb;
        private TextBox update_numb_tb;
        private Label label6;
        private Button delete_button;
        private Button update_button;
        private Button insert_button;
        private GroupBox insert_client_box;
        private Label label10;
        private TextBox insert_fio_tb;
        private Button insert_table_button;
        private Button insert_cancel_button;
        private Label label8;
        private Label label9;
        private TextBox insert_mail_tb;
        private TextBox insert_numb_tb;
        private Label label1;
        private Label label3;
        private Label label11;
        private Label label7;
        private Label label4;
        private TextBox insert_pass_tb;
        private Label label5;
        private TextBox update_pass_tb;
        private DataGridViewTextBoxColumn clientid;
        private DataGridViewTextBoxColumn fio;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
    }
}