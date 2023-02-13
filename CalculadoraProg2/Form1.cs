using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProg2
{
	public partial class Form1 : Form
	{
		double num1 = 0;
		double num2 = 0;
		string op = "";
		public Form1()
		{
			InitializeComponent();
		}
		private double operar(string operador) {
			double res = 0;
			switch (operador)
			{
				case "+":
					res = num1 + num2;
					break;
				case "-":
					res = num1 - num2;
					break;
				case "*":
					res = num1 * num2;
					break;
				case "/":
					res = num1 / num2;
					break;

			}
			return res;
		}
		private void btn0_Click(object sender, EventArgs e)
		{
	
			if (txtResultado.Text.Equals("0"))
			{
				txtResultado.Text += ".0";
			}
			else {
				txtResultado.Text += 0;
			}
		}

		private void btn1_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 1;
		}

		private void btn2_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 2;
		}

		private void btn3_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 3;
		}

		private void btn4_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 4;
		}

		private void btn5_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 5;
		}

		private void btn6_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 6;
		}

		private void btn7_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 7;
		}

		private void btn8_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 8;
		}

		private void btn9_Click(object sender, EventArgs e)
		{

			txtResultado.Text += 9;
		}

		private void btnPoint_Click(object sender, EventArgs e)
		{
			if (txtResultado.Text.Equals(".")) {
			} else {
				txtResultado.Text += ".";
				btnPoint.Enabled = false;
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtResultado.Text);
			lblEscribir.Text = txtResultado.Text + " + ";
			txtResultado.Text = "";
			op = "+";
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			if (num2 == 0) {
				num2 = Convert.ToDouble(txtResultado.Text);
				lblEscribir.Text += num2;
				double res = operar(op);
				num1 = 0;
				num2 = 0;
				txtResultado.Text = Convert.ToString(res);
			}
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtResultado.Text);
			lblEscribir.Text = txtResultado.Text + " - ";
			txtResultado.Text = "";
			op = "-";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			num1 = 0;
			num2 = 0;
			op = "";
			txtResultado.Text = "";
			lblEscribir.Text = "";
			btnPoint.Enabled = true;
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtResultado.Text);
			lblEscribir.Text = txtResultado.Text + " x ";
			txtResultado.Text = "";
			op = "*";
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			num1 = Convert.ToDouble(txtResultado.Text);
			lblEscribir.Text = txtResultado.Text + " / ";
			txtResultado.Text = "";
			op = "/";
		}
	}
}
