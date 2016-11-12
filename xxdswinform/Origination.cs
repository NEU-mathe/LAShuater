namespace xxdswinform
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    public class Origination : Form
    {
        private IContainer components = null;
        private System.Windows.Forms.Timer Counter;
        private bool flag = false;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;

        public Origination()
        {
            this.InitializeComponent();
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 10;
            this.progressBar1.MarqueeAnimationSpeed = 100;
            this.Counter.Start();
            new Thread(new ThreadStart(this.openMainWindow)) { IsBackground = true }.Start();
        }

        private void Counter_Tick(object sender, EventArgs e)
        {
            if (this.flag)
            {
                base.Hide();
                this.Counter.Stop();
            }
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
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Origination));
            this.label1 = new Label();
            this.label2 = new Label();
            this.Counter = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new ProgressBar();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("幼圆", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label1.Location = new Point(3, 0x24);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x16a, 0x15);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用东北大学线性代数考试系统";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("宋体", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label2.Location = new Point(0x57, 0x6a);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xb2, 0x15);
            this.label2.TabIndex = 0;
            this.label2.Text = "连接服务器中……";
            this.Counter.Interval = 0x3e8;
            this.Counter.Tick += new EventHandler(this.Counter_Tick);
            this.progressBar1.Location = new Point(0x2e, 180);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(0x10c, 0x12);
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x16e, 0x105);
            base.Controls.Add(this.progressBar1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "Origination";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Origination";
            base.Load += new EventHandler(this.Origination_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void openMainWindow()
        {
            Form1 form = new Form1();
            this.flag = true;
            this.ThreadSafeWay(null, form);
        }

        private void Origination_Load(object sender, EventArgs e)
        {
        }

        public DialogResult ThreadSafeWay(object msg, object form)
        {
            FormDelegate method = new FormDelegate(this.ThreadSafeWay);
            if (this.InvokeRequired)
            {
                return (DialogResult)this.Invoke(method, new object[] { msg, form });
            }
            return (form as Form).ShowDialog(this);
        }

        private delegate DialogResult FormDelegate(object msg, object form);
    }
}

