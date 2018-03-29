namespace Conversion
{
    partial class Conversion
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
            this.convertBTN = new System.Windows.Forms.Button();
            this.outArabicLB = new System.Windows.Forms.Label();
            this.outRomanLB = new System.Windows.Forms.Label();
            this.arabicLB = new System.Windows.Forms.Label();
            this.romanLB = new System.Windows.Forms.Label();
            this.inArabicNumTB = new System.Windows.Forms.TextBox();
            this.inRomanNumTB = new System.Windows.Forms.TextBox();
            this.convertRBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertBTN
            // 
            this.convertBTN.Location = new System.Drawing.Point(12, 85);
            this.convertBTN.Name = "convertBTN";
            this.convertBTN.Size = new System.Drawing.Size(75, 53);
            this.convertBTN.TabIndex = 0;
            this.convertBTN.Text = "Convert Arabic";
            this.convertBTN.UseVisualStyleBackColor = true;
            this.convertBTN.Click += new System.EventHandler(this.convertBTN_Click);
            // 
            // outArabicLB
            // 
            this.outArabicLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outArabicLB.Location = new System.Drawing.Point(12, 171);
            this.outArabicLB.Name = "outArabicLB";
            this.outArabicLB.Size = new System.Drawing.Size(100, 23);
            this.outArabicLB.TabIndex = 1;
            // 
            // outRomanLB
            // 
            this.outRomanLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outRomanLB.Location = new System.Drawing.Point(169, 171);
            this.outRomanLB.Name = "outRomanLB";
            this.outRomanLB.Size = new System.Drawing.Size(100, 23);
            this.outRomanLB.TabIndex = 2;
            // 
            // arabicLB
            // 
            this.arabicLB.AutoSize = true;
            this.arabicLB.Location = new System.Drawing.Point(9, 9);
            this.arabicLB.Name = "arabicLB";
            this.arabicLB.Size = new System.Drawing.Size(40, 13);
            this.arabicLB.TabIndex = 3;
            this.arabicLB.Text = "Arabic:";
            // 
            // romanLB
            // 
            this.romanLB.AutoSize = true;
            this.romanLB.Location = new System.Drawing.Point(166, 9);
            this.romanLB.Name = "romanLB";
            this.romanLB.Size = new System.Drawing.Size(44, 13);
            this.romanLB.TabIndex = 4;
            this.romanLB.Text = "Roman:";
            // 
            // inArabicNumTB
            // 
            this.inArabicNumTB.Location = new System.Drawing.Point(12, 35);
            this.inArabicNumTB.Name = "inArabicNumTB";
            this.inArabicNumTB.Size = new System.Drawing.Size(100, 20);
            this.inArabicNumTB.TabIndex = 5;
            // 
            // inRomanNumTB
            // 
            this.inRomanNumTB.Location = new System.Drawing.Point(169, 35);
            this.inRomanNumTB.Name = "inRomanNumTB";
            this.inRomanNumTB.Size = new System.Drawing.Size(100, 20);
            this.inRomanNumTB.TabIndex = 6;
            // 
            // convertRBTN
            // 
            this.convertRBTN.Location = new System.Drawing.Point(169, 85);
            this.convertRBTN.Name = "convertRBTN";
            this.convertRBTN.Size = new System.Drawing.Size(75, 53);
            this.convertRBTN.TabIndex = 7;
            this.convertRBTN.Text = "Convert Roman";
            this.convertRBTN.UseVisualStyleBackColor = true;
            this.convertRBTN.Click += new System.EventHandler(this.convertRBTN_Click);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.convertRBTN);
            this.Controls.Add(this.inRomanNumTB);
            this.Controls.Add(this.inArabicNumTB);
            this.Controls.Add(this.romanLB);
            this.Controls.Add(this.arabicLB);
            this.Controls.Add(this.outRomanLB);
            this.Controls.Add(this.outArabicLB);
            this.Controls.Add(this.convertBTN);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertBTN;
        private System.Windows.Forms.Label outArabicLB;
        private System.Windows.Forms.Label outRomanLB;
        private System.Windows.Forms.Label arabicLB;
        private System.Windows.Forms.Label romanLB;
        private System.Windows.Forms.TextBox inArabicNumTB;
        private System.Windows.Forms.TextBox inRomanNumTB;
        private System.Windows.Forms.Button convertRBTN;
    }
}

