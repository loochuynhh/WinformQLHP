using BTCuoiKyDotnet.BLL;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetCBBHocPhan();
            SetSBBSort();
        }

        public void SetCBBHocPhan()
        {
            BLLSVHP BLL = new BLLSVHP();
            CBBHocPhan.Items.AddRange(BLL.GetCBBHP().ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LabelTenHocPhan_Click(object sender, EventArgs e)
        {

        }
        public void SetDefaultDataGridView()
        {
            dataGridView1.Columns.Clear();
            BLLSVHP BLL = new BLLSVHP();
            dataGridView1.DataSource = BLL.GetSinhViens("ALL", "");
            SetDataGridView();
        }
        public void SetDataGridView()
        {
            // Tạo cột STT
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Name = "sttColumn";
            dataGridView1.Columns.Insert(0, sttColumn); // Chèn cột vào vị trí đầu tiên
            // Đặt giá trị cho các ô trong cột STT
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["sttColumn"].Value = (i + 1).ToString();
            }
            dataGridView1.Columns[1].Name = "Mã SV";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[10].Name = "Giới Tính";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[2].Name = "IdSVHP";
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[3].HeaderText = "Tên SV";
            dataGridView1.Columns[4].HeaderText = "Lớp SH";
            dataGridView1.Columns[5].HeaderText = "Tên Học Phần";
            dataGridView1.Columns[6].HeaderText = "Điểm BT";
            dataGridView1.Columns[7].HeaderText = "Điểm GK";
            dataGridView1.Columns[8].HeaderText = "Điểm CK";
            dataGridView1.Columns[9].HeaderText = "Tổng Kết";
            dataGridView1.Columns[11].HeaderText = "Ngày Thi";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CBBHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            BLLSVHP BLL = new BLLSVHP();
            dataGridView1.DataSource =  BLL.GetSinhViens(CBBHocPhan.SelectedItem.ToString(),"");
            SetDataGridView();
        }

        private void BTTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            BLLSVHP BLL = new BLLSVHP();
            dataGridView1.DataSource = BLL.GetSinhViens(CBBHocPhan.SelectedItem.ToString(),TBTimKiem.Text);
            SetDataGridView();
        }
        public void SetSBBSort()
        {
            CBBSapXep.Items.Add("Tên SV");
            CBBSapXep.Items.Add("Lớp SH");
            CBBSapXep.Items.Add("Tên Học Phần");
            CBBSapXep.Items.Add("Điểm BT");
            CBBSapXep.Items.Add("Điểm GK");
            CBBSapXep.Items.Add("Điểm CK");
            CBBSapXep.Items.Add("Tổng Kết");
            CBBSapXep.Items.Add("Ngày Thi");
            CBBSapXep.SelectedIndex = 0;
        }

        private void BTSapXep_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            BLLSVHP BLL = new BLLSVHP();
            dataGridView1.DataSource = BLL.GetSinhViensAfterSort(CBBHocPhan.SelectedItem.ToString(), TBTimKiem.Text, CBBSapXep.SelectedItem.ToString());
            SetDataGridView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                List<int> list = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    list.Add(Convert.ToInt32(row.Cells["IdSVHP"].Value));
                }
                dataGridView1.Columns.Clear();
                BLLSVHP BLL = new BLLSVHP();
                dataGridView1.DataSource = BLL.DeleteSV(list);
                SetDataGridView();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DetialForm f = new DetialForm();
            f.Del += new DetialForm.SetDefaultDTGV(SetDefaultDataGridView);
            f.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DetialForm f = new DetialForm(dataGridView1.CurrentRow.Cells["Mã SV"].Value.ToString());
                f.Del += new DetialForm.SetDefaultDTGV(SetDefaultDataGridView);
                f.ShowDialog();
            }
            
        }
    }
}
