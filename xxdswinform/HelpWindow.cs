namespace xxdswinform
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class HelpWindow : Form
    {
        private IContainer components = null;
        private LinkLabel linkLabel1;
        private TextBox tb_help;

        public HelpWindow()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(HelpWindow));
            this.linkLabel1 = new LinkLabel();
            this.tb_help = new TextBox();
            base.SuspendLayout();
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new Font("宋体", 20f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.linkLabel1.LinkColor = Color.Blue;
            this.linkLabel1.Location = new Point(220, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(0x7c, 0x1b);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "考试要求";
            this.tb_help.AllowDrop = false;
            this.tb_help.Font = new Font("宋体", 13f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.tb_help.Location = new Point(7, 0x35);
            this.tb_help.Multiline = true;
            this.tb_help.Name = "tb_help";
            this.tb_help.ReadOnly = true;
            this.tb_help.Size = new Size(0x25a, 0xd1);
            this.tb_help.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x267, 0x120);
            base.Controls.Add(this.tb_help);
            base.Controls.Add(this.linkLabel1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "HelpWindow";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "帮助文档";
            base.TopMost = true;
            base.Load += new EventHandler(this.帮助_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void 帮助_Load(object sender, EventArgs e)
        {
            this.tb_help.Text = "1、考试方式：闭卷,自带演算纸；\r\n2、考试时间为1小时30分钟；\r\n3、考试开始后，根据提示点击“生成试卷”按钮开始考试；\r\n4、考试过程中系统自动保存试卷和答案；\r\n5、考试过程中出现死机等异常情况，请联系监考老师\r\n6、答题完毕，点击“提交试卷”按钮，否则没有考试成绩；\r\n7、字母和数字之间用“*”连接，如 -2/3-2*a/3, 2/(3*a)；\r\n8、分式表示 -2/3 , 或用小数-0.67；\r\n9、光标在需要录入根式的地方，然后点击“录入根式”按钮。\r\n10、试卷成功提交以后，程序5分钟后自动关闭。";
        }
    }
}

