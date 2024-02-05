namespace WorkOrder
{
    partial class User_Details
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(472, 4);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
            label1.TabIndex = 0;
            label1.Text = "User Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 416);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnEdit);
            panel3.Location = new Point(366, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 118);
            panel3.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(548, 34);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(147, 57);
            btnNew.TabIndex = 3;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(395, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 57);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(242, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 57);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(89, 34);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(147, 57);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 74);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 5);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 6;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 57);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 106);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 160);
            label5.Name = "label5";
            label5.Size = new Size(135, 31);
            label5.TabIndex = 9;
            label5.Text = "Contact No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 211);
            label6.Name = "label6";
            label6.Size = new Size(89, 31);
            label6.TabIndex = 10;
            label6.Text = "Region";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(441, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(290, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(290, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 27);
            textBox5.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(163, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 277);
            panel4.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(2, 505);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1133, 346);
            dataGridView1.TabIndex = 3;
            // 
            // Column6
            // 
            Column6.HeaderText = "#";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "User ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact No";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Region";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // User_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 896);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "User_Details";
            Text = "User_Details";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Button btnEdit;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}