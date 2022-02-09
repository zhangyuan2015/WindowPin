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
            this.cbx_pin = new System.Windows.Forms.CheckBox();
            this.txt_Opacity = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lab_Opacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_pin
            // 
            this.cbx_pin.AutoSize = true;
            this.cbx_pin.Location = new System.Drawing.Point(249, 12);
            this.cbx_pin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbx_pin.Name = "cbx_pin";
            this.cbx_pin.Size = new System.Drawing.Size(51, 21);
            this.cbx_pin.TabIndex = 1;
            this.cbx_pin.Text = "固定";
            this.cbx_pin.UseVisualStyleBackColor = true;
            this.cbx_pin.CheckedChanged += new System.EventHandler(this.cbx_pin_CheckedChanged);
            // 
            // txt_Opacity
            // 
            this.txt_Opacity.Location = new System.Drawing.Point(219, 10);
            this.txt_Opacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Opacity.Name = "txt_Opacity";
            this.txt_Opacity.Size = new System.Drawing.Size(26, 23);
            this.txt_Opacity.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(56, 8);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lab_Opacity
            // 
            this.lab_Opacity.AutoSize = true;
            this.lab_Opacity.Location = new System.Drawing.Point(9, 8);
            this.lab_Opacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Opacity.Name = "lab_Opacity";
            this.lab_Opacity.Size = new System.Drawing.Size(44, 17);
            this.lab_Opacity.TabIndex = 4;
            this.lab_Opacity.Text = "透明度";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 46);
            this.Controls.Add(this.lab_Opacity);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txt_Opacity);
            this.Controls.Add(this.cbx_pin);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SetForm";
            this.Text = "SetForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox cbx_pin;
        private TextBox txt_Opacity;
        private TrackBar trackBar1;
        private Label lab_Opacity;
    }
}