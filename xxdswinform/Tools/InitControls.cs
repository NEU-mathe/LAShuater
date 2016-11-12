namespace xxdswinform.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Genetibase.MathX;

    public class InitControls
    {
        public void calculationOneOfTwo(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 2, 0);
            tableLayoutPanel.Controls.Add(list[3], 3, 0);
            tableLayoutPanel.Controls.Add(list[4], 4, 0);
            tableLayoutPanel.Controls.Add(list[5], 0, 1);
            tableLayoutPanel.Controls.Add(list[6], 1, 1);
            tableLayoutPanel.Controls.Add(list[7], 2, 1);
            tableLayoutPanel.Controls.Add(list[8], 3, 1);
            tableLayoutPanel.Controls.Add(list[9], 4, 1);
            tableLayoutPanel.Controls.Add(list[10], 0, 2);
            tableLayoutPanel.Controls.Add(list[11], 1, 2);
            tableLayoutPanel.Controls.Add(list[12], 2, 2);
            tableLayoutPanel.Controls.Add(list[13], 3, 2);
            tableLayoutPanel.Controls.Add(list[14], 4, 2);
            tableLayoutPanel.Controls.Add(list[15], 0, 3);
            tableLayoutPanel.Controls.Add(list[0x10], 1, 3);
            tableLayoutPanel.Controls.Add(list[0x11], 2, 3);
            tableLayoutPanel.Controls.Add(list[0x12], 3, 3);
            tableLayoutPanel.Controls.Add(list[0x13], 4, 3);
        }

        public void calculationThree(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 1);
            tableLayoutPanel.Controls.Add(list[2], 2, 2);
        }

        public void matrixFourToFour(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 0, 2);
            tableLayoutPanel.Controls.Add(list[3], 0, 3);
            tableLayoutPanel.Controls.Add(list[4], 1, 0);
            tableLayoutPanel.Controls.Add(list[5], 1, 1);
            tableLayoutPanel.Controls.Add(list[6], 1, 2);
            tableLayoutPanel.Controls.Add(list[7], 1, 3);
            tableLayoutPanel.Controls.Add(list[8], 2, 0);
            tableLayoutPanel.Controls.Add(list[9], 2, 1);
            tableLayoutPanel.Controls.Add(list[10], 2, 2);
            tableLayoutPanel.Controls.Add(list[11], 2, 3);
            tableLayoutPanel.Controls.Add(list[12], 3, 0);
            tableLayoutPanel.Controls.Add(list[13], 3, 1);
            tableLayoutPanel.Controls.Add(list[14], 3, 2);
            tableLayoutPanel.Controls.Add(list[15], 3, 3);
        }

        public void matrixFourToFour(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 2, 0);
            tableLayoutPanel.Controls.Add(list[3], 3, 0);
            tableLayoutPanel.Controls.Add(list[4], 0, 1);
            tableLayoutPanel.Controls.Add(list[5], 1, 1);
            tableLayoutPanel.Controls.Add(list[6], 2, 1);
            tableLayoutPanel.Controls.Add(list[7], 3, 1);
            tableLayoutPanel.Controls.Add(list[8], 0, 2);
            tableLayoutPanel.Controls.Add(list[9], 1, 2);
            tableLayoutPanel.Controls.Add(list[10], 2, 2);
            tableLayoutPanel.Controls.Add(list[11], 3, 2);
            tableLayoutPanel.Controls.Add(list[12], 0, 3);
            tableLayoutPanel.Controls.Add(list[13], 1, 3);
            tableLayoutPanel.Controls.Add(list[14], 2, 3);
            tableLayoutPanel.Controls.Add(list[15], 3, 3);
        }

        public void matrixFourToOne(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 0, 2);
            tableLayoutPanel.Controls.Add(list[3], 0, 3);
        }

        public void matrixOneToThree(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 2, 0);
        }

        public void matrixOneToThree(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 2, 0);
        }

        public void matrixThreeToOne(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 0, 2);
        }

        public void matrixThreeToOneUpThree(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            Label control = new Label {
                Text = ",",
                AutoSize = true,
                Font = new Font("宋体", 18f)
            };
            Label label2 = new Label {
                Text = ",",
                AutoSize = true,
                Font = new Font("宋体", 18f)
            };
            Label label3 = new Label {
                AutoSize = true,
                Text = ".",
                Font = new Font("宋体", 18f)
            };
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 0, 2);
            tableLayoutPanel.Controls.Add(control, 1, 1);
            tableLayoutPanel.Controls.Add(list[3], 2, 0);
            tableLayoutPanel.Controls.Add(list[4], 2, 1);
            tableLayoutPanel.Controls.Add(list[5], 2, 2);
            tableLayoutPanel.Controls.Add(label2, 3, 1);
            tableLayoutPanel.Controls.Add(list[6], 4, 0);
            tableLayoutPanel.Controls.Add(list[7], 4, 1);
            tableLayoutPanel.Controls.Add(list[8], 4, 2);
            tableLayoutPanel.Controls.Add(label3, 5, 1);
        }

        public void matrixThreeToThree(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 0, 2);
            tableLayoutPanel.Controls.Add(list[3], 1, 0);
            tableLayoutPanel.Controls.Add(list[4], 1, 1);
            tableLayoutPanel.Controls.Add(list[5], 1, 2);
            tableLayoutPanel.Controls.Add(list[6], 2, 0);
            tableLayoutPanel.Controls.Add(list[7], 2, 1);
            tableLayoutPanel.Controls.Add(list[8], 2, 2);
        }

        public void matrixThreeToThree(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 2, 0);
            tableLayoutPanel.Controls.Add(list[3], 0, 1);
            tableLayoutPanel.Controls.Add(list[4], 1, 1);
            tableLayoutPanel.Controls.Add(list[5], 2, 1);
            tableLayoutPanel.Controls.Add(list[6], 0, 2);
            tableLayoutPanel.Controls.Add(list[7], 1, 2);
            tableLayoutPanel.Controls.Add(list[8], 2, 2);
        }

        public void matrixTwoToThree(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 0, 1);
            tableLayoutPanel.Controls.Add(list[3], 1, 1);
            tableLayoutPanel.Controls.Add(list[4], 0, 2);
            tableLayoutPanel.Controls.Add(list[5], 1, 2);
        }

        public void matrixTwoToThree(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 0, 1);
            tableLayoutPanel.Controls.Add(list[3], 1, 1);
            tableLayoutPanel.Controls.Add(list[4], 0, 2);
            tableLayoutPanel.Controls.Add(list[5], 1, 2);
        }

        public void matrixTwoToTwo(TableLayoutPanel tableLayoutPanel, List<NuGenEQML> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 0, 1);
            tableLayoutPanel.Controls.Add(list[2], 1, 0);
            tableLayoutPanel.Controls.Add(list[3], 1, 1);
        }

        public void matrixTwoToTwo(TableLayoutPanel tableLayoutPanel, List<TextBox> list)
        {
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.Controls.Add(list[0], 0, 0);
            tableLayoutPanel.Controls.Add(list[1], 1, 0);
            tableLayoutPanel.Controls.Add(list[2], 0, 1);
            tableLayoutPanel.Controls.Add(list[3], 1, 1);
        }
    }
}

