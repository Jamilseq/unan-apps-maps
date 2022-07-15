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
    public partial class FrmRoutesScreen : Form
    {
        private int _indexMap;
        private int _indexVRMap;
        private string destination;
        public FrmRoutesScreen(int indexMap, int indexVRMap, string destination)
        {
            InitializeComponent();
            this.destination = destination;
            this._indexMap = indexMap;
            this._indexVRMap = indexVRMap;
        }

        private void FrmRoutesScreen_Load(object sender, EventArgs e)
        {
            
            panelBgRoutesScreen.BackgroundImage = imageListRoutes.Images[_indexMap];
            pictureBoxMiniVR.BackgroundImage = imageListRoutes.Images[2];
            txtNameDestination.Text = destination;
            
        }

        private void buttonCloseRoute_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.MdiParent = this.MdiParent;
            Principal.Show();
            this.Close();

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            FrmVRScreen VR = new FrmVRScreen(_indexMap, _indexVRMap, destination);
            VR.MdiParent = this.MdiParent;
            VR.Show();
        }
    }
}
