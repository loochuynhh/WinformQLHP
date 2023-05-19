using System;
using System.Data.Entity;
using System.Linq;

namespace BTCuoiKyDotnet
{
    public class SinhVienHocPhan : DbContext
    {
        public SinhVienHocPhan()
            : base("name=SinhVienHocPhan")
        {
            Database.SetInitializer<SinhVienHocPhan>(new CreateDB());
        }
        public virtual DbSet<SVHP> SVHPs { get; set; }
        public virtual DbSet<HocPhan> HPs { get; set; }
        public virtual DbSet<SinhVien> SVs { get; set; }

       
    }
}