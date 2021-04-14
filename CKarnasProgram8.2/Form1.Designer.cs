namespace CKarnasProgram8._2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplaySummary = new System.Windows.Forms.Button();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnCreatePaySlip = new System.Windows.Forms.Button();
            this.lblPayCheckAmount = new System.Windows.Forms.Label();
            this.lblNetpay = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplaySummary);
            this.groupBox1.Controls.Add(this.nudPayRate);
            this.groupBox1.Controls.Add(this.nudHours);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.btnReset1);
            this.groupBox1.Controls.Add(this.btnCreatePaySlip);
            this.groupBox1.Controls.Add(this.lblPayCheckAmount);
            this.groupBox1.Controls.Add(this.lblNetpay);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.lblHoursWorked);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Period";
            // 
            // btnDisplaySummary
            // 
            this.btnDisplaySummary.AutoSize = true;
            this.btnDisplaySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySummary.Location = new System.Drawing.Point(274, 202);
            this.btnDisplaySummary.Name = "btnDisplaySummary";
            this.btnDisplaySummary.Size = new System.Drawing.Size(243, 34);
            this.btnDisplaySummary.TabIndex = 9;
            this.btnDisplaySummary.Text = "&Display Summary";
            this.btnDisplaySummary.UseVisualStyleBackColor = true;
            this.btnDisplaySummary.Click += new System.EventHandler(this.btnDisplaySummary_Click);
            // 
            // nudPayRate
            // 
            this.nudPayRate.DecimalPlaces = 2;
            this.nudPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPayRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudPayRate.Location = new System.Drawing.Point(448, 64);
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(84, 29);
            this.nudPayRate.TabIndex = 6;
            this.nudPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudHours
            // 
            this.nudHours.DecimalPlaces = 2;
            this.nudHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudHours.Location = new System.Drawing.Point(263, 64);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(84, 29);
            this.nudHours.TabIndex = 4;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(263, 22);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(269, 29);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // btnReset1
            // 
            this.btnReset1.AutoSize = true;
            this.btnReset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.Location = new System.Drawing.Point(542, 202);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(129, 34);
            this.btnReset1.TabIndex = 10;
            this.btnReset1.Text = "&Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnCreatePaySlip
            // 
            this.btnCreatePaySlip.AutoSize = true;
            this.btnCreatePaySlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePaySlip.Location = new System.Drawing.Point(274, 147);
            this.btnCreatePaySlip.Name = "btnCreatePaySlip";
            this.btnCreatePaySlip.Size = new System.Drawing.Size(243, 34);
            this.btnCreatePaySlip.TabIndex = 8;
            this.btnCreatePaySlip.Text = "&Create Pay Slip";
            this.btnCreatePaySlip.UseVisualStyleBackColor = true;
            this.btnCreatePaySlip.Click += new System.EventHandler(this.btnCreatePaySlip_Click);
            // 
            // lblPayCheckAmount
            // 
            this.lblPayCheckAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayCheckAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayCheckAmount.Location = new System.Drawing.Point(263, 108);
            this.lblPayCheckAmount.Name = "lblPayCheckAmount";
            this.lblPayCheckAmount.Size = new System.Drawing.Size(269, 25);
            this.lblPayCheckAmount.TabIndex = 7;
            // 
            // lblNetpay
            // 
            this.lblNetpay.AutoSize = true;
            this.lblNetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetpay.Location = new System.Drawing.Point(10, 109);
            this.lblNetpay.Name = "lblNetpay";
            this.lblNetpay.Size = new System.Drawing.Size(181, 24);
            this.lblNetpay.TabIndex = 2;
            this.lblNetpay.Text = "PayCheck (after tax):";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(353, 66);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(89, 24);
            this.lblPayRate.TabIndex = 5;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(54, 66);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(137, 24);
            this.lblHoursWorked.TabIndex = 1;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(34, 27);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(157, 24);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(575, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(12, 310);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloper.TabIndex = 10;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 332);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnCreatePaySlip;
        private System.Windows.Forms.Label lblPayCheckAmount;
        private System.Windows.Forms.Label lblNetpay;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnDisplaySummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblDeveloper;
    }
}

