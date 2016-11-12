namespace Day5
{
    partial class Day5
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
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.lblNumberThree = new System.Windows.Forms.Label();
            this.tbNumberOne = new System.Windows.Forms.TextBox();
            this.tbNumberTwo = new System.Windows.Forms.TextBox();
            this.tbNumberThree = new System.Windows.Forms.TextBox();
            this.cbMathProcess = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(12, 13);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(99, 21);
            this.lblNumberOne.TabIndex = 0;
            this.lblNumberOne.Text = "Number One";
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(12, 56);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(99, 21);
            this.lblNumberTwo.TabIndex = 1;
            this.lblNumberTwo.Text = "Number Two";
            // 
            // lblNumberThree
            // 
            this.lblNumberThree.AutoSize = true;
            this.lblNumberThree.Location = new System.Drawing.Point(12, 98);
            this.lblNumberThree.Name = "lblNumberThree";
            this.lblNumberThree.Size = new System.Drawing.Size(110, 21);
            this.lblNumberThree.TabIndex = 2;
            this.lblNumberThree.Text = "Number Three";
            // 
            // tbNumberOne
            // 
            this.tbNumberOne.Location = new System.Drawing.Point(130, 13);
            this.tbNumberOne.Name = "tbNumberOne";
            this.tbNumberOne.Size = new System.Drawing.Size(175, 28);
            this.tbNumberOne.TabIndex = 3;
            this.tbNumberOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberOne_KeyPress);
            // 
            // tbNumberTwo
            // 
            this.tbNumberTwo.Location = new System.Drawing.Point(130, 53);
            this.tbNumberTwo.Name = "tbNumberTwo";
            this.tbNumberTwo.Size = new System.Drawing.Size(175, 28);
            this.tbNumberTwo.TabIndex = 4;
            this.tbNumberTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberTwo_KeyPress);
            // 
            // tbNumberThree
            // 
            this.tbNumberThree.Location = new System.Drawing.Point(130, 95);
            this.tbNumberThree.Name = "tbNumberThree";
            this.tbNumberThree.Size = new System.Drawing.Size(175, 28);
            this.tbNumberThree.TabIndex = 5;
            this.tbNumberThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberThree_KeyPress);
            // 
            // cbMathProcess
            // 
            this.cbMathProcess.FormattingEnabled = true;
            this.cbMathProcess.Items.AddRange(new object[] {
            "Addition",
            "Multiplication",
            "Substraction"});
            this.cbMathProcess.Location = new System.Drawing.Point(12, 148);
            this.cbMathProcess.Name = "cbMathProcess";
            this.cbMathProcess.Size = new System.Drawing.Size(293, 29);
            this.cbMathProcess.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(112, 195);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 29);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(130, 242);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(175, 28);
            this.tbResult.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 245);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 21);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // Day5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 293);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbMathProcess);
            this.Controls.Add(this.tbNumberThree);
            this.Controls.Add(this.tbNumberTwo);
            this.Controls.Add(this.tbNumberOne);
            this.Controls.Add(this.lblNumberThree);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblNumberOne);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Day5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.Label lblNumberThree;
        private System.Windows.Forms.TextBox tbNumberOne;
        private System.Windows.Forms.TextBox tbNumberTwo;
        private System.Windows.Forms.TextBox tbNumberThree;
        private System.Windows.Forms.ComboBox cbMathProcess;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblResult;
    }
}

