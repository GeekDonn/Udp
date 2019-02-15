namespace Udp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ip1 = new System.Windows.Forms.ComboBox();
            this.port1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.port2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isCmd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 373);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 106);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 355);
            this.textBox2.TabIndex = 2;
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(548, 28);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(126, 20);
            this.ip1.TabIndex = 3;
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(548, 65);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(126, 21);
            this.port1.TabIndex = 4;
            this.port1.Visible = false;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(548, 102);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(126, 21);
            this.ip2.TabIndex = 5;
            this.ip2.Visible = false;
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(548, 144);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(126, 21);
            this.port2.TabIndex = 6;
            this.port2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "未连接";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ip:";
            // 
            // isCmd
            // 
            this.isCmd.AutoSize = true;
            this.isCmd.Location = new System.Drawing.Point(569, 297);
            this.isCmd.Name = "isCmd";
            this.isCmd.Size = new System.Drawing.Size(66, 16);
            this.isCmd.TabIndex = 10;
            this.isCmd.Text = "cmd模式";
            this.isCmd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 491);
            this.Controls.Add(this.isCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox ip1;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isCmd;
    }
}

