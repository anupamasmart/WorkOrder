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
            label2.Location = new Point(221, 102);
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
            label3.Location = new Point(221, 170);
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
            label4.Location = new Point(221, 234);
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
            label5.Location = new Point(221, 302);
            label5.Name = "label5";
            label5.Size = new Size(165, 38);
            label5.TabIndex = 4;
            label5.Text = "Contact No";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(496, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(496, 113);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(212, 27);
            txtRequester.TabIndex = 6;
            // 
            // txtRequestedBy
            // 
            txtRequestedBy.Location = new Point(496, 245);
            txtRequestedBy.Name = "txtRequestedBy";
            txtRequestedBy.Size = new Size(345, 27);
            txtRequestedBy.TabIndex = 7;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(496, 313);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(212, 27);
            txtContactNo.TabIndex = 8;
            // 
            // Requester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1126, 501);
            Controls.Add(txtContactNo);
            Controls.Add(txtRequestedBy);
            Controls.Add(txtRequester);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Requester";
            Text = "Requester";
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
    }
}