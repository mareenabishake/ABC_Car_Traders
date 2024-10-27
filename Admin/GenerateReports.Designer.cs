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
            this.btnGenerateOrderReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 113);
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
            this.btnGenerateCarPartInventoryReport.Location = new System.Drawing.Point(169, 242);
            this.btnGenerateCarPartInventoryReport.Name = "btnGenerateCarPartInventoryReport";
            this.btnGenerateCarPartInventoryReport.Size = new System.Drawing.Size(238, 36);
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
            this.btnGenerateCustomerReport.Location = new System.Drawing.Point(169, 165);
            this.btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            this.btnGenerateCustomerReport.Size = new System.Drawing.Size(238, 36);
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
            this.btnGenerateCarInventoryReport.Location = new System.Drawing.Point(169, 393);
            this.btnGenerateCarInventoryReport.Name = "btnGenerateCarInventoryReport";
            this.btnGenerateCarInventoryReport.Size = new System.Drawing.Size(238, 36);
            this.btnGenerateCarInventoryReport.TabIndex = 5;
            this.btnGenerateCarInventoryReport.Text = "Generate Car Inventory Report";
            this.btnGenerateCarInventoryReport.UseVisualStyleBackColor = false;
            this.btnGenerateCarInventoryReport.Click += new System.EventHandler(this.btnGenerateCarInventoryReport_Click);
            // 
            // btnGenerateOrderReport
            // 
            this.btnGenerateOrderReport.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGenerateOrderReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateOrderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateOrderReport.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateOrderReport.Location = new System.Drawing.Point(169, 318);
            this.btnGenerateOrderReport.Name = "btnGenerateOrderReport";
            this.btnGenerateOrderReport.Size = new System.Drawing.Size(238, 36);
            this.btnGenerateOrderReport.TabIndex = 6;
            this.btnGenerateOrderReport.Text = "Generate Order Report";
            this.btnGenerateOrderReport.UseVisualStyleBackColor = false;
            this.btnGenerateOrderReport.Click += new System.EventHandler(this.btnGenerateOrderReport_Click_1);
            // 
            // GenerateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnGenerateOrderReport);
            this.Controls.Add(this.btnGenerateCarInventoryReport);
            this.Controls.Add(this.btnGenerateCustomerReport);
            this.Controls.Add(this.btnGenerateCarPartInventoryReport);
            this.Controls.Add(this.label1);
            this.Name = "GenerateReports";
            this.Text = "GenerateReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateCarPartInventoryReport;
        private System.Windows.Forms.Button btnGenerateCustomerReport;
        private System.Windows.Forms.Button btnGenerateCarInventoryReport;
        private System.Windows.Forms.Button btnGenerateOrderReport;
    }
}