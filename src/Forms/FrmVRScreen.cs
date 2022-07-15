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
        private int _indexMap;
        private int _indexVRMap;
        private string destination;

        public FrmVRScreen(int indexMap, int indexVRMap, string destination)
        {

            InitializeComponent();
            this.destination = destination;
            this._indexMap = indexMap;
            this._indexVRMap = indexVRMap;
        }

        private void FrmVRScreen_Load(object sender, EventArgs e)
        {
            paneBgRouteVR.BackgroundImage = imageListRoutesVR.Images[_indexVRMap];
            pictureBoxMiniMap.BackgroundImage = imageListRoutesVR.Images[_indexVRMap];
            txtNameDestination.Text = destination;
        }

        private void buttonCloseRouteVR_Click(object sender, EventArgs e)
        {
            FrmRoutesScreen Route = new FrmRoutesScreen(_indexMap, _indexVRMap, destination);
            Route.MdiParent = this.MdiParent;
            Route.Show();
            this.Close();
        }
    }
}
