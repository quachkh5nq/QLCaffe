namespace test
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
            this.thongTinSinhVien1 = new TongHopControll.thongTinSinhVien();
            this.SuspendLayout();
            // 
            // thongTinSinhVien1
            // 
            this.thongTinSinhVien1.Location = new System.Drawing.Point(12, 23);
            this.thongTinSinhVien1.Name = "thongTinSinhVien1";
            this.thongTinSinhVien1.Size = new System.Drawing.Size(505, 230);
            this.thongTinSinhVien1.TabIndex = 0;
            this.thongTinSinhVien1.Load += new System.EventHandler(this.thongTinSinhVien1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 384);
            this.Controls.Add(this.thongTinSinhVien1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TongHopControll.thongTinSinhVien thongTinSinhVien1;

    }
}

