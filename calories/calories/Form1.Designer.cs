namespace calories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.textBoxFat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxLowfat = new System.Windows.Forms.CheckBox();
            this.labelFatgrams = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter n. of calories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the fat";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(360, 56);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(191, 26);
            this.textBoxCalories.TabIndex = 2;
            // 
            // textBoxFat
            // 
            this.textBoxFat.Location = new System.Drawing.Point(360, 102);
            this.textBoxFat.Name = "textBoxFat";
            this.textBoxFat.Size = new System.Drawing.Size(191, 26);
            this.textBoxFat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxLowfat
            // 
            this.checkBoxLowfat.AutoSize = true;
            this.checkBoxLowfat.Location = new System.Drawing.Point(93, 182);
            this.checkBoxLowfat.Name = "checkBoxLowfat";
            this.checkBoxLowfat.Size = new System.Drawing.Size(83, 24);
            this.checkBoxLowfat.TabIndex = 5;
            this.checkBoxLowfat.Text = "Lowfat";
            this.checkBoxLowfat.UseVisualStyleBackColor = true;
            // 
            // labelFatgrams
            // 
            this.labelFatgrams.Location = new System.Drawing.Point(242, 337);
            this.labelFatgrams.Name = "labelFatgrams";
            this.labelFatgrams.Size = new System.Drawing.Size(201, 47);
            this.labelFatgrams.TabIndex = 6;
            // 
            // labelPercentage
            // 
            this.labelPercentage.Location = new System.Drawing.Point(231, 394);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(223, 42);
            this.labelPercentage.TabIndex = 7;
            this.labelPercentage.Click += new System.EventHandler(this.labelPercentage_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Percentage:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 47);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of calories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelFatgrams);
            this.Controls.Add(this.checkBoxLowfat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFat);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.TextBox textBoxFat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLowfat;
        private System.Windows.Forms.Label labelFatgrams;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

