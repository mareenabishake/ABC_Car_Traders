﻿namespace ABC_Car_Traders
{
    partial class ManageCarDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarDetails));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.dgvCarDetails = new System.Windows.Forms.DataGridView();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.txtMenuStripManageCarDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCarParts = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageCustomerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMenuStripGenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarDetails)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(205, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Car Details";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.BackColor = System.Drawing.Color.Transparent;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(140, 106);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(55, 20);
            this.lblCarID.TabIndex = 2;
            this.lblCarID.Text = "Car ID";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Transparent;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(140, 138);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(48, 20);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(144, 242);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(140, 208);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(140, 174);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(390, 123);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(100, 29);
            this.btnAddCar.TabIndex = 7;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(390, 170);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(100, 29);
            this.btnEditCar.TabIndex = 8;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.Location = new System.Drawing.Point(390, 213);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(100, 29);
            this.btnDeleteCar.TabIndex = 9;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtCarID
            // 
            this.txtCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarID.Location = new System.Drawing.Point(201, 103);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(125, 26);
            this.txtCarID.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(201, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(201, 205);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 26);
            this.txtYear.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(201, 171);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(125, 26);
            this.txtModel.TabIndex = 15;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(201, 135);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(125, 26);
            this.txtMake.TabIndex = 16;
            // 
            // dgvCarDetails
            // 
            this.dgvCarDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarDetails.Location = new System.Drawing.Point(12, 300);
            this.dgvCarDetails.Name = "dgvCarDetails";
            this.dgvCarDetails.Size = new System.Drawing.Size(667, 215);
            this.dgvCarDetails.TabIndex = 17;
            this.dgvCarDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarDetails_CellClick);
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
            this.menuStripAdmin.Size = new System.Drawing.Size(691, 24);
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
            // ManageCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 531);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.dgvCarDetails);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManageCarDetails";
            this.Text = "ManageCarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarDetails)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.DataGridView dgvCarDetails;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCarParts;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageCustomerDetails;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripManageOrders;
        private System.Windows.Forms.ToolStripMenuItem txtMenuStripGenerateReports;
    }
}