namespace WindowPin
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OK = new System.Windows.Forms.Button();
            this.cbx_pin = new System.Windows.Forms.CheckBox();
            this.txt_Opacity = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lab_Opacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(562, 262);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 29);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "保存";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cbx_pin
            // 
            this.cbx_pin.AutoSize = true;
            this.cbx_pin.Location = new System.Drawing.Point(577, 83);
            this.cbx_pin.Name = "cbx_pin";
            this.cbx_pin.Size = new System.Drawing.Size(61, 24);
            this.cbx_pin.TabIndex = 1;
            this.cbx_pin.Text = "固定";
            this.cbx_pin.UseVisualStyleBackColor = true;
            // 
            // txt_Opacity
            // 
            this.txt_Opacity.Location = new System.Drawing.Point(281, 12);
            this.txt_Opacity.Name = "txt_Opacity";
            this.txt_Opacity.Size = new System.Drawing.Size(32, 27);
            this.txt_Opacity.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(72, 9);
            this.trackBar1.Maximum = 80;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(203, 56);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lab_Opacity
            // 
            this.lab_Opacity.AutoSize = true;
            this.lab_Opacity.Location = new System.Drawing.Point(12, 9);
            this.lab_Opacity.Name = "lab_Opacity";
            this.lab_Opacity.Size = new System.Drawing.Size(54, 20);
            this.lab_Opacity.TabIndex = 4;
            this.lab_Opacity.Text = "透明度";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Opacity);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txt_Opacity);
            this.Controls.Add(this.cbx_pin);
            this.Controls.Add(this.btn_OK);
            this.Name = "SetForm";
            this.Text = "SetForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_OK;
        private CheckBox cbx_pin;
        private TextBox txt_Opacity;
        private TrackBar trackBar1;
        private Label lab_Opacity;
    }
}