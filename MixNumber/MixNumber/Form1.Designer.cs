
namespace MixNumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Real = new System.Windows.Forms.TextBox();
            this.imagine = new System.Windows.Forms.TextBox();
            this.No1 = new System.Windows.Forms.Button();
            this.No2 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Real
            // 
            this.Real.Location = new System.Drawing.Point(150, 23);
            this.Real.Name = "Real";
            this.Real.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Real.Size = new System.Drawing.Size(259, 47);
            this.Real.TabIndex = 0;
            this.Real.TextChanged += new System.EventHandler(this.Real_TextChanged);
            // 
            // imagine
            // 
            this.imagine.Location = new System.Drawing.Point(150, 119);
            this.imagine.Name = "imagine";
            this.imagine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.imagine.Size = new System.Drawing.Size(259, 47);
            this.imagine.TabIndex = 1;
            // 
            // No1
            // 
            this.No1.Location = new System.Drawing.Point(472, 23);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(127, 62);
            this.No1.TabIndex = 2;
            this.No1.Text = "No1";
            this.No1.UseVisualStyleBackColor = true;
            this.No1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // No2
            // 
            this.No2.Location = new System.Drawing.Point(472, 112);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(127, 62);
            this.No2.TabIndex = 3;
            this.No2.Text = "No2";
            this.No2.UseVisualStyleBackColor = true;
            this.No2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(33, 282);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(113, 41);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result:";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(24, 192);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 38);
            this.Add.TabIndex = 5;
            this.Add.Text = "Plus";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(197, 192);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(105, 38);
            this.Subtract.TabIndex = 6;
            this.Subtract.Text = "Subt";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(398, 192);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(129, 38);
            this.Mul.TabIndex = 7;
            this.Mul.Text = "Mul";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Real:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imaginary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.No2);
            this.Controls.Add(this.No1);
            this.Controls.Add(this.imagine);
            this.Controls.Add(this.Real);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Real;
        private System.Windows.Forms.TextBox imagine;
        private System.Windows.Forms.Button No1;
        private System.Windows.Forms.Button No2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

