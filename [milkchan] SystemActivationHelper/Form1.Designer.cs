namespace _milkchan__SystemActivationHelper
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
            this.pro = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.education = new System.Windows.Forms.Button();
            this.enterprise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pro
            // 
            this.pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pro.Location = new System.Drawing.Point(191, 326);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(173, 27);
            this.pro.TabIndex = 0;
            this.pro.Text = "11/10 Pro 인증하기";
            this.pro.UseVisualStyleBackColor = true;
            this.pro.Click += new System.EventHandler(this.pro_Click);
            // 
            // home
            // 
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Location = new System.Drawing.Point(12, 326);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(173, 27);
            this.home.TabIndex = 1;
            this.home.Text = "11/10 Home 인증하기";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // education
            // 
            this.education.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.education.Location = new System.Drawing.Point(370, 326);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(184, 27);
            this.education.TabIndex = 2;
            this.education.Text = "11/10 Education 인증하기";
            this.education.UseVisualStyleBackColor = true;
            this.education.Click += new System.EventHandler(this.education_Click);
            // 
            // enterprise
            // 
            this.enterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterprise.Location = new System.Drawing.Point(560, 326);
            this.enterprise.Name = "enterprise";
            this.enterprise.Size = new System.Drawing.Size(185, 27);
            this.enterprise.TabIndex = 3;
            this.enterprise.Text = "11/10 Enterprise 인증하기";
            this.enterprise.UseVisualStyleBackColor = true;
            this.enterprise.Click += new System.EventHandler(this.enterprise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Windows 10/11 System Activations Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(633, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Release Channel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "⚠️ 이 인증 방식은 일부 윈도우 버전에서 오류(0xC004F069)가 발생할 수 있습니다.\r\n예: 설치되어있는 윈도우 버전과 정품인증 키의 불일" +
    "치";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(757, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterprise);
            this.Controls.Add(this.education);
            this.Controls.Add(this.home);
            this.Controls.Add(this.pro);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SystemActivationHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pro;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button education;
        private System.Windows.Forms.Button enterprise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

