namespace LightX
{
	// Token: 0x02000003 RID: 3
	public partial class LightX : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000023F4 File Offset: 0x000005F4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000242C File Offset: 0x0000062C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LightX.LightX));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.button10 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button12 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.button12);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(979, 33);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Trebuchet MS", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(120, 8);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(73, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Executor 1.4";
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.Location = new global::System.Drawing.Point(932, 4);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(19, 23);
			this.button7.TabIndex = 3;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.Location = new global::System.Drawing.Point(957, 3);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(19, 23);
			this.button9.TabIndex = 2;
			this.button9.Text = "X";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Trebuchet MS", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(31, -2);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(97, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "LightX";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button2.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(6, 233);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(111, 34);
			this.button2.TabIndex = 3;
			this.button2.Text = "Execute";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button1.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(444, 233);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(100, 32);
			this.button1.TabIndex = 10;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button3.Font = new global::System.Drawing.Font("Modern No. 20", 10.5f);
			this.button3.Location = new global::System.Drawing.Point(123, 233);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(103, 34);
			this.button3.TabIndex = 11;
			this.button3.Text = "Open File";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button5.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.Location = new global::System.Drawing.Point(754, 233);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(104, 32);
			this.button5.TabIndex = 13;
			this.button5.Text = "Inject";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button8.Font = new global::System.Drawing.Font("Modern No. 20", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.Location = new global::System.Drawing.Point(744, 6);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(88, 23);
			this.button8.TabIndex = 14;
			this.button8.Text = "Script Hub";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button6.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.Location = new global::System.Drawing.Point(864, 233);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(103, 32);
			this.button6.TabIndex = 15;
			this.button6.Text = "Refresh";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(307, 266);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BookmarkColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.fastColoredTextBox1.BracketsHighlightStrategy = global::FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.fastColoredTextBox1.CaretColor = global::System.Drawing.Color.Yellow;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.CommentPrefix = "--";
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.FoldingIndicatorColor = global::System.Drawing.Color.Yellow;
			this.fastColoredTextBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f);
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Language = global::FastColoredTextBoxNS.Language.Lua;
			this.fastColoredTextBox1.LeftBracket = '(';
			this.fastColoredTextBox1.LeftBracket2 = '{';
			this.fastColoredTextBox1.LineNumberColor = global::System.Drawing.Color.FromArgb(192, 192, 0);
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(6, 39);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.RightBracket = ')';
			this.fastColoredTextBox1.RightBracket2 = '}';
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(855, 186);
			this.fastColoredTextBox1.TabIndex = 16;
			this.fastColoredTextBox1.Text = componentResourceManager.GetString("fastColoredTextBox1.Text");
			this.fastColoredTextBox1.Zoom = 100;
			this.fastColoredTextBox1.Load += new global::System.EventHandler(this.fastColoredTextBox1_Load);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(867, 62);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(100, 169);
			this.listBox1.TabIndex = 17;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button10.Font = new global::System.Drawing.Font("Modern No. 20", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button10.Location = new global::System.Drawing.Point(838, 6);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(88, 22);
			this.button10.TabIndex = 18;
			this.button10.Text = "LXAdapt";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(23, 4);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(58, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Scripts";
			this.panel2.BackColor = global::System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new global::System.Drawing.Point(867, 33);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(100, 29);
			this.panel2.TabIndex = 20;
			this.button11.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button11.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button11.Location = new global::System.Drawing.Point(338, 233);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(100, 34);
			this.button11.TabIndex = 12;
			this.button11.Text = "Save File";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new global::System.EventHandler(this.button4_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button4.Font = new global::System.Drawing.Font("Modern No. 20", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(232, 233);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(100, 34);
			this.button4.TabIndex = 21;
			this.button4.Text = "Execute File";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_1);
			this.pictureBox1.Image = global::LightX.Properties.Resources.lx2;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(33, 33);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.button12.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button12.Font = new global::System.Drawing.Font("Modern No. 20", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button12.Location = new global::System.Drawing.Point(650, 6);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(88, 23);
			this.button12.TabIndex = 19;
			this.button12.Text = "Script Maker";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new global::System.EventHandler(this.button12_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(235, 235, 235);
			base.ClientSize = new global::System.Drawing.Size(979, 277);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.fastColoredTextBox1);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "LightX";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.LightX_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400000F RID: 15
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button10;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button11;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button12;
	}
}
