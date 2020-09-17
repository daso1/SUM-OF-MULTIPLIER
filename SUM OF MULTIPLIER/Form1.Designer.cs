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
            this.OutputLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputLbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(132, 28);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 20);
            this.BtnCalculate.TabIndex = 1;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(12, 28);
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(114, 20);
            this.InputTxtBox.TabIndex = 0;
            this.InputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTxtBox_KeyPress);
            // 
            // OutputLbl1
            // 
            this.OutputLbl1.AutoSize = true;
            this.OutputLbl1.Location = new System.Drawing.Point(12, 74);
            this.OutputLbl1.Name = "OutputLbl1";
            this.OutputLbl1.Size = new System.Drawing.Size(0, 13);
            this.OutputLbl1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write a number between 1.000 and 100.000";
            // 
            // OutputLbl2
            // 
            this.OutputLbl2.AutoSize = true;
            this.OutputLbl2.Location = new System.Drawing.Point(12, 106);
            this.OutputLbl2.Name = "OutputLbl2";
            this.OutputLbl2.Size = new System.Drawing.Size(0, 13);
            this.OutputLbl2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 128);
            this.Controls.Add(this.OutputLbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLbl1);
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
        private System.Windows.Forms.Label OutputLbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputLbl2;
    }
}

