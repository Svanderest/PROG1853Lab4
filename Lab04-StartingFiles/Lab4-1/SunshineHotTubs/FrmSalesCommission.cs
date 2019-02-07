using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Sebastian van der Est
namespace SunshineHotTubs
{
    public partial class FrmSalesCommission : Form
    {
        double cliffTotal = 0;
        double marshaTotal = 0;
        double dinoTotal = 0;

        public FrmSalesCommission()
        {
            InitializeComponent();
        }

        private void btnCalcCommission_Click(object sender, EventArgs e)
        {
            char initial = Convert.ToChar(txtInitial.Text);
            double comission = Convert.ToDouble(txtSaleTotal.Text) * 0.1;
            lblCommission.Text = comission.ToString("C2");
            switch(initial)
            {
                case 'c':
                case 'C': cliffTotal += comission;
                    break;
                case 'm':
                case 'M': marshaTotal += comission;
                    break;
                case 'd':
                case 'D': dinoTotal += comission;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInitial.Text = "";
            txtSaleTotal.Text = "";
            lblCommission.Text = "";
            cliffTotal = 0;
            marshaTotal = 0;
            dinoTotal = 0;
        }

        private void btnDisplayCommission_Click(object sender, EventArgs e)
        {
            MessageBox.Show(  "Cliff's Commissions: " + cliffTotal.ToString("C2")
                            + "\nMarsha's Commissions: " + marshaTotal.ToString("C2")
                            + "\nDino's Commissions: " + dinoTotal.ToString("C2")
                            );
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
