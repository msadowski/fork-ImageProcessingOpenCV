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
using ImageProcessingOpenCV.InterfacingNative;

namespace ImageProcessingOpenCV
{
    public partial class MainForm : Form
    {
        private NativeCommunication nativeCommunicator;

        public MainForm()
        {
            InitializeComponent();
            tbPath.Text = "C:\\Users\\mateu\\Pictures\\Lenna.jpg";
            nativeCommunicator = new NativeCommunication();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if(!File.Exists(tbPath.Text))
            {
                return;
            }
            string imagePath = tbPath.Text;

            Image image = Image.FromFile(imagePath);
            pbMain.Image = image;
        }

        private void btImageProcess_Click(object sender, EventArgs e)
        {
            Image oldImage = pbMain.Image;
            pbMain.Image = nativeCommunicator.ConvertImage(oldImage);
            pbMain.Invalidate();
            oldImage.Dispose();
        }

        private void btn_FirstApproximation_Click(object sender, EventArgs e)
        {
            double pan = (double)nupd_FirstApproxPan.Value;
            double tilt = (double)nupd_FirstApproxTilt.Value;
            int[] p1 = { (int)nupd_FirstApproxP10.Value, (int)nupd_FirstApproxP11.Value };
            int[] p2 = { (int)nupd_FirstApproxP20.Value, (int)nupd_FirstApproxP21.Value };
            nativeCommunicator.TestFirstAproximation(p1, p2, ref pan, ref tilt);
            nupd_FirstApproxPan.Value = (decimal)pan;
            nupd_FirstApproxTilt.Value = (decimal)tilt;
            MessageBox.Show($"Pan : {pan}, Tilt: {tilt}");
        }

        private void btn_FinalParams_Click(object sender, EventArgs e)
        {
            double pan = (double)nupd_FinalParams_Pan.Value;
            double tilt = (double)nupd_FinalParams_Tilt.Value;
            int zoom = (int)nupd_FinalParams_Zoom.Value;

            nativeCommunicator.TestFinalPtzParams(pb_RImage.Image, pb_PImage.Image, ref pan, ref tilt, ref zoom);

            nupd_FinalParams_Pan.Value = (decimal)pan;
            nupd_FinalParams_Tilt.Value = (decimal)tilt;
            nupd_FinalParams_Zoom.Value = zoom;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_FinalParams_R_Load_Click(object sender, EventArgs e)
        {
            loadImage(pb_RImage, txt_FinalParams_R_Load.Text);
        }

        private void btn_FinalParams_P_Load_Click(object sender, EventArgs e)
        {
            loadImage(pb_PImage, txt_FinalParams_P_Load.Text);
        }

        private void loadImage(PictureBox dest, string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            Image image = Image.FromFile(path);
            dest.Image = image;
        }
    }
}
