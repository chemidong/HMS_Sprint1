using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Sprint1
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
        }

        private void butTransfer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("계좌 이체 완료되었습니다.","나연 호텔");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카드 결제 완료되었습니다.", "나연 호텔");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butCoupon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("쿠폰 기능은 아직 구현되지 않았습니다.", "나연 호텔");
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
