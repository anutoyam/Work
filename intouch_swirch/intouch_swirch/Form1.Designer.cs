namespace intouch_swirch
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SFHM = new System.Windows.Forms.Button();
            this.btn_RM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // btn_SFHM
            // 
            this.btn_SFHM.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SFHM.Location = new System.Drawing.Point(274, 12);
            this.btn_SFHM.Name = "btn_SFHM";
            this.btn_SFHM.Size = new System.Drawing.Size(256, 217);
            this.btn_SFHM.TabIndex = 4;
            this.btn_SFHM.Text = "SFHM";
            this.btn_SFHM.UseVisualStyleBackColor = true;
            this.btn_SFHM.Click += new System.EventHandler(this.btn_SFHM_Click);
            // 
            // btn_RM
            // 
            this.btn_RM.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RM.Location = new System.Drawing.Point(12, 12);
            this.btn_RM.Name = "btn_RM";
            this.btn_RM.Size = new System.Drawing.Size(256, 217);
            this.btn_RM.TabIndex = 5;
            this.btn_RM.Text = "RM";
            this.btn_RM.UseVisualStyleBackColor = true;
            this.btn_RM.Click += new System.EventHandler(this.btn_RM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "cycle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_RM);
            this.Controls.Add(this.btn_SFHM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Intouch_Switch";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SFHM;
        private System.Windows.Forms.Button btn_RM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

