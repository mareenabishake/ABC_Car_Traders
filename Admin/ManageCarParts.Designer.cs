namespace ABC_Car_Traders
{
    partial class ManageCarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarParts));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.dgvCarParts = new System.Windows.Forms.DataGridView();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripManageCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCustomerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(258, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Car Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(168, 193);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(263, 94);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(141, 26);
            this.txtPartID.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(263, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(263, 158);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(141, 26);
            this.txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 26);
            this.txtName.TabIndex = 9;
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(456, 100);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(103, 28);
            this.btnAddPart.TabIndex = 10;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.ForeColor = System.Drawing.Color.White;
            this.btnDeletePart.Location = new System.Drawing.Point(456, 177);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(103, 28);
            this.btnDeletePart.TabIndex = 11;
            this.btnDeletePart.Text = "Delete Part";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPart.Location = new System.Drawing.Point(456, 140);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(103, 28);
            this.btnEditPart.TabIndex = 12;
            this.btnEditPart.Text = "Edit Part";
            this.btnEditPart.UseVisualStyleBackColor = false;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // dgvCarParts
            // 
            this.dgvCarParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarParts.Location = new System.Drawing.Point(12, 242);
            this.dgvCarParts.Name = "dgvCarParts";
            this.dgvCarParts.Size = new System.Drawing.Size(668, 226);
            this.dgvCarParts.TabIndex = 13;
            this.dgvCarParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarParts_CellClick);
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
            this.menuStripAdmin.Size = new System.Drawing.Size(692, 24);
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
            // ManageCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 480);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.dgvCarParts);
            this.Controls.Add(this.btnEditPart);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManageCarParts";
            this.Text = "ManageCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarParts)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.DataGridView dgvCarParts;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCustomerDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageOrders;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripGenerateReports;
    }
}