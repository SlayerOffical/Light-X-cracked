namespace LightX
{
	// Token: 0x02000007 RID: 7
	public partial class ScriptMaker : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00005080 File Offset: 0x00003280
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000050B8 File Offset: 0x000032B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LightX.ScriptMaker));
			this.button10 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.button6 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button10.Font = new global::System.Drawing.Font("Modern No. 20", 8.999999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button10.Location = new global::System.Drawing.Point(12, 167);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(88, 39);
			this.button10.TabIndex = 19;
			this.button10.Text = "Save Script";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button1.Font = new global::System.Drawing.Font("Modern No. 20", 8.999999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(106, 167);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(88, 39);
			this.button1.TabIndex = 20;
			this.button1.Text = "Open Script";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button2.Font = new global::System.Drawing.Font("Modern No. 20", 8.999999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(200, 167);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(88, 39);
			this.button2.TabIndex = 21;
			this.button2.Text = "Execute Script";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(294, 41);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(100, 143);
			this.listBox1.TabIndex = 22;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button6.Font = new global::System.Drawing.Font("Modern No. 20", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.Location = new global::System.Drawing.Point(291, 185);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(103, 21);
			this.button6.TabIndex = 23;
			this.button6.Text = "Refresh";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.panel2.BackColor = global::System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new global::System.Drawing.Point(294, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(100, 29);
			this.panel2.TabIndex = 24;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(1, 5);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(99, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Saved Scripts";
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
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(27, 14);
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
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Language = global::FastColoredTextBoxNS.Language.Lua;
			this.fastColoredTextBox1.LeftBracket = '(';
			this.fastColoredTextBox1.LeftBracket2 = '{';
			this.fastColoredTextBox1.LineNumberColor = global::System.Drawing.Color.FromArgb(192, 192, 0);
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(13, 12);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.RightBracket = ')';
			this.fastColoredTextBox1.RightBracket2 = '}';
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(275, 149);
			this.fastColoredTextBox1.TabIndex = 25;
			this.fastColoredTextBox1.Zoom = 100;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(402, 209);
			base.Controls.Add(this.fastColoredTextBox1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button10);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "ScriptMaker";
			this.Text = "ScriptMaker";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400003A RID: 58
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000042 RID: 66
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
	}
}
