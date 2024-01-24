namespace WinForm_IoT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBMessage = new TextBox();
            btnSendM = new Button();
            label1 = new Label();
            label2 = new Label();
            btnViewM = new Button();
            label3 = new Label();
            comboBoxDevices = new ComboBox();
            SuspendLayout();
            // 
            // txtBMessage
            // 
            txtBMessage.Location = new Point(228, 220);
            txtBMessage.Multiline = true;
            txtBMessage.Name = "txtBMessage";
            txtBMessage.Size = new Size(330, 111);
            txtBMessage.TabIndex = 0;
            // 
            // btnSendM
            // 
            btnSendM.BackColor = SystemColors.Highlight;
            btnSendM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendM.Location = new Point(228, 350);
            btnSendM.Name = "btnSendM";
            btnSendM.Size = new Size(155, 50);
            btnSendM.TabIndex = 2;
            btnSendM.Text = "Send";
            btnSendM.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 81);
            label1.Name = "label1";
            label1.Size = new Size(149, 22);
            label1.TabIndex = 3;
            label1.Text = "Select Device Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 185);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 4;
            label2.Text = "Text Message:";
            // 
            // btnViewM
            // 
            btnViewM.BackColor = SystemColors.ButtonShadow;
            btnViewM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewM.Location = new Point(403, 350);
            btnViewM.Name = "btnViewM";
            btnViewM.Size = new Size(155, 50);
            btnViewM.TabIndex = 5;
            btnViewM.Text = "View Messages ->";
            btnViewM.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 23);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 6;
            label3.Text = "Message to a Device";
            // 
            // comboBoxDevices
            // 
            comboBoxDevices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDevices.FormattingEnabled = true;
            comboBoxDevices.Location = new Point(289, 131);
            comboBoxDevices.Name = "comboBoxDevices";
            comboBoxDevices.Size = new Size(196, 28);
            comboBoxDevices.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxDevices);
            Controls.Add(label3);
            Controls.Add(btnViewM);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSendM);
            Controls.Add(txtBMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBMessage;
        private Button btnSendM;
        private Label label1;
        private Label label2;
        private Button btnViewM;
        private Label label3;
        private ComboBox comboBoxDevices;
    }
}
