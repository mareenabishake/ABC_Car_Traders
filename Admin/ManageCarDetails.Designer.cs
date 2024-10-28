namespace ABC_Car_Traders
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(173, 51);
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
            this.lblCarID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCarID.Location = new System.Drawing.Point(78, 110);
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
            this.lblMake.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMake.Location = new System.Drawing.Point(78, 149);
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
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(82, 192);
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
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(292, 149);
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
            this.lblModel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModel.Location = new System.Drawing.Point(292, 108);
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
            this.btnAddCar.Location = new System.Drawing.Point(69, 252);
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
            this.btnEditCar.Location = new System.Drawing.Point(238, 252);
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
            this.btnDeleteCar.Location = new System.Drawing.Point(402, 252);
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
            this.txtCarID.Location = new System.Drawing.Point(139, 107);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(125, 26);
            this.txtCarID.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(139, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(353, 146);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 26);
            this.txtYear.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(353, 105);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(125, 26);
            this.txtModel.TabIndex = 15;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(139, 146);
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
            this.dgvCarDetails.Size = new System.Drawing.Size(560, 150);
            this.dgvCarDetails.TabIndex = 17;
            this.dgvCarDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarDetails_CellClick);
            // 
            // ManageCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.istockphoto_1209030907_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
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
    }
}
