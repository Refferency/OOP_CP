using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CP
{
    public partial class HomeScreen : Form
    {
        private Timer t;

        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Click(object sender, EventArgs e)
        {
            t.Stop();
            HomeScreen.ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            Close();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 5 * 1000;
            t.Tick += delegate { this.Close(); };
            t.Start();
        }
    }
}
