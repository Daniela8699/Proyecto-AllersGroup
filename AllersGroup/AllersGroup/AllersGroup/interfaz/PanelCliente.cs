using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllersGroup.interfaz
{
    public partial class PanelCliente : Form
    {
        public PanelCliente(String cardCode,String GroupName,String City, String depart, String payment)
        {
            InitializeComponent();
            lblCardCode.Text = cardCode;
            lblGroupName.Text = GroupName;
            lblCity.Text = City;
            lblDepartment.Text = depart;
            lblPayment.Text = payment;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
