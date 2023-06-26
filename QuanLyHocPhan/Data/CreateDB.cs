using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet
{
    public class CreateDB 
        //: CreateDatabaseIfNotExists<SinhVienHocPhan>
        : DropCreateDatabaseIfModelChanges<SinhVienHocPhan>
    {
        protected override void Seed(SinhVienHocPhan context)
        {
            context.SVHPs.AddRange(new SVHP[]
            {
                new SVHP {idSVHP = 1, maHP = "HP1", maSV = "SV2"},
                new SVHP {idSVHP = 2, maHP = "HP1", maSV = "SV1"},
                new SVHP {idSVHP = 3, maHP = "HP2", maSV = "SV4"},
                new SVHP {idSVHP = 4, maHP = "HP3", maSV = "SV4"},
                new SVHP {idSVHP = 5, maHP = "HP4", maSV = "SV2"},
                new SVHP {idSVHP = 6, maHP = "HP1", maSV = "SV5"},
                new SVHP {idSVHP = 7, maHP = "HP3", maSV = "SV3"},
                new SVHP {idSVHP = 8, maHP = "HP5", maSV = "SV5"},
            });

            context.HPs.AddRange(new HocPhan[]
            {
                new HocPhan {maHP = "HP1", tenHP = "Đại số tuyến tính"},
                new HocPhan {maHP = "HP2", tenHP = "Đồ họa máy tính"},
                new HocPhan {maHP = "HP3", tenHP = "Giải tích 1"},
                new HocPhan {maHP = "HP4", tenHP = "Xác suất thống kê"},
                new HocPhan {maHP = "HP5", tenHP = "Kỹ thuật lập trình"},
            });
            context.SVs.AddRange(new SinhVien[] 
            { 
                new SinhVien {maSV = "SV1", tenSV = "Huỳnh Văn Lộc", lopSH = "21T_DT", diemBT = 8.0, diemCK = 7.8, diemGK = 6.9, gioiTinh =true, ngayThi = new DateTime(2023,5,25)},
                new SinhVien {maSV = "SV2", tenSV = "Huỳnh Thị Ban", lopSH = "21T_DT2", diemBT = 8.0, diemCK = 7.8, diemGK = 7.3, gioiTinh =false, ngayThi = new DateTime(2023,5,20)},
                new SinhVien {maSV = "SV3", tenSV = "Huỳnh Văn Tuấn", lopSH = "21T_DT", diemBT = 5.5, diemCK = 8.1, diemGK = 7.9, gioiTinh =true, ngayThi = new DateTime(2023,5,28)},
                new SinhVien {maSV = "SV4", tenSV = "Huỳnh Văn Tú", lopSH = "21T_DT2", diemBT = 8.0, diemCK = 7.0, diemGK = 6.9, gioiTinh =true, ngayThi = new DateTime(2023,5,24)},
                new SinhVien {maSV = "SV5", tenSV = "Huỳnh Thị Thanh", lopSH = "21T_DT2", diemBT = 8.1, diemCK = 7.8, diemGK = 7.7, gioiTinh =false, ngayThi = new DateTime(2023,5,21)},
            });
        }
    }
}
