using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet
{
    [Table("SinhVien")]
    public class SinhVien
    {
        public SinhVien()
        {
            SVHPs = new HashSet<SVHP>(); 
        }
        [Key]
        public string maSV { get; set; }
        [Required]
        [Column("Tên SV")]
        public string tenSV { get; set; }
        [Required]
        [Column("Lớp SH")]
        public string lopSH { get; set; }
        [Column("Giới tính")]
        [Required]
        public bool gioiTinh { get; set; }
        [Column("Điểm BT")]
        [Required]
        public double diemBT { get; set; }
        [Column("Điểm GK")]
        [Required]
        public double diemGK { get; set; }
        [Column("Điểm CK")]
        [Required]
        public double diemCK { get; set; }
        [Column("Ngày thi")]
        [Required]
        public DateTime ngayThi { get; set; }
        public virtual ICollection<SVHP> SVHPs { get; set; }

    }
}
