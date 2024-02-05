namespace WorkOrder
{
    partial class Work_Order
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
            panelWorkOrder = new Panel();
            label1 = new Label();
            btnRequester = new Button();
            btnReSiteDetails = new Button();
            btnAntennaInfo = new Button();
            SuspendLayout();
            // 
            // panelWorkOrder
            // 
            panelWorkOrder.Location = new Point(3, 61);
            panelWorkOrder.Name = "panelWorkOrder";
            panelWorkOrder.Size = new Size(1194, 809);
            panelWorkOrder.TabIndex = 0;
            panelWorkOrder.Paint += panelWorkOrder_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(510, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 1;
            label1.Text = "Work Order";
            // 
            // btnRequester
            // 
            btnRequester.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRequester.Location = new Point(3, 876);
            btnRequester.Name = "btnRequester";
            btnRequester.Size = new Size(219, 50);
            btnRequester.TabIndex = 2;
            btnRequester.Text = "Requester Details";
            btnRequester.UseVisualStyleBackColor = true;
            btnRequester.Click += btnRequester_Click;
            // 
            // btnReSiteDetails
            // 
            btnReSiteDetails.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnReSiteDetails.Location = new Point(228, 876);
            btnReSiteDetails.Name = "btnReSiteDetails";
            btnReSiteDetails.Size = new Size(219, 50);
            btnReSiteDetails.TabIndex = 3;
            btnReSiteDetails.Text = "Requesting Site ";
            btnReSiteDetails.UseVisualStyleBackColor = true;
            btnReSiteDetails.Click += btnReSiteDetails_Click;
            // 
            // btnAntennaInfo
            // 
            btnAntennaInfo.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnAntennaInfo.Location = new Point(453, 877);
            btnAntennaInfo.Name = "btnAntennaInfo";
            btnAntennaInfo.Size = new Size(253, 50);
            btnAntennaInfo.TabIndex = 4;
            btnAntennaInfo.Text = "Antenna Information";
            btnAntennaInfo.UseVisualStyleBackColor = true;
            btnAntennaInfo.Click += btnAntennaInfo_Click;
            // 
            // Work_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 952);
            Controls.Add(btnAntennaInfo);
            Controls.Add(btnReSiteDetails);
            Controls.Add(btnRequester);
            Controls.Add(label1);
            Controls.Add(panelWorkOrder);
            Name = "Work_Order";
            Text = "Work_Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelWorkOrder;
        private Label label1;
        private Button btnRequester;
        private Button btnReSiteDetails;
        private Button btnAntennaInfo;
    }
}