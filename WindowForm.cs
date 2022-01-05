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
    public partial class WindowForm : Form
    {
        public WindowForm(string path)
        {
            InitializeComponent();
            this.Text = path;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {

        }

        private void tmi_openSet_Click(object sender, EventArgs e)
        {
            new SetForm(this).Show();
        }
    }
}