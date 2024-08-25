namespace ABC_Car_Traders
{
    partial class OrderCarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCarParts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOrderCarPart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dgvPartDetails = new System.Windows.Forms.DataGridView();
            this.menuStripCustomer = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripSearchCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripSearchCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartDetails)).BeginInit();
            this.menuStripCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Car Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part ID";
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(205, 125);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(166, 26);
            this.txtPartID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(205, 157);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(166, 26);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnOrderCarPart
            // 
            this.btnOrderCarPart.BackColor = System.Drawing.Color.LightGreen;
            this.btnOrderCarPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderCarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCarPart.Location = new System.Drawing.Point(399, 114);
            this.btnOrderCarPart.Name = "btnOrderCarPart";
            this.btnOrderCarPart.Size = new System.Drawing.Size(92, 49);
            this.btnOrderCarPart.TabIndex = 5;
            this.btnOrderCarPart.Text = "Order \r\nCar Part";
            this.btnOrderCarPart.UseVisualStyleBackColor = false;
            this.btnOrderCarPart.Click += new System.EventHandler(this.btnOrderCarPart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(205, 93);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(166, 26);
            this.txtCustomerID.TabIndex = 8;
            // 
            // dgvPartDetails
            // 
            this.dgvPartDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPartDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartDetails.Location = new System.Drawing.Point(12, 207);
            this.dgvPartDetails.Name = "dgvPartDetails";
            this.dgvPartDetails.Size = new System.Drawing.Size(566, 189);
            this.dgvPartDetails.TabIndex = 9;
            this.dgvPartDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarPartDetails_CellClick);
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
            this.menuStripCustomer.Size = new System.Drawing.Size(590, 24);
            this.menuStripCustomer.TabIndex = 12;
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
            // OrderCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 410);
            this.Controls.Add(this.menuStripCustomer);
            this.Controls.Add(this.dgvPartDetails);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOrderCarPart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderCarParts";
            this.Text = "OrderCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartDetails)).EndInit();
            this.menuStripCustomer.ResumeLayout(false);
            this.menuStripCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOrderCarPart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView dgvPartDetails;
        private System.Windows.Forms.MenuStrip menuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCar;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderStatus;
    }
}