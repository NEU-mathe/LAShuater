namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using xxdswinform.Utils;

    internal class ChoiceMethod
    {
        private static int flagNumber = 1;
        public static List<string> Result = new List<string>();

        public static void addChoice(TableLayoutPanel table, FlowLayoutPanel flowLayoutPanel1, List<PictureBox> list, string titleNumber, List<RadioButton> radioButton, int anwserFlag, Label labelChoice)
        {
            table.RowCount = 2;
            table.ColumnCount = 6;
            table.AutoSize = true;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            list[0].SizeMode = PictureBoxSizeMode.AutoSize;
            list[1].SizeMode = PictureBoxSizeMode.AutoSize;
            list[2].SizeMode = PictureBoxSizeMode.AutoSize;
            list[3].SizeMode = PictureBoxSizeMode.AutoSize;
            list[4].SizeMode = PictureBoxSizeMode.AutoSize;
            list[5].SizeMode = PictureBoxSizeMode.AutoSize;
            list[6].SizeMode = PictureBoxSizeMode.AutoSize;
            list[7].SizeMode = PictureBoxSizeMode.AutoSize;
            list[8].SizeMode = PictureBoxSizeMode.AutoSize;
            list[0].Anchor = AnchorStyles.None;
            list[1].Anchor = AnchorStyles.None;
            list[2].Anchor = AnchorStyles.None;
            list[3].Anchor = AnchorStyles.None;
            list[4].Anchor = AnchorStyles.None;
            list[5].Anchor = AnchorStyles.None;
            list[6].Anchor = AnchorStyles.None;
            list[7].Anchor = AnchorStyles.None;
            list[8].Anchor = AnchorStyles.None;
            radioButton[0].Anchor = AnchorStyles.None;
            radioButton[1].Anchor = AnchorStyles.None;
            radioButton[2].Anchor = AnchorStyles.None;
            radioButton[3].Anchor = AnchorStyles.None;
            radioButton[0].AutoSize = true;
            radioButton[1].AutoSize = true;
            radioButton[2].AutoSize = true;
            radioButton[3].AutoSize = true;
            labelChoice.Width = 30;
            list[0].Load("temp/" + titleNumber + ".jpg");
            flowLayoutPanel1.Controls.Add(list[0]);
            flowLayoutPanel1.SetFlowBreak(list[0], true);
            flowLayoutPanel1.Controls.Add(labelChoice);
            List<int> chooseOneAnswer = null;
            if (flagNumber == 1)
            {
                chooseOneAnswer = ChoiceSpilt.chooseOneAnswer;
                flagNumber++;
            }
            else if (flagNumber == 2)
            {
                chooseOneAnswer = ChoiceSpilt.chooseTwoAnswer;
                flagNumber++;
            }
            else if (flagNumber == 3)
            {
                chooseOneAnswer = ChoiceSpilt.chooseThreeAnswer;
                flagNumber++;
            }
            else if (flagNumber == 4)
            {
                chooseOneAnswer = ChoiceSpilt.chooseFourAnswer;
                flagNumber++;
            }
            else if (flagNumber == 5)
            {
                chooseOneAnswer = ChoiceSpilt.chooseFiveAnswer;
                flagNumber++;
            }
            for (int i = 1; i < 5; i++)
            {
                int num2 = chooseOneAnswer[i - 1];
                switch (i)
                {
                    case 1:
                        if (num2 == anwserFlag)
                        {
                            Result.Add("a");
                        }
                        table.Controls.Add(radioButton[0], 0, 0);
                        list[1].Load("ChooseAnswerImage/a.jpg");
                        list[2].Load(string.Concat(new object[] { "temp/", titleNumber, "_", num2, ".jpg" }));
                        table.Controls.Add(list[1], 1, 0);
                        table.Controls.Add(list[2], 2, 0);
                        break;

                    case 2:
                        if (num2 == anwserFlag)
                        {
                            Result.Add("b");
                        }
                        table.Controls.Add(radioButton[1], 3, 0);
                        list[3].Load("ChooseAnswerImage/b.jpg");
                        list[4].Load(string.Concat(new object[] { "temp/", titleNumber, "_", num2, ".jpg" }));
                        table.Controls.Add(list[3], 4, 0);
                        table.Controls.Add(list[4], 5, 0);
                        break;

                    case 3:
                        if (num2 == anwserFlag)
                        {
                            Result.Add("c");
                        }
                        table.Controls.Add(radioButton[2], 0, 1);
                        list[5].Load("ChooseAnswerImage/c.jpg");
                        list[6].Load(string.Concat(new object[] { "temp/", titleNumber, "_", num2, ".jpg" }));
                        table.Controls.Add(list[5], 1, 1);
                        table.Controls.Add(list[6], 2, 1);
                        break;

                    case 4:
                        if (num2 == anwserFlag)
                        {
                            Result.Add("d");
                        }
                        table.Controls.Add(radioButton[3], 3, 1);
                        list[7].Load("ChooseAnswerImage/d.jpg");
                        list[8].Load(string.Concat(new object[] { "temp/", titleNumber, "_", num2, ".jpg" }));
                        table.Controls.Add(list[7], 4, 1);
                        table.Controls.Add(list[8], 5, 1);
                        flowLayoutPanel1.Controls.Add(table);
                        flowLayoutPanel1.SetFlowBreak(table, true);
                        break;
                }
            }
        }
    }
}

