using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SqlClass;
namespace TongHopControll
{
    public partial class thongTinSinhVien : UserControl
    {
        
        public thongTinSinhVien()
        {
            InitializeComponent();
 
            
            this.txtTen.ReadOnly = true;
            this.txtLop.ReadOnly = true;
            this.txtNS.ReadOnly = true;
            this.txtGT.ReadOnly = true;
            this.txtCCCD.ReadOnly = true;
            
        }

        private void thongTinSinhVien_Load(object sender, EventArgs e)
        {
           

        }

       
        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                
                xuly xuLy = new xuly();
                SinhVien sv= xuLy.showInfoSv(txtMSSV.Text.Trim());
                if (sv.Ten != null)
                {
                    txtTen.Text = sv.Ten;
                    txtLop.Text = sv.Ma_Lop;
                    txtNS.Text = sv.NgaySinh;
                    txtGT.Text = sv.GT;
                    txtCCCD.Text = sv.CCCD;
                }
                else
                {
                    
                    MessageBox.Show("sinh vien k ton tai");
                    txtMSSV.Text = " ";
                    txtTen.Text = " ";
                    txtLop.Text = " ";
                    txtNS.Text = " ";
                    txtGT.Text = " ";
                    txtCCCD.Text = " ";
                }
            }
            
            
        }

        // ham tra ve sv

    }
}
