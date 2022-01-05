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
        public SetForm(WindowForm _WindowForm)
        {
            InitializeComponent();
            form = _WindowForm;

            txt_Opacity.Text = form.Opacity.ToString();
            cbx_pin.Checked = form.FormBorderStyle == FormBorderStyle.None;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            form.Opacity = double.Parse(txt_Opacity.Text);
            form.FormBorderStyle = cbx_pin.Checked ? FormBorderStyle.FixedSingle : FormBorderStyle.Sizable;

            //this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decimal i = 100;
            txt_Opacity.Text = (trackBar1.Value / i).ToString();
        }
    }
}