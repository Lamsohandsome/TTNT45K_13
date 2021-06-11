using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giả_lập_Calculator
{
    public enum Opration
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide,
    }
    public partial class btn0 : Form
    {
        private double result;
        private double currentNum;
        private bool secondNum;
        private bool flag;
        private Opration Op;
        public btn0()
        {
            InitializeComponent();
            result = 0;
            flag = true;
            this.secondNum = false;
            Op = Opration.None;
        }
        private void btn0_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           if(this.IbIKetQua.Text == "0" )
           {
               return;
           }
            if (this.flag==true)
            {
               this.IbIKetQua.Text += "0";
            }
            else
            {
                this.IbIKetQua.Text = "0";
            }
            this.flag = true;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.IbIKetQua.Text == "0")
            {
                this.IbIKetQua.Text = "";
            }
            if (this.flag == true)
            {
                this.IbIKetQua.Text += "1";
            }
            else
            {
                this.IbIKetQua.Text = "1";
            }
            this.flag = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.result = this.result + Convert.ToDouble(this.IbIKetQua.Text);
            this.flag = false;
            this.IbIKetQua.Text = String.Format("{0}", this.result);
            this.secondNum = true;
            Op = Opration.Add;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.IbIKetQua.Text == "0")
            {
                this.IbIKetQua.Text = "";
            }
            if (this.flag == true)
            {
                this.IbIKetQua.Text += "2";
            }
            else
            {
                this.IbIKetQua.Text = "2";
            }
            this.flag = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.IbIKetQua.Text == "0")
            {
                this.IbIKetQua.Text = "";
            }
            if (this.flag == true)
            {
                this.IbIKetQua.Text += "3";
            }
            else
            {
                this.IbIKetQua.Text = "3";
            }
            this.flag = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (secondNum == false)
            {
                this.result = Convert.ToDouble(this.IbIKetQua.Text);
            }
            else
            {
                this.result = this.result - Convert.ToDouble(this.IbIKetQua.Text);
            }
            this.flag = false;
            this.IbIKetQua.Text = String.Format("{0}", this.result);
            this.secondNum = true;
            Op = Opration.Subtract;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (this.Op == Opration.Add)
            {
                this.result = this.result + Convert.ToDouble(this.IbIKetQua.Text);
            }
            else if(this.Op == Opration.Subtract)
            {
                this.result = this.result - Convert.ToDouble(this.IbIKetQua.Text);
            }
            this.IbIKetQua.Text = String.Format("{0}", this.result);
            this.flag = false;
            this.secondNum = false;
            this.result = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (this.Op == Opration.Multiply)
            {
                this.result = this.result * Convert.ToDouble(this.IbIKetQua.Text);
            }
            else if (this.Op == Opration.Subtract)
            {
                this.result = this.result - Convert.ToDouble(this.IbIKetQua.Text);
            }
            this.IbIKetQua.Text = String.Format("{0}", this.result);
            this.flag = false;
            this.secondNum = false;
            this.result = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (this.Op == Opration.Divide)
            {
                this.result = this.result / Convert.ToDouble(this.IbIKetQua.Text);
            }
            else if (this.Op == Opration.Subtract)
            {
                this.result = this.result - Convert.ToDouble(this.IbIKetQua.Text);
            }
            this.IbIKetQua.Text = String.Format("{0}", this.result);
            this.flag = false;
            this.secondNum = false;
            this.result = 0;
        }
    }
}
