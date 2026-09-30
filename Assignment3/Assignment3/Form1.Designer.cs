namespace Assignment3
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
            this.txtboxfood1 = new System.Windows.Forms.TextBox();
            this.txtboxprice1 = new System.Windows.Forms.TextBox();
            this.txtboxfood2 = new System.Windows.Forms.TextBox();
            this.txtboxprice2 = new System.Windows.Forms.TextBox();
            this.lblsalestext = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxfood1
            // 
            this.txtboxfood1.Location = new System.Drawing.Point(346, 41);
            this.txtboxfood1.Name = "txtboxfood1";
            this.txtboxfood1.Size = new System.Drawing.Size(172, 26);
            this.txtboxfood1.TabIndex = 0;
            // 
            // txtboxprice1
            // 
            this.txtboxprice1.Location = new System.Drawing.Point(346, 85);
            this.txtboxprice1.Name = "txtboxprice1";
            this.txtboxprice1.Size = new System.Drawing.Size(172, 26);
            this.txtboxprice1.TabIndex = 1;
            // 
            // txtboxfood2
            // 
            this.txtboxfood2.Location = new System.Drawing.Point(346, 132);
            this.txtboxfood2.Name = "txtboxfood2";
            this.txtboxfood2.Size = new System.Drawing.Size(172, 26);
            this.txtboxfood2.TabIndex = 2;
            // 
            // txtboxprice2
            // 
            this.txtboxprice2.Location = new System.Drawing.Point(346, 186);
            this.txtboxprice2.Name = "txtboxprice2";
            this.txtboxprice2.Size = new System.Drawing.Size(172, 26);
            this.txtboxprice2.TabIndex = 3;
            // 
            // lblsalestext
            // 
            this.lblsalestext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsalestext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestext.Location = new System.Drawing.Point(346, 297);
            this.lblsalestext.Name = "lblsalestext";
            this.lblsalestext.Size = new System.Drawing.Size(184, 39);
            this.lblsalestext.TabIndex = 4;
            // 
            // lblTips
            // 
            this.lblTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(346, 344);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(172, 42);
            this.lblTips.TabIndex = 5;
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(346, 399);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(172, 27);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sales text is :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tips amount : ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total amount :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Enter name food1: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Enter price food1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Enter name food 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Enter price food2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "calculate the price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lblsalestext);
            this.Controls.Add(this.txtboxprice2);
            this.Controls.Add(this.txtboxfood2);
            this.Controls.Add(this.txtboxprice1);
            this.Controls.Add(this.txtboxfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxfood1;
        private System.Windows.Forms.TextBox txtboxprice1;
        private System.Windows.Forms.TextBox txtboxfood2;
        private System.Windows.Forms.TextBox txtboxprice2;
        private System.Windows.Forms.Label lblsalestext;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

