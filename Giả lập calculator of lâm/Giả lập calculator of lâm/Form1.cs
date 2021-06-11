using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giả_lập_calculator_of_lâm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool isTypingNumber = false; // Kiểm tra người dùng đang nhập số: "true" hay mới bắt đầu nhập số: "false"
        private void Nhapso(string a) // Tạo mảng và đặt tên là "Nhapso" đầu vào của nó là một chuỗi "so"
        {
            if (isTypingNumber)
                KetQua.Text = KetQua.Text + a;
            else
                KetQua.Text = a;
            isTypingNumber = true;
        }
        private void So0_Click(object sender, EventArgs e)
        {
            Nhapso("0");
        }
        private void So1_Click(object sender, EventArgs e)
        {
            Nhapso("1");
        }
        private void So2_Click(object sender, EventArgs e)
        {
            Nhapso("2");
        }
        private void So3_Click(object sender, EventArgs e)
        {
            Nhapso("3");
        }
        private void So4_Click(object sender, EventArgs e)
        {
            Nhapso("4");
        }
        private void So5_Click(object sender, EventArgs e)
        {
            Nhapso("5");
        }
        private void So6_Click(object sender, EventArgs e)
        {
            Nhapso("6");
        }
        private void So7_Click(object sender, EventArgs e)
        {
            Nhapso("7");
        }
        private void So8_Click(object sender, EventArgs e)
        {
            Nhapso("8");
        }
        private void So9_Click(object sender, EventArgs e)
        {
            Nhapso("9");
        }
        enum PhepToan { Cong, Tru, Nhan, Chia };
        PhepToan pheptoan;
        double nho = 0.0;
        private void NhapPhepToan(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+": pheptoan = PhepToan.Cong;
                    break;
                case "-": pheptoan = PhepToan.Tru;
                    break;
                case "*": pheptoan = PhepToan.Nhan;
                    break;
                case "/": pheptoan = PhepToan.Chia;
                    break;
            }
            nho = double.Parse(KetQua.Text);
            isTypingNumber = false;
        }
        private void TinhKetQua()
        {
            double tam = double.Parse(KetQua.Text);
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.Cong: ketqua = nho + tam;
                    break;
                case PhepToan.Tru: ketqua = nho - tam;
                    break;
                case PhepToan.Nhan: ketqua = nho * tam;
                    break;
                case PhepToan.Chia: ketqua = nho / tam;
                    break;
            }
            KetQua.Text = ketqua.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TinhKetQua();
            isTypingNumber = false;
        }
            
    }
}

