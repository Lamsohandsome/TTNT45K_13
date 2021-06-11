namespace Giả_lập_calculator_of_lâm
{
    partial class Form1
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
            this.KetQua = new System.Windows.Forms.Label();
            this.DauTru = new System.Windows.Forms.Button();
            this.DauPhay = new System.Windows.Forms.Button();
            this.So3 = new System.Windows.Forms.Button();
            this.So6 = new System.Windows.Forms.Button();
            this.DauCong = new System.Windows.Forms.Button();
            this.DauNhan = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.So1 = new System.Windows.Forms.Button();
            this.So4 = new System.Windows.Forms.Button();
            this.So0 = new System.Windows.Forms.Button();
            this.So2 = new System.Windows.Forms.Button();
            this.So5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DauChia = new System.Windows.Forms.Button();
            this.So9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.So8 = new System.Windows.Forms.Button();
            this.So7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KetQua
            // 
            this.KetQua.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KetQua.Location = new System.Drawing.Point(375, 9);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(886, 99);
            this.KetQua.TabIndex = 1;
            this.KetQua.Text = "0";
            this.KetQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DauTru
            // 
            this.DauTru.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DauTru.Location = new System.Drawing.Point(1152, 345);
            this.DauTru.Name = "DauTru";
            this.DauTru.Size = new System.Drawing.Size(105, 79);
            this.DauTru.TabIndex = 2;
            this.DauTru.Text = "-";
            this.DauTru.UseVisualStyleBackColor = true;
            this.DauTru.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // DauPhay
            // 
            this.DauPhay.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DauPhay.Location = new System.Drawing.Point(894, 443);
            this.DauPhay.Name = "DauPhay";
            this.DauPhay.Size = new System.Drawing.Size(105, 79);
            this.DauPhay.TabIndex = 6;
            this.DauPhay.Text = ".";
            this.DauPhay.UseVisualStyleBackColor = true;
            // 
            // So3
            // 
            this.So3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So3.Location = new System.Drawing.Point(894, 344);
            this.So3.Name = "So3";
            this.So3.Size = new System.Drawing.Size(105, 79);
            this.So3.TabIndex = 5;
            this.So3.Text = "3";
            this.So3.UseVisualStyleBackColor = true;
            this.So3.Click += new System.EventHandler(this.So3_Click);
            // 
            // So6
            // 
            this.So6.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So6.Location = new System.Drawing.Point(894, 239);
            this.So6.Name = "So6";
            this.So6.Size = new System.Drawing.Size(105, 79);
            this.So6.TabIndex = 4;
            this.So6.Text = "6";
            this.So6.UseVisualStyleBackColor = true;
            this.So6.Click += new System.EventHandler(this.So6_Click);
            // 
            // DauCong
            // 
            this.DauCong.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DauCong.Location = new System.Drawing.Point(1023, 345);
            this.DauCong.Name = "DauCong";
            this.DauCong.Size = new System.Drawing.Size(105, 79);
            this.DauCong.TabIndex = 8;
            this.DauCong.Text = "+";
            this.DauCong.UseVisualStyleBackColor = true;
            this.DauCong.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // DauNhan
            // 
            this.DauNhan.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DauNhan.Location = new System.Drawing.Point(1023, 239);
            this.DauNhan.Name = "DauNhan";
            this.DauNhan.Size = new System.Drawing.Size(105, 79);
            this.DauNhan.TabIndex = 7;
            this.DauNhan.Text = "*";
            this.DauNhan.UseVisualStyleBackColor = true;
            this.DauNhan.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(641, 444);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 79);
            this.button10.TabIndex = 18;
            this.button10.Text = "+/-";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // So1
            // 
            this.So1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So1.Location = new System.Drawing.Point(641, 345);
            this.So1.Name = "So1";
            this.So1.Size = new System.Drawing.Size(105, 79);
            this.So1.TabIndex = 17;
            this.So1.Text = "1";
            this.So1.UseVisualStyleBackColor = true;
            this.So1.Click += new System.EventHandler(this.So1_Click);
            // 
            // So4
            // 
            this.So4.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So4.Location = new System.Drawing.Point(641, 239);
            this.So4.Name = "So4";
            this.So4.Size = new System.Drawing.Size(105, 79);
            this.So4.TabIndex = 16;
            this.So4.Text = "4";
            this.So4.UseVisualStyleBackColor = true;
            this.So4.Click += new System.EventHandler(this.So4_Click);
            // 
            // So0
            // 
            this.So0.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So0.Location = new System.Drawing.Point(770, 444);
            this.So0.Name = "So0";
            this.So0.Size = new System.Drawing.Size(105, 79);
            this.So0.TabIndex = 12;
            this.So0.Text = "0";
            this.So0.UseVisualStyleBackColor = true;
            this.So0.Click += new System.EventHandler(this.So0_Click);
            // 
            // So2
            // 
            this.So2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So2.Location = new System.Drawing.Point(770, 345);
            this.So2.Name = "So2";
            this.So2.Size = new System.Drawing.Size(105, 79);
            this.So2.TabIndex = 11;
            this.So2.Text = "2";
            this.So2.UseVisualStyleBackColor = true;
            this.So2.Click += new System.EventHandler(this.So2_Click);
            // 
            // So5
            // 
            this.So5.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So5.Location = new System.Drawing.Point(770, 239);
            this.So5.Name = "So5";
            this.So5.Size = new System.Drawing.Size(105, 79);
            this.So5.TabIndex = 10;
            this.So5.Text = "5";
            this.So5.UseVisualStyleBackColor = true;
            this.So5.Click += new System.EventHandler(this.So5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1023, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DauChia
            // 
            this.DauChia.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DauChia.Location = new System.Drawing.Point(1152, 239);
            this.DauChia.Name = "DauChia";
            this.DauChia.Size = new System.Drawing.Size(105, 79);
            this.DauChia.TabIndex = 0;
            this.DauChia.Text = "/";
            this.DauChia.UseVisualStyleBackColor = true;
            this.DauChia.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // So9
            // 
            this.So9.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So9.Location = new System.Drawing.Point(894, 135);
            this.So9.Name = "So9";
            this.So9.Size = new System.Drawing.Size(105, 79);
            this.So9.TabIndex = 20;
            this.So9.Text = "9";
            this.So9.UseVisualStyleBackColor = true;
            this.So9.Click += new System.EventHandler(this.So9_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(1023, 135);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(234, 79);
            this.button15.TabIndex = 21;
            this.button15.Text = "Del";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // So8
            // 
            this.So8.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So8.Location = new System.Drawing.Point(770, 135);
            this.So8.Name = "So8";
            this.So8.Size = new System.Drawing.Size(105, 79);
            this.So8.TabIndex = 22;
            this.So8.Text = "8";
            this.So8.UseVisualStyleBackColor = true;
            this.So8.Click += new System.EventHandler(this.So8_Click);
            // 
            // So7
            // 
            this.So7.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So7.Location = new System.Drawing.Point(641, 135);
            this.So7.Name = "So7";
            this.So7.Size = new System.Drawing.Size(105, 79);
            this.So7.TabIndex = 23;
            this.So7.Text = "7";
            this.So7.UseVisualStyleBackColor = true;
            this.So7.Click += new System.EventHandler(this.So7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 540);
            this.Controls.Add(this.So7);
            this.Controls.Add(this.So8);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.So9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.So1);
            this.Controls.Add(this.So4);
            this.Controls.Add(this.So0);
            this.Controls.Add(this.So2);
            this.Controls.Add(this.So5);
            this.Controls.Add(this.DauCong);
            this.Controls.Add(this.DauNhan);
            this.Controls.Add(this.DauPhay);
            this.Controls.Add(this.So3);
            this.Controls.Add(this.So6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DauTru);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.DauChia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.Button DauTru;
        private System.Windows.Forms.Button DauPhay;
        private System.Windows.Forms.Button So3;
        private System.Windows.Forms.Button So6;
        private System.Windows.Forms.Button DauCong;
        private System.Windows.Forms.Button DauNhan;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button So1;
        private System.Windows.Forms.Button So4;
        private System.Windows.Forms.Button So0;
        private System.Windows.Forms.Button So2;
        private System.Windows.Forms.Button So5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DauChia;
        private System.Windows.Forms.Button So9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button So8;
        private System.Windows.Forms.Button So7;
    }
}

