namespace WorkOrder
{
    partial class New_Antenna_Details
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
            panel2 = new Panel();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            panel3 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 54);
            label1.TabIndex = 0;
            label1.Text = "Antenna Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 69);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(2, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 344);
            panel2.TabIndex = 2;
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
            // btnSave
            // 
            btnSave.Location = new Point(242, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 57);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
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
            // btnNew
            // 
            btnNew.Location = new Point(548, 34);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(147, 57);
            btnNew.TabIndex = 3;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnEdit);
            panel3.Location = new Point(366, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(767, 118);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 51);
            label2.Name = "label2";
            label2.Size = new Size(199, 38);
            label2.TabIndex = 5;
            label2.Text = "Antenna Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 27);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(2, 424);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1135, 323);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Antenna Type";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // New_Antenna_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 826);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "New_Antenna_Details";
            Text = "New_Antenna_Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Button btnEdit;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}