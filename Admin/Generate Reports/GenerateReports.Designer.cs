namespace ABC_Car_Traders
{
    partial class GenerateReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReports));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateCarPartInventoryReport = new System.Windows.Forms.Button();
            this.btnGenerateCustomerReport = new System.Windows.Forms.Button();
            this.btnGenerateCarInventoryReport = new System.Windows.Forms.Button();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripManageCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCustomerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Reports";
            // 
            // btnGenerateCarPartInventoryReport
            // 
            this.btnGenerateCarPartInventoryReport.BackColor = System.Drawing.Color.Blue;
            this.btnGenerateCarPartInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateCarPartInventoryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCarPartInventoryReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCarPartInventoryReport.Location = new System.Drawing.Point(476, 98);
            this.btnGenerateCarPartInventoryReport.Name = "btnGenerateCarPartInventoryReport";
            this.btnGenerateCarPartInventoryReport.Size = new System.Drawing.Size(184, 54);
            this.btnGenerateCarPartInventoryReport.TabIndex = 3;
            this.btnGenerateCarPartInventoryReport.Text = "Generate Car Part Inventory Report";
            this.btnGenerateCarPartInventoryReport.UseVisualStyleBackColor = false;
            this.btnGenerateCarPartInventoryReport.Click += new System.EventHandler(this.btnGenerateCarPartInventoryReport_Click);
            // 
            // btnGenerateCustomerReport
            // 
            this.btnGenerateCustomerReport.BackColor = System.Drawing.Color.Green;
            this.btnGenerateCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateCustomerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCustomerReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCustomerReport.Location = new System.Drawing.Point(32, 98);
            this.btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            this.btnGenerateCustomerReport.Size = new System.Drawing.Size(184, 54);
            this.btnGenerateCustomerReport.TabIndex = 4;
            this.btnGenerateCustomerReport.Text = "Generate Customer Report";
            this.btnGenerateCustomerReport.UseVisualStyleBackColor = false;
            this.btnGenerateCustomerReport.Click += new System.EventHandler(this.btnGenerateCustomerReport_Click);
            // 
            // btnGenerateCarInventoryReport
            // 
            this.btnGenerateCarInventoryReport.BackColor = System.Drawing.Color.Yellow;
            this.btnGenerateCarInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateCarInventoryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCarInventoryReport.Location = new System.Drawing.Point(252, 98);
            this.btnGenerateCarInventoryReport.Name = "btnGenerateCarInventoryReport";
            this.btnGenerateCarInventoryReport.Size = new System.Drawing.Size(184, 54);
            this.btnGenerateCarInventoryReport.TabIndex = 5;
            this.btnGenerateCarInventoryReport.Text = "Generate Car Inventory Report";
            this.btnGenerateCarInventoryReport.UseVisualStyleBackColor = false;
            this.btnGenerateCarInventoryReport.Click += new System.EventHandler(this.btnGenerateCarInventoryReport_Click);
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
            this.menuStripAdmin.Size = new System.Drawing.Size(697, 24);
            this.menuStripAdmin.TabIndex = 9;
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
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 179);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.btnGenerateCarInventoryReport);
            this.Controls.Add(this.btnGenerateCustomerReport);
            this.Controls.Add(this.btnGenerateCarPartInventoryReport);
            this.Controls.Add(this.label1);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateCarPartInventoryReport;
        private System.Windows.Forms.Button btnGenerateCustomerReport;
        private System.Windows.Forms.Button btnGenerateCarInventoryReport;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCustomerDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageOrders;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripGenerateReports;
    }
}