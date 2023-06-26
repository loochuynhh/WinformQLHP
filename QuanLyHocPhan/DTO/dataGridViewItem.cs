using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet.DTO
{
    public class dataGridViewItem
    {
        public string maSV { get; set; }
        public int idSVHP { get; set; }
        public string tenSV { get; set; }
        public string lopSH { get; set; }
        public string tenHP { get; set; }
        public double diemBT { get; set; }
        public double diemGK { get; set; }
        public double diemCK { get; set; }
        public double tongKet { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngayThi { get; set; }
    }
}
