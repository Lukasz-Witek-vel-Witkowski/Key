using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size_Number = 0;
            int size_SmallChars = 0;
            int size_BigChars = 0;
            int iter_Number = 0;
            int iter_SmallChars = 0;
            int iter_BigChars = 0;
            int size = 0;
            int value = 0;
            string data = "";
            bool active = false;
            bool loop = false;
            try
            {
                if (number.TextLength > 0)
                {
                    size_Number = int.Parse(number.Text);
                }
                if (smallChars.TextLength > 0)
                {
                    size_SmallChars = int.Parse(smallChars.Text);
                }
                if (bigChars.TextLength > 0)
                {
                    size_BigChars = int.Parse(bigChars.Text);
                }
            }
            catch (FormatException)
            {

            }
            size = size_Number + size_SmallChars+ size_BigChars;
            Random random = new Random();
            for(int i=0; i<size; i++)
            {
               
                active = false;
                loop = false;
                do
               {
                    value = random.Next(1, 3);
                       if (loop)
                       {
                           if (value == 3) value = 1;
                           value++;
                       }
                    switch (value)
                    {
                        case 1: //liczby
                            if (iter_Number < size_Number)
                            {
                                iter_Number++;
                                active = true;
                                value = random.Next(1, 9);
                                data += (char)(value + 47);
                            }
                            break;
                        case 2: //male litery
                            if (iter_SmallChars < size_SmallChars)
                            {
                                iter_SmallChars++;
                                active = true;
                                value = random.Next(1, 25);
                                data += (char)(value + 96);
                            }
                            break;
                        default:// duze litery
                            if (iter_BigChars < size_BigChars)
                            {
                                iter_BigChars++;
                                active = true;
                                value = random.Next(1, 25);
                                data += (char)(value + 64);
                            }
                            break;
                    }
                    loop = true;
                } while (!active);
                
            }
            key.Text = data;
        }
    }
}
// liczby od 48 do 57 - 9
// male litery 97 do 122 - 25
//duze liter 65 do 90 - 25