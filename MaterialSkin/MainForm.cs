using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPin.MaterialSkin
{
    public partial class MainForm : MaterialForm
    {
        NotifyIcon nfi_MinWindow;
        ContextMenuStrip cms_by_Nfi;

        public MainForm()
        {
            InitializeComponent();

            components = new Container();
            nfi_MinWindow = new NotifyIcon(components);
            cms_by_Nfi = new ContextMenuStrip(components);

            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;

            nfi_MinWindow.Icon = new Icon("./Resources/Icon/icon-128.ico");
            nfi_MinWindow.Visible = true;
            nfi_MinWindow.MouseClick += nfi_MinWindow_MouseClick;

            ToolStripMenuItem tsmi_create = new ToolStripMenuItem("新建", null, tsmi_create_Click);
            ToolStripMenuItem tsmi_close = new ToolStripMenuItem("退出", null, tsmi_close_Click);
            cms_by_Nfi.Items.AddRange(new[] { tsmi_create, tsmi_close });
            nfi_MinWindow.ContextMenuStrip = cms_by_Nfi;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void nfi_MinWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("关于：");
            }
        }

        private void tsmi_create_Click(object sender, EventArgs e)
        {
            CreatePathForm.CreateInstance().Show();
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
