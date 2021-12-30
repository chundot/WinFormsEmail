
namespace wfemail.form.control
{
    partial class AccountForm
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textAccount = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.textImap = new System.Windows.Forms.TextBox();
            this.textSmtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numIPort = new System.Windows.Forms.NumericUpDown();
            this.numSPort = new System.Windows.Forms.NumericUpDown();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSPort)).BeginInit();
            this.SuspendLayout();
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(148, 78);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(132, 23);
            this.textAccount.TabIndex = 0;
            this.textAccount.Leave += new System.EventHandler(this.textAccount_Leave);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(148, 107);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(132, 23);
            this.textPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "邮箱账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Checked = true;
            this.checkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAuto.Location = new System.Drawing.Point(173, 161);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(75, 21);
            this.checkBoxAuto.TabIndex = 4;
            this.checkBoxAuto.Text = "自动配置";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // textImap
            // 
            this.textImap.Enabled = false;
            this.textImap.Location = new System.Drawing.Point(116, 228);
            this.textImap.Name = "textImap";
            this.textImap.Size = new System.Drawing.Size(100, 23);
            this.textImap.TabIndex = 5;
            // 
            // textSmtp
            // 
            this.textSmtp.Enabled = false;
            this.textSmtp.Location = new System.Drawing.Point(116, 199);
            this.textSmtp.Name = "textSmtp";
            this.textSmtp.Size = new System.Drawing.Size(100, 23);
            this.textSmtp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "IMAP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "端口";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "端口";
            // 
            // numIPort
            // 
            this.numIPort.Enabled = false;
            this.numIPort.Location = new System.Drawing.Point(271, 229);
            this.numIPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numIPort.Name = "numIPort";
            this.numIPort.Size = new System.Drawing.Size(58, 23);
            this.numIPort.TabIndex = 13;
            // 
            // numSPort
            // 
            this.numSPort.Enabled = false;
            this.numSPort.Location = new System.Drawing.Point(271, 200);
            this.numSPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSPort.Name = "numSPort";
            this.numSPort.Size = new System.Drawing.Size(58, 23);
            this.numSPort.TabIndex = 14;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(141, 308);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.numSPort);
            this.Controls.Add(this.numIPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSmtp);
            this.Controls.Add(this.textImap);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textAccount);
            this.Name = "AccountForm";
            this.Size = new System.Drawing.Size(410, 363);
            ((System.ComponentModel.ISupportInitialize)(this.numIPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.TextBox textImap;
        private System.Windows.Forms.TextBox textSmtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numIPort;
        private System.Windows.Forms.NumericUpDown numSPort;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSubmit;
    }
}
