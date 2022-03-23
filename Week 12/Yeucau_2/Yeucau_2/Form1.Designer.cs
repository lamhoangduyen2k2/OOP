
namespace Yeucau_2
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
            this.rdbt = new System.Windows.Forms.RadioButton();
            this.rbt_CreateDic = new System.Windows.Forms.RadioButton();
            this.rtShow = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn";
            // 
            // rdbt
            // 
            this.rdbt.AutoSize = true;
            this.rdbt.Location = new System.Drawing.Point(12, 80);
            this.rdbt.Name = "rdbt";
            this.rdbt.Size = new System.Drawing.Size(115, 21);
            this.rdbt.TabIndex = 1;
            this.rdbt.TabStop = true;
            this.rdbt.Text = "Thông tin File";
            this.rdbt.UseVisualStyleBackColor = true;
            // 
            // rbt_CreateDic
            // 
            this.rbt_CreateDic.AutoSize = true;
            this.rbt_CreateDic.Location = new System.Drawing.Point(12, 121);
            this.rbt_CreateDic.Name = "rbt_CreateDic";
            this.rbt_CreateDic.Size = new System.Drawing.Size(108, 21);
            this.rbt_CreateDic.TabIndex = 2;
            this.rbt_CreateDic.TabStop = true;
            this.rbt_CreateDic.Text = "Tạo thư mục";
            this.rbt_CreateDic.UseVisualStyleBackColor = true;
            // 
            // rtShow
            // 
            this.rtShow.Location = new System.Drawing.Point(198, 80);
            this.rtShow.Name = "rtShow";
            this.rtShow.Size = new System.Drawing.Size(465, 450);
            this.rtShow.TabIndex = 3;
            this.rtShow.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtShow);
            this.Controls.Add(this.rbt_CreateDic);
            this.Controls.Add(this.rdbt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbt;
        private System.Windows.Forms.RadioButton rbt_CreateDic;
        private System.Windows.Forms.RichTextBox rtShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

