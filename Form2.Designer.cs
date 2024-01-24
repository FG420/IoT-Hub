namespace WinForm_IoT
{
    partial class Form2
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
            dataVMessages = new DataGridView();
            txtBDevice = new TextBox();
            txtBFrom = new TextBox();
            txtBTo = new TextBox();
            txtBText = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnViewID = new Button();
            btnViewDate = new Button();
            btnViewText = new Button();
            btnClear = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataVMessages).BeginInit();
            SuspendLayout();
            // 
            // dataVMessages
            // 
            dataVMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataVMessages.Location = new Point(69, 256);
            dataVMessages.Name = "dataVMessages";
            dataVMessages.ReadOnly = true;
            dataVMessages.RowHeadersWidth = 51;
            dataVMessages.Size = new Size(838, 188);
            dataVMessages.TabIndex = 3;
            // 
            // txtBDevice
            // 
            txtBDevice.Location = new Point(69, 97);
            txtBDevice.Name = "txtBDevice";
            txtBDevice.Size = new Size(154, 27);
            txtBDevice.TabIndex = 7;
            // 
            // txtBFrom
            // 
            txtBFrom.Location = new Point(453, 97);
            txtBFrom.Name = "txtBFrom";
            txtBFrom.Size = new Size(133, 27);
            txtBFrom.TabIndex = 8;
            // 
            // txtBTo
            // 
            txtBTo.Location = new Point(453, 150);
            txtBTo.Name = "txtBTo";
            txtBTo.Size = new Size(133, 27);
            txtBTo.TabIndex = 9;
            // 
            // txtBText
            // 
            txtBText.Location = new Point(789, 97);
            txtBText.Name = "txtBText";
            txtBText.Size = new Size(118, 27);
            txtBText.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 65);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 11;
            label1.Text = "Device ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(499, 65);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 12;
            label4.Text = "From :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(508, 127);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 13;
            label5.Text = "To :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(828, 65);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 14;
            label6.Text = "Text :";
            // 
            // btnViewID
            // 
            btnViewID.BackColor = Color.OliveDrab;
            btnViewID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewID.ForeColor = SystemColors.ControlLight;
            btnViewID.Location = new Point(92, 201);
            btnViewID.Name = "btnViewID";
            btnViewID.Size = new Size(103, 38);
            btnViewID.TabIndex = 15;
            btnViewID.Text = "Search";
            btnViewID.UseVisualStyleBackColor = false;
            // 
            // btnViewDate
            // 
            btnViewDate.BackColor = Color.FromArgb(0, 0, 192);
            btnViewDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewDate.ForeColor = SystemColors.ControlLight;
            btnViewDate.Location = new Point(470, 201);
            btnViewDate.Name = "btnViewDate";
            btnViewDate.Size = new Size(103, 38);
            btnViewDate.TabIndex = 16;
            btnViewDate.Text = "Search";
            btnViewDate.UseVisualStyleBackColor = false;
            // 
            // btnViewText
            // 
            btnViewText.BackColor = Color.Maroon;
            btnViewText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewText.ForeColor = SystemColors.ControlLight;
            btnViewText.Location = new Point(789, 201);
            btnViewText.Name = "btnViewText";
            btnViewText.Size = new Size(103, 38);
            btnViewText.TabIndex = 17;
            btnViewText.Text = "Search";
            btnViewText.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Coral;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(707, 459);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(199, 46);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(86, 22);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 19;
            label7.Text = "View By Device ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(470, 22);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 20;
            label8.Text = "View By Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(791, 22);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 21;
            label9.Text = "View By Text";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnViewText);
            Controls.Add(btnViewDate);
            Controls.Add(btnViewID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBText);
            Controls.Add(txtBTo);
            Controls.Add(txtBFrom);
            Controls.Add(txtBDevice);
            Controls.Add(dataVMessages);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataVMessages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private DataGridView dataVMessages;
        private TextBox txtBDevice;
        private TextBox txtBFrom;
        private TextBox txtBTo;
        private TextBox txtBText;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnViewID;
        private Button btnViewDate;
        private Button btnViewText;
        private Button btnClear;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}