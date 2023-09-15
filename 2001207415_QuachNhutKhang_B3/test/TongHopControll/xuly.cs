using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlClass;
using System.Data;
namespace TongHopControll
{
    public class xuly
    {
        
        public SinhVien showInfoSv(string ma){

            DataTable dt = Sql.ExecuteQuery("Data Source=A101PC45;Initial Catalog=SinhVien;Integrated Security=True", "select * from sinhVien where maSinhVien ='" + ma + "'");
            SinhVien sv = new SinhVien();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sv.Ma = dt.Rows[i][0].ToString();
                sv.Ten = dt.Rows[i][1].ToString();
                sv.Ma_Lop= dt.Rows[i][2].ToString();
                sv.NgaySinh = dt.Rows[i][3].ToString();
                sv.GT = dt.Rows[i][4].ToString();
                sv.CCCD = dt.Rows[i][5].ToString();
            }
            return sv;
    }
    
    }

}
