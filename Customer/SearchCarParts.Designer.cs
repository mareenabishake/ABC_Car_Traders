namespace ABC_Car_Traders
{
    partial class SearchCarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarParts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.menuStripCustomer = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripSearchCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripSearchCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripOrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.menuStripCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Car Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part ID";
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(206, 96);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(149, 26);
            this.txtPartID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(374, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(12, 139);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.Size = new System.Drawing.Size(548, 230);
            this.dgvCarParts.TabIndex = 4;
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
            this.menuStripCustomer.Size = new System.Drawing.Size(582, 24);
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
            // SearchCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.menuStripCustomer);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchCarParts";
            this.Text = "SearchCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.menuStripCustomer.ResumeLayout(false);
            this.menuStripCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCarParts;
        private System.Windows.Forms.MenuStrip menuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripSearchCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCar;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripOrderStatus;
    }
}