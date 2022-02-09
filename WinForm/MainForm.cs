using WindowPin.Code.Service;

namespace WindowPin
{
    public partial class MainForm : Form
    {
        private readonly MainConfigService mainConfigService = MainConfigService.CreateInstance();

        public MainForm()
        {
            InitializeComponent();
            //this.Opacity = 0;//透明的
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            nfi_MinWindow.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var windowForm in mainConfigService.MainConfig.WindowForms)
            {
                new WindowForm(windowForm).Show();
            }
        }

        private void nfi_MinWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Activate_Main_Form();
            }
        }

        private void Activate_Main_Form()
        {
            /*if (this.WindowState == FormWindowState.Minimized)
            {
                //还原窗体
                this.WindowState = FormWindowState.Normal;
                //系统任务栏显示图标
                this.ShowInTaskbar = true;
            }
            //激活窗体并获取焦点
            this.Activate();*/
        }

        private void tsmi_create_Click(object sender, EventArgs e)
        {
            CreatePathForm.CreateInstance().Show();
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_save_Click(object sender, EventArgs e)
        {
            mainConfigService.Update();
        }
    }
}