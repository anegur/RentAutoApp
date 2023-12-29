namespace WinFormsApp1
{
    partial class AdminCarsForm
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
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            update_car_box = new GroupBox();
            update_carid_tb = new TextBox();
            label12 = new Label();
            label11 = new Label();
            update_fee_tb = new TextBox();
            update_table_button = new Button();
            update_cancel_button = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            update_access_tb = new TextBox();
            update_year_tb = new TextBox();
            update_model_tb = new TextBox();
            label6 = new Label();
            delete_button = new Button();
            update_button = new Button();
            insert_button = new Button();
            insert_car_box = new GroupBox();
            label10 = new Label();
            insert_fee_tb = new TextBox();
            insert_table_button = new Button();
            insert_cancel_button = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            insert_access_tb = new TextBox();
            insert_year_tb = new TextBox();
            insert_car_tb = new TextBox();
            to_back_button = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            update_car_box.SuspendLayout();
            insert_car_box.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-7, -1);
            label1.Name = "label1";
            label1.Size = new Size(793, 45);
            label1.TabIndex = 9;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(update_car_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(insert_button);
            panel1.Controls.Add(insert_car_box);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-7, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 460);
            panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(14, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(564, 256);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // update_car_box
            // 
            update_car_box.BackColor = Color.LightSteelBlue;
            update_car_box.Controls.Add(update_carid_tb);
            update_car_box.Controls.Add(label12);
            update_car_box.Controls.Add(label11);
            update_car_box.Controls.Add(update_fee_tb);
            update_car_box.Controls.Add(update_table_button);
            update_car_box.Controls.Add(update_cancel_button);
            update_car_box.Controls.Add(label5);
            update_car_box.Controls.Add(label4);
            update_car_box.Controls.Add(label3);
            update_car_box.Controls.Add(update_access_tb);
            update_car_box.Controls.Add(update_year_tb);
            update_car_box.Controls.Add(update_model_tb);
            update_car_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_car_box.ForeColor = Color.Black;
            update_car_box.Location = new Point(395, 265);
            update_car_box.Name = "update_car_box";
            update_car_box.Size = new Size(378, 186);
            update_car_box.TabIndex = 16;
            update_car_box.TabStop = false;
            update_car_box.Text = "Изменение";
            // 
            // update_carid_tb
            // 
            update_carid_tb.Location = new Point(112, 147);
            update_carid_tb.Name = "update_carid_tb";
            update_carid_tb.Size = new Size(102, 29);
            update_carid_tb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(112, 126);
            label12.Name = "label12";
            label12.Size = new Size(94, 21);
            label12.TabIndex = 21;
            label12.Text = "ID машины";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(0, 20);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 20;
            label11.Text = "Тариф";
            // 
            // update_fee_tb
            // 
            update_fee_tb.Location = new Point(4, 44);
            update_fee_tb.Name = "update_fee_tb";
            update_fee_tb.Size = new Size(141, 29);
            update_fee_tb.TabIndex = 18;
            // 
            // update_table_button
            // 
            update_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_table_button.ForeColor = SystemColors.ControlText;
            update_table_button.Location = new Point(216, 88);
            update_table_button.Name = "update_table_button";
            update_table_button.Size = new Size(152, 45);
            update_table_button.TabIndex = 17;
            update_table_button.Text = "Изменить";
            update_table_button.UseVisualStyleBackColor = true;
            update_table_button.Click += update_table_button_Click;
            // 
            // update_cancel_button
            // 
            update_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_cancel_button.ForeColor = SystemColors.ControlText;
            update_cancel_button.Location = new Point(216, 138);
            update_cancel_button.Name = "update_cancel_button";
            update_cancel_button.Size = new Size(152, 45);
            update_cancel_button.TabIndex = 17;
            update_cancel_button.Text = "Отменить";
            update_cancel_button.UseVisualStyleBackColor = true;
            update_cancel_button.Click += update_cancel_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(0, 126);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 5;
            label5.Text = "Доступность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(0, 76);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 4;
            label4.Text = "Год выпуска";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(153, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 3;
            label3.Text = "Модель";
            // 
            // update_access_tb
            // 
            update_access_tb.Location = new Point(4, 147);
            update_access_tb.Name = "update_access_tb";
            update_access_tb.Size = new Size(102, 29);
            update_access_tb.TabIndex = 2;
            // 
            // update_year_tb
            // 
            update_year_tb.Location = new Point(4, 97);
            update_year_tb.Name = "update_year_tb";
            update_year_tb.Size = new Size(210, 29);
            update_year_tb.TabIndex = 1;
            // 
            // update_model_tb
            // 
            update_model_tb.Location = new Point(153, 44);
            update_model_tb.Name = "update_model_tb";
            update_model_tb.Size = new Size(215, 29);
            update_model_tb.TabIndex = 0;
            update_model_tb.TextChanged += textBox1_TextChanged;
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
            delete_button.Location = new Point(584, 188);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(191, 45);
            delete_button.TabIndex = 15;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_button.ForeColor = SystemColors.ControlText;
            update_button.Location = new Point(584, 88);
            update_button.Name = "update_button";
            update_button.Size = new Size(191, 45);
            update_button.TabIndex = 14;
            update_button.Text = "Изменить";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // insert_button
            // 
            insert_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_button.ForeColor = SystemColors.ControlText;
            insert_button.Location = new Point(584, 38);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(191, 45);
            insert_button.TabIndex = 13;
            insert_button.Text = "Добавить";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
            // 
            // insert_car_box
            // 
            insert_car_box.BackColor = Color.LightSteelBlue;
            insert_car_box.Controls.Add(label10);
            insert_car_box.Controls.Add(insert_fee_tb);
            insert_car_box.Controls.Add(insert_table_button);
            insert_car_box.Controls.Add(insert_cancel_button);
            insert_car_box.Controls.Add(label7);
            insert_car_box.Controls.Add(label8);
            insert_car_box.Controls.Add(label9);
            insert_car_box.Controls.Add(insert_access_tb);
            insert_car_box.Controls.Add(insert_year_tb);
            insert_car_box.Controls.Add(insert_car_tb);
            insert_car_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_car_box.ForeColor = Color.Black;
            insert_car_box.Location = new Point(8, 265);
            insert_car_box.Name = "insert_car_box";
            insert_car_box.Size = new Size(381, 186);
            insert_car_box.TabIndex = 18;
            insert_car_box.TabStop = false;
            insert_car_box.Text = "Добавление";
            insert_car_box.Enter += insert_car_box_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(6, 20);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 19;
            label10.Text = "Тариф";
            // 
            // insert_fee_tb
            // 
            insert_fee_tb.Location = new Point(6, 44);
            insert_fee_tb.Name = "insert_fee_tb";
            insert_fee_tb.Size = new Size(147, 29);
            insert_fee_tb.TabIndex = 18;
            // 
            // insert_table_button
            // 
            insert_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_table_button.ForeColor = SystemColors.ControlText;
            insert_table_button.Location = new Point(218, 88);
            insert_table_button.Name = "insert_table_button";
            insert_table_button.Size = new Size(157, 45);
            insert_table_button.TabIndex = 17;
            insert_table_button.Text = "Добавить";
            insert_table_button.UseVisualStyleBackColor = true;
            insert_table_button.Click += insert_table_button_Click;
            // 
            // insert_cancel_button
            // 
            insert_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_cancel_button.ForeColor = SystemColors.ControlText;
            insert_cancel_button.Location = new Point(218, 138);
            insert_cancel_button.Name = "insert_cancel_button";
            insert_cancel_button.Size = new Size(157, 45);
            insert_cancel_button.TabIndex = 17;
            insert_cancel_button.Text = "Отменить";
            insert_cancel_button.UseVisualStyleBackColor = true;
            insert_cancel_button.Click += insert_cancel_button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(7, 129);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 5;
            label7.Text = "Доступность";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(7, 76);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 4;
            label8.Text = "Год выпуска";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(160, 20);
            label9.Name = "label9";
            label9.Size = new Size(70, 21);
            label9.TabIndex = 3;
            label9.Text = "Модель";
            // 
            // insert_access_tb
            // 
            insert_access_tb.Location = new Point(7, 151);
            insert_access_tb.Name = "insert_access_tb";
            insert_access_tb.Size = new Size(123, 29);
            insert_access_tb.TabIndex = 2;
            // 
            // insert_year_tb
            // 
            insert_year_tb.Location = new Point(6, 97);
            insert_year_tb.Name = "insert_year_tb";
            insert_year_tb.Size = new Size(210, 29);
            insert_year_tb.TabIndex = 1;
            // 
            // insert_car_tb
            // 
            insert_car_tb.Location = new Point(160, 44);
            insert_car_tb.Name = "insert_car_tb";
            insert_car_tb.Size = new Size(215, 29);
            insert_car_tb.TabIndex = 0;
            // 
            // to_back_button
            // 
            to_back_button.BackColor = Color.OldLace;
            to_back_button.Cursor = Cursors.Hand;
            to_back_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            to_back_button.ForeColor = Color.OliveDrab;
            to_back_button.Location = new Point(-7, -1);
            to_back_button.Name = "to_back_button";
            to_back_button.Size = new Size(121, 45);
            to_back_button.TabIndex = 11;
            to_back_button.Text = "<-назад";
            to_back_button.TextAlign = ContentAlignment.MiddleCenter;
            to_back_button.Click += to_back_button_Click;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(103, 9);
            label2.Name = "label2";
            label2.Size = new Size(241, 29);
            label2.TabIndex = 12;
            label2.Text = "Таблица: Машины";
            label2.Click += label2_Click;
            // 
            // AdminCarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 502);
            Controls.Add(label2);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AdminCarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCarsForm";
            Load += AdminCarsForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            update_car_box.ResumeLayout(false);
            update_car_box.PerformLayout();
            insert_car_box.ResumeLayout(false);
            insert_car_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label to_back_button;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Button insert_button;
        private Button delete_button;
        private Button update_button;
        private Label label2;
        private GroupBox update_car_box;
        private TextBox update_access_tb;
        private Label label3;
        private Button update_table_button;
        private Button update_cancel_button;
        private Label label5;
        private Label label4;
        private Label label6;
        private GroupBox insert_car_box;
        private Button insert_table_button;
        private Button insert_cancel_button;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox insert_access_tb;
        private TextBox insert_year_tb;
        private TextBox insert_car_tb;
        private TextBox update_year_tb;
        private TextBox update_model_tb;
        private Label label11;
        private TextBox update_fee_tb;
        private Label label10;
        private TextBox insert_fee_tb;
        private TextBox update_carid_tb;
        private Label label12;
        private DataGridView dataGridView1;
    }
}