namespace ABC_Car_Traders
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchCarDetails = new System.Windows.Forms.Button();
            this.btnViewOrderStatus = new System.Windows.Forms.Button();
            this.btnOrderCarParts = new System.Windows.Forms.Button();
            this.btnOrderCar = new System.Windows.Forms.Button();
            this.btnSearchCarParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Dashboard";
            // 
            // btnSearchCarDetails
            // 
            this.btnSearchCarDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchCarDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarDetails.ForeColor = System.Drawing.Color.White;
            this.btnSearchCarDetails.Location = new System.Drawing.Point(69, 65);
            this.btnSearchCarDetails.Name = "btnSearchCarDetails";
            this.btnSearchCarDetails.Size = new System.Drawing.Size(162, 37);
            this.btnSearchCarDetails.TabIndex = 1;
            this.btnSearchCarDetails.Text = "Search Car Details";
            this.btnSearchCarDetails.UseVisualStyleBackColor = false;
            this.btnSearchCarDetails.Click += new System.EventHandler(this.btnSearchCarDetails_Click);
            // 
            // btnViewOrderStatus
            // 
            this.btnViewOrderStatus.BackColor = System.Drawing.Color.SlateGray;
            this.btnViewOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderStatus.ForeColor = System.Drawing.Color.White;
            this.btnViewOrderStatus.Location = new System.Drawing.Point(69, 237);
            this.btnViewOrderStatus.Name = "btnViewOrderStatus";
            this.btnViewOrderStatus.Size = new System.Drawing.Size(162, 37);
            this.btnViewOrderStatus.TabIndex = 3;
            this.btnViewOrderStatus.Text = "View Order Status";
            this.btnViewOrderStatus.UseVisualStyleBackColor = false;
            this.btnViewOrderStatus.Click += new System.EventHandler(this.btnViewOrderStatus_Click);
            // 
            // btnOrderCarParts
            // 
            this.btnOrderCarParts.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrderCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCarParts.Location = new System.Drawing.Point(69, 194);
            this.btnOrderCarParts.Name = "btnOrderCarParts";
            this.btnOrderCarParts.Size = new System.Drawing.Size(162, 37);
            this.btnOrderCarParts.TabIndex = 4;
            this.btnOrderCarParts.Text = "Order Car Parts";
            this.btnOrderCarParts.UseVisualStyleBackColor = false;
            this.btnOrderCarParts.Click += new System.EventHandler(this.btnOrderCarParts_Click);
            // 
            // btnOrderCar
            // 
            this.btnOrderCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrderCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCar.Location = new System.Drawing.Point(69, 151);
            this.btnOrderCar.Name = "btnOrderCar";
            this.btnOrderCar.Size = new System.Drawing.Size(162, 37);
            this.btnOrderCar.TabIndex = 5;
            this.btnOrderCar.Text = "Order Car";
            this.btnOrderCar.UseVisualStyleBackColor = false;
            this.btnOrderCar.Click += new System.EventHandler(this.btnOrderCar_Click);
            // 
            // btnSearchCarParts
            // 
            this.btnSearchCarParts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarParts.ForeColor = System.Drawing.Color.White;
            this.btnSearchCarParts.Location = new System.Drawing.Point(69, 108);
            this.btnSearchCarParts.Name = "btnSearchCarParts";
            this.btnSearchCarParts.Size = new System.Drawing.Size(162, 37);
            this.btnSearchCarParts.TabIndex = 6;
            this.btnSearchCarParts.Text = "Search Car Parts";
            this.btnSearchCarParts.UseVisualStyleBackColor = false;
            this.btnSearchCarParts.Click += new System.EventHandler(this.btnSearchCarParts_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(311, 303);
            this.Controls.Add(this.btnSearchCarParts);
            this.Controls.Add(this.btnOrderCar);
            this.Controls.Add(this.btnOrderCarParts);
            this.Controls.Add(this.btnViewOrderStatus);
            this.Controls.Add(this.btnSearchCarDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchCarDetails;
        private System.Windows.Forms.Button btnViewOrderStatus;
        private System.Windows.Forms.Button btnOrderCarParts;
        private System.Windows.Forms.Button btnOrderCar;
        private System.Windows.Forms.Button btnSearchCarParts;
    }
}