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
    public partial class FrmVRScreen : Form
    {
        private bool index;

        public FrmVRScreen(int index)
        {
            InitializeComponent();
        }

        private void FrmVRScreen_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = "path img";
        }

        private void buttonCloseRouteVR_Click(object sender, EventArgs e)
        {
            int indexImg = 0;

            FrmRoutesScreen Route = new FrmRoutesScreen(indexImg);
            Route.MdiParent = this.MdiParent;
            Route.Show();
            this.Close();
        }
    }
}
