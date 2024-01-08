﻿namespace WinFormsApp1
{
    partial class AdminRentForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            to_back_button = new Label();
            panel1 = new Panel();
            label17 = new Label();
            label16 = new Label();
            label12 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            rentDGV = new DataGridView();
            rentid = new DataGridViewTextBoxColumn();
            clientid = new DataGridViewTextBoxColumn();
            employeeid = new DataGridViewTextBoxColumn();
            carid = new DataGridViewTextBoxColumn();
            start_date = new DataGridViewTextBoxColumn();
            end_date = new DataGridViewTextBoxColumn();
            update_rent_box = new GroupBox();
            update_end_dtp = new DateTimePicker();
            update_start_dtp = new DateTimePicker();
            label11 = new Label();
            update_rentid_tb = new TextBox();
            label3 = new Label();
            label5 = new Label();
            update_cancel_button = new Button();
            update_table_button = new Button();
            update_carid_tb = new TextBox();
            label7 = new Label();
            label9 = new Label();
            update_employeeid_tb = new TextBox();
            update_clientid_tb = new TextBox();
            label8 = new Label();
            label6 = new Label();
            delete_button = new Button();
            update_button = new Button();
            insert_button = new Button();
            insert_rent_box = new GroupBox();
            insert_end_dtp = new DateTimePicker();
            insert_start_dtp = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            insert_carid_tb = new TextBox();
            label13 = new Label();
            insert_employeeid_tb = new TextBox();
            label4 = new Label();
            insert_clientid_tb = new TextBox();
            label10 = new Label();
            insert_table_button = new Button();
            insert_cancel_button = new Button();
            label1 = new Label();
            buttonIncreaseWidth = new Button();
            buttonResetSize = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentDGV).BeginInit();
            update_rent_box.SuspendLayout();
            insert_rent_box.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(130, 21);
            label2.Name = "label2";
            label2.Size = new Size(297, 36);
            label2.TabIndex = 24;
            label2.Text = "Таблица: Прокаты";
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(5, 8);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(138, 60);
            to_back_button.TabIndex = 23;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(rentDGV);
            panel1.Controls.Add(update_rent_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(insert_button);
            panel1.Controls.Add(insert_rent_box);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(5, 72);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1721, 662);
            panel1.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.ForeColor = Color.Olive;
            label17.Location = new Point(1050, 446);
            label17.Name = "label17";
            label17.Size = new Size(183, 28);
            label17.TabIndex = 45;
            label17.Text = "Таблица: Машины";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.ForeColor = Color.Olive;
            label16.Location = new Point(1050, 228);
            label16.Name = "label16";
            label16.Size = new Size(212, 28);
            label16.TabIndex = 44;
            label16.Text = "Таблица: Сотрудники";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.Olive;
            label12.Location = new Point(1050, 10);
            label12.Name = "label12";
            label12.Size = new Size(182, 28);
            label12.TabIndex = 43;
            label12.Text = "Таблица: Клиенты";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Teal;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.Location = new Point(1050, 477);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(662, 182);
            dataGridView3.TabIndex = 22;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DarkCyan;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(1050, 258);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(662, 185);
            dataGridView2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(1047, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 184);
            dataGridView1.TabIndex = 20;
            // 
            // rentDGV
            // 
            rentDGV.AllowUserToAddRows = false;
            rentDGV.AllowUserToDeleteRows = false;
            rentDGV.AllowUserToResizeColumns = false;
            rentDGV.AllowUserToResizeRows = false;
            rentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentDGV.Columns.AddRange(new DataGridViewColumn[] { rentid, clientid, employeeid, carid, start_date, end_date });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(128, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            rentDGV.DefaultCellStyle = dataGridViewCellStyle4;
            rentDGV.GridColor = SystemColors.WindowText;
            rentDGV.Location = new Point(9, 4);
            rentDGV.Margin = new Padding(3, 4, 3, 4);
            rentDGV.Name = "rentDGV";
            rentDGV.RowHeadersWidth = 51;
            rentDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentDGV.Size = new Size(822, 341);
            rentDGV.TabIndex = 19;
            rentDGV.CellContentClick += employeeDGV_CellContentClick;
            // 
            // rentid
            // 
            rentid.DataPropertyName = "rentid";
            rentid.HeaderText = "ID Проката";
            rentid.MinimumWidth = 6;
            rentid.Name = "rentid";
            rentid.Width = 125;
            // 
            // clientid
            // 
            clientid.DataPropertyName = "clientid";
            clientid.HeaderText = "ID Клиента";
            clientid.MinimumWidth = 6;
            clientid.Name = "clientid";
            clientid.Width = 125;
            // 
            // employeeid
            // 
            employeeid.DataPropertyName = "employeeid";
            employeeid.HeaderText = "ID Сотрудника";
            employeeid.MinimumWidth = 6;
            employeeid.Name = "employeeid";
            employeeid.Width = 115;
            // 
            // carid
            // 
            carid.DataPropertyName = "carid";
            carid.HeaderText = "ID Машины";
            carid.MinimumWidth = 6;
            carid.Name = "carid";
            carid.Width = 120;
            // 
            // start_date
            // 
            start_date.DataPropertyName = "start_date";
            start_date.HeaderText = "Дата начала";
            start_date.MinimumWidth = 6;
            start_date.Name = "start_date";
            start_date.Width = 131;
            // 
            // end_date
            // 
            end_date.DataPropertyName = "end_date";
            end_date.HeaderText = "Дата окончания";
            end_date.MinimumWidth = 6;
            end_date.Name = "end_date";
            end_date.Width = 150;
            // 
            // update_rent_box
            // 
            update_rent_box.BackColor = Color.LightSteelBlue;
            update_rent_box.Controls.Add(update_end_dtp);
            update_rent_box.Controls.Add(update_start_dtp);
            update_rent_box.Controls.Add(label11);
            update_rent_box.Controls.Add(update_rentid_tb);
            update_rent_box.Controls.Add(label3);
            update_rent_box.Controls.Add(label5);
            update_rent_box.Controls.Add(update_cancel_button);
            update_rent_box.Controls.Add(update_table_button);
            update_rent_box.Controls.Add(update_carid_tb);
            update_rent_box.Controls.Add(label7);
            update_rent_box.Controls.Add(label9);
            update_rent_box.Controls.Add(update_employeeid_tb);
            update_rent_box.Controls.Add(update_clientid_tb);
            update_rent_box.Controls.Add(label8);
            update_rent_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_rent_box.ForeColor = Color.Black;
            update_rent_box.Location = new Point(450, 353);
            update_rent_box.Margin = new Padding(3, 4, 3, 4);
            update_rent_box.Name = "update_rent_box";
            update_rent_box.Padding = new Padding(3, 4, 3, 4);
            update_rent_box.Size = new Size(583, 300);
            update_rent_box.TabIndex = 16;
            update_rent_box.TabStop = false;
            update_rent_box.Text = "Изменение";
            update_rent_box.Enter += update_rent_box_Enter;
            // 
            // update_end_dtp
            // 
            update_end_dtp.Location = new Point(296, 127);
            update_end_dtp.Name = "update_end_dtp";
            update_end_dtp.Size = new Size(268, 34);
            update_end_dtp.TabIndex = 42;
            // 
            // update_start_dtp
            // 
            update_start_dtp.Location = new Point(9, 127);
            update_start_dtp.Name = "update_start_dtp";
            update_start_dtp.Size = new Size(268, 34);
            update_start_dtp.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(2, 27);
            label11.Name = "label11";
            label11.Size = new Size(117, 28);
            label11.TabIndex = 41;
            label11.Text = "ID Проката";
            // 
            // update_rentid_tb
            // 
            update_rentid_tb.BorderStyle = BorderStyle.FixedSingle;
            update_rentid_tb.Location = new Point(7, 59);
            update_rentid_tb.Margin = new Padding(3, 4, 3, 4);
            update_rentid_tb.Name = "update_rentid_tb";
            update_rentid_tb.Size = new Size(128, 34);
            update_rentid_tb.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(294, 97);
            label3.Name = "label3";
            label3.Size = new Size(248, 28);
            label3.TabIndex = 39;
            label3.Text = "Дата окончания проката";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(442, 27);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 37;
            label5.Text = "ID Машины";
            // 
            // update_cancel_button
            // 
            update_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_cancel_button.ForeColor = SystemColors.ControlText;
            update_cancel_button.Location = new Point(10, 219);
            update_cancel_button.Margin = new Padding(3, 4, 3, 4);
            update_cancel_button.Name = "update_cancel_button";
            update_cancel_button.Size = new Size(280, 60);
            update_cancel_button.TabIndex = 29;
            update_cancel_button.Text = "Отменить";
            update_cancel_button.UseVisualStyleBackColor = true;
            update_cancel_button.Click += update_cancel_button_Click;
            // 
            // update_table_button
            // 
            update_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_table_button.ForeColor = SystemColors.ControlText;
            update_table_button.Location = new Point(296, 219);
            update_table_button.Margin = new Padding(3, 4, 3, 4);
            update_table_button.Name = "update_table_button";
            update_table_button.Size = new Size(277, 60);
            update_table_button.TabIndex = 28;
            update_table_button.Text = "Изменить";
            update_table_button.UseVisualStyleBackColor = true;
            update_table_button.Click += update_table_button_Click;
            // 
            // update_carid_tb
            // 
            update_carid_tb.Location = new Point(442, 59);
            update_carid_tb.Margin = new Padding(3, 4, 3, 4);
            update_carid_tb.Name = "update_carid_tb";
            update_carid_tb.Size = new Size(127, 34);
            update_carid_tb.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(287, 27);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 35;
            label7.Text = "ID Сотрудника";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(9, 97);
            label9.Name = "label9";
            label9.Size = new Size(209, 28);
            label9.TabIndex = 31;
            label9.Text = "Дата начала проката";
            // 
            // update_employeeid_tb
            // 
            update_employeeid_tb.Location = new Point(294, 59);
            update_employeeid_tb.Margin = new Padding(3, 4, 3, 4);
            update_employeeid_tb.Name = "update_employeeid_tb";
            update_employeeid_tb.Size = new Size(127, 34);
            update_employeeid_tb.TabIndex = 34;
            // 
            // update_clientid_tb
            // 
            update_clientid_tb.Location = new Point(150, 59);
            update_clientid_tb.Margin = new Padding(3, 4, 3, 4);
            update_clientid_tb.Name = "update_clientid_tb";
            update_clientid_tb.Size = new Size(127, 34);
            update_clientid_tb.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(150, 27);
            label8.Name = "label8";
            label8.Size = new Size(116, 28);
            label8.TabIndex = 33;
            label8.Text = "ID Клиента";
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
            delete_button.Location = new Point(838, 225);
            delete_button.Margin = new Padding(3, 4, 3, 4);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(203, 60);
            delete_button.TabIndex = 15;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_button.ForeColor = SystemColors.ControlText;
            update_button.Location = new Point(838, 72);
            update_button.Margin = new Padding(3, 4, 3, 4);
            update_button.Name = "update_button";
            update_button.Size = new Size(203, 60);
            update_button.TabIndex = 14;
            update_button.Text = "Изменить";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // insert_button
            // 
            insert_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_button.ForeColor = SystemColors.ControlText;
            insert_button.Location = new Point(838, 4);
            insert_button.Margin = new Padding(3, 4, 3, 4);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(203, 60);
            insert_button.TabIndex = 13;
            insert_button.Text = "Добавить";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
            // 
            // insert_rent_box
            // 
            insert_rent_box.BackColor = Color.LightSteelBlue;
            insert_rent_box.Controls.Add(insert_end_dtp);
            insert_rent_box.Controls.Add(insert_start_dtp);
            insert_rent_box.Controls.Add(label15);
            insert_rent_box.Controls.Add(label14);
            insert_rent_box.Controls.Add(insert_carid_tb);
            insert_rent_box.Controls.Add(label13);
            insert_rent_box.Controls.Add(insert_employeeid_tb);
            insert_rent_box.Controls.Add(label4);
            insert_rent_box.Controls.Add(insert_clientid_tb);
            insert_rent_box.Controls.Add(label10);
            insert_rent_box.Controls.Add(insert_table_button);
            insert_rent_box.Controls.Add(insert_cancel_button);
            insert_rent_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_rent_box.ForeColor = Color.Black;
            insert_rent_box.Location = new Point(9, 353);
            insert_rent_box.Margin = new Padding(3, 4, 3, 4);
            insert_rent_box.Name = "insert_rent_box";
            insert_rent_box.Padding = new Padding(3, 4, 3, 4);
            insert_rent_box.Size = new Size(435, 300);
            insert_rent_box.TabIndex = 18;
            insert_rent_box.TabStop = false;
            insert_rent_box.Text = "Добавление";
            insert_rent_box.Enter += insert_rent_box_Enter;
            // 
            // insert_end_dtp
            // 
            insert_end_dtp.Location = new Point(222, 127);
            insert_end_dtp.Name = "insert_end_dtp";
            insert_end_dtp.Size = new Size(201, 34);
            insert_end_dtp.TabIndex = 28;
            // 
            // insert_start_dtp
            // 
            insert_start_dtp.Location = new Point(7, 128);
            insert_start_dtp.Name = "insert_start_dtp";
            insert_start_dtp.Size = new Size(201, 34);
            insert_start_dtp.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(213, 97);
            label15.Name = "label15";
            label15.Size = new Size(248, 28);
            label15.TabIndex = 27;
            label15.Text = "Дата окончания проката";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(301, 27);
            label14.Name = "label14";
            label14.Size = new Size(122, 28);
            label14.TabIndex = 25;
            label14.Text = "ID Машины";
            // 
            // insert_carid_tb
            // 
            insert_carid_tb.Location = new Point(301, 59);
            insert_carid_tb.Margin = new Padding(3, 4, 3, 4);
            insert_carid_tb.Name = "insert_carid_tb";
            insert_carid_tb.Size = new Size(127, 34);
            insert_carid_tb.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(157, 27);
            label13.Name = "label13";
            label13.Size = new Size(149, 28);
            label13.TabIndex = 23;
            label13.Text = "ID Сотрудника";
            // 
            // insert_employeeid_tb
            // 
            insert_employeeid_tb.Location = new Point(157, 59);
            insert_employeeid_tb.Margin = new Padding(3, 4, 3, 4);
            insert_employeeid_tb.Name = "insert_employeeid_tb";
            insert_employeeid_tb.Size = new Size(127, 34);
            insert_employeeid_tb.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(7, 27);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 21;
            label4.Text = "ID Клиента";
            // 
            // insert_clientid_tb
            // 
            insert_clientid_tb.BorderStyle = BorderStyle.FixedSingle;
            insert_clientid_tb.Location = new Point(7, 59);
            insert_clientid_tb.Margin = new Padding(3, 4, 3, 4);
            insert_clientid_tb.Name = "insert_clientid_tb";
            insert_clientid_tb.Size = new Size(128, 34);
            insert_clientid_tb.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(7, 97);
            label10.Name = "label10";
            label10.Size = new Size(209, 28);
            label10.TabIndex = 19;
            label10.Text = "Дата начала проката";
            // 
            // insert_table_button
            // 
            insert_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_table_button.ForeColor = SystemColors.ControlText;
            insert_table_button.Location = new Point(228, 219);
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
            insert_cancel_button.Location = new Point(7, 219);
            insert_cancel_button.Margin = new Padding(3, 4, 3, 4);
            insert_cancel_button.Name = "insert_cancel_button";
            insert_cancel_button.Size = new Size(201, 60);
            insert_cancel_button.TabIndex = 17;
            insert_cancel_button.Text = "Отменить";
            insert_cancel_button.UseVisualStyleBackColor = true;
            insert_cancel_button.Click += insert_cancel_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(1721, 60);
            label1.TabIndex = 21;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonIncreaseWidth
            // 
            buttonIncreaseWidth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonIncreaseWidth.ForeColor = SystemColors.ControlText;
            buttonIncreaseWidth.Location = new Point(547, 8);
            buttonIncreaseWidth.Margin = new Padding(3, 4, 3, 4);
            buttonIncreaseWidth.Name = "buttonIncreaseWidth";
            buttonIncreaseWidth.Size = new Size(143, 61);
            buttonIncreaseWidth.TabIndex = 46;
            buttonIncreaseWidth.Text = "Открыть таблицы";
            buttonIncreaseWidth.UseVisualStyleBackColor = true;
            buttonIncreaseWidth.Click += buttonIncreaseWidth_Click;
            // 
            // buttonResetSize
            // 
            buttonResetSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonResetSize.ForeColor = SystemColors.ControlText;
            buttonResetSize.Location = new Point(696, 8);
            buttonResetSize.Margin = new Padding(3, 4, 3, 4);
            buttonResetSize.Name = "buttonResetSize";
            buttonResetSize.Size = new Size(143, 61);
            buttonResetSize.TabIndex = 47;
            buttonResetSize.Text = "Скрыть таблицы";
            buttonResetSize.UseVisualStyleBackColor = true;
            buttonResetSize.Click += buttonResetSize_Click;
            // 
            // AdminRentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 738);
            Controls.Add(buttonResetSize);
            Controls.Add(buttonIncreaseWidth);
            Controls.Add(label2);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminRentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRentForm";
            Load += AdminRentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentDGV).EndInit();
            update_rent_box.ResumeLayout(false);
            update_rent_box.PerformLayout();
            insert_rent_box.ResumeLayout(false);
            insert_rent_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label to_back_button;
        private Panel panel1;
        private DataGridView rentDGV;
        private GroupBox update_rent_box;
        private Label label6;
        private Button delete_button;
        private Button update_button;
        private Button insert_button;
        private GroupBox insert_rent_box;
        private Label label4;
        private TextBox insert_clientid_tb;
        private Label label10;
        private Button insert_table_button;
        private Button insert_cancel_button;
        private Label label1;
        private Label label15;
        private Label label14;
        private TextBox insert_carid_tb;
        private Label label13;
        private TextBox insert_employeeid_tb;
        private Label label11;
        private TextBox update_rentid_tb;
        private Label label3;
        private Label label5;
        private Button update_cancel_button;
        private Button update_table_button;
        private TextBox update_carid_tb;
        private Label label7;
        private Label label9;
        private TextBox update_employeeid_tb;
        private TextBox update_clientid_tb;
        private Label label8;
        private DataGridViewTextBoxColumn rentid;
        private DataGridViewTextBoxColumn clientid;
        private DataGridViewTextBoxColumn employeeid;
        private DataGridViewTextBoxColumn carid;
        private DataGridViewTextBoxColumn start_date;
        private DataGridViewTextBoxColumn end_date;
        private DateTimePicker update_end_dtp;
        private DateTimePicker update_start_dtp;
        private DateTimePicker insert_end_dtp;
        private DateTimePicker insert_start_dtp;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label17;
        private Label label16;
        private Label label12;
        private Button buttonIncreaseWidth;
        private Button buttonResetSize;
    }
}