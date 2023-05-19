
using BTCuoiKyDotnet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKyDotnet.BLL
{
    public class BLLSVHP
    {
        public delegate bool comparestr(dataGridViewItem s1, dataGridViewItem s2);
        public static void swap(ref List<dataGridViewItem> list, int i, int j)
        {
            dataGridViewItem temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        public List<dataGridViewItem> sortDelegate(List<dataGridViewItem> s1, comparestr cmp)
        {
            for (int i = 0; i < s1.Count - 1; i++)
            {
                for (int j = 0; j < s1.Count - i - 1; j++)
                {
                    if (cmp(s1[j], s1[j + 1]))
                    {
                        swap(ref s1, j, j + 1);
                    }
                }
            }
            return s1;
        }
        public bool cmpTenSV(dataGridViewItem s1, dataGridViewItem s2)
        {
            if (string.Compare((s1).tenSV, (s2).tenSV) > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpTenLopSH(dataGridViewItem s1, dataGridViewItem s2)
        {
            if (string.Compare((s1).lopSH, (s2).lopSH) > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpTenHP(dataGridViewItem s1, dataGridViewItem s2)
        {
            if (string.Compare((s1).tenHP, (s2).tenHP) > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpDiemBT(dataGridViewItem s1, dataGridViewItem s2)
        {
            if ((s1).diemBT - (s2).diemBT > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpDiemGk(dataGridViewItem s1, dataGridViewItem s2)
        {
            if ((s1).diemGK - (s2).diemGK > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpDiemCK(dataGridViewItem s1, dataGridViewItem s2)
        {
            if ((s1).diemCK - (s2).diemCK > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpTongKet(dataGridViewItem s1, dataGridViewItem s2)
        {
            if ((s1).tongKet - (s2).tongKet > 0)
            {
                return true;
            }
            return false;
        }
        public bool cmpNgayThi(dataGridViewItem s1, dataGridViewItem s2)
        {
            if ((s1).ngayThi > (s2).ngayThi )
            {
                return true;
            }
            return false;
        }
        public List<string> GetCBBHP()
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            List<string> list = new List<string>();
            list.Add("ALL");
            foreach (var item in db.HPs)
            {
                list.Add(item.tenHP.ToString());
            }
            return list;
        }
        public List<dataGridViewItem> GetSinhViens(string tenHP, string txt)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
                if (tenHP == "ALL")
                {
                    
                    return db.SVs.Where(sv => sv.tenSV.Contains(txt) || sv.maSV.Contains(txt))
                                 .Join(db.SVHPs,
                                        sv => sv.maSV,
                                        svhp => svhp.maSV,
                                        (sv, svhp) => new { SV = sv, SVHP = svhp })
                                 .Join(db.HPs,
                                         result => result.SVHP.maHP,
                                         hp => hp.maHP,
                                         (result, hp) => new dataGridViewItem
                                         {
                                             maSV = result.SV.maSV,
                                             idSVHP = result.SVHP.idSVHP,
                                             tenSV = result.SV.tenSV,
                                             lopSH = result.SV.lopSH,
                                             tenHP = hp.tenHP,
                                             diemBT = result.SV.diemBT,
                                             diemGK = result.SV.diemGK,
                                             diemCK = result.SV.diemCK,
                                             gioiTinh = result.SV.gioiTinh,
                                             tongKet = result.SV.diemBT * 0.2 + result.SV.diemGK * 0.2 + result.SV.diemCK * 0.6,
                                             ngayThi = result.SV.ngayThi
                                         })
                                 .ToList();
                }
                else
                {
                    return db.SVs.Where(sv => sv.tenSV.Contains(txt) || sv.maSV.Contains(txt))
                                 .Join(db.SVHPs,
                                       sv => sv.maSV,
                                       svhp => svhp.maSV,
                                       (sv, svhp) => new { SV = sv, SVHP = svhp })
                                 .Join(db.HPs,
                                        result => result.SVHP.maHP,
                                        hp => hp.maHP,
                                        (result, hp) => new dataGridViewItem
                                        {
                                            maSV = result.SV.maSV,
                                            idSVHP = result.SVHP.idSVHP,
                                            tenSV = result.SV.tenSV,
                                            lopSH = result.SV.lopSH,
                                            tenHP = hp.tenHP,
                                            diemBT = result.SV.diemBT,
                                            diemGK = result.SV.diemGK,
                                            diemCK = result.SV.diemCK,
                                            gioiTinh = result.SV.gioiTinh,
                                            tongKet = result.SV.diemBT * 0.2 + result.SV.diemGK * 0.2 + result.SV.diemCK * 0.6,
                                            ngayThi = result.SV.ngayThi
                                        })
                                 .Where(s => s.tenHP == tenHP)
                                 .ToList();
                }
        }
        public List<dataGridViewItem> GetSinhViensAfterSort(string tenHP, string txt, string txtsort)
        {
            List<dataGridViewItem> data = GetSinhViens(tenHP, txt);
            SinhVienHocPhan db = new SinhVienHocPhan();
            switch (txtsort)
            {
                case ("Tên SV"):
                    this.sortDelegate(data,cmpTenSV);
                    break;
                case ("Lớp SH"):
                    this.sortDelegate(data, cmpTenLopSH);
                    break;
                case ("Tên Học Phần"):
                    this.sortDelegate(data, cmpTenHP);
                    break;
                case ("Điểm BT"):
                    this.sortDelegate(data, cmpDiemBT);
                    break;
                case ("Điểm GK"):
                    this.sortDelegate(data, cmpDiemGk);
                    break;
                case ("Điểm CK"):
                    this.sortDelegate(data, cmpDiemCK);
                    break;
                case ("Tổng Kết"):
                    this.sortDelegate(data, cmpTongKet);
                    break;
                case ("Ngày Thi"):
                    this.sortDelegate(data, cmpNgayThi);
                    break;
                default:
                    break;
            }
            return data;
                
        }
        public List<dataGridViewItem> DeleteSV(List<int> IdSVHP)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            List<dataGridViewItem> data = GetSinhViens("ALL", "");
            for(int i = 0; i < IdSVHP.Count; i++)
            {
                SVHP svhp = db.SVHPs.Find(IdSVHP[i]);
                db.SVHPs.Remove(svhp);
                db.SaveChanges();
            }
            return data;
        }
        public List<string> setCBBLopSH()
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            return db.SVs.Select(s =>s.lopSH).Distinct().ToList();
        }
        public List<string> setHocPhan()
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            return db.HPs.Select(s => s.tenHP).Distinct().ToList();
        }
        public dataGridViewItem getSinhVien(string MaSV)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            return db.SVs.Join(db.SVHPs,
                                       sv => sv.maSV,
                                       svhp => svhp.maSV,
                                       (sv, svhp) => new { SV = sv, SVHP = svhp })
                                 .Join(db.HPs,
                                        result => result.SVHP.maHP,
                                        hp => hp.maHP,
                                        (result, hp) => new dataGridViewItem
                                        {
                                            maSV = result.SV.maSV,
                                            idSVHP = result.SVHP.idSVHP,
                                            tenSV = result.SV.tenSV,
                                            lopSH = result.SV.lopSH,
                                            tenHP = hp.tenHP,
                                            diemBT = result.SV.diemBT,
                                            diemGK = result.SV.diemGK,
                                            diemCK = result.SV.diemCK,
                                            gioiTinh = result.SV.gioiTinh,
                                            tongKet = result.SV.diemBT * 0.2 + result.SV.diemGK * 0.2 + result.SV.diemCK * 0.6,
                                            ngayThi = result.SV.ngayThi
                                        })
                                 .Where(s => s.maSV == MaSV)
                                 .FirstOrDefault();
        }
        public string GetHocPhanTheoTen(string tenHP)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            return db.HPs.Where(s => s.tenHP == tenHP).Select(s => s.maHP).FirstOrDefault();
        }
        public void UpdateSinhVien(SinhVien sv)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            SinhVien s = db.SVs.Find(sv.maSV);
            s.lopSH = sv.lopSH;
            s.ngayThi = sv.ngayThi;
            s.gioiTinh = sv.gioiTinh;
            s.diemGK = sv.diemGK;
            s.diemBT =sv.diemBT;
            s.diemCK = sv.diemCK;
            s.tenSV = sv.tenSV;
            db.SaveChanges();
        }
        public void AddSVHP(SVHP svhp)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            SVHP s = db.SVHPs.Find(svhp.idSVHP);
            if (s != null)
            {
                throw new Exception("Mã số sinh viên đã tồn tại");
            }
            else
            {
                db.SVHPs.Add(svhp);
                db.SaveChanges();
            }
        }
        public void AddSinhVien(SinhVien sv)
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            SinhVien s = db.SVs.Find(sv.maSV);
            if(s != null)
            {
                throw new Exception("Mã số sinh viên đã tồn tại");
            }
            else
            {
                db.SVs.Add(sv);
                db.SaveChanges();
            }
        }
        public int getLengthSVHP()
        {
            SinhVienHocPhan db = new SinhVienHocPhan();
            return db.SVHPs.Count();
        }
    }
}
