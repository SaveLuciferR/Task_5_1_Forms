using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double res(double x)
		{
			if (x <= 0.5) throw new Exception();
			else return x / (Math.Sqrt(2 * x - 1));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = Convert.ToDouble(textBox1.Text);
				double b = Convert.ToDouble(textBox2.Text);
				double h = Convert.ToDouble(textBox3.Text);

				textBox4.Text = "";

				for (double i = a; i <= b; i += h)
				{
					try
					{
						textBox4.Text += String.Format("f({0}) = {1:f4}\r\n", i, res(i));
					}
					catch
					{
						textBox4.Text += string.Format("f({0}) = error\r\n", i);
					}
				}
			}
			catch (FormatException)
			{
				textBox4.Text = "Введеные некорректные данные";
			}
			catch
			{
				textBox4.Text = "Неизвестная ошибка";
			}
		}
	}
}
