using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotalCalories_Click(object sender, EventArgs e)
        {
            try
            {
                double CookieNumber = double.Parse(txtCookieNumber.Text);

                //calculate calories 
                double CaloriesNumber = CookieNumber*(300/(40/10));

                //display result
                lblTotal.Text = "You ate " + CaloriesNumber + " calories";
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
