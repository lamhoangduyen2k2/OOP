
namespace Caculator
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
            this.realLabel = new System.Windows.Forms.Label();
            this.imaginaryLabel = new System.Windows.Forms.Label();
            this.realTextBox = new System.Windows.Forms.TextBox();
            this.imaginaryTextBox = new System.Windows.Forms.TextBox();
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.mutiplyButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // realLabel
            // 
            this.realLabel.AutoSize = true;
            this.realLabel.Location = new System.Drawing.Point(37, 67);
            this.realLabel.Name = "realLabel";
            this.realLabel.Size = new System.Drawing.Size(37, 17);
            this.realLabel.TabIndex = 0;
            this.realLabel.Text = "Real";
            // 
            // imaginaryLabel
            // 
            this.imaginaryLabel.AutoSize = true;
            this.imaginaryLabel.Location = new System.Drawing.Point(23, 116);
            this.imaginaryLabel.Name = "imaginaryLabel";
            this.imaginaryLabel.Size = new System.Drawing.Size(69, 17);
            this.imaginaryLabel.TabIndex = 1;
            this.imaginaryLabel.Text = "Imaginary";
            this.imaginaryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // realTextBox
            // 
            this.realTextBox.Location = new System.Drawing.Point(100, 61);
            this.realTextBox.Name = "realTextBox";
            this.realTextBox.Size = new System.Drawing.Size(128, 22);
            this.realTextBox.TabIndex = 2;
            // 
            // imaginaryTextBox
            // 
            this.imaginaryTextBox.Location = new System.Drawing.Point(100, 111);
            this.imaginaryTextBox.Name = "imaginaryTextBox";
            this.imaginaryTextBox.Size = new System.Drawing.Size(128, 22);
            this.imaginaryTextBox.TabIndex = 3;
            this.imaginaryTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(284, 61);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 23);
            this.firstButton.TabIndex = 4;
            this.firstButton.Text = "Set No 1";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(284, 111);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(75, 23);
            this.secondButton.TabIndex = 5;
            this.secondButton.Text = "Set No 2";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(161, 181);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(80, 30);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "Substract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // mutiplyButton
            // 
            this.mutiplyButton.Location = new System.Drawing.Point(284, 181);
            this.mutiplyButton.Name = "mutiplyButton";
            this.mutiplyButton.Size = new System.Drawing.Size(75, 30);
            this.mutiplyButton.TabIndex = 8;
            this.mutiplyButton.Text = "Multify";
            this.mutiplyButton.UseVisualStyleBackColor = true;
            this.mutiplyButton.Click += new System.EventHandler(this.mutiplyButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(40, 248);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 17);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Notice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 318);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mutiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.imaginaryTextBox);
            this.Controls.Add(this.realTextBox);
            this.Controls.Add(this.imaginaryLabel);
            this.Controls.Add(this.realLabel);
            this.Name = "Form1";
            this.Text = "Complex Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realLabel;
        private System.Windows.Forms.Label imaginaryLabel;
        private System.Windows.Forms.TextBox realTextBox;
        private System.Windows.Forms.TextBox imaginaryTextBox;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button mutiplyButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

