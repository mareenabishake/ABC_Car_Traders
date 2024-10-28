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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.dgvViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 41);
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
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(103, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(179, 116);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(158, 26);
            this.txtOrderID.TabIndex = 2;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.Location = new System.Drawing.Point(352, 115);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(117, 27);
            this.btnViewStatus.TabIndex = 3;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // dgvViewOrderStatus
            // 
            this.dgvViewOrderStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewOrderStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewOrderStatus.Location = new System.Drawing.Point(12, 235);
            this.dgvViewOrderStatus.Name = "dgvViewOrderStatus";
            this.dgvViewOrderStatus.Size = new System.Drawing.Size(560, 150);
            this.dgvViewOrderStatus.TabIndex = 4;
            this.dgvViewOrderStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewOrderStatus_CellClick);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrderStatus.Location = new System.Drawing.Point(185, 189);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(114, 24);
            this.lblOrderStatus.TabIndex = 7;
            this.lblOrderStatus.Text = "Order Status";
            this.lblOrderStatus.Visible = false;
            // 
            // ViewOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.istockphoto_1209030907_612x612;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.dgvViewOrderStatus);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrderStatus";
            this.Text = "ViewOrderStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrderStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.DataGridView dgvViewOrderStatus;
        private System.Windows.Forms.Label lblOrderStatus;
    }
}
