
namespace Keyboard
{
	partial class Form3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(9, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(237, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button2.Location = new System.Drawing.Point(302, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "Сохранение";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button3.Location = new System.Drawing.Point(433, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 28);
			this.button3.TabIndex = 3;
			this.button3.Text = "Загрузка";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new System.Drawing.Point(1, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 41);
			this.panel1.TabIndex = 4;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button4.Location = new System.Drawing.Point(554, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(71, 28);
			this.button4.TabIndex = 5;
			this.button4.Text = "Вернуться";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(419, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "|";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Location = new System.Drawing.Point(1, 50);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(632, 418);
			this.panel2.TabIndex = 5;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 470);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(654, 509);
			this.Name = "Form3";
			this.Text = "Собственная раскладка";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
