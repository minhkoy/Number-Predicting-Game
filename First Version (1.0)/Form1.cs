using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPredicting
{
    public partial class PredictingNumber : Form
    {
        int X;
        string player1Name, player2Name;
        int askAttempt1, askAttempt2;
        int ansAttempt1 = 3, ansAttempt2 = 3;
        public PredictingNumber()
        {
            InitializeComponent();
        }

        private void PredictingNumber_Load(object sender, EventArgs e)
        {
            ans1.Text = ansAttempt1.ToString();
            ans2.Text = ansAttempt2.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {
            player1Name = name1.Text;
        }

        private void finalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void name2_TextChanged(object sender, EventArgs e)
        {
            player2Name = name2.Text;
        }

        private void ques1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Player1Ask_Click(object sender, EventArgs e)
        {
            if (askAttempt1 == 0)
            {
                MessageBox.Show("Bạn đã hết lượt hỏi! Đoán thôi nào.");
                return;
            }
            int lower, upper;
            int.TryParse(lowerNum.Text, out lower);
            int.TryParse(upperNum.Text, out upper);
            if (lower <= X && X <= upper)
            {
                MessageBox.Show("Đúng rồi. Số đó nằm trong khoảng từ " + lower + " đến " + upper);
            }
            else
            {
                MessageBox.Show("Sai. Số đó không nằm trong khoảng này.");
            }
            lowerNum.Text = "";
            upperNum.Text = "";
            askAttempt1--; ques1.Text = askAttempt1.ToString();
        }

        private void Player2Ask_Click(object sender, EventArgs e)
        {
            if (askAttempt2 == 0)
            {
                MessageBox.Show("Bạn đã hết lượt hỏi! Đoán thôi nào.");
                return;
            }
            int lower, upper;
            int.TryParse(lowerNum.Text, out lower);
            int.TryParse(upperNum.Text, out upper);
            if (lower <= X && X <= upper)
            {
                MessageBox.Show("Đúng rồi. Số đó nằm trong khoảng từ " + lower + " đến " + upper);
            }
            else
            {
                MessageBox.Show("Sai. Số đó không nằm trong khoảng này.");
            }
            lowerNum.Text = "";
            upperNum.Text = "";
            askAttempt2--; ques2.Text = askAttempt2.ToString();
        }

        private void Player1Ans_Click(object sender, EventArgs e)
        {
            int answer;
            int.TryParse(predictNum.Text, out answer);
            if (ansAttempt1 == 0)
            {
                MessageBox.Show("Bạn thua rồi! Chịu khó chờ game sau vậy ha.");
                return;
            }
            if (answer == X)
            {
                MessageBox.Show("Chúc mừng " + player1Name + ". Đó là câu trả lời chính xác!");
                finalNumber.Text = X.ToString();
                PlayAgainButton.Enabled = true;
                return;
            }
            MessageBox.Show("Rất tiếc, bạn đã đoán sai. Hãy thử lại nhé :>");
            ansAttempt1--;
            ans1.Text = ansAttempt1.ToString();
        }

        private void Player2Ans_Click(object sender, EventArgs e)
        {
            int answer;
            int.TryParse(predictNum.Text, out answer);
            if (ansAttempt2 == 0)
            {
                MessageBox.Show("Bạn thua rồi! Chịu khó chờ game sau vậy ha.");
                return;
            }
            if (answer == X)
            {
                MessageBox.Show("Chúc mừng " + player2Name + ". Đó là câu trả lời chính xác!");
                finalNumber.Text = X.ToString();
                PlayAgainButton.Enabled = true;
                return;
            }
            MessageBox.Show("Rất tiếc, bạn đã đoán sai. Hãy thử lại nhé :>");
            ansAttempt2--;
            ans2.Text = ansAttempt2.ToString();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void askAttempt_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(askAttempt.Text, out askAttempt1);
            if (!check)
            {
                MessageBox.Show("Không hợp lệ! Xin vui lòng nhập lại.");
            }
            else if (askAttempt1 <= 0)
            {
                MessageBox.Show("Hãy nhập một số lớn hơn 0!");
            }
            else
            {
                MessageBox.Show("Lưu thành công! Có " + askAttempt1 + " câu hỏi cho mỗi người.");
                askAttempt2 = askAttempt1;
                ques1.Text = askAttempt1.ToString();
                ques2.Text = askAttempt1.ToString();
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            bool checkParse = int.TryParse(finalNumber.Text, out X);
            if (!checkParse) MessageBox.Show("Dữ liệu nhập vào không hợp lệ!");
            else if (X <= 0 || X > 100) MessageBox.Show("Hãy nhập số trong phạm vi 1-100!");
            else
            {
                finalNumber.Text = "";
                MessageBox.Show("Lưu thành công!");
                finalNumber.Enabled = false;
            }
        }
    }
}
