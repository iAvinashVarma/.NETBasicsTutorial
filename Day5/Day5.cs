using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day5
{
    public partial class Day5 : Form
    {
        public Day5()
        {
            InitializeComponent();
            cbMathProcess.SelectedIndex = 0;
        }

        private void tbNumberOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumericValues(sender, e);
        }

        private void OnlyNumericValues(object sender, KeyPressEventArgs e)
        {
            // Make sures only numeric value is entered.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OnlyNumericValues(object sender, KeyPressEventArgs e, bool isDecimal)
        {
            OnlyNumericValues(sender, e);

            // Only one decimal point is allowed
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbNumberTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumericValues(sender, e);
        }

        private void tbNumberThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumericValues(sender, e);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int tbOne;// = int.Parse(tbNumberOne.Text);
            int tbTwo;// = int.Parse(tbNumberTwo.Text);
            int tbThree;// = int.Parse(tbNumberThree.Text);
            int.TryParse(tbNumberOne.Text, out tbOne);
            int.TryParse(tbNumberTwo.Text, out tbTwo);
            int.TryParse(tbNumberThree.Text, out tbThree);
            switch(cbMathProcess.SelectedIndex)
            {
                case 0:
                    tbResult.Text = (tbOne + tbTwo + tbThree).ToString();
                    break;
                case 1:
                    tbResult.Text = (tbOne * tbTwo * tbTwo).ToString();
                    break;
                case 2:
                    tbResult.Text = (tbOne - tbTwo - tbThree).ToString();
                    break;
                default:
                    tbResult.Text = "0";
                    break;
            }
        }
    }
}
