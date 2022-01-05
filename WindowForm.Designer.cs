namespace WindowPin
{
    partial class WindowForm
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
            this.components = new System.ComponentModel.Container();
            this.cms_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmi_openSet = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_menu
            // 
            this.cms_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_openSet});
            this.cms_menu.Name = "cms_menu";
            this.cms_menu.Size = new System.Drawing.Size(109, 28);
            // 
            // tmi_openSet
            // 
            this.tmi_openSet.Name = "tmi_openSet";
            this.tmi_openSet.Size = new System.Drawing.Size(108, 24);
            this.tmi_openSet.Text = "设置";
            this.tmi_openSet.Click += new System.EventHandler(this.tmi_openSet_Click);
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cms_menu;
            this.Name = "WindowForm";
            this.Text = "WindowForm";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.cms_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip cms_menu;
        private ToolStripMenuItem tmi_openSet;
    }
}