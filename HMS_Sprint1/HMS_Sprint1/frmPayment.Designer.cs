namespace HMS_Sprint1
{
    partial class frmPayment
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
            this.butTransfer = new System.Windows.Forms.Button();
            this.butCard = new System.Windows.Forms.Button();
            this.butCoupon = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butTransfer
            // 
            this.butTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.butTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTransfer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butTransfer.Location = new System.Drawing.Point(52, 35);
            this.butTransfer.Name = "butTransfer";
            this.butTransfer.Size = new System.Drawing.Size(200, 80);
            this.butTransfer.TabIndex = 1;
            this.butTransfer.Text = "계좌이체";
            this.butTransfer.UseVisualStyleBackColor = false;
            this.butTransfer.Click += new System.EventHandler(this.butTransfer_Click);
            // 
            // butCard
            // 
            this.butCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.butCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCard.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butCard.Location = new System.Drawing.Point(52, 134);
            this.butCard.Name = "butCard";
            this.butCard.Size = new System.Drawing.Size(200, 80);
            this.butCard.TabIndex = 2;
            this.butCard.Text = "카드";
            this.butCard.UseVisualStyleBackColor = false;
            this.butCard.Click += new System.EventHandler(this.butCard_Click);
            // 
            // butCoupon
            // 
            this.butCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.butCoupon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCoupon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCoupon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCoupon.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butCoupon.Location = new System.Drawing.Point(52, 238);
            this.butCoupon.Name = "butCoupon";
            this.butCoupon.Size = new System.Drawing.Size(200, 80);
            this.butCoupon.TabIndex = 3;
            this.butCoupon.Text = "쿠폰";
            this.butCoupon.UseVisualStyleBackColor = false;
            this.butCoupon.Click += new System.EventHandler(this.butCoupon_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butCancel.Location = new System.Drawing.Point(52, 341);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(200, 80);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "결제취소";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 454);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butCoupon);
            this.Controls.Add(this.butCard);
            this.Controls.Add(this.butTransfer);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPayment";
            this.Text = "결제하기";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butTransfer;
        private System.Windows.Forms.Button butCard;
        private System.Windows.Forms.Button butCoupon;
        private System.Windows.Forms.Button butCancel;
    }
}