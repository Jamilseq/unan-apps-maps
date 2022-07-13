using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetRoute_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.ToLower();
            string destination = txtSearch.Text.ToLower();

            FrmRoutesScreen Route = new FrmRoutesScreen();
            Route.MdiParent = this.MdiParent;


            if (string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(location))
            {
                txtErrorsRoutes.Text = "Ingrese los datos de su busqueda";
            }
            else
            {
                //change for the files 
                if (location == "puente" && destination == "tesoreria")
                {
                    Route.Show();
                    this.Close();
                }
                else
                {
                    txtErrorsRoutes.Text = "Ruta no encontrada";
                }
            }
        }
    }
}
