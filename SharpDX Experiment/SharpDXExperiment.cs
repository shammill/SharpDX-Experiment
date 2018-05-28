using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Desktop;
using SharpDX.Windows;

namespace SharpDX_Experiment
{
    public partial class SharpDXExperiment : RenderForm
    {
        public SharpDXExperiment()
        {
            InitializeComponent();
            MakeFullScreen();
        }

        public void MakeFullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.IsFullscreen = true;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        public void MakeWindowed()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.IsFullscreen = false;
        }


    }
}
