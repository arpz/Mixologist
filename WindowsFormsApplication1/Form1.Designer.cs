namespace WindowsFormsApplication1
{
    partial class mainForm
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
            this.txtDesiredStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBottleSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseNic = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultNic = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desired Nicotine Str";
            // 
            // txtDesiredStr
            // 
            this.txtDesiredStr.Location = new System.Drawing.Point(119, 68);
            this.txtDesiredStr.Name = "txtDesiredStr";
            this.txtDesiredStr.Size = new System.Drawing.Size(101, 20);
            this.txtDesiredStr.TabIndex = 1;
            this.txtDesiredStr.TextChanged += new System.EventHandler(this.txtDesiredStr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount to make";
            // 
            // txtBottleSize
            // 
            this.txtBottleSize.Location = new System.Drawing.Point(120, 44);
            this.txtBottleSize.Name = "txtBottleSize";
            this.txtBottleSize.Size = new System.Drawing.Size(100, 20);
            this.txtBottleSize.TabIndex = 3;
            this.txtBottleSize.TextChanged += new System.EventHandler(this.txtBottleSize_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base Nic Strength";
            // 
            // txtBaseNic
            // 
            this.txtBaseNic.Location = new System.Drawing.Point(120, 20);
            this.txtBaseNic.Name = "txtBaseNic";
            this.txtBaseNic.Size = new System.Drawing.Size(100, 20);
            this.txtBaseNic.TabIndex = 5;
            this.txtBaseNic.TextChanged += new System.EventHandler(this.txtBaseNic_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultNic);
            this.groupBox1.Location = new System.Drawing.Point(239, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lblResultNic
            // 
            this.lblResultNic.AutoSize = true;
            this.lblResultNic.Location = new System.Drawing.Point(6, 27);
            this.lblResultNic.Name = "lblResultNic";
            this.lblResultNic.Size = new System.Drawing.Size(52, 13);
            this.lblResultNic.TabIndex = 0;
            this.lblResultNic.Text = "Nicotine: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBaseNic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBottleSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesiredStr);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Mixologist 0.1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesiredStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBottleSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseNic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultNic;
    }
}

