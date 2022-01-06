using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPin
{
    public partial class WindowForm : Form
    {
        private string basePath;
        public WindowForm(string _path)
        {
            InitializeComponent();
            
            basePath = _path;

            //this.BackColor = Color.FromArgb(32, 43, 67);
            //this.lvw_folders.BackColor = Color.FromArgb(32, 43, 67);

            this.Text = basePath;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            Init_fsw();
            Init_lvw_folders();

            LoadFolder();
        }

        #region 初始化 lvw_folders
        /// <summary>
        /// 初始化 lvw_folders
        /// </summary>
        private void Init_lvw_folders()
        {
            this.lvw_folders.View = View.Details;
            //this.lvw_folders.Columns.Add("名称", 200);
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
            fsw.Path = basePath;
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

        private void WindowForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 加载文件夹
        /// </summary>
        private void LoadFolder()
        {
            this.lvw_folders.Items.Clear();

            var baseDir = new DirectoryInfo(basePath);
            if (baseDir.Exists)
            {
                foreach (var subDir in baseDir.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(
                        new string[]
                        {
                                subDir.Name
                                //subDir.FullName,
                                //subDir.CreationTime.ToString("yyyy-MM-dd HH:mm:ss") 
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
            p.StartInfo.Arguments = $" {basePath}";
            p.Start();
        }
    }
}