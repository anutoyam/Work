namespace workbench
{
    partial class MainFrm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RACK01 = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rACK7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ExcelLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(20, 87);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(675, 536);
            this.DataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Search,
            this.TSMI_Add,
            this.TSMI_Delete,
            this.TSMI_Update,
            this.TSMI_ExcelLoad,
            this.TSMI_Close});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Add
            // 
            this.TSMI_Add.Name = "TSMI_Add";
            this.TSMI_Add.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Add.Text = "등록";
            this.TSMI_Add.Click += new System.EventHandler(this.TSMI_Add_Click);
            // 
            // TSMI_Delete
            // 
            this.TSMI_Delete.Name = "TSMI_Delete";
            this.TSMI_Delete.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Delete.Text = "제거";
            // 
            // TSMI_Update
            // 
            this.TSMI_Update.Name = "TSMI_Update";
            this.TSMI_Update.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Update.Text = "수정";
            // 
            // TSMI_Close
            // 
            this.TSMI_Close.Name = "TSMI_Close";
            this.TSMI_Close.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Close.Text = "종료";
            this.TSMI_Close.Click += new System.EventHandler(this.TSMI_Close_Click);
            // 
            // TSMI_Search
            // 
            this.TSMI_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_RACK01,
            this.rACK2ToolStripMenuItem,
            this.rACK3ToolStripMenuItem,
            this.rACK4ToolStripMenuItem,
            this.rACK5ToolStripMenuItem,
            this.rACK6ToolStripMenuItem,
            this.rACK7ToolStripMenuItem});
            this.TSMI_Search.Name = "TSMI_Search";
            this.TSMI_Search.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Search.Text = "조회";
            // 
            // TSMI_RACK01
            // 
            this.TSMI_RACK01.Name = "TSMI_RACK01";
            this.TSMI_RACK01.Size = new System.Drawing.Size(152, 22);
            this.TSMI_RACK01.Text = "RACK 1";
            this.TSMI_RACK01.Click += new System.EventHandler(this.TSMI_RACK01_Click);
            // 
            // rACK2ToolStripMenuItem
            // 
            this.rACK2ToolStripMenuItem.Name = "rACK2ToolStripMenuItem";
            this.rACK2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK2ToolStripMenuItem.Text = "RACK 2";
            // 
            // rACK3ToolStripMenuItem
            // 
            this.rACK3ToolStripMenuItem.Name = "rACK3ToolStripMenuItem";
            this.rACK3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK3ToolStripMenuItem.Text = "RACK 3";
            // 
            // rACK4ToolStripMenuItem
            // 
            this.rACK4ToolStripMenuItem.Name = "rACK4ToolStripMenuItem";
            this.rACK4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK4ToolStripMenuItem.Text = "RACK 4";
            // 
            // rACK5ToolStripMenuItem
            // 
            this.rACK5ToolStripMenuItem.Name = "rACK5ToolStripMenuItem";
            this.rACK5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK5ToolStripMenuItem.Text = "RACK 5";
            // 
            // rACK6ToolStripMenuItem
            // 
            this.rACK6ToolStripMenuItem.Name = "rACK6ToolStripMenuItem";
            this.rACK6ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK6ToolStripMenuItem.Text = "RACK 6";
            // 
            // rACK7ToolStripMenuItem
            // 
            this.rACK7ToolStripMenuItem.Name = "rACK7ToolStripMenuItem";
            this.rACK7ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rACK7ToolStripMenuItem.Text = "RACK7";
            // 
            // TSMI_ExcelLoad
            // 
            this.TSMI_ExcelLoad.Name = "TSMI_ExcelLoad";
            this.TSMI_ExcelLoad.ShowShortcutKeys = false;
            this.TSMI_ExcelLoad.Size = new System.Drawing.Size(95, 20);
            this.TSMI_ExcelLoad.Text = "엑셀 불러오기";
            this.TSMI_ExcelLoad.Click += new System.EventHandler(this.TSMI_ExcelLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 646);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFrm";
            this.Text = "WareHouse";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Add;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Delete;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Update;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Close;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Search;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RACK01;
        private System.Windows.Forms.ToolStripMenuItem rACK2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rACK3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rACK4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rACK5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rACK6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rACK7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ExcelLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

