using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet
{
    [Table("SVHP")]
    public class SVHP
    {
        [Key]
        public int idSVHP { get; set; }
        [Required]
        public string maHP { get; set; }
        [ForeignKey("maHP")]
        public HocPhan HP { get; set; }
        [Required]
        public string maSV { get; set; }
        [ForeignKey("maSV")]
        public SinhVien SV { get; set; }

    }
}
