using WindowPin.Code.Model;
using WindowPin.Code.Service;

namespace WindowPin
{
    public partial class CreatePathForm : Form
    {
        private readonly MainConfigService mainConfigService = MainConfigService.CreateInstance();

        /// <summary>
        /// 
        /// </summary>
        private static CreatePathForm _form;
        public static CreatePathForm CreateInstance()
        {
            if (_form == null)
            {
                _form = new CreatePathForm();
            }
            return _form;
        }

        public CreatePathForm()
        {
            InitializeComponent();
        }

        private void CreatePathForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_folderPath_Click(object sender, EventArgs e)
        {
            fbd_folderPath.Description = "请选择文件夹";
            fbd_folderPath.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd_folderPath.ShowNewFolderButton = true;
            if (txt_folderPath.Text.Length > 0) fbd_folderPath.SelectedPath = txt_folderPath.Text;
            if (fbd_folderPath.ShowDialog() == DialogResult.OK)
            {
                txt_folderPath.Text = fbd_folderPath.SelectedPath;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var windowForm = mainConfigService.MainConfig.WindowForms.FirstOrDefault(a => a.Path == txt_folderPath.Text);
            if (windowForm == null)
            {
                windowForm = new WindowFormConfig { Path = txt_folderPath.Text };
                mainConfigService.MainConfig.WindowForms.Add(windowForm);
                new WindowForm(windowForm).Show();
            }
            else
            {
                MessageBox.Show(txt_folderPath.Text + ":已打开");
            }
        }
    }
}