namespace Buoi6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.txtdiemsv = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "vitri/tongso";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(438, 178);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(221, 20);
            this.txtmasv.TabIndex = 5;
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(438, 215);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(221, 20);
            this.txttensv.TabIndex = 6;
            // 
            // txtdiemsv
            // 
            this.txtdiemsv.Location = new System.Drawing.Point(446, 261);
            this.txtdiemsv.Name = "txtdiemsv";
            this.txtdiemsv.Size = new System.Drawing.Size(221, 20);
            this.txtdiemsv.TabIndex = 7;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(446, 313);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(221, 20);
            this.txtmakhoa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Điểm SV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã Khoa";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(366, 367);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(59, 61);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(481, 367);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(59, 61);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(600, 367);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 61);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.txtdiemsv);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txtdiemsv;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}

