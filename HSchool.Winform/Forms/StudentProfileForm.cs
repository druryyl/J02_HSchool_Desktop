using HSchool.Lib.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.Forms
{
    public partial class StudentProfileForm : Form
    {
        private IPersonBL _personBL;
        public StudentProfileForm(IPersonBL personBL)
        {
            InitializeComponent();

            _personBL = personBL;

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
        }

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {
            var panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, 
                Color.DarkKhaki, ButtonBorderStyle.Solid);
        }
    }

    public class StudentModel
    {
        public StudentModel(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
