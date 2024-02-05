namespace WorkOrder
{
    partial class Dialog_Work_Order
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
            panel1 = new Panel();
            label1 = new Label();
            btnAntennaDetails = new Button();
            btnSiteDetails = new Button();
            btnUserDetails = new Button();
            btnGenWorkOrder = new Button();
            panelface = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(443, 54);
            label1.TabIndex = 0;
            label1.Text = "Work Order Genareter";
            // 
            // btnAntennaDetails
            // 
            btnAntennaDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAntennaDetails.Location = new Point(293, 73);
            btnAntennaDetails.Name = "btnAntennaDetails";
            btnAntennaDetails.Size = new Size(171, 45);
            btnAntennaDetails.TabIndex = 1;
            btnAntennaDetails.Text = "Antennas Details";
            btnAntennaDetails.UseVisualStyleBackColor = true;
            btnAntennaDetails.Click += btnAntennaDetails_Click;
            // 
            // btnSiteDetails
            // 
            btnSiteDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiteDetails.Location = new Point(147, 73);
            btnSiteDetails.Name = "btnSiteDetails";
            btnSiteDetails.Size = new Size(140, 45);
            btnSiteDetails.TabIndex = 2;
            btnSiteDetails.Text = "Site Details";
            btnSiteDetails.UseVisualStyleBackColor = true;
            btnSiteDetails.Click += btnSiteDetails_Click;
            // 
            // btnUserDetails
            // 
            btnUserDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserDetails.Location = new Point(1, 73);
            btnUserDetails.Name = "btnUserDetails";
            btnUserDetails.Size = new Size(140, 45);
            btnUserDetails.TabIndex = 3;
            btnUserDetails.Text = "User Details";
            btnUserDetails.UseVisualStyleBackColor = true;
            btnUserDetails.Click += btnUserDetails_Click;
            // 
            // btnGenWorkOrder
            // 
            btnGenWorkOrder.BackColor = SystemColors.HotTrack;
            btnGenWorkOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenWorkOrder.ForeColor = SystemColors.ButtonHighlight;
            btnGenWorkOrder.Location = new Point(470, 73);
            btnGenWorkOrder.Name = "btnGenWorkOrder";
            btnGenWorkOrder.Size = new Size(226, 45);
            btnGenWorkOrder.TabIndex = 4;
            btnGenWorkOrder.Text = "Generate a Work Order";
            btnGenWorkOrder.UseVisualStyleBackColor = false;
            btnGenWorkOrder.Click += btnGenWorkOrder_Click;
            // 
            // panelface
            // 
            panelface.Location = new Point(3, 124);
            panelface.Name = "panelface";
            panelface.Size = new Size(1085, 845);
            panelface.TabIndex = 5;
            panelface.Paint += panelface_Paint;
            // 
            // Dialog_Work_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 981);
            Controls.Add(panelface);
            Controls.Add(btnGenWorkOrder);
            Controls.Add(btnUserDetails);
            Controls.Add(btnSiteDetails);
            Controls.Add(btnAntennaDetails);
            Controls.Add(panel1);
            Name = "Dialog_Work_Order";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAntennaDetails;
        private Button btnSiteDetails;
        private Button btnUserDetails;
        private Button btnGenWorkOrder;
        private Panel panelface;
    }
}