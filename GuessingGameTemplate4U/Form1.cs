using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// A template to be used to practice creating user screens and passing 
/// values between screens through a basic guessing game.
/// </summary>

namespace GuessingGameTemplate4U
{
    public partial class Form1 : Form
    {
        //TODO create global list to store user guesses
        public static List<int> marks = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launch the Main Screen
            UserControl1 ss = new UserControl1();
            MainScreen ms = new MainScreen();
           

            this.Controls.Add(ms);
        }
    }
}
