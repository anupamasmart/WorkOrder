namespace WorkOrder
{
    partial class Requester
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtRequester = new TextBox();
            txtRequestedBy = new TextBox();
            txtContactNo = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(443, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 46);
            label1.TabIndex = 0;
            label1.Text = "Requester";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(161, 51);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 1;
            label2.Text = "Requester";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(161, 119);
            label3.Name = "label3";
            label3.Size = new Size(221, 38);
            label3.TabIndex = 2;
            label3.Text = "Date of request";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(161, 183);
            label4.Name = "label4";
            label4.Size = new Size(194, 38);
            label4.TabIndex = 3;
            label4.Text = "Requested By";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(161, 251);
            label5.Name = "label5";
            label5.Size = new Size(165, 38);
            label5.TabIndex = 4;
            label5.Text = "Contact No";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(436, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(436, 62);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(212, 27);
            txtRequester.TabIndex = 6;
            // 
            // txtRequestedBy
            // 
            txtRequestedBy.Location = new Point(436, 194);
            txtRequestedBy.Name = "txtRequestedBy";
            txtRequestedBy.Size = new Size(345, 27);
            txtRequestedBy.TabIndex = 7;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(436, 262);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(212, 27);
            txtContactNo.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(txtContactNo);
            panel1.Controls.Add(txtRequestedBy);
            panel1.Controls.Add(txtRequester);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(79, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 355);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(240, 75);
            label6.Name = "label6";
            label6.Size = new Size(113, 38);
            label6.TabIndex = 10;
            label6.Text = "User ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(685, 86);
            button1.Name = "button1";
            button1.Size = new Size(145, 27);
            button1.TabIndex = 12;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // Requester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1126, 501);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Requester";
            Text = "Requester";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox txtRequester;
        private TextBox txtRequestedBy;
        private TextBox txtContactNo;
        private Panel panel1;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
    }
}