using STUDENT.DAO;
using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT.BUS
{
    class LOPBUS
    {
        LOPDAO dao = new LOPDAO();
        KHOIDAO daokhoi = new KHOIDAO();
        LOPDTO lop;
        List<KHOIDTO> listkhoi = new List<KHOIDTO>();
        List<LOPDTO> listLop;

       
        public List<LOPDTO> GetAllClass(DataGridView data)
        {
            data.DataSource = dao.GetAllClass();
           
            foreach (DataGridViewRow item in data.Rows)
            {               
                string ClassId = item.Cells["MaLop"].Value.ToString();
                string ClassName = item.Cells["TenLop"].Value.ToString();
                string Amount = item.Cells["SiSo"].Value.ToString();
                string GradeId = item.Cells["MaKhoi"].Value.ToString();
               
                if(Amount != null)
                {
                    try
                    {
                        listLop = new List<LOPDTO>();
                        int amount = Int32.Parse(Amount);
                        lop = new LOPDTO(ClassId, ClassName, amount, GradeId);
                        listLop.Add(lop);                       
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine($"Unable to parse '{Amount}'");
                        Console.WriteLine(e.Message);
                    }
                }
               
            }
            return listLop;

        }

        

        public void ShowComboBoxClassByGrade(ComboBox cb, string Id)
        {
            cb.DataSource = dao.GetClassInGrade(Id);
            listkhoi = new List<KHOIDTO>();
            foreach (var khoi in listkhoi)
            {
                listLop = new List<LOPDTO>();
                foreach (var lop in listLop)
                {
                    
                }
            }
            cb.DisplayMember = "TenKhoi";
            cb.ValueMember = "MaKhoi";

            
        }
        
    }
}
