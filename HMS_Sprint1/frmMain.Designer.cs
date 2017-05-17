namespace HMS_Sprint1
{
    partial class frmMain
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.butSignin = new System.Windows.Forms.Button();
            this.butSignup = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(82, 509);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 49);
            this.txtPassword.TabIndex = 4;
            // 
            // butSignin
            // 
            this.butSignin.Location = new System.Drawing.Point(82, 575);
            this.butSignin.Name = "butSignin";
            this.butSignin.Size = new System.Drawing.Size(400, 50);
            this.butSignin.TabIndex = 5;
            this.butSignin.Text = "Sign in";
            this.butSignin.UseVisualStyleBackColor = true;
            // 
            // butSignup
            // 
            this.butSignup.Location = new System.Drawing.Point(82, 631);
            this.butSignup.Name = "butSignup";
            this.butSignup.Size = new System.Drawing.Size(400, 50);
            this.butSignup.TabIndex = 6;
            this.butSignup.Text = "Sign Up";
            this.butSignup.UseVisualStyleBackColor = true;
            this.butSignup.Click += new System.EventHandler(this.butSignup_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(82, 436);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(400, 49);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // picLogin
            // 
            this.picLogin.Location = new System.Drawing.Point(82, 136);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(400, 246);
            this.picLogin.TabIndex = 8;
            this.picLogin.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 744);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.butSignup);
            this.Controls.Add(this.butSignin);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmMain";
            this.Text = "Twice Nayeon HMS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button butSignin;
        private System.Windows.Forms.Button butSignup;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picLogin;
    }
}

