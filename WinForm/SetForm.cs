using WindowPin.Code.Model;
using WindowPin.Code.Service;

namespace WindowPin
{
    public partial class SetForm : Form
    {
        private WindowForm form;
        private readonly MainConfigService mainConfigService = MainConfigService.CreateInstance();

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

        private void SetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var windowForm = mainConfigService.MainConfig.WindowForms.FirstOrDefault(a => a.Path == form.BasePath);
            if (windowForm == null)
            {
                windowForm = new WindowFormConfig { Path = form.BasePath };
                mainConfigService.MainConfig.WindowForms.Add(windowForm);
            }
            windowForm.Opacity = WindowFormOpacity;
            windowForm.IsFix = cbx_pin.Checked;
        }
    }
}