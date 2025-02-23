
namespace TripCost
{
    partial class frmTripCost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCarTankCapacity = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtGallonsLeft = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtGasCostPerGallon = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtMilesDriven = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblCostOfTrip = new System.Windows.Forms.Label();
            lblMilesPerGallon = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtCarTankCapacity
            // 
            txtCarTankCapacity.Location = new System.Drawing.Point(266, 14);
            txtCarTankCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCarTankCapacity.Name = "txtCarTankCapacity";
            txtCarTankCapacity.Size = new System.Drawing.Size(148, 26);
            txtCarTankCapacity.TabIndex = 1;
            txtCarTankCapacity.TextChanged += txtCarTankCapacity_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Car gas tank capacity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(207, 20);
            label2.TabIndex = 2;
            label2.Text = "Gallons left in tank after trip:";
            // 
            // txtGallonsLeft
            // 
            txtGallonsLeft.Location = new System.Drawing.Point(266, 47);
            txtGallonsLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtGallonsLeft.Name = "txtGallonsLeft";
            txtGallonsLeft.Size = new System.Drawing.Size(148, 26);
            txtGallonsLeft.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(226, 20);
            label3.TabIndex = 6;
            label3.Text = "Cost of gas per gallon to fill-up:";
            // 
            // txtGasCostPerGallon
            // 
            txtGasCostPerGallon.Location = new System.Drawing.Point(266, 116);
            txtGasCostPerGallon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtGasCostPerGallon.Name = "txtGasCostPerGallon";
            txtGasCostPerGallon.Size = new System.Drawing.Size(148, 26);
            txtGasCostPerGallon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 83);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(143, 20);
            label4.TabIndex = 4;
            label4.Text = "Miles driven on trip:";
            // 
            // txtMilesDriven
            // 
            txtMilesDriven.Location = new System.Drawing.Point(266, 83);
            txtMilesDriven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMilesDriven.Name = "txtMilesDriven";
            txtMilesDriven.Size = new System.Drawing.Size(148, 26);
            txtMilesDriven.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(149, 232);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(126, 29);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(36, 188);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 20);
            label5.TabIndex = 10;
            label5.Text = "Gas cost of trip:";
            // 
            // lblCostOfTrip
            // 
            lblCostOfTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCostOfTrip.Location = new System.Drawing.Point(262, 188);
            lblCostOfTrip.Name = "lblCostOfTrip";
            lblCostOfTrip.Size = new System.Drawing.Size(87, 28);
            lblCostOfTrip.TabIndex = 11;
            lblCostOfTrip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMilesPerGallon
            // 
            lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblMilesPerGallon.Location = new System.Drawing.Point(262, 160);
            lblMilesPerGallon.Name = "lblMilesPerGallon";
            lblMilesPerGallon.Size = new System.Drawing.Size(87, 28);
            lblMilesPerGallon.TabIndex = 9;
            lblMilesPerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(36, 160);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(122, 20);
            label8.TabIndex = 8;
            label8.Text = "Miles per gallon:";
            // 
            // frmTripCost
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(457, 288);
            Controls.Add(lblMilesPerGallon);
            Controls.Add(label8);
            Controls.Add(lblCostOfTrip);
            Controls.Add(label5);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(txtGasCostPerGallon);
            Controls.Add(label4);
            Controls.Add(txtMilesDriven);
            Controls.Add(label2);
            Controls.Add(txtGallonsLeft);
            Controls.Add(label1);
            Controls.Add(txtCarTankCapacity);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmTripCost";
            Text = "Mileage Cost of Trip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtCarTankCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGallonsLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGasCostPerGallon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCostOfTrip;
        private System.Windows.Forms.Label lblMilesPerGallon;
        private System.Windows.Forms.Label label8;
    }
}

