
namespace Calc_Phap
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
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDoiDau = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnChamPhay = new System.Windows.Forms.Button();
            this.btnPhanTram = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.GreenYellow;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 252);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 50);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.GreenYellow;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(13, 197);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.GreenYellow;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(69, 197);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnDoiDau
            // 
            this.btnDoiDau.BackColor = System.Drawing.Color.HotPink;
            this.btnDoiDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiDau.Location = new System.Drawing.Point(125, 253);
            this.btnDoiDau.Name = "btnDoiDau";
            this.btnDoiDau.Size = new System.Drawing.Size(50, 50);
            this.btnDoiDau.TabIndex = 3;
            this.btnDoiDau.Text = "+/-";
            this.btnDoiDau.UseVisualStyleBackColor = false;
            this.btnDoiDau.Click += new System.EventHandler(this.Operator_click);
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.HotPink;
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(181, 253);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 50);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.GreenYellow;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(124, 196);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.HotPink;
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.Location = new System.Drawing.Point(180, 196);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(50, 50);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.Operator_click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.HotPink;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(180, 140);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(50, 50);
            this.btnNhan.TabIndex = 10;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.GreenYellow;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(124, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.GreenYellow;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(68, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.GreenYellow;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 140);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.Color.HotPink;
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.Location = new System.Drawing.Point(180, 84);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(50, 50);
            this.btnChia.TabIndex = 14;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.GreenYellow;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(124, 84);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.GreenYellow;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(68, 84);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.GreenYellow;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 84);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Khaki;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(236, 84);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 15;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Khaki;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(236, 140);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBang
            // 
            this.btnBang.BackColor = System.Drawing.Color.Orange;
            this.btnBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(236, 252);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(50, 50);
            this.btnBang.TabIndex = 17;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = false;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 39);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(274, 39);
            this.txtResult.TabIndex = 18;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChamPhay
            // 
            this.btnChamPhay.BackColor = System.Drawing.Color.HotPink;
            this.btnChamPhay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamPhay.Location = new System.Drawing.Point(69, 252);
            this.btnChamPhay.Name = "btnChamPhay";
            this.btnChamPhay.Size = new System.Drawing.Size(50, 50);
            this.btnChamPhay.TabIndex = 20;
            this.btnChamPhay.Text = ".";
            this.btnChamPhay.UseVisualStyleBackColor = false;
            this.btnChamPhay.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnPhanTram
            // 
            this.btnPhanTram.BackColor = System.Drawing.Color.Thistle;
            this.btnPhanTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanTram.Location = new System.Drawing.Point(236, 196);
            this.btnPhanTram.Name = "btnPhanTram";
            this.btnPhanTram.Size = new System.Drawing.Size(50, 50);
            this.btnPhanTram.TabIndex = 21;
            this.btnPhanTram.Text = "%";
            this.btnPhanTram.UseVisualStyleBackColor = false;
            this.btnPhanTram.Click += new System.EventHandler(this.Operator_click);
            // 
            // lblShow
            // 
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.ForeColor = System.Drawing.Color.Black;
            this.lblShow.Location = new System.Drawing.Point(12, 9);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(274, 27);
            this.lblShow.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 309);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnPhanTram);
            this.Controls.Add(this.btnChamPhay);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnDoiDau);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính tay";
            this.Click += new System.EventHandler(this.Operator_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDoiDau;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnChamPhay;
        private System.Windows.Forms.Button btnPhanTram;
        private System.Windows.Forms.Label lblShow;
    }
}

