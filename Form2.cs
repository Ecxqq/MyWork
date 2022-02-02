using System;
using System.Drawing;
using System.Windows.Forms;

namespace Keyboard
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		protected override CreateParams CreateParams //задаем параметр формы чтобы она была поверх окон и не переключала на себя нажатия
		{
			get {
				CreateParams param = base.CreateParams;
				param.ExStyle |= 0x08000000;
				return param;
			}
		}
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void EnterDigit(object sender, EventArgs e)
		{
			var Dig=(sender as Button).Text;
			if (!checkBox2.Checked)
			{
				SendKeys.Send(Dig);
			}
			
		}
		void EnterText(object sender, EventArgs e)
		{
			var Symb=(sender as Button).Text;
			
			if (checkBox1.Checked || checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send(Symb);
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send(Symb.ToLower());
			}
		}
		
		void ShiftOff()
		{
			checkBox5.Checked = false;
			checkBox7.Checked = false;
		}
		
		void Button78Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F1}");
		}
		void Button79Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F2}");
		}
		void Button80Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F3}");
		}
		void Button82Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F4}");
		}
		void Button81Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F5}");
		}
		void Button83Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F6}");
		}
		void Button84Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F7}");
		}
		void Button85Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F8}");
		}
		void Button86Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F9}");
		}
		void Button87Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F10}");
		}
		void Button88Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F11}");
		}
		void Button89Click(object sender, EventArgs e)
		{
			SendKeys.Send("{F12}");
		}
		void Button73Click(object sender, EventArgs e)
		{
			SendKeys.Send("{UP}");
		}
		void Button56Click(object sender, EventArgs e)
		{
			SendKeys.Send("{DOWN}");
		}
		void Button69Click(object sender, EventArgs e)
		{
			SendKeys.Send("{RIGHT}");
		}
		void Button75Click(object sender, EventArgs e)
		{
			SendKeys.Send("{LEFT}");
		}
		void Button31Click(object sender, EventArgs e)
		{
			SendKeys.Send(" ");
		}
		void Button55Click(object sender, EventArgs e)
		{
			SendKeys.Send("~");
		}
		void Button76Click(object sender, EventArgs e)
		{
			SendKeys.Send("{ESC}");
		}
		void Button71Click(object sender, EventArgs e)
		{
			SendKeys.Send("{END}");
		}
		void Button74Click(object sender, EventArgs e)
		{
			SendKeys.Send("{HOME}");
		}
		void Button77Click(object sender, EventArgs e)
		{
			SendKeys.Send("{PRTSC}");
		}
		void Button90Click(object sender, EventArgs e)
		{
			SendKeys.Send("{SCROLLOCK}");
		}
		void Button53Click(object sender, EventArgs e)
		{
			SendKeys.Send("{BACKSPACE}");
		}
		void Button72Click(object sender, EventArgs e)
		{
			SendKeys.Send("{DEL}");
		}
		void Button92Click(object sender, EventArgs e)
		{
			SendKeys.Send("{PGUP}");
		}
		void Button91Click(object sender, EventArgs e)
		{
			SendKeys.Send("{PGDN}");
		}
		void Button70Click(object sender, EventArgs e)
		{
			SendKeys.Send("~");
		}
		
		void Button35Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("!");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("1");
			}
		}
		void Button36Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("\"");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("2");
			}
		}
		void Button37Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("№");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("3");
			}
		}
		void Button38Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("$");
				ShiftOff();
				ShiftOff();	
			}
			else
			{
				SendKeys.Send("4");
			}
		}
		void Button39Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{%}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("5");
			}
		}
		void Button40Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{^}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("6");
			}
		}
		void Button41Click(object sender, EventArgs e)
		{
			SendKeys.Send("7");
		}
		void Button42Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("*");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("8");
			}
		}
		void Button43Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{(}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("9");
			}
		}
		void Button44Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{)}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("0");
			}
		}
		void Button45Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("_");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("-");
			}
		}
		void Button46Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{+}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("=");
			}
		}
		void Button26Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{}{");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("[");
			}
		}
		void Button28Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("{}}");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("]");
			}
		}
		void Button27Click(object sender, EventArgs e)
		{
			
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send(":");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send(";");
			}
		}
		void Button29Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("@");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("'");
			}
		}
		void Button33Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("<");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send(",");
			}
		}
		void Button32Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send(">");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send(".");
			}
		}
		void Button30Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("~");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("#");
			}
		}
		void Button34Click(object sender, EventArgs e)
		{
			if (checkBox5.Checked || checkBox7.Checked)
			{
				SendKeys.Send("?");
				ShiftOff();
				ShiftOff();
			}
			else
			{
				SendKeys.Send("/");
			}
		}
		
		void Button51Click(object sender, EventArgs e)
		{
			Hide();
			MainForm button93 = new MainForm();
			button93.ShowDialog();
			Close();
		}
		void Button54Click(object sender, EventArgs e)
		{
			Hide();
			var Form3 = new Form3();
			Form3.ShowDialog();
			Close();
		}
	

	}
}
