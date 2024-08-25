namespace ABC_Car_Traders
{
    partial class ViewOrderStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.menuStripCustomer = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripSearchCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripSearchCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Order Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(195, 80);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(158, 26);
            this.txtOrderID.TabIndex = 2;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.Location = new System.Drawing.Point(368, 79);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(117, 27);
            this.btnViewStatus.TabIndex = 3;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // menuStripCustomer
            // 
            this.menuStripCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenuStripSearchCarDetails,
            this.txtMenuStripSearchCarParts,
            this.txtMenuStripOrderCar,
            this.txtMenuStripOrderCarParts,
            this.txtMenuStripOrderStatus});
            this.menuStripCustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripCustomer.Name = "menuStripCustomer";
            this.menuStripCustomer.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripCustomer.Size = new System.Drawing.Size(584, 24);
            this.menuStripCustomer.TabIndex = 11;
            this.menuStripCustomer.Text = "menuStrip1";
            // 
            // txtMenuStripSearchCarDetails
            // 
            this.txtMenuStripSearchCarDetails.BackColor = System.Drawing.Color.Lavender;
            this.txtMenuStripSearchCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripSearchCarDetails.Name = "txtMenuStripSearchCarDetails";
            this.txtMenuStripSearchCarDetails.Size = new System.Drawing.Size(131, 20);
            this.txtMenuStripSearchCarDetails.Text = "Search Car Details";
            this.txtMenuStripSearchCarDetails.Click += new System.EventHandler(this.txtMenuStripSearchCarDetails_Click);
            // 
            // txtMenuStripSearchCarParts
            // 
            this.txtMenuStripSearchCarParts.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMenuStripSearchCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripSearchCarParts.Name = "txtMenuStripSearchCarParts";
            this.txtMenuStripSearchCarParts.Size = new System.Drawing.Size(120, 20);
            this.txtMenuStripSearchCarParts.Text = "Search Car Parts";
            this.txtMenuStripSearchCarParts.Click += new System.EventHandler(this.txtMenuStripSearchCarParts_Click);
            // 
            // txtMenuStripOrderCar
            // 
            this.txtMenuStripOrderCar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMenuStripOrderCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripOrderCar.Name = "txtMenuStripOrderCar";
            this.txtMenuStripOrderCar.Size = new System.Drawing.Size(77, 20);
            this.txtMenuStripOrderCar.Text = "Order Car";
            this.txtMenuStripOrderCar.Click += new System.EventHandler(this.txtMenuStripOrderCar_Click);
            // 
            // txtMenuStripOrderCarParts
            // 
            this.txtMenuStripOrderCarParts.BackColor = System.Drawing.Color.MistyRose;
            this.txtMenuStripOrderCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripOrderCarParts.Name = "txtMenuStripOrderCarParts";
            this.txtMenuStripOrderCarParts.Size = new System.Drawing.Size(111, 20);
            this.txtMenuStripOrderCarParts.Text = "Order Car Parts";
            this.txtMenuStripOrderCarParts.Click += new System.EventHandler(this.txtMenuStripOrderCarParts_Click);
            // 
            // txtMenuStripOrderStatus
            // 
            this.txtMenuStripOrderStatus.BackColor = System.Drawing.Color.Honeydew;
            this.txtMenuStripOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuStripOrderStatus.Name = "txtMenuStripOrderStatus";
            this.txtMenuStripOrderStatus.Size = new System.Drawing.Size(125, 20);
            this.txtMenuStripOrderStatus.Text = "View Order Status";
            this.txtMenuStripOrderStatus.Click += new System.EventHandler(this.txtMenuStripOrderStatus_Click);
            // 
            // ViewOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 133);
            this.Controls.Add(this.menuStripCustomer);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrderStatus";
            this.Text = "ViewOrderStatus";
            this.menuStripCustomer.ResumeLayout(false);
            this.menuStripCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.MenuStrip menuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCar;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderStatus;
    }
}