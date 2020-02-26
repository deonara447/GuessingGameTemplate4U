using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            Form1.marks.Sort();
            for (int i = 0; i < Form1.marks.Count(); i++)

            {

                label2.Text += "\n" + i + ": " + Form1.marks[i];

            }
        }
    }
}
