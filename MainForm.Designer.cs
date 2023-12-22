namespace WinFormsApp1
{
    partial class MainForm
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
            AdminButton = new Button();
            EmlpoyeeButton = new Button();
            ClientButton = new Button();
            SuspendLayout();
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(53, 168);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(189, 70);
            AdminButton.TabIndex = 0;
            AdminButton.Text = "Администратор";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // EmlpoyeeButton
            // 
            EmlpoyeeButton.Location = new Point(313, 168);
            EmlpoyeeButton.Name = "EmlpoyeeButton";
            EmlpoyeeButton.Size = new Size(189, 70);
            EmlpoyeeButton.TabIndex = 1;
            EmlpoyeeButton.Text = "Сотрудник";
            EmlpoyeeButton.UseVisualStyleBackColor = true;
            EmlpoyeeButton.Click += EmlpoyeeButton_Click;
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(566, 168);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(189, 70);
            ClientButton.TabIndex = 2;
            ClientButton.Text = "Сотрудник";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientButton);
            Controls.Add(EmlpoyeeButton);
            Controls.Add(AdminButton);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AdminButton;
        private Button EmlpoyeeButton;
        private Button ClientButton;
    }
}