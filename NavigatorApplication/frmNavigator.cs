using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navigator;

namespace NavigatorApplication
{
    public partial class frmNavigator : Form
    {
        public frmNavigator()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            List<string> instructions = new List<string>();

            #region Sample values
            /*
            5 5
            1 2 N
            LMLMLMLMM
            3 3 E
            MMRMMRMRRM
            */

            #endregion

            string[] separator = new string[] { Environment.NewLine };
            instructions = txtInputInstructions.Text.Split(separator, StringSplitOptions.None).ToList();

            Navigator.Navigator navigator = new Navigator.Navigator();
            List<string> result = navigator.Navigate(instructions);

            txtOutputResult.Text = "";
            foreach(string resultItem in result)
            {
                txtOutputResult.Text += resultItem + Environment.NewLine;
            }
        }
    }
}
