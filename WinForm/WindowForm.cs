using System.Diagnostics;
using WindowPin.Code.Model;
using WindowPin.Code.Service;

namespace WindowPin
{
    public partial class WindowForm : Form
    {
        public string BasePath { get; set; }
        private readonly WindowFormConfig FormConfig;

        public WindowForm(WindowFormConfig config)
        {
            InitializeComponent();

            FormConfig = config;
            BasePath = FormConfig.Path;

            //this.BackColor = Color.FromArgb(32, 43, 67);
            //this.lvw_folders.BackColor = Color.FromArgb(32, 43, 67);

            this.Text = BasePath;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            this.Top = config.Top;
            this.Left = config.Left;
            this.Height = config.Height;
            this.Width = config.Width;
            this.Opacity = config.Opacity;
            this.FormBorderStyle = config.IsFix ? FormBorderStyle.FixedSingle : FormBorderStyle.Sizable;

            Init_fsw();
            Init_lvw_folders();

            LoadFolder();
        }

        #region 初始化 lvw_folders
        /// <summary>
        /// 初始化 ListView lvw_folders
        /// </summary>
        private void Init_lvw_folders()
        {
            this.lvw_folders.View = View.Details;
            this.lvw_folders.Columns.Add("名称", 200);
            //this.lvw_folders.Columns.Add("路径", 200);
            //this.lvw_folders.Columns.Add("创建时间", 200);

            this.lvw_folders.ColumnClick += new ColumnClickEventHandler(lvw_folders_ColumnClick);
        }

        private void lvw_folders_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //this.lvw_folders.ListViewItemSorter = new ListViewItemComparer(x++, this.lvw_folders.Columns[e.Column].Text);
            this.lvw_folders.Sort();
        }
        #endregion

        #region 初始化 文件变化监控
        /// <summary>
        /// 初始化文件变化监控
        /// </summary>
        private void Init_fsw()
        {
            var fsw = new FileSystemWatcher();
            fsw.Path = BasePath;
            fsw.IncludeSubdirectories = false;
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
            fsw.Created += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);
            fsw.Deleted += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);
            fsw.Changed += new FileSystemEventHandler(this.fileSystemWatcher_EventHandle);
            fsw.Renamed += new RenamedEventHandler(this.fileSystemWatcher_Renamed);
            fsw.EnableRaisingEvents = true;
        }

        private void fileSystemWatcher_EventHandle(object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法
        {
            LoadFolder();
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)   //文件重命名时被调用的处理方法
        {
            LoadFolder();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 加载文件夹
        /// </summary>
        private void LoadFolder()
        {
            this.lvw_folders.Items.Clear();

            var baseDir = new DirectoryInfo(BasePath);
            if (baseDir.Exists)
            {
                foreach (var subDir in baseDir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(
                        new string[]
                        {
                                subDir.Name,
                                subDir.FullName,
                                subDir.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
                        })
                    { Tag = subDir.FullName };
                    this.lvw_folders.Items.Add(item);
                }
            }
        }

        private void tmi_openSet_Click(object sender, EventArgs e)
        {
            new SetForm(this).ShowDialog();
        }

        private void tmi_openExplorer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "explorer.exe";
            p.StartInfo.Arguments = $" {BasePath}";
            p.Start();
        }

        private void WindowForm_Move(object sender, EventArgs e)
        {
            FormConfig.Top = Top;
            FormConfig.Left = Left;
        }

        private void WindowForm_Resize(object sender, EventArgs e)
        {
            FormConfig.Height = Height;
            FormConfig.Width = Width;
        }
    }
}