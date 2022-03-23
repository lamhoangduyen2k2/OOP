
namespace _20110174_LamHoangDuyen
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
            this.txtHuman = new System.Windows.Forms.TextBox();
            this.btSet = new System.Windows.Forms.Button();
            this.btDis = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblDis = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Data";
            // 
            // txtHuman
            // 
            this.txtHuman.Location = new System.Drawing.Point(115, 27);
            this.txtHuman.Name = "txtHuman";
            this.txtHuman.Size = new System.Drawing.Size(100, 22);
            this.txtHuman.TabIndex = 1;
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(274, 27);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(75, 30);
            this.btSet.TabIndex = 2;
            this.btSet.Text = "Nhập";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // btDis
            // 
            this.btDis.Location = new System.Drawing.Point(390, 27);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(75, 23);
            this.btDis.TabIndex = 3;
            this.btDis.Text = "Hiển Thị";
            this.btDis.UseVisualStyleBackColor = true;
            this.btDis.Click += new System.EventHandler(this.btDis_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(526, 27);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Lưu Data";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(16, 111);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(88, 17);
            this.lblDis.TabIndex = 5;
            this.lblDis.Text = "Dữ liệu nhập";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(19, 186);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(72, 17);
            this.lblHienThi.TabIndex = 6;
            this.lblHienThi.Text = "Thống kê:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(526, 358);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 35);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 414);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDis);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.txtHuman);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHuman;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Button btDis;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btExit;
    }
}

