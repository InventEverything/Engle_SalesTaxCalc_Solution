namespace Engle_SalesTaxCalc_Project
{
    partial class frmVehicleSalesTaxCalculator
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
            this.txtVehiclePrice = new System.Windows.Forms.TextBox();
            this.cboWarranty = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVehiclePrice
            // 
            this.txtVehiclePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiclePrice.Location = new System.Drawing.Point(235, 78);
            this.txtVehiclePrice.Name = "txtVehiclePrice";
            this.txtVehiclePrice.Size = new System.Drawing.Size(184, 32);
            this.txtVehiclePrice.TabIndex = 0;
            this.txtVehiclePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVehiclePrice_KeyDown);
            // 
            // cboWarranty
            // 
            this.cboWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboWarranty.FormattingEnabled = true;
            this.cboWarranty.Items.AddRange(new object[] {
            "No Warranty",
            "One Year",
            "Two Year",
            "Three Year"});
            this.cboWarranty.Location = new System.Drawing.Point(235, 134);
            this.cboWarranty.Name = "cboWarranty";
            this.cboWarranty.Size = new System.Drawing.Size(184, 33);
            this.cboWarranty.TabIndex = 1;
            this.cboWarranty.Text = "No Warranty";
            this.cboWarranty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboWarranty_KeyDown);
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.cboState.Location = new System.Drawing.Point(235, 186);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(59, 33);
            this.cboState.TabIndex = 2;
            this.cboState.Text = "WA";
            this.cboState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboState_KeyDown);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(350, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 33);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(308, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(389, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(27, 256);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(246, 26);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Total Vehicle Cost Is: ";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalCost.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 26);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(27, 81);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(202, 26);
            this.lblBasePrice.TabIndex = 8;
            this.lblBasePrice.Text = "Vehicle Base Price:";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(25, 137);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(204, 26);
            this.lblWarranty.TabIndex = 9;
            this.lblWarranty.Text = "Extended Warranty:";
            this.lblWarranty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(110, 189);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(119, 26);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State Sold:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(279, 256);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 26);
            this.lblGrandTotal.TabIndex = 11;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmVehicleSalesTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.cboWarranty);
            this.Controls.Add(this.txtVehiclePrice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmVehicleSalesTaxCalculator";
            this.Text = "Billy-Bob’s Bunch-O-Cars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehiclePrice;
        private System.Windows.Forms.ComboBox cboWarranty;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}

