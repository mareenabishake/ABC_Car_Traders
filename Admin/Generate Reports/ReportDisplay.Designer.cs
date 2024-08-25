namespace ABC_Car_Traders
{
    partial class ReportDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDisplay));
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.dgvReportDisplay = new System.Windows.Forms.DataGridView();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripManageCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCustomerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportDisplay)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(248, 38);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(142, 26);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "Report Title ";
            // 
            // dgvReportDisplay
            // 
            this.dgvReportDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportDisplay.Location = new System.Drawing.Point(12, 81);
            this.dgvReportDisplay.Name = "dgvReportDisplay";
            this.dgvReportDisplay.Size = new System.Drawing.Size(672, 312);
            this.dgvReportDisplay.TabIndex = 1;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenuStripManageCarDetails,
            this.txtMenuStripManageCarParts,
            this.txtMenuStripManageCustomerDetails,
            this.txtMenuStripManageOrders,
            this.txtMenuStripGenerateReports});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripAdmin.Size = new System.Drawing.Size(696, 24);
            this.menuStripAdmin.TabIndex = 19;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // txtMenuStripManageCarDetails
            // 
            this.txtMenuStripManageCarDetails.BackColor = System.Drawing.Color.Lavender;
            this.txtMenuStripManageCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripManageCarDetails.Name = "txtMenuStripManageCarDetails";
            this.txtMenuStripManageCarDetails.Size = new System.Drawing.Size(138, 20);
            this.txtMenuStripManageCarDetails.Text = "Manage Car Details";
            this.txtMenuStripManageCarDetails.Click += new System.EventHandler(this.txtMenuStripManageCarDetails_Click);
            // 
            // txtMenuStripManageCarParts
            // 
            this.txtMenuStripManageCarParts.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMenuStripManageCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripManageCarParts.Name = "txtMenuStripManageCarParts";
            this.txtMenuStripManageCarParts.Size = new System.Drawing.Size(127, 20);
            this.txtMenuStripManageCarParts.Text = "Manage Car Parts";
            this.txtMenuStripManageCarParts.Click += new System.EventHandler(this.txtMenuStripManageCarParts_Click);
            // 
            // txtMenuStripManageCustomerDetails
            // 
            this.txtMenuStripManageCustomerDetails.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMenuStripManageCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripManageCustomerDetails.Name = "txtMenuStripManageCustomerDetails";
            this.txtMenuStripManageCustomerDetails.Size = new System.Drawing.Size(174, 20);
            this.txtMenuStripManageCustomerDetails.Text = "Manage Customer Details";
            this.txtMenuStripManageCustomerDetails.Click += new System.EventHandler(this.txtMenuStripManageCustomerDetails_Click);
            // 
            // txtMenuStripManageOrders
            // 
            this.txtMenuStripManageOrders.BackColor = System.Drawing.Color.MistyRose;
            this.txtMenuStripManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripManageOrders.Name = "txtMenuStripManageOrders";
            this.txtMenuStripManageOrders.Size = new System.Drawing.Size(113, 20);
            this.txtMenuStripManageOrders.Text = "Manage Orders";
            this.txtMenuStripManageOrders.Click += new System.EventHandler(this.txtMenuStripManageOrders_Click);
            // 
            // txtMenuStripGenerateReports
            // 
            this.txtMenuStripGenerateReports.BackColor = System.Drawing.Color.Honeydew;
            this.txtMenuStripGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripGenerateReports.Name = "txtMenuStripGenerateReports";
            this.txtMenuStripGenerateReports.Size = new System.Drawing.Size(126, 20);
            this.txtMenuStripGenerateReports.Text = "Generate Reports";
            this.txtMenuStripGenerateReports.Click += new System.EventHandler(this.txtMenuStripGenerateReports_Click);
            // 
            // ReportDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 405);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.dgvReportDisplay);
            this.Controls.Add(this.lblReportTitle);
            this.Name = "ReportDisplay";
            this.Text = "ReportDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportDisplay)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.DataGridView dgvReportDisplay;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCustomerDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageOrders;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripGenerateReports;
    }
}