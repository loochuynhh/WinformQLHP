using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet
{
    [Table("HocPhan")]
    public class HocPhan
    {
        public HocPhan()
        {
            SVHPs = new HashSet<SVHP>();
        }
        [Key]
        public string maHP { get; set; }
        [Column("Tên HP")]
        [Required]
        public string tenHP { get; set; }
        public virtual ICollection<SVHP> SVHPs { get; set; }

    }
}
