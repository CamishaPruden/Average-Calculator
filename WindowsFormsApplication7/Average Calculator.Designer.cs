namespace WindowsFormsApplication7
{
    partial class AverageCalculator
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
            this.txtMarkOne = new System.Windows.Forms.TextBox();
            this.txtMarkFive = new System.Windows.Forms.TextBox();
            this.txtMarkThree = new System.Windows.Forms.TextBox();
            this.txtMarkFour = new System.Windows.Forms.TextBox();
            this.txtMarkTwo = new System.Windows.Forms.TextBox();
            this.lblMarkOne = new System.Windows.Forms.Label();
            this.lblMarkTwo = new System.Windows.Forms.Label();
            this.lblMarkThree = new System.Windows.Forms.Label();
            this.lblMarkFour = new System.Windows.Forms.Label();
            this.lblMarkFive = new System.Windows.Forms.Label();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarkOne
            // 
            this.txtMarkOne.Location = new System.Drawing.Point(84, 10);
            this.txtMarkOne.Name = "txtMarkOne";
            this.txtMarkOne.Size = new System.Drawing.Size(100, 20);
            this.txtMarkOne.TabIndex = 0;
            // 
            // txtMarkFive
            // 
            this.txtMarkFive.Location = new System.Drawing.Point(84, 98);
            this.txtMarkFive.Name = "txtMarkFive";
            this.txtMarkFive.Size = new System.Drawing.Size(100, 20);
            this.txtMarkFive.TabIndex = 1;
            // 
            // txtMarkThree
            // 
            this.txtMarkThree.Location = new System.Drawing.Point(84, 54);
            this.txtMarkThree.Name = "txtMarkThree";
            this.txtMarkThree.Size = new System.Drawing.Size(100, 20);
            this.txtMarkThree.TabIndex = 2;
            // 
            // txtMarkFour
            // 
            this.txtMarkFour.Location = new System.Drawing.Point(84, 76);
            this.txtMarkFour.Name = "txtMarkFour";
            this.txtMarkFour.Size = new System.Drawing.Size(100, 20);
            this.txtMarkFour.TabIndex = 3;
            // 
            // txtMarkTwo
            // 
            this.txtMarkTwo.Location = new System.Drawing.Point(84, 32);
            this.txtMarkTwo.Name = "txtMarkTwo";
            this.txtMarkTwo.Size = new System.Drawing.Size(100, 20);
            this.txtMarkTwo.TabIndex = 4;
            // 
            // lblMarkOne
            // 
            this.lblMarkOne.AutoSize = true;
            this.lblMarkOne.Location = new System.Drawing.Point(13, 13);
            this.lblMarkOne.Name = "lblMarkOne";
            this.lblMarkOne.Size = new System.Drawing.Size(57, 13);
            this.lblMarkOne.TabIndex = 5;
            this.lblMarkOne.Text = "Mark One:";
            // 
            // lblMarkTwo
            // 
            this.lblMarkTwo.AutoSize = true;
            this.lblMarkTwo.Location = new System.Drawing.Point(13, 35);
            this.lblMarkTwo.Name = "lblMarkTwo";
            this.lblMarkTwo.Size = new System.Drawing.Size(58, 13);
            this.lblMarkTwo.TabIndex = 6;
            this.lblMarkTwo.Text = "Mark Two:";
            // 
            // lblMarkThree
            // 
            this.lblMarkThree.AutoSize = true;
            this.lblMarkThree.Location = new System.Drawing.Point(13, 57);
            this.lblMarkThree.Name = "lblMarkThree";
            this.lblMarkThree.Size = new System.Drawing.Size(65, 13);
            this.lblMarkThree.TabIndex = 7;
            this.lblMarkThree.Text = "Mark Three:";
            // 
            // lblMarkFour
            // 
            this.lblMarkFour.AutoSize = true;
            this.lblMarkFour.Location = new System.Drawing.Point(13, 79);
            this.lblMarkFour.Name = "lblMarkFour";
            this.lblMarkFour.Size = new System.Drawing.Size(58, 13);
            this.lblMarkFour.TabIndex = 8;
            this.lblMarkFour.Text = "Mark Four:";
            // 
            // lblMarkFive
            // 
            this.lblMarkFive.AutoSize = true;
            this.lblMarkFive.Location = new System.Drawing.Point(13, 101);
            this.lblMarkFive.Name = "lblMarkFive";
            this.lblMarkFive.Size = new System.Drawing.Size(57, 13);
            this.lblMarkFive.TabIndex = 9;
            this.lblMarkFive.Text = "Mark Five:";
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(12, 124);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(172, 23);
            this.btnCalculateAverage.TabIndex = 10;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(13, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(171, 102);
            this.lblResult.TabIndex = 11;
            // 
            // AverageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.lblMarkFive);
            this.Controls.Add(this.lblMarkFour);
            this.Controls.Add(this.lblMarkThree);
            this.Controls.Add(this.lblMarkTwo);
            this.Controls.Add(this.lblMarkOne);
            this.Controls.Add(this.txtMarkTwo);
            this.Controls.Add(this.txtMarkFour);
            this.Controls.Add(this.txtMarkThree);
            this.Controls.Add(this.txtMarkFive);
            this.Controls.Add(this.txtMarkOne);
            this.Name = "AverageCalculator";
            this.Text = "Average Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarkOne;
        private System.Windows.Forms.TextBox txtMarkFive;
        private System.Windows.Forms.TextBox txtMarkThree;
        private System.Windows.Forms.TextBox txtMarkFour;
        private System.Windows.Forms.TextBox txtMarkTwo;
        private System.Windows.Forms.Label lblMarkOne;
        private System.Windows.Forms.Label lblMarkTwo;
        private System.Windows.Forms.Label lblMarkThree;
        private System.Windows.Forms.Label lblMarkFour;
        private System.Windows.Forms.Label lblMarkFive;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

