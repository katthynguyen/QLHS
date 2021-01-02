using STUDENT.BUS;
using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT.GUI
{
    public partial class TiepNhanHocSinh : Form
    {
        public TiepNhanHocSinh()
        {
            InitializeComponent();
            
        }       

        private void TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            LoadHocSinh();
        }
        void LoadHocSinh()
        {
            HOCSINHBUS bus = new HOCSINHBUS();
            dgvHocSinh.DataSource = bus.GetAllHocSinh();            
        }
          
                
        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvHocSinh.CurrentRow.Index;
            txtMaHocSinh.Text = dgvHocSinh.Rows[idx].Cells["MaHocSinh"].Value.ToString();
            txtHoTen.Text = dgvHocSinh.Rows[idx].Cells["TenHocSinh"].Value.ToString();
            dtNgaySinh.Text = dgvHocSinh.Rows[idx].Cells["NgaySinh"].Value.ToString(); 
            txtEmail.Text = dgvHocSinh.Rows[idx].Cells["Email"].Value.ToString();
            txtDiaChi.Text = dgvHocSinh.Rows[idx].Cells["DiaChi"].Value.ToString();

            string gioitinh = dgvHocSinh.Rows[idx].Cells["GioiTinh"].Value.ToString();
            
            if (gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }  
            else if (gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            
        }

        private void btnExitHocSinh_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn thêm học sinh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                AddHocSinh();
                LoadHocSinh();
            }

        }
        void AddHocSinh()
        {
            HOCSINHDTO hs = new HOCSINHDTO();
            HOCSINHBUS bus = new HOCSINHBUS();
            string prefix = "HS100";
            int n = dgvHocSinh.Rows.Count + 1;
            hs.MaHocSinh = string.Format("{0}{1}", prefix, n);
            
            while (true)
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTen.Focus();
                    break;
                }

                else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    break;
                }

                else if (string.IsNullOrWhiteSpace(txtEmail.Text) || IsEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Địa chỉ Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    break;
                }
                else if(rdbNam.Checked == false && rdbNu.Checked == false)
                {
                    MessageBox.Show("Hãy xác định giới tính của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if(bus.CheckAge(DateTime.Now.Year - dtNgaySinh.Value.Year) == false)
                {
                    MessageBox.Show("Tuổi của bạn không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    if (rdbNam.Checked)
                    {
                        hs.GioiTinh = "Nam";
                    }
                    else if (rdbNu.Checked)
                    {
                        hs.GioiTinh = "N'Nữ'";
                    }

                    hs.TenHocSinh = txtHoTen.Text;
                    hs.NgaySinh = dtNgaySinh.Value;
                    hs.DiaChi = txtDiaChi.Text;
                    hs.Email = txtEmail.Text;
                                        
                    bus.InsertHocSinh(hs);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        bool IsEmail(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return (true);
            else
                return (false);
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                DeleteHocSinh();
                LoadHocSinh();
            }
            
        }
        void DeleteHocSinh()
        {
            HOCSINHBUS bus = new HOCSINHBUS();
            bus.DeleteHocSinh(txtMaHocSinh.Text);
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            UpDateHocSinh();
            LoadHocSinh();
        }

        void UpDateHocSinh()
        {
            HOCSINHDTO hs = new HOCSINHDTO();
            hs.MaHocSinh = txtMaHocSinh.Text;
            hs.TenHocSinh = txtHoTen.Text;
            hs.NgaySinh = dtNgaySinh.Value;
            hs.DiaChi = txtDiaChi.Text;
            hs.Email = txtEmail.Text;

            if (rdbNam.Checked)            
                hs.GioiTinh = "Nam";
            else if (rdbNu.Checked)            
                hs.GioiTinh = "Nữ";

            HOCSINHBUS bus = new HOCSINHBUS();
            bus.UpdateHocSinh(hs);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
