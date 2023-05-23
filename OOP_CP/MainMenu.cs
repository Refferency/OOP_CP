using OOP_CP.Management;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void routeManagerButton_Click(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Hide();
            RouteManager rm = new RouteManager();
            rm.ShowDialog();
            Close();
        }

        private void busManagerButton_Click(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Hide();
            BusManager bm = new BusManager();
            bm.ShowDialog();
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
