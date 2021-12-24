
namespace wfemail.form.control
{
    partial class MailList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.ToolStripLabel();
            this.listMail = new System.Windows.Forms.ListView();
            this.colSub = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 319);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(471, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.Text = "邮件列表";
            // 
            // listMail
            // 
            this.listMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSub,
            this.colDate});
            this.listMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMail.HideSelection = false;
            this.listMail.Location = new System.Drawing.Point(0, 0);
            this.listMail.Margin = new System.Windows.Forms.Padding(0);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(471, 319);
            this.listMail.TabIndex = 2;
            this.listMail.UseCompatibleStateImageBehavior = false;
            this.listMail.View = System.Windows.Forms.View.Details;
            // 
            // colSub
            // 
            this.colSub.Text = "主题";
            this.colSub.Width = 240;
            // 
            // colDate
            // 
            this.colDate.Text = "日期";
            this.colDate.Width = 144;
            // 
            // MailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMail);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MailList";
            this.Size = new System.Drawing.Size(471, 344);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView listMail;
        private System.Windows.Forms.ColumnHeader colSub;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ToolStripLabel label1;
    }
}
