namespace xxdswinform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using xxdswinform.Tools;
    using xxdswinform.Utils;
    using xxdswinform.WebReference;
    using System.IO;
    using Test;

    public class loginWindow : Form
    {
        private Button btn_login;
        private iniHelper ih = new iniHelper("config.ini");
        private IContainer components = null;
        private bool logining = false;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label1;
        private Label label2;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private Label label3;
        private ComboBox comboBox12;
        private ComboBox comboBox13;
        private ComboBox comboBox14;
        private ComboBox uselessComboBox;
        private ComboBox comboBox11;
        private Panel panel1;
        private Label helper_label;
        private Button button1;
        private TextBox tb_userName;

        public loginWindow()
        {
            this.InitializeComponent();
            Random rd = new Random((Guid.NewGuid().GetHashCode()));
            //选择题
            Dictionary<ComboBox, int> cbcdic = new Dictionary<ComboBox, int>();
            //每道选择题题库题目数量
            cbcdic.Add(comboBox1, Convert.ToInt32(ih.GetValue("ChoiceNum", "ChapterOne")));
            cbcdic.Add(comboBox2, Convert.ToInt32(ih.GetValue("ChoiceNum", "ChapterTwo")));
            cbcdic.Add(comboBox3, Convert.ToInt32(ih.GetValue("ChoiceNum", "ChapterThree")));
            cbcdic.Add(comboBox4, Convert.ToInt32(ih.GetValue("ChoiceNum", "ChapterFour")));
            cbcdic.Add(comboBox5, Convert.ToInt32(ih.GetValue("ChoiceNum", "ChapterFive")));
            //遍历五个选择题组合框
            foreach(ComboBox cmb in cbcdic.Keys)
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                //添加题目
                for(int i = 1; i <= cbcdic[cmb]; ++i)
                    cmb.Items.Add(i);
                //随机选择题目
                
                cmb.SelectedIndex = rd.Next(cbcdic[cmb]);
            }
            //填空题
            List<ComboBox> cbgdic = new List<ComboBox>();
            //hehe
            cbgdic.Add(comboBox6);
            cbgdic.Add(comboBox7);
            cbgdic.Add(comboBox8);
            cbgdic.Add(comboBox9);
            cbgdic.Add(comboBox10);
            //遍历五个填空题题组合框
            foreach (ComboBox cmb in cbgdic)
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                //添加题目
                string[] file_xmls = Directory.GetFiles("GapfillingXML");
                foreach (string xml in file_xmls)
                {
                    string headlessXml = xml.Replace("GapfillingXML\\", "");
                    cmb.Items.Add(headlessXml);
                }
                //随机选择题目
                cmb.SelectedIndex = rd.Next(cmb.Items.Count);
            }
            //计算题
            List<ComboBox> cbldic = new List<ComboBox>();
            //hehe
            cbldic.Add(comboBox11);
            cbldic.Add(comboBox12);
            cbldic.Add(comboBox13);
            cbldic.Add(comboBox14);
            comboBox11.Items.AddRange(new String[] { "c7.xml", "c8.xml", "c9.xml" });
            comboBox12.Items.AddRange(new String[] { "c1.xml", "c2.xml"});
            comboBox13.Items.AddRange(new String[] { "c5.xml", "c3.xml", "c4.xml" });
            comboBox14.Items.AddRange(new String[] { "c6.xml", "c11.xml", "c10.xml" });
            //遍历五个计算题组合框
            foreach (ComboBox cmb in cbldic)
            {
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                //随机选择题目
                cmb.SelectedIndex = rd.Next(cmb.Items.Count);
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!this.logining)
            {
                this.logining = true;
                this.btn_login.Text = "正在登录";
                this.btn_login.ForeColor = Color.Red;
                this.check_User();
            }
        }

        private string messUpBranches()
        {
            List<int> choice_branch = new List<int> { 1, 2, 3, 4 };
            Random rd = new Random();
            string theMess = "";            
            for(int i = 4; i > 0; --i)
            {
                int focus = rd.Next(i);
                theMess += choice_branch[focus].ToString() + ",";
                choice_branch.Remove(choice_branch[focus]);
            }
            return theMess;
        }
        private string generateChoice()
        {
            string result = "";
            result += "ChapterOne_" + comboBox1.Text + "," + messUpBranches() + "|";
            result += "ChapterTwo_" + comboBox2.Text + "," + messUpBranches() + "|";
            result += "ChapterThree_" + comboBox3.Text + "," + messUpBranches() + "|";
            result += "ChapterFour_" + comboBox4.Text + "," + messUpBranches() + "|";
            result += "ChapterFive_" + comboBox5.Text + "," + messUpBranches() + "|";
            return result;
        }

        private string generateGapFilling()
        {
            string result = "";
            result += comboBox6.Text + "|";
            result += comboBox7.Text + "|";
            result += comboBox8.Text + "|";
            result += comboBox9.Text + "|";
            result += comboBox10.Text + "|";
            return result;
        }

        private string generateCal()
        {
            string result = "";
            result += comboBox11.Text + "|";
            result += comboBox12.Text + "|";
            result += comboBox13.Text + "|";
            result += comboBox14.Text + "|";
            return result;
        }

        private void check_User()
        {
            if (this.tb_userName.Text.Length > 0)
            {
                Exception exception;
                try
                {
                    StudentServiceModel model = new StudentServiceModel();//new StudentService().getStudent(this.tb_userName.Text, "~!{#$@cdf3}");
                    if (false && model.version != 4)
                    {
                        MessageBox.Show("版本太低，请从新下载最新的版本");
                        //Application.Exit();
                    }
                    else if (true || model != null)
                    {
                        if (false && model.starttime.ToString() == "0001/1/1 0:00:00")
                        {
                            MessageBox.Show("没有该堂考试信息。。。");
                            //Application.Exit();
                        }
                        else
                        {
                            TimeSpan span = (TimeSpan) (model.currenttime - model.starttime);
                            TimeSpan span2 = (TimeSpan) (model.endtime - model.currenttime);
                            if (false && span2.Minutes < 0)
                            {
                                MessageBox.Show("考试时间已过请联系管理员。。。");
                                //Application.Exit();
                            }
                            else if (false && span.Minutes < 0)
                            {
                                MessageBox.Show("未到考试时间。。。");
                                //Application.Exit();
                            }
                            else
                            {
                                //StudentModel.isReGeneration = model.isregeneration;
                                //StudentModel.studentNumber = model.studentnumber;
                                //StudentModel.mac = model.mac;
                                //StudentModel.chooseNumber = model.choosenumber;
                                //StudentModel.gapfillingNumber = model.gapfillingnumber;
                                //StudentModel.calculationNumber = model.calculationnumber;
                                //StudentModel.endTime = model.endtime;
                                //StudentModel.examCode = model.examcode;
                                //StudentModel.grade = model.grade;
                                //StudentModel.startTime = model.starttime;
                                //StudentModel.status = model.status;
                                //StudentModel.studentName = model.studentname;
                                //StudentModel.studentClass = model.studentclass;

                                StudentModel.isReGeneration = true;
                                StudentModel.studentNumber = "02166407";
                                StudentModel.mac = "FF:FF:FF:FF:FF:FF";
                                StudentModel.chooseNumber = generateChoice();//"ChapterOne_25,3,2,1,4,|ChapterTwo_9,1,4,2,3,|ChapterThree_3,3,1,4,2,|ChapterFour_11,4,2,1,3,|ChapterFive_3,4,1,2,3,|";
                                StudentModel.gapfillingNumber = generateGapFilling();//"g_four_1.xml|g_one_2.xml|g_five_1.xml|g_six_1.xml|g_two_2_6.xml|";
                                StudentModel.calculationNumber = generateCal();//"c8.xml|c1.xml|c3.xml|c10.xml|";
                                StudentModel.endTime = DateTime.Now.AddDays(1);
                                StudentModel.examCode = 2;
                                StudentModel.grade = 0;
                                StudentModel.startTime = DateTime.Now.AddDays(-1);
                                StudentModel.status = 0;
                                StudentModel.studentName = "AMFairy";
                                StudentModel.studentClass = "NEU Mathe";

                                if (true || (StudentModel.mac.Length == 0) || ((StudentModel.mac == new GetMacAddress().getmac()) && (StudentModel.status == 1)))
                                {
                                    string str2;
                                    string str3;
                                    string str = "temp";
                                    SupportTools.DirectoryIsExist("temp");
                                    SupportTools.DirectoryIsExist("temp/generate");
                                    SupportTools.DirectoryIsExist("temp/UA");
                                    if (!StudentModel.isReGeneration)
                                    {
                                        str2 = StudentModel.examCode + "/" + StudentModel.studentNumber;
                                        str3 = "Parameter.zip";
                                        try
                                        {
                                            UploadAndDownload.DownloadFile(str2, str3);
                                            Zip.Extract("./" + str + "/" + str3, "./", 0x400);
                                            UploadAndDownload.DownloadFile(str2, "Answer.zip");
                                            Zip.Extract("./" + str + "/Answer.zip", "./", 0x400);
                                        }
                                        catch (Exception)
                                        {
                                            try
                                            {
                                                UploadAndDownload.DownloadFile(str2, str3);
                                                Zip.Extract("./" + str + "/" + str3, "./", 0x400);
                                                UploadAndDownload.DownloadFile(str2, "AnswerCopy.zip");
                                                Zip.Extract("./" + str + "/AnswerCopy.zip", "./", 0x400);
                                            }
                                            catch (Exception exception2)
                                            {
                                                exception = exception2;
                                                MessageBox.Show("试卷还原的参数下载失败");
                                            }
                                        }
                                    }
                                    List<string> list = new List<string>();
                                    List<string> list2 = new List<string>();
                                    foreach (string str4 in StudentModel.chooseNumber.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
                                    {
                                        string[] strArray2 = str4.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                        list.Add(strArray2[0]);
                                        string[] strArray3 = strArray2[0].Split(new char[] { '_' });
                                        list2.Add(strArray3[0]);
                                    }
                                    try
                                    {
                                        MessageBox.Show("即将开始考试，请耐心等待试卷生成");
                                        for (int j = 0; j < list.Count; j++)
                                        {
                                            str2 = list2[j];
                                            str3 = list[j] + ".zip";
                                            
                                            UploadAndDownload2.DownloadFile(str2, str3);
                                        }
                                    }
                                    catch (Exception exception3)
                                    {
                                        exception = exception3;
                                        MessageBox.Show("从服务器上下载文件失败\r\n" + exception.Message);
                                    }
                                    for (int i = 0; i < list.Count; i++)
                                    {
                                        str2 = list2[i];
                                        Zip.Extract("./temp/" + (list[i] + ".zip"), "./temp", 0x400);
                                    }
                                    new Origination().Show();
                                    base.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("在另外一台机器上登陆了。。。");
                                    //Application.Exit();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入的学号不存在或不在考试时间范围内");
                        //Application.Exit();
                    }
                }
                catch (Exception exception4)
                {
                    exception = exception4;
                    if (exception.Message.Contains("System.Number.ParseInt32"))
                    {
                        MessageBox.Show("未安排你的考试");
                    }
                    else
                    {
                        MessageBox.Show("连接服务器错误。。。" + exception.Message);
                    }
                    //Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("请输入学号");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginWindow));
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.uselessComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helper_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(211, 142);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 40);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登陆";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_userName.Location = new System.Drawing.Point(3, 209);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(10, 38);
            this.tb_userName.TabIndex = 4;
            this.tb_userName.Text = "99999";
            this.tb_userName.Visible = false;
            this.tb_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userName_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 20);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(251, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(88, 20);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(345, 25);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(88, 20);
            this.comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(439, 25);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(88, 20);
            this.comboBox5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "选择题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "填空题";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(63, 63);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(88, 20);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(157, 63);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(88, 20);
            this.comboBox7.TabIndex = 15;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(251, 63);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(88, 20);
            this.comboBox8.TabIndex = 14;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(345, 63);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(88, 20);
            this.comboBox9.TabIndex = 13;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(439, 63);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(88, 20);
            this.comboBox10.TabIndex = 12;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "计算题";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(157, 103);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(88, 20);
            this.comboBox12.TabIndex = 21;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(251, 103);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(88, 20);
            this.comboBox13.TabIndex = 20;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(345, 103);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(88, 20);
            this.comboBox14.TabIndex = 19;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // uselessComboBox
            // 
            this.uselessComboBox.Font = new System.Drawing.Font("宋体", 9F);
            this.uselessComboBox.FormattingEnabled = true;
            this.uselessComboBox.Items.AddRange(new object[] {
            "强迫症凑数组合框",
            "你值得拥有"});
            this.uselessComboBox.Location = new System.Drawing.Point(439, 103);
            this.uselessComboBox.Name = "uselessComboBox";
            this.uselessComboBox.Size = new System.Drawing.Size(88, 20);
            this.uselessComboBox.TabIndex = 18;
            this.uselessComboBox.Text = "强迫症凑数用";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(63, 103);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(88, 20);
            this.comboBox11.TabIndex = 22;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.helper_label);
            this.panel1.Location = new System.Drawing.Point(19, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 124);
            this.panel1.TabIndex = 24;
            // 
            // helper_label
            // 
            this.helper_label.ForeColor = System.Drawing.Color.White;
            this.helper_label.Location = new System.Drawing.Point(7, 6);
            this.helper_label.Name = "helper_label";
            this.helper_label.Size = new System.Drawing.Size(320, 115);
            this.helper_label.TabIndex = 0;
            this.helper_label.Text = "//帮助信息";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Webdings", 8.25F);
            this.button1.Location = new System.Drawing.Point(19, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginWindow
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.uselessComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_userName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "东北大学线性代数考试系统（呵呵）";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupInterface_FormClosing);
            this.Load += new System.EventHandler(this.loginWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loginWindow_Load(object sender, EventArgs e)
        {
            helper_label.Text = "//帮助信息会显示在这里";
            this.Height -= panel1.Height + 15;
            //new HelpWindow().ShowDialog();
        }


        private void StartupInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void tb_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_login_Click(sender, e);
            }
        }

        private void flush_helper(string xmlName)
        {
            helper_label.Text = "";
            helper_label.Text += "所属章节：" + ih.GetValue(xmlName, "Chapter") + "\r\n";
            helper_label.Text += "涉及知识点：" + ih.GetValue(xmlName, "Knowledge") + "\r\n";
            helper_label.Text += "题目示例：" + ih.GetValue(xmlName, "Example") + "\r\n";
            //helper_label.Text += "做过次数：" + ih.GetValue(xmlName, "Count") + "\r\n";
            //helper_label.Text += "正确率："
            //    + (Convert.ToInt32(ih.GetValue(xmlName, "CorrectCount"))
            //    / Convert.ToDouble(ih.GetValue(xmlName, "Count")) * 100).ToString() + "%\r\n";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox6.SelectedItem.ToString());
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox7.SelectedItem.ToString());
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox8.SelectedItem.ToString());
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox9.SelectedItem.ToString());
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox10.SelectedItem.ToString());
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox11.SelectedItem.ToString());
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox12.SelectedItem.ToString());
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox13.SelectedItem.ToString());
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            flush_helper(comboBox14.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "6")
            {
                button1.Text = "5";
                this.Height += panel1.Height + 15;
            }
            else if(button1.Text == "5")
            {
                button1.Text = "6";
                this.Height -= panel1.Height + 15;
            }
        }


    }
}

