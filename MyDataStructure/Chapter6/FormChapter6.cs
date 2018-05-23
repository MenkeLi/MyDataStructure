using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataStructure.Chapter6
{
    public partial class FormChapter6 : Form
    {
        public FormChapter6()
        {
            
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Calculate(MoveDirection.Left);
        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            Calculate(MoveDirection.Right);
        }

        private void Calculate(MoveDirection moveDirection)
        {
            int input = Int32.Parse(textBoxInt.Text);
            int moveNumber = Int32.Parse(textBoxMove.Text);

            labelInt.Text = CalculateBinary(input).ToString();
            if (moveDirection == MoveDirection.Left)
            {
                labelResult.Text = CalculateBinary(input << moveNumber).ToString();
            }
            else
            {
                labelResult.Text = CalculateBinary(input >> moveNumber).ToString();
            }
        }

        private StringBuilder CalculateBinary(int dec)
        {
            int calMask = 1 << 31;
            StringBuilder stringBuilder = new StringBuilder(35);
            for (int i = 0; i < 32; i++)
            {
                if ((dec & calMask) != 0)
                {
                    stringBuilder.Append('1');
                }
                else
                {
                    stringBuilder.Append('0');
                }

                if ((i + 1) % 8 == 0)
                {
                    stringBuilder.Append(' ');
                }

                dec <<= 1;
            }
            return stringBuilder;
        }
    }

    public enum MoveDirection
    {
        Left,
        Right
    }
}
