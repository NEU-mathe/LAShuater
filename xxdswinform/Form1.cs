namespace xxdswinform
{
    using Genetibase.MathX;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Timers;
    using System.Windows.Forms;
    using System.Xml;
    using System.Threading;
    using xxdswinform.CalculationDomain;
    using xxdswinform.GapfillingDomain;
    using xxdswinform.Tools;
    using xxdswinform.Utils;
    using xxdswinform.WebReference;
    using xxdswinform.WebReference1;
    using 计算题.CalculationDomain;

    public class Form1 : Form
    {
        public List<int> AnwserNumber;
        private Button btn_Generate_Test;
        private Button btn_help;
        private Button btn_isSubmit;
        private Button btn_sqrt;
        private Button btn_Submit;
        public Dictionary<string, List<bool>> calculationAnswerResults;
        public List<string> calculationString;
        public List<bool> ChoiceAnwser;
        public List<string> ChoicegString;
        private ComboBox comboBoxC10_1_1;
        private ComboBox comboBoxC10_2_1;
        private ComboBox comboBoxC10_2_2;
        private ComboBox comboBoxC10_2_3;
        private ComboBox comboBoxC10_3_1;
        private ComboBox comboBoxC11_1_1;
        private ComboBox comboBoxC11_1_2;
        private ComboBox comboBoxC11_2_1;
        private ComboBox comboBoxC11_2_2;
        private ComboBox comboBoxC11_3_1;
        private ComboBox comboBoxC11_3_2;
        private IContainer components;
        private NuGenEQML controlC1;
        private NuGenEQML controlC10;
        private NuGenEQML controlC10_2_1;
        private NuGenEQML controlC10_2_2;
        private NuGenEQML controlC10_2_3;
        private NuGenEQML controlC10_2_4;
        private NuGenEQML controlC10_3_1;
        private NuGenEQML controlC10_3_2;
        private NuGenEQML controlC10_3_3;
        private NuGenEQML controlC10_3_4;
        private NuGenEQML controlC11;
        private NuGenEQML controlC11_2_1;
        private NuGenEQML controlC11_2_2;
        private NuGenEQML controlC11_2_3;
        private NuGenEQML controlC11_3_1;
        private NuGenEQML controlC11_3_2;
        private NuGenEQML controlC11_3_3;
        private NuGenEQML controlC2;
        private NuGenEQML controlC2_3_1;
        private NuGenEQML controlC2_3_10;
        private NuGenEQML controlC2_3_11;
        private NuGenEQML controlC2_3_12;
        private NuGenEQML controlC2_3_2;
        private NuGenEQML controlC2_3_3;
        private NuGenEQML controlC2_3_4;
        private NuGenEQML controlC2_3_5;
        private NuGenEQML controlC2_3_6;
        private NuGenEQML controlC2_3_7;
        private NuGenEQML controlC2_3_8;
        private NuGenEQML controlC2_3_9;
        private NuGenEQML controlC2_4_1;
        private NuGenEQML controlC2_4_2;
        private NuGenEQML controlC2_4_3;
        private NuGenEQML controlC2_4_4;
        private NuGenEQML controlC3;
        private NuGenEQML controlC3_1_1;
        private NuGenEQML controlC3_1_2;
        private NuGenEQML controlC3_1_3;
        private NuGenEQML controlC3_1_4;
        private NuGenEQML controlC3_1_5;
        private NuGenEQML controlC3_1_6;
        private NuGenEQML controlC3_2_1_1;
        private NuGenEQML controlC3_2_1_2;
        private NuGenEQML controlC3_2_1_3;
        private NuGenEQML controlC3_2_1_4;
        private NuGenEQML controlC3_2_1_5;
        private NuGenEQML controlC3_2_2_1;
        private NuGenEQML controlC3_2_2_2;
        private NuGenEQML controlC3_2_2_3;
        private NuGenEQML controlC3_2_2_4;
        private NuGenEQML controlC3_2_2_5;
        private NuGenEQML controlC3_2_3_1;
        private NuGenEQML controlC3_2_3_2;
        private NuGenEQML controlC3_2_3_3;
        private NuGenEQML controlC3_2_3_4;
        private NuGenEQML controlC3_2_3_5;
        private NuGenEQML controlC3_2_3_6;
        private NuGenEQML controlC3_3_1;
        private NuGenEQML controlC3_3_2;
        private NuGenEQML controlC3_3_3;
        private NuGenEQML controlC3_3_4;
        private NuGenEQML controlC3_3_5;
        private NuGenEQML controlC3_3_6;
        private NuGenEQML controlC3_3_7;
        private NuGenEQML controlC3_3_8;
        private NuGenEQML controlC3_3_9;
        private NuGenEQML controlC3_4;
        private NuGenEQML controlC3_4_1;
        private NuGenEQML controlC3_4_2;
        private NuGenEQML controlC3_4_3;
        private NuGenEQML controlC4;
        private NuGenEQML controlC4_1_1;
        private NuGenEQML controlC4_2_1;
        private NuGenEQML controlC4_2_2;
        private NuGenEQML controlC4_2_3;
        private NuGenEQML controlC4_2_4;
        private NuGenEQML controlC4_2_5;
        private NuGenEQML controlC4_2_6;
        private NuGenEQML controlC4_3_1;
        private NuGenEQML controlC4_3_10;
        private NuGenEQML controlC4_3_11;
        private NuGenEQML controlC4_3_12;
        private NuGenEQML controlC4_3_13;
        private NuGenEQML controlC4_3_14;
        private NuGenEQML controlC4_3_15;
        private NuGenEQML controlC4_3_16;
        private NuGenEQML controlC4_3_17;
        private NuGenEQML controlC4_3_18;
        private NuGenEQML controlC4_3_19;
        private NuGenEQML controlC4_3_2;
        private NuGenEQML controlC4_3_20;
        private NuGenEQML controlC4_3_21;
        private NuGenEQML controlC4_3_3;
        private NuGenEQML controlC4_3_4;
        private NuGenEQML controlC4_3_5;
        private NuGenEQML controlC4_3_6;
        private NuGenEQML controlC4_3_7;
        private NuGenEQML controlC4_3_8;
        private NuGenEQML controlC4_3_9;
        private NuGenEQML controlC4_4_1;
        private NuGenEQML controlC4_4_2;
        private NuGenEQML controlC4_4_3;
        private NuGenEQML controlC4_4_4;
        private NuGenEQML controlC4_4_5;
        private NuGenEQML controlC4_4_6;
        private NuGenEQML controlC4_4_7;
        private NuGenEQML controlC5;
        private NuGenEQML controlC5_1_1;
        private NuGenEQML controlC5_1_2;
        private NuGenEQML controlC5_1_3;
        private NuGenEQML controlC5_1_4;
        private NuGenEQML controlC5_1_5;
        private NuGenEQML controlC5_1_6;
        private NuGenEQML controlC5_2_1;
        private NuGenEQML controlC5_2_10;
        private NuGenEQML controlC5_2_11;
        private NuGenEQML controlC5_2_12;
        private NuGenEQML controlC5_2_13;
        private NuGenEQML controlC5_2_14;
        private NuGenEQML controlC5_2_15;
        private NuGenEQML controlC5_2_2;
        private NuGenEQML controlC5_2_3;
        private NuGenEQML controlC5_2_4;
        private NuGenEQML controlC5_2_5;
        private NuGenEQML controlC5_2_6;
        private NuGenEQML controlC5_2_7;
        private NuGenEQML controlC5_2_8;
        private NuGenEQML controlC5_2_9;
        private NuGenEQML controlC5_3_1;
        private NuGenEQML controlC5_3_2;
        private NuGenEQML controlC5_3_3;
        private NuGenEQML controlC5_3_4;
        private NuGenEQML controlC5_3_5;
        private NuGenEQML controlC5_3_6;
        private NuGenEQML controlC5_3_7;
        private NuGenEQML controlC5_3_8;
        private NuGenEQML controlC5_3_9;
        private NuGenEQML controlC6;
        private NuGenEQML controlC6_2_1;
        private NuGenEQML controlC6_2_10;
        private NuGenEQML controlC6_2_11;
        private NuGenEQML controlC6_2_12;
        private NuGenEQML controlC6_2_2;
        private NuGenEQML controlC6_2_3;
        private NuGenEQML controlC6_2_4;
        private NuGenEQML controlC6_2_5;
        private NuGenEQML controlC6_2_6;
        private NuGenEQML controlC6_2_7;
        private NuGenEQML controlC6_2_8;
        private NuGenEQML controlC6_2_9;
        private NuGenEQML controlC6_3_1;
        private NuGenEQML controlC6_3_2;
        private NuGenEQML controlC6_3_3;
        private NuGenEQML controlC6_3_4;
        private NuGenEQML controlC6_3_5;
        private NuGenEQML controlC6_3_6;
        private NuGenEQML controlC7;
        private NuGenEQML controlC7_1_1;
        private NuGenEQML controlC7_2_1;
        private NuGenEQML controlC8;
        private NuGenEQML controlC8_1_1;
        private NuGenEQML controlC9;
        private NuGenEQML controlC9_3_1;
        private NuGenEQML controlC9_3_2;
        private NuGenEQML controlC9_3_3;
        private NuGenEQML controlFlag;
        private NuGenEQML controlG1_1_1;
        private NuGenEQML controlG1_2_1;
        private NuGenEQML controlG2_1_1;
        private NuGenEQML controlG2_2_1_1;
        private NuGenEQML controlG2_2_2_1;
        private NuGenEQML controlG2_2_3_1;
        private NuGenEQML controlG2_2_4_1;
        private NuGenEQML controlG2_2_5_1;
        private NuGenEQML controlG2_2_6_1;
        private NuGenEQML controlG3_1_1;
        private NuGenEQML controlG3_2_1;
        private NuGenEQML controlG4_1_1;
        private NuGenEQML controlG4_2_1;
        private NuGenEQML controlG5_1_1;
        private NuGenEQML controlG6_1_1;
        private NuGenEQML controlG7_1_1_1;
        private NuGenEQML controlG7_1_2_1;
        private NuGenEQML controlG7_1_3_1;
        private NuGenEQML controlG7_2_1;
        private NuGenEQML controlGT4_2_1_1;
        private NuGenEQML controlGT4_2_1_2;
        private NuGenEQML controlGT4_2_1_3;
        private NuGenEQML controlGT4_2_1_4;
        private NuGenEQML controlGT4_2_2_1;
        private NuGenEQML controlGT4_2_2_2;
        private NuGenEQML controlGT4_2_2_3;
        private NuGenEQML controlGT4_2_2_4;
        private NuGenEQML controlGT4_2_3_1;
        private NuGenEQML controlGT4_2_3_2;
        private NuGenEQML controlGT4_2_3_3;
        private NuGenEQML controlGT4_2_3_4;
        private FlowLayoutPanel flowLayoutPanel1;
        public Dictionary<string, bool> gapfillingAnswerResults;
        public List<string> gapfillingString;
        public string guid;
        private System.Windows.Forms.Timer intervalTimer;
        private bool isReSubmit;
        private Label label_Choice;
        private Label label_class;
        private Label label_code;
        private Label label_grade;
        private Label label_name;
        private Label label_time;
        private Label label_title;
        private Label labelC;
        private Label labelC1_1;
        private Label labelC1_1_1;
        private Label labelC1_1_2;
        private Label labelC1_2;
        private Label labelC1_2_1;
        private Label labelC1_2_10;
        private Label labelC1_2_11;
        private Label labelC1_2_12;
        private Label labelC1_2_2;
        private Label labelC1_2_3;
        private Label labelC1_2_4;
        private Label labelC1_2_5;
        private Label labelC1_2_6;
        private Label labelC1_2_7;
        private Label labelC1_2_8;
        private Label labelC1_2_9;
        private Label labelC1_3;
        private Label labelC1_3_1;
        private Label labelC1_3_1_0;
        private Label labelC1_3_1_1;
        private Label labelC1_3_1_10;
        private Label labelC1_3_1_2;
        private Label labelC1_3_1_3;
        private Label labelC1_3_1_4;
        private Label labelC1_3_1_5;
        private Label labelC1_3_1_6;
        private Label labelC1_3_1_7;
        private Label labelC1_3_1_8;
        private Label labelC1_3_1_9;
        private Label labelC1_3_2_0;
        private Label labelC1_3_2_1;
        private Label labelC1_3_2_10;
        private Label labelC1_3_2_2;
        private Label labelC1_3_2_3;
        private Label labelC1_3_2_4;
        private Label labelC1_3_2_5;
        private Label labelC1_3_2_6;
        private Label labelC1_3_2_7;
        private Label labelC1_3_2_8;
        private Label labelC1_3_2_9;
        private Label labelC1_3_3_0;
        private Label labelC1_3_3_1;
        private Label labelC1_3_3_10;
        private Label labelC1_3_3_2;
        private Label labelC1_3_3_3;
        private Label labelC1_3_3_4;
        private Label labelC1_3_3_5;
        private Label labelC1_3_3_6;
        private Label labelC1_3_3_7;
        private Label labelC1_3_3_8;
        private Label labelC1_3_3_9;
        private Label labelC1_3_4_0;
        private Label labelC1_3_4_1;
        private Label labelC1_3_4_10;
        private Label labelC1_3_4_2;
        private Label labelC1_3_4_3;
        private Label labelC1_3_4_4;
        private Label labelC1_3_4_5;
        private Label labelC1_3_4_6;
        private Label labelC1_3_4_7;
        private Label labelC1_3_4_8;
        private Label labelC1_3_4_9;
        private Label labelC10_1;
        private Label labelC10_1_1;
        private Label labelC10_1_2;
        private Label labelC10_2;
        private Label labelC10_2_1;
        private Label labelC10_2_2;
        private Label labelC10_3;
        private Label labelC10_3_1;
        private Label labelC10_3_2;
        private Label labelC10_3_3;
        private Label labelC11_1;
        private Label labelC11_1_1;
        private Label labelC11_1_2;
        private Label labelC11_1_3;
        private Label labelC11_2;
        private Label labelC11_2_1;
        private Label labelC11_2_2;
        private Label labelC11_2_3;
        private Label labelC11_3;
        private Label labelC11_3_1;
        private Label labelC11_3_2;
        private Label labelC11_3_3;
        private Label labelC11_3_4;
        private Label labelC2_1;
        private Label labelC2_1_1;
        private Label labelC2_2;
        private Label labelC2_2_1;
        private Label labelC2_2_2;
        private Label labelC2_2_3;
        private Label labelC2_2_4;
        private Label labelC2_2_5;
        private Label labelC2_3;
        private Label labelC2_3_1;
        private Label labelC2_3_2;
        private Label labelC2_3_3;
        private Label labelC2_4;
        private Label labelC2_4_1;
        private Label labelC3_1;
        private Label labelC3_1_1;
        private Label labelC3_1_2;
        private Label labelC3_1_3;
        private Label labelC3_1_4;
        private Label labelC3_2;
        private Label labelC3_2_1_1;
        private Label labelC3_2_1_2;
        private Label labelC3_2_1_3;
        private Label labelC3_2_2_1;
        private Label labelC3_2_2_2;
        private Label labelC3_2_2_3;
        private Label labelC3_2_3_1;
        private Label labelC3_2_3_2;
        private Label labelC3_2_3_3;
        private Label labelC3_3;
        private Label labelC3_3_1;
        private Label labelC3_4;
        private Label labelC3_4_1;
        private Label labelC4_1;
        private Label labelC4_1_1;
        private Label labelC4_2;
        private Label labelC4_2_1;
        private Label labelC4_3;
        private Label labelC4_3_1;
        private Label labelC4_3_2;
        private Label labelC4_3_3;
        private Label labelC4_4;
        private Label labelC4_4_1;
        private Label labelC5_1;
        private Label labelC5_1_1;
        private Label labelC5_2;
        private Label labelC5_2_1;
        private Label labelC5_2_2;
        private Label labelC5_2_3;
        private Label labelC5_3;
        private Label labelC5_3_1;
        private Label labelC6_1;
        private Label labelC6_1_1;
        private Label labelC6_1_2;
        private Label labelC6_1_3;
        private Label labelC6_1_4;
        private Label labelC6_2;
        private Label labelC6_2_1;
        private Label labelC6_2_2;
        private Label labelC6_3;
        private Label labelC6_3_1;
        private Label labelC7_1;
        private Label labelC7_1_1;
        private Label labelC7_2;
        private Label labelC7_2_1;
        private Label labelC7_3;
        private Label labelC7_3_1;
        private Label labelC8_1;
        private Label labelC8_1_1;
        private Label labelC8_2;
        private Label labelC8_2_1;
        private Label labelC8_3;
        private Label labelC8_3_1;
        private Label labelC9_1;
        private Label labelC9_1_1;
        private Label labelC9_2;
        private Label labelC9_2_1;
        private Label labelC9_3;
        private Label labelC9_3_1;
        private Label labelChoice1_1;
        private Label labelChoice1_2;
        private Label labelChoice1_3;
        private Label labelChoice2_1;
        private Label labelChoice2_2;
        private Label labelChoice2_3;
        private Label labelChoice3_1;
        private Label labelChoice3_2;
        private Label labelChoice3_3;
        private Label labelChoice4_1;
        private Label labelChoice4_2;
        private Label labelChoice4_3;
        private Label labelChoice5_1;
        private Label labelChoice5_2;
        private Label labelChoice5_3;
        private Label labelG;
        private Label labelG1_1;
        private Label labelG1_2;
        private Label labelG2_1;
        private Label labelG2_2_1;
        private Label labelG2_2_2;
        private Label labelG2_2_3;
        private Label labelG2_2_4;
        private Label labelG2_2_5;
        private Label labelG2_2_6;
        private Label labelG3_1;
        private Label labelG3_2;
        private Label labelG4_1;
        private Label labelG4_2;
        private Label labelG5_1;
        private Label labelG6_1;
        private Label labelG7_1_1;
        private Label labelG7_1_2;
        private Label labelG7_1_3;
        private Label labelG7_2;
        private Label labelhelp;
        private int mark;
        private int number;
        private TimeSpan oneSpan;
        private Panel panel1;
        private PictureBox pictureBox_five_1;
        private PictureBox pictureBox_five_2;
        private PictureBox pictureBox_five_3;
        private PictureBox pictureBox_five_4;
        private PictureBox pictureBox_five_5;
        private PictureBox pictureBox_five_6;
        private PictureBox pictureBox_five_7;
        private PictureBox pictureBox_five_8;
        private PictureBox pictureBox_five_9;
        private PictureBox pictureBox_four_1;
        private PictureBox pictureBox_four_2;
        private PictureBox pictureBox_four_3;
        private PictureBox pictureBox_four_4;
        private PictureBox pictureBox_four_5;
        private PictureBox pictureBox_four_6;
        private PictureBox pictureBox_four_7;
        private PictureBox pictureBox_four_8;
        private PictureBox pictureBox_four_9;
        private PictureBox pictureBox_one_1;
        private PictureBox pictureBox_one_2;
        private PictureBox pictureBox_one_3;
        private PictureBox pictureBox_one_4;
        private PictureBox pictureBox_one_5;
        private PictureBox pictureBox_one_6;
        private PictureBox pictureBox_one_7;
        private PictureBox pictureBox_one_8;
        private PictureBox pictureBox_one_9;
        private PictureBox pictureBox_three_1;
        private PictureBox pictureBox_three_2;
        private PictureBox pictureBox_three_3;
        private PictureBox pictureBox_three_4;
        private PictureBox pictureBox_three_5;
        private PictureBox pictureBox_three_6;
        private PictureBox pictureBox_three_7;
        private PictureBox pictureBox_three_8;
        private PictureBox pictureBox_three_9;
        private PictureBox pictureBox_two_1;
        private PictureBox pictureBox_two_2;
        private PictureBox pictureBox_two_3;
        private PictureBox pictureBox_two_4;
        private PictureBox pictureBox_two_5;
        private PictureBox pictureBox_two_6;
        private PictureBox pictureBox_two_7;
        private PictureBox pictureBox_two_8;
        private PictureBox pictureBox_two_9;
        private PictureBox pictureBoxC2_1_1;
        private PictureBox pictureBoxC2_1_2;
        private PictureBox pictureBoxC2_3_1;
        private PictureBox pictureBoxC2_3_2;
        private PictureBox pictureBoxC2_3_3;
        private PictureBox pictureBoxC2_3_4;
        private PictureBox pictureBoxC2_3_5;
        private PictureBox pictureBoxC2_3_6;
        private PictureBox pictureBoxC2_4_1;
        private PictureBox pictureBoxC2_4_2;
        private PictureBox pictureBoxC3_3_1;
        private PictureBox pictureBoxC3_3_2;
        private PictureBox pictureBoxC3_4_1;
        private PictureBox pictureBoxC3_4_2;
        private PictureBox pictureBoxC4_1_1;
        private PictureBox pictureBoxC4_1_2;
        private PictureBox pictureBoxC5_3_1;
        private PictureBox pictureBoxC5_3_2;
        private PictureBox pictureBoxC7_1_1;
        private PictureBox pictureBoxC7_1_2;
        private PictureBox pictureBoxC7_2_1;
        private PictureBox pictureBoxC7_2_2;
        private PictureBox pictureBoxC7_3_1;
        private PictureBox pictureBoxC7_3_2;
        private PictureBox pictureBoxC8_1_1;
        private PictureBox pictureBoxC8_1_2;
        private PictureBox pictureBoxC8_2_1;
        private PictureBox pictureBoxC8_2_2;
        private PictureBox pictureBoxC8_3_1;
        private PictureBox pictureBoxC8_3_2;
        private PictureBox pictureBoxG1_1_1;
        private PictureBox pictureBoxG1_1_2;
        private PictureBox pictureBoxG1_2_1;
        private PictureBox pictureBoxG1_2_2;
        private PictureBox pictureBoxG2_1_1;
        private PictureBox pictureBoxG2_1_2;
        private PictureBox pictureBoxG2_2_1_1;
        private PictureBox pictureBoxG2_2_1_2;
        private PictureBox pictureBoxG2_2_2_1;
        private PictureBox pictureBoxG2_2_2_2;
        private PictureBox pictureBoxG2_2_3_1;
        private PictureBox pictureBoxG2_2_3_2;
        private PictureBox pictureBoxG2_2_4_1;
        private PictureBox pictureBoxG2_2_4_2;
        private PictureBox pictureBoxG2_2_5_1;
        private PictureBox pictureBoxG2_2_5_2;
        private PictureBox pictureBoxG2_2_6_1;
        private PictureBox pictureBoxG2_2_6_2;
        private PictureBox pictureBoxG3_1_1;
        private PictureBox pictureBoxG3_1_2;
        private PictureBox pictureBoxG3_2_1;
        private PictureBox pictureBoxG3_2_2;
        private PictureBox pictureBoxG4_1_1;
        private PictureBox pictureBoxG4_1_2;
        private PictureBox pictureBoxG5_1_1;
        private PictureBox pictureBoxG5_1_2;
        private PictureBox pictureBoxG6_1_1;
        private PictureBox pictureBoxG6_1_2;
        private PictureBox pictureBoxG7_1_1_1;
        private PictureBox pictureBoxG7_1_1_2;
        private PictureBox pictureBoxG7_1_2_1;
        private PictureBox pictureBoxG7_1_2_2;
        private PictureBox pictureBoxG7_1_3_1;
        private PictureBox pictureBoxG7_1_3_2;
        private PictureBox pictureBoxG7_2_1;
        private PictureBox pictureBoxG7_2_2;
        private RadioButton radioButton_Five_1;
        private RadioButton radioButton_Five_2;
        private RadioButton radioButton_Five_3;
        private RadioButton radioButton_Five_4;
        private RadioButton radioButton_Four_1;
        private RadioButton radioButton_Four_2;
        private RadioButton radioButton_Four_3;
        private RadioButton radioButton_Four_4;
        private RadioButton radioButton_one_1;
        private RadioButton radioButton_one_2;
        private RadioButton radioButton_one_3;
        private RadioButton radioButton_one_4;
        private RadioButton radioButton_Three_1;
        private RadioButton radioButton_Three_2;
        private RadioButton radioButton_Three_3;
        private RadioButton radioButton_Three_4;
        private RadioButton radioButton_Two_1;
        private RadioButton radioButton_Two_2;
        private RadioButton radioButton_Two_3;
        private RadioButton radioButton_Two_4;
        private RadioButton radioButtonC2_2_1;
        private RadioButton radioButtonC2_2_2;
        private RadioButton radiobuttonC9_2_1;
        private RadioButton radiobuttonC9_2_2;
        private RadioButton radiobuttonC9_2_3;
        private int randmomSubmitTime;
        private System.Windows.Forms.Timer show_time;
        private TimeSpan span;
        private TableLayoutPanel table_five;
        private TableLayoutPanel table_Four;
        private TableLayoutPanel table_one;
        private TableLayoutPanel table_Three;
        private TableLayoutPanel table_Two;
        private TableLayoutPanel tableC2_1_1;
        private TableLayoutPanel tableC2_3_1;
        private TableLayoutPanel tableC2_3_2;
        private TableLayoutPanel tableC2_3_3;
        private TableLayoutPanel tableC2_4_1;
        private TableLayoutPanel tableC3_3_1;
        private TableLayoutPanel tableC3_4_1;
        private TableLayoutPanel tableC4_1_1;
        private TableLayoutPanel tableC5_3_1;
        private TableLayoutPanel tableC7_1_1;
        private TableLayoutPanel tableC7_2_1;
        private TableLayoutPanel tableC7_3_1;
        private TableLayoutPanel tableC8_1_1;
        private TableLayoutPanel tableC8_2_1;
        private TableLayoutPanel tableC8_3_1;
        private TableLayoutPanel tableG2_1_1;
        private TableLayoutPanel tableG2_2_1_1;
        private TableLayoutPanel tableG2_2_2_1;
        private TableLayoutPanel tableG2_2_3_1;
        private TableLayoutPanel tableG2_2_4_1;
        private TableLayoutPanel tableG2_2_5_1;
        private TableLayoutPanel tableG2_2_6_1;
        private TableLayoutPanel tableG4_2_1;
        private TableLayoutPanel tableG4_2_2;
        private TableLayoutPanel tableG4_2_3;
        private TableLayoutPanel tableG7_1_1_1;
        private TableLayoutPanel tableG7_1_2_1;
        private TableLayoutPanel tableG7_1_3_1;
        private TableLayoutPanel tableG7_2_1;
        private TextBox textbox_class;
        private TextBox textbox_code;
        private TextBox textbox_grade;
        private TextBox textbox_name;
        private TextBox textBoxC1_1_1;
        private TextBox TextBoxC1_2_1;
        private TextBox TextBoxC1_2_2;
        private TextBox TextBoxC1_2_3;
        private TextBox TextBoxC1_2_4;
        private TextBox TextBoxC1_2_5;
        private TextBox textBoxC1_3_1_1;
        private TextBox textBoxC1_3_1_2;
        private TextBox textBoxC1_3_1_3;
        private TextBox textBoxC1_3_1_4;
        private TextBox textBoxC1_3_1_5;
        private TextBox textBoxC1_3_1_6;
        private TextBox textBoxC1_3_1_7;
        private TextBox textBoxC1_3_1_8;
        private TextBox textBoxC1_3_1_9;
        private TextBox textBoxC1_3_2_1;
        private TextBox textBoxC1_3_2_2;
        private TextBox textBoxC1_3_2_3;
        private TextBox textBoxC1_3_2_4;
        private TextBox textBoxC1_3_2_5;
        private TextBox textBoxC1_3_2_6;
        private TextBox textBoxC1_3_2_7;
        private TextBox textBoxC1_3_2_8;
        private TextBox textBoxC1_3_2_9;
        private TextBox textBoxC1_3_3_1;
        private TextBox textBoxC1_3_3_2;
        private TextBox textBoxC1_3_3_3;
        private TextBox textBoxC1_3_3_4;
        private TextBox textBoxC1_3_3_5;
        private TextBox textBoxC1_3_3_6;
        private TextBox textBoxC1_3_3_7;
        private TextBox textBoxC1_3_3_8;
        private TextBox textBoxC1_3_3_9;
        private TextBox textBoxC1_3_4_1;
        private TextBox textBoxC1_3_4_2;
        private TextBox textBoxC1_3_4_3;
        private TextBox textBoxC1_3_4_4;
        private TextBox textBoxC1_3_4_5;
        private TextBox textBoxC1_3_4_6;
        private TextBox textBoxC1_3_4_7;
        private TextBox textBoxC1_3_4_8;
        private TextBox textBoxC1_3_4_9;
        private TextBox textBoxC10_1_1;
        private TextBox textBoxC10_2_1;
        private TextBox textBoxC10_2_2;
        private TextBox textBoxC10_2_3;
        private TextBox textBoxC10_2_4;
        private TextBox textBoxC10_2_5;
        private TextBox textBoxC10_2_6;
        private TextBox textBoxC10_3_1;
        private TextBox textBoxC10_3_2;
        private TextBox textBoxC10_3_3;
        private TextBox textBoxC10_3_4;
        private TextBox textBoxC10_3_5;
        private TextBox textBoxC11_1_1;
        private TextBox textBoxC11_1_2;
        private TextBox textBoxC11_2_1;
        private TextBox textBoxC11_2_2;
        private TextBox textBoxC11_2_3;
        private TextBox textBoxC11_2_4;
        private TextBox textBoxC11_2_5;
        private TextBox textBoxC11_3_1;
        private TextBox textBoxC11_3_2;
        private TextBox textBoxC11_3_3;
        private TextBox textBoxC11_3_4;
        private TextBox textBoxC11_3_5;
        private TextBox textBoxC2_1_1;
        private TextBox textBoxC2_1_10;
        private TextBox textBoxC2_1_11;
        private TextBox textBoxC2_1_12;
        private TextBox textBoxC2_1_13;
        private TextBox textBoxC2_1_14;
        private TextBox textBoxC2_1_15;
        private TextBox textBoxC2_1_16;
        private TextBox textBoxC2_1_17;
        private TextBox textBoxC2_1_18;
        private TextBox textBoxC2_1_19;
        private TextBox textBoxC2_1_2;
        private TextBox textBoxC2_1_20;
        private TextBox textBoxC2_1_3;
        private TextBox textBoxC2_1_4;
        private TextBox textBoxC2_1_5;
        private TextBox textBoxC2_1_6;
        private TextBox textBoxC2_1_7;
        private TextBox textBoxC2_1_8;
        private TextBox textBoxC2_1_9;
        private TextBox textBoxC2_2_1;
        private TextBox textBoxC2_2_2;
        private TextBox textBoxC4_1_1;
        private TextBox textBoxC4_1_2;
        private TextBox textBoxC4_1_3;
        private TextBox textBoxC4_1_4;
        private TextBox textBoxC4_1_5;
        private TextBox textBoxC4_1_6;
        private TextBox textBoxC4_1_7;
        private TextBox textBoxC4_1_8;
        private TextBox textBoxC4_1_9;
        private TextBox textBoxC6_1_1;
        private TextBox textBoxC6_1_2;
        private TextBox textBoxC7_1_1;
        private TextBox textBoxC7_1_2;
        private TextBox textBoxC7_1_3;
        private TextBox textBoxC7_1_4;
        private TextBox textBoxC7_1_5;
        private TextBox textBoxC7_1_6;
        private TextBox textBoxC7_1_7;
        private TextBox textBoxC7_1_8;
        private TextBox textBoxC7_1_9;
        private TextBox textBoxC7_2_1;
        private TextBox textBoxC7_2_2;
        private TextBox textBoxC7_2_3;
        private TextBox textBoxC7_2_4;
        private TextBox textBoxC7_3_1;
        private TextBox textBoxC7_3_2;
        private TextBox textBoxC7_3_3;
        private TextBox textBoxC7_3_4;
        private TextBox textBoxC7_3_5;
        private TextBox textBoxC7_3_6;
        private TextBox textBoxC8_1_1;
        private TextBox textBoxC8_1_2;
        private TextBox textBoxC8_1_3;
        private TextBox textBoxC8_1_4;
        private TextBox textBoxC8_1_5;
        private TextBox textBoxC8_1_6;
        private TextBox textBoxC8_1_7;
        private TextBox textBoxC8_1_8;
        private TextBox textBoxC8_1_9;
        private TextBox textBoxC8_2_1;
        private TextBox textBoxC8_2_2;
        private TextBox textBoxC8_2_3;
        private TextBox textBoxC8_2_4;
        private TextBox textBoxC8_2_5;
        private TextBox textBoxC8_2_6;
        private TextBox textBoxC8_3_1;
        private TextBox textBoxC8_3_2;
        private TextBox textBoxC8_3_3;
        private TextBox textBoxC8_3_4;
        private TextBox textBoxC8_3_5;
        private TextBox textBoxC8_3_6;
        private TextBox textBoxC9_1_1;
        private TextBox textBoxC9_3_1;
        private TextBox textBoxC9_3_2;
        private TextBox textBoxC9_3_3;
        private TextBox textBoxG1_1_1;
        private TextBox textBoxG1_2_1;
        private TextBox textBoxG2_2_1_1;
        private TextBox textBoxG2_2_1_2;
        private TextBox textBoxG2_2_1_3;
        private TextBox textBoxG2_2_1_4;
        private TextBox textBoxG2_2_1_5;
        private TextBox textBoxG2_2_1_6;
        private TextBox textBoxG2_2_1_7;
        private TextBox textBoxG2_2_1_8;
        private TextBox textBoxG2_2_1_9;
        private TextBox textBoxG2_2_2_1;
        private TextBox textBoxG2_2_2_2;
        private TextBox textBoxG2_2_2_3;
        private TextBox textBoxG2_2_2_4;
        private TextBox textBoxG2_2_2_5;
        private TextBox textBoxG2_2_2_6;
        private TextBox textBoxG2_2_2_7;
        private TextBox textBoxG2_2_2_8;
        private TextBox textBoxG2_2_2_9;
        private TextBox textBoxG2_2_3_1;
        private TextBox textBoxG2_2_3_2;
        private TextBox textBoxG2_2_3_3;
        private TextBox textBoxG2_2_3_4;
        private TextBox textBoxG2_2_3_5;
        private TextBox textBoxG2_2_3_6;
        private TextBox textBoxG2_2_3_7;
        private TextBox textBoxG2_2_3_8;
        private TextBox textBoxG2_2_3_9;
        private TextBox textBoxG2_2_4_1;
        private TextBox textBoxG2_2_4_2;
        private TextBox textBoxG2_2_4_3;
        private TextBox textBoxG2_2_4_4;
        private TextBox textBoxG2_2_4_5;
        private TextBox textBoxG2_2_4_6;
        private TextBox textBoxG2_2_4_7;
        private TextBox textBoxG2_2_4_8;
        private TextBox textBoxG2_2_4_9;
        private TextBox textBoxG2_2_5_1;
        private TextBox textBoxG2_2_5_2;
        private TextBox textBoxG2_2_5_3;
        private TextBox textBoxG2_2_5_4;
        private TextBox textBoxG2_2_5_5;
        private TextBox textBoxG2_2_5_6;
        private TextBox textBoxG2_2_5_7;
        private TextBox textBoxG2_2_5_8;
        private TextBox textBoxG2_2_5_9;
        private TextBox textBoxG2_2_6_1;
        private TextBox textBoxG2_2_6_2;
        private TextBox textBoxG2_2_6_3;
        private TextBox textBoxG2_2_6_4;
        private TextBox textBoxG2_2_6_5;
        private TextBox textBoxG2_2_6_6;
        private TextBox textBoxG2_2_6_7;
        private TextBox textBoxG2_2_6_8;
        private TextBox textBoxG2_2_6_9;
        private TextBox textBoxG3_1_1;
        private TextBox textBoxG3_2_1;
        private TextBox textBoxG4_1_1;
        private TextBox textBoxG5_1_1;
        private TextBox textBoxG6_1_1;
        private TextBox textBoxG7_1_1_1;
        private TextBox textBoxG7_1_1_2;
        private TextBox textBoxG7_1_1_3;
        private TextBox textBoxG7_1_1_4;
        private TextBox textBoxG7_1_1_5;
        private TextBox textBoxG7_1_1_6;
        private TextBox textBoxG7_1_1_7;
        private TextBox textBoxG7_1_1_8;
        private TextBox textBoxG7_1_1_9;
        private TextBox textBoxG7_1_2_1;
        private TextBox textBoxG7_1_2_10;
        private TextBox textBoxG7_1_2_11;
        private TextBox textBoxG7_1_2_12;
        private TextBox textBoxG7_1_2_13;
        private TextBox textBoxG7_1_2_14;
        private TextBox textBoxG7_1_2_15;
        private TextBox textBoxG7_1_2_16;
        private TextBox textBoxG7_1_2_2;
        private TextBox textBoxG7_1_2_3;
        private TextBox textBoxG7_1_2_4;
        private TextBox textBoxG7_1_2_5;
        private TextBox textBoxG7_1_2_6;
        private TextBox textBoxG7_1_2_7;
        private TextBox textBoxG7_1_2_8;
        private TextBox textBoxG7_1_2_9;
        private TextBox textBoxG7_1_3_1;
        private TextBox textBoxG7_1_3_2;
        private TextBox textBoxG7_1_3_3;
        private TextBox textBoxG7_1_3_4;
        private TextBox textBoxG7_1_3_5;
        private TextBox textBoxG7_1_3_6;
        private TextBox textBoxG7_1_3_7;
        private TextBox textBoxG7_1_3_8;
        private TextBox textBoxG7_1_3_9;
        private TextBox textBoxG7_2_1;
        private TextBox textBoxG7_2_2;
        private TextBox textBoxG7_2_3;
        private TextBox textBoxGT2_1_1;
        private TextBox textBoxGT2_1_10;
        private TextBox textBoxGT2_1_11;
        private TextBox textBoxGT2_1_12;
        private TextBox textBoxGT2_1_13;
        private TextBox textBoxGT2_1_14;
        private TextBox textBoxGT2_1_15;
        private TextBox textBoxGT2_1_16;
        private TextBox textBoxGT2_1_2;
        private TextBox textBoxGT2_1_3;
        private TextBox textBoxGT2_1_4;
        private TextBox textBoxGT2_1_5;
        private TextBox textBoxGT2_1_6;
        private TextBox textBoxGT2_1_7;
        private TextBox textBoxGT2_1_8;
        private TextBox textBoxGT2_1_9;
        private System.Timers.Timer timersTimer;
        private static StudentService timeService = new StudentService();
        public int totalScore;
        private static int uploadSeconds = new Random().Next(0, 60);
        public List<string> UserChoiceString;

        public Form1()
        {
            int num;
            this.components = null;
            this.mark = 0;
            this.isReSubmit = false;
            this.number = 0;
            this.span = (TimeSpan) (StudentModel.endTime - DateTime.Now);
            this.oneSpan = new TimeSpan(0, 0, 1);
            this.randmomSubmitTime = new Random().Next(0, 60);
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.controlFlag = null;
            this.labelhelp = new Label();
            this.label_Choice = new Label();
            this.show_time = new System.Windows.Forms.Timer();
            this.label_time = new Label();
            this.label_class = new Label();
            this.textbox_class = new TextBox();
            this.label_name = new Label();
            this.textbox_name = new TextBox();
            this.label_code = new Label();
            this.textbox_code = new TextBox();
            this.label_grade = new Label();
            this.textbox_grade = new TextBox();
            this.label_title = new Label();
            this.totalScore = 0;
            this.btn_isSubmit = new Button();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Text = "东北大学线性代数考试系统";
            base.WindowState = FormWindowState.Maximized;
            this.InitializeComponent();
            base.VerticalScroll.Value = 0;
            if (base.FormBorderStyle == FormBorderStyle.None)
            {
                base.FormBorderStyle = FormBorderStyle.FixedSingle;
                base.WindowState = FormWindowState.Normal;
            }
            else
            {
                base.FormBorderStyle = FormBorderStyle.None;
                base.WindowState = FormWindowState.Maximized;
            }
            this.flowLayoutPanel1.Width = SystemInformation.VirtualScreen.Width;
            this.flowLayoutPanel1.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new Point(0, 100);
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.Left = 0;
            this.flowLayoutPanel1.AllowDrop = false;
            base.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel1.AutoScrollPosition = new Point(100, 250);
            this.guid = Guid.NewGuid().ToString();
            StreamWriter writer = new StreamWriter("temp/generate/id.txt");
            writer.Write(this.guid);
            writer.Close();
            this.AnwserNumber = new List<int>();
            ChoiceSpilt.splitChoice();
            this.ChoicegString = ChoiceSpilt.StacticChoicegString;
            this.AnwserNumber = new ChoiceAnwserNumber().GetChoiceAnwserNumber(this.ChoicegString);
            this.choiceInitialAndShow(this.ChoicegString);
            this.gapfillingString = new List<string>();
            string[] strArray = StudentModel.gapfillingNumber.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (num = 0; num < strArray.Length; num++)
            {
                this.gapfillingString.Add(strArray[num]);
            }
            this.assignGapfillingControls(this.gapfillingString);
            this.labelhelp.Width = Screen.PrimaryScreen.Bounds.Width + 600;
            this.flowLayoutPanel1.Controls.Add(this.labelhelp);
            this.calculationString = new List<string>();
            string[] strArray2 = StudentModel.calculationNumber.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (num = 0; num < strArray2.Length; num++)
            {
                this.calculationString.Add(strArray2[num]);
            }
            this.assignCalculationControls(this.calculationString);
            if (!StudentModel.isReGeneration)
            {
                try
                {
                    string str;
                    List<string> list2;
                    List<string> list3;
                    List<string> list4;
                    if (!File.Exists("temp/UA/choiceAnswer.xml"))
                    {
                        goto Label_0707;
                    }
                    List<string> list = new List<string>();
                    XmlDocument document = new XmlDocument();
                    document.Load("temp/UA/choiceAnswer.xml");
                    foreach (XmlNode node in document.ChildNodes)
                    {
                        foreach (XmlNode node2 in node.ChildNodes)
                        {
                            list.Add(node2.FirstChild.InnerText);
                        }
                    }
                    string str6 = list[0];
                    if (str6 != null)
                    {
                        if (!(str6 == "a"))
                        {
                            if (str6 == "b")
                            {
                                goto Label_04C9;
                            }
                            if (str6 == "c")
                            {
                                goto Label_04D8;
                            }
                            if (str6 == "d")
                            {
                                goto Label_04E7;
                            }
                        }
                        else
                        {
                            this.radioButton_one_1.Checked = true;
                        }
                    }
                    goto Label_04F6;
                Label_04C9:
                    this.radioButton_one_2.Checked = true;
                    goto Label_04F6;
                Label_04D8:
                    this.radioButton_one_3.Checked = true;
                    goto Label_04F6;
                Label_04E7:
                    this.radioButton_one_4.Checked = true;
                Label_04F6:
                    str6 = list[1];
                    if (str6 != null)
                    {
                        if (!(str6 == "a"))
                        {
                            if (str6 == "b")
                            {
                                goto Label_054D;
                            }
                            if (str6 == "c")
                            {
                                goto Label_055C;
                            }
                            if (str6 == "d")
                            {
                                goto Label_056B;
                            }
                        }
                        else
                        {
                            this.radioButton_Two_1.Checked = true;
                        }
                    }
                    goto Label_057A;
                Label_054D:
                    this.radioButton_Two_2.Checked = true;
                    goto Label_057A;
                Label_055C:
                    this.radioButton_Two_3.Checked = true;
                    goto Label_057A;
                Label_056B:
                    this.radioButton_Two_4.Checked = true;
                Label_057A:
                    str6 = list[2];
                    if (str6 != null)
                    {
                        if (!(str6 == "a"))
                        {
                            if (str6 == "b")
                            {
                                goto Label_05D1;
                            }
                            if (str6 == "c")
                            {
                                goto Label_05E0;
                            }
                            if (str6 == "d")
                            {
                                goto Label_05EF;
                            }
                        }
                        else
                        {
                            this.radioButton_Three_1.Checked = true;
                        }
                    }
                    goto Label_05FE;
                Label_05D1:
                    this.radioButton_Three_2.Checked = true;
                    goto Label_05FE;
                Label_05E0:
                    this.radioButton_Three_3.Checked = true;
                    goto Label_05FE;
                Label_05EF:
                    this.radioButton_Three_4.Checked = true;
                Label_05FE:
                    str6 = list[3];
                    if (str6 != null)
                    {
                        if (!(str6 == "a"))
                        {
                            if (str6 == "b")
                            {
                                goto Label_0655;
                            }
                            if (str6 == "c")
                            {
                                goto Label_0664;
                            }
                            if (str6 == "d")
                            {
                                goto Label_0673;
                            }
                        }
                        else
                        {
                            this.radioButton_Four_1.Checked = true;
                        }
                    }
                    goto Label_0682;
                Label_0655:
                    this.radioButton_Four_2.Checked = true;
                    goto Label_0682;
                Label_0664:
                    this.radioButton_Four_3.Checked = true;
                    goto Label_0682;
                Label_0673:
                    this.radioButton_Four_4.Checked = true;
                Label_0682:
                    str6 = list[4];
                    if (str6 != null)
                    {
                        if (!(str6 == "a"))
                        {
                            if (str6 == "b")
                            {
                                goto Label_06D9;
                            }
                            if (str6 == "c")
                            {
                                goto Label_06E8;
                            }
                            if (str6 == "d")
                            {
                                goto Label_06F7;
                            }
                        }
                        else
                        {
                            this.radioButton_Five_1.Checked = true;
                        }
                    }
                    goto Label_0707;
                Label_06D9:
                    this.radioButton_Five_2.Checked = true;
                    goto Label_0707;
                Label_06E8:
                    this.radioButton_Five_3.Checked = true;
                    goto Label_0707;
                Label_06F7:
                    this.radioButton_Five_4.Checked = true;
                Label_0707:
                    if (File.Exists("temp/UA/gapfillingAnswer.xml"))
                    {
                        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
                        document = new XmlDocument();
                        document.Load("temp/UA/gapfillingAnswer.xml");
                        foreach (XmlNode node in document.ChildNodes)
                        {
                            foreach (XmlNode node2 in node.ChildNodes)
                            {
                                str = node2.Attributes["name"].Value;
                                list2 = new List<string>();
                                foreach (XmlNode node3 in node2.FirstChild.ChildNodes)
                                {
                                    list2.Add(node3.InnerText);
                                }
                                dictionary[str] = list2;
                            }
                        }
                        list3 = new List<string>();
                        foreach (string str2 in dictionary.Keys)
                        {
                            list3.Add(str2);
                        }
                        foreach (string str3 in list3)
                        {
                            list4 = dictionary[str3];
                            switch (str3)
                            {
                                case "g_one_1.xml":
                                    this.textBoxG1_1_1.Text = list4[0];
                                    break;

                                case "g_one_2.xml":
                                    this.textBoxG1_2_1.Text = list4[0];
                                    break;

                                case "g_two_1.xml":
                                    this.textBoxGT2_1_1.Text = list4[0];
                                    this.textBoxGT2_1_2.Text = list4[1];
                                    this.textBoxGT2_1_3.Text = list4[2];
                                    this.textBoxGT2_1_4.Text = list4[3];
                                    this.textBoxGT2_1_5.Text = list4[4];
                                    this.textBoxGT2_1_6.Text = list4[5];
                                    this.textBoxGT2_1_7.Text = list4[6];
                                    this.textBoxGT2_1_8.Text = list4[7];
                                    this.textBoxGT2_1_9.Text = list4[8];
                                    this.textBoxGT2_1_10.Text = list4[9];
                                    this.textBoxGT2_1_11.Text = list4[10];
                                    this.textBoxGT2_1_12.Text = list4[11];
                                    this.textBoxGT2_1_13.Text = list4[12];
                                    this.textBoxGT2_1_14.Text = list4[13];
                                    this.textBoxGT2_1_15.Text = list4[14];
                                    this.textBoxGT2_1_16.Text = list4[15];
                                    break;

                                case "g_two_2_1.xml":
                                    this.textBoxG2_2_1_1.Text = list4[0];
                                    this.textBoxG2_2_1_2.Text = list4[1];
                                    this.textBoxG2_2_1_3.Text = list4[2];
                                    this.textBoxG2_2_1_4.Text = list4[3];
                                    this.textBoxG2_2_1_5.Text = list4[4];
                                    this.textBoxG2_2_1_6.Text = list4[5];
                                    this.textBoxG2_2_1_7.Text = list4[6];
                                    this.textBoxG2_2_1_8.Text = list4[7];
                                    this.textBoxG2_2_1_9.Text = list4[8];
                                    break;

                                case "g_two_2_2.xml":
                                    this.textBoxG2_2_2_1.Text = list4[0];
                                    this.textBoxG2_2_2_2.Text = list4[1];
                                    this.textBoxG2_2_2_3.Text = list4[2];
                                    this.textBoxG2_2_2_4.Text = list4[3];
                                    this.textBoxG2_2_2_5.Text = list4[4];
                                    this.textBoxG2_2_2_6.Text = list4[5];
                                    this.textBoxG2_2_2_7.Text = list4[6];
                                    this.textBoxG2_2_2_8.Text = list4[7];
                                    this.textBoxG2_2_2_9.Text = list4[8];
                                    break;

                                case "g_two_2_3.xml":
                                    this.textBoxG2_2_3_1.Text = list4[0];
                                    this.textBoxG2_2_3_2.Text = list4[1];
                                    this.textBoxG2_2_3_3.Text = list4[2];
                                    this.textBoxG2_2_3_4.Text = list4[3];
                                    this.textBoxG2_2_3_5.Text = list4[4];
                                    this.textBoxG2_2_3_6.Text = list4[5];
                                    this.textBoxG2_2_3_7.Text = list4[6];
                                    this.textBoxG2_2_3_8.Text = list4[7];
                                    this.textBoxG2_2_3_9.Text = list4[8];
                                    break;

                                case "g_two_2_4.xml":
                                    this.textBoxG2_2_4_1.Text = list4[0];
                                    this.textBoxG2_2_4_2.Text = list4[1];
                                    this.textBoxG2_2_4_3.Text = list4[2];
                                    this.textBoxG2_2_4_4.Text = list4[3];
                                    this.textBoxG2_2_4_5.Text = list4[4];
                                    this.textBoxG2_2_4_6.Text = list4[5];
                                    this.textBoxG2_2_4_7.Text = list4[6];
                                    this.textBoxG2_2_4_8.Text = list4[7];
                                    this.textBoxG2_2_4_9.Text = list4[8];
                                    break;

                                case "g_two_2_5.xml":
                                    this.textBoxG2_2_5_1.Text = list4[0];
                                    this.textBoxG2_2_5_2.Text = list4[1];
                                    this.textBoxG2_2_5_3.Text = list4[2];
                                    this.textBoxG2_2_5_4.Text = list4[3];
                                    this.textBoxG2_2_5_5.Text = list4[4];
                                    this.textBoxG2_2_5_6.Text = list4[5];
                                    this.textBoxG2_2_5_7.Text = list4[6];
                                    this.textBoxG2_2_5_8.Text = list4[7];
                                    this.textBoxG2_2_5_9.Text = list4[8];
                                    break;

                                case "g_two_2_6.xml":
                                    this.textBoxG2_2_6_1.Text = list4[0];
                                    this.textBoxG2_2_6_2.Text = list4[1];
                                    this.textBoxG2_2_6_3.Text = list4[2];
                                    this.textBoxG2_2_6_4.Text = list4[3];
                                    this.textBoxG2_2_6_5.Text = list4[4];
                                    this.textBoxG2_2_6_6.Text = list4[5];
                                    this.textBoxG2_2_6_7.Text = list4[6];
                                    this.textBoxG2_2_6_8.Text = list4[7];
                                    this.textBoxG2_2_6_9.Text = list4[8];
                                    break;

                                case "g_three_1.xml":
                                    this.textBoxG3_1_1.Text = list4[0];
                                    break;

                                case "g_three_2.xml":
                                    this.textBoxG3_2_1.Text = list4[0];
                                    break;

                                case "g_four_1.xml":
                                    this.textBoxG4_1_1.Text = list4[0];
                                    break;

                                case "g_four_2.xml":
                                    this.controlGT4_2_1_1.pub_LoadXML(list4[0]);
                                    this.controlGT4_2_1_2.pub_LoadXML(list4[1]);
                                    this.controlGT4_2_1_3.pub_LoadXML(list4[2]);
                                    this.controlGT4_2_1_4.pub_LoadXML(list4[3]);
                                    this.controlGT4_2_2_1.pub_LoadXML(list4[4]);
                                    this.controlGT4_2_2_2.pub_LoadXML(list4[5]);
                                    this.controlGT4_2_2_3.pub_LoadXML(list4[6]);
                                    this.controlGT4_2_2_4.pub_LoadXML(list4[7]);
                                    this.controlGT4_2_3_1.pub_LoadXML(list4[8]);
                                    this.controlGT4_2_3_2.pub_LoadXML(list4[9]);
                                    this.controlGT4_2_3_3.pub_LoadXML(list4[10]);
                                    this.controlGT4_2_3_4.pub_LoadXML(list4[11]);
                                    break;

                                case "g_five_1.xml":
                                    this.textBoxG5_1_1.Text = list4[0];
                                    break;

                                case "g_six_1.xml":
                                    this.textBoxG6_1_1.Text = list4[0];
                                    break;

                                case "g_seven_1_1.xml":
                                    this.textBoxG7_1_1_1.Text = list4[0];
                                    this.textBoxG7_1_1_2.Text = list4[1];
                                    this.textBoxG7_1_1_3.Text = list4[2];
                                    this.textBoxG7_1_1_4.Text = list4[3];
                                    this.textBoxG7_1_1_5.Text = list4[4];
                                    this.textBoxG7_1_1_6.Text = list4[5];
                                    this.textBoxG7_1_1_7.Text = list4[6];
                                    this.textBoxG7_1_1_8.Text = list4[7];
                                    this.textBoxG7_1_1_9.Text = list4[8];
                                    break;

                                case "g_seven_1_2.xml":
                                    this.textBoxG7_1_2_1.Text = list4[0];
                                    this.textBoxG7_1_2_2.Text = list4[1];
                                    this.textBoxG7_1_2_3.Text = list4[2];
                                    this.textBoxG7_1_2_4.Text = list4[3];
                                    this.textBoxG7_1_2_5.Text = list4[4];
                                    this.textBoxG7_1_2_6.Text = list4[5];
                                    this.textBoxG7_1_2_7.Text = list4[6];
                                    this.textBoxG7_1_2_8.Text = list4[7];
                                    this.textBoxG7_1_2_9.Text = list4[8];
                                    this.textBoxG7_1_2_10.Text = list4[9];
                                    this.textBoxG7_1_2_11.Text = list4[10];
                                    this.textBoxG7_1_2_12.Text = list4[11];
                                    this.textBoxG7_1_2_13.Text = list4[12];
                                    this.textBoxG7_1_2_14.Text = list4[13];
                                    this.textBoxG7_1_2_15.Text = list4[14];
                                    this.textBoxG7_1_2_16.Text = list4[15];
                                    break;

                                case "g_seven_1_3.xml":
                                    this.textBoxG7_1_3_1.Text = list4[0];
                                    this.textBoxG7_1_3_2.Text = list4[1];
                                    this.textBoxG7_1_3_3.Text = list4[2];
                                    this.textBoxG7_1_3_4.Text = list4[3];
                                    this.textBoxG7_1_3_5.Text = list4[4];
                                    this.textBoxG7_1_3_6.Text = list4[5];
                                    this.textBoxG7_1_3_7.Text = list4[6];
                                    this.textBoxG7_1_3_8.Text = list4[7];
                                    this.textBoxG7_1_3_9.Text = list4[8];
                                    break;

                                case "g_seven_2.xml":
                                    this.textBoxG7_2_1.Text = list4[0];
                                    this.textBoxG7_2_2.Text = list4[1];
                                    this.textBoxG7_2_3.Text = list4[2];
                                    break;
                            }
                        }
                    }
                    if (File.Exists("temp/UA/calculationAnswer.xml"))
                    {
                        Dictionary<string, List<string>> dictionary2 = new Dictionary<string, List<string>>();
                        document = new XmlDocument();
                        document.Load("temp/UA/calculationAnswer.xml");
                        foreach (XmlNode node in document.ChildNodes)
                        {
                            foreach (XmlNode node2 in node.ChildNodes)
                            {
                                str = node2.Attributes["name"].Value;
                                list2 = new List<string>();
                                foreach (XmlNode node3 in node2.FirstChild.ChildNodes)
                                {
                                    list2.Add(node3.InnerText);
                                }
                                dictionary2[str] = list2;
                            }
                        }
                        list3 = new List<string>();
                        foreach (string str2 in dictionary2.Keys)
                        {
                            list3.Add(str2);
                        }
                        foreach (string str4 in list3)
                        {
                            list4 = dictionary2[str4];
                            switch (str4)
                            {
                                case "c1.xml":
                                {
                                    this.textBoxC1_1_1.Text = list4[0];
                                    this.TextBoxC1_2_1.Text = list4[1];
                                    this.TextBoxC1_2_2.Text = list4[2];
                                    this.TextBoxC1_2_3.Text = list4[3];
                                    this.TextBoxC1_2_4.Text = list4[4];
                                    this.TextBoxC1_2_5.Text = list4[5];
                                    this.textBoxC1_3_1_1.Text = list4[6];
                                    this.textBoxC1_3_1_2.Text = list4[7];
                                    this.textBoxC1_3_1_3.Text = list4[8];
                                    this.textBoxC1_3_1_4.Text = list4[9];
                                    this.textBoxC1_3_1_5.Text = list4[10];
                                    this.textBoxC1_3_1_6.Text = list4[11];
                                    this.textBoxC1_3_1_7.Text = list4[12];
                                    this.textBoxC1_3_1_8.Text = list4[13];
                                    this.textBoxC1_3_1_9.Text = list4[14];
                                    this.textBoxC1_3_2_1.Text = list4[15];
                                    this.textBoxC1_3_2_2.Text = list4[0x10];
                                    this.textBoxC1_3_2_3.Text = list4[0x11];
                                    this.textBoxC1_3_2_4.Text = list4[0x12];
                                    this.textBoxC1_3_2_5.Text = list4[0x13];
                                    this.textBoxC1_3_2_6.Text = list4[20];
                                    this.textBoxC1_3_2_7.Text = list4[0x15];
                                    this.textBoxC1_3_2_8.Text = list4[0x16];
                                    this.textBoxC1_3_2_9.Text = list4[0x17];
                                    this.textBoxC1_3_3_1.Text = list4[0x18];
                                    this.textBoxC1_3_3_2.Text = list4[0x19];
                                    this.textBoxC1_3_3_3.Text = list4[0x1a];
                                    this.textBoxC1_3_3_4.Text = list4[0x1b];
                                    this.textBoxC1_3_3_5.Text = list4[0x1c];
                                    this.textBoxC1_3_3_6.Text = list4[0x1d];
                                    this.textBoxC1_3_3_7.Text = list4[30];
                                    this.textBoxC1_3_3_8.Text = list4[0x1f];
                                    this.textBoxC1_3_3_9.Text = list4[0x20];
                                    this.textBoxC1_3_4_1.Text = list4[0x21];
                                    this.textBoxC1_3_4_2.Text = list4[0x22];
                                    this.textBoxC1_3_4_3.Text = list4[0x23];
                                    this.textBoxC1_3_4_4.Text = list4[0x24];
                                    this.textBoxC1_3_4_5.Text = list4[0x25];
                                    this.textBoxC1_3_4_6.Text = list4[0x26];
                                    this.textBoxC1_3_4_7.Text = list4[0x27];
                                    this.textBoxC1_3_4_8.Text = list4[40];
                                    this.textBoxC1_3_4_9.Text = list4[0x29];
                                    continue;
                                }
                                case "c2.xml":

                                    this.textBoxC2_1_1.Text = list4[0];
                                    this.textBoxC2_1_2.Text = list4[1];
                                    this.textBoxC2_1_3.Text = list4[2];
                                    this.textBoxC2_1_4.Text = list4[3];
                                    this.textBoxC2_1_5.Text = list4[4];
                                    this.textBoxC2_1_6.Text = list4[5];
                                    this.textBoxC2_1_7.Text = list4[6];
                                    this.textBoxC2_1_8.Text = list4[7];
                                    this.textBoxC2_1_9.Text = list4[8];
                                    this.textBoxC2_1_10.Text = list4[9];
                                    this.textBoxC2_1_11.Text = list4[10];
                                    this.textBoxC2_1_12.Text = list4[11];
                                    this.textBoxC2_1_13.Text = list4[12];
                                    this.textBoxC2_1_14.Text = list4[13];
                                    this.textBoxC2_1_15.Text = list4[14];
                                    this.textBoxC2_1_16.Text = list4[15];
                                    this.textBoxC2_1_17.Text = list4[0x10];
                                    this.textBoxC2_1_18.Text = list4[0x11];
                                    this.textBoxC2_1_19.Text = list4[0x12];
                                    this.textBoxC2_1_20.Text = list4[0x13];
                                    this.textBoxC2_2_1.Text = list4[20];
                                    this.textBoxC2_2_2.Text = list4[0x15];
                                    if (list4[0x16] != "true")
                                    {
                                        break;
                                    }
                                    this.radioButtonC2_2_1.Checked = true;
                                    goto Label_1D1E;

                                case "c3.xml":
                                {
                                    this.controlC3_1_4.pub_LoadXML(list4[0]);
                                    this.controlC3_1_5.pub_LoadXML(list4[1]);
                                    this.controlC3_1_6.pub_LoadXML(list4[2]);
                                    this.controlC3_2_1_3.pub_LoadXML(list4[3]);
                                    this.controlC3_2_1_4.pub_LoadXML(list4[4]);
                                    this.controlC3_2_1_5.pub_LoadXML(list4[5]);
                                    this.controlC3_2_2_3.pub_LoadXML(list4[6]);
                                    this.controlC3_2_2_4.pub_LoadXML(list4[7]);
                                    this.controlC3_2_2_5.pub_LoadXML(list4[8]);
                                    this.controlC3_2_3_4.pub_LoadXML(list4[9]);
                                    this.controlC3_2_3_5.pub_LoadXML(list4[10]);
                                    this.controlC3_2_3_6.pub_LoadXML(list4[11]);
                                    this.controlC3_3_1.pub_LoadXML(list4[12]);
                                    this.controlC3_3_2.pub_LoadXML(list4[13]);
                                    this.controlC3_3_3.pub_LoadXML(list4[14]);
                                    this.controlC3_3_4.pub_LoadXML(list4[15]);
                                    this.controlC3_3_5.pub_LoadXML(list4[0x10]);
                                    this.controlC3_3_6.pub_LoadXML(list4[0x11]);
                                    this.controlC3_3_7.pub_LoadXML(list4[0x12]);
                                    this.controlC3_3_8.pub_LoadXML(list4[0x13]);
                                    this.controlC3_3_9.pub_LoadXML(list4[20]);
                                    this.controlC3_4_1.pub_LoadXML(list4[0x15]);
                                    this.controlC3_4_2.pub_LoadXML(list4[0x16]);
                                    this.controlC3_4_3.pub_LoadXML(list4[0x17]);
                                    continue;
                                }
                                case "c4.xml":
                                {
                                    this.textBoxC4_1_1.Text = list4[0];
                                    this.textBoxC4_1_2.Text = list4[1];
                                    this.textBoxC4_1_3.Text = list4[2];
                                    this.textBoxC4_1_4.Text = list4[3];
                                    this.textBoxC4_1_5.Text = list4[4];
                                    this.textBoxC4_1_6.Text = list4[5];
                                    this.textBoxC4_1_7.Text = list4[6];
                                    this.textBoxC4_1_8.Text = list4[7];
                                    this.textBoxC4_1_9.Text = list4[8];
                                    this.controlC4_2_4.pub_LoadXML(list4[9]);
                                    this.controlC4_2_5.pub_LoadXML(list4[10]);
                                    this.controlC4_2_6.pub_LoadXML(list4[11]);
                                    this.controlC4_3_13.pub_LoadXML(list4[12]);
                                    this.controlC4_3_14.pub_LoadXML(list4[13]);
                                    this.controlC4_3_15.pub_LoadXML(list4[14]);
                                    this.controlC4_3_16.pub_LoadXML(list4[15]);
                                    this.controlC4_3_17.pub_LoadXML(list4[0x10]);
                                    this.controlC4_3_18.pub_LoadXML(list4[0x11]);
                                    this.controlC4_3_19.pub_LoadXML(list4[0x12]);
                                    this.controlC4_3_20.pub_LoadXML(list4[0x13]);
                                    this.controlC4_3_21.pub_LoadXML(list4[20]);
                                    this.controlC4_4_5.pub_LoadXML(list4[0x15]);
                                    this.controlC4_4_6.pub_LoadXML(list4[0x16]);
                                    this.controlC4_4_7.pub_LoadXML(list4[0x17]);
                                    continue;
                                }
                                case "c5.xml":
                                {
                                    this.controlC5_1_4.pub_LoadXML(list4[0]);
                                    this.controlC5_1_5.pub_LoadXML(list4[1]);
                                    this.controlC5_1_6.pub_LoadXML(list4[2]);
                                    this.controlC5_2_7.pub_LoadXML(list4[3]);
                                    this.controlC5_2_8.pub_LoadXML(list4[4]);
                                    this.controlC5_2_9.pub_LoadXML(list4[5]);
                                    this.controlC5_2_10.pub_LoadXML(list4[6]);
                                    this.controlC5_2_11.pub_LoadXML(list4[7]);
                                    this.controlC5_2_12.pub_LoadXML(list4[8]);
                                    this.controlC5_2_13.pub_LoadXML(list4[9]);
                                    this.controlC5_2_14.pub_LoadXML(list4[10]);
                                    this.controlC5_2_15.pub_LoadXML(list4[11]);
                                    this.controlC5_3_1.pub_LoadXML(list4[12]);
                                    this.controlC5_3_2.pub_LoadXML(list4[13]);
                                    this.controlC5_3_3.pub_LoadXML(list4[14]);
                                    this.controlC5_3_4.pub_LoadXML(list4[15]);
                                    this.controlC5_3_5.pub_LoadXML(list4[0x10]);
                                    this.controlC5_3_6.pub_LoadXML(list4[0x11]);
                                    this.controlC5_3_7.pub_LoadXML(list4[0x12]);
                                    this.controlC5_3_8.pub_LoadXML(list4[0x13]);
                                    this.controlC5_3_9.pub_LoadXML(list4[20]);
                                    continue;
                                }
                                case "c6.xml":
                                {
                                    this.textBoxC6_1_1.Text = list4[0];
                                    this.textBoxC6_1_2.Text = list4[1];
                                    this.controlC6_2_3.pub_LoadXML(list4[2]);
                                    this.controlC6_2_4.pub_LoadXML(list4[3]);
                                    this.controlC6_2_5.pub_LoadXML(list4[4]);
                                    this.controlC6_2_6.pub_LoadXML(list4[5]);
                                    this.controlC6_2_7.pub_LoadXML(list4[6]);
                                    this.controlC6_2_8.pub_LoadXML(list4[7]);
                                    this.controlC6_2_9.pub_LoadXML(list4[8]);
                                    this.controlC6_2_10.pub_LoadXML(list4[9]);
                                    this.controlC6_2_11.pub_LoadXML(list4[10]);
                                    this.controlC6_2_12.pub_LoadXML(list4[11]);
                                    this.controlC6_3_2.pub_LoadXML(list4[12]);
                                    this.controlC6_3_3.pub_LoadXML(list4[13]);
                                    this.controlC6_3_4.pub_LoadXML(list4[14]);
                                    this.controlC6_3_5.pub_LoadXML(list4[15]);
                                    this.controlC6_3_6.pub_LoadXML(list4[0x10]);
                                    continue;
                                }
                                case "c7.xml":
                                {
                                    this.textBoxC7_1_1.Text = list4[0];
                                    this.textBoxC7_1_2.Text = list4[1];
                                    this.textBoxC7_1_3.Text = list4[2];
                                    this.textBoxC7_1_4.Text = list4[3];
                                    this.textBoxC7_1_5.Text = list4[4];
                                    this.textBoxC7_1_6.Text = list4[5];
                                    this.textBoxC7_1_7.Text = list4[6];
                                    this.textBoxC7_1_8.Text = list4[7];
                                    this.textBoxC7_1_9.Text = list4[8];
                                    this.textBoxC7_2_1.Text = list4[9];
                                    this.textBoxC7_2_2.Text = list4[10];
                                    this.textBoxC7_2_3.Text = list4[11];
                                    this.textBoxC7_2_4.Text = list4[12];
                                    this.textBoxC7_3_1.Text = list4[13];
                                    this.textBoxC7_3_2.Text = list4[14];
                                    this.textBoxC7_3_3.Text = list4[15];
                                    this.textBoxC7_3_4.Text = list4[0x10];
                                    this.textBoxC7_3_5.Text = list4[0x11];
                                    this.textBoxC7_3_6.Text = list4[0x12];
                                    continue;
                                }
                                case "c8.xml":
                                {
                                    this.textBoxC8_1_1.Text = list4[0];
                                    this.textBoxC8_1_2.Text = list4[1];
                                    this.textBoxC8_1_3.Text = list4[2];
                                    this.textBoxC8_1_4.Text = list4[3];
                                    this.textBoxC8_1_5.Text = list4[4];
                                    this.textBoxC8_1_6.Text = list4[5];
                                    this.textBoxC8_1_7.Text = list4[6];
                                    this.textBoxC8_1_8.Text = list4[7];
                                    this.textBoxC8_1_9.Text = list4[8];
                                    this.textBoxC8_2_1.Text = list4[9];
                                    this.textBoxC8_2_2.Text = list4[10];
                                    this.textBoxC8_2_3.Text = list4[11];
                                    this.textBoxC8_2_4.Text = list4[12];
                                    this.textBoxC8_2_5.Text = list4[13];
                                    this.textBoxC8_2_6.Text = list4[14];
                                    this.textBoxC8_3_1.Text = list4[15];
                                    this.textBoxC8_3_2.Text = list4[0x10];
                                    this.textBoxC8_3_3.Text = list4[0x11];
                                    this.textBoxC8_3_4.Text = list4[0x12];
                                    this.textBoxC8_3_5.Text = list4[0x13];
                                    this.textBoxC8_3_6.Text = list4[20];
                                    continue;
                                }
                                case "c9.xml":
                                    this.textBoxC9_1_1.Text = list4[0];
                                    if (list4[1] != "false")
                                    {
                                        goto Label_28F1;
                                    }
                                    this.radiobuttonC9_2_1.Checked = true;
                                    goto Label_291B;

                                case "c10.xml":
                                {
                                    this.comboBoxC10_1_1.SelectedIndex = int.Parse(list4[0]);
                                    this.textBoxC10_1_1.Text = list4[1];
                                    this.comboBoxC10_2_1.SelectedIndex = int.Parse(list4[2]);
                                    this.textBoxC10_2_1.Text = list4[3];
                                    this.comboBoxC10_2_2.SelectedIndex = int.Parse(list4[4]);
                                    this.comboBoxC10_2_3.SelectedIndex = int.Parse(list4[5]);
                                    this.textBoxC10_2_2.Text = list4[6];
                                    this.textBoxC10_2_3.Text = list4[7];
                                    this.textBoxC10_2_4.Text = list4[8];
                                    this.textBoxC10_2_5.Text = list4[9];
                                    this.textBoxC10_2_6.Text = list4[10];
                                    this.comboBoxC10_3_1.SelectedIndex = int.Parse(list4[11]);
                                    this.textBoxC10_3_1.Text = list4[12];
                                    this.textBoxC10_3_2.Text = list4[13];
                                    this.textBoxC10_3_3.Text = list4[14];
                                    this.textBoxC10_3_4.Text = list4[15];
                                    this.textBoxC10_3_5.Text = list4[0x10];
                                    continue;
                                }
                                case "c11.xml":
                                {
                                    this.comboBoxC11_1_1.SelectedIndex = int.Parse(list4[0]);
                                    this.textBoxC11_1_1.Text = list4[1];
                                    this.comboBoxC11_1_2.SelectedIndex = int.Parse(list4[2]);
                                    this.textBoxC11_1_2.Text = list4[3];
                                    this.comboBoxC11_2_1.SelectedIndex = int.Parse(list4[4]);
                                    this.textBoxC11_2_1.Text = list4[5];
                                    this.comboBoxC11_2_2.SelectedIndex = int.Parse(list4[6]);
                                    this.textBoxC11_2_2.Text = list4[7];
                                    this.textBoxC11_2_3.Text = list4[8];
                                    this.textBoxC11_2_4.Text = list4[9];
                                    this.textBoxC11_2_5.Text = list4[10];
                                    this.comboBoxC11_3_1.SelectedIndex = int.Parse(list4[11]);
                                    this.textBoxC11_3_1.Text = list4[12];
                                    this.textBoxC11_3_2.Text = list4[13];
                                    this.comboBoxC11_3_2.SelectedIndex = int.Parse(list4[14]);
                                    this.textBoxC11_3_3.Text = list4[15];
                                    this.textBoxC11_3_4.Text = list4[0x10];
                                    this.textBoxC11_3_5.Text = list4[0x11];
                                    continue;
                                }
                                default:
                                {
                                    continue;
                                }
                            }
                            if (list4[0x16] == "false")
                            {
                                this.radioButtonC2_2_2.Checked = true;
                            }
                        Label_1D1E:
                            this.controlC2_3_1.pub_LoadXML(list4[0x17]);
                            this.controlC2_3_2.pub_LoadXML(list4[0x18]);
                            this.controlC2_3_3.pub_LoadXML(list4[0x19]);
                            this.controlC2_3_4.pub_LoadXML(list4[0x1a]);
                            this.controlC2_3_5.pub_LoadXML(list4[0x1b]);
                            this.controlC2_3_6.pub_LoadXML(list4[0x1c]);
                            this.controlC2_3_7.pub_LoadXML(list4[0x1d]);
                            this.controlC2_3_8.pub_LoadXML(list4[30]);
                            this.controlC2_3_9.pub_LoadXML(list4[0x1f]);
                            this.controlC2_3_10.pub_LoadXML(list4[0x20]);
                            this.controlC2_3_11.pub_LoadXML(list4[0x21]);
                            this.controlC2_3_12.pub_LoadXML(list4[0x22]);
                            this.controlC2_4_1.pub_LoadXML(list4[0x23]);
                            this.controlC2_4_2.pub_LoadXML(list4[0x24]);
                            this.controlC2_4_3.pub_LoadXML(list4[0x25]);
                            this.controlC2_4_4.pub_LoadXML(list4[0x26]);
                            continue;
                        Label_28F1:
                            if (list4[1] == "true")
                            {
                                this.radiobuttonC9_2_2.Checked = true;
                            }
                        Label_291B:
                            this.textBoxC9_3_1.Text = list4[2];
                            this.textBoxC9_3_2.Text = list4[3];
                            this.textBoxC9_3_3.Text = list4[4];
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("试题还原失败！");
                }
            }
            string path = "temp/generate/total.xml";
            FileStream w = new FileStream(path, FileMode.Create);
            XmlTextWriter writer2 = new XmlTextWriter(w, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            writer2.WriteStartDocument();
            writer2.WriteStartElement("Info");
            writer2.WriteAttributeString("guid", this.guid);
            writer2.WriteStartElement("choice");
            for (num = 1; num <= this.ChoicegString.Count; num++)
            {
                writer2.WriteStartElement("qid");
                writer2.WriteAttributeString("id", num.ToString());
                writer2.WriteElementString("name", this.ChoicegString[num - 1]);
                writer2.WriteEndElement();
            }
            writer2.WriteEndElement();
            writer2.WriteStartElement("gapfilling");
            for (num = 1; num <= this.gapfillingString.Count; num++)
            {
                writer2.WriteStartElement("qid");
                writer2.WriteAttributeString("id", num.ToString());
                writer2.WriteElementString("name", this.gapfillingString[num - 1]);
                writer2.WriteEndElement();
            }
            writer2.WriteEndElement();
            writer2.WriteStartElement("calculation");
            for (num = 1; num <= this.calculationString.Count; num++)
            {
                writer2.WriteStartElement("qid");
                writer2.WriteAttributeString("id", num.ToString());
                writer2.WriteElementString("name", this.calculationString[num - 1]);
                writer2.WriteEndElement();
            }
            writer2.WriteEndElement();
            writer2.WriteEndElement();
            writer2.WriteEndDocument();
            writer2.Flush();
            writer2.Close();
        }

        private void anotherinitTextBox(TextBox textBox)
        {
            textBox.Font = new Font("宋体", 8f, textBox.Font.Style);
            textBox.Size = new Size(15, 15);
            textBox.Anchor = AnchorStyles.Bottom;
        }

        private void AnswerUpload()
        {
            try
            {
                this.ChoiceAnswerJudge(null, null);
                this.ChoiceSave(null, null);
                this.GapfillingSave(null, null);
                this.CalculationSave(null, null);
                FileService service = new FileService();
                string filePath = string.Concat(new object[] { StudentModel.examCode, @"\", StudentModel.studentNumber, @"\Answer.zip" });
                service.studentFileDelete(filePath, "~!{#$@cdf3}");
                string dirPath = "./temp/UA";
                string uriPath = string.Concat(new object[] { StudentModel.examCode, "/", StudentModel.studentNumber, "/Answer.zip" });
                string filepath = "./upload/Answer.zip";
                SupportTools.FilePathIsExist(filepath);
                Zip.CompressDirectory(dirPath, filepath, 9, 0x400);
                if (this.mark == 0)
                {
                    UploadAndDownload.MakeDir(StudentModel.examCode.ToString());
                    UploadAndDownload.MakeDir(StudentModel.examCode.ToString() + "/" + StudentModel.studentNumber);
                    this.mark++;
                }
                UploadAndDownload.Upload(uriPath, filepath);
            }
            catch (Exception)
            {
                if (this.intervalTimer.Tag.ToString() == "off")
                {
                    this.intervalTimer.Start();
                    this.intervalTimer.Tag = "on";
                }
                else
                {
                    MessageBox.Show("网络故障，上传答案失败！请联系监考老师换机考试");
                }
            }
        }

        private void AnswerUpload(object sender, EventArgs e)
        {
            try
            {
                //FileService service = new FileService();
                //string filePath = string.Concat(new object[] { StudentModel.examCode, @"\", StudentModel.studentNumber, @"\Answer.zip" });
                //service.studentFileDelete(filePath, "~!{#$@cdf3}");
                //string dirPath = "./temp/UA";
                //string uriPath = string.Concat(new object[] { StudentModel.examCode, "/", StudentModel.studentNumber, "/Answer.zip" });
                //string filepath = "./upload/Answer.zip";
                //SupportTools.FilePathIsExist(filepath);
                //Zip.CompressDirectory(dirPath, filepath, 9, 0x400);
                //if (this.mark == 0)
                //{
                //    UploadAndDownload.MakeDir(StudentModel.examCode.ToString());
                //    UploadAndDownload.MakeDir(StudentModel.examCode + "/" + StudentModel.studentNumber);
                //    this.mark++;
                //}
                //UploadAndDownload.Upload(uriPath, filepath);
                //StudentService service2 = new StudentService();
                if (true )// service2.updateStudent_grade(StudentModel.studentNumber, this.totalScore, "~!{#$@cdf3}") != this.totalScore)
                {
                    this.textbox_grade.Text = this.totalScore.ToString();
                    this.label_time.Text = "成绩插入数据库失败!";
                    this.isReSubmit = true;
                }
                else
                {
                    this.textbox_grade.Text = this.totalScore.ToString();
                    this.label_time.Text = "试卷已成功提交！";
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Tick += new EventHandler(this.closeChengxuTime_Tick);
                    timer.Interval = 0x3e8;
                    timer.Start();
                    MessageBox.Show("试卷已经成功提交！你的分数是" + this.textbox_grade.Text + "分 \r\n 程序5分钟后会自动关闭");
                    this.btn_isSubmit.Enabled = false;
                }
            }
            catch (Exception)
            {
                this.isReSubmit = true;
                MessageBox.Show("成绩提交失败，请联系管理员");
            }
            finally
            {
                this.show_time.Stop();
                this.timersTimer.Enabled = false;
            }
        }

        private void assignCalculationControls(List<string> calculationTest)
        {
            this.labelC = new Label();
            this.labelC.Font = new Font("宋体", 30f);
            this.labelC.AutoSize = true;
            this.labelC.Text = "三、计算题(共55分)";
            this.flowLayoutPanel1.Controls.Add(this.labelC);
            this.flowLayoutPanel1.SetFlowBreak(this.labelC, true);
            for (int i = 0; i < calculationTest.Count; i++)
            {
                string str = calculationTest[i];
                if (str.Equals("c1.xml"))
                {
                    this.controlC1 = new NuGenEQML();
                    new C1().C1Generate(this.controlC1, (i + 1) + ".");
                    this.flowLayoutPanel1.Controls.Add(this.controlC1);
                    this.flowLayoutPanel1.SetFlowBreak(this.controlC1, true);
                    this.labelC1_1 = new Label();
                    this.initScoreLabel(this.labelC1_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_1);
                    this.labelC1_1_1 = new Label();
                    this.labelC1_1_2 = new Label();
                    this.textBoxC1_1_1 = new TextBox();
                    this.initTextBox(this.textBoxC1_1_1);
                    this.initLabel(this.labelC1_1_1);
                    this.initLabel(this.labelC1_1_2);
                    this.labelC1_1_1.Text = "   (1)此向量组的秩为(";
                    this.labelC1_1_2.Text = ")；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_1_2);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_1_2, true);
                    this.labelC1_2 = new Label();
                    this.initScoreLabel(this.labelC1_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2);
                    this.labelC1_2_1 = new Label();
                    this.labelC1_2_2 = new Label();
                    this.labelC1_2_3 = new Label();
                    this.labelC1_2_4 = new Label();
                    this.labelC1_2_5 = new Label();
                    this.labelC1_2_6 = new Label();
                    this.labelC1_2_7 = new Label();
                    this.labelC1_2_8 = new Label();
                    this.labelC1_2_9 = new Label();
                    this.labelC1_2_10 = new Label();
                    this.labelC1_2_11 = new Label();
                    this.labelC1_2_12 = new Label();
                    this.initLabel(this.labelC1_2_1);
                    this.labelC1_2_2.Size = new Size(10, 0x19);
                    this.initLabel(this.labelC1_2_3);
                    this.labelC1_2_4.Size = new Size(10, 0x19);
                    this.initLabel(this.labelC1_2_5);
                    this.labelC1_2_6.Size = new Size(10, 0x19);
                    this.initLabel(this.labelC1_2_7);
                    this.labelC1_2_8.Size = new Size(10, 0x19);
                    this.initLabel(this.labelC1_2_9);
                    this.labelC1_2_10.Size = new Size(10, 0x19);
                    this.initLabel(this.labelC1_2_11);
                    this.initLabel(this.labelC1_2_12);
                    this.TextBoxC1_2_1 = new TextBox();
                    this.TextBoxC1_2_2 = new TextBox();
                    this.TextBoxC1_2_3 = new TextBox();
                    this.TextBoxC1_2_4 = new TextBox();
                    this.TextBoxC1_2_5 = new TextBox();
                    this.anotherinitTextBox(this.TextBoxC1_2_1);
                    this.anotherinitTextBox(this.TextBoxC1_2_2);
                    this.anotherinitTextBox(this.TextBoxC1_2_3);
                    this.anotherinitTextBox(this.TextBoxC1_2_4);
                    this.anotherinitTextBox(this.TextBoxC1_2_5);
                    this.labelC1_2_1.Text = "   (2)此向量组的一个极大线性无关组为";
                    this.labelC1_2_2.Text = "α";
                    this.labelC1_2_3.Text = "，";
                    this.labelC1_2_4.Text = "α";
                    this.labelC1_2_5.Text = "，";
                    this.labelC1_2_6.Text = "α";
                    this.labelC1_2_7.Text = "，";
                    this.labelC1_2_8.Text = "α";
                    this.labelC1_2_9.Text = "，";
                    this.labelC1_2_10.Text = "α";
                    this.labelC1_2_11.Text = "，";
                    this.labelC1_2_12.Text = "（多余的空格不填)；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_2);
                    this.flowLayoutPanel1.Controls.Add(this.TextBoxC1_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_4);
                    this.flowLayoutPanel1.Controls.Add(this.TextBoxC1_2_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_6);
                    this.flowLayoutPanel1.Controls.Add(this.TextBoxC1_2_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_7);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_8);
                    this.flowLayoutPanel1.Controls.Add(this.TextBoxC1_2_4);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_9);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_10);
                    this.flowLayoutPanel1.Controls.Add(this.TextBoxC1_2_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_11);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_2_12);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_2_12, true);
                    this.labelC1_3 = new Label();
                    this.initScoreLabel(this.labelC1_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3);
                    this.labelC1_3_1 = new Label();
                    this.initLabel(this.labelC1_3_1);
                    this.labelC1_3_1.Text = "   (3)其它向量用该极大线性无关组线性表出的表达式为:(多余的空格不填)；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_3_1, true);
                    this.labelC1_3_1_0 = new Label();
                    this.labelC1_3_1_1 = new Label();
                    this.labelC1_3_1_2 = new Label();
                    this.labelC1_3_1_3 = new Label();
                    this.labelC1_3_1_4 = new Label();
                    this.labelC1_3_1_5 = new Label();
                    this.labelC1_3_1_6 = new Label();
                    this.labelC1_3_1_7 = new Label();
                    this.labelC1_3_1_8 = new Label();
                    this.labelC1_3_1_9 = new Label();
                    this.labelC1_3_1_10 = new Label();
                    this.initLabel(this.labelC1_3_1_0);
                    this.labelC1_3_1_1.Size = new Size(10, 0x19);
                    this.labelC1_3_1_1.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_1_2);
                    this.labelC1_3_1_3.Size = new Size(10, 0x19);
                    this.labelC1_3_1_3.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_1_4);
                    this.labelC1_3_1_5.Size = new Size(10, 0x19);
                    this.labelC1_3_1_5.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_1_6);
                    this.labelC1_3_1_7.Size = new Size(10, 0x19);
                    this.labelC1_3_1_7.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_1_8);
                    this.labelC1_3_1_9.Size = new Size(10, 0x19);
                    this.labelC1_3_1_9.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_1_10);
                    this.textBoxC1_3_1_1 = new TextBox();
                    this.textBoxC1_3_1_2 = new TextBox();
                    this.textBoxC1_3_1_3 = new TextBox();
                    this.textBoxC1_3_1_4 = new TextBox();
                    this.textBoxC1_3_1_5 = new TextBox();
                    this.textBoxC1_3_1_6 = new TextBox();
                    this.textBoxC1_3_1_7 = new TextBox();
                    this.textBoxC1_3_1_8 = new TextBox();
                    this.textBoxC1_3_1_9 = new TextBox();
                    this.anotherinitTextBox(this.textBoxC1_3_1_1);
                    this.initTextBox(this.textBoxC1_3_1_2);
                    this.anotherinitTextBox(this.textBoxC1_3_1_3);
                    this.initTextBox(this.textBoxC1_3_1_4);
                    this.anotherinitTextBox(this.textBoxC1_3_1_5);
                    this.initTextBox(this.textBoxC1_3_1_6);
                    this.anotherinitTextBox(this.textBoxC1_3_1_7);
                    this.initTextBox(this.textBoxC1_3_1_8);
                    this.anotherinitTextBox(this.textBoxC1_3_1_9);
                    this.labelC1_3_1_0.Text = "   ";
                    this.labelC1_3_1_1.Text = "α";
                    this.labelC1_3_1_2.Text = "=";
                    this.labelC1_3_1_3.Text = "α";
                    this.labelC1_3_1_4.Text = "+";
                    this.labelC1_3_1_5.Text = "α";
                    this.labelC1_3_1_6.Text = "+";
                    this.labelC1_3_1_7.Text = "α";
                    this.labelC1_3_1_8.Text = "+";
                    this.labelC1_3_1_9.Text = "α";
                    this.labelC1_3_1_10.Text = "；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_0);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_2);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_3);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_4);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_4);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_5);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_6);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_6);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_7);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_7);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_8);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_8);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_9);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_1_9);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_1_10);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_3_1_10, true);
                    this.labelC1_3_2_0 = new Label();
                    this.labelC1_3_2_1 = new Label();
                    this.labelC1_3_2_2 = new Label();
                    this.labelC1_3_2_3 = new Label();
                    this.labelC1_3_2_4 = new Label();
                    this.labelC1_3_2_5 = new Label();
                    this.labelC1_3_2_6 = new Label();
                    this.labelC1_3_2_7 = new Label();
                    this.labelC1_3_2_8 = new Label();
                    this.labelC1_3_2_9 = new Label();
                    this.labelC1_3_2_10 = new Label();
                    this.initLabel(this.labelC1_3_2_0);
                    this.labelC1_3_2_1.Size = new Size(10, 0x19);
                    this.labelC1_3_2_1.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_2_2);
                    this.labelC1_3_2_3.Size = new Size(10, 0x19);
                    this.labelC1_3_2_3.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_2_4);
                    this.labelC1_3_2_5.Size = new Size(10, 0x19);
                    this.labelC1_3_2_5.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_2_6);
                    this.labelC1_3_2_7.Size = new Size(10, 0x19);
                    this.labelC1_3_2_7.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_2_8);
                    this.labelC1_3_2_9.Size = new Size(10, 0x19);
                    this.labelC1_3_2_9.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_2_10);
                    this.textBoxC1_3_2_1 = new TextBox();
                    this.textBoxC1_3_2_2 = new TextBox();
                    this.textBoxC1_3_2_3 = new TextBox();
                    this.textBoxC1_3_2_4 = new TextBox();
                    this.textBoxC1_3_2_5 = new TextBox();
                    this.textBoxC1_3_2_6 = new TextBox();
                    this.textBoxC1_3_2_7 = new TextBox();
                    this.textBoxC1_3_2_8 = new TextBox();
                    this.textBoxC1_3_2_9 = new TextBox();
                    this.anotherinitTextBox(this.textBoxC1_3_2_1);
                    this.initTextBox(this.textBoxC1_3_2_2);
                    this.anotherinitTextBox(this.textBoxC1_3_2_3);
                    this.initTextBox(this.textBoxC1_3_2_4);
                    this.anotherinitTextBox(this.textBoxC1_3_2_5);
                    this.initTextBox(this.textBoxC1_3_2_6);
                    this.anotherinitTextBox(this.textBoxC1_3_2_7);
                    this.initTextBox(this.textBoxC1_3_2_8);
                    this.anotherinitTextBox(this.textBoxC1_3_2_9);
                    this.labelC1_3_2_0.Text = "   ";
                    this.labelC1_3_2_1.Text = "α";
                    this.labelC1_3_2_2.Text = "=";
                    this.labelC1_3_2_3.Text = "α";
                    this.labelC1_3_2_4.Text = "+";
                    this.labelC1_3_2_5.Text = "α";
                    this.labelC1_3_2_6.Text = "+";
                    this.labelC1_3_2_7.Text = "α";
                    this.labelC1_3_2_8.Text = "+";
                    this.labelC1_3_2_9.Text = "α";
                    this.labelC1_3_2_10.Text = "；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_0);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_2);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_3);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_4);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_4);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_5);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_6);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_6);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_7);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_7);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_8);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_8);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_9);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_2_9);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_2_10);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_3_2_10, true);
                    this.labelC1_3_3_0 = new Label();
                    this.labelC1_3_3_1 = new Label();
                    this.labelC1_3_3_2 = new Label();
                    this.labelC1_3_3_3 = new Label();
                    this.labelC1_3_3_4 = new Label();
                    this.labelC1_3_3_5 = new Label();
                    this.labelC1_3_3_6 = new Label();
                    this.labelC1_3_3_7 = new Label();
                    this.labelC1_3_3_8 = new Label();
                    this.labelC1_3_3_9 = new Label();
                    this.labelC1_3_3_10 = new Label();
                    this.initLabel(this.labelC1_3_3_0);
                    this.labelC1_3_3_1.Size = new Size(10, 0x19);
                    this.labelC1_3_3_1.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_3_2);
                    this.labelC1_3_3_3.Size = new Size(10, 0x19);
                    this.labelC1_3_3_3.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_3_4);
                    this.labelC1_3_3_5.Size = new Size(10, 0x19);
                    this.labelC1_3_3_5.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_3_6);
                    this.labelC1_3_3_7.Size = new Size(10, 0x19);
                    this.labelC1_3_3_7.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_3_8);
                    this.labelC1_3_3_9.Size = new Size(10, 0x19);
                    this.labelC1_3_3_9.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_3_10);
                    this.textBoxC1_3_3_1 = new TextBox();
                    this.textBoxC1_3_3_2 = new TextBox();
                    this.textBoxC1_3_3_3 = new TextBox();
                    this.textBoxC1_3_3_4 = new TextBox();
                    this.textBoxC1_3_3_5 = new TextBox();
                    this.textBoxC1_3_3_6 = new TextBox();
                    this.textBoxC1_3_3_7 = new TextBox();
                    this.textBoxC1_3_3_8 = new TextBox();
                    this.textBoxC1_3_3_9 = new TextBox();
                    this.anotherinitTextBox(this.textBoxC1_3_3_1);
                    this.initTextBox(this.textBoxC1_3_3_2);
                    this.anotherinitTextBox(this.textBoxC1_3_3_3);
                    this.initTextBox(this.textBoxC1_3_3_4);
                    this.anotherinitTextBox(this.textBoxC1_3_3_5);
                    this.initTextBox(this.textBoxC1_3_3_6);
                    this.anotherinitTextBox(this.textBoxC1_3_3_7);
                    this.initTextBox(this.textBoxC1_3_3_8);
                    this.anotherinitTextBox(this.textBoxC1_3_3_9);
                    this.labelC1_3_3_0.Text = "   ";
                    this.labelC1_3_3_1.Text = "α";
                    this.labelC1_3_3_2.Text = "=";
                    this.labelC1_3_3_3.Text = "α";
                    this.labelC1_3_3_4.Text = "+";
                    this.labelC1_3_3_5.Text = "α";
                    this.labelC1_3_3_6.Text = "+";
                    this.labelC1_3_3_7.Text = "α";
                    this.labelC1_3_3_8.Text = "+";
                    this.labelC1_3_3_9.Text = "α";
                    this.labelC1_3_3_10.Text = "；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_0);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_2);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_3);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_4);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_4);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_5);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_6);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_6);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_7);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_7);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_8);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_8);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_9);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_3_9);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_3_10);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_3_3_10, true);
                    this.labelC1_3_4_0 = new Label();
                    this.labelC1_3_4_1 = new Label();
                    this.labelC1_3_4_2 = new Label();
                    this.labelC1_3_4_3 = new Label();
                    this.labelC1_3_4_4 = new Label();
                    this.labelC1_3_4_5 = new Label();
                    this.labelC1_3_4_6 = new Label();
                    this.labelC1_3_4_7 = new Label();
                    this.labelC1_3_4_8 = new Label();
                    this.labelC1_3_4_9 = new Label();
                    this.labelC1_3_4_10 = new Label();
                    this.initLabel(this.labelC1_3_4_0);
                    this.labelC1_3_4_1.Size = new Size(10, 0x19);
                    this.labelC1_3_4_1.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_4_2);
                    this.labelC1_3_4_3.Size = new Size(10, 0x19);
                    this.labelC1_3_4_3.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_4_4);
                    this.labelC1_3_4_5.Size = new Size(10, 0x19);
                    this.labelC1_3_4_5.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_4_6);
                    this.labelC1_3_4_7.Size = new Size(10, 0x19);
                    this.labelC1_3_4_7.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_4_8);
                    this.labelC1_3_4_9.Size = new Size(10, 0x19);
                    this.labelC1_3_4_9.Anchor = AnchorStyles.None;
                    this.initLabel(this.labelC1_3_4_10);
                    this.textBoxC1_3_4_1 = new TextBox();
                    this.textBoxC1_3_4_2 = new TextBox();
                    this.textBoxC1_3_4_3 = new TextBox();
                    this.textBoxC1_3_4_4 = new TextBox();
                    this.textBoxC1_3_4_5 = new TextBox();
                    this.textBoxC1_3_4_6 = new TextBox();
                    this.textBoxC1_3_4_7 = new TextBox();
                    this.textBoxC1_3_4_8 = new TextBox();
                    this.textBoxC1_3_4_9 = new TextBox();
                    this.anotherinitTextBox(this.textBoxC1_3_4_1);
                    this.initTextBox(this.textBoxC1_3_4_2);
                    this.anotherinitTextBox(this.textBoxC1_3_4_3);
                    this.initTextBox(this.textBoxC1_3_4_4);
                    this.anotherinitTextBox(this.textBoxC1_3_4_5);
                    this.initTextBox(this.textBoxC1_3_4_6);
                    this.anotherinitTextBox(this.textBoxC1_3_4_7);
                    this.initTextBox(this.textBoxC1_3_4_8);
                    this.anotherinitTextBox(this.textBoxC1_3_4_9);
                    this.labelC1_3_4_0.Text = "   ";
                    this.labelC1_3_4_1.Text = "α";
                    this.labelC1_3_4_2.Text = "=";
                    this.labelC1_3_4_3.Text = "α";
                    this.labelC1_3_4_4.Text = "+";
                    this.labelC1_3_4_5.Text = "α";
                    this.labelC1_3_4_6.Text = "+";
                    this.labelC1_3_4_7.Text = "α";
                    this.labelC1_3_4_8.Text = "+";
                    this.labelC1_3_4_9.Text = "α";
                    this.labelC1_3_4_10.Text = "；";
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_0);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_2);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_2);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_3);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_3);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_4);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_4);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_5);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_5);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_6);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_6);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_7);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_7);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_8);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_8);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_9);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxC1_3_4_9);
                    this.flowLayoutPanel1.Controls.Add(this.labelC1_3_4_10);
                    this.flowLayoutPanel1.SetFlowBreak(this.labelC1_3_4_10, true);
                }
                else
                {
                    List<NuGenEQML> list5;
                    if (str.Equals("c2.xml"))
                    {
                        this.controlC2 = new NuGenEQML();
                        new C2().C2Generate(this.controlC2, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlC2);
                        this.flowLayoutPanel1.SetFlowBreak(this.controlC2, true);
                        this.labelC2_1 = new Label();
                        this.initScoreLabel(this.labelC2_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_1);
                        this.labelC2_1_1 = new Label();
                        this.initLabel(this.labelC2_1_1);
                        this.labelC2_1_1.Text = "  （1）线性方程组增广矩阵的行最简矩阵是：";
                        this.pictureBoxC2_1_1 = new PictureBox();
                        this.pictureBoxC2_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxC2_1_1);
                        this.initPictureBox(this.pictureBoxC2_1_2);
                        this.pictureBoxC2_1_1.Load("Images/4-1-1.jpg");
                        this.pictureBoxC2_1_2.Load("Images/4-2-1.jpg");
                        this.tableC2_1_1 = new TableLayoutPanel();
                        this.textBoxC2_1_1 = new TextBox();
                        this.textBoxC2_1_2 = new TextBox();
                        this.textBoxC2_1_3 = new TextBox();
                        this.textBoxC2_1_4 = new TextBox();
                        this.textBoxC2_1_5 = new TextBox();
                        this.textBoxC2_1_6 = new TextBox();
                        this.textBoxC2_1_7 = new TextBox();
                        this.textBoxC2_1_8 = new TextBox();
                        this.textBoxC2_1_9 = new TextBox();
                        this.textBoxC2_1_10 = new TextBox();
                        this.textBoxC2_1_11 = new TextBox();
                        this.textBoxC2_1_12 = new TextBox();
                        this.textBoxC2_1_13 = new TextBox();
                        this.textBoxC2_1_14 = new TextBox();
                        this.textBoxC2_1_15 = new TextBox();
                        this.textBoxC2_1_16 = new TextBox();
                        this.textBoxC2_1_17 = new TextBox();
                        this.textBoxC2_1_18 = new TextBox();
                        this.textBoxC2_1_19 = new TextBox();
                        this.textBoxC2_1_20 = new TextBox();
                        List<TextBox> lists = new List<TextBox> {
                            this.textBoxC2_1_1,
                            this.textBoxC2_1_2,
                            this.textBoxC2_1_3,
                            this.textBoxC2_1_4,
                            this.textBoxC2_1_5,
                            this.textBoxC2_1_6,
                            this.textBoxC2_1_7,
                            this.textBoxC2_1_8,
                            this.textBoxC2_1_9,
                            this.textBoxC2_1_10,
                            this.textBoxC2_1_11,
                            this.textBoxC2_1_12,
                            this.textBoxC2_1_13,
                            this.textBoxC2_1_14,
                            this.textBoxC2_1_15,
                            this.textBoxC2_1_16,
                            this.textBoxC2_1_17,
                            this.textBoxC2_1_18,
                            this.textBoxC2_1_19,
                            this.textBoxC2_1_20
                        };
                        this.initTextBox(lists);
                        new InitControls().calculationOneOfTwo(this.tableC2_1_1, lists);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableC2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC2_1_2, true);
                        this.labelC2_2 = new Label();
                        this.initScoreLabel(this.labelC2_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2);
                        this.labelC2_2_1 = new Label();
                        this.labelC2_2_2 = new Label();
                        this.labelC2_2_3 = new Label();
                        this.labelC2_2_4 = new Label();
                        this.labelC2_2_5 = new Label();
                        this.initLabel(this.labelC2_2_1);
                        this.initLabel(this.labelC2_2_2);
                        this.initLabel(this.labelC2_2_3);
                        this.initLabel(this.labelC2_2_4);
                        this.initLabel(this.labelC2_2_5);
                        this.labelC2_2_1.Text = "  （2）线性方程组系数矩阵的秩等于(";
                        this.labelC2_2_2.Text = "),增广矩阵的秩等于(";
                        this.labelC2_2_3.Text = ")，方程组是否有解？(";
                        this.labelC2_2_4.Text = "，";
                        this.labelC2_2_5.Text = ")；";
                        this.textBoxC2_2_1 = new TextBox();
                        this.textBoxC2_2_2 = new TextBox();
                        this.initTextBox(this.textBoxC2_2_1);
                        this.initTextBox(this.textBoxC2_2_2);
                        this.radioButtonC2_2_1 = new RadioButton();
                        this.radioButtonC2_2_2 = new RadioButton();
                        this.radioButtonC2_2_1.Name = "choose";
                        this.radioButtonC2_2_2.Name = "choose";
                        this.radioButtonC2_2_1.Text = "是";
                        this.radioButtonC2_2_2.Text = "否";
                        this.radioButtonC2_2_1.Font = new Font("宋体", 14f);
                        this.radioButtonC2_2_2.Font = new Font("宋体", 14f);
                        this.radioButtonC2_2_1.AutoSize = true;
                        this.radioButtonC2_2_1.Anchor = AnchorStyles.None;
                        this.radioButtonC2_2_2.Anchor = AnchorStyles.None;
                        this.radioButtonC2_2_2.AutoSize = true;
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxC2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2_2);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxC2_2_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2_3);
                        this.flowLayoutPanel1.Controls.Add(this.radioButtonC2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2_4);
                        this.flowLayoutPanel1.Controls.Add(this.radioButtonC2_2_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_2_5);
                        this.flowLayoutPanel1.SetFlowBreak(this.labelC2_2_5, true);
                        this.labelC2_3 = new Label();
                        this.initScoreLabel(this.labelC2_3);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_3);
                        this.labelC2_3_1 = new Label();
                        this.initLabel(this.labelC2_3_1);
                        this.labelC2_3_1.Text = "  （3）线性方程组的导出组的一个基础解系为(多余的空格不填)：";
                        this.controlC2_3_1 = new NuGenEQML();
                        this.controlC2_3_2 = new NuGenEQML();
                        this.controlC2_3_3 = new NuGenEQML();
                        this.controlC2_3_4 = new NuGenEQML();
                        this.controlC2_3_5 = new NuGenEQML();
                        this.controlC2_3_6 = new NuGenEQML();
                        this.controlC2_3_7 = new NuGenEQML();
                        this.controlC2_3_8 = new NuGenEQML();
                        this.controlC2_3_9 = new NuGenEQML();
                        this.controlC2_3_10 = new NuGenEQML();
                        this.controlC2_3_11 = new NuGenEQML();
                        this.controlC2_3_12 = new NuGenEQML();
                        this.labelC2_3_2 = new Label();
                        this.labelC2_3_3 = new Label();
                        this.initLabel(this.labelC2_3_2);
                        this.initLabel(this.labelC2_3_3);
                        this.labelC2_3_2.Text = ",";
                        this.labelC2_3_3.Text = ",";
                        this.pictureBoxC2_3_1 = new PictureBox();
                        this.pictureBoxC2_3_2 = new PictureBox();
                        this.pictureBoxC2_3_3 = new PictureBox();
                        this.pictureBoxC2_3_4 = new PictureBox();
                        this.pictureBoxC2_3_5 = new PictureBox();
                        this.pictureBoxC2_3_6 = new PictureBox();
                        this.initPictureBox(this.pictureBoxC2_3_1);
                        this.initPictureBox(this.pictureBoxC2_3_2);
                        this.initPictureBox(this.pictureBoxC2_3_3);
                        this.initPictureBox(this.pictureBoxC2_3_4);
                        this.initPictureBox(this.pictureBoxC2_3_5);
                        this.initPictureBox(this.pictureBoxC2_3_6);
                        this.pictureBoxC2_3_1.Load("Images/4-1.jpg");
                        this.pictureBoxC2_3_2.Load("Images/4-2.jpg");
                        this.pictureBoxC2_3_3.Load("Images/4-1.jpg");
                        this.pictureBoxC2_3_4.Load("Images/4-2.jpg");
                        this.pictureBoxC2_3_5.Load("Images/4-1.jpg");
                        this.pictureBoxC2_3_6.Load("Images/4-2.jpg");
                        List<NuGenEQML> list2 = new List<NuGenEQML> {
                            this.controlC2_3_1,
                            this.controlC2_3_2,
                            this.controlC2_3_3,
                            this.controlC2_3_4
                        };
                        List<NuGenEQML> list3 = new List<NuGenEQML> {
                            this.controlC2_3_5,
                            this.controlC2_3_6,
                            this.controlC2_3_7,
                            this.controlC2_3_8
                        };
                        List<NuGenEQML> list4 = new List<NuGenEQML> {
                            this.controlC2_3_9,
                            this.controlC2_3_10,
                            this.controlC2_3_11,
                            this.controlC2_3_12
                        };
                        this.initControls(list2);
                        this.initControls(list3);
                        this.initControls(list4);
                        this.tableC2_3_1 = new TableLayoutPanel();
                        this.tableC2_3_2 = new TableLayoutPanel();
                        this.tableC2_3_3 = new TableLayoutPanel();
                        new InitControls().matrixFourToOne(this.tableC2_3_1, list2);
                        new InitControls().matrixFourToOne(this.tableC2_3_2, list3);
                        new InitControls().matrixFourToOne(this.tableC2_3_3, list4);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableC2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_3_2);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_3);
                        this.flowLayoutPanel1.Controls.Add(this.tableC2_3_2);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_4);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_3_3);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_5);
                        this.flowLayoutPanel1.Controls.Add(this.tableC2_3_3);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_3_6);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC2_3_6, true);
                        this.labelC2_4 = new Label();
                        this.initScoreLabel(this.labelC2_4);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_4);
                        this.labelC2_4_1 = new Label();
                        this.initLabel(this.labelC2_4_1);
                        this.labelC2_4_1.Text = "  （4）线性方程组的一个特解为：";
                        this.pictureBoxC2_4_1 = new PictureBox();
                        this.pictureBoxC2_4_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxC2_4_1);
                        this.initPictureBox(this.pictureBoxC2_4_2);
                        this.pictureBoxC2_4_1.Load("Images/4-1.jpg");
                        this.pictureBoxC2_4_2.Load("Images/4-2.jpg");
                        this.controlC2_4_1 = new NuGenEQML();
                        this.controlC2_4_2 = new NuGenEQML();
                        this.controlC2_4_3 = new NuGenEQML();
                        this.controlC2_4_4 = new NuGenEQML();
                        list5 = new List<NuGenEQML> {
                            this.controlC2_4_1,
                            this.controlC2_4_2,
                            this.controlC2_4_3,
                            this.controlC2_4_4
                        };
                        this.initControls(list5);
                        this.tableC2_4_1 = new TableLayoutPanel();
                        new InitControls().matrixFourToOne(this.tableC2_4_1, list5);
                        this.flowLayoutPanel1.Controls.Add(this.labelC2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableC2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxC2_4_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC2_4_2, true);
                    }
                    else
                    {
                        List<NuGenEQML> list6;
                        if (str.Equals("c3.xml"))
                        {
                            this.controlC3 = new NuGenEQML();
                            new C3().C3Generate(this.controlC3, (i + 1) + ".");
                            this.flowLayoutPanel1.Controls.Add(this.controlC3);
                            this.flowLayoutPanel1.SetFlowBreak(this.controlC3, true);
                            this.labelC3_1 = new Label();
                            this.initScoreLabel(this.labelC3_1);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1);
                            this.labelC3_1_1 = new Label();
                            this.labelC3_1_2 = new Label();
                            this.labelC3_1_3 = new Label();
                            this.labelC3_1_4 = new Label();
                            this.initLabel(this.labelC3_1_1);
                            this.initLabel(this.labelC3_1_2);
                            this.initLabel(this.labelC3_1_3);
                            this.initLabel(this.labelC3_1_4);
                            this.labelC3_1 = new Label();
                            this.initScoreLabel(this.labelC3_1);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1);
                            this.labelC3_1_1.Text = "   (1)矩阵A的特征值为";
                            this.labelC3_1_2.Text = ",";
                            this.labelC3_1_3.Text = ",";
                            this.labelC3_1_4.Text = ";";
                            this.controlC3_1_1 = new NuGenEQML();
                            this.controlC3_1_2 = new NuGenEQML();
                            this.controlC3_1_3 = new NuGenEQML();
                            this.controlC3_1_4 = new NuGenEQML();
                            this.controlC3_1_5 = new NuGenEQML();
                            this.controlC3_1_6 = new NuGenEQML();
                            this.initsmallControl(this.controlC3_1_1);
                            this.initsmallControl(this.controlC3_1_2);
                            this.initsmallControl(this.controlC3_1_3);
                            list6 = new List<NuGenEQML> {
                                this.controlC3_1_4,
                                this.controlC3_1_5,
                                this.controlC3_1_6
                            };
                            this.initControls(list6);
                            this.controlC3_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                            this.controlC3_1_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                            this.controlC3_1_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_4);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1_2);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_2);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_5);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1_3);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_3);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_1_6);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_1_4);
                            this.flowLayoutPanel1.SetFlowBreak(this.labelC3_1_4, true);
                            this.labelC3_2 = new Label();
                            this.initScoreLabel(this.labelC3_2);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2);
                            this.labelC3_2_1_1 = new Label();
                            this.labelC3_2_1_2 = new Label();
                            this.labelC3_2_1_3 = new Label();
                            this.initLabel(this.labelC3_2_1_1);
                            this.initLabel(this.labelC3_2_1_2);
                            this.initLabel(this.labelC3_2_1_3);
                            this.labelC3_2_1_1.Text = "   (2)";
                            this.labelC3_2_1_2.Text = ",";
                            this.labelC3_2_1_3.Text = ",";
                            this.controlC3_2_1_1 = new NuGenEQML();
                            this.controlC3_2_1_2 = new NuGenEQML();
                            this.controlC3_2_1_3 = new NuGenEQML();
                            this.controlC3_2_1_4 = new NuGenEQML();
                            this.controlC3_2_1_5 = new NuGenEQML();
                            this.controlC3_2_1_1.Enabled = false;
                            this.controlC3_2_1_1.Anchor = AnchorStyles.None;
                            this.controlC3_2_1_1.Size = new Size(320, 0x20);
                            this.controlC3_2_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>属于特征值</mi><mspace /><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>1</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                            List<NuGenEQML> list7 = new List<NuGenEQML> {
                                this.controlC3_2_1_3,
                                this.controlC3_2_1_4,
                                this.controlC3_2_1_5
                            };
                            this.initControls(list7);
                            this.initsmallControl(this.controlC3_2_1_2);
                            this.controlC3_2_1_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_1_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_1_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_1_3);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_1_2);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_1_4);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_1_3);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_1_5);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_1_2);
                            this.flowLayoutPanel1.SetFlowBreak(this.controlC3_2_1_2, true);
                            this.labelC3_2_2_1 = new Label();
                            this.labelC3_2_2_2 = new Label();
                            this.labelC3_2_2_3 = new Label();
                            this.initLabel(this.labelC3_2_2_1);
                            this.initLabel(this.labelC3_2_2_2);
                            this.initLabel(this.labelC3_2_2_3);
                            this.labelC3_2_2_1.Text = "      ";
                            this.labelC3_2_2_2.Text = ",";
                            this.labelC3_2_2_3.Text = ",";
                            this.controlC3_2_2_1 = new NuGenEQML();
                            this.controlC3_2_2_2 = new NuGenEQML();
                            this.controlC3_2_2_3 = new NuGenEQML();
                            this.controlC3_2_2_4 = new NuGenEQML();
                            this.controlC3_2_2_5 = new NuGenEQML();
                            this.controlC3_2_2_1.Enabled = false;
                            this.controlC3_2_2_1.Anchor = AnchorStyles.None;
                            this.controlC3_2_2_1.Size = new Size(320, 0x20);
                            this.controlC3_2_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>属于特征值</mi><mspace /><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>2</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                            this.initsmallControl(this.controlC3_2_2_2);
                            this.controlC3_2_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                            List<NuGenEQML> list8 = new List<NuGenEQML> {
                                this.controlC3_2_2_3,
                                this.controlC3_2_2_4,
                                this.controlC3_2_2_5
                            };
                            this.initControls(list8);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_2_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_2_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_2_3);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_2_2);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_2_4);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_2_3);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_2_5);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_2_2);
                            this.flowLayoutPanel1.SetFlowBreak(this.controlC3_2_2_2, true);
                            this.labelC3_2_3_1 = new Label();
                            this.labelC3_2_3_2 = new Label();
                            this.labelC3_2_3_3 = new Label();
                            this.initLabel(this.labelC3_2_3_1);
                            this.initLabel(this.labelC3_2_3_2);
                            this.initLabel(this.labelC3_2_3_3);
                            this.labelC3_2_3_1.Text = "      ";
                            this.labelC3_2_3_2.Text = ",";
                            this.labelC3_2_3_3.Text = ",";
                            this.controlC3_2_3_1 = new NuGenEQML();
                            this.controlC3_2_3_1.Enabled = false;
                            this.controlC3_2_3_1.Anchor = AnchorStyles.None;
                            this.controlC3_2_3_1.Size = new Size(320, 0x20);
                            this.controlC3_2_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>属于特征值</mi><mspace /><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>3</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                            this.controlC3_2_3_2 = new NuGenEQML();
                            this.initsmallControl(this.controlC3_2_3_2);
                            this.controlC3_2_3_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                            this.controlC3_2_3_3 = new NuGenEQML();
                            this.controlC3_2_3_3.Enabled = false;
                            this.controlC3_2_3_3.Anchor = AnchorStyles.None;
                            this.controlC3_2_3_3.Size = new Size(380, 0x20);
                            this.controlC3_2_3_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mrow><mo>&lpar;</mo></mrow><mi>注：如果</mi><mspace /><msub><mrow><mi>&lambda;</mi></mrow><mrow><mi>i</mi></mrow></msub><mo>&equals;</mo><msub><mrow><mi>&lambda;</mi></mrow><mrow><mi>j</mi></mrow></msub><mspace /><mi>要求</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mi>i</mi></mrow></msub><mo>&comma;</mo><msub><mrow><mi>p</mi></mrow><mrow><mi>j</mi></mrow></msub><mspace /><mi>线性无关。</mi><mo>&rpar;</mo></mtd></mtr></mtable></math>");
                            this.controlC3_2_3_4 = new NuGenEQML();
                            this.controlC3_2_3_5 = new NuGenEQML();
                            this.controlC3_2_3_6 = new NuGenEQML();
                            List<NuGenEQML> list9 = new List<NuGenEQML> {
                                this.controlC3_2_3_4,
                                this.controlC3_2_3_5,
                                this.controlC3_2_3_6
                            };
                            this.initControls(list9);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_3_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_4);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_3_2);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_5);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_2_3_3);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_6);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_2);
                            this.flowLayoutPanel1.SetFlowBreak(this.controlC3_2_3_2, true);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_2_3_3);
                            this.flowLayoutPanel1.SetFlowBreak(this.controlC3_2_3_3, true);
                            this.labelC3_3 = new Label();
                            this.initScoreLabel(this.labelC3_3);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_3);
                            this.labelC3_3_1 = new Label();
                            this.initLabel(this.labelC3_3_1);
                            this.labelC3_3_1.Text = "   (3)正交矩阵为Q=";
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_3_1);
                            this.controlC3_3_1 = new NuGenEQML();
                            this.controlC3_3_2 = new NuGenEQML();
                            this.controlC3_3_3 = new NuGenEQML();
                            this.controlC3_3_4 = new NuGenEQML();
                            this.controlC3_3_5 = new NuGenEQML();
                            this.controlC3_3_6 = new NuGenEQML();
                            this.controlC3_3_7 = new NuGenEQML();
                            this.controlC3_3_8 = new NuGenEQML();
                            this.controlC3_3_9 = new NuGenEQML();
                            list5 = new List<NuGenEQML> {
                                this.controlC3_3_1,
                                this.controlC3_3_2,
                                this.controlC3_3_3,
                                this.controlC3_3_4,
                                this.controlC3_3_5,
                                this.controlC3_3_6,
                                this.controlC3_3_7,
                                this.controlC3_3_8,
                                this.controlC3_3_9
                            };
                            this.initControls(list5);
                            this.pictureBoxC3_3_1 = new PictureBox();
                            this.pictureBoxC3_3_2 = new PictureBox();
                            this.initPictureBox(this.pictureBoxC3_3_1);
                            this.initPictureBox(this.pictureBoxC3_3_2);
                            this.pictureBoxC3_3_1.Load("Images/3-1.jpg");
                            this.pictureBoxC3_3_2.Load("Images/3-2.jpg");
                            this.tableC3_3_1 = new TableLayoutPanel();
                            new InitControls().matrixThreeToThree(this.tableC3_3_1, list5);
                            this.flowLayoutPanel1.Controls.Add(this.pictureBoxC3_3_1);
                            this.flowLayoutPanel1.Controls.Add(this.tableC3_3_1);
                            this.flowLayoutPanel1.Controls.Add(this.pictureBoxC3_3_2);
                            this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC3_3_2, true);
                            this.labelC3_4 = new Label();
                            this.initScoreLabel(this.labelC3_4);
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_4);
                            this.labelC3_4_1 = new Label();
                            this.initLabel(this.labelC3_4_1);
                            this.labelC3_4_1.Text = "   (4)";
                            this.controlC3_4_1 = new NuGenEQML();
                            this.controlC3_4_2 = new NuGenEQML();
                            this.controlC3_4_3 = new NuGenEQML();
                            List<NuGenEQML> list10 = new List<NuGenEQML> {
                                this.controlC3_4_1,
                                this.controlC3_4_2,
                                this.controlC3_4_3
                            };
                            this.initControls(list10);
                            this.pictureBoxC3_4_1 = new PictureBox();
                            this.pictureBoxC3_4_2 = new PictureBox();
                            this.initPictureBox(this.pictureBoxC3_4_1);
                            this.initPictureBox(this.pictureBoxC3_4_2);
                            this.pictureBoxC3_4_1.Load("Images/3-1.jpg");
                            this.pictureBoxC3_4_2.Load("Images/3-2.jpg");
                            this.tableC3_4_1 = new TableLayoutPanel();
                            new InitControls().calculationThree(this.tableC3_4_1, list10);
                            this.controlC3_4 = new NuGenEQML();
                            this.controlC3_4.Size = new Size(190, 30);
                            this.controlC3_4.Enabled = false;
                            this.controlC3_4.Anchor = AnchorStyles.None;
                            this.controlC3_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>对角矩阵为</mi><mspace /><msup><mrow><mi>Q</mi></mrow><mrow><mo>&minus;</mo><mn>1</mn></mrow></msup><mspace /><mi>A</mi><mspace /><mi>Q</mi><mo>&equals;</mo></mtd></mtr></mtable></math>");
                            this.flowLayoutPanel1.Controls.Add(this.labelC3_4_1);
                            this.flowLayoutPanel1.Controls.Add(this.controlC3_4);
                            this.flowLayoutPanel1.Controls.Add(this.pictureBoxC3_4_1);
                            this.flowLayoutPanel1.Controls.Add(this.tableC3_4_1);
                            this.flowLayoutPanel1.Controls.Add(this.pictureBoxC3_4_2);
                            this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC3_4_2, true);
                        }
                        else
                        {
                            List<TextBox> list11;
                            if (str.Equals("c4.xml"))
                            {
                                this.controlC4 = new NuGenEQML();
                                new C4().C4Generate(this.controlC4, (i + 1) + ".");
                                this.flowLayoutPanel1.Controls.Add(this.controlC4);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4, true);
                                this.labelC4_1 = new Label();
                                this.initScoreLabel(this.labelC4_1);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_1);
                                this.labelC4_1_1 = new Label();
                                this.initLabel(this.labelC4_1_1);
                                this.labelC4_1_1.Text = "   (1)";
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_1_1);
                                this.controlC4_1_1 = new NuGenEQML();
                                this.controlC4_1_1.Size = new Size(300, 30);
                                this.controlC4_1_1.Enabled = false;
                                this.controlC4_1_1.Anchor = AnchorStyles.None;
                                this.controlC4_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mi>二次型</mi><mspace /><mi>f</mi><mrow><mo>&lpar;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&comma;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&comma;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&rpar;</mo><mspace /><mi>的矩阵为：A=</mi></mrow></math>");
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_1_1);
                                this.tableC4_1_1 = new TableLayoutPanel();
                                this.textBoxC4_1_1 = new TextBox();
                                this.textBoxC4_1_2 = new TextBox();
                                this.textBoxC4_1_3 = new TextBox();
                                this.textBoxC4_1_4 = new TextBox();
                                this.textBoxC4_1_5 = new TextBox();
                                this.textBoxC4_1_6 = new TextBox();
                                this.textBoxC4_1_7 = new TextBox();
                                this.textBoxC4_1_8 = new TextBox();
                                this.textBoxC4_1_9 = new TextBox();
                                list11 = new List<TextBox> {
                                    this.textBoxC4_1_1,
                                    this.textBoxC4_1_2,
                                    this.textBoxC4_1_3,
                                    this.textBoxC4_1_4,
                                    this.textBoxC4_1_5,
                                    this.textBoxC4_1_6,
                                    this.textBoxC4_1_7,
                                    this.textBoxC4_1_8,
                                    this.textBoxC4_1_9
                                };
                                this.initTextBox(list11);
                                this.pictureBoxC4_1_1 = new PictureBox();
                                this.pictureBoxC4_1_2 = new PictureBox();
                                this.initPictureBox(this.pictureBoxC4_1_1);
                                this.initPictureBox(this.pictureBoxC4_1_2);
                                this.pictureBoxC4_1_1.Load("Images/3-1-1.jpg");
                                this.pictureBoxC4_1_2.Load("Images/3-2-2.jpg");
                                new InitControls().matrixThreeToThree(this.tableC4_1_1, list11);
                                this.flowLayoutPanel1.Controls.Add(this.pictureBoxC4_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.tableC4_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.pictureBoxC4_1_2);
                                this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC4_1_2, true);
                                this.labelC4_2 = new Label();
                                this.initScoreLabel(this.labelC4_2);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_2);
                                this.labelC4_2_1 = new Label();
                                this.initLabel(this.labelC4_2_1);
                                this.labelC4_2_1.Text = "   (2)矩阵A的特征值为：";
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_2_1);
                                this.controlC4_2_1 = new NuGenEQML();
                                this.controlC4_2_2 = new NuGenEQML();
                                this.controlC4_2_3 = new NuGenEQML();
                                this.initsmallControl(this.controlC4_2_1);
                                this.initsmallControl(this.controlC4_2_2);
                                this.initsmallControl(this.controlC4_2_3);
                                this.controlC4_2_4 = new NuGenEQML();
                                this.controlC4_2_5 = new NuGenEQML();
                                this.controlC4_2_6 = new NuGenEQML();
                                this.initControls(this.controlC4_2_4);
                                this.initControls(this.controlC4_2_5);
                                this.initControls(this.controlC4_2_6);
                                this.controlC4_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_2_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_4);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_2_6);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4_2_6, true);
                                this.labelC4_3 = new Label();
                                this.initScoreLabel(this.labelC4_3);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_3);
                                this.labelC4_3_1 = new Label();
                                this.initLabel(this.labelC4_3_1);
                                this.labelC4_3_1.Text = "   (3)所用正交变换为：";
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_3_1);
                                this.labelC4_3_2 = new Label();
                                this.labelC4_3_2.Width = 220;
                                this.labelC4_3_3 = new Label();
                                this.labelC4_3_3.Width = 220;
                                this.controlC4_3_1 = new NuGenEQML();
                                this.controlC4_3_2 = new NuGenEQML();
                                this.controlC4_3_3 = new NuGenEQML();
                                this.controlC4_3_4 = new NuGenEQML();
                                this.controlC4_3_5 = new NuGenEQML();
                                this.controlC4_3_6 = new NuGenEQML();
                                this.controlC4_3_7 = new NuGenEQML();
                                this.controlC4_3_8 = new NuGenEQML();
                                this.controlC4_3_9 = new NuGenEQML();
                                this.controlC4_3_10 = new NuGenEQML();
                                this.controlC4_3_11 = new NuGenEQML();
                                this.controlC4_3_12 = new NuGenEQML();
                                this.initsmallControl(this.controlC4_3_1);
                                this.initsmallControl(this.controlC4_3_2);
                                this.initsmallControl(this.controlC4_3_3);
                                this.initsmallControl(this.controlC4_3_4);
                                this.initsmallControl(this.controlC4_3_5);
                                this.initsmallControl(this.controlC4_3_6);
                                this.initsmallControl(this.controlC4_3_7);
                                this.initsmallControl(this.controlC4_3_8);
                                this.initsmallControl(this.controlC4_3_9);
                                this.initsmallControl(this.controlC4_3_10);
                                this.initsmallControl(this.controlC4_3_11);
                                this.initsmallControl(this.controlC4_3_12);
                                this.controlC4_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>3</mn></mrow></msub></mtd></mtr></mtable></math>");
                                this.controlC4_3_5.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_6.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_7.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_8.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>3</mn></mrow></msub></mtd></mtr></mtable></math>");
                                this.controlC4_3_9.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_10.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_11.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_3_12.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>y</mi></mrow><mrow><mn>3</mn></mrow></msub></mtd></mtr></mtable></math>");
                                this.controlC4_3_13 = new NuGenEQML();
                                this.controlC4_3_14 = new NuGenEQML();
                                this.controlC4_3_15 = new NuGenEQML();
                                this.controlC4_3_16 = new NuGenEQML();
                                this.controlC4_3_17 = new NuGenEQML();
                                this.controlC4_3_18 = new NuGenEQML();
                                this.controlC4_3_19 = new NuGenEQML();
                                this.controlC4_3_20 = new NuGenEQML();
                                this.controlC4_3_21 = new NuGenEQML();
                                this.initControls(this.controlC4_3_13);
                                this.initControls(this.controlC4_3_14);
                                this.initControls(this.controlC4_3_15);
                                this.initControls(this.controlC4_3_16);
                                this.initControls(this.controlC4_3_17);
                                this.initControls(this.controlC4_3_18);
                                this.initControls(this.controlC4_3_19);
                                this.initControls(this.controlC4_3_20);
                                this.initControls(this.controlC4_3_21);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_13);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_14);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_15);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_4);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4_3_4, true);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_3_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_16);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_6);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_17);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_7);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_18);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_8);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4_3_8, true);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_3_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_9);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_19);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_10);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_20);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_11);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_21);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_3_12);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4_3_12, true);
                                this.labelC4_4 = new Label();
                                this.initScoreLabel(this.labelC4_4);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_4);
                                this.labelC4_4_1 = new Label();
                                this.initLabel(this.labelC4_4_1);
                                this.labelC4_4_1.Text = "   (4)变换后的标准形为：";
                                this.controlC4_4_1 = new NuGenEQML();
                                this.controlC4_4_2 = new NuGenEQML();
                                this.controlC4_4_3 = new NuGenEQML();
                                this.controlC4_4_4 = new NuGenEQML();
                                this.controlC4_4_1.Size = new Size(140, 30);
                                this.controlC4_4_1.Enabled = false;
                                this.controlC4_4_1.Anchor = AnchorStyles.None;
                                this.controlC4_4_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>f</mi><mrow><mo>&lpar;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&comma;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&comma;</mo><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&rpar;</mo></mrow><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.initsmallControl(this.controlC4_4_2);
                                this.controlC4_4_2.Size = new Size(0x41, 30);
                                this.initsmallControl(this.controlC4_4_3);
                                this.controlC4_4_3.Size = new Size(0x41, 30);
                                this.initsmallControl(this.controlC4_4_4);
                                this.controlC4_4_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><msub><mrow><mi>y</mi></mrow><mrow><mn>1</mn></mrow></msub></mrow><mrow><mn>2</mn></mrow></msup><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_4_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><msub><mrow><mi>y</mi></mrow><mrow><mn>2</mn></mrow></msub></mrow><mrow><mn>2</mn></mrow></msup><mo>&plus;</mo></mtd></mtr></mtable></math>");
                                this.controlC4_4_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><msub><mrow><mi>y</mi></mrow><mrow><mn>3</mn></mrow></msub></mrow><mrow><mn>2</mn></mrow></msup></mtd></mtr></mtable></math>");
                                this.controlC4_4_5 = new NuGenEQML();
                                this.controlC4_4_6 = new NuGenEQML();
                                this.controlC4_4_7 = new NuGenEQML();
                                this.initControls(this.controlC4_4_5);
                                this.initControls(this.controlC4_4_6);
                                this.initControls(this.controlC4_4_7);
                                this.flowLayoutPanel1.Controls.Add(this.labelC4_4_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_6);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_7);
                                this.flowLayoutPanel1.Controls.Add(this.controlC4_4_4);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC4_4_4, true);
                            }
                            else if (str.Equals("c5.xml"))
                            {
                                this.controlC5 = new NuGenEQML();
                                new C5().C5Generate(this.controlC5, (i + 1) + ".");
                                this.flowLayoutPanel1.Controls.Add(this.controlC5);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC5, true);
                                this.labelC5_1 = new Label();
                                this.initScoreLabel(this.labelC5_1);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_1);
                                this.labelC5_1_1 = new Label();
                                this.initLabel(this.labelC5_1_1);
                                this.labelC5_1_1.Text = "   (1)";
                                this.controlC5_1_1 = new NuGenEQML();
                                this.controlC5_1_2 = new NuGenEQML();
                                this.controlC5_1_3 = new NuGenEQML();
                                this.controlC5_1_1.Size = new Size(200, 30);
                                this.controlC5_1_1.Enabled = false;
                                this.initsmallControl(this.controlC5_1_2);
                                this.initsmallControl(this.controlC5_1_3);
                                this.controlC5_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>矩阵A的特征值为</mi><mspace /><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC5_1_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC5_1_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                this.controlC5_1_4 = new NuGenEQML();
                                this.controlC5_1_5 = new NuGenEQML();
                                this.controlC5_1_6 = new NuGenEQML();
                                this.initControls(this.controlC5_1_4);
                                this.initControls(this.controlC5_1_5);
                                this.initControls(this.controlC5_1_6);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_4);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_1_6);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC5_1_6, true);
                                this.labelC5_2 = new Label();
                                this.initScoreLabel(this.labelC5_2);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_2);
                                this.labelC5_2_1 = new Label();
                                this.labelC5_2_2 = new Label();
                                this.labelC5_2_3 = new Label();
                                this.initLabel(this.labelC5_2_1);
                                this.initLabel(this.labelC5_2_2);
                                this.initLabel(this.labelC5_2_3);
                                this.labelC5_2_1.Text = "   (2) 属于特征值";
                                this.labelC5_2_2.Text = "       属于特征值";
                                this.labelC5_2_3.Text = "       属于特征值";
                                this.controlC5_2_1 = new NuGenEQML();
                                this.controlC5_2_2 = new NuGenEQML();
                                this.controlC5_2_3 = new NuGenEQML();
                                this.controlC5_2_4 = new NuGenEQML();
                                this.controlC5_2_5 = new NuGenEQML();
                                this.controlC5_2_6 = new NuGenEQML();
                                this.initsmallControl(this.controlC5_2_1);
                                this.controlC5_2_1.Size = new Size(220, 30);
                                this.controlC5_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>1</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_2_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_1);
                                this.initsmallControl(this.controlC5_2_2);
                                this.controlC5_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                                this.initsmallControl(this.controlC5_2_3);
                                this.controlC5_2_3.Size = new Size(220, 30);
                                this.controlC5_2_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>2</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                                this.initsmallControl(this.controlC5_2_4);
                                this.controlC5_2_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                                this.initsmallControl(this.controlC5_2_5);
                                this.controlC5_2_5.Size = new Size(220, 30);
                                this.controlC5_2_5.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>&lambda;</mi></mrow><mrow><mn>3</mn></mrow></msub><mspace /><mi>的一个特征向量为</mi><mspace /><msub><mrow><mi>p</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo><mrow><mo>&lpar;</mo></mrow></mtd></mtr></mtable></math>");
                                this.initsmallControl(this.controlC5_2_6);
                                this.controlC5_2_6.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                                this.controlC5_2_7 = new NuGenEQML();
                                this.controlC5_2_8 = new NuGenEQML();
                                this.controlC5_2_9 = new NuGenEQML();
                                this.controlC5_2_10 = new NuGenEQML();
                                this.controlC5_2_11 = new NuGenEQML();
                                this.controlC5_2_12 = new NuGenEQML();
                                this.controlC5_2_13 = new NuGenEQML();
                                this.controlC5_2_14 = new NuGenEQML();
                                this.controlC5_2_15 = new NuGenEQML();
                                this.initControls(this.controlC5_2_7);
                                this.initControls(this.controlC5_2_8);
                                this.initControls(this.controlC5_2_9);
                                this.initControls(this.controlC5_2_10);
                                this.initControls(this.controlC5_2_11);
                                this.initControls(this.controlC5_2_12);
                                this.initControls(this.controlC5_2_13);
                                this.initControls(this.controlC5_2_14);
                                this.initControls(this.controlC5_2_15);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_7);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_8);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_9);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_2);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC5_2_2, true);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_2_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_10);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_11);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_12);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_4);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC5_2_4, true);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_2_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_13);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_14);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_15);
                                this.flowLayoutPanel1.Controls.Add(this.controlC5_2_6);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC5_2_6, true);
                                this.labelC5_3 = new Label();
                                this.initScoreLabel(this.labelC5_3);
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_3);
                                this.labelC5_3_1 = new Label();
                                this.initLabel(this.labelC5_3_1);
                                this.labelC5_3_1.Text = "   (3)矩阵A=";
                                this.flowLayoutPanel1.Controls.Add(this.labelC5_3_1);
                                this.controlC5_3_1 = new NuGenEQML();
                                this.controlC5_3_2 = new NuGenEQML();
                                this.controlC5_3_3 = new NuGenEQML();
                                this.controlC5_3_4 = new NuGenEQML();
                                this.controlC5_3_5 = new NuGenEQML();
                                this.controlC5_3_6 = new NuGenEQML();
                                this.controlC5_3_7 = new NuGenEQML();
                                this.controlC5_3_8 = new NuGenEQML();
                                this.controlC5_3_9 = new NuGenEQML();
                                list6 = new List<NuGenEQML> {
                                    this.controlC5_3_1,
                                    this.controlC5_3_2,
                                    this.controlC5_3_3,
                                    this.controlC5_3_4,
                                    this.controlC5_3_5,
                                    this.controlC5_3_6,
                                    this.controlC5_3_7,
                                    this.controlC5_3_8,
                                    this.controlC5_3_9
                                };
                                this.initControls(list6);
                                this.tableC5_3_1 = new TableLayoutPanel();
                                this.pictureBoxC5_3_1 = new PictureBox();
                                this.pictureBoxC5_3_2 = new PictureBox();
                                this.initPictureBox(this.pictureBoxC5_3_1);
                                this.initPictureBox(this.pictureBoxC5_3_2);
                                this.pictureBoxC5_3_1.Load("Images/3-1.jpg");
                                this.pictureBoxC5_3_2.Load("Images/3-2.jpg");
                                new InitControls().matrixThreeToThree(this.tableC5_3_1, list6);
                                this.flowLayoutPanel1.Controls.Add(this.pictureBoxC5_3_1);
                                this.flowLayoutPanel1.Controls.Add(this.tableC5_3_1);
                                this.flowLayoutPanel1.Controls.Add(this.pictureBoxC5_3_2);
                                this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC5_3_2, true);
                            }
                            else if (str.Equals("c6.xml"))
                            {
                                this.controlC6 = new NuGenEQML();
                                new C6().C6Generate(this.controlC6, (i + 1) + ".");
                                this.flowLayoutPanel1.Controls.Add(this.controlC6);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC6, true);
                                this.labelC6_1 = new Label();
                                this.initScoreLabel(this.labelC6_1);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_1);
                                this.labelC6_1_1 = new Label();
                                this.labelC6_1_2 = new Label();
                                this.labelC6_1_3 = new Label();
                                this.labelC6_1_4 = new Label();
                                this.initLabel(this.labelC6_1_1);
                                this.initLabel(this.labelC6_1_2);
                                this.initLabel(this.labelC6_1_3);
                                this.initLabel(this.labelC6_1_4);
                                this.labelC6_1_1.Text = "   (1)系数矩阵的秩R(A)=";
                                this.labelC6_1_2.Text = ",";
                                this.labelC6_1_3.Text = "增广矩阵的秩R(B)=";
                                this.labelC6_1_4.Text = ";";
                                this.textBoxC6_1_1 = new TextBox();
                                this.textBoxC6_1_2 = new TextBox();
                                list11 = new List<TextBox> {
                                    this.textBoxC6_1_1,
                                    this.textBoxC6_1_2
                                };
                                this.initTextBox(list11);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.textBoxC6_1_1);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_1_2);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_1_3);
                                this.flowLayoutPanel1.Controls.Add(this.textBoxC6_1_2);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_1_4);
                                this.flowLayoutPanel1.SetFlowBreak(this.labelC6_1_4, true);
                                this.labelC6_2 = new Label();
                                this.initScoreLabel(this.labelC6_2);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_2);
                                this.labelC6_2_1 = new Label();
                                this.labelC6_2_2 = new Label();
                                this.initLabel(this.labelC6_2_1);
                                this.initLabel(this.labelC6_2_2);
                                this.labelC6_2_1.Text = "   (2)线性方程组的导出组的一个基础解系为:(";
                                this.labelC6_2_2.Text = "(";
                                this.controlC6_2_1 = new NuGenEQML();
                                this.initsmallControl(this.controlC6_2_1);
                                this.controlC6_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>&comma;</mo></mtd></mtr></mtable></math>");
                                this.controlC6_2_3 = new NuGenEQML();
                                this.controlC6_2_4 = new NuGenEQML();
                                this.controlC6_2_5 = new NuGenEQML();
                                this.controlC6_2_6 = new NuGenEQML();
                                this.controlC6_2_7 = new NuGenEQML();
                                this.initControls(this.controlC6_2_3);
                                this.initControls(this.controlC6_2_4);
                                this.initControls(this.controlC6_2_5);
                                this.initControls(this.controlC6_2_6);
                                this.initControls(this.controlC6_2_7);
                                this.controlC6_2_2 = new NuGenEQML();
                                this.initsmallControl(this.controlC6_2_2);
                                this.controlC6_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_2_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_4);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_6);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_7);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_1);
                                this.controlC6_2_8 = new NuGenEQML();
                                this.controlC6_2_9 = new NuGenEQML();
                                this.controlC6_2_10 = new NuGenEQML();
                                this.controlC6_2_11 = new NuGenEQML();
                                this.controlC6_2_12 = new NuGenEQML();
                                this.initControls(this.controlC6_2_8);
                                this.initControls(this.controlC6_2_9);
                                this.initControls(this.controlC6_2_10);
                                this.initControls(this.controlC6_2_11);
                                this.initControls(this.controlC6_2_12);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_2_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_8);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_9);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_10);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_11);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_12);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_2_2);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC6_2_2, true);
                                this.labelC6_3 = new Label();
                                this.initScoreLabel(this.labelC6_3);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_3);
                                this.labelC6_3_1 = new Label();
                                this.initLabel(this.labelC6_3_1);
                                this.labelC6_3_1.Text = "   (3)线性方程组的一个特解为：(";
                                this.controlC6_3_1 = new NuGenEQML();
                                this.initsmallControl(this.controlC6_3_1);
                                this.controlC6_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msup><mrow><mo>&rpar;</mo></mrow><mrow><mi>T</mi></mrow></msup><mo>;</mo></mtd></mtr></mtable></math>");
                                this.controlC6_3_2 = new NuGenEQML();
                                this.controlC6_3_3 = new NuGenEQML();
                                this.controlC6_3_4 = new NuGenEQML();
                                this.controlC6_3_5 = new NuGenEQML();
                                this.controlC6_3_6 = new NuGenEQML();
                                this.initControls(this.controlC6_3_2);
                                this.initControls(this.controlC6_3_3);
                                this.initControls(this.controlC6_3_4);
                                this.initControls(this.controlC6_3_5);
                                this.initControls(this.controlC6_3_6);
                                this.flowLayoutPanel1.Controls.Add(this.labelC6_3_1);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_2);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_3);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_4);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_5);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_6);
                                this.flowLayoutPanel1.Controls.Add(this.controlC6_3_1);
                                this.flowLayoutPanel1.SetFlowBreak(this.controlC6_3_1, true);
                            }
                            else
                            {
                                List<TextBox> list12;
                                List<TextBox> list13;
                                if (str.Equals("c7.xml"))
                                {
                                    this.controlC7 = new NuGenEQML();
                                    new C7().C7Generate(this.controlC7, (i + 1) + ".");
                                    this.flowLayoutPanel1.Controls.Add(this.controlC7);
                                    this.flowLayoutPanel1.SetFlowBreak(this.controlC7, true);
                                    this.labelC7_1 = new Label();
                                    this.initScoreLabel(this.labelC7_1);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_1);
                                    this.tableC7_1_1 = new TableLayoutPanel();
                                    this.labelC7_1_1 = new Label();
                                    this.initLabel(this.labelC7_1_1);
                                    this.labelC7_1_1.Text = "   (1)";
                                    this.controlC7_1_1 = new NuGenEQML();
                                    this.controlC7_1_1.Width = 200;
                                    this.controlC7_1_1.Height = 30;
                                    this.controlC7_1_1.Anchor = AnchorStyles.None;
                                    this.controlC7_1_1.Enabled = false;
                                    this.controlC7_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>矩阵A的逆矩阵为</mi><mspace /><msup><mrow><mi>A</mi></mrow><mrow><mo>&minus;</mo><mn>1</mn></mrow></msup><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.textBoxC7_1_1 = new TextBox();
                                    this.textBoxC7_1_2 = new TextBox();
                                    this.textBoxC7_1_3 = new TextBox();
                                    this.textBoxC7_1_4 = new TextBox();
                                    this.textBoxC7_1_5 = new TextBox();
                                    this.textBoxC7_1_6 = new TextBox();
                                    this.textBoxC7_1_7 = new TextBox();
                                    this.textBoxC7_1_8 = new TextBox();
                                    this.textBoxC7_1_9 = new TextBox();
                                    list11 = new List<TextBox> {
                                        this.textBoxC7_1_1,
                                        this.textBoxC7_1_2,
                                        this.textBoxC7_1_3,
                                        this.textBoxC7_1_4,
                                        this.textBoxC7_1_5,
                                        this.textBoxC7_1_6,
                                        this.textBoxC7_1_7,
                                        this.textBoxC7_1_8,
                                        this.textBoxC7_1_9
                                    };
                                    this.initTextBox(list11);
                                    this.pictureBoxC7_1_1 = new PictureBox();
                                    this.pictureBoxC7_1_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC7_1_1);
                                    this.initPictureBox(this.pictureBoxC7_1_2);
                                    this.pictureBoxC7_1_1.Load("Images/3-1-1.jpg");
                                    this.pictureBoxC7_1_2.Load("Images/3-2-2.jpg");
                                    new InitControls().matrixThreeToThree(this.tableC7_1_1, list11);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC7_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC7_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_1_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC7_1_2, true);
                                    this.labelC7_2 = new Label();
                                    this.initScoreLabel(this.labelC7_2);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_2);
                                    this.labelC7_2_1 = new Label();
                                    this.initLabel(this.labelC7_2_1);
                                    this.labelC7_2_1.Text = "   (2)";
                                    this.controlC7_2_1 = new NuGenEQML();
                                    this.controlC7_2_1.Width = 200;
                                    this.controlC7_2_1.Height = 30;
                                    this.controlC7_2_1.Anchor = AnchorStyles.None;
                                    this.controlC7_2_1.Enabled = false;
                                    this.controlC7_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>矩阵B的逆矩阵为</mi><mspace /><msup><mrow><mi>B</mi></mrow><mrow><mo>&minus;</mo><mn>1</mn></mrow></msup><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.textBoxC7_2_1 = new TextBox();
                                    this.textBoxC7_2_2 = new TextBox();
                                    this.textBoxC7_2_3 = new TextBox();
                                    this.textBoxC7_2_4 = new TextBox();
                                    list12 = new List<TextBox> {
                                        this.textBoxC7_2_1,
                                        this.textBoxC7_2_2,
                                        this.textBoxC7_2_3,
                                        this.textBoxC7_2_4
                                    };
                                    this.initTextBox(list12);
                                    this.tableC7_2_1 = new TableLayoutPanel();
                                    new InitControls().matrixTwoToTwo(this.tableC7_2_1, list12);
                                    this.pictureBoxC7_2_1 = new PictureBox();
                                    this.pictureBoxC7_2_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC7_2_1);
                                    this.initPictureBox(this.pictureBoxC7_2_2);
                                    this.pictureBoxC7_2_1.Load("Images/2-1.jpg");
                                    this.pictureBoxC7_2_2.Load("Images/2-2.jpg");
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC7_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC7_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_2_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC7_2_2, true);
                                    this.labelC7_3 = new Label();
                                    this.initScoreLabel(this.labelC7_3);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_3);
                                    this.labelC7_3_1 = new Label();
                                    this.initLabel(this.labelC7_3_1);
                                    this.labelC7_3_1.Text = "   (3)矩阵方程AXB=C的解为X=";
                                    this.textBoxC7_3_1 = new TextBox();
                                    this.textBoxC7_3_2 = new TextBox();
                                    this.textBoxC7_3_3 = new TextBox();
                                    this.textBoxC7_3_4 = new TextBox();
                                    this.textBoxC7_3_5 = new TextBox();
                                    this.textBoxC7_3_6 = new TextBox();
                                    list13 = new List<TextBox> {
                                        this.textBoxC7_3_1,
                                        this.textBoxC7_3_2,
                                        this.textBoxC7_3_3,
                                        this.textBoxC7_3_4,
                                        this.textBoxC7_3_5,
                                        this.textBoxC7_3_6
                                    };
                                    this.initTextBox(list13);
                                    this.pictureBoxC7_3_1 = new PictureBox();
                                    this.pictureBoxC7_3_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC7_3_1);
                                    this.initPictureBox(this.pictureBoxC7_3_2);
                                    this.pictureBoxC7_3_1.Load("Images/3-1-1.jpg");
                                    this.pictureBoxC7_3_2.Load("Images/3-2-2.jpg");
                                    this.tableC7_3_1 = new TableLayoutPanel();
                                    new InitControls().matrixTwoToThree(this.tableC7_3_1, list13);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC7_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC7_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC7_3_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC7_3_2, true);
                                }
                                else if (str.Equals("c8.xml"))
                                {
                                    this.controlC8 = new NuGenEQML();
                                    new C8().C8Generate(this.controlC8, (i + 1) + ".");
                                    this.flowLayoutPanel1.Controls.Add(this.controlC8);
                                    this.flowLayoutPanel1.SetFlowBreak(this.controlC8, true);
                                    this.labelC8_1 = new Label();
                                    this.initScoreLabel(this.labelC8_1);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_1);
                                    this.labelC8_1_1 = new Label();
                                    this.initLabel(this.labelC8_1_1);
                                    this.labelC8_1_1.Text = "   (1)";
                                    this.controlC8_1_1 = new NuGenEQML();
                                    this.controlC8_1_1.Width = 200;
                                    this.controlC8_1_1.Height = 30;
                                    this.controlC8_1_1.Anchor = AnchorStyles.None;
                                    this.controlC8_1_1.Enabled = false;
                                    this.controlC8_1_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><mi>矩阵A的逆矩阵为</mi><mspace /><msup><mrow><mi>A</mi></mrow><mrow><mo>&minus;</mo><mn>1</mn></mrow></msup><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.textBoxC8_1_1 = new TextBox();
                                    this.textBoxC8_1_2 = new TextBox();
                                    this.textBoxC8_1_3 = new TextBox();
                                    this.textBoxC8_1_4 = new TextBox();
                                    this.textBoxC8_1_5 = new TextBox();
                                    this.textBoxC8_1_6 = new TextBox();
                                    this.textBoxC8_1_7 = new TextBox();
                                    this.textBoxC8_1_8 = new TextBox();
                                    this.textBoxC8_1_9 = new TextBox();
                                    list11 = new List<TextBox> {
                                        this.textBoxC8_1_1,
                                        this.textBoxC8_1_2,
                                        this.textBoxC8_1_3,
                                        this.textBoxC8_1_4,
                                        this.textBoxC8_1_5,
                                        this.textBoxC8_1_6,
                                        this.textBoxC8_1_7,
                                        this.textBoxC8_1_8,
                                        this.textBoxC8_1_9
                                    };
                                    this.initTextBox(list11);
                                    this.tableC8_1_1 = new TableLayoutPanel();
                                    this.pictureBoxC8_1_1 = new PictureBox();
                                    this.pictureBoxC8_1_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC8_1_1);
                                    this.initPictureBox(this.pictureBoxC8_1_2);
                                    this.pictureBoxC8_1_1.Load("Images/3-1-1.jpg");
                                    this.pictureBoxC8_1_2.Load("Images/3-2-2.jpg");
                                    new InitControls().matrixThreeToThree(this.tableC8_1_1, list11);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC8_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC8_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_1_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC8_1_2, true);
                                    this.labelC8_2 = new Label();
                                    this.initScoreLabel(this.labelC8_2);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_2);
                                    this.labelC8_2_1 = new Label();
                                    this.initLabel(this.labelC8_2_1);
                                    this.labelC8_2_1.Text = "   (2)矩阵C-B=";
                                    this.textBoxC8_2_1 = new TextBox();
                                    this.textBoxC8_2_2 = new TextBox();
                                    this.textBoxC8_2_3 = new TextBox();
                                    this.textBoxC8_2_4 = new TextBox();
                                    this.textBoxC8_2_5 = new TextBox();
                                    this.textBoxC8_2_6 = new TextBox();
                                    list12 = new List<TextBox> {
                                        this.textBoxC8_2_1,
                                        this.textBoxC8_2_2,
                                        this.textBoxC8_2_3,
                                        this.textBoxC8_2_4,
                                        this.textBoxC8_2_5,
                                        this.textBoxC8_2_6
                                    };
                                    this.initTextBox(list12);
                                    this.tableC8_2_1 = new TableLayoutPanel();
                                    this.pictureBoxC8_2_1 = new PictureBox();
                                    this.pictureBoxC8_2_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC8_2_1);
                                    this.initPictureBox(this.pictureBoxC8_2_2);
                                    this.pictureBoxC8_2_1.Load("Images/3-1-1.jpg");
                                    this.pictureBoxC8_2_2.Load("Images/3-2-2.jpg");
                                    new InitControls().matrixTwoToThree(this.tableC8_2_1, list12);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC8_2_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_2_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC8_2_2, true);
                                    this.labelC8_3 = new Label();
                                    this.initScoreLabel(this.labelC8_3);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_3);
                                    this.tableC8_3_1 = new TableLayoutPanel();
                                    this.labelC8_3_1 = new Label();
                                    this.initLabel(this.labelC8_3_1);
                                    this.labelC8_3_1.Text = "   (3)矩阵方程AX+B=C的解为X=";
                                    this.textBoxC8_3_1 = new TextBox();
                                    this.textBoxC8_3_2 = new TextBox();
                                    this.textBoxC8_3_3 = new TextBox();
                                    this.textBoxC8_3_4 = new TextBox();
                                    this.textBoxC8_3_5 = new TextBox();
                                    this.textBoxC8_3_6 = new TextBox();
                                    list13 = new List<TextBox> {
                                        this.textBoxC8_3_1,
                                        this.textBoxC8_3_2,
                                        this.textBoxC8_3_3,
                                        this.textBoxC8_3_4,
                                        this.textBoxC8_3_5,
                                        this.textBoxC8_3_6
                                    };
                                    this.initTextBox(list13);
                                    this.pictureBoxC8_3_1 = new PictureBox();
                                    this.pictureBoxC8_3_2 = new PictureBox();
                                    this.initPictureBox(this.pictureBoxC8_3_1);
                                    this.initPictureBox(this.pictureBoxC8_3_2);
                                    this.pictureBoxC8_3_1.Load("Images/3-1-1.jpg");
                                    this.pictureBoxC8_3_2.Load("Images/3-2-2.jpg");
                                    new InitControls().matrixTwoToThree(this.tableC8_3_1, list13);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC8_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.tableC8_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxC8_3_2);
                                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxC8_3_2, true);
                                }
                                else if (str.Equals("c9.xml"))
                                {
                                    this.controlC9 = new NuGenEQML();
                                    new C9().C9Generate(this.controlC9, (i + 1) + ".");
                                    this.flowLayoutPanel1.Controls.Add(this.controlC9);
                                    this.flowLayoutPanel1.SetFlowBreak(this.controlC9, true);
                                    this.labelC9_1 = new Label();
                                    this.initScoreLabel(this.labelC9_1);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_1);
                                    this.labelC9_1_1 = new Label();
                                    this.initLabel(this.labelC9_1_1);
                                    this.labelC9_1_1.Text = "   (1)方程组系数行列式D=";
                                    this.textBoxC9_1_1 = new TextBox();
                                    this.initTextBox(this.textBoxC9_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_1_1);
                                    this.flowLayoutPanel1.Controls.Add(this.textBoxC9_1_1);
                                    this.flowLayoutPanel1.SetFlowBreak(this.textBoxC9_1_1, true);
                                    this.labelC9_2 = new Label();
                                    this.initScoreLabel(this.labelC9_2);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_2);
                                    this.labelC9_2_1 = new Label();
                                    this.initLabel(this.labelC9_2_1);
                                    Panel panel = new Panel {
                                        Width = 350,
                                        Height = 0x19,
                                        Anchor = AnchorStyles.None
                                    };
                                    this.labelC9_2_1.Text = "   (2）方程组的解情况为(";
                                    this.radiobuttonC9_2_1 = new RadioButton();
                                    this.radiobuttonC9_2_1.Name = "choose1";
                                    this.radiobuttonC9_2_1.Text = "无解；";
                                    this.radiobuttonC9_2_1.Anchor = AnchorStyles.None;
                                    this.radiobuttonC9_2_1.Font = new Font("宋体", 14f);
                                    this.radiobuttonC9_2_1.AutoSize = true;
                                    this.radiobuttonC9_2_2 = new RadioButton();
                                    this.radiobuttonC9_2_2.Name = "choose1";
                                    this.radiobuttonC9_2_2.Text = "唯一解；";
                                    this.radiobuttonC9_2_2.Anchor = AnchorStyles.None;
                                    this.radiobuttonC9_2_2.Font = new Font("宋体", 14f);
                                    this.radiobuttonC9_2_2.AutoSize = true;
                                    this.radiobuttonC9_2_3 = new RadioButton();
                                    this.radiobuttonC9_2_3.Name = "choose1";
                                    this.radiobuttonC9_2_3.Text = "无穷多解);";
                                    this.radiobuttonC9_2_3.Width = 180;
                                    this.radiobuttonC9_2_3.Anchor = AnchorStyles.None;
                                    this.radiobuttonC9_2_3.Font = new Font("宋体", 14f);
                                    this.radiobuttonC9_2_3.AutoSize = true;
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_2_1);
                                    this.radiobuttonC9_2_1.Location = new Point(3, 0);
                                    this.radiobuttonC9_2_2.Location = new Point(100, 0);
                                    this.radiobuttonC9_2_3.Location = new Point(210, 0);
                                    panel.Controls.Add(this.radiobuttonC9_2_1);
                                    panel.Controls.Add(this.radiobuttonC9_2_2);
                                    panel.Controls.Add(this.radiobuttonC9_2_3);
                                    this.flowLayoutPanel1.Controls.Add(panel);
                                    this.flowLayoutPanel1.SetFlowBreak(panel, true);
                                    this.labelC9_3 = new Label();
                                    this.initScoreLabel(this.labelC9_3);
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_3);
                                    this.labelC9_3_1 = new Label();
                                    this.initLabel(this.labelC9_3_1);
                                    this.labelC9_3_1.Text = "   (3)方程组的解为";
                                    this.controlC9_3_1 = new NuGenEQML();
                                    this.controlC9_3_2 = new NuGenEQML();
                                    this.controlC9_3_3 = new NuGenEQML();
                                    this.initsmallControl(this.controlC9_3_1);
                                    this.initsmallControl(this.controlC9_3_2);
                                    this.initsmallControl(this.controlC9_3_3);
                                    this.textBoxC9_3_1 = new TextBox();
                                    this.textBoxC9_3_2 = new TextBox();
                                    this.textBoxC9_3_3 = new TextBox();
                                    this.initTextBox(this.textBoxC9_3_1);
                                    this.initTextBox(this.textBoxC9_3_2);
                                    this.initTextBox(this.textBoxC9_3_3);
                                    this.controlC9_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.controlC9_3_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.controlC9_3_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                    this.flowLayoutPanel1.Controls.Add(this.labelC9_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC9_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.textBoxC9_3_1);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC9_3_2);
                                    this.flowLayoutPanel1.Controls.Add(this.textBoxC9_3_2);
                                    this.flowLayoutPanel1.Controls.Add(this.controlC9_3_3);
                                    this.flowLayoutPanel1.Controls.Add(this.textBoxC9_3_3);
                                    this.flowLayoutPanel1.SetFlowBreak(this.textBoxC9_3_3, true);
                                }
                                else
                                {
                                    PictureBox box;
                                    if (str.Equals("c10.xml"))
                                    {
                                        this.controlC10 = new NuGenEQML();
                                        new C10().C10Generate(this.controlC10, (i + 1) + ".");
                                        this.flowLayoutPanel1.Controls.Add(this.controlC10);
                                        this.flowLayoutPanel1.SetFlowBreak(this.controlC10, true);
                                        this.labelC10_1 = new Label();
                                        this.initScoreLabel(this.labelC10_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_1);
                                        this.labelC10_1_1 = new Label();
                                        this.initLabel(this.labelC10_1_1);
                                        this.labelC10_1_1.Text = "   (1)当a";
                                        this.labelC10_1_2 = new Label();
                                        this.initLabel(this.labelC10_1_2);
                                        this.comboBoxC10_1_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC10_1_1);
                                        this.labelC10_1_2.Text = "时，方程组无解；";
                                        this.textBoxC10_1_1 = new TextBox();
                                        this.initTextBox(this.textBoxC10_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC10_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_1_2);
                                        this.flowLayoutPanel1.SetFlowBreak(this.labelC10_1_2, true);
                                        this.labelC10_2 = new Label();
                                        this.initScoreLabel(this.labelC10_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_2);
                                        this.labelC10_2_1 = new Label();
                                        this.initLabel(this.labelC10_2_1);
                                        this.labelC10_2_1.Text = "   (2)当a";
                                        this.comboBoxC10_2_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC10_2_1);
                                        this.comboBoxC10_2_2 = new ComboBox();
                                        this.initComboBox(this.comboBoxC10_2_2);
                                        this.comboBoxC10_2_3 = new ComboBox();
                                        this.initMyComboBox(this.comboBoxC10_2_3);
                                        this.labelC10_2_2 = new Label();
                                        this.initLabel(this.labelC10_2_2);
                                        this.labelC10_2_2.Text = "时，方程组有唯一解，且解为：";
                                        this.controlC10_2_1 = new NuGenEQML();
                                        this.controlC10_2_2 = new NuGenEQML();
                                        this.controlC10_2_3 = new NuGenEQML();
                                        this.controlC10_2_4 = new NuGenEQML();
                                        this.initsmallControl(this.controlC10_2_1);
                                        this.initsmallControl(this.controlC10_2_2);
                                        this.initsmallControl(this.controlC10_2_3);
                                        this.initsmallControl(this.controlC10_2_4);
                                        this.controlC10_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_2_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_2_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>4</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.textBoxC10_2_1 = new TextBox();
                                        this.textBoxC10_2_2 = new TextBox();
                                        this.textBoxC10_2_3 = new TextBox();
                                        this.textBoxC10_2_4 = new TextBox();
                                        this.textBoxC10_2_5 = new TextBox();
                                        this.textBoxC10_2_6 = new TextBox();
                                        this.initTextBox(this.textBoxC10_2_1);
                                        this.initTextBox(this.textBoxC10_2_2);
                                        this.initTextBox(this.textBoxC10_2_3);
                                        this.initTextBox(this.textBoxC10_2_4);
                                        this.initTextBox(this.textBoxC10_2_5);
                                        this.initTextBox(this.textBoxC10_2_6);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC10_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC10_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC10_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC10_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC10_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_4);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC10_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_5);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC10_2_4);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_2_6);
                                        this.flowLayoutPanel1.SetFlowBreak(this.textBoxC10_2_6, true);
                                        this.labelC10_3 = new Label();
                                        this.initScoreLabel(this.labelC10_3);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_3);
                                        this.labelC10_3_1 = new Label();
                                        this.labelC10_3_2 = new Label();
                                        this.initLabel(this.labelC10_3_1);
                                        this.labelC10_3_1.Text = "   (3)当a";
                                        this.initLabel(this.labelC10_3_2);
                                        this.labelC10_3_2.Text = "时，方程组有无穷多解，且通解为：";
                                        this.comboBoxC10_3_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC10_3_1);
                                        this.textBoxC10_3_1 = new TextBox();
                                        this.initTextBox(this.textBoxC10_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC10_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC10_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC10_3_2);
                                        box = new PictureBox();
                                        this.initPictureBox(box);
                                        box.Load("Images/lbrace-4.jpg");
                                        this.controlC10_3_1 = new NuGenEQML();
                                        this.controlC10_3_2 = new NuGenEQML();
                                        this.controlC10_3_3 = new NuGenEQML();
                                        this.controlC10_3_4 = new NuGenEQML();
                                        this.initsmallControl(this.controlC10_3_1);
                                        this.initsmallControl(this.controlC10_3_2);
                                        this.initsmallControl(this.controlC10_3_3);
                                        this.initsmallControl(this.controlC10_3_4);
                                        this.controlC10_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_3_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_3_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC10_3_4.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>4</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.textBoxC10_3_2 = new TextBox();
                                        this.initTextBox(this.textBoxC10_3_2);
                                        this.textBoxC10_3_3 = new TextBox();
                                        this.initTextBox(this.textBoxC10_3_3);
                                        this.textBoxC10_3_4 = new TextBox();
                                        this.initTextBox(this.textBoxC10_3_4);
                                        this.textBoxC10_3_5 = new TextBox();
                                        this.initTextBox(this.textBoxC10_3_5);
                                        this.flowLayoutPanel1.Controls.Add(box);
                                        this.labelC10_3_3 = new Label();
                                        this.initLabel(this.labelC10_3_3);
                                        this.labelC10_3_3.Text = "(用c,d,k表示任意实数 参数与数字之间要用“*”连接,例如，3+2/(3*c)，3+2/c)";
                                        FlowLayoutPanel panel2 = new FlowLayoutPanel {
                                            AutoSize = true
                                        };
                                        panel2.Controls.Add(this.controlC10_3_1);
                                        panel2.Controls.Add(this.textBoxC10_3_2);
                                        panel2.SetFlowBreak(this.textBoxC10_3_2, true);
                                        panel2.Controls.Add(this.controlC10_3_2);
                                        panel2.Controls.Add(this.textBoxC10_3_3);
                                        panel2.SetFlowBreak(this.textBoxC10_3_3, true);
                                        panel2.Controls.Add(this.controlC10_3_3);
                                        panel2.Controls.Add(this.textBoxC10_3_4);
                                        panel2.Controls.Add(this.labelC10_3_3);
                                        panel2.SetFlowBreak(this.labelC10_3_3, true);
                                        panel2.Controls.Add(this.controlC10_3_4);
                                        panel2.Controls.Add(this.textBoxC10_3_5);
                                        panel2.SetFlowBreak(this.textBoxC10_3_5, true);
                                        this.flowLayoutPanel1.Controls.Add(panel2);
                                        this.flowLayoutPanel1.SetFlowBreak(panel2, true);
                                    }
                                    else if (str.Equals("c11.xml"))
                                    {
                                        this.controlC11 = new NuGenEQML();
                                        new C11().C11Generate(this.controlC11, (i + 1) + ".");
                                        this.flowLayoutPanel1.Controls.Add(this.controlC11);
                                        this.flowLayoutPanel1.SetFlowBreak(this.controlC11, true);
                                        this.labelC11_1 = new Label();
                                        this.initScoreLabel(this.labelC11_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_1);
                                        this.labelC11_1_1 = new Label();
                                        this.labelC11_1_1.Text = "   (1)当a";
                                        this.initLabel(this.labelC11_1_1);
                                        this.labelC11_1_2 = new Label();
                                        this.labelC11_1_2.Text = ",b";
                                        this.initLabel(this.labelC11_1_2);
                                        this.labelC11_1_3 = new Label();
                                        this.labelC11_1_3.Text = "时（注：当a或b任意取值时，对应空不填，下同），方程组无解";
                                        this.initLabel(this.labelC11_1_3);
                                        this.textBoxC11_1_1 = new TextBox();
                                        this.textBoxC11_1_2 = new TextBox();
                                        this.initTextBox(this.textBoxC11_1_1);
                                        this.initTextBox(this.textBoxC11_1_2);
                                        this.comboBoxC11_1_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_1_1);
                                        this.comboBoxC11_1_2 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_1_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_1_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_1_2);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_1_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_1_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_1_3);
                                        this.flowLayoutPanel1.SetFlowBreak(this.labelC11_1_3, true);
                                        this.labelC11_2 = new Label();
                                        this.initScoreLabel(this.labelC11_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_2);
                                        this.labelC11_2_1 = new Label();
                                        this.labelC11_2_1.Text = "   (2)当a";
                                        this.initLabel(this.labelC11_2_1);
                                        this.labelC11_2_2 = new Label();
                                        this.labelC11_2_2.Text = ",b";
                                        this.initLabel(this.labelC11_2_2);
                                        this.labelC11_2_3 = new Label();
                                        this.labelC11_2_3.Text = "时，方程组有唯一解，且解为:";
                                        this.initLabel(this.labelC11_2_3);
                                        this.controlC11_2_1 = new NuGenEQML();
                                        this.controlC11_2_2 = new NuGenEQML();
                                        this.controlC11_2_3 = new NuGenEQML();
                                        this.initsmallControl(this.controlC11_2_1);
                                        this.initsmallControl(this.controlC11_2_2);
                                        this.initsmallControl(this.controlC11_2_3);
                                        this.controlC11_2_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC11_2_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC11_2_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.comboBoxC11_2_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_2_1);
                                        this.comboBoxC11_2_2 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_2_2);
                                        this.textBoxC11_2_1 = new TextBox();
                                        this.initTextBox(this.textBoxC11_2_1);
                                        this.textBoxC11_2_2 = new TextBox();
                                        this.initTextBox(this.textBoxC11_2_2);
                                        this.textBoxC11_2_3 = new TextBox();
                                        this.initTextBox(this.textBoxC11_2_3);
                                        this.textBoxC11_2_4 = new TextBox();
                                        this.initTextBox(this.textBoxC11_2_4);
                                        this.textBoxC11_2_5 = new TextBox();
                                        this.initTextBox(this.textBoxC11_2_5);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC11_2_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC11_2_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_2_4);
                                        this.flowLayoutPanel1.Controls.Add(this.controlC11_2_3);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_2_5);
                                        this.flowLayoutPanel1.SetFlowBreak(this.textBoxC11_2_5, true);
                                        this.labelC11_3 = new Label();
                                        this.initScoreLabel(this.labelC11_3);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_3);
                                        this.labelC11_3_1 = new Label();
                                        this.initLabel(this.labelC11_3_1);
                                        this.labelC11_3_1.Text = "   (3)当a";
                                        this.labelC11_3_2 = new Label();
                                        this.initLabel(this.labelC11_3_2);
                                        this.labelC11_3_2.Text = ",b";
                                        this.labelC11_3_3 = new Label();
                                        this.initLabel(this.labelC11_3_3);
                                        this.labelC11_3_3.Text = "时,方程组有无穷多解,且通解为:";
                                        this.labelC11_3_4 = new Label();
                                        this.initLabel(this.labelC11_3_4);
                                        this.labelC11_3_4.Text = "(用c,d,k表示任意实数 参数与数字之间要用“*”连接,例如，2/3+(4/3)*c,2/3+4*c/3)";
                                        box = new PictureBox();
                                        this.initPictureBox(box);
                                        box.Load("Images/lbrace-3.jpg");
                                        this.controlC11_3_1 = new NuGenEQML();
                                        this.controlC11_3_2 = new NuGenEQML();
                                        this.controlC11_3_3 = new NuGenEQML();
                                        this.initsmallControl(this.controlC11_3_1);
                                        this.initsmallControl(this.controlC11_3_2);
                                        this.initsmallControl(this.controlC11_3_3);
                                        this.controlC11_3_1.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>1</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC11_3_2.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>2</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.controlC11_3_3.pub_LoadXML("<math xmlns=\"http://www.w3.org/1998/Math/MathML\"><mtable><mtr><mtd><msub><mrow><mi>x</mi></mrow><mrow><mn>3</mn></mrow></msub><mo>&equals;</mo></mtd></mtr></mtable></math>");
                                        this.textBoxC11_3_1 = new TextBox();
                                        this.initTextBox(this.textBoxC11_3_1);
                                        this.textBoxC11_3_2 = new TextBox();
                                        this.initTextBox(this.textBoxC11_3_2);
                                        this.textBoxC11_3_3 = new TextBox();
                                        this.initTextBox(this.textBoxC11_3_3);
                                        this.textBoxC11_3_4 = new TextBox();
                                        this.initTextBox(this.textBoxC11_3_4);
                                        this.textBoxC11_3_5 = new TextBox();
                                        this.initTextBox(this.textBoxC11_3_5);
                                        this.comboBoxC11_3_1 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_3_1);
                                        this.comboBoxC11_3_2 = new ComboBox();
                                        this.initComboBox(this.comboBoxC11_3_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_3_1);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_3_2);
                                        this.flowLayoutPanel1.Controls.Add(this.comboBoxC11_3_2);
                                        this.flowLayoutPanel1.Controls.Add(this.textBoxC11_3_2);
                                        this.flowLayoutPanel1.Controls.Add(this.labelC11_3_3);
                                        this.flowLayoutPanel1.Controls.Add(box);
                                        FlowLayoutPanel panel3 = new FlowLayoutPanel {
                                            AutoSize = true
                                        };
                                        panel3.Controls.Add(this.controlC11_3_1);
                                        panel3.Controls.Add(this.textBoxC11_3_3);
                                        panel3.SetFlowBreak(this.textBoxC11_3_3, true);
                                        panel3.Controls.Add(this.controlC11_3_2);
                                        panel3.Controls.Add(this.textBoxC11_3_4);
                                        panel3.Controls.Add(this.labelC11_3_4);
                                        panel3.SetFlowBreak(this.labelC11_3_4, true);
                                        panel3.Controls.Add(this.controlC11_3_3);
                                        panel3.Controls.Add(this.textBoxC11_3_5);
                                        this.flowLayoutPanel1.Controls.Add(panel3);
                                        this.flowLayoutPanel1.SetFlowBreak(panel3, true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void assignGapfillingControls(List<string> gapfillingTest)
        {
            this.labelG = new Label();
            this.labelG.Font = new Font("宋体", 30f);
            this.labelG.AutoSize = true;
            this.labelG.Text = "二、填空题（每小题5分，共25分，把正确答案填入到题中的括号内）";
            this.flowLayoutPanel1.Controls.Add(this.labelG);
            this.flowLayoutPanel1.SetFlowBreak(this.labelG, true);
            for (int i = 0; i < gapfillingTest.Count; i++)
            {
                string str = gapfillingTest[i];
                if (str.Equals("g_one_1.xml"))
                {
                    this.labelG1_1 = new Label();
                    this.initScoreLabel(this.labelG1_1);
                    this.controlG1_1_1 = new NuGenEQML();
                    this.textBoxG1_1_1 = new TextBox();
                    this.initTextBox(this.textBoxG1_1_1);
                    this.pictureBoxG1_1_1 = new PictureBox();
                    this.pictureBoxG1_1_2 = new PictureBox();
                    this.initPictureBox(this.pictureBoxG1_1_1);
                    this.initPictureBox(this.pictureBoxG1_1_2);
                    this.pictureBoxG1_1_1.Load("Images/5-1.jpg");
                    this.pictureBoxG1_1_2.Load("Images/5-2.jpg");
                    new G_one_1().g_one_1Generate(this.controlG1_1_1, (i + 1) + ".");
                    this.flowLayoutPanel1.Controls.Add(this.labelG1_1);
                    this.flowLayoutPanel1.Controls.Add(this.controlG1_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG1_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxG1_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG1_1_2);
                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG1_1_2, true);
                }
                else if (str.Equals("g_one_2.xml"))
                {
                    this.labelG1_2 = new Label();
                    this.initScoreLabel(this.labelG1_2);
                    this.controlG1_2_1 = new NuGenEQML();
                    this.textBoxG1_2_1 = new TextBox();
                    this.initTextBox(this.textBoxG1_2_1);
                    this.pictureBoxG1_2_1 = new PictureBox();
                    this.pictureBoxG1_2_2 = new PictureBox();
                    this.initPictureBox(this.pictureBoxG1_2_1);
                    this.initPictureBox(this.pictureBoxG1_2_2);
                    this.pictureBoxG1_2_1.Load("Images/5-1.jpg");
                    this.pictureBoxG1_2_2.Load("Images/5-2.jpg");
                    new G_one_2().g_one_2Generate(this.controlG1_2_1, (i + 1) + ".");
                    this.flowLayoutPanel1.Controls.Add(this.labelG1_2);
                    this.flowLayoutPanel1.Controls.Add(this.controlG1_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG1_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.textBoxG1_2_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG1_2_2);
                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG1_2_2, true);
                }
                else if (str.Equals("g_two_1.xml"))
                {
                    this.labelG2_1 = new Label();
                    this.initScoreLabel(this.labelG2_1);
                    this.flowLayoutPanel1.Controls.Add(this.labelG2_1);
                    this.textBoxGT2_1_1 = new TextBox();
                    this.textBoxGT2_1_2 = new TextBox();
                    this.textBoxGT2_1_3 = new TextBox();
                    this.textBoxGT2_1_4 = new TextBox();
                    this.textBoxGT2_1_5 = new TextBox();
                    this.textBoxGT2_1_6 = new TextBox();
                    this.textBoxGT2_1_7 = new TextBox();
                    this.textBoxGT2_1_8 = new TextBox();
                    this.textBoxGT2_1_9 = new TextBox();
                    this.textBoxGT2_1_10 = new TextBox();
                    this.textBoxGT2_1_11 = new TextBox();
                    this.textBoxGT2_1_12 = new TextBox();
                    this.textBoxGT2_1_13 = new TextBox();
                    this.textBoxGT2_1_14 = new TextBox();
                    this.textBoxGT2_1_15 = new TextBox();
                    this.textBoxGT2_1_16 = new TextBox();
                    List<TextBox> lists = new List<TextBox> {
                        this.textBoxGT2_1_1,
                        this.textBoxGT2_1_2,
                        this.textBoxGT2_1_3,
                        this.textBoxGT2_1_4,
                        this.textBoxGT2_1_5,
                        this.textBoxGT2_1_6,
                        this.textBoxGT2_1_7,
                        this.textBoxGT2_1_8,
                        this.textBoxGT2_1_9,
                        this.textBoxGT2_1_10,
                        this.textBoxGT2_1_11,
                        this.textBoxGT2_1_12,
                        this.textBoxGT2_1_13,
                        this.textBoxGT2_1_14,
                        this.textBoxGT2_1_15,
                        this.textBoxGT2_1_16
                    };
                    this.initTextBox(lists);
                    this.pictureBoxG2_1_1 = new PictureBox();
                    this.pictureBoxG2_1_2 = new PictureBox();
                    this.initPictureBox(this.pictureBoxG2_1_1);
                    this.initPictureBox(this.pictureBoxG2_1_2);
                    this.pictureBoxG2_1_1.Load("Images/4-1-1.jpg");
                    this.pictureBoxG2_1_2.Load("Images/4-2-1.jpg");
                    this.controlG2_1_1 = new NuGenEQML();
                    this.tableG2_1_1 = new TableLayoutPanel();
                    new G_two_1().g_two_1Generate(this.controlG2_1_1, this.tableG2_1_1, lists, (i + 1) + ".");
                    this.flowLayoutPanel1.Controls.Add(this.controlG2_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.tableG2_1_1);
                    this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_1_2);
                    this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_1_2, true);
                }
                else
                {
                    List<TextBox> list2;
                    if (str.Equals("g_two_2_1.xml"))
                    {
                        this.labelG2_2_1 = new Label();
                        this.initScoreLabel(this.labelG2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_1);
                        this.controlG2_2_1_1 = new NuGenEQML();
                        this.tableG2_2_1_1 = new TableLayoutPanel();
                        this.textBoxG2_2_1_1 = new TextBox();
                        this.textBoxG2_2_1_2 = new TextBox();
                        this.textBoxG2_2_1_3 = new TextBox();
                        this.textBoxG2_2_1_4 = new TextBox();
                        this.textBoxG2_2_1_5 = new TextBox();
                        this.textBoxG2_2_1_6 = new TextBox();
                        this.textBoxG2_2_1_7 = new TextBox();
                        this.textBoxG2_2_1_8 = new TextBox();
                        this.textBoxG2_2_1_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_1_1,
                            this.textBoxG2_2_1_2,
                            this.textBoxG2_2_1_3,
                            this.textBoxG2_2_1_4,
                            this.textBoxG2_2_1_5,
                            this.textBoxG2_2_1_6,
                            this.textBoxG2_2_1_7,
                            this.textBoxG2_2_1_8,
                            this.textBoxG2_2_1_9
                        };
                        this.initTextBox(list2);
                        this.pictureBoxG2_2_1_1 = new PictureBox();
                        this.pictureBoxG2_2_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_1_1);
                        this.initPictureBox(this.pictureBoxG2_2_1_2);
                        this.pictureBoxG2_2_1_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_1_2.Load("Images/3-2-2.jpg");
                        new G_two_2_1().g_two_2_1Generate(this.controlG2_2_1_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_1_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_1_2, true);
                    }
                    else if (str.Equals("g_two_2_2.xml"))
                    {
                        this.labelG2_2_2 = new Label();
                        this.initScoreLabel(this.labelG2_2_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_2);
                        this.controlG2_2_2_1 = new NuGenEQML();
                        this.tableG2_2_2_1 = new TableLayoutPanel();
                        this.textBoxG2_2_2_1 = new TextBox();
                        this.textBoxG2_2_2_2 = new TextBox();
                        this.textBoxG2_2_2_3 = new TextBox();
                        this.textBoxG2_2_2_4 = new TextBox();
                        this.textBoxG2_2_2_5 = new TextBox();
                        this.textBoxG2_2_2_6 = new TextBox();
                        this.textBoxG2_2_2_7 = new TextBox();
                        this.textBoxG2_2_2_8 = new TextBox();
                        this.textBoxG2_2_2_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_2_1,
                            this.textBoxG2_2_2_2,
                            this.textBoxG2_2_2_3,
                            this.textBoxG2_2_2_4,
                            this.textBoxG2_2_2_5,
                            this.textBoxG2_2_2_6,
                            this.textBoxG2_2_2_7,
                            this.textBoxG2_2_2_8,
                            this.textBoxG2_2_2_9
                        };
                        this.pictureBoxG2_2_2_1 = new PictureBox();
                        this.pictureBoxG2_2_2_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_2_1);
                        this.initPictureBox(this.pictureBoxG2_2_2_2);
                        this.pictureBoxG2_2_2_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_2_2.Load("Images/3-2-2.jpg");
                        this.initTextBox(list2);
                        new G_two_2_2().g_two_2_2Generate(this.controlG2_2_2_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_2_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_2_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_2_2, true);
                    }
                    else if (str.Equals("g_two_2_3.xml"))
                    {
                        this.labelG2_2_3 = new Label();
                        this.initScoreLabel(this.labelG2_2_3);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_3);
                        this.controlG2_2_3_1 = new NuGenEQML();
                        this.tableG2_2_3_1 = new TableLayoutPanel();
                        this.textBoxG2_2_3_1 = new TextBox();
                        this.textBoxG2_2_3_2 = new TextBox();
                        this.textBoxG2_2_3_3 = new TextBox();
                        this.textBoxG2_2_3_4 = new TextBox();
                        this.textBoxG2_2_3_5 = new TextBox();
                        this.textBoxG2_2_3_6 = new TextBox();
                        this.textBoxG2_2_3_7 = new TextBox();
                        this.textBoxG2_2_3_8 = new TextBox();
                        this.textBoxG2_2_3_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_3_1,
                            this.textBoxG2_2_3_2,
                            this.textBoxG2_2_3_3,
                            this.textBoxG2_2_3_4,
                            this.textBoxG2_2_3_5,
                            this.textBoxG2_2_3_6,
                            this.textBoxG2_2_3_7,
                            this.textBoxG2_2_3_8,
                            this.textBoxG2_2_3_9
                        };
                        this.initTextBox(list2);
                        this.pictureBoxG2_2_3_1 = new PictureBox();
                        this.pictureBoxG2_2_3_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_3_1);
                        this.initPictureBox(this.pictureBoxG2_2_3_2);
                        this.pictureBoxG2_2_3_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_3_2.Load("Images/3-2-2.jpg");
                        new G_two_2_3().g_two_2_3Generate(this.controlG2_2_3_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_3_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_3_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_3_2, true);
                    }
                    else if (str.Equals("g_two_2_4.xml"))
                    {
                        this.labelG2_2_4 = new Label();
                        this.initScoreLabel(this.labelG2_2_4);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_4);
                        this.controlG2_2_4_1 = new NuGenEQML();
                        this.tableG2_2_4_1 = new TableLayoutPanel();
                        this.textBoxG2_2_4_1 = new TextBox();
                        this.textBoxG2_2_4_2 = new TextBox();
                        this.textBoxG2_2_4_3 = new TextBox();
                        this.textBoxG2_2_4_4 = new TextBox();
                        this.textBoxG2_2_4_5 = new TextBox();
                        this.textBoxG2_2_4_6 = new TextBox();
                        this.textBoxG2_2_4_7 = new TextBox();
                        this.textBoxG2_2_4_8 = new TextBox();
                        this.textBoxG2_2_4_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_4_1,
                            this.textBoxG2_2_4_2,
                            this.textBoxG2_2_4_3,
                            this.textBoxG2_2_4_4,
                            this.textBoxG2_2_4_5,
                            this.textBoxG2_2_4_6,
                            this.textBoxG2_2_4_7,
                            this.textBoxG2_2_4_8,
                            this.textBoxG2_2_4_9
                        };
                        this.initTextBox(list2);
                        this.pictureBoxG2_2_4_1 = new PictureBox();
                        this.pictureBoxG2_2_4_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_4_1);
                        this.initPictureBox(this.pictureBoxG2_2_4_2);
                        this.pictureBoxG2_2_4_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_4_2.Load("Images/3-2-2.jpg");
                        new G_two_2_4().g_two_2_4Generate(this.controlG2_2_4_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_4_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_4_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_4_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_4_2, true);
                    }
                    else if (str.Equals("g_two_2_5.xml"))
                    {
                        this.labelG2_2_5 = new Label();
                        this.initScoreLabel(this.labelG2_2_5);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_5);
                        this.controlG2_2_5_1 = new NuGenEQML();
                        this.tableG2_2_5_1 = new TableLayoutPanel();
                        this.textBoxG2_2_5_1 = new TextBox();
                        this.textBoxG2_2_5_2 = new TextBox();
                        this.textBoxG2_2_5_3 = new TextBox();
                        this.textBoxG2_2_5_4 = new TextBox();
                        this.textBoxG2_2_5_5 = new TextBox();
                        this.textBoxG2_2_5_6 = new TextBox();
                        this.textBoxG2_2_5_7 = new TextBox();
                        this.textBoxG2_2_5_8 = new TextBox();
                        this.textBoxG2_2_5_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_5_1,
                            this.textBoxG2_2_5_2,
                            this.textBoxG2_2_5_3,
                            this.textBoxG2_2_5_4,
                            this.textBoxG2_2_5_5,
                            this.textBoxG2_2_5_6,
                            this.textBoxG2_2_5_7,
                            this.textBoxG2_2_5_8,
                            this.textBoxG2_2_5_9
                        };
                        this.pictureBoxG2_2_5_1 = new PictureBox();
                        this.pictureBoxG2_2_5_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_5_1);
                        this.initPictureBox(this.pictureBoxG2_2_5_2);
                        this.pictureBoxG2_2_5_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_5_2.Load("Images/3-2-2.jpg");
                        this.initTextBox(list2);
                        new G_two_2_5().g_two_2_5Generate(this.controlG2_2_5_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_5_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_5_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_5_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_5_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_5_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_5_2, true);
                    }
                    else if (str.Equals("g_two_2_6.xml"))
                    {
                        this.labelG2_2_6 = new Label();
                        this.initScoreLabel(this.labelG2_2_6);
                        this.flowLayoutPanel1.Controls.Add(this.labelG2_2_6);
                        this.controlG2_2_6_1 = new NuGenEQML();
                        this.tableG2_2_6_1 = new TableLayoutPanel();
                        this.textBoxG2_2_6_1 = new TextBox();
                        this.textBoxG2_2_6_2 = new TextBox();
                        this.textBoxG2_2_6_3 = new TextBox();
                        this.textBoxG2_2_6_4 = new TextBox();
                        this.textBoxG2_2_6_5 = new TextBox();
                        this.textBoxG2_2_6_6 = new TextBox();
                        this.textBoxG2_2_6_7 = new TextBox();
                        this.textBoxG2_2_6_8 = new TextBox();
                        this.textBoxG2_2_6_9 = new TextBox();
                        list2 = new List<TextBox> {
                            this.textBoxG2_2_6_1,
                            this.textBoxG2_2_6_2,
                            this.textBoxG2_2_6_3,
                            this.textBoxG2_2_6_4,
                            this.textBoxG2_2_6_5,
                            this.textBoxG2_2_6_6,
                            this.textBoxG2_2_6_7,
                            this.textBoxG2_2_6_8,
                            this.textBoxG2_2_6_9
                        };
                        this.initTextBox(list2);
                        this.pictureBoxG2_2_6_1 = new PictureBox();
                        this.pictureBoxG2_2_6_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG2_2_6_1);
                        this.initPictureBox(this.pictureBoxG2_2_6_2);
                        this.pictureBoxG2_2_6_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG2_2_6_2.Load("Images/3-2-2.jpg");
                        new G_two_2_6().g_two_2_6Generate(this.controlG2_2_6_1, (i + 1) + ".");
                        new InitControls().matrixThreeToThree(this.tableG2_2_6_1, list2);
                        this.flowLayoutPanel1.Controls.Add(this.controlG2_2_6_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_6_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG2_2_6_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG2_2_6_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG2_2_6_2, true);
                    }
                    else if (str.Equals("g_three_1.xml"))
                    {
                        this.labelG3_1 = new Label();
                        this.initScoreLabel(this.labelG3_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG3_1);
                        this.controlG3_1_1 = new NuGenEQML();
                        this.textBoxG3_1_1 = new TextBox();
                        this.initTextBox(this.textBoxG3_1_1);
                        this.pictureBoxG3_1_1 = new PictureBox();
                        this.pictureBoxG3_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG3_1_1);
                        this.initPictureBox(this.pictureBoxG3_1_2);
                        this.pictureBoxG3_1_1.Load("Images/5-1.jpg");
                        this.pictureBoxG3_1_2.Load("Images/5-2.jpg");
                        new G_three_1().g_three_1Generate(this.controlG3_1_1, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG3_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG3_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxG3_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG3_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG3_1_2, true);
                    }
                    else if (str.Equals("g_three_2.xml"))
                    {
                        this.labelG3_2 = new Label();
                        this.initScoreLabel(this.labelG3_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelG3_2);
                        this.controlG3_2_1 = new NuGenEQML();
                        this.textBoxG3_2_1 = new TextBox();
                        this.initTextBox(this.textBoxG3_2_1);
                        this.pictureBoxG3_2_1 = new PictureBox();
                        this.pictureBoxG3_2_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG3_2_1);
                        this.initPictureBox(this.pictureBoxG3_2_2);
                        this.pictureBoxG3_2_1.Load("Images/5-1.jpg");
                        this.pictureBoxG3_2_2.Load("Images/5-2.jpg");
                        new G_three_2().g_three_2Generate(this.controlG3_2_1, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG3_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG3_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxG3_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG3_2_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG3_2_2, true);
                    }
                    else if (str.Equals("g_four_1.xml"))
                    {
                        this.labelG4_1 = new Label();
                        this.initScoreLabel(this.labelG4_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG4_1);
                        this.controlG4_1_1 = new NuGenEQML();
                        this.textBoxG4_1_1 = new TextBox();
                        this.initTextBox(this.textBoxG4_1_1);
                        this.pictureBoxG4_1_1 = new PictureBox();
                        this.pictureBoxG4_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG4_1_1);
                        this.initPictureBox(this.pictureBoxG4_1_2);
                        this.pictureBoxG4_1_1.Load("Images/5-1.jpg");
                        this.pictureBoxG4_1_2.Load("Images/5-2.jpg");
                        new G_four_1().g_four_1Generate(this.controlG4_1_1, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG4_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG4_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxG4_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG4_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG4_1_2, true);
                    }
                    else if (str.Equals("g_four_2.xml"))
                    {
                        this.labelG4_2 = new Label();
                        this.initScoreLabel(this.labelG4_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelG4_2);
                        this.controlG4_2_1 = new NuGenEQML();
                        this.tableG4_2_1 = new TableLayoutPanel();
                        this.tableG4_2_2 = new TableLayoutPanel();
                        this.tableG4_2_3 = new TableLayoutPanel();
                        List<NuGenEQML> list3 = new List<NuGenEQML>();
                        this.controlGT4_2_1_1 = new NuGenEQML();
                        this.controlGT4_2_1_2 = new NuGenEQML();
                        this.controlGT4_2_1_3 = new NuGenEQML();
                        this.controlGT4_2_1_4 = new NuGenEQML();
                        list3.Add(this.controlGT4_2_1_1);
                        list3.Add(this.controlGT4_2_1_2);
                        list3.Add(this.controlGT4_2_1_3);
                        list3.Add(this.controlGT4_2_1_4);
                        this.initControls(list3);
                        List<NuGenEQML> list4 = new List<NuGenEQML>();
                        this.controlGT4_2_2_1 = new NuGenEQML();
                        this.controlGT4_2_2_2 = new NuGenEQML();
                        this.controlGT4_2_2_3 = new NuGenEQML();
                        this.controlGT4_2_2_4 = new NuGenEQML();
                        list4.Add(this.controlGT4_2_2_1);
                        list4.Add(this.controlGT4_2_2_2);
                        list4.Add(this.controlGT4_2_2_3);
                        list4.Add(this.controlGT4_2_2_4);
                        this.initControls(list4);
                        List<NuGenEQML> list5 = new List<NuGenEQML>();
                        this.controlGT4_2_3_1 = new NuGenEQML();
                        this.controlGT4_2_3_2 = new NuGenEQML();
                        this.controlGT4_2_3_3 = new NuGenEQML();
                        this.controlGT4_2_3_4 = new NuGenEQML();
                        list5.Add(this.controlGT4_2_3_1);
                        list5.Add(this.controlGT4_2_3_2);
                        list5.Add(this.controlGT4_2_3_3);
                        list5.Add(this.controlGT4_2_3_4);
                        this.initControls(list5);
                        new G_four_2().g_four_2Generate(this.controlG4_2_1, (i + 1) + ".");
                        new InitControls().matrixFourToOne(this.tableG4_2_1, list3);
                        new InitControls().matrixFourToOne(this.tableG4_2_2, list4);
                        new InitControls().matrixFourToOne(this.tableG4_2_3, list5);
                        Label label = new Label {
                            Text = ","
                        };
                        Label label2 = new Label {
                            Text = ","
                        };
                        Label label3 = new Label {
                            Text = "."
                        };
                        label.Anchor = AnchorStyles.None;
                        label.AutoSize = true;
                        label2.Anchor = AnchorStyles.None;
                        label2.AutoSize = true;
                        label3.Anchor = AnchorStyles.None;
                        label3.AutoSize = true;
                        this.flowLayoutPanel1.Controls.Add(this.controlG4_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG4_2_1);
                        this.flowLayoutPanel1.Controls.Add(label);
                        this.flowLayoutPanel1.Controls.Add(this.tableG4_2_2);
                        this.flowLayoutPanel1.Controls.Add(label2);
                        this.flowLayoutPanel1.Controls.Add(this.tableG4_2_3);
                        this.flowLayoutPanel1.Controls.Add(label3);
                        this.flowLayoutPanel1.SetFlowBreak(label3, true);
                    }
                    else if (str.Equals("g_five_1.xml"))
                    {
                        this.labelG5_1 = new Label();
                        this.initScoreLabel(this.labelG5_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG5_1);
                        this.controlG5_1_1 = new NuGenEQML();
                        new G_five_1().g_five_1Generate(this.controlG5_1_1, (i + 1) + ".");
                        this.textBoxG5_1_1 = new TextBox();
                        this.initTextBox(this.textBoxG5_1_1);
                        this.pictureBoxG5_1_1 = new PictureBox();
                        this.pictureBoxG5_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG5_1_1);
                        this.initPictureBox(this.pictureBoxG5_1_2);
                        this.pictureBoxG5_1_1.Load("Images/5-1.jpg");
                        this.pictureBoxG5_1_2.Load("Images/5-2.jpg");
                        this.flowLayoutPanel1.Controls.Add(this.controlG5_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG5_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxG5_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG5_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG5_1_2, true);
                    }
                    else if (str.Equals("g_six_1.xml"))
                    {
                        this.labelG6_1 = new Label();
                        this.initScoreLabel(this.labelG6_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG6_1);
                        this.controlG6_1_1 = new NuGenEQML();
                        new G_six_1().g_six_1Generate(this.controlG6_1_1, (i + 1) + ".");
                        this.textBoxG6_1_1 = new TextBox();
                        this.initTextBox(this.textBoxG6_1_1);
                        this.pictureBoxG6_1_1 = new PictureBox();
                        this.pictureBoxG6_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG6_1_1);
                        this.initPictureBox(this.pictureBoxG6_1_2);
                        this.pictureBoxG6_1_1.Load("Images/5-1.jpg");
                        this.pictureBoxG6_1_2.Load("Images/5-2.jpg");
                        this.flowLayoutPanel1.Controls.Add(this.controlG6_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG6_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.textBoxG6_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG6_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG6_1_2, true);
                    }
                    else if (str.Equals("g_seven_1_1.xml"))
                    {
                        this.labelG7_1_1 = new Label();
                        this.initScoreLabel(this.labelG7_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelG7_1_1);
                        this.controlG7_1_1_1 = new NuGenEQML();
                        this.textBoxG7_1_1_1 = new TextBox();
                        this.textBoxG7_1_1_2 = new TextBox();
                        this.textBoxG7_1_1_3 = new TextBox();
                        this.textBoxG7_1_1_4 = new TextBox();
                        this.textBoxG7_1_1_5 = new TextBox();
                        this.textBoxG7_1_1_6 = new TextBox();
                        this.textBoxG7_1_1_7 = new TextBox();
                        this.textBoxG7_1_1_8 = new TextBox();
                        this.textBoxG7_1_1_9 = new TextBox();
                        List<TextBox> list6 = new List<TextBox> {
                            this.textBoxG7_1_1_1,
                            this.textBoxG7_1_1_2,
                            this.textBoxG7_1_1_3,
                            this.textBoxG7_1_1_4,
                            this.textBoxG7_1_1_5,
                            this.textBoxG7_1_1_6,
                            this.textBoxG7_1_1_7,
                            this.textBoxG7_1_1_8,
                            this.textBoxG7_1_1_9
                        };
                        this.pictureBoxG7_1_1_1 = new PictureBox();
                        this.pictureBoxG7_1_1_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG7_1_1_1);
                        this.initPictureBox(this.pictureBoxG7_1_1_2);
                        this.pictureBoxG7_1_1_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG7_1_1_2.Load("Images/3-2-2.jpg");
                        this.initTextBox(list6);
                        this.tableG7_1_1_1 = new TableLayoutPanel();
                        new G_seven_1_1().g_seven_1_1Generate(this.controlG7_1_1_1, this.tableG7_1_1_1, list6, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG7_1_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG7_1_1_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_1_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG7_1_1_2, true);
                    }
                    else if (str.Equals("g_seven_1_2.xml"))
                    {
                        this.labelG7_1_2 = new Label();
                        this.initScoreLabel(this.labelG7_1_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelG7_1_2);
                        this.controlG7_1_2_1 = new NuGenEQML();
                        this.textBoxG7_1_2_1 = new TextBox();
                        this.textBoxG7_1_2_2 = new TextBox();
                        this.textBoxG7_1_2_3 = new TextBox();
                        this.textBoxG7_1_2_4 = new TextBox();
                        this.textBoxG7_1_2_5 = new TextBox();
                        this.textBoxG7_1_2_6 = new TextBox();
                        this.textBoxG7_1_2_7 = new TextBox();
                        this.textBoxG7_1_2_8 = new TextBox();
                        this.textBoxG7_1_2_9 = new TextBox();
                        this.textBoxG7_1_2_10 = new TextBox();
                        this.textBoxG7_1_2_11 = new TextBox();
                        this.textBoxG7_1_2_12 = new TextBox();
                        this.textBoxG7_1_2_13 = new TextBox();
                        this.textBoxG7_1_2_14 = new TextBox();
                        this.textBoxG7_1_2_15 = new TextBox();
                        this.textBoxG7_1_2_16 = new TextBox();
                        List<TextBox> list7 = new List<TextBox> {
                            this.textBoxG7_1_2_1,
                            this.textBoxG7_1_2_2,
                            this.textBoxG7_1_2_3,
                            this.textBoxG7_1_2_4,
                            this.textBoxG7_1_2_5,
                            this.textBoxG7_1_2_6,
                            this.textBoxG7_1_2_7,
                            this.textBoxG7_1_2_8,
                            this.textBoxG7_1_2_9,
                            this.textBoxG7_1_2_10,
                            this.textBoxG7_1_2_11,
                            this.textBoxG7_1_2_12,
                            this.textBoxG7_1_2_13,
                            this.textBoxG7_1_2_14,
                            this.textBoxG7_1_2_15,
                            this.textBoxG7_1_2_16
                        };
                        this.initTextBox(list7);
                        this.pictureBoxG7_1_2_1 = new PictureBox();
                        this.pictureBoxG7_1_2_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG7_1_2_1);
                        this.initPictureBox(this.pictureBoxG7_1_2_2);
                        this.pictureBoxG7_1_2_1.Load("Images/4-1-1.jpg");
                        this.pictureBoxG7_1_2_2.Load("Images/4-2-1.jpg");
                        this.tableG7_1_2_1 = new TableLayoutPanel();
                        new G_seven_1_2().g_seven_1_2Generate(this.controlG7_1_2_1, this.tableG7_1_2_1, list7, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG7_1_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG7_1_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_2_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG7_1_2_2, true);
                    }
                    else if (str.Equals("g_seven_1_3.xml"))
                    {
                        this.labelG7_1_3 = new Label();
                        this.initScoreLabel(this.labelG7_1_3);
                        this.flowLayoutPanel1.Controls.Add(this.labelG7_1_3);
                        this.controlG7_1_3_1 = new NuGenEQML();
                        this.textBoxG7_1_3_1 = new TextBox();
                        this.textBoxG7_1_3_2 = new TextBox();
                        this.textBoxG7_1_3_3 = new TextBox();
                        this.textBoxG7_1_3_4 = new TextBox();
                        this.textBoxG7_1_3_5 = new TextBox();
                        this.textBoxG7_1_3_6 = new TextBox();
                        this.textBoxG7_1_3_7 = new TextBox();
                        this.textBoxG7_1_3_8 = new TextBox();
                        this.textBoxG7_1_3_9 = new TextBox();
                        List<TextBox> list8 = new List<TextBox> {
                            this.textBoxG7_1_3_1,
                            this.textBoxG7_1_3_2,
                            this.textBoxG7_1_3_3,
                            this.textBoxG7_1_3_4,
                            this.textBoxG7_1_3_5,
                            this.textBoxG7_1_3_6,
                            this.textBoxG7_1_3_7,
                            this.textBoxG7_1_3_8,
                            this.textBoxG7_1_3_9
                        };
                        this.initTextBox(list8);
                        this.pictureBoxG7_1_3_1 = new PictureBox();
                        this.pictureBoxG7_1_3_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG7_1_3_1);
                        this.initPictureBox(this.pictureBoxG7_1_3_2);
                        this.pictureBoxG7_1_3_1.Load("Images/3-1-1.jpg");
                        this.pictureBoxG7_1_3_2.Load("Images/3-2-2.jpg");
                        this.tableG7_1_3_1 = new TableLayoutPanel();
                        new G_seven_1_3().g_seven_1_3Generate(this.controlG7_1_3_1, this.tableG7_1_3_1, list8, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG7_1_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG7_1_3_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_1_3_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG7_1_3_2, true);
                    }
                    else if (str.Equals("g_seven_2.xml"))
                    {
                        this.labelG7_2 = new Label();
                        this.initScoreLabel(this.labelG7_2);
                        this.flowLayoutPanel1.Controls.Add(this.labelG7_2);
                        this.controlG7_2_1 = new NuGenEQML();
                        this.tableG7_2_1 = new TableLayoutPanel();
                        List<TextBox> list9 = new List<TextBox>();
                        this.textBoxG7_2_1 = new TextBox();
                        this.textBoxG7_2_2 = new TextBox();
                        this.textBoxG7_2_3 = new TextBox();
                        list9.Add(this.textBoxG7_2_1);
                        list9.Add(this.textBoxG7_2_2);
                        list9.Add(this.textBoxG7_2_3);
                        this.initTextBox(list9);
                        this.pictureBoxG7_2_1 = new PictureBox();
                        this.pictureBoxG7_2_2 = new PictureBox();
                        this.initPictureBox(this.pictureBoxG7_2_1);
                        this.initPictureBox(this.pictureBoxG7_2_2);
                        this.pictureBoxG7_2_1.Load("Images/5-1.jpg");
                        this.pictureBoxG7_2_2.Load("Images/5-2.jpg");
                        new G_seven_2().g_seven_2Generate(this.controlG7_2_1, this.tableG7_2_1, list9, (i + 1) + ".");
                        this.flowLayoutPanel1.Controls.Add(this.controlG7_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.tableG7_2_1);
                        this.flowLayoutPanel1.Controls.Add(this.pictureBoxG7_2_2);
                        this.flowLayoutPanel1.SetFlowBreak(this.pictureBoxG7_2_2, true);
                    }
                }
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            new HelpWindow().ShowDialog();
        }
        private void btn_isSubmit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定要提交试卷吗", "提交试卷提示", MessageBoxButtons.YesNo))
            {
                if (this.isReSubmit)
                {
                    //this.AnswerUpload(null, null);
                }
                this.btn_Submit.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.controlFlag != null)
            {
                this.controlFlag.pub_InsertSqrt();
            }
        }

        private void CalculationAnswerJudge(object sender, EventArgs e)
        {
            this.calculationAnswerResults = new Dictionary<string, List<bool>>();
            foreach (string str in this.calculationString)
            {
                List<string> list6;
                List<string> list7;
                List<string> list8;
                switch (str)
                {
                    case "c1.xml":
                    {
                        List<string> list = new List<string> {
                            this.TextBoxC1_2_1.Text.Trim(),
                            this.TextBoxC1_2_2.Text.Trim(),
                            this.TextBoxC1_2_3.Text.Trim(),
                            this.TextBoxC1_2_4.Text.Trim(),
                            this.TextBoxC1_2_5.Text.Trim()
                        };
                        List<string> list2 = new List<string> {
                            this.textBoxC1_3_1_1.Text.Trim(),
                            this.textBoxC1_3_1_2.Text.Trim(),
                            this.textBoxC1_3_1_3.Text.Trim(),
                            this.textBoxC1_3_1_4.Text.Trim(),
                            this.textBoxC1_3_1_5.Text.Trim(),
                            this.textBoxC1_3_1_6.Text.Trim(),
                            this.textBoxC1_3_1_7.Text.Trim(),
                            this.textBoxC1_3_1_8.Text.Trim(),
                            this.textBoxC1_3_1_9.Text.Trim()
                        };
                        List<string> list3 = new List<string> {
                            this.textBoxC1_3_2_1.Text.Trim(),
                            this.textBoxC1_3_2_2.Text.Trim(),
                            this.textBoxC1_3_2_3.Text.Trim(),
                            this.textBoxC1_3_2_4.Text.Trim(),
                            this.textBoxC1_3_2_5.Text.Trim(),
                            this.textBoxC1_3_2_6.Text.Trim(),
                            this.textBoxC1_3_2_7.Text.Trim(),
                            this.textBoxC1_3_2_8.Text.Trim(),
                            this.textBoxC1_3_2_9.Text.Trim()
                        };
                        List<string> list4 = new List<string> {
                            this.textBoxC1_3_3_1.Text.Trim(),
                            this.textBoxC1_3_3_2.Text.Trim(),
                            this.textBoxC1_3_3_3.Text.Trim(),
                            this.textBoxC1_3_3_4.Text.Trim(),
                            this.textBoxC1_3_3_5.Text.Trim(),
                            this.textBoxC1_3_3_6.Text.Trim(),
                            this.textBoxC1_3_3_7.Text.Trim(),
                            this.textBoxC1_3_3_8.Text.Trim(),
                            this.textBoxC1_3_3_9.Text.Trim()
                        };
                        List<string> list5 = new List<string> {
                            this.textBoxC1_3_4_1.Text.Trim(),
                            this.textBoxC1_3_4_2.Text.Trim(),
                            this.textBoxC1_3_4_3.Text.Trim(),
                            this.textBoxC1_3_4_4.Text.Trim(),
                            this.textBoxC1_3_4_5.Text.Trim(),
                            this.textBoxC1_3_4_6.Text.Trim(),
                            this.textBoxC1_3_4_7.Text.Trim(),
                            this.textBoxC1_3_4_8.Text.Trim(),
                            this.textBoxC1_3_4_9.Text.Trim()
                        };
                        this.calculationAnswerResults["c1.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c1(this.textBoxC1_1_1.Text.Trim(), list, list2, list3, list4, list5);
                        continue;
                    }
                    case "c2.xml":
                        list6 = new List<string> {
                            this.textBoxC2_1_1.Text.Trim(),
                            this.textBoxC2_1_2.Text.Trim(),
                            this.textBoxC2_1_3.Text.Trim(),
                            this.textBoxC2_1_4.Text.Trim(),
                            this.textBoxC2_1_5.Text.Trim(),
                            this.textBoxC2_1_6.Text.Trim(),
                            this.textBoxC2_1_7.Text.Trim(),
                            this.textBoxC2_1_8.Text.Trim(),
                            this.textBoxC2_1_9.Text.Trim(),
                            this.textBoxC2_1_10.Text.Trim(),
                            this.textBoxC2_1_11.Text.Trim(),
                            this.textBoxC2_1_12.Text.Trim(),
                            this.textBoxC2_1_13.Text.Trim(),
                            this.textBoxC2_1_14.Text.Trim(),
                            this.textBoxC2_1_15.Text.Trim(),
                            this.textBoxC2_1_16.Text.Trim(),
                            this.textBoxC2_1_17.Text.Trim(),
                            this.textBoxC2_1_18.Text.Trim(),
                            this.textBoxC2_1_19.Text.Trim(),
                            this.textBoxC2_1_20.Text.Trim()
                        };
                        list7 = new List<string> {
                            this.textBoxC2_2_1.Text.Trim(),
                            this.textBoxC2_2_2.Text.Trim()
                        };
                        if (!this.radioButtonC2_2_1.Checked)
                        {
                            break;
                        }
                        list7.Add("true");
                        goto Label_07A9;

                    case "c3.xml":
                    {
                        List<string> list12 = new List<string> {
                            this.controlC3_1_4.pub_GetXML(false),
                            this.controlC3_1_5.pub_GetXML(false),
                            this.controlC3_1_6.pub_GetXML(false)
                        };
                        List<string> list13 = new List<string> {
                            this.controlC3_2_1_3.pub_GetXML(false),
                            this.controlC3_2_1_4.pub_GetXML(false),
                            this.controlC3_2_1_5.pub_GetXML(false)
                        };
                        List<string> list14 = new List<string> {
                            this.controlC3_2_2_3.pub_GetXML(false),
                            this.controlC3_2_2_4.pub_GetXML(false),
                            this.controlC3_2_2_5.pub_GetXML(false)
                        };
                        List<string> list15 = new List<string> {
                            this.controlC3_2_3_4.pub_GetXML(false),
                            this.controlC3_2_3_5.pub_GetXML(false),
                            this.controlC3_2_3_6.pub_GetXML(false)
                        };
                        List<string> list16 = new List<string> {
                            this.controlC3_3_1.pub_GetXML(false),
                            this.controlC3_3_2.pub_GetXML(false),
                            this.controlC3_3_3.pub_GetXML(false),
                            this.controlC3_3_4.pub_GetXML(false),
                            this.controlC3_3_5.pub_GetXML(false),
                            this.controlC3_3_6.pub_GetXML(false),
                            this.controlC3_3_7.pub_GetXML(false),
                            this.controlC3_3_8.pub_GetXML(false),
                            this.controlC3_3_9.pub_GetXML(false)
                        };
                        List<string> list17 = new List<string> {
                            this.controlC3_4_1.pub_GetXML(false),
                            this.controlC3_4_2.pub_GetXML(false),
                            this.controlC3_4_3.pub_GetXML(false)
                        };
                        this.calculationAnswerResults["c3.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c3(list12, list13, list14, list15, list16, list17);
                        continue;
                    }
                    case "c4.xml":
                    {
                        List<TextBox> list18 = new List<TextBox> {
                            this.textBoxC4_1_1,
                            this.textBoxC4_1_2,
                            this.textBoxC4_1_3,
                            this.textBoxC4_1_4,
                            this.textBoxC4_1_5,
                            this.textBoxC4_1_6,
                            this.textBoxC4_1_7,
                            this.textBoxC4_1_8,
                            this.textBoxC4_1_9
                        };
                        List<string> list19 = new List<string> {
                            this.controlC4_2_4.pub_GetXML(false)
                        };
                        List<string> list20 = new List<string> {
                            this.controlC4_2_5.pub_GetXML(false)
                        };
                        List<string> list21 = new List<string> {
                            this.controlC4_2_6.pub_GetXML(false)
                        };
                        List<string> list22 = new List<string> {
                            this.controlC4_3_13.pub_GetXML(false),
                            this.controlC4_3_14.pub_GetXML(false),
                            this.controlC4_3_15.pub_GetXML(false),
                            this.controlC4_3_16.pub_GetXML(false),
                            this.controlC4_3_17.pub_GetXML(false),
                            this.controlC4_3_18.pub_GetXML(false),
                            this.controlC4_3_19.pub_GetXML(false),
                            this.controlC4_3_20.pub_GetXML(false),
                            this.controlC4_3_21.pub_GetXML(false)
                        };
                        List<string> list23 = new List<string> {
                            this.controlC4_4_5.pub_GetXML(false),
                            this.controlC4_4_6.pub_GetXML(false),
                            this.controlC4_4_7.pub_GetXML(false)
                        };
                        this.calculationAnswerResults["c4.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c4(list18, list19, list20, list21, list22, list23);
                        continue;
                    }
                    case "c5.xml":
                    {
                        List<string> list24 = new List<string> {
                            this.controlC5_1_4.pub_GetXML(false)
                        };
                        List<string> list25 = new List<string> {
                            this.controlC5_1_5.pub_GetXML(false)
                        };
                        List<string> list26 = new List<string> {
                            this.controlC5_1_6.pub_GetXML(false)
                        };
                        List<string> list27 = new List<string> {
                            this.controlC5_2_7.pub_GetXML(false),
                            this.controlC5_2_8.pub_GetXML(false),
                            this.controlC5_2_9.pub_GetXML(false)
                        };
                        List<string> list28 = new List<string> {
                            this.controlC5_2_10.pub_GetXML(false),
                            this.controlC5_2_11.pub_GetXML(false),
                            this.controlC5_2_12.pub_GetXML(false)
                        };
                        List<string> list29 = new List<string> {
                            this.controlC5_2_13.pub_GetXML(false),
                            this.controlC5_2_14.pub_GetXML(false),
                            this.controlC5_2_15.pub_GetXML(false)
                        };
                        List<string> list30 = new List<string> {
                            this.controlC5_3_1.pub_GetXML(false),
                            this.controlC5_3_2.pub_GetXML(false),
                            this.controlC5_3_3.pub_GetXML(false),
                            this.controlC5_3_4.pub_GetXML(false),
                            this.controlC5_3_5.pub_GetXML(false),
                            this.controlC5_3_6.pub_GetXML(false),
                            this.controlC5_3_7.pub_GetXML(false),
                            this.controlC5_3_8.pub_GetXML(false),
                            this.controlC5_3_9.pub_GetXML(false)
                        };
                        this.calculationAnswerResults["c5.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c5(list24, list25, list26, list27, list28, list29, list30);
                        continue;
                    }
                    case "c6.xml":
                    {
                        List<TextBox> list31 = new List<TextBox> {
                            this.textBoxC6_1_1,
                            this.textBoxC6_1_2
                        };
                        List<string> list32 = new List<string> {
                            this.controlC6_2_3.pub_GetXML(false),
                            this.controlC6_2_4.pub_GetXML(false),
                            this.controlC6_2_5.pub_GetXML(false),
                            this.controlC6_2_6.pub_GetXML(false),
                            this.controlC6_2_7.pub_GetXML(false),
                            this.controlC6_2_8.pub_GetXML(false),
                            this.controlC6_2_9.pub_GetXML(false),
                            this.controlC6_2_10.pub_GetXML(false),
                            this.controlC6_2_11.pub_GetXML(false),
                            this.controlC6_2_12.pub_GetXML(false)
                        };
                        List<string> list33 = new List<string> {
                            this.controlC6_3_2.pub_GetXML(false),
                            this.controlC6_3_3.pub_GetXML(false),
                            this.controlC6_3_4.pub_GetXML(false),
                            this.controlC6_3_5.pub_GetXML(false),
                            this.controlC6_3_6.pub_GetXML(false)
                        };
                        this.calculationAnswerResults["c6.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c6(list31, list32, list33);
                        continue;
                    }
                    case "c7.xml":
                    {
                        List<TextBox> list34 = new List<TextBox>()
                        {
                            this.textBoxC7_1_1,
                            this.textBoxC7_1_2,
                            this.textBoxC7_1_3,
                            this.textBoxC7_1_4,
                            this.textBoxC7_1_5,
                            this.textBoxC7_1_6,
                            this.textBoxC7_1_7,
                            this.textBoxC7_1_8,
                            this.textBoxC7_1_9

                        };
                        List<TextBox> list35 = new List<TextBox>()
                        {
                            this.textBoxC7_2_1,
                            this.textBoxC7_2_2,
                            this.textBoxC7_2_3,
                            this.textBoxC7_2_4,
                        };
                        List<TextBox> list36 = new List<TextBox> {
                            this.textBoxC7_3_1,
                            this.textBoxC7_3_2,
                            this.textBoxC7_3_3,
                            this.textBoxC7_3_4,
                            this.textBoxC7_3_5,
                            this.textBoxC7_3_6
                        };
                        this.calculationAnswerResults["c7.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c7(list34, list35, list36);
                        continue;
                    }
                    case "c8.xml":
                    {
                        List<TextBox> list37 = new List<TextBox>(){
                            this.textBoxC8_1_1,
                            this.textBoxC8_1_2,
                            this.textBoxC8_1_3,
                            this.textBoxC8_1_4,
                            this.textBoxC8_1_5,
                            this.textBoxC8_1_6,
                            this.textBoxC8_1_7,
                            this.textBoxC8_1_8,
                            this.textBoxC8_1_9

                        };
                        List<TextBox> list38 = new List<TextBox>()
                        {
                            this.textBoxC8_2_1,
                            this.textBoxC8_2_2,
                            this.textBoxC8_2_3,
                            this.textBoxC8_2_4,
                            this.textBoxC8_2_5,
                            this.textBoxC8_2_6

                        };
                        List<TextBox> list39 = new List<TextBox> {
                            this.textBoxC8_3_1,
                            this.textBoxC8_3_2,
                            this.textBoxC8_3_3,
                            this.textBoxC8_3_4,
                            this.textBoxC8_3_5,
                            this.textBoxC8_3_6
                        };
                        this.calculationAnswerResults["c8.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c8(list37, list38, list39);
                        continue;
                    }
                    case "c9.xml":
                    {
                        List<RadioButton> list40 = new List<RadioButton> {
                            this.radiobuttonC9_2_1,
                            this.radiobuttonC9_2_2,
                            this.radiobuttonC9_2_3
                        };
                        List<TextBox> list41 = new List<TextBox> {
                            this.textBoxC9_3_1,
                            this.textBoxC9_3_2,
                            this.textBoxC9_3_3
                        };
                        this.calculationAnswerResults["c9.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c9(this.textBoxC9_1_1.Text.Trim(), list40, list41);
                        continue;
                    }
                    case "c10.xml":
                    {
                        List<int> list42 = new List<int> {
                            Convert.ToInt32(this.comboBoxC10_1_1.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC10_2_1.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC10_2_2.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC10_2_3.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC10_3_1.SelectedIndex)
                        };
                        string text = this.textBoxC10_1_1.Text;
                        List<string> list43 = new List<string> {
                            this.textBoxC10_2_1.Text.Trim(),
                            this.textBoxC10_2_2.Text.Trim(),
                            this.textBoxC10_2_3.Text.Trim(),
                            this.textBoxC10_2_4.Text.Trim(),
                            this.textBoxC10_2_5.Text.Trim(),
                            this.textBoxC10_2_6.Text.Trim()
                        };
                        List<string> list44 = new List<string> {
                            this.textBoxC10_3_1.Text.Trim(),
                            this.textBoxC10_3_2.Text.Trim(),
                            this.textBoxC10_3_3.Text.Trim(),
                            this.textBoxC10_3_4.Text.Trim(),
                            this.textBoxC10_3_5.Text.Trim()
                        };
                        this.calculationAnswerResults["c10.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c10(list42, text, list43, list44);
                        continue;
                    }
                    case "c11.xml":
                    {
                        List<int> list45 = new List<int> {
                            Convert.ToInt32(this.comboBoxC11_1_1.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC11_1_2.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC11_2_1.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC11_2_2.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC11_3_1.SelectedIndex),
                            Convert.ToInt32(this.comboBoxC11_3_2.SelectedIndex)
                        };
                        string str3 = this.textBoxC11_1_2.Text;
                        List<string> list46 = new List<string> {
                            this.textBoxC11_2_1.Text.Trim(),
                            this.textBoxC11_2_2.Text.Trim(),
                            this.textBoxC11_2_3.Text.Trim(),
                            this.textBoxC11_2_4.Text.Trim(),
                            this.textBoxC11_2_5.Text.Trim()
                        };
                        List<string> list47 = new List<string> {
                            this.textBoxC11_3_1.Text.Trim(),
                            this.textBoxC11_3_2.Text.Trim(),
                            this.textBoxC11_3_3.Text.Trim(),
                            this.textBoxC11_3_4.Text.Trim(),
                            this.textBoxC11_3_5.Text.Trim()
                        };
                        this.calculationAnswerResults["c11.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c11(list45, str3, list46, list47);
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                if (this.radioButtonC2_2_2.Checked)
                {
                    list7.Add("false");
                }
                else
                {
                    list7.Add("none");
                }
            Label_07A9:
                list8 = new List<string>();
                list8.Add(this.controlC2_3_1.pub_GetXML(false));
                list8.Add(this.controlC2_3_2.pub_GetXML(false));
                list8.Add(this.controlC2_3_3.pub_GetXML(false));
                list8.Add(this.controlC2_3_4.pub_GetXML(false));
                List<string> list9 = new List<string> {
                    this.controlC2_3_5.pub_GetXML(false),
                    this.controlC2_3_6.pub_GetXML(false),
                    this.controlC2_3_7.pub_GetXML(false),
                    this.controlC2_3_8.pub_GetXML(false)
                };
                List<string> list10 = new List<string> {
                    this.controlC2_3_9.pub_GetXML(false),
                    this.controlC2_3_10.pub_GetXML(false),
                    this.controlC2_3_11.pub_GetXML(false),
                    this.controlC2_3_12.pub_GetXML(false)
                };
                List<string> list11 = new List<string> {
                    this.controlC2_4_1.pub_GetXML(false),
                    this.controlC2_4_2.pub_GetXML(false),
                    this.controlC2_4_3.pub_GetXML(false),
                    this.controlC2_4_4.pub_GetXML(false)
                };
                this.calculationAnswerResults["c2.xml"] = CalculationAnswerJudgeTools.AnswerJudge_c2(list6, list7, list8, list9, list10, list11);
            }
        }

        private void CalculationSave(object sender, EventArgs e)
        {
            FileStream w = new FileStream("temp/UA/calculationAnswer.xml", FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            int num = 0;
            writer.WriteStartDocument();
            writer.WriteStartElement("calculationAnswer");
            writer.WriteAttributeString("guid", this.guid);
            foreach (string str in this.calculationString)
            {
                switch (str)
                {
                    case "c1.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c1_1", this.textBoxC1_1_1.Text);
                        writer.WriteElementString("c1_2_1", this.TextBoxC1_2_1.Text);
                        writer.WriteElementString("c1_2_2", this.TextBoxC1_2_2.Text);
                        writer.WriteElementString("c1_2_3", this.TextBoxC1_2_3.Text);
                        writer.WriteElementString("c1_2_4", this.TextBoxC1_2_4.Text);
                        writer.WriteElementString("c1_2_5", this.TextBoxC1_2_5.Text);
                        writer.WriteElementString("c1_3_1_1", this.textBoxC1_3_1_1.Text);
                        writer.WriteElementString("c1_3_1_2", this.textBoxC1_3_1_2.Text);
                        writer.WriteElementString("c1_3_1_3", this.textBoxC1_3_1_3.Text);
                        writer.WriteElementString("c1_3_1_4", this.textBoxC1_3_1_4.Text);
                        writer.WriteElementString("c1_3_1_5", this.textBoxC1_3_1_5.Text);
                        writer.WriteElementString("c1_3_1_6", this.textBoxC1_3_1_6.Text);
                        writer.WriteElementString("c1_3_1_7", this.textBoxC1_3_1_7.Text);
                        writer.WriteElementString("c1_3_1_8", this.textBoxC1_3_1_8.Text);
                        writer.WriteElementString("c1_3_1_9", this.textBoxC1_3_1_9.Text);
                        writer.WriteElementString("c1_3_2_1", this.textBoxC1_3_2_1.Text);
                        writer.WriteElementString("c1_3_2_2", this.textBoxC1_3_2_2.Text);
                        writer.WriteElementString("c1_3_2_3", this.textBoxC1_3_2_3.Text);
                        writer.WriteElementString("c1_3_2_4", this.textBoxC1_3_2_4.Text);
                        writer.WriteElementString("c1_3_2_5", this.textBoxC1_3_2_5.Text);
                        writer.WriteElementString("c1_3_2_6", this.textBoxC1_3_2_6.Text);
                        writer.WriteElementString("c1_3_2_7", this.textBoxC1_3_2_7.Text);
                        writer.WriteElementString("c1_3_2_8", this.textBoxC1_3_2_8.Text);
                        writer.WriteElementString("c1_3_2_9", this.textBoxC1_3_2_9.Text);
                        writer.WriteElementString("c1_3_3_1", this.textBoxC1_3_3_1.Text);
                        writer.WriteElementString("c1_3_3_2", this.textBoxC1_3_3_2.Text);
                        writer.WriteElementString("c1_3_3_3", this.textBoxC1_3_3_3.Text);
                        writer.WriteElementString("c1_3_3_4", this.textBoxC1_3_3_4.Text);
                        writer.WriteElementString("c1_3_3_5", this.textBoxC1_3_3_5.Text);
                        writer.WriteElementString("c1_3_3_6", this.textBoxC1_3_3_6.Text);
                        writer.WriteElementString("c1_3_3_7", this.textBoxC1_3_3_7.Text);
                        writer.WriteElementString("c1_3_3_8", this.textBoxC1_3_3_8.Text);
                        writer.WriteElementString("c1_3_3_9", this.textBoxC1_3_3_9.Text);
                        writer.WriteElementString("c1_3_4_1", this.textBoxC1_3_4_1.Text);
                        writer.WriteElementString("c1_3_4_2", this.textBoxC1_3_4_2.Text);
                        writer.WriteElementString("c1_3_4_3", this.textBoxC1_3_4_3.Text);
                        writer.WriteElementString("c1_3_4_4", this.textBoxC1_3_4_4.Text);
                        writer.WriteElementString("c1_3_4_5", this.textBoxC1_3_4_5.Text);
                        writer.WriteElementString("c1_3_4_6", this.textBoxC1_3_4_6.Text);
                        writer.WriteElementString("c1_3_4_7", this.textBoxC1_3_4_7.Text);
                        writer.WriteElementString("c1_3_4_8", this.textBoxC1_3_4_8.Text);
                        writer.WriteElementString("c1_3_4_9", this.textBoxC1_3_4_9.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c2_1_1", this.textBoxC2_1_1.Text);
                        writer.WriteElementString("c2_1_2", this.textBoxC2_1_2.Text);
                        writer.WriteElementString("c2_1_3", this.textBoxC2_1_3.Text);
                        writer.WriteElementString("c2_1_4", this.textBoxC2_1_4.Text);
                        writer.WriteElementString("c2_1_5", this.textBoxC2_1_5.Text);
                        writer.WriteElementString("c2_1_6", this.textBoxC2_1_6.Text);
                        writer.WriteElementString("c2_1_7", this.textBoxC2_1_7.Text);
                        writer.WriteElementString("c2_1_8", this.textBoxC2_1_8.Text);
                        writer.WriteElementString("c2_1_9", this.textBoxC2_1_9.Text);
                        writer.WriteElementString("c2_1_10", this.textBoxC2_1_10.Text);
                        writer.WriteElementString("c2_1_11", this.textBoxC2_1_11.Text);
                        writer.WriteElementString("c2_1_12", this.textBoxC2_1_12.Text);
                        writer.WriteElementString("c2_1_13", this.textBoxC2_1_13.Text);
                        writer.WriteElementString("c2_1_14", this.textBoxC2_1_14.Text);
                        writer.WriteElementString("c2_1_15", this.textBoxC2_1_15.Text);
                        writer.WriteElementString("c2_1_16", this.textBoxC2_1_16.Text);
                        writer.WriteElementString("c2_1_17", this.textBoxC2_1_17.Text);
                        writer.WriteElementString("c2_1_18", this.textBoxC2_1_18.Text);
                        writer.WriteElementString("c2_1_19", this.textBoxC2_1_19.Text);
                        writer.WriteElementString("c2_1_20", this.textBoxC2_1_20.Text);
                        writer.WriteElementString("c2_2_1", this.textBoxC2_2_1.Text);
                        writer.WriteElementString("c2_2_2", this.textBoxC2_2_2.Text);
                        if (!this.radioButtonC2_2_1.Checked)
                        {
                            break;
                        }
                        writer.WriteElementString("c2_2_3", "true");
                        goto Label_0813;

                    case "c3.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c3.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteStartElement("c3_1_1");
                        writer.WriteCData(this.controlC3_1_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_1_2");
                        writer.WriteCData(this.controlC3_1_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_1_3");
                        writer.WriteCData(this.controlC3_1_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_1_1");
                        writer.WriteCData(this.controlC3_2_1_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_1_2");
                        writer.WriteCData(this.controlC3_2_1_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_1_3");
                        writer.WriteCData(this.controlC3_2_1_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_2_1");
                        writer.WriteCData(this.controlC3_2_2_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_2_2");
                        writer.WriteCData(this.controlC3_2_2_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_2_3");
                        writer.WriteCData(this.controlC3_2_2_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_3_1");
                        writer.WriteCData(this.controlC3_2_3_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_3_2");
                        writer.WriteCData(this.controlC3_2_3_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_2_3_3");
                        writer.WriteCData(this.controlC3_2_3_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_1");
                        writer.WriteCData(this.controlC3_3_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_2");
                        writer.WriteCData(this.controlC3_3_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_3");
                        writer.WriteCData(this.controlC3_3_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_4");
                        writer.WriteCData(this.controlC3_3_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_5");
                        writer.WriteCData(this.controlC3_3_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_6");
                        writer.WriteCData(this.controlC3_3_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_7");
                        writer.WriteCData(this.controlC3_3_7.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_8");
                        writer.WriteCData(this.controlC3_3_8.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_3_9");
                        writer.WriteCData(this.controlC3_3_9.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_4_1");
                        writer.WriteCData(this.controlC3_4_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_4_2");
                        writer.WriteCData(this.controlC3_4_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c3_4_3");
                        writer.WriteCData(this.controlC3_4_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c4.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c4.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c4_1_1", this.textBoxC4_1_1.Text);
                        writer.WriteElementString("c4_1_2", this.textBoxC4_1_2.Text);
                        writer.WriteElementString("c4_1_3", this.textBoxC4_1_3.Text);
                        writer.WriteElementString("c4_1_4", this.textBoxC4_1_4.Text);
                        writer.WriteElementString("c4_1_5", this.textBoxC4_1_5.Text);
                        writer.WriteElementString("c4_1_6", this.textBoxC4_1_6.Text);
                        writer.WriteElementString("c4_1_7", this.textBoxC4_1_7.Text);
                        writer.WriteElementString("c4_1_8", this.textBoxC4_1_8.Text);
                        writer.WriteElementString("c4_1_9", this.textBoxC4_1_9.Text);
                        writer.WriteStartElement("c4_2_1");
                        writer.WriteCData(this.controlC4_2_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_2_2");
                        writer.WriteCData(this.controlC4_2_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_2_3");
                        writer.WriteCData(this.controlC4_2_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_1");
                        writer.WriteCData(this.controlC4_3_13.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_2");
                        writer.WriteCData(this.controlC4_3_14.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_3");
                        writer.WriteCData(this.controlC4_3_15.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_4");
                        writer.WriteCData(this.controlC4_3_16.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_5");
                        writer.WriteCData(this.controlC4_3_17.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_6");
                        writer.WriteCData(this.controlC4_3_18.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_7");
                        writer.WriteCData(this.controlC4_3_19.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_8");
                        writer.WriteCData(this.controlC4_3_20.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_3_9");
                        writer.WriteCData(this.controlC4_3_21.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_4_1");
                        writer.WriteCData(this.controlC4_4_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_4_2");
                        writer.WriteCData(this.controlC4_4_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c4_4_3");
                        writer.WriteCData(this.controlC4_4_7.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c5.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c5.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteStartElement("c5_1_1");
                        writer.WriteCData(this.controlC5_1_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_1_2");
                        writer.WriteCData(this.controlC5_1_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_1_3");
                        writer.WriteCData(this.controlC5_1_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_1");
                        writer.WriteCData(this.controlC5_2_7.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_2");
                        writer.WriteCData(this.controlC5_2_8.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_3");
                        writer.WriteCData(this.controlC5_2_9.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_4");
                        writer.WriteCData(this.controlC5_2_10.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_5");
                        writer.WriteCData(this.controlC5_2_11.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_6");
                        writer.WriteCData(this.controlC5_2_12.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_7");
                        writer.WriteCData(this.controlC5_2_13.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_8");
                        writer.WriteCData(this.controlC5_2_14.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_2_9");
                        writer.WriteCData(this.controlC5_2_15.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_1");
                        writer.WriteCData(this.controlC5_3_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_2");
                        writer.WriteCData(this.controlC5_3_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_3");
                        writer.WriteCData(this.controlC5_3_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_4");
                        writer.WriteCData(this.controlC5_3_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_5");
                        writer.WriteCData(this.controlC5_3_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_6");
                        writer.WriteCData(this.controlC5_3_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_7");
                        writer.WriteCData(this.controlC5_3_7.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_8");
                        writer.WriteCData(this.controlC5_3_8.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c5_3_9");
                        writer.WriteCData(this.controlC5_3_9.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c6.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c6.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c6_1_1", this.textBoxC6_1_1.Text);
                        writer.WriteElementString("c6_1_2", this.textBoxC6_1_2.Text);
                        writer.WriteStartElement("c6_2_1");
                        writer.WriteCData(this.controlC6_2_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_2");
                        writer.WriteCData(this.controlC6_2_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_3");
                        writer.WriteCData(this.controlC6_2_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_4");
                        writer.WriteCData(this.controlC6_2_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_5");
                        writer.WriteCData(this.controlC6_2_7.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_6");
                        writer.WriteCData(this.controlC6_2_8.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_7");
                        writer.WriteCData(this.controlC6_2_9.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_8");
                        writer.WriteCData(this.controlC6_2_10.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_9");
                        writer.WriteCData(this.controlC6_2_11.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_2_10");
                        writer.WriteCData(this.controlC6_2_12.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_3_1");
                        writer.WriteCData(this.controlC6_3_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_3_2");
                        writer.WriteCData(this.controlC6_3_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_3_3");
                        writer.WriteCData(this.controlC6_3_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_3_4");
                        writer.WriteCData(this.controlC6_3_5.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("c6_3_5");
                        writer.WriteCData(this.controlC6_3_6.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c7.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c7.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c7_1_1", this.textBoxC7_1_1.Text);
                        writer.WriteElementString("c7_1_2", this.textBoxC7_1_2.Text);
                        writer.WriteElementString("c7_1_3", this.textBoxC7_1_3.Text);
                        writer.WriteElementString("c7_1_4", this.textBoxC7_1_4.Text);
                        writer.WriteElementString("c7_1_5", this.textBoxC7_1_5.Text);
                        writer.WriteElementString("c7_1_6", this.textBoxC7_1_6.Text);
                        writer.WriteElementString("c7_1_7", this.textBoxC7_1_7.Text);
                        writer.WriteElementString("c7_1_8", this.textBoxC7_1_8.Text);
                        writer.WriteElementString("c7_1_9", this.textBoxC7_1_9.Text);
                        writer.WriteElementString("c7_2_1", this.textBoxC7_2_1.Text);
                        writer.WriteElementString("c7_2_2", this.textBoxC7_2_2.Text);
                        writer.WriteElementString("c7_2_3", this.textBoxC7_2_3.Text);
                        writer.WriteElementString("c7_2_4", this.textBoxC7_2_4.Text);
                        writer.WriteElementString("c7_3_1", this.textBoxC7_3_1.Text);
                        writer.WriteElementString("c7_3_2", this.textBoxC7_3_2.Text);
                        writer.WriteElementString("c7_3_3", this.textBoxC7_3_3.Text);
                        writer.WriteElementString("c7_3_4", this.textBoxC7_3_4.Text);
                        writer.WriteElementString("c7_3_5", this.textBoxC7_3_5.Text);
                        writer.WriteElementString("c7_3_6", this.textBoxC7_3_6.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c8.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c8.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c8_1_1", this.textBoxC8_1_1.Text);
                        writer.WriteElementString("c8_1_2", this.textBoxC8_1_2.Text);
                        writer.WriteElementString("c8_1_3", this.textBoxC8_1_3.Text);
                        writer.WriteElementString("c8_1_4", this.textBoxC8_1_4.Text);
                        writer.WriteElementString("c8_1_5", this.textBoxC8_1_5.Text);
                        writer.WriteElementString("c8_1_6", this.textBoxC8_1_6.Text);
                        writer.WriteElementString("c8_1_7", this.textBoxC8_1_7.Text);
                        writer.WriteElementString("c8_1_8", this.textBoxC8_1_8.Text);
                        writer.WriteElementString("c8_1_9", this.textBoxC8_1_9.Text);
                        writer.WriteElementString("c8_2_1", this.textBoxC8_2_1.Text);
                        writer.WriteElementString("c8_2_2", this.textBoxC8_2_2.Text);
                        writer.WriteElementString("c8_2_3", this.textBoxC8_2_3.Text);
                        writer.WriteElementString("c8_2_4", this.textBoxC8_2_4.Text);
                        writer.WriteElementString("c8_2_5", this.textBoxC8_2_5.Text);
                        writer.WriteElementString("c8_2_6", this.textBoxC8_2_6.Text);
                        writer.WriteElementString("c8_3_1", this.textBoxC8_3_1.Text);
                        writer.WriteElementString("c8_3_2", this.textBoxC8_3_2.Text);
                        writer.WriteElementString("c8_3_3", this.textBoxC8_3_3.Text);
                        writer.WriteElementString("c8_3_4", this.textBoxC8_3_4.Text);
                        writer.WriteElementString("c8_3_5", this.textBoxC8_3_5.Text);
                        writer.WriteElementString("c8_3_6", this.textBoxC8_3_6.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c9.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c9.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c9_1", this.textBoxC9_1_1.Text);
                        if (!this.radiobuttonC9_2_1.Checked)
                        {
                            goto Label_1E76;
                        }
                        writer.WriteElementString("c9_2", "false");
                        goto Label_1EB2;

                    case "c10.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c10.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c10_1_1", this.comboBoxC10_1_1.SelectedIndex.ToString());
                        writer.WriteElementString("c10_1_2", this.textBoxC10_1_1.Text);
                        writer.WriteElementString("c10_2_1", this.comboBoxC10_2_1.SelectedIndex.ToString());
                        writer.WriteElementString("c10_2_2", this.textBoxC10_2_1.Text);
                        writer.WriteElementString("c10_2_3_1", this.comboBoxC10_2_2.SelectedIndex.ToString());
                        writer.WriteElementString("c10_2_3", this.comboBoxC10_2_3.SelectedIndex.ToString());
                        writer.WriteElementString("c10_2_4", this.textBoxC10_2_2.Text);
                        writer.WriteElementString("c10_2_5", this.textBoxC10_2_3.Text);
                        writer.WriteElementString("c10_2_6", this.textBoxC10_2_4.Text);
                        writer.WriteElementString("c10_2_7", this.textBoxC10_2_5.Text);
                        writer.WriteElementString("c10_2_8", this.textBoxC10_2_6.Text);
                        int selectedIndex = this.comboBoxC10_3_1.SelectedIndex;
                        writer.WriteElementString("c10_3_1", selectedIndex.ToString());
                        writer.WriteElementString("c10_3_2", this.textBoxC10_3_1.Text);
                        writer.WriteElementString("c10_3_3", this.textBoxC10_3_2.Text);
                        writer.WriteElementString("c10_3_4", this.textBoxC10_3_3.Text);
                        writer.WriteElementString("c10_3_5", this.textBoxC10_3_4.Text);
                        writer.WriteElementString("c10_3_6", this.textBoxC10_3_5.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    case "c11.xml":
                    {
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "c11.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("c11_1_1", this.comboBoxC11_1_1.SelectedIndex.ToString());
                        writer.WriteElementString("c11_1_2", this.textBoxC11_1_1.Text);
                        writer.WriteElementString("c11_1_3", this.comboBoxC11_1_2.SelectedIndex.ToString());
                        writer.WriteElementString("c11_1_4", this.textBoxC11_1_2.Text);
                        writer.WriteElementString("c11_2_1", this.comboBoxC11_2_1.SelectedIndex.ToString());
                        writer.WriteElementString("c11_2_2", this.textBoxC11_2_1.Text);
                        writer.WriteElementString("c11_2_3", this.comboBoxC11_2_2.SelectedIndex.ToString());
                        writer.WriteElementString("c11_2_4", this.textBoxC11_2_2.Text);
                        writer.WriteElementString("c11_2_5", this.textBoxC11_2_3.Text);
                        writer.WriteElementString("c11_2_6", this.textBoxC11_2_4.Text);
                        writer.WriteElementString("c11_2_7", this.textBoxC11_2_5.Text);
                        writer.WriteElementString("c11_3_1", this.comboBoxC11_3_1.SelectedIndex.ToString());
                        writer.WriteElementString("c11_3_2", this.textBoxC11_3_1.Text);
                        writer.WriteElementString("c11_3_3", this.textBoxC11_3_2.Text);
                        writer.WriteElementString("c11_3_4", this.comboBoxC11_3_2.SelectedIndex.ToString());
                        writer.WriteElementString("c11_3_5", this.textBoxC11_3_3.Text);
                        writer.WriteElementString("c11_3_6", this.textBoxC11_3_4.Text);
                        writer.WriteElementString("c11_3_7", this.textBoxC11_3_5.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                if (this.radioButtonC2_2_2.Checked)
                {
                    writer.WriteElementString("c2_2_3", "false");
                }
                else
                {
                    writer.WriteElementString("c2_2_3", "none");
                }
            Label_0813:
                writer.WriteStartElement("c2_3_1_1");
                writer.WriteCData(this.controlC2_3_1.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_1_2");
                writer.WriteCData(this.controlC2_3_2.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_1_3");
                writer.WriteCData(this.controlC2_3_3.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_1_4");
                writer.WriteCData(this.controlC2_3_4.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_2_1");
                writer.WriteCData(this.controlC2_3_5.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_2_2");
                writer.WriteCData(this.controlC2_3_6.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_2_3");
                writer.WriteCData(this.controlC2_3_7.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_2_4");
                writer.WriteCData(this.controlC2_3_8.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_3_1");
                writer.WriteCData(this.controlC2_3_9.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_3_2");
                writer.WriteCData(this.controlC2_3_10.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_3_3");
                writer.WriteCData(this.controlC2_3_11.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_3_3_4");
                writer.WriteCData(this.controlC2_3_12.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_4_1");
                writer.WriteCData(this.controlC2_4_1.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_4_2");
                writer.WriteCData(this.controlC2_4_2.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_4_3");
                writer.WriteCData(this.controlC2_4_3.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("c2_4_4");
                writer.WriteCData(this.controlC2_4_4.pub_GetXML(false).ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                continue;
            Label_1E76:
                if (this.radiobuttonC9_2_2.Checked)
                {
                    writer.WriteElementString("c9_2", "true");
                }
                else
                {
                    writer.WriteElementString("c9_2", "false");
                }
            Label_1EB2:
                writer.WriteElementString("c9_3_1", this.textBoxC9_3_1.Text);
                writer.WriteElementString("c9_3_2", this.textBoxC9_3_2.Text);
                writer.WriteElementString("c9_3_3", this.textBoxC9_3_3.Text);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        private void CalculationScoreShow(object sender, EventArgs e)
        {
            foreach (string str in this.calculationString)
            {
                List<bool> list;
                List<bool> list2;
                int num;
                List<bool> list4;
                int num15;
                List<bool> list5;
                int num18;
                int num19;
                int num20;
                List<bool> list6;
                int num24;
                int num25;
                List<bool> list7;
                List<bool> list8;
                List<bool> list9;
                List<bool> list10;
                List<bool> list11;
                switch (str)
                {
                    case "c1.xml":
                        list = this.calculationAnswerResults["c1.xml"];
                        if (!list[0])
                        {
                            break;
                        }
                        this.labelC1_1.Text = "4";
                        this.totalScore += 4;
                        goto Label_0177;

                    case "c2.xml":
                        list2 = this.calculationAnswerResults["c2.xml"];
                        if (!list2[0])
                        {
                            goto Label_0264;
                        }
                        this.labelC2_1.Text = "4";
                        this.totalScore += 4;
                        goto Label_0283;

                    case "c3.xml":
                    {
                        List<bool> list3 = this.calculationAnswerResults["c3.xml"];
                        int num6 = 0;
                        int num7 = 0;
                        int num8 = 0;
                        int num9 = 0;
                        int num10 = 0;
                        int num11 = 0;
                        if (list3[0])
                        {
                            num6 = 2;
                            this.totalScore += 2;
                        }
                        if (list3[2])
                        {
                            num7 = 2;
                            this.totalScore += 2;
                        }
                        if (list3[4])
                        {
                            num8 = 2;
                            this.totalScore += 2;
                        }
                        if (list3[1])
                        {
                            num9 = 2;
                            this.totalScore += 2;
                        }
                        if (list3[3])
                        {
                            num10 = 2;
                            this.totalScore += 2;
                        }
                        if (list3[5])
                        {
                            num11 = 2;
                            this.totalScore += 2;
                        }
                        this.labelC3_1.Text = string.Concat(new object[] { num6, ",", num7, ",", num8 });
                        this.labelC3_2.Text = string.Concat(new object[] { num9, ",", num10, ",", num11 });
                        int num12 = 0;
                        int num13 = 0;
                        int num14 = 0;
                        if (list3[6])
                        {
                            num12 = 1;
                            this.totalScore++;
                        }
                        if (list3[7])
                        {
                            num13 = 1;
                            this.totalScore++;
                        }
                        if (list3[8])
                        {
                            num14 = 1;
                            this.totalScore++;
                        }
                        this.labelC3_3.Text = string.Concat(new object[] { num12, ",", num13, ",", num14 });
                        if (list3[9])
                        {
                            this.labelC3_4.Text = "3";
                            this.totalScore += 3;
                        }
                        else
                        {
                            this.labelC3_4.Text = "0";
                        }
                        continue;
                    }
                    case "c4.xml":
                        list4 = this.calculationAnswerResults["c4.xml"];
                        if (!list4[0])
                        {
                            goto Label_06F5;
                        }
                        this.labelC4_1.Text = "3";
                        this.totalScore += 3;
                        goto Label_0708;

                    case "c5.xml":
                        list5 = this.calculationAnswerResults["c5.xml"];
                        num18 = 0;
                        num19 = 0;
                        num20 = 0;
                        if (!list5[0])
                        {
                            goto Label_08B4;
                        }
                        num18 = 2;
                        this.totalScore += 2;
                        goto Label_08B9;

                    case "c6.xml":
                        list6 = this.calculationAnswerResults["c6.xml"];
                        num24 = 0;
                        num25 = 0;
                        if (!list6[0])
                        {
                            goto Label_0ABF;
                        }
                        num24 = 2;
                        this.totalScore += 2;
                        goto Label_0AC4;

                    case "c7.xml":
                        list7 = this.calculationAnswerResults["c7.xml"];
                        if (!list7[0])
                        {
                            goto Label_0BEC;
                        }
                        this.labelC7_1.Text = "4";
                        this.totalScore += 4;
                        goto Label_0BFF;

                    case "c8.xml":
                        list8 = this.calculationAnswerResults["c8.xml"];
                        if (!list8[0])
                        {
                            goto Label_0CD8;
                        }
                        this.labelC8_1.Text = "4";
                        this.totalScore += 4;
                        goto Label_0CEB;

                    case "c9.xml":
                        list9 = this.calculationAnswerResults["c9.xml"];
                        if (!list9[0])
                        {
                            goto Label_0DC4;
                        }
                        this.labelC9_1.Text = "4";
                        this.totalScore += 4;
                        goto Label_0DD7;

                    case "c10.xml":
                        list10 = this.calculationAnswerResults["c10.xml"];
                        if (!list10[0])
                        {
                            goto Label_0EB0;
                        }
                        this.labelC10_1.Text = "1";
                        this.totalScore++;
                        goto Label_0EC3;

                    case "c11.xml":
                        list11 = this.calculationAnswerResults["c11.xml"];
                        if (!list11[0])
                        {
                            goto Label_0F9C;
                        }
                        this.labelC11_1.Text = "1";
                        this.totalScore++;
                        goto Label_0FAF;

                    default:
                    {
                        continue;
                    }
                }
                this.labelC1_1.Text = "0";
                this.totalScore = this.totalScore;
            Label_0177:
                if (list[1])
                {
                    this.labelC1_2.Text = "3";
                    this.totalScore += 3;
                }
                else
                {
                    this.labelC1_2.Text = "0";
                    this.totalScore = this.totalScore;
                }
                if (list[2])
                {
                    this.labelC1_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC1_3.Text = "0";
                    this.totalScore = this.totalScore;
                }
                continue;
            Label_0264:
                this.labelC2_1.Text = "0";
                this.totalScore = this.totalScore;
            Label_0283:
                num = 0;
                int num2 = 0;
                int num3 = 0;
                if (list2[1])
                {
                    num = 1;
                    this.totalScore++;
                }
                if (list2[2])
                {
                    num2 = 1;
                    this.totalScore++;
                }
                if (list2[3])
                {
                    num3 = 1;
                    this.totalScore++;
                }
                this.labelC2_2.Text = string.Concat(new object[] { num, ",", num2, ",", num3 });
                int num4 = 0;
                int num5 = 0;
                if (list2[4])
                {
                    num4 = 2;
                    this.totalScore += 2;
                }
                if (list2[5])
                {
                    num5 = 2;
                    this.totalScore += 2;
                }
                this.labelC2_3.Text = num4 + "," + num5;
                if (list2[6])
                {
                    this.labelC2_4.Text = "2";
                    this.totalScore += 2;
                }
                else
                {
                    this.labelC2_4.Text = "0";
                    this.totalScore = this.totalScore;
                }
                continue;
            Label_06F5:
                this.labelC4_1.Text = "0";
            Label_0708:
                num15 = 0;
                int num16 = 0;
                int num17 = 0;
                if (list4[1])
                {
                    num15 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num15 = 0;
                }
                if (list4[2])
                {
                    num16 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num16 = 0;
                }
                if (list4[3])
                {
                    num17 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num17 = 0;
                }
                this.labelC4_2.Text = string.Concat(new object[] { num15, "，", num16, ",", num17 });
                if (list4[4])
                {
                    this.labelC4_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC4_3.Text = "0";
                }
                if (list4[5])
                {
                    this.labelC4_4.Text = "3";
                    this.totalScore += 3;
                }
                else
                {
                    this.labelC4_4.Text = "0";
                }
                continue;
            Label_08B4:
                num18 = 0;
            Label_08B9:
                if (list5[1])
                {
                    num19 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num19 = 0;
                }
                if (list5[2])
                {
                    num20 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num20 = 0;
                }
                this.labelC5_1.Text = string.Concat(new object[] { num18, ",", num19, ",", num20 });
                int num21 = 0;
                int num22 = 0;
                int num23 = 0;
                if (list5[3])
                {
                    num21 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num21 = 0;
                }
                if (list5[4])
                {
                    num22 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num22 = 0;
                }
                if (list5[5])
                {
                    num23 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num23 = 0;
                }
                this.labelC5_2.Text = string.Concat(new object[] { num21, ",", num22, ",", num23 });
                if (list5[6])
                {
                    this.labelC5_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC5_3.Text = "0";
                }
                continue;
            Label_0ABF:
                num24 = 0;
            Label_0AC4:
                if (list6[1])
                {
                    num25 = 2;
                    this.totalScore += 2;
                }
                else
                {
                    num25 = 0;
                }
                this.labelC6_1.Text = num24 + "," + num25;
                if (list6[2])
                {
                    this.labelC6_2.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC6_2.Text = "0";
                }
                if (list6[3])
                {
                    this.labelC6_3.Text = "2";
                    this.totalScore += 2;
                }
                else
                {
                    this.labelC6_3.Text = "0";
                }
                continue;
            Label_0BEC:
                this.labelC7_1.Text = "0";
            Label_0BFF:
                if (list7[1])
                {
                    this.labelC7_2.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC7_2.Text = "0";
                }
                if (list7[2])
                {
                    this.labelC7_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC7_3.Text = "0";
                }
                continue;
            Label_0CD8:
                this.labelC8_1.Text = "0";
            Label_0CEB:
                if (list8[1])
                {
                    this.labelC8_2.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC8_2.Text = "0";
                }
                if (list8[2])
                {
                    this.labelC8_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC8_3.Text = "0";
                }
                continue;
            Label_0DC4:
                this.labelC9_1.Text = "0";
            Label_0DD7:
                if (list9[1])
                {
                    this.labelC9_2.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC9_2.Text = "0";
                }
                if (list9[2])
                {
                    this.labelC9_3.Text = "6";
                    this.totalScore += 6;
                }
                else
                {
                    this.labelC9_3.Text = "0";
                }
                continue;
            Label_0EB0:
                this.labelC10_1.Text = "0";
            Label_0EC3:
                if (list10[1])
                {
                    this.labelC10_2.Text = "5";
                    this.totalScore += 5;
                }
                else
                {
                    this.labelC10_2.Text = "0";
                }
                if (list10[2])
                {
                    this.labelC10_3.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC10_3.Text = "0";
                }
                continue;
            Label_0F9C:
                this.labelC11_1.Text = "0";
            Label_0FAF:
                if (list11[1])
                {
                    this.labelC11_2.Text = "5";
                    this.totalScore += 5;
                }
                else
                {
                    this.labelC11_2.Text = "0";
                }
                if (list11[2])
                {
                    this.labelC11_3.Text = "4";
                    this.totalScore += 4;
                }
                else
                {
                    this.labelC11_3.Text = "0";
                }
            }
        }

        private void ChoiceAnswerJudge(object sender, EventArgs e)
        {
            this.ChoiceAnwser = new List<bool>();
            this.UserChoiceString = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                {
                    goto Label_020A;
                }
                string str = ChoiceMethod.Result[i];
                if (str != null)
                {
                    if (!(str == "a"))
                    {
                        if (str == "b")
                        {
                            goto Label_00B6;
                        }
                        if (str == "c")
                        {
                            goto Label_00EA;
                        }
                        if (str == "d")
                        {
                            goto Label_011E;
                        }
                    }
                    else if (this.radioButton_one_1.Checked)
                    {
                        this.ChoiceAnwser.Add(true);
                    }
                    else
                    {
                        this.ChoiceAnwser.Add(false);
                    }
                }
                goto Label_0152;
            Label_00B6:
                if (this.radioButton_one_2.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0152;
            Label_00EA:
                if (this.radioButton_one_3.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0152;
            Label_011E:
                if (this.radioButton_one_4.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
            Label_0152:
                if (this.radioButton_one_1.Checked)
                {
                    this.UserChoiceString.Add("a");
                }
                else if (this.radioButton_one_2.Checked)
                {
                    this.UserChoiceString.Add("b");
                }
                else if (this.radioButton_one_3.Checked)
                {
                    this.UserChoiceString.Add("c");
                }
                else if (this.radioButton_one_4.Checked)
                {
                    this.UserChoiceString.Add("d");
                }
                else
                {
                    this.UserChoiceString.Add("unchecked");
                }
                continue;
            Label_020A:
                if (i != 1)
                {
                    goto Label_03F5;
                }
                str = ChoiceMethod.Result[i];
                if (str != null)
                {
                    if (!(str == "a"))
                    {
                        if (str == "b")
                        {
                            goto Label_02A1;
                        }
                        if (str == "c")
                        {
                            goto Label_02D5;
                        }
                        if (str == "d")
                        {
                            goto Label_0309;
                        }
                    }
                    else if (this.radioButton_Two_1.Checked)
                    {
                        this.ChoiceAnwser.Add(true);
                    }
                    else
                    {
                        this.ChoiceAnwser.Add(false);
                    }
                }
                goto Label_033D;
            Label_02A1:
                if (this.radioButton_Two_2.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_033D;
            Label_02D5:
                if (this.radioButton_Two_3.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_033D;
            Label_0309:
                if (this.radioButton_Two_4.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
            Label_033D:
                if (this.radioButton_Two_1.Checked)
                {
                    this.UserChoiceString.Add("a");
                }
                else if (this.radioButton_Two_2.Checked)
                {
                    this.UserChoiceString.Add("b");
                }
                else if (this.radioButton_Two_3.Checked)
                {
                    this.UserChoiceString.Add("c");
                }
                else if (this.radioButton_Two_4.Checked)
                {
                    this.UserChoiceString.Add("d");
                }
                else
                {
                    this.UserChoiceString.Add("unchecked");
                }
                continue;
            Label_03F5:
                if (i != 2)
                {
                    goto Label_05E0;
                }
                str = ChoiceMethod.Result[i];
                if (str != null)
                {
                    if (!(str == "a"))
                    {
                        if (str == "b")
                        {
                            goto Label_048C;
                        }
                        if (str == "c")
                        {
                            goto Label_04C0;
                        }
                        if (str == "d")
                        {
                            goto Label_04F4;
                        }
                    }
                    else if (this.radioButton_Three_1.Checked)
                    {
                        this.ChoiceAnwser.Add(true);
                    }
                    else
                    {
                        this.ChoiceAnwser.Add(false);
                    }
                }
                goto Label_0528;
            Label_048C:
                if (this.radioButton_Three_2.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0528;
            Label_04C0:
                if (this.radioButton_Three_3.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0528;
            Label_04F4:
                if (this.radioButton_Three_4.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
            Label_0528:
                if (this.radioButton_Three_1.Checked)
                {
                    this.UserChoiceString.Add("a");
                }
                else if (this.radioButton_Three_2.Checked)
                {
                    this.UserChoiceString.Add("b");
                }
                else if (this.radioButton_Three_3.Checked)
                {
                    this.UserChoiceString.Add("c");
                }
                else if (this.radioButton_Three_4.Checked)
                {
                    this.UserChoiceString.Add("d");
                }
                else
                {
                    this.UserChoiceString.Add("unchecked");
                }
                continue;
            Label_05E0:
                if (i != 3)
                {
                    goto Label_07CB;
                }
                str = ChoiceMethod.Result[i];
                if (str != null)
                {
                    if (!(str == "a"))
                    {
                        if (str == "b")
                        {
                            goto Label_0677;
                        }
                        if (str == "c")
                        {
                            goto Label_06AB;
                        }
                        if (str == "d")
                        {
                            goto Label_06DF;
                        }
                    }
                    else if (this.radioButton_Four_1.Checked)
                    {
                        this.ChoiceAnwser.Add(true);
                    }
                    else
                    {
                        this.ChoiceAnwser.Add(false);
                    }
                }
                goto Label_0713;
            Label_0677:
                if (this.radioButton_Four_2.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0713;
            Label_06AB:
                if (this.radioButton_Four_3.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_0713;
            Label_06DF:
                if (this.radioButton_Four_4.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
            Label_0713:
                if (this.radioButton_Four_1.Checked)
                {
                    this.UserChoiceString.Add("a");
                }
                else if (this.radioButton_Four_2.Checked)
                {
                    this.UserChoiceString.Add("b");
                }
                else if (this.radioButton_Four_3.Checked)
                {
                    this.UserChoiceString.Add("c");
                }
                else if (this.radioButton_Four_4.Checked)
                {
                    this.UserChoiceString.Add("d");
                }
                else
                {
                    this.UserChoiceString.Add("unchecked");
                }
                continue;
            Label_07CB:
                if (i != 4)
                {
                    continue;
                }
                str = ChoiceMethod.Result[i];
                if (str != null)
                {
                    if (!(str == "a"))
                    {
                        if (str == "b")
                        {
                            goto Label_0862;
                        }
                        if (str == "c")
                        {
                            goto Label_0896;
                        }
                        if (str == "d")
                        {
                            goto Label_08CA;
                        }
                    }
                    else if (this.radioButton_Five_1.Checked)
                    {
                        this.ChoiceAnwser.Add(true);
                    }
                    else
                    {
                        this.ChoiceAnwser.Add(false);
                    }
                }
                goto Label_08FE;
            Label_0862:
                if (this.radioButton_Five_2.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_08FE;
            Label_0896:
                if (this.radioButton_Five_3.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
                goto Label_08FE;
            Label_08CA:
                if (this.radioButton_Five_4.Checked)
                {
                    this.ChoiceAnwser.Add(true);
                }
                else
                {
                    this.ChoiceAnwser.Add(false);
                }
            Label_08FE:
                if (this.radioButton_Five_1.Checked)
                {
                    this.UserChoiceString.Add("a");
                }
                else if (this.radioButton_Five_2.Checked)
                {
                    this.UserChoiceString.Add("b");
                }
                else if (this.radioButton_Five_3.Checked)
                {
                    this.UserChoiceString.Add("c");
                }
                else if (this.radioButton_Five_4.Checked)
                {
                    this.UserChoiceString.Add("d");
                }
                else
                {
                    this.UserChoiceString.Add("unchecked");
                }
            }
        }

        private void choiceInitialAndShow(List<string> choiceTitle)
        {
            int num;
            this.label_Choice.Font = new Font("宋体", 30f);
            this.label_Choice.AutoSize = true;
            this.label_Choice.Text = "一、选择题（每小题4分，共20分)";
            this.flowLayoutPanel1.Controls.Add(this.label_Choice);
            this.flowLayoutPanel1.SetFlowBreak(this.label_Choice, true);
            for (num = 0; num < choiceTitle.Count; num++)
            {
                switch (num)
                {
                    case 0:
                    {
                        this.table_one = new TableLayoutPanel();
                        this.pictureBox_one_1 = new PictureBox();
                        this.pictureBox_one_2 = new PictureBox();
                        this.pictureBox_one_3 = new PictureBox();
                        this.pictureBox_one_4 = new PictureBox();
                        this.pictureBox_one_5 = new PictureBox();
                        this.pictureBox_one_6 = new PictureBox();
                        this.pictureBox_one_7 = new PictureBox();
                        this.pictureBox_one_8 = new PictureBox();
                        this.pictureBox_one_9 = new PictureBox();
                        List<PictureBox> list = new List<PictureBox> {
                            this.pictureBox_one_1,
                            this.pictureBox_one_2,
                            this.pictureBox_one_3,
                            this.pictureBox_one_4,
                            this.pictureBox_one_5,
                            this.pictureBox_one_6,
                            this.pictureBox_one_7,
                            this.pictureBox_one_8,
                            this.pictureBox_one_9
                        };
                        List<RadioButton> radioButton = new List<RadioButton>();
                        this.radioButton_one_1 = new RadioButton();
                        this.radioButton_one_2 = new RadioButton();
                        this.radioButton_one_3 = new RadioButton();
                        this.radioButton_one_4 = new RadioButton();
                        radioButton.Add(this.radioButton_one_1);
                        radioButton.Add(this.radioButton_one_2);
                        radioButton.Add(this.radioButton_one_3);
                        radioButton.Add(this.radioButton_one_4);
                        this.labelChoice1_1 = new Label();
                        this.initScoreLabel(this.labelChoice1_1);
                        this.labelChoice1_2 = new Label();
                        this.initLabel(this.labelChoice1_2);
                        this.labelChoice1_2.Text = "1";
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice1_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice1_2);
                        this.labelChoice1_3 = new Label();
                        ChoiceMethod.addChoice(this.table_one, this.flowLayoutPanel1, list, choiceTitle[num], radioButton, this.AnwserNumber[num], this.labelChoice1_3);
                        break;
                    }
                    case 1:
                    {
                        this.table_Two = new TableLayoutPanel();
                        this.pictureBox_two_1 = new PictureBox();
                        this.pictureBox_two_2 = new PictureBox();
                        this.pictureBox_two_3 = new PictureBox();
                        this.pictureBox_two_4 = new PictureBox();
                        this.pictureBox_two_5 = new PictureBox();
                        this.pictureBox_two_6 = new PictureBox();
                        this.pictureBox_two_7 = new PictureBox();
                        this.pictureBox_two_8 = new PictureBox();
                        this.pictureBox_two_9 = new PictureBox();
                        List<PictureBox> list3 = new List<PictureBox> {
                            this.pictureBox_two_1,
                            this.pictureBox_two_2,
                            this.pictureBox_two_3,
                            this.pictureBox_two_4,
                            this.pictureBox_two_5,
                            this.pictureBox_two_6,
                            this.pictureBox_two_7,
                            this.pictureBox_two_8,
                            this.pictureBox_two_9
                        };
                        List<RadioButton> list4 = new List<RadioButton>();
                        this.radioButton_Two_1 = new RadioButton();
                        this.radioButton_Two_2 = new RadioButton();
                        this.radioButton_Two_3 = new RadioButton();
                        this.radioButton_Two_4 = new RadioButton();
                        list4.Add(this.radioButton_Two_1);
                        list4.Add(this.radioButton_Two_2);
                        list4.Add(this.radioButton_Two_3);
                        list4.Add(this.radioButton_Two_4);
                        this.labelChoice2_1 = new Label();
                        this.initScoreLabel(this.labelChoice2_1);
                        this.labelChoice2_2 = new Label();
                        this.initLabel(this.labelChoice2_2);
                        this.labelChoice2_2.Text = "2";
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice2_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice2_2);
                        this.labelChoice2_3 = new Label();
                        ChoiceMethod.addChoice(this.table_Two, this.flowLayoutPanel1, list3, this.ChoicegString[num], list4, this.AnwserNumber[num], this.labelChoice2_3);
                        break;
                    }
                    case 2:
                    {
                        this.table_Three = new TableLayoutPanel();
                        this.pictureBox_three_1 = new PictureBox();
                        this.pictureBox_three_2 = new PictureBox();
                        this.pictureBox_three_3 = new PictureBox();
                        this.pictureBox_three_4 = new PictureBox();
                        this.pictureBox_three_5 = new PictureBox();
                        this.pictureBox_three_6 = new PictureBox();
                        this.pictureBox_three_7 = new PictureBox();
                        this.pictureBox_three_8 = new PictureBox();
                        this.pictureBox_three_9 = new PictureBox();
                        List<PictureBox> list5 = new List<PictureBox> {
                            this.pictureBox_three_1,
                            this.pictureBox_three_2,
                            this.pictureBox_three_3,
                            this.pictureBox_three_4,
                            this.pictureBox_three_5,
                            this.pictureBox_three_6,
                            this.pictureBox_three_7,
                            this.pictureBox_three_8,
                            this.pictureBox_three_9
                        };
                        List<RadioButton> list6 = new List<RadioButton>();
                        this.radioButton_Three_1 = new RadioButton();
                        this.radioButton_Three_2 = new RadioButton();
                        this.radioButton_Three_3 = new RadioButton();
                        this.radioButton_Three_4 = new RadioButton();
                        list6.Add(this.radioButton_Three_1);
                        list6.Add(this.radioButton_Three_2);
                        list6.Add(this.radioButton_Three_3);
                        list6.Add(this.radioButton_Three_4);
                        this.labelChoice3_1 = new Label();
                        this.initScoreLabel(this.labelChoice3_1);
                        this.labelChoice3_2 = new Label();
                        this.initLabel(this.labelChoice3_2);
                        this.labelChoice3_2.Text = "3";
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice3_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice3_2);
                        this.labelChoice3_3 = new Label();
                        ChoiceMethod.addChoice(this.table_Three, this.flowLayoutPanel1, list5, this.ChoicegString[num], list6, this.AnwserNumber[num], this.labelChoice3_3);
                        break;
                    }
                    case 3:
                    {
                        this.table_Four = new TableLayoutPanel();
                        this.pictureBox_four_1 = new PictureBox();
                        this.pictureBox_four_2 = new PictureBox();
                        this.pictureBox_four_3 = new PictureBox();
                        this.pictureBox_four_4 = new PictureBox();
                        this.pictureBox_four_5 = new PictureBox();
                        this.pictureBox_four_6 = new PictureBox();
                        this.pictureBox_four_7 = new PictureBox();
                        this.pictureBox_four_8 = new PictureBox();
                        this.pictureBox_four_9 = new PictureBox();
                        List<PictureBox> list7 = new List<PictureBox> {
                            this.pictureBox_four_1,
                            this.pictureBox_four_2,
                            this.pictureBox_four_3,
                            this.pictureBox_four_4,
                            this.pictureBox_four_5,
                            this.pictureBox_four_6,
                            this.pictureBox_four_7,
                            this.pictureBox_four_8,
                            this.pictureBox_four_9
                        };
                        List<RadioButton> list8 = new List<RadioButton>();
                        this.radioButton_Four_1 = new RadioButton();
                        this.radioButton_Four_2 = new RadioButton();
                        this.radioButton_Four_3 = new RadioButton();
                        this.radioButton_Four_4 = new RadioButton();
                        list8.Add(this.radioButton_Four_1);
                        list8.Add(this.radioButton_Four_2);
                        list8.Add(this.radioButton_Four_3);
                        list8.Add(this.radioButton_Four_4);
                        this.labelChoice4_1 = new Label();
                        this.initScoreLabel(this.labelChoice4_1);
                        this.labelChoice4_2 = new Label();
                        this.initLabel(this.labelChoice4_2);
                        this.labelChoice4_2.Text = "4";
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice4_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice4_2);
                        this.labelChoice4_3 = new Label();
                        ChoiceMethod.addChoice(this.table_Four, this.flowLayoutPanel1, list7, this.ChoicegString[num], list8, this.AnwserNumber[num], this.labelChoice4_3);
                        break;
                    }
                    case 4:
                    {
                        this.table_five = new TableLayoutPanel();
                        this.pictureBox_five_1 = new PictureBox();
                        this.pictureBox_five_2 = new PictureBox();
                        this.pictureBox_five_3 = new PictureBox();
                        this.pictureBox_five_4 = new PictureBox();
                        this.pictureBox_five_5 = new PictureBox();
                        this.pictureBox_five_6 = new PictureBox();
                        this.pictureBox_five_7 = new PictureBox();
                        this.pictureBox_five_8 = new PictureBox();
                        this.pictureBox_five_9 = new PictureBox();
                        List<PictureBox> list9 = new List<PictureBox> {
                            this.pictureBox_five_1,
                            this.pictureBox_five_2,
                            this.pictureBox_five_3,
                            this.pictureBox_five_4,
                            this.pictureBox_five_5,
                            this.pictureBox_five_6,
                            this.pictureBox_five_7,
                            this.pictureBox_five_8,
                            this.pictureBox_five_9
                        };
                        List<RadioButton> list10 = new List<RadioButton>();
                        this.radioButton_Five_1 = new RadioButton();
                        this.radioButton_Five_2 = new RadioButton();
                        this.radioButton_Five_3 = new RadioButton();
                        this.radioButton_Five_4 = new RadioButton();
                        list10.Add(this.radioButton_Five_1);
                        list10.Add(this.radioButton_Five_2);
                        list10.Add(this.radioButton_Five_3);
                        list10.Add(this.radioButton_Five_4);
                        this.labelChoice5_1 = new Label();
                        this.initScoreLabel(this.labelChoice5_1);
                        this.labelChoice5_2 = new Label();
                        this.initLabel(this.labelChoice5_2);
                        this.labelChoice5_2.Text = "5";
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice5_1);
                        this.flowLayoutPanel1.Controls.Add(this.labelChoice5_2);
                        this.labelChoice5_3 = new Label();
                        ChoiceMethod.addChoice(this.table_five, this.flowLayoutPanel1, list9, this.ChoicegString[num], list10, this.AnwserNumber[num], this.labelChoice5_3);
                        break;
                    }
                }
            }
            string path = "temp/generate/choice.xml";
            FileStream w = new FileStream(path, FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            writer.WriteStartDocument();
            writer.WriteStartElement("Info");
            writer.WriteAttributeString("guid", this.guid);
            for (num = 1; num <= this.ChoicegString.Count; num++)
            {
                writer.WriteStartElement("qid");
                writer.WriteAttributeString("id", num.ToString());
                writer.WriteElementString("name", this.ChoicegString[num - 1]);
                writer.WriteElementString("RightAnswer", ChoiceMethod.Result[num - 1]);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        private void ChoiceSave(object sender, EventArgs e)
        {
            SupportTools.DirectoryIsExist("temp/UA");
            FileStream w = new FileStream("temp/UA/choiceAnswer.xml", FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            writer.WriteStartDocument();
            writer.WriteStartElement("choiceAnswer");
            writer.WriteAttributeString("guid", this.guid);
            for (int i = 1; i <= this.ChoicegString.Count; i++)
            {
                writer.WriteStartElement("qid");
                writer.WriteAttributeString("id", i.ToString());
                writer.WriteAttributeString("name", this.ChoicegString[i - 1]);
                writer.WriteElementString("UserAnswer", this.UserChoiceString[i - 1]);
                writer.WriteElementString("RightAnswer", ChoiceMethod.Result[i - 1]);
                writer.WriteElementString("IsTrue", this.ChoiceAnwser[i - 1].ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        private void ChoiceScoreShow(object sender, EventArgs e)
        {
            this.totalScore = 0;
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                    {
                        if (!this.ChoiceAnwser[i])
                        {
                            break;
                        }
                        this.labelChoice1_1.Text = "4";
                        this.totalScore += 4;
                        continue;
                    }
                    case 1:
                    {
                        if (!this.ChoiceAnwser[i])
                        {
                            goto Label_00C1;
                        }
                        this.labelChoice2_1.Text = "4";
                        this.totalScore += 4;
                        continue;
                    }
                    case 2:
                    {
                        if (!this.ChoiceAnwser[i])
                        {
                            goto Label_011B;
                        }
                        this.labelChoice3_1.Text = "4";
                        this.totalScore += 4;
                        continue;
                    }
                    case 3:
                    {
                        if (!this.ChoiceAnwser[i])
                        {
                            goto Label_0175;
                        }
                        this.labelChoice4_1.Text = "4";
                        this.totalScore += 4;
                        continue;
                    }
                    case 4:
                    {
                        if (!this.ChoiceAnwser[i])
                        {
                            goto Label_01CC;
                        }
                        this.labelChoice5_1.Text = "4";
                        this.totalScore += 4;
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                this.labelChoice1_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_00C1:
                this.labelChoice2_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_011B:
                this.labelChoice3_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0175:
                this.labelChoice4_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_01CC:
                this.labelChoice5_1.Text = "0";
                this.totalScore = this.totalScore;
            }
        }

        private void closeChengxuTime_Tick(object sender, EventArgs e)
        {
            this.number++;
            if (this.number == 300)
            {
                base.Dispose();
                Application.Exit();
            }
        }

        private void closeFullWindow(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            this.flowLayoutPanel1.Width = SystemInformation.VirtualScreen.Width;
            this.flowLayoutPanel1.Height = SystemInformation.VirtualScreen.Height - 170;
            base.TopMost = false;
            base.FormBorderStyle = FormBorderStyle.Sizable;
            base.WindowState = FormWindowState.Maximized;
            button.Enabled = false;
            this.disable(this.flowLayoutPanel1);
            this.timersTimer.Enabled = false;
        }

        private void disable(Control flowLayoutPanel11)
        {
            if (flowLayoutPanel11.HasChildren)
            {
                foreach (Control control in flowLayoutPanel11.Controls)
                {
                    if ((control is NuGenEQML) || (control is RadioButton))
                    {
                        control.Enabled = false;
                    }
                    if (control is TextBox)
                    {
                        TextBox box = (TextBox) control;
                        box.ReadOnly = true;
                        box.BackColor = Color.White;
                    }
                    if (control.HasChildren)
                    {
                        this.disable(control);
                    }
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1 = new Panel();
            this.panel1.AutoScroll = true;
            this.panel1.Height = 100;
            this.panel1.Width = SystemInformation.VirtualScreen.Width;
            this.panel1.Location = new Point(0, 0);
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            TableLayoutPanel panel = new TableLayoutPanel {
                RowCount = 2,
                Anchor = AnchorStyles.None,
                ColumnCount = 15,
                Height = 100,
                Width = SystemInformation.VirtualScreen.Width,
                AutoScroll = true
            };
            this.initLabel(this.label_class);
            this.initLabel(this.label_name);
            this.initLabel(this.label_code);
            this.initLabel(this.label_grade);
            this.initBigLabel(this.label_title);
            this.initPanelTextBox(this.textbox_class);
            this.initPanelTextBox(this.textbox_name);
            this.initPanelTextBox(this.textbox_grade);
            this.initPanelTextBox(this.textbox_code);
            this.label_class.Text = "班级";
            this.label_title.Text = "线性代数课程考试系统";
            this.label_title.Font = new Font("宋体", 30f, FontStyle.Underline);
            panel.SetColumnSpan(this.label_title, 15);
            panel.Controls.Add(this.label_class, 0, 1);
            panel.Controls.Add(this.textbox_class, 1, 1);
            panel.Controls.Add(this.label_title);
            this.textbox_class.Text = StudentModel.studentClass;
            this.textbox_code.Text = StudentModel.studentNumber;
            this.textbox_name.Text = StudentModel.studentName;
            this.btn_Generate_Test = new Button();
            this.btn_Generate_Test.Text = "生成试卷";
            this.initButton(this.btn_Generate_Test);
            this.btn_Generate_Test.Click += new EventHandler(this.GenerateTest_Click);
            this.btn_Submit = new Button();
            this.btn_Submit.Click += new EventHandler(this.closeFullWindow);
            this.btn_Submit.Click += new EventHandler(this.ChoiceAnswerJudge);
            this.btn_Submit.Click += new EventHandler(this.GapfillingAnswerJudge);
            this.btn_Submit.Click += new EventHandler(this.CalculationAnswerJudge);
            this.btn_Submit.Click += new EventHandler(this.ChoiceScoreShow);
            this.btn_Submit.Click += new EventHandler(this.GapfillingScoreShow);
            this.btn_Submit.Click += new EventHandler(this.CalculationScoreShow);
            this.btn_Submit.Click += new EventHandler(this.ChoiceSave);
            this.btn_Submit.Click += new EventHandler(this.GapfillingSave);
            this.btn_Submit.Click += new EventHandler(this.CalculationSave);
            this.btn_Submit.Click += new EventHandler(this.AnswerUpload);
            this.btn_isSubmit.Text = "提交试卷";
            this.btn_isSubmit.Click += new EventHandler(this.btn_isSubmit_Click);
            this.initButton(this.btn_Submit);
            this.initButton(this.btn_isSubmit);
            this.initLabel(this.label_time);
            this.label_time.Width = Screen.PrimaryScreen.Bounds.Width;
            this.label_time.BackColor = Color.Red;
            this.show_time.Tick += new EventHandler(this.show_time_Tick);
            this.btn_help = new Button();
            this.btn_help.Text = "帮助";
            this.initButton(this.btn_help);
            this.btn_help.Click += new EventHandler(this.btn_help_Click);
            this.btn_sqrt = new Button();
            this.btn_sqrt.Name = "button1";
            this.initButton(this.btn_sqrt);
            this.btn_sqrt.TabIndex = 1;
            this.btn_sqrt.Text = "录入根号";
            this.btn_sqrt.Click += new EventHandler(this.button1_Click);
            this.label_grade.Text = "成绩";
            this.label_code.Text = "学号";
            panel.Controls.Add(this.label_code, 2, 1);
            panel.Controls.Add(this.textbox_code, 3, 1);
            this.label_name.Text = "姓名";
            panel.Controls.Add(this.label_name, 4, 1);
            panel.Controls.Add(this.textbox_name, 5, 1);
            this.panel1.Controls.Add(panel);
            panel.Controls.Add(this.btn_Generate_Test, 6, 1);
            panel.Controls.Add(this.btn_isSubmit, 14, 1);
            panel.Controls.Add(this.label_grade, 8, 1);
            panel.Controls.Add(this.textbox_grade, 9, 1);
            panel.Controls.Add(this.btn_help, 10, 1);
            panel.Controls.Add(this.btn_sqrt, 11, 1);
            panel.SetColumnSpan(this.label_time, 1);
            panel.Controls.Add(this.label_time, 7, 1);
            base.Controls.Add(this.panel1);
            this.timersTimer = new System.Timers.Timer();
            this.timersTimer.Enabled = false;
            this.timersTimer.Interval = 300000.0;
            this.timersTimer.Elapsed += new ElapsedEventHandler(this.timersTimer_Elapsed);
            this.timersTimer.SynchronizingObject = null;
        }

        private void GapfillingAnswerJudge(object sender, EventArgs e)
        {
            this.gapfillingAnswerResults = new Dictionary<string, bool>();
            foreach (string str in this.gapfillingString)
            {
                switch (str)
                {
                    case "g_one_1.xml":
                        this.gapfillingAnswerResults["g_one_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_one_1(this.textBoxG1_1_1.Text.Trim());
                        break;

                    case "g_one_2.xml":
                        this.gapfillingAnswerResults["g_one_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_one_2(this.textBoxG1_2_1.Text.Trim());
                        break;

                    case "g_two_1.xml":
                    {
                        List<string> list = new List<string> {
                            this.textBoxGT2_1_1.Text.Trim(),
                            this.textBoxGT2_1_2.Text.Trim(),
                            this.textBoxGT2_1_3.Text.Trim(),
                            this.textBoxGT2_1_4.Text.Trim(),
                            this.textBoxGT2_1_5.Text.Trim(),
                            this.textBoxGT2_1_6.Text.Trim(),
                            this.textBoxGT2_1_7.Text.Trim(),
                            this.textBoxGT2_1_8.Text.Trim(),
                            this.textBoxGT2_1_9.Text.Trim(),
                            this.textBoxGT2_1_10.Text.Trim(),
                            this.textBoxGT2_1_11.Text.Trim(),
                            this.textBoxGT2_1_12.Text.Trim(),
                            this.textBoxGT2_1_13.Text.Trim(),
                            this.textBoxGT2_1_14.Text.Trim(),
                            this.textBoxGT2_1_15.Text.Trim(),
                            this.textBoxGT2_1_16.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_1(list);
                        break;
                    }
                    case "g_two_2_1.xml":
                    {
                        List<string> list2 = new List<string> {
                            this.textBoxG2_2_1_1.Text.Trim(),
                            this.textBoxG2_2_1_2.Text.Trim(),
                            this.textBoxG2_2_1_3.Text.Trim(),
                            this.textBoxG2_2_1_4.Text.Trim(),
                            this.textBoxG2_2_1_5.Text.Trim(),
                            this.textBoxG2_2_1_6.Text.Trim(),
                            this.textBoxG2_2_1_7.Text.Trim(),
                            this.textBoxG2_2_1_8.Text.Trim(),
                            this.textBoxG2_2_1_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_1(list2);
                        break;
                    }
                    case "g_two_2_2.xml":
                    {
                        List<string> list3 = new List<string> {
                            this.textBoxG2_2_2_1.Text.Trim(),
                            this.textBoxG2_2_2_2.Text.Trim(),
                            this.textBoxG2_2_2_3.Text.Trim(),
                            this.textBoxG2_2_2_4.Text.Trim(),
                            this.textBoxG2_2_2_5.Text.Trim(),
                            this.textBoxG2_2_2_6.Text.Trim(),
                            this.textBoxG2_2_2_7.Text.Trim(),
                            this.textBoxG2_2_2_8.Text.Trim(),
                            this.textBoxG2_2_2_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_2(list3);
                        break;
                    }
                    case "g_two_2_3.xml":
                    {
                        List<string> list4 = new List<string> {
                            this.textBoxG2_2_3_1.Text.Trim(),
                            this.textBoxG2_2_3_2.Text.Trim(),
                            this.textBoxG2_2_3_3.Text.Trim(),
                            this.textBoxG2_2_3_4.Text.Trim(),
                            this.textBoxG2_2_3_5.Text.Trim(),
                            this.textBoxG2_2_3_6.Text.Trim(),
                            this.textBoxG2_2_3_7.Text.Trim(),
                            this.textBoxG2_2_3_8.Text.Trim(),
                            this.textBoxG2_2_3_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_3.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_3(list4);
                        break;
                    }
                    case "g_two_2_4.xml":
                    {
                        List<string> list5 = new List<string> {
                            this.textBoxG2_2_4_1.Text.Trim(),
                            this.textBoxG2_2_4_2.Text.Trim(),
                            this.textBoxG2_2_4_3.Text.Trim(),
                            this.textBoxG2_2_4_4.Text.Trim(),
                            this.textBoxG2_2_4_5.Text.Trim(),
                            this.textBoxG2_2_4_6.Text.Trim(),
                            this.textBoxG2_2_4_7.Text.Trim(),
                            this.textBoxG2_2_4_8.Text.Trim(),
                            this.textBoxG2_2_4_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_4.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_4(list5);
                        break;
                    }
                    case "g_two_2_5.xml":
                    {
                        List<string> list6 = new List<string> {
                            this.textBoxG2_2_5_1.Text.Trim(),
                            this.textBoxG2_2_5_2.Text.Trim(),
                            this.textBoxG2_2_5_3.Text.Trim(),
                            this.textBoxG2_2_5_4.Text.Trim(),
                            this.textBoxG2_2_5_5.Text.Trim(),
                            this.textBoxG2_2_5_6.Text.Trim(),
                            this.textBoxG2_2_5_7.Text.Trim(),
                            this.textBoxG2_2_5_8.Text.Trim(),
                            this.textBoxG2_2_5_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_5.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_5(list6);
                        break;
                    }
                    case "g_two_2_6.xml":
                    {
                        List<string> list7 = new List<string> {
                            this.textBoxG2_2_6_1.Text.Trim(),
                            this.textBoxG2_2_6_2.Text.Trim(),
                            this.textBoxG2_2_6_3.Text.Trim(),
                            this.textBoxG2_2_6_4.Text.Trim(),
                            this.textBoxG2_2_6_5.Text.Trim(),
                            this.textBoxG2_2_6_6.Text.Trim(),
                            this.textBoxG2_2_6_7.Text.Trim(),
                            this.textBoxG2_2_6_8.Text.Trim(),
                            this.textBoxG2_2_6_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_two_2_6.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_two_2_6(list7);
                        break;
                    }
                    case "g_three_1.xml":
                        this.gapfillingAnswerResults["g_three_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_three_1(this.textBoxG3_1_1.Text.Trim());
                        break;

                    case "g_three_2.xml":
                        this.gapfillingAnswerResults["g_three_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_three_2(this.textBoxG3_2_1.Text.Trim());
                        break;

                    case "g_four_1.xml":
                        this.gapfillingAnswerResults["g_four_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_four_1(this.textBoxG4_1_1.Text.Trim());
                        break;

                    case "g_four_2.xml":
                    {
                        List<string> list8 = new List<string> {
                            this.controlGT4_2_1_1.pub_GetXML(false).Trim(),
                            this.controlGT4_2_1_2.pub_GetXML(false).Trim(),
                            this.controlGT4_2_1_3.pub_GetXML(false).Trim(),
                            this.controlGT4_2_1_4.pub_GetXML(false).Trim()
                        };
                        List<string> list9 = new List<string> {
                            this.controlGT4_2_2_1.pub_GetXML(false).Trim(),
                            this.controlGT4_2_2_2.pub_GetXML(false).Trim(),
                            this.controlGT4_2_2_3.pub_GetXML(false).Trim(),
                            this.controlGT4_2_2_4.pub_GetXML(false).Trim()
                        };
                        List<string> list10 = new List<string> {
                            this.controlGT4_2_3_1.pub_GetXML(false).Trim(),
                            this.controlGT4_2_3_2.pub_GetXML(false).Trim(),
                            this.controlGT4_2_3_3.pub_GetXML(false).Trim(),
                            this.controlGT4_2_3_4.pub_GetXML(false).Trim()
                        };
                        this.gapfillingAnswerResults["g_four_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_four_2(list8, list9, list10);
                        break;
                    }
                    case "g_five_1.xml":
                        this.gapfillingAnswerResults["g_five_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_five_1(this.textBoxG5_1_1.Text.Trim());
                        break;

                    case "g_six_1.xml":
                        this.gapfillingAnswerResults["g_six_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_six_1(this.textBoxG6_1_1.Text.Trim());
                        break;

                    case "g_seven_1_1.xml":
                    {
                        List<string> list11 = new List<string> {
                            this.textBoxG7_1_1_1.Text.Trim(),
                            this.textBoxG7_1_1_2.Text.Trim(),
                            this.textBoxG7_1_1_3.Text.Trim(),
                            this.textBoxG7_1_1_4.Text.Trim(),
                            this.textBoxG7_1_1_5.Text.Trim(),
                            this.textBoxG7_1_1_6.Text.Trim(),
                            this.textBoxG7_1_1_7.Text.Trim(),
                            this.textBoxG7_1_1_8.Text.Trim(),
                            this.textBoxG7_1_1_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_seven_1_1.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_seven_1_1(list11);
                        break;
                    }
                    case "g_seven_1_2.xml":
                    {
                        List<string> list12 = new List<string> {
                            this.textBoxG7_1_2_1.Text.Trim(),
                            this.textBoxG7_1_2_2.Text.Trim(),
                            this.textBoxG7_1_2_3.Text.Trim(),
                            this.textBoxG7_1_2_4.Text.Trim(),
                            this.textBoxG7_1_2_5.Text.Trim(),
                            this.textBoxG7_1_2_6.Text.Trim(),
                            this.textBoxG7_1_2_7.Text.Trim(),
                            this.textBoxG7_1_2_8.Text.Trim(),
                            this.textBoxG7_1_2_9.Text.Trim(),
                            this.textBoxG7_1_2_10.Text.Trim(),
                            this.textBoxG7_1_2_11.Text.Trim(),
                            this.textBoxG7_1_2_12.Text.Trim(),
                            this.textBoxG7_1_2_13.Text.Trim(),
                            this.textBoxG7_1_2_14.Text.Trim(),
                            this.textBoxG7_1_2_15.Text.Trim(),
                            this.textBoxG7_1_2_16.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_seven_1_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_seven_1_2(list12);
                        break;
                    }
                    case "g_seven_1_3.xml":
                    {
                        List<string> list13 = new List<string> {
                            this.textBoxG7_1_3_1.Text.Trim(),
                            this.textBoxG7_1_3_2.Text.Trim(),
                            this.textBoxG7_1_3_3.Text.Trim(),
                            this.textBoxG7_1_3_4.Text.Trim(),
                            this.textBoxG7_1_3_5.Text.Trim(),
                            this.textBoxG7_1_3_6.Text.Trim(),
                            this.textBoxG7_1_3_7.Text.Trim(),
                            this.textBoxG7_1_3_8.Text.Trim(),
                            this.textBoxG7_1_3_9.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_seven_1_3.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_seven_1_3(list13);
                        break;
                    }
                    case "g_seven_2.xml":
                    {
                        List<string> list14 = new List<string> {
                            this.textBoxG7_2_1.Text.Trim(),
                            this.textBoxG7_2_2.Text.Trim(),
                            this.textBoxG7_2_3.Text.Trim()
                        };
                        this.gapfillingAnswerResults["g_seven_2.xml"] = GapfillingAnswerJudgeTools.AnswerJudge_g_seven_2(list14);
                        break;
                    }
                }
            }
        }

        private void GapfillingSave(object sender, EventArgs e)
        {
            FileStream w = new FileStream("temp/UA/gapfillingAnswer.xml", FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(w, Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            int num = 0;
            writer.WriteStartDocument();
            writer.WriteStartElement("gapfillingAnswer");
            writer.WriteAttributeString("guid", this.guid);
            foreach (string str in this.gapfillingString)
            {
                switch (str)
                {
                    case "g_one_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_one_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG1_1_1.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_one_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_one_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG1_2_1.Text);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxGT2_1_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxGT2_1_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxGT2_1_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxGT2_1_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxGT2_1_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxGT2_1_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxGT2_1_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxGT2_1_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxGT2_1_9.Text.ToString());
                        writer.WriteElementString("b32", this.textBoxGT2_1_10.Text.ToString());
                        writer.WriteElementString("b33", this.textBoxGT2_1_11.Text.ToString());
                        writer.WriteElementString("b34", this.textBoxGT2_1_12.Text.ToString());
                        writer.WriteElementString("b41", this.textBoxGT2_1_13.Text.ToString());
                        writer.WriteElementString("b42", this.textBoxGT2_1_14.Text.ToString());
                        writer.WriteElementString("b43", this.textBoxGT2_1_15.Text.ToString());
                        writer.WriteElementString("b44", this.textBoxGT2_1_16.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_1_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_1_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_1_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_1_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_1_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_1_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_1_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_1_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_1_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_2_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_2_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_2_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_2_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_2_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_2_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_2_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_2_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_2_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_3.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_3.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_3_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_3_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_3_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_3_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_3_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_3_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_3_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_3_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_3_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_4.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_4.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_4_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_4_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_4_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_4_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_4_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_4_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_4_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_4_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_4_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_5.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_5.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_5_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_5_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_5_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_5_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_5_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_5_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_5_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_5_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_5_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_two_2_6.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_two_2_6.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG2_2_6_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG2_2_6_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG2_2_6_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG2_2_6_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG2_2_6_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG2_2_6_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG2_2_6_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG2_2_6_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG2_2_6_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_three_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_three_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG3_1_1.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_three_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_three_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG3_2_1.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_four_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_four_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG4_1_1.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_four_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_four_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteStartElement("a11");
                        writer.WriteCData(this.controlGT4_2_1_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a12");
                        writer.WriteCData(this.controlGT4_2_1_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a13");
                        writer.WriteCData(this.controlGT4_2_1_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a14");
                        writer.WriteCData(this.controlGT4_2_1_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a21");
                        writer.WriteCData(this.controlGT4_2_2_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a22");
                        writer.WriteCData(this.controlGT4_2_2_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a23");
                        writer.WriteCData(this.controlGT4_2_2_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a24");
                        writer.WriteCData(this.controlGT4_2_2_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a31");
                        writer.WriteCData(this.controlGT4_2_3_1.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a32");
                        writer.WriteCData(this.controlGT4_2_3_2.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a33");
                        writer.WriteCData(this.controlGT4_2_3_3.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("a34");
                        writer.WriteCData(this.controlGT4_2_3_4.pub_GetXML(false).ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_five_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_five_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG5_1_1.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_six_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_six_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("D", this.textBoxG6_1_1.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_seven_1_1.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_seven_1_1.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG7_1_1_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG7_1_1_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG7_1_1_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG7_1_1_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG7_1_1_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG7_1_1_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG7_1_1_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG7_1_1_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG7_1_1_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_seven_1_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_seven_1_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG7_1_2_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG7_1_2_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG7_1_2_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG7_1_2_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG7_1_2_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG7_1_2_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG7_1_2_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG7_1_2_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG7_1_2_9.Text.ToString());
                        writer.WriteElementString("b32", this.textBoxG7_1_2_10.Text.ToString());
                        writer.WriteElementString("b33", this.textBoxG7_1_2_11.Text.ToString());
                        writer.WriteElementString("b34", this.textBoxG7_1_2_12.Text.ToString());
                        writer.WriteElementString("b41", this.textBoxG7_1_2_13.Text.ToString());
                        writer.WriteElementString("b42", this.textBoxG7_1_2_14.Text.ToString());
                        writer.WriteElementString("b43", this.textBoxG7_1_2_15.Text.ToString());
                        writer.WriteElementString("b44", this.textBoxG7_1_2_16.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_seven_1_3.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_seven_1_3.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG7_1_3_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG7_1_3_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG7_1_3_3.Text.ToString());
                        writer.WriteElementString("b14", this.textBoxG7_1_3_4.Text.ToString());
                        writer.WriteElementString("b21", this.textBoxG7_1_3_5.Text.ToString());
                        writer.WriteElementString("b22", this.textBoxG7_1_3_6.Text.ToString());
                        writer.WriteElementString("b23", this.textBoxG7_1_3_7.Text.ToString());
                        writer.WriteElementString("b24", this.textBoxG7_1_3_8.Text.ToString());
                        writer.WriteElementString("b31", this.textBoxG7_1_3_9.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;

                    case "g_seven_2.xml":
                        num++;
                        writer.WriteStartElement("qid");
                        writer.WriteAttributeString("id", num.ToString());
                        writer.WriteAttributeString("name", "g_seven_2.xml");
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("b11", this.textBoxG7_2_1.Text.ToString());
                        writer.WriteElementString("b12", this.textBoxG7_2_2.Text.ToString());
                        writer.WriteElementString("b13", this.textBoxG7_2_3.Text.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        break;
                }
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        private void GapfillingScoreShow(object sender, EventArgs e)
        {
            foreach (string str in this.gapfillingString)
            {
                switch (str)
                {
                    case "g_one_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_one_1.xml"])
                        {
                            break;
                        }
                        this.labelG1_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_one_2.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_one_2.xml"])
                        {
                            goto Label_0234;
                        }
                        this.labelG1_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_1.xml"])
                        {
                            goto Label_0294;
                        }
                        this.labelG2_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_1.xml"])
                        {
                            goto Label_02F4;
                        }
                        this.labelG2_2_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_2.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_2.xml"])
                        {
                            goto Label_0354;
                        }
                        this.labelG2_2_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_3.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_3.xml"])
                        {
                            goto Label_03B4;
                        }
                        this.labelG2_2_3.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_4.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_4.xml"])
                        {
                            goto Label_0414;
                        }
                        this.labelG2_2_4.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_5.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_5.xml"])
                        {
                            goto Label_0474;
                        }
                        this.labelG2_2_5.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_two_2_6.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_two_2_6.xml"])
                        {
                            goto Label_04D4;
                        }
                        this.labelG2_2_6.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_three_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_three_1.xml"])
                        {
                            goto Label_0534;
                        }
                        this.labelG3_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_three_2.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_three_2.xml"])
                        {
                            goto Label_0594;
                        }
                        this.labelG3_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_four_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_four_1.xml"])
                        {
                            goto Label_05F4;
                        }
                        this.labelG4_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_four_2.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_four_2.xml"])
                        {
                            goto Label_0654;
                        }
                        this.labelG4_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_five_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_five_1.xml"])
                        {
                            goto Label_06B4;
                        }
                        this.labelG5_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_six_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_six_1.xml"])
                        {
                            goto Label_0714;
                        }
                        this.labelG6_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_seven_1_1.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_seven_1_1.xml"])
                        {
                            goto Label_0774;
                        }
                        this.labelG7_1_1.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_seven_1_2.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_seven_1_2.xml"])
                        {
                            goto Label_07D4;
                        }
                        this.labelG7_1_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_seven_1_3.xml":
                    {
                        if (!this.gapfillingAnswerResults["g_seven_1_3.xml"])
                        {
                            goto Label_0834;
                        }
                        this.labelG7_1_3.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    case "g_seven_2.xml":
                    {
                        List<string> list = new List<string>();
                        if (!this.gapfillingAnswerResults["g_seven_2.xml"])
                        {
                            goto Label_0897;
                        }
                        this.labelG7_2.Text = "5";
                        this.totalScore += 5;
                        continue;
                    }
                    default:
                    {
                        continue;
                    }
                }
                this.labelG1_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0234:
                this.labelG1_2.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0294:
                this.labelG2_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_02F4:
                this.labelG2_2_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0354:
                this.labelG2_2_2.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_03B4:
                this.labelG2_2_3.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0414:
                this.labelG2_2_4.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0474:
                this.labelG2_2_5.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_04D4:
                this.labelG2_2_6.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0534:
                this.labelG3_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0594:
                this.labelG3_2.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_05F4:
                this.labelG4_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0654:
                this.labelG4_2.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_06B4:
                this.labelG5_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0714:
                this.labelG6_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0774:
                this.labelG7_1_1.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_07D4:
                this.labelG7_1_2.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0834:
                this.labelG7_1_3.Text = "0";
                this.totalScore = this.totalScore;
                continue;
            Label_0897:
                this.labelG7_2.Text = "0";
                this.totalScore = this.totalScore;
            }
        }
        
        private void GenerateTest_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag;
                StudentService service = new StudentService();
                if (StudentModel.isReGeneration)
                {
                    StudentModel.isReGeneration = false;
                    StudentModel.status = 1;
                    //this.UploadParameter(null, null);
                    flag = true;//service.updateStudent(StudentModel.studentNumber, new GetMacAddress().getmac(), StudentModel.isReGeneration, StudentModel.status, "~!{#$@cdf3}");
                }
                else
                {
                    StudentModel.status = 1;
                    flag = true;//service.updateStudent_mac(StudentModel.studentNumber, new GetMacAddress().getmac(), StudentModel.status, "~!{#$@cdf3}");
                }
                if (!flag)
                {
                    MessageBox.Show("生成试卷失败,网络有问题。");
                    //Application.Exit();
                }
                Button button = (Button)sender;
                button.Enabled = false;
                //this.flowLayoutPanel1.Visible = true;
                this.flowLayoutPanel1.Show();
                this.flowLayoutPanel1.ScrollControlIntoView(this.label_Choice);
                this.show_time.Interval = 0x3e8;
                this.show_time.Start();
                this.btn_Generate_Test.Enabled = false;
                this.btn_Generate_Test.Enabled = true;
                this.intervalTimer = new System.Windows.Forms.Timer();
                this.intervalTimer.Interval = 0xea60;
                this.intervalTimer.Tag = "off";
                this.intervalTimer.Tick += new EventHandler(this.intervalTimer_Tick);
            }
            catch (Exception) { }
        }

        private void initBigLabel(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font("宋体", 40f);
            label.Anchor = AnchorStyles.None;
            label.ForeColor = Color.Blue;
        }

        private void initButton(Button button)
        {
            button.AutoSize = true;
            button.Font = new Font("宋体", 14f);
            button.Anchor = AnchorStyles.None;
        }

        private void initComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("不填");
            comboBox.Items.Add("=");
            comboBox.Items.Add("≠");
            comboBox.Items.Add("<");
            comboBox.Items.Add(">");
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Size = new Size(50, 30);
            comboBox.Anchor = AnchorStyles.None;
        }

        private void initControls(NuGenEQML mathMLControl)
        {
            mathMLControl.AutoCloseBrackets = true;
            mathMLControl.BackColor = Color.White;
            mathMLControl.Size = new Size(120, 0x20);
            mathMLControl.Enabled = true;
            mathMLControl.Event_OnGotFocus += new EventHandler(this.mathMLControl_Event_OnSelectionChanged);
            mathMLControl.Anchor = AnchorStyles.None;
            mathMLControl.BorderStyle = BorderStyle.FixedSingle;
        }

        private void initControls(List<NuGenEQML> listGT2)
        {
            foreach (NuGenEQML neqml in listGT2)
            {
                neqml.AutoCloseBrackets = true;
                neqml.BackColor = Color.White;
                neqml.Size = new Size(120, 0x20);
                neqml.Enabled = true;
                neqml.BorderStyle = BorderStyle.FixedSingle;
                neqml.Event_OnGotFocus += new EventHandler(this.mathMLControl_Event_OnSelectionChanged);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Name = "Form1";
            this.Text = "东北大学线性代数考试系统";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartupInterface_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void initLabel(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font("宋体", 14f);
            label.Anchor = AnchorStyles.None;
        }

        private void initMyComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add("不填");
            comboBox.Items.Add("且");
            comboBox.Items.Add("或");
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Size = new Size(50, 30);
            comboBox.SelectedIndex = 0;
            comboBox.Anchor = AnchorStyles.None;
        }

        private void initPanelTextBox(TextBox textBox)
        {
            textBox.Width = 100;
            textBox.Height = 60;
            textBox.Font = new Font("宋体", 12f, FontStyle.Bold);
            textBox.ForeColor = Color.Blue;
            textBox.Anchor = AnchorStyles.None;
            textBox.ReadOnly = true;
            textBox.BackColor = Color.White;
        }

        private void initPictureBox(PictureBox pictureBox)
        {
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void initScoreLabel(Label label)
        {
            label.AutoSize = true;
            label.ForeColor = Color.Red;
            label.Font = new Font("宋体", 14f);
            label.Anchor = AnchorStyles.None;
        }

        private void initsmallControl(NuGenEQML control)
        {
            control.Size = new Size(50, 30);
            control.Enabled = false;
            control.Font = new Font("宋体", 14f);
            control.Anchor = AnchorStyles.None;
        }

        public void initTextBox(List<TextBox> lists)
        {
            foreach (TextBox box in lists)
            {
                box.Height = 80;
                box.Width = 60;
                box.Font = new Font("宋体", 12f);
                box.Anchor = AnchorStyles.None;
            }
        }

        private void initTextBox(TextBox textBox)
        {
            textBox.Width = 80;
            textBox.Height = 60;
            textBox.Font = new Font("宋体", 12f);
            textBox.Anchor = AnchorStyles.None;
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            //this.AnswerUpload();
            this.intervalTimer.Tag = "off";
            this.intervalTimer.Stop();
        }

        private void mathMLControl_Event_OnSelectionChanged(object sender, EventArgs e)
        {
            NuGenEQML neqml = (NuGenEQML) sender;
            this.controlFlag = neqml;
        }

        private void show_time_Tick(object sender, EventArgs e)
        {
            this.span = this.span.Subtract(this.oneSpan);
            if ((this.span.Hours == 0) && (this.span.Minutes <= 0))
            {
                this.label_time.Text = "正在准备提交试卷！";
                this.randmomSubmitTime--;
            }
            else
            {
                this.label_time.Text = "离考试结束还有" + this.span.Hours.ToString() + "小时" + this.span.Minutes.ToString() + "分钟";
            }
            if (((this.span.Hours == 0) && (this.span.Minutes <= 0)) && (this.randmomSubmitTime <= 0))
            {
                this.ChoiceAnswerJudge(null, null);
                this.GapfillingAnswerJudge(null, null);
                this.CalculationAnswerJudge(null, null);
                this.ChoiceScoreShow(null, null);
                this.GapfillingScoreShow(null, null);
                this.CalculationScoreShow(null, null);
                this.ChoiceSave(null, null);
                this.GapfillingSave(null, null);
                this.CalculationSave(null, null);
                this.show_time.Stop();
                //this.AnswerUpload(null, null);
                this.btn_Submit.Enabled = false;
                this.label_time.Text = "试卷已成功提交！";
                this.flowLayoutPanel1.Width = SystemInformation.VirtualScreen.Width;
                this.flowLayoutPanel1.Height = SystemInformation.VirtualScreen.Height - 170;
                base.TopMost = false;
                base.FormBorderStyle = FormBorderStyle.Sizable;
                base.WindowState = FormWindowState.Maximized;
            }
            if (this.span.Seconds == uploadSeconds)
            {
                this.timersTimer.Enabled = true;
            }
        }

        private void StartupInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            SupportTools.DeleteFile(currentDirectory + "/temp");
            SupportTools.DeleteFile(currentDirectory + "/upload");
            base.Dispose();
            Application.Exit();
        }

        private void timersTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //SetTextCallback method = new SetTextCallback(this.AnswerUpload);
            //base.Invoke(method, null);
        }

        private void UploadParameter(object sender, EventArgs e)
        {
            try
            {
                //FileService service = new FileService();
                string str = StudentModel.examCode + @"\" + StudentModel.studentNumber;
                //service.studentFileDelete(str + @"\Answer.zip", "~!{#$@cdf3}");
                //service.studentFileDelete(str + @"\Parameter.zip", "~!{#$@cdf3}");
                string dirPath = "./temp/generate";
                string uriPath = string.Concat(new object[] { StudentModel.examCode, "/", StudentModel.studentNumber, "/Parameter.zip" });
                string filepath = "./upload/Parameter.zip";
                SupportTools.FilePathIsExist(filepath);
                Zip.CompressDirectory(dirPath, filepath, 9, 0x400);
                if (this.mark == 0)
                {
                    UploadAndDownload.MakeDir(StudentModel.examCode.ToString());
                    UploadAndDownload.MakeDir(StudentModel.examCode + "/" + StudentModel.studentNumber);
                    this.mark++;
                }
                //UploadAndDownload.Upload(uriPath, filepath);
            }
            catch (Exception)
            {
                MessageBox.Show("上传试题参数失败，无法确保试卷还原，\r\n请联系监考老师换机考试");
            }
        }

        private delegate void SetTextCallback();
    }
}

