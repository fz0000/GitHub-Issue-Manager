
namespace GitHub_Issue_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxToken = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assignees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.closedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labels = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.milestone = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectCards = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.reactionGroups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStripButtonLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxToken,
            this.toolStripSeparator,
            this.toolStripButtonLogin,
            this.toolStripButtonLogout,
            this.toolStripSeparator1,
            this.ToolStripButtonDownload,
            this.ToolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 28);
            this.toolStripLabel1.Text = "Token:";
            // 
            // toolStripTextBoxToken
            // 
            this.toolStripTextBoxToken.Name = "toolStripTextBoxToken";
            this.toolStripTextBoxToken.Size = new System.Drawing.Size(300, 31);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButtonDownload
            // 
            this.ToolStripButtonDownload.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonDownload.Image")));
            this.ToolStripButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDownload.Name = "ToolStripButtonDownload";
            this.ToolStripButtonDownload.Size = new System.Drawing.Size(60, 28);
            this.ToolStripButtonDownload.Text = "下载";
            this.ToolStripButtonDownload.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonSave.Image")));
            this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new System.Drawing.Size(60, 28);
            this.ToolStripButtonSave.Text = "导出";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 410);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 441);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignees,
            this.author,
            this.body,
            this.closed,
            this.closedAt,
            this.comments,
            this.createdAt,
            this.id,
            this.labels,
            this.milestone,
            this.number,
            this.projectCards,
            this.reactionGroups,
            this.state,
            this.title,
            this.updatedAt,
            this.url});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(784, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // assignees
            // 
            this.assignees.HeaderText = "assignees";
            this.assignees.MinimumWidth = 8;
            this.assignees.Name = "assignees";
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            // 
            // body
            // 
            this.body.HeaderText = "body";
            this.body.MinimumWidth = 8;
            this.body.Name = "body";
            // 
            // closed
            // 
            this.closed.HeaderText = "closed";
            this.closed.MinimumWidth = 8;
            this.closed.Name = "closed";
            // 
            // closedAt
            // 
            this.closedAt.HeaderText = "closedAt";
            this.closedAt.MinimumWidth = 8;
            this.closedAt.Name = "closedAt";
            // 
            // comments
            // 
            this.comments.HeaderText = "comments";
            this.comments.MinimumWidth = 8;
            this.comments.Name = "comments";
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "createdAt";
            this.createdAt.MinimumWidth = 8;
            this.createdAt.Name = "createdAt";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // labels
            // 
            this.labels.HeaderText = "labels";
            this.labels.MinimumWidth = 8;
            this.labels.Name = "labels";
            // 
            // milestone
            // 
            this.milestone.HeaderText = "milestone";
            this.milestone.MinimumWidth = 8;
            this.milestone.Name = "milestone";
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 8;
            this.number.Name = "number";
            // 
            // projectCards
            // 
            this.projectCards.HeaderText = "projectCards";
            this.projectCards.MinimumWidth = 8;
            this.projectCards.Name = "projectCards";
            // 
            // reactionGroups
            // 
            this.reactionGroups.HeaderText = "reactionGroups";
            this.reactionGroups.MinimumWidth = 8;
            this.reactionGroups.Name = "reactionGroups";
            // 
            // state
            // 
            this.state.HeaderText = "state";
            this.state.MinimumWidth = 8;
            this.state.Name = "state";
            // 
            // title
            // 
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 8;
            this.title.Name = "title";
            // 
            // updatedAt
            // 
            this.updatedAt.HeaderText = "updatedAt";
            this.updatedAt.MinimumWidth = 8;
            this.updatedAt.Name = "updatedAt";
            // 
            // url
            // 
            this.url.HeaderText = "url";
            this.url.MinimumWidth = 8;
            this.url.Name = "url";
            // 
            // toolStripButtonLogin
            // 
            this.toolStripButtonLogin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogin.Image")));
            this.toolStripButtonLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogin.Name = "toolStripButtonLogin";
            this.toolStripButtonLogin.Size = new System.Drawing.Size(68, 28);
            this.toolStripButtonLogin.Text = "Login";
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogout.Image")));
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(77, 28);
            this.toolStripButtonLogout.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Issue Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDownload;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignees;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn body;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closed;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn labels;
        private System.Windows.Forms.DataGridViewComboBoxColumn milestone;
        private System.Windows.Forms.DataGridViewComboBoxColumn number;
        private System.Windows.Forms.DataGridViewComboBoxColumn projectCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn reactionGroups;
        private System.Windows.Forms.DataGridViewComboBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAt;
        private System.Windows.Forms.DataGridViewLinkColumn url;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxToken;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogin;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

