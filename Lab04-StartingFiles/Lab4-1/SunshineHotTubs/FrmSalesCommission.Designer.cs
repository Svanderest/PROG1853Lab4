namespace SunshineHotTubs
{
    partial class FrmSalesCommission
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtSaleTotal = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.btnCalcCommission = new System.Windows.Forms.Button();
            this.btnDisplayCommission = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Person (Initial):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sale Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Commission:";
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(137, 19);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(53, 20);
            this.txtInitial.TabIndex = 1;
            this.txtInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaleTotal
            // 
            this.txtSaleTotal.Location = new System.Drawing.Point(90, 57);
            this.txtSaleTotal.Name = "txtSaleTotal";
            this.txtSaleTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSaleTotal.TabIndex = 3;
            this.txtSaleTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCommission
            // 
            this.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommission.Location = new System.Drawing.Point(97, 93);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(93, 23);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalcCommission
            // 
            this.btnCalcCommission.Location = new System.Drawing.Point(12, 137);
            this.btnCalcCommission.Name = "btnCalcCommission";
            this.btnCalcCommission.Size = new System.Drawing.Size(84, 39);
            this.btnCalcCommission.TabIndex = 6;
            this.btnCalcCommission.Text = "&Calculate Commission";
            this.btnCalcCommission.UseVisualStyleBackColor = true;
            this.btnCalcCommission.Click += new System.EventHandler(this.btnCalcCommission_Click);
            // 
            // btnDisplayCommission
            // 
            this.btnDisplayCommission.Location = new System.Drawing.Point(120, 137);
            this.btnDisplayCommission.Name = "btnDisplayCommission";
            this.btnDisplayCommission.Size = new System.Drawing.Size(84, 39);
            this.btnDisplayCommission.TabIndex = 7;
            this.btnDisplayCommission.Text = "&Display Total Commissions";
            this.btnDisplayCommission.UseVisualStyleBackColor = true;
            this.btnDisplayCommission.Click += new System.EventHandler(this.btnDisplayCommission_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(12, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(120, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmSalesCommission
            // 
            this.AcceptButton = this.btnCalcCommission;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(216, 218);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayCommission);
            this.Controls.Add(this.btnCalcCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtSaleTotal);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSalesCommission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunshine Hot Tubs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtSaleTotal;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Button btnCalcCommission;
        private System.Windows.Forms.Button btnDisplayCommission;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

