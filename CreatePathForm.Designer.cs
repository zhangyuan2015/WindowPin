namespace WindowPin
{
    partial class CreatePathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePathForm));
            this.txt_folderPath = new System.Windows.Forms.TextBox();
            this.fbd_folderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folderPath = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_folderPath
            // 
            this.txt_folderPath.Location = new System.Drawing.Point(0, 0);
            this.txt_folderPath.Name = "txt_folderPath";
            this.txt_folderPath.Size = new System.Drawing.Size(380, 27);
            this.txt_folderPath.TabIndex = 0;
            // 
            // btn_folderPath
            // 
            this.btn_folderPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_folderPath.BackgroundImage")));
            this.btn_folderPath.Location = new System.Drawing.Point(386, 0);
            this.btn_folderPath.Name = "btn_folderPath";
            this.btn_folderPath.Size = new System.Drawing.Size(34, 29);
            this.btn_folderPath.TabIndex = 1;
            this.btn_folderPath.UseVisualStyleBackColor = true;
            this.btn_folderPath.Click += new System.EventHandler(this.btn_folderPath_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create.BackgroundImage")));
            this.btn_create.Location = new System.Drawing.Point(426, 0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(37, 29);
            this.btn_create.TabIndex = 2;
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // CreatePathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 31);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_folderPath);
            this.Controls.Add(this.txt_folderPath);
            this.Name = "CreatePathForm";
            this.Text = "CreatePathForm";
            this.Load += new System.EventHandler(this.CreatePathForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_folderPath;
        private FolderBrowserDialog fbd_folderPath;
        private Button btn_folderPath;
        private Button btn_create;
    }
}