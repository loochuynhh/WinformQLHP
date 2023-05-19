using BTCuoiKyDotnet.BLL;
using BTCuoiKyDotnet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCuoiKyDotnet
{
    public partial class DetialForm : Form
    {
        public delegate void SetDefaultDTGV();
        public SetDefaultDTGV Del { get; set; }
        string MaSVGlobal;

        public DetialForm(string MaSV = null)
        {
            InitializeComponent();
            setLopSH();
            setHocPhan();
            tbTongKet.ReadOnly = true;
            MaSVGlobal = MaSV;
            if (MaSV != null)
            {
                tbMSSV.ReadOnly = true;
                cbbHP.Enabled = false;
                SetDefaltValue(MaSV);
            }
        }
        public void setLopSH()
        {
            BLLSVHP bll = new BLLSVHP();
            cbbLopSH.Items.AddRange(bll.setCBBLopSH().ToArray());
        }
        public void setHocPhan()
        {
            BLLSVHP bll = new BLLSVHP();
            cbbHP.Items.AddRange(bll.setHocPhan().ToArray());
        }
        public void SetDefaltValue(string MaSV)
        {
            BLLSVHP bll = new BLLSVHP();
            dataGridViewItem item = bll.getSinhVien(MaSV);
            tbMSSV.Text = item.maSV.ToString();
            tbDiemBT.Text = item.diemBT.ToString();
            tbDiemGK.Text = item.diemGK.ToString();
            tbDiemCK.Text = item.diemCK.ToString();
            tbTongKet.Text = item.tongKet.ToString();
            if (item.gioiTinh)
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
            cbbLopSH.Text = item.lopSH.ToString();
            cbbHP.Text = item.tenHP.ToString();
            dtNgayThi.Value = item.ngayThi;
            tbTen.Text = item.tenSV.ToString();

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            BLLSVHP bll = new BLLSVHP();
            SinhVien sv = new SinhVien();
            sv.tenSV = tbTen.Text;
            sv.lopSH = cbbLopSH.SelectedItem.ToString();
            sv.diemGK = Convert.ToDouble(tbDiemGK.Text);
            sv.diemBT = Convert.ToDouble(tbDiemBT.Text);
            sv.diemCK = Convert.ToDouble(tbDiemCK.Text);
            sv.ngayThi = dtNgayThi.Value;
            if (rdoNam.Checked)
            {
                sv.gioiTinh = true;
            }
            else { sv.gioiTinh = false; }
            sv.maSV = tbMSSV.Text.ToString();
            if (MaSVGlobal != null)
            {
                bll.UpdateSinhVien(sv);
            }
            else
            {
                SVHP svhp = new SVHP();
                svhp.maHP = bll.GetHocPhanTheoTen(cbbHP.SelectedItem.ToString());
                svhp.maSV = tbMSSV.Text.ToString();
                svhp.idSVHP = bll.getLengthSVHP() + 1;
                bll.AddSinhVien(sv);
                bll.AddSVHP(svhp);
            }
            Del();
            this.Dispose();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Del();
            this.Dispose();
        }
    }
}
