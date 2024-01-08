namespace WinFormsApp1
{
    partial class AdminFeeForm
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
            feeDGV = new DataGridView();
            update_fee_box = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            update_feeid_tb = new TextBox();
            label12 = new Label();
            update_name_tb = new TextBox();
            update_table_button = new Button();
            update_cancel_button = new Button();
            update_cost_tb = new TextBox();
            label6 = new Label();
            delete_button = new Button();
            update_button = new Button();
            insert_button = new Button();
            insert_fee_box = new GroupBox();
            label10 = new Label();
            insert_name_tb = new TextBox();
            insert_table_button = new Button();
            insert_cancel_button = new Button();
            label8 = new Label();
            insert_cost_tb = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feeDGV).BeginInit();
            update_fee_box.SuspendLayout();
            insert_fee_box.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OldLace;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(115, 9);
            label2.Name = "label2";
            label2.Size = new Size(291, 36);
            label2.TabIndex = 16;
            label2.Text = "Таблица: Тарифы";
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
            panel1.Controls.Add(feeDGV);
            panel1.Controls.Add(update_fee_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(update_button);
            panel1.Controls.Add(insert_button);
            panel1.Controls.Add(insert_fee_box);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-10, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 613);
            panel1.TabIndex = 14;
            // 
            // feeDGV
            // 
            feeDGV.AllowUserToAddRows = false;
            feeDGV.AllowUserToDeleteRows = false;
            feeDGV.AllowUserToResizeColumns = false;
            feeDGV.AllowUserToResizeRows = false;
            feeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            feeDGV.DefaultCellStyle = dataGridViewCellStyle1;
            feeDGV.GridColor = SystemColors.WindowText;
            feeDGV.Location = new Point(16, 4);
            feeDGV.Margin = new Padding(3, 4, 3, 4);
            feeDGV.Name = "feeDGV";
            feeDGV.RowHeadersWidth = 51;
            feeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            feeDGV.Size = new Size(645, 341);
            feeDGV.TabIndex = 19;
            feeDGV.CellContentClick += feeDGV_CellContentClick;
            // 
            // update_fee_box
            // 
            update_fee_box.BackColor = Color.LightSteelBlue;
            update_fee_box.Controls.Add(label5);
            update_fee_box.Controls.Add(label3);
            update_fee_box.Controls.Add(update_feeid_tb);
            update_fee_box.Controls.Add(label12);
            update_fee_box.Controls.Add(update_name_tb);
            update_fee_box.Controls.Add(update_table_button);
            update_fee_box.Controls.Add(update_cancel_button);
            update_fee_box.Controls.Add(update_cost_tb);
            update_fee_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_fee_box.ForeColor = Color.Black;
            update_fee_box.Location = new Point(451, 353);
            update_fee_box.Margin = new Padding(3, 4, 3, 4);
            update_fee_box.Name = "update_fee_box";
            update_fee_box.Padding = new Padding(3, 4, 3, 4);
            update_fee_box.Size = new Size(432, 248);
            update_fee_box.TabIndex = 16;
            update_fee_box.TabStop = false;
            update_fee_box.Text = "Изменение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(7, 97);
            label5.Name = "label5";
            label5.Size = new Size(207, 28);
            label5.TabIndex = 20;
            label5.Text = "Цена тарифа р/день";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 23;
            label3.Text = "Название тарифа";
            label3.Click += label3_Click;
            // 
            // update_feeid_tb
            // 
            update_feeid_tb.Location = new Point(128, 196);
            update_feeid_tb.Margin = new Padding(3, 4, 3, 4);
            update_feeid_tb.Name = "update_feeid_tb";
            update_feeid_tb.Size = new Size(116, 34);
            update_feeid_tb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(128, 168);
            label12.Name = "label12";
            label12.Size = new Size(106, 28);
            label12.TabIndex = 21;
            label12.Text = "ID тарифа";
            // 
            // update_name_tb
            // 
            update_name_tb.Location = new Point(5, 59);
            update_name_tb.Margin = new Padding(3, 4, 3, 4);
            update_name_tb.Name = "update_name_tb";
            update_name_tb.Size = new Size(161, 34);
            update_name_tb.TabIndex = 18;
            // 
            // update_table_button
            // 
            update_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_table_button.ForeColor = SystemColors.ControlText;
            update_table_button.Location = new Point(247, 117);
            update_table_button.Margin = new Padding(3, 4, 3, 4);
            update_table_button.Name = "update_table_button";
            update_table_button.Size = new Size(174, 60);
            update_table_button.TabIndex = 17;
            update_table_button.Text = "Изменить";
            update_table_button.UseVisualStyleBackColor = true;
            update_table_button.Click += update_table_button_Click;
            // 
            // update_cancel_button
            // 
            update_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            update_cancel_button.ForeColor = SystemColors.ControlText;
            update_cancel_button.Location = new Point(247, 184);
            update_cancel_button.Margin = new Padding(3, 4, 3, 4);
            update_cancel_button.Name = "update_cancel_button";
            update_cancel_button.Size = new Size(174, 60);
            update_cancel_button.TabIndex = 17;
            update_cancel_button.Text = "Отменить";
            update_cancel_button.UseVisualStyleBackColor = true;
            update_cancel_button.Click += update_cancel_button_Click;
            // 
            // update_cost_tb
            // 
            update_cost_tb.Location = new Point(5, 129);
            update_cost_tb.Margin = new Padding(3, 4, 3, 4);
            update_cost_tb.Name = "update_cost_tb";
            update_cost_tb.Size = new Size(239, 34);
            update_cost_tb.TabIndex = 1;
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
            update_button.Click += update_button_Click_1;
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
            insert_button.Click += insert_button_Click_1;
            // 
            // insert_fee_box
            // 
            insert_fee_box.BackColor = Color.LightSteelBlue;
            insert_fee_box.Controls.Add(label10);
            insert_fee_box.Controls.Add(insert_name_tb);
            insert_fee_box.Controls.Add(insert_table_button);
            insert_fee_box.Controls.Add(insert_cancel_button);
            insert_fee_box.Controls.Add(label8);
            insert_fee_box.Controls.Add(insert_cost_tb);
            insert_fee_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_fee_box.ForeColor = Color.Black;
            insert_fee_box.Location = new Point(9, 353);
            insert_fee_box.Margin = new Padding(3, 4, 3, 4);
            insert_fee_box.Name = "insert_fee_box";
            insert_fee_box.Padding = new Padding(3, 4, 3, 4);
            insert_fee_box.Size = new Size(435, 248);
            insert_fee_box.TabIndex = 18;
            insert_fee_box.TabStop = false;
            insert_fee_box.Text = "Добавление";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(7, 27);
            label10.Name = "label10";
            label10.Size = new Size(176, 28);
            label10.TabIndex = 19;
            label10.Text = "Название тарифа";
            // 
            // insert_name_tb
            // 
            insert_name_tb.Location = new Point(7, 59);
            insert_name_tb.Margin = new Padding(3, 4, 3, 4);
            insert_name_tb.Name = "insert_name_tb";
            insert_name_tb.Size = new Size(219, 34);
            insert_name_tb.TabIndex = 18;
            // 
            // insert_table_button
            // 
            insert_table_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_table_button.ForeColor = SystemColors.ControlText;
            insert_table_button.Location = new Point(249, 117);
            insert_table_button.Margin = new Padding(3, 4, 3, 4);
            insert_table_button.Name = "insert_table_button";
            insert_table_button.Size = new Size(179, 60);
            insert_table_button.TabIndex = 17;
            insert_table_button.Text = "Добавить";
            insert_table_button.UseVisualStyleBackColor = true;
            insert_table_button.Click += insert_table_button_Click;
            // 
            // insert_cancel_button
            // 
            insert_cancel_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            insert_cancel_button.ForeColor = SystemColors.ControlText;
            insert_cancel_button.Location = new Point(249, 184);
            insert_cancel_button.Margin = new Padding(3, 4, 3, 4);
            insert_cancel_button.Name = "insert_cancel_button";
            insert_cancel_button.Size = new Size(179, 60);
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
            label8.Location = new Point(8, 101);
            label8.Name = "label8";
            label8.Size = new Size(207, 28);
            label8.TabIndex = 4;
            label8.Text = "Цена тарифа р/день";
            // 
            // insert_cost_tb
            // 
            insert_cost_tb.Location = new Point(7, 129);
            insert_cost_tb.Margin = new Padding(3, 4, 3, 4);
            insert_cost_tb.Name = "insert_cost_tb";
            insert_cost_tb.Size = new Size(219, 34);
            insert_cost_tb.TabIndex = 1;
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
            // AdminFeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 669);
            Controls.Add(label2);
            Controls.Add(to_back_button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminFeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFeeForm";
            Load += AdminFeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)feeDGV).EndInit();
            update_fee_box.ResumeLayout(false);
            update_fee_box.PerformLayout();
            insert_fee_box.ResumeLayout(false);
            insert_fee_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label to_back_button;
        private Panel panel1;
        private DataGridView feeDGV;
        private GroupBox update_fee_box;
        private TextBox update_name_tb;
        private Button update_table_button;
        private Button update_cancel_button;
        private TextBox update_cost_tb;
        private Label label6;
        private Button delete_button;
        private Button update_button;
        private Button insert_button;
        private GroupBox insert_fee_box;
        private Label label10;
        private TextBox insert_name_tb;
        private Button insert_table_button;
        private Button insert_cancel_button;
        private Label label8;
        private TextBox insert_cost_tb;
        private Label label1;
        private Label label5;
        private Label label3;
        private TextBox update_feeid_tb;
        private Label label12;
    }
}