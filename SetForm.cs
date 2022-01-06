using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPin
{
    public partial class SetForm : Form
    {
        private WindowForm form;

        public double WindowFormOpacity { get; set; }

        public SetForm(WindowForm _WindowForm)
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            form = _WindowForm;
            WindowFormOpacity = form.Opacity;

            SetOpacityText();
            cbx_pin.Checked = form.FormBorderStyle == FormBorderStyle.None;
        }

        private void ReInitWindowForm()
        {
            form.Opacity = WindowFormOpacity;
            form.FormBorderStyle = cbx_pin.Checked ? FormBorderStyle.FixedSingle : FormBorderStyle.Sizable;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            WindowFormOpacity = (double)trackBar1.Value / 100;
            SetOpacityText();

            ReInitWindowForm();
        }

        private void SetOpacityText()
        {
            var windowFormOpacityInt = (int)(WindowFormOpacity * 100);
            txt_Opacity.Text = windowFormOpacityInt.ToString();
            trackBar1.Value = windowFormOpacityInt;
        }

        private void cbx_pin_CheckedChanged(object sender, EventArgs e)
        {
            ReInitWindowForm();
        }
    }
}