namespace MsmqOperate
{
    partial class MsmqOperateForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("专用队列");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsmqOperateForm));
            this.menuStrip_MsmqOperate = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView_PrivatQueue = new System.Windows.Forms.TreeView();
            this.imageList_QueueInfo = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_QuueMessageInfo = new System.Windows.Forms.DataGridView();
            this.menuStrip_MsmqOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuueMessageInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_MsmqOperate
            // 
            this.menuStrip_MsmqOperate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip_MsmqOperate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip_MsmqOperate.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MsmqOperate.Name = "menuStrip_MsmqOperate";
            this.menuStrip_MsmqOperate.Size = new System.Drawing.Size(739, 25);
            this.menuStrip_MsmqOperate.TabIndex = 0;
            this.menuStrip_MsmqOperate.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // treeView_PrivatQueue
            // 
            this.treeView_PrivatQueue.ImageIndex = 0;
            this.treeView_PrivatQueue.ImageList = this.imageList_QueueInfo;
            this.treeView_PrivatQueue.Location = new System.Drawing.Point(0, 25);
            this.treeView_PrivatQueue.Name = "treeView_PrivatQueue";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Note0_PrivateQueue";
            treeNode1.Text = "专用队列";
            this.treeView_PrivatQueue.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView_PrivatQueue.SelectedImageIndex = 0;
            this.treeView_PrivatQueue.Size = new System.Drawing.Size(206, 426);
            this.treeView_PrivatQueue.TabIndex = 1;
            this.treeView_PrivatQueue.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_PrivatQueue_NodeMouseClick);
            // 
            // imageList_QueueInfo
            // 
            this.imageList_QueueInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_QueueInfo.ImageStream")));
            this.imageList_QueueInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_QueueInfo.Images.SetKeyName(0, "PrivateFolder.ico");
            this.imageList_QueueInfo.Images.SetKeyName(1, "TransactionalQueue.ico");
            // 
            // dataGridView_QuueMessageInfo
            // 
            this.dataGridView_QuueMessageInfo.AllowUserToAddRows = false;
            this.dataGridView_QuueMessageInfo.AllowUserToDeleteRows = false;
            this.dataGridView_QuueMessageInfo.AllowUserToResizeColumns = false;
            this.dataGridView_QuueMessageInfo.AllowUserToResizeRows = false;
            this.dataGridView_QuueMessageInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_QuueMessageInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_QuueMessageInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_QuueMessageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuueMessageInfo.Location = new System.Drawing.Point(203, 25);
            this.dataGridView_QuueMessageInfo.Name = "dataGridView_QuueMessageInfo";
            this.dataGridView_QuueMessageInfo.ReadOnly = true;
            this.dataGridView_QuueMessageInfo.RowTemplate.Height = 23;
            this.dataGridView_QuueMessageInfo.Size = new System.Drawing.Size(536, 426);
            this.dataGridView_QuueMessageInfo.TabIndex = 2;
            // 
            // MsmqOperateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.dataGridView_QuueMessageInfo);
            this.Controls.Add(this.treeView_PrivatQueue);
            this.Controls.Add(this.menuStrip_MsmqOperate);
            this.MainMenuStrip = this.menuStrip_MsmqOperate;
            this.Name = "MsmqOperateForm";
            this.Text = "MSMQ操作";
            this.menuStrip_MsmqOperate.ResumeLayout(false);
            this.menuStrip_MsmqOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuueMessageInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_MsmqOperate;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView_PrivatQueue;
        private System.Windows.Forms.ImageList imageList_QueueInfo;
        private System.Windows.Forms.DataGridView dataGridView_QuueMessageInfo;
    }
}

