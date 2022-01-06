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
    public partial class CreatePathForm : MaterialForm
    {
        TextBox txt_folderPath = new TextBox();
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

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}