namespace WinFormsApp1
{
    partial class ClientFullForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            exitButton = new Label();
            label1 = new Label();
            panel1 = new Panel();
            feeCostDGV = new DataGridView();
            cost_fee_name = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            freeCarDGV = new DataGridView();
            freecarmodel = new DataGridViewTextBoxColumn();
            free_car_release_year = new DataGridViewTextBoxColumn();
            free_fee_name = new DataGridViewTextBoxColumn();
            label2 = new Label();
            clientRentDGV = new DataGridView();
            carmodel = new DataGridViewTextBoxColumn();
            start_date = new DataGridViewTextBoxColumn();
            end_date = new DataGridViewTextBoxColumn();
            total_price = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feeCostDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeCarDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientRentDGV).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OldLace;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Firebrick;
            exitButton.Location = new Point(690, -4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(121, 45);
            exitButton.TabIndex = 15;
            exitButton.Text = "Выйти";
            exitButton.TextAlign = ContentAlignment.MiddleCenter;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(-9, -4);
            label1.Name = "label1";
            label1.Size = new Size(823, 45);
            label1.TabIndex = 14;
            label1.Text = "Панель клиента";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(feeCostDGV);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(freeCarDGV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(clientRentDGV);
            panel1.ForeColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-9, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 445);
            panel1.TabIndex = 13;
            // 
            // feeCostDGV
            // 
            feeCostDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            feeCostDGV.Columns.AddRange(new DataGridViewColumn[] { cost_fee_name, cost });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            feeCostDGV.DefaultCellStyle = dataGridViewCellStyle4;
            feeCostDGV.Location = new Point(512, 280);
            feeCostDGV.Name = "feeCostDGV";
            feeCostDGV.Size = new Size(299, 150);
            feeCostDGV.TabIndex = 5;
            // 
            // cost_fee_name
            // 
            cost_fee_name.DataPropertyName = "name";
            cost_fee_name.HeaderText = "Название тарифа";
            cost_fee_name.Name = "cost_fee_name";
            cost_fee_name.Width = 140;
            // 
            // cost
            // 
            cost.DataPropertyName = "cost";
            cost.HeaderText = "Цена р./сут.";
            cost.Name = "cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(536, 252);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Цены тарифов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 252);
            label3.Name = "label3";
            label3.Size = new Size(340, 25);
            label3.TabIndex = 3;
            label3.Text = "Доступные для проката машины";
            // 
            // freeCarDGV
            // 
            freeCarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            freeCarDGV.Columns.AddRange(new DataGridViewColumn[] { freecarmodel, free_car_release_year, free_fee_name });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            freeCarDGV.DefaultCellStyle = dataGridViewCellStyle5;
            freeCarDGV.Location = new Point(10, 280);
            freeCarDGV.Name = "freeCarDGV";
            freeCarDGV.Size = new Size(496, 150);
            freeCarDGV.TabIndex = 2;
            // 
            // freecarmodel
            // 
            freecarmodel.DataPropertyName = "model";
            freecarmodel.HeaderText = "Модель";
            freecarmodel.Name = "freecarmodel";
            freecarmodel.Width = 180;
            // 
            // free_car_release_year
            // 
            free_car_release_year.DataPropertyName = "release_year";
            free_car_release_year.HeaderText = "Год выпуска";
            free_car_release_year.Name = "free_car_release_year";
            free_car_release_year.Width = 120;
            // 
            // free_fee_name
            // 
            free_fee_name.DataPropertyName = "name";
            free_fee_name.HeaderText = "Название тарифа";
            free_fee_name.Name = "free_fee_name";
            free_fee_name.Width = 140;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(330, 41);
            label2.Name = "label2";
            label2.Size = new Size(180, 29);
            label2.TabIndex = 1;
            label2.Text = "Ваши прокаты";
            // 
            // clientRentDGV
            // 
            clientRentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientRentDGV.Columns.AddRange(new DataGridViewColumn[] { carmodel, start_date, end_date, total_price });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            clientRentDGV.DefaultCellStyle = dataGridViewCellStyle6;
            clientRentDGV.Location = new Point(70, 73);
            clientRentDGV.Name = "clientRentDGV";
            clientRentDGV.Size = new Size(684, 123);
            clientRentDGV.TabIndex = 0;
            // 
            // carmodel
            // 
            carmodel.DataPropertyName = "model";
            carmodel.HeaderText = "Модель машины";
            carmodel.Name = "carmodel";
            carmodel.Width = 180;
            // 
            // start_date
            // 
            start_date.DataPropertyName = "start_date";
            start_date.HeaderText = "Дата начала проката";
            start_date.Name = "start_date";
            start_date.Width = 150;
            // 
            // end_date
            // 
            end_date.DataPropertyName = "end_date";
            end_date.HeaderText = "Дата окончания проката";
            end_date.Name = "end_date";
            end_date.Width = 180;
            // 
            // total_price
            // 
            total_price.DataPropertyName = "total_fee";
            total_price.HeaderText = "Цена проката";
            total_price.Name = "total_price";
            total_price.Width = 130;
            // 
            // ClientFullForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 486);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ClientFullForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientFullForm";
            Load += ClientFullForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)feeCostDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeCarDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientRentDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label exitButton;
        private Label label1;
        private Panel panel1;
        private DataGridView clientRentDGV;
        private Label label2;
        private Label label3;
        private DataGridView freeCarDGV;
        private Label label4;
        private DataGridView feeCostDGV;
        private DataGridViewTextBoxColumn carmodel;
        private DataGridViewTextBoxColumn start_date;
        private DataGridViewTextBoxColumn end_date;
        private DataGridViewTextBoxColumn total_price;
        private DataGridViewTextBoxColumn freecarmodel;
        private DataGridViewTextBoxColumn free_car_release_year;
        private DataGridViewTextBoxColumn free_fee_name;
        private DataGridViewTextBoxColumn cost_fee_name;
        private DataGridViewTextBoxColumn cost;
    }
}