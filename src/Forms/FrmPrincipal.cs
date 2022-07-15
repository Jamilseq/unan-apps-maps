using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void buttonGetRoute_Click(object sender, EventArgs e)
        {
            string DIR = Directory.GetCurrentDirectory();
            string routes = DIR.Replace(@"\bin\Debug", @"\Resourses\Files\Routes.txt");
            string topRoutes = DIR.Replace(@"\bin\Debug", @"\Resourses\Files\TopRoutes.txt");
            string location = txtLocation.Text.ToLower();
            string destination = txtSearch.Text.ToLower();
            bool routeExist = false;

            if (string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(location))
            {
                txtErrorsRoutes.Text = "Ingrese los datos de su busqueda";
            }
            else
            {
                StreamReader sr = new StreamReader(routes);
                string locationDB = sr.ReadLine();
                string destinationDB = sr.ReadLine();
                string imageIndex = sr.ReadLine();
                string imageIndexVR = sr.ReadLine();

                while (!routeExist && locationDB != null && destinationDB != null && imageIndex != null && imageIndexVR != null)
                {
                    if (location.Equals(locationDB) && destination.Equals(destinationDB))
                    {
                        routeExist = true;
                    }
                    else
                    {
                        location = sr.ReadLine();
                        destination = sr.ReadLine();
                        imageIndex = sr.ReadLine();
                        imageIndexVR = sr.ReadLine();
                    }
                }

                sr.Close();

                if (routeExist)
                {
                    FrmRoutesScreen Route = new FrmRoutesScreen(int.Parse(imageIndex), int.Parse(imageIndexVR), destinationDB);
                    Route.MdiParent = this.MdiParent;

                    FileStream fs = new FileStream(topRoutes, FileMode.Append);
                    StreamWriter insert = new StreamWriter(fs);

                    insert.WriteLine(location);
                    insert.Close();

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
