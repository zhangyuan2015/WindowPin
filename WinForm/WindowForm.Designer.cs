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
            this.tmi_openExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.lvw_folders = new System.Windows.Forms.ListView();
            this.cms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_menu
            // 
            this.cms_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_openSet,
            this.tmi_openExplorer});
            this.cms_menu.Name = "cms_menu";
            this.cms_menu.Size = new System.Drawing.Size(137, 48);
            // 
            // tmi_openSet
            // 
            this.tmi_openSet.Name = "tmi_openSet";
            this.tmi_openSet.Size = new System.Drawing.Size(136, 22);
            this.tmi_openSet.Text = "设置";
            this.tmi_openSet.Click += new System.EventHandler(this.tmi_openSet_Click);
            // 
            // tmi_openExplorer
            // 
            this.tmi_openExplorer.Name = "tmi_openExplorer";
            this.tmi_openExplorer.Size = new System.Drawing.Size(136, 22);
            this.tmi_openExplorer.Text = "打开文件夹";
            this.tmi_openExplorer.Click += new System.EventHandler(this.tmi_openExplorer_Click);
            // 
            // lvw_folders
            // 
            this.lvw_folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_folders.Location = new System.Drawing.Point(0, 0);
            this.lvw_folders.Name = "lvw_folders";
            this.lvw_folders.Size = new System.Drawing.Size(622, 382);
            this.lvw_folders.TabIndex = 1;
            this.lvw_folders.UseCompatibleStateImageBehavior = false;
            this.lvw_folders.View = System.Windows.Forms.View.Details;
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.ContextMenuStrip = this.cms_menu;
            this.Controls.Add(this.lvw_folders);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "WindowForm";
            this.Text = "WindowForm";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.cms_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip cms_menu;
        private ToolStripMenuItem tmi_openSet;
        private ListView lvw_folders;
        private ToolStripMenuItem tmi_openExplorer;
    }
}