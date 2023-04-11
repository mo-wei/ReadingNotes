
namespace 单例模式
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制CtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴CtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切CtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具栏ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "这是菜单");
            // 
            // 工具栏ToolStripMenuItem
            // 
            this.工具栏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem});
            this.工具栏ToolStripMenuItem.Name = "工具栏ToolStripMenuItem";
            this.工具栏ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.工具栏ToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.工具栏ToolStripMenuItem.Text = "工具栏(&B)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制CtrlCToolStripMenuItem,
            this.粘贴CtrlCToolStripMenuItem,
            this.剪切CtrlXToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 94);
            // 
            // 复制CtrlCToolStripMenuItem
            // 
            this.复制CtrlCToolStripMenuItem.Name = "复制CtrlCToolStripMenuItem";
            this.复制CtrlCToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.复制CtrlCToolStripMenuItem.Text = "复制    Ctrl+C";
            this.复制CtrlCToolStripMenuItem.Click += new System.EventHandler(this.复制CtrlCToolStripMenuItem_Click);
            // 
            // 粘贴CtrlCToolStripMenuItem
            // 
            this.粘贴CtrlCToolStripMenuItem.Name = "粘贴CtrlCToolStripMenuItem";
            this.粘贴CtrlCToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.粘贴CtrlCToolStripMenuItem.Text = "粘贴    Ctrl+V";
            this.粘贴CtrlCToolStripMenuItem.Click += new System.EventHandler(this.粘贴CtrlCToolStripMenuItem_Click);
            // 
            // 剪切CtrlXToolStripMenuItem
            // 
            this.剪切CtrlXToolStripMenuItem.Name = "剪切CtrlXToolStripMenuItem";
            this.剪切CtrlXToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.剪切CtrlXToolStripMenuItem.Text = "剪切    Ctrl+X";
            this.剪切CtrlXToolStripMenuItem.Click += new System.EventHandler(this.剪切CtrlXToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(0, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 382);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "工具箱";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制CtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴CtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切CtrlXToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}

