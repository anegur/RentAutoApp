namespace WinFormsApp1
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            to_back_button = new Label();
            panel1 = new Panel();
            employeeDGV = new DataGridView();
            update_rent_box = new GroupBox();
            label6 = new Label();
            delete_button = new Button();
            update_button = new Button();
            insert_button = new Button();
            insert_rent_box = new GroupBox();
            label4 = new Label();
            insert_clientid_tb = new TextBox();
            label10 = new Label();
            insert_start_date_tb = new TextBox();
            insert_table_button = new Button();
            insert_cancel_button = new Button();
            label1 = new Label();
            rentid = new DataGridViewTextBoxColumn();
            clientid = new DataGridViewTextBoxColumn();
            employeeid = new DataGridViewTextBoxColumn();
            carid = new DataGridViewTextBoxColumn();
            start_date = new DataGridViewTextBoxColumn();
            end_date = new DataGridViewTextBoxColumn();
            label13 = new Label();
            insert_employeeid_tb = new TextBox();
            label14 = new Label();
            insert_carid_tb = new TextBox();
            label15 = new Label();
            insert_end_date_tb = new TextBox();
            label3 = new Label();
            update_end_date_tb = new TextBox();
            label5 = new Label();
            update_carid_tb = new TextBox();
            label7 = new Label();
            update_employeeid_tb = new TextBox();
            label8 = new Label();
            update_clientid_tb = new TextBox();
            label9 = new Label();
            update_start_date_tb = new TextBox();
            update_table_button = new Button();
            update_cancel_button = new Button();
            update_rentid_tb = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDGV).BeginInit();
            update_rent_box.SuspendLayout();
            insert_rent_box.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(114, 16);
            label2.Name = "label2";
            label2.Size = new Size(241, 29);
            label2.TabIndex = 24;
            label2.Text = "Таблица: Прокаты";
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(4, 6);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(121, 45);
            to_back_button.TabIndex = 23;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(employeeDGV);
            panel1.Controls.Add(update_rent_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(insert_button);
            panel1.Controls.Add(insert_rent_box);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(4, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 452);
            panel1.TabIndex = 22;
            // 
            // employeeDGV
            // 
            employeeDGV.AllowUserToAddRows = false;
            employeeDGV.AllowUserToDeleteRows = false;
            employeeDGV.AllowUserToResizeColumns = false;
            employeeDGV.AllowUserToResizeRows = false;
            employeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDGV.Columns.AddRange(new DataGridViewColumn[] { rentid, clientid, employeeid, carid, start_date, end_date });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            employeeDGV.DefaultCellStyle = dataGridViewCellStyle4;
            employeeDGV.GridColor = SystemColors.WindowText;
            employeeDGV.Location = new Point(8, 3);
            employeeDGV.Name = "employeeDGV";
            employeeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDGV.Size = new Size(719, 256);
            employeeDGV.TabIndex = 19;
            // 
            // update_rent_box
            // 
            update_rent_box.BackColor = Color.LightSteelBlue;
            update_rent_box.Controls.Add(label11);
            update_rent_box.Controls.Add(update_rentid_tb);
            update_rent_box.Controls.Add(label3);
            update_rent_box.Controls.Add(label5);
            update_rent_box.Controls.Add(update_end_date_tb);
            update_rent_box.Controls.Add(update_cancel_button);
            update_rent_box.Controls.Add(update_table_button);
            update_rent_box.Controls.Add(update_carid_tb);
            update_rent_box.Controls.Add(update_start_date_tb);
            update_rent_box.Controls.Add(label7);
            update_rent_box.Controls.Add(label9);
            update_rent_box.Controls.Add(update_employeeid_tb);
            update_rent_box.Controls.Add(update_clientid_tb);
            update_rent_box.Controls.Add(label8);
            update_rent_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_rent_box.ForeColor = Color.Black;
            update_rent_box.Location = new Point(395, 265);
            update_rent_box.Name = "update_rent_box";
            update_rent_box.Size = new Size(510, 186);
            update_rent_box.TabIndex = 16;
            update_rent_box.TabStop = false;
            update_rent_box.Text = "Изменение";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(646, 13);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 18;
            label6.Text = "Вкладки";
            // 
            // delete_button
            // 
            delete_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            delete_button.ForeColor = Color.Maroon;
            delete_button.Location = new Point(733, 169);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(178, 45);
            delete_button.TabIndex = 15;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            update_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_button.ForeColor = SystemColors.ControlText;
            update_button.Location = new Point(733, 54);
            update_button.Name = "update_button";
            update_button.Size = new Size(178, 45);
            update_button.TabIndex = 14;
            update_button.Text = "Изменить";
            update_button.UseVisualStyleBackColor = true;
            // 
            // insert_button
            // 
            insert_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_button.ForeColor = SystemColors.ControlText;
            insert_button.Location = new Point(733, 3);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(178, 45);
            insert_button.TabIndex = 13;
            insert_button.Text = "Добавить";
            insert_button.UseVisualStyleBackColor = true;
            // 
            // insert_rent_box
            // 
            insert_rent_box.BackColor = Color.LightSteelBlue;
            insert_rent_box.Controls.Add(label15);
            insert_rent_box.Controls.Add(insert_end_date_tb);
            insert_rent_box.Controls.Add(label14);
            insert_rent_box.Controls.Add(insert_carid_tb);
            insert_rent_box.Controls.Add(label13);
            insert_rent_box.Controls.Add(insert_employeeid_tb);
            insert_rent_box.Controls.Add(label4);
            insert_rent_box.Controls.Add(insert_clientid_tb);
            insert_rent_box.Controls.Add(label10);
            insert_rent_box.Controls.Add(insert_start_date_tb);
            insert_rent_box.Controls.Add(insert_table_button);
            insert_rent_box.Controls.Add(insert_cancel_button);
            insert_rent_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_rent_box.ForeColor = Color.Black;
            insert_rent_box.Location = new Point(8, 265);
            insert_rent_box.Name = "insert_rent_box";
            insert_rent_box.Size = new Size(381, 186);
            insert_rent_box.TabIndex = 18;
            insert_rent_box.TabStop = false;
            insert_rent_box.Text = "Добавление";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(6, 20);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 21;
            label4.Text = "ID Клиента";
            // 
            // insert_clientid_tb
            // 
            insert_clientid_tb.BorderStyle = BorderStyle.FixedSingle;
            insert_clientid_tb.Location = new Point(6, 44);
            insert_clientid_tb.Name = "insert_clientid_tb";
            insert_clientid_tb.Size = new Size(112, 29);
            insert_clientid_tb.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(6, 73);
            label10.Name = "label10";
            label10.Size = new Size(164, 21);
            label10.TabIndex = 19;
            label10.Text = "Дата начала проката";
            // 
            // insert_start_date_tb
            // 
            insert_start_date_tb.Location = new Point(8, 97);
            insert_start_date_tb.Name = "insert_start_date_tb";
            insert_start_date_tb.Size = new Size(174, 29);
            insert_start_date_tb.TabIndex = 18;
            // 
            // insert_table_button
            // 
            insert_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_table_button.ForeColor = SystemColors.ControlText;
            insert_table_button.Location = new Point(200, 132);
            insert_table_button.Name = "insert_table_button";
            insert_table_button.Size = new Size(175, 45);
            insert_table_button.TabIndex = 17;
            insert_table_button.Text = "Добавить";
            insert_table_button.UseVisualStyleBackColor = true;
            // 
            // insert_cancel_button
            // 
            insert_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_cancel_button.ForeColor = SystemColors.ControlText;
            insert_cancel_button.Location = new Point(6, 132);
            insert_cancel_button.Name = "insert_cancel_button";
            insert_cancel_button.Size = new Size(176, 45);
            insert_cancel_button.TabIndex = 17;
            insert_cancel_button.Text = "Отменить";
            insert_cancel_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(914, 45);
            label1.TabIndex = 21;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rentid
            // 
            rentid.DataPropertyName = "rentid";
            rentid.HeaderText = "ID Проката";
            rentid.Name = "rentid";
            // 
            // clientid
            // 
            clientid.DataPropertyName = "clientid";
            clientid.HeaderText = "ID Клиента";
            clientid.Name = "clientid";
            // 
            // employeeid
            // 
            employeeid.DataPropertyName = "employeeid";
            employeeid.HeaderText = "ID Сотрудника";
            employeeid.Name = "employeeid";
            employeeid.Width = 115;
            // 
            // carid
            // 
            carid.DataPropertyName = "carid";
            carid.HeaderText = "ID Машины";
            carid.Name = "carid";
            // 
            // start_date
            // 
            start_date.DataPropertyName = "start_date";
            start_date.HeaderText = "Дата начала";
            start_date.Name = "start_date";
            start_date.Width = 130;
            // 
            // end_date
            // 
            end_date.DataPropertyName = "end_date";
            end_date.HeaderText = "Дата окончания";
            end_date.Name = "end_date";
            end_date.Width = 130;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(137, 20);
            label13.Name = "label13";
            label13.Size = new Size(118, 21);
            label13.TabIndex = 23;
            label13.Text = "ID Сотрудника";
            // 
            // insert_employeeid_tb
            // 
            insert_employeeid_tb.Location = new Point(137, 44);
            insert_employeeid_tb.Name = "insert_employeeid_tb";
            insert_employeeid_tb.Size = new Size(112, 29);
            insert_employeeid_tb.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(263, 20);
            label14.Name = "label14";
            label14.Size = new Size(97, 21);
            label14.TabIndex = 25;
            label14.Text = "ID Машины";
            // 
            // insert_carid_tb
            // 
            insert_carid_tb.Location = new Point(263, 44);
            insert_carid_tb.Name = "insert_carid_tb";
            insert_carid_tb.Size = new Size(112, 29);
            insert_carid_tb.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(186, 73);
            label15.Name = "label15";
            label15.Size = new Size(195, 21);
            label15.TabIndex = 27;
            label15.Text = "Дата окончания проката";
            label15.Click += label15_Click;
            // 
            // insert_end_date_tb
            // 
            insert_end_date_tb.Location = new Point(200, 97);
            insert_end_date_tb.Name = "insert_end_date_tb";
            insert_end_date_tb.Size = new Size(175, 29);
            insert_end_date_tb.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(257, 73);
            label3.Name = "label3";
            label3.Size = new Size(195, 21);
            label3.TabIndex = 39;
            label3.Text = "Дата окончания проката";
            // 
            // update_end_date_tb
            // 
            update_end_date_tb.Location = new Point(257, 97);
            update_end_date_tb.Name = "update_end_date_tb";
            update_end_date_tb.Size = new Size(242, 29);
            update_end_date_tb.TabIndex = 38;
            update_end_date_tb.TextChanged += update_end_date_tb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(387, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 37;
            label5.Text = "ID Машины";
            // 
            // update_carid_tb
            // 
            update_carid_tb.Location = new Point(387, 44);
            update_carid_tb.Name = "update_carid_tb";
            update_carid_tb.Size = new Size(112, 29);
            update_carid_tb.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(251, 20);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 35;
            label7.Text = "ID Сотрудника";
            // 
            // update_employeeid_tb
            // 
            update_employeeid_tb.Location = new Point(257, 44);
            update_employeeid_tb.Name = "update_employeeid_tb";
            update_employeeid_tb.Size = new Size(112, 29);
            update_employeeid_tb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(131, 20);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 33;
            label8.Text = "ID Клиента";
            // 
            // update_clientid_tb
            // 
            update_clientid_tb.Location = new Point(131, 44);
            update_clientid_tb.Name = "update_clientid_tb";
            update_clientid_tb.Size = new Size(112, 29);
            update_clientid_tb.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(8, 73);
            label9.Name = "label9";
            label9.Size = new Size(164, 21);
            label9.TabIndex = 31;
            label9.Text = "Дата начала проката";
            // 
            // update_start_date_tb
            // 
            update_start_date_tb.Location = new Point(8, 97);
            update_start_date_tb.Name = "update_start_date_tb";
            update_start_date_tb.Size = new Size(243, 29);
            update_start_date_tb.TabIndex = 30;
            // 
            // update_table_button
            // 
            update_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_table_button.ForeColor = SystemColors.ControlText;
            update_table_button.Location = new Point(257, 132);
            update_table_button.Name = "update_table_button";
            update_table_button.Size = new Size(242, 45);
            update_table_button.TabIndex = 28;
            update_table_button.Text = "Добавить";
            update_table_button.UseVisualStyleBackColor = true;
            // 
            // update_cancel_button
            // 
            update_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_cancel_button.ForeColor = SystemColors.ControlText;
            update_cancel_button.Location = new Point(6, 132);
            update_cancel_button.Name = "update_cancel_button";
            update_cancel_button.Size = new Size(245, 45);
            update_cancel_button.TabIndex = 29;
            update_cancel_button.Text = "Отменить";
            update_cancel_button.UseVisualStyleBackColor = true;
            // 
            // update_rentid_tb
            // 
            update_rentid_tb.BorderStyle = BorderStyle.FixedSingle;
            update_rentid_tb.Location = new Point(6, 44);
            update_rentid_tb.Name = "update_rentid_tb";
            update_rentid_tb.Size = new Size(112, 29);
            update_rentid_tb.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(2, 20);
            label11.Name = "label11";
            label11.Size = new Size(93, 21);
            label11.TabIndex = 41;
            label11.Text = "ID Проката";
            // 
            // AdminRentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 509);
            Controls.Add(label2);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AdminRentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminRentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDGV).EndInit();
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
        private DataGridView employeeDGV;
        private GroupBox update_rent_box;
        private Label label6;
        private Button delete_button;
        private Button update_button;
        private Button insert_button;
        private GroupBox insert_rent_box;
        private Label label4;
        private TextBox insert_clientid_tb;
        private Label label10;
        private TextBox insert_start_date_tb;
        private Button insert_table_button;
        private Button insert_cancel_button;
        private Label label1;
        private DataGridViewTextBoxColumn rentid;
        private DataGridViewTextBoxColumn clientid;
        private DataGridViewTextBoxColumn employeeid;
        private DataGridViewTextBoxColumn carid;
        private DataGridViewTextBoxColumn start_date;
        private DataGridViewTextBoxColumn end_date;
        private Label label15;
        private TextBox insert_end_date_tb;
        private Label label14;
        private TextBox insert_carid_tb;
        private Label label13;
        private TextBox insert_employeeid_tb;
        private Label label11;
        private TextBox update_rentid_tb;
        private Label label3;
        private Label label5;
        private TextBox update_end_date_tb;
        private Button update_cancel_button;
        private Button update_table_button;
        private TextBox update_carid_tb;
        private TextBox update_start_date_tb;
        private Label label7;
        private Label label9;
        private TextBox update_employeeid_tb;
        private TextBox update_clientid_tb;
        private Label label8;
    }
}