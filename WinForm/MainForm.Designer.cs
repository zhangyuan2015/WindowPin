namespace WindowPin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nfi_MinWindow = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_nfi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_create = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_nfi.SuspendLayout();
            this.SuspendLayout();
            // 
            // nfi_MinWindow
            // 
            this.nfi_MinWindow.ContextMenuStrip = this.cms_nfi;
            this.nfi_MinWindow.Icon = ((System.Drawing.Icon)(resources.GetObject("nfi_MinWindow.Icon")));
            this.nfi_MinWindow.Text = "WindowPin";
            this.nfi_MinWindow.Visible = true;
            this.nfi_MinWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nfi_MinWindow_MouseClick);
            // 
            // cms_nfi
            // 
            this.cms_nfi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_nfi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_create,
            this.tsmi_save,
            this.toolStripSeparator1,
            this.tsmi_close});
            this.cms_nfi.Name = "cms_nfi";
            this.cms_nfi.Size = new System.Drawing.Size(101, 76);
            // 
            // tsmi_create
            // 
            this.tsmi_create.Name = "tsmi_create";
            this.tsmi_create.Size = new System.Drawing.Size(100, 22);
            this.tsmi_create.Text = "新建";
            this.tsmi_create.Click += new System.EventHandler(this.tsmi_create_Click);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.Size = new System.Drawing.Size(100, 22);
            this.tsmi_save.Text = "保存";
            this.tsmi_save.Click += new System.EventHandler(this.tsmi_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(100, 22);
            this.tsmi_close.Text = "退出";
            this.tsmi_close.Click += new System.EventHandler(this.tsmi_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 292);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cms_nfi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon nfi_MinWindow;
        private ContextMenuStrip cms_nfi;
        private ToolStripMenuItem tsmi_create;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmi_close;
        private ToolStripMenuItem tsmi_save;
    }
}