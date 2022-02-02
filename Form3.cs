using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections.Generic;

namespace Keyboard
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		protected override CreateParams CreateParams //задаем параметр формы чтобы она была поверх окон и не переключала на себя нажатия
		{
			get {
				CreateParams param = base.CreateParams;
				param.ExStyle |= 0x08000000;
				return param;
			}
		}
		
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			TopMost = true;
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public int PosTop = 5; //Позиция Сверху
		
		public int PosLeft = 10; //Позиция Слева
		
		public int CountOfButtons = 0;  //Количество кнопок
		
		public int lenBut;
		
		public List<string> SaveList = new List<string>(); //список данных для сохранения кнопок
		
		void Button1Click(object sender, EventArgs e)
		{	
			TopMost = false;//форма не поверх окон(чтобы мы могли ввести название кнопки)TopMost = false;
			string Value = Microsoft.VisualBasic.Interaction.InputBox("Название","Создание новой кнопки","",100);//вызываем окно опроса для ввода названия кнопки
			TopMost = true;
			
			var FontT = new Font("Microsoft Sans Serif", 8.25F);
			var textSize = TextRenderer.MeasureText(Value, FontT); 
		
			lenBut=textSize.Width;
			lenBut+=10;
				
    		if (PosLeft + lenBut>= this.panel2.Width)//если следующая кнопка будет касаться нижней границы панели тогда переносим ее путем изменения глобального отступа слева
    		{
    			PosTop=PosTop + 29;
    			PosLeft=10;
    		}
    		
    		TopMost = true;//форма поверх окон
			Button button = new Button(); //новая кнопка
    		button.Left = PosLeft; //отступ слева
    		
    		button.Top = PosTop;//отступ сверху
    		button.Width=lenBut;//ширина кнопки
    		TopMost = false;//форма не поверх окон(чтобы мы могли ввести название кнопки)
    		
    		
    		button.Text=Value;//текст кнопки равен введенному в окно опроса
    		button.Name="Button"+CountOfButtons;//имя кнопки равно слову Button+ее номеру от 0
    		button.Click += ButtonOnClick; //добавляем событие на щелчок по кнопке
    		button.Parent=panel2; //родительский элемент для кнопки будет панель2
    		this.panel2.Controls.Add(button); //добавляем кнопку на элемент родитель
    		
    		CountOfButtons++;//увеличиваем колво кнопок
    		
    		if (SaveList.Count == 0)//если список данных для сохранения пуст
    		{
    			SaveList.Add(Convert.ToString(CountOfButtons));//добавляем в 0 элемент колво кнопок
    		}
    		else SaveList[0]=Convert.ToString(CountOfButtons);//иначе меняем колво кнопок в 0 элементе
    		
    		SaveList.Add(button.Text);//добавляем в список текст кнопки
    		
    		SaveList.Add(button.Name);//добавляем ее имя
    		
    		SaveList.Add(Convert.ToString(PosLeft));//добавляем отступ слева
    		
    		SaveList.Add(Convert.ToString(PosTop));//добавляем отступ сверху
    		
    		SaveList.Add(Convert.ToString(lenBut));//длина кнопки
    		
    		PosLeft=PosLeft + button.Width + 10;//меняем глобальную переменную отступа слева для создания следующей кнопки
    		
    		
		}
		
		public void ButtonOnClick(object sender, EventArgs eventArgs)//на щелчок по созданным кнопкам
		{
			var button = (Button)sender;//создаем переменную хранящую текст кнопкки
			if (button != null) //если она не пуста
			{
    			SendKeys.Send(button.Text);//вводим в поле текст с кнопки
			}
		}
		void Button2Click(object sender, EventArgs e)//сохранение
		{
			var Saver = new SaveFileDialog();//новый диалог сохранения
			Saver.Filter = "Сохранения (*.txt)|*.txt";//какие файлы принимает диалоговое окно
			Saver.ShowDialog();//показываем лдиалог
		
			if (Saver.FileName!="")//если введено название файла
			{
				using (StreamWriter sw = new StreamWriter(Saver.FileName))//используем новый стримвритер 
            	{
                	foreach (var q in SaveList)//проходим все элементы списка сейвлист
                	{
                    	sw.WriteLine(q); //записываем в файл построчно все значения списка сейвлист
                	}
				}
            	
			}
		}
		void Button3Click(object sender, EventArgs e)//загрузка 
		{
			SaveList.Clear();//очищаем список сохранения
			
			RemoveControls();//удаляем все текущие кнопки
			try{
				var Loader = new OpenFileDialog();//новый загрузочный диалог
				Loader.Filter = "Сохранения (*.txt)|*.txt";//
				Loader.ShowDialog();//
				
				if (Loader.FileName!="")//если имя не пусто
				{
					string temp = "";//временная строка
					using (StreamReader sr = new StreamReader(Loader.FileName))//используем новый стримридер
            		{
              	  		while ((temp = sr.ReadLine()) != null)//пока считываемые данные не кончились
                		{
                			SaveList.Add(temp);//добавляем временную строку содержащуюю значение в список
                		}
            		}
				}
				CreateKeys();//вызываем метод создания кнопок
			}
			catch{}
			
		}
		
		public void RemoveControls()//метод удаления кнопок с формы
		{
			panel2.Controls.Clear();//очищаем панел2 (родитель кнопок)
			PosLeft=10;//устанавливаем стандартные координаты 
			PosTop=5;//
		}
		
		public void CreateKeys()//выводим кнопки из загрузочного списка
		{
			try{
				int i = 0;//
				while (i+5<SaveList.Count)//пока кнопки не кончились (одна кнопка 5 переменных для данных) 
				{
					Button button = new Button();//новая кнопка
					i++;
					button.Text=SaveList[i];//считываем текст
					i++;
					button.Name=SaveList[i];//считываем имя
					i++;
					button.Left=Convert.ToInt32(SaveList[i]);//считываем коорд слева
					i++;
					button.Top=Convert.ToInt32(SaveList[i]);//считываем коорд сверху
					i++;
					button.Width=Convert.ToInt32(SaveList[i]);//ширина кнопки
					
					button.Click += ButtonOnClick;//событие на клик по кнопке
					button.Parent=panel2;//родитель
					this.panel2.Controls.Add(button);//добавляем на родителя
				}
				
				lenBut=Convert.ToInt32(SaveList[Convert.ToInt32(SaveList.Count-1)]);
				PosLeft=Convert.ToInt32(SaveList[Convert.ToInt32(SaveList.Count-3)])+lenBut+10;//задаем отступы на случай если будем создавать кнопку к загруженной раскладке
				PosTop=Convert.ToInt32(SaveList[Convert.ToInt32(SaveList.Count-2)]);
			}
			catch{}
		}
		void Button4Click(object sender, EventArgs e)//переход обратно к клавиатуре
		{
			Hide();//скрыть текущую форму
			var Form1 = new MainForm();//создать новую 
			Form1.ShowDialog();//показать ее
			Close();//закрыть старую
		}
	}
}
