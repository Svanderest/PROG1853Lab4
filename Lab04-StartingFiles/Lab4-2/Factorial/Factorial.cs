using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace Factorial
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            UInt64 factorial = 1;
            UInt64 n = Convert.ToUInt64(txtNumber.Text);
            if(n<=20)
            {
                for(UInt64 i=2; i<=n; i++)            
                    factorial *= i;            
            }
            lblResult.Text = factorial.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
