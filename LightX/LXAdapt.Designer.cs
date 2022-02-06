namespace LightX
{
	// Token: 0x02000004 RID: 4
	public partial class LXAdapt : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000372C File Offset: 0x0000192C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003764 File Offset: 0x00001964
		private void InitializeComponent()
		{
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(522, 245);
			this.panel2.TabIndex = 5;
			this.button1.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(138, 163);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(248, 69);
			this.button1.TabIndex = 6;
			this.button1.Text = "Execute LXAdapt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(3, 68);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(84, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "game you enjoy!";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(3, 55);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(516, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "execute that script for you, if it is approved by LightX developers. This is the easiest way, to find a script for a";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(3, 42);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(487, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "LXAdapt. An adaptive roblox script which detects the game you are in, and if a script is available, it will";
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(522, 39);
			this.panel1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Trebuchet MS", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(209, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(93, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "LXAdapt";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(521, 244);
			base.Controls.Add(this.panel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "LXAdapt";
			this.Text = "LXAdapt";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label2;
	}
}
