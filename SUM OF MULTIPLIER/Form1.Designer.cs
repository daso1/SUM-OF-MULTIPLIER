namespace SUM_OF_MULTIPLIER
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(133, 16);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 20);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(13, 16);
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(114, 20);
            this.InputTxtBox.TabIndex = 1;
            this.InputTxtBox.TextChanged += new System.EventHandler(this.InputTxtBox_TextChanged);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(61, 123);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(55, 13);
            this.OutputLbl.TabIndex = 2;
            this.OutputLbl.Text = "Numbers: ";
            this.OutputLbl.Click += new System.EventHandler(this.OutputLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 295);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sum Of Multiplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Label OutputLbl;
    }
}

