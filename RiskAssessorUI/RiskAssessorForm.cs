using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiskAssessorCore.Data;
using RiskAssessorLib.Entities;
using RiskAssessorLib.Logic;

namespace RiskAssessorUI
{
    public partial class RiskAssessorForm : Form
    {
        public RiskAssessorForm()
        {
            InitializeComponent();

            LoadData(); 
        }


        private void LoadData()
        {
            try
            {
                iCustomerBindingSource.DataSource = RiskAssessorDataAdapter.GetInstance().AllCustomers;

            }
            catch (Exception)
            {
                MessageBox.Show("Please place the csv files next to the exe :)");
            }
            comboBoxCustomer.SelectedIndex = -1;
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex != -1)
                labelUnusualWinnings.Visible = ((ICustomer) comboBoxCustomer.SelectedItem).CustomerHasUnusualWinningOdds();
        }
    }
}
