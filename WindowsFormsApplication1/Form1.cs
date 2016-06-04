using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixologist
{
    public partial class mainForm : Form
    {
        private calculate calculator = new calculate();
        public mainForm()
        {
            InitializeComponent();
            calculate calculator = new calculate();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtBaseNic.Text = "72";
            txtBottleSize.Text = "30";
            txtDesiredStr.Text = "3";
            float test = new float();
            test = Convert.ToSingle(txtBottleSize.Text);
            lblResultNic.Text = test.ToString();
        }

        private void txtBaseNic_TextChanged(object sender, EventArgs e)
        {
           float nicAmount = calculator.calcNic(Convert.ToSingle(txtBottleSize.Text), Convert.ToSingle(txtBaseNic.Text), Convert.ToSingle(txtDesiredStr.Text));
           // lblResultNic.Text = nicAmount.ToString();
        }

        private void txtBottleSize_TextChanged(object sender, EventArgs e)
        {
            float nicAmount = calculator.calcNic(Convert.ToSingle(txtBottleSize.Text), Convert.ToSingle(txtBaseNic.Text), Convert.ToSingle(txtDesiredStr.Text));
            //lblResultNic.Text = nicAmount.ToString();
        }

        private void txtDesiredStr_TextChanged(object sender, EventArgs e)
        {
           float nicAmount = calculator.calcNic(Convert.ToSingle(txtBottleSize.Text), Convert.ToSingle(txtBaseNic.Text), Convert.ToSingle(txtDesiredStr.Text));
           // lblResultNic.Text = nicAmount.ToString();
        }
    }
}
