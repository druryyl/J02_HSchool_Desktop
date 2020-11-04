using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            var listStudent = new List<StudentModel>
            {
                new StudentModel("Dominique Angela Maurines"),
                new StudentModel("Athalia rebecca thammy"),
                new StudentModel("Yolenta Nathania Trahutama"),
                new StudentModel("Jizelle Shalom Aubrey"),
                new StudentModel("Fransisco Danar"),
                new StudentModel("Joceline Ignacia"),
                new StudentModel("Maria Luisa Putri Aer"),
                new StudentModel("Chrissy Evelyn"),
            };
            dataGridView1.DataSource = listStudent;

            var listFee = new List<FeeModel>
            {
                new FeeModel("UGPKA", "Fee Bulanan Wajib", "",   "     Rp.   500.000", "Monthly"),
                new FeeModel("UGPKB", "Fee Bulanan Sukarela", "","     Rp.   350.000", "Yearly"),
                new FeeModel("UGPKA", "Uang Gedung", "",         "     Rp. 3.750.000", "Once"),
                new FeeModel("UGPKA", "Materi Buku", "",         "     Rp. 1.750.000", "Monthly"),
            };
            dataGridView2.DataSource = listFee;
        }
        private void FlowPanel_Paint(object sender, PaintEventArgs e)
        {
            var panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                Color.DarkKhaki, ButtonBorderStyle.Solid);
        }
    }

    public class FeeModel
    {
        public FeeModel(string id, string name, string ket, string nilai, string periode)
        {
            FeeID = id;
            FeeName = name;
            Nilai = nilai;
            Keterangan = ket;
            Period = periode;
        }
        public string FeeID { get; set; }
        public string FeeName { get; set; }
        public string Keterangan { get; set; }
        public string Nilai { get; set; }
        public string Period { get; set; }
    }
}
