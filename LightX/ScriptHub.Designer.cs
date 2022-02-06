namespace LightX
{
	// Token: 0x02000006 RID: 6
	public partial class ScriptHub : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00004068 File Offset: 0x00002268
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000040A0 File Offset: 0x000022A0
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button12 = new global::System.Windows.Forms.Button();
			this.button13 = new global::System.Windows.Forms.Button();
			this.button14 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.button15 = new global::System.Windows.Forms.Button();
			this.button16 = new global::System.Windows.Forms.Button();
			this.button17 = new global::System.Windows.Forms.Button();
			this.button19 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button20 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-1, -4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(602, 41);
			this.panel1.TabIndex = 0;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Trebuchet MS", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(250, 27);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(82, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Script Hub 1.4";
			this.pictureBox1.Image = global::LightX.Properties.Resources.lx2;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(36, 34);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Trebuchet MS", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(254, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(74, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "LightX";
			this.button1.Location = new global::System.Drawing.Point(242, 43);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(85, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Zoom!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(242, 246);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(85, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Draw!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Location = new global::System.Drawing.Point(242, 159);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(85, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Btools!";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Location = new global::System.Drawing.Point(242, 101);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(85, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "E To Fly";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button9.Location = new global::System.Drawing.Point(2, 43);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(175, 23);
			this.button9.TabIndex = 10;
			this.button9.Text = "BlueZone";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button8.Location = new global::System.Drawing.Point(2, 72);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(175, 23);
			this.button8.TabIndex = 11;
			this.button8.Text = "EclipseHub";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button10.Location = new global::System.Drawing.Point(242, 130);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(85, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "E Gravity";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.button11.Location = new global::System.Drawing.Point(242, 217);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(85, 23);
			this.button11.TabIndex = 13;
			this.button11.Text = "ESP";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new global::System.EventHandler(this.button11_Click);
			this.button12.Location = new global::System.Drawing.Point(242, 275);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(85, 23);
			this.button12.TabIndex = 14;
			this.button12.Text = "Dex V2";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new global::System.EventHandler(this.button12_Click);
			this.button13.Location = new global::System.Drawing.Point(424, 43);
			this.button13.Name = "button13";
			this.button13.Size = new global::System.Drawing.Size(177, 23);
			this.button13.TabIndex = 15;
			this.button13.Text = "King Legacy GUI";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new global::System.EventHandler(this.button13_Click);
			this.button14.Location = new global::System.Drawing.Point(424, 72);
			this.button14.Name = "button14";
			this.button14.Size = new global::System.Drawing.Size(177, 23);
			this.button14.TabIndex = 16;
			this.button14.Text = "Pet Simulator X GUI";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new global::System.EventHandler(this.button14_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(519, 365);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(82, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "LightX 1.4 2022";
			this.button15.Location = new global::System.Drawing.Point(424, 101);
			this.button15.Name = "button15";
			this.button15.Size = new global::System.Drawing.Size(177, 23);
			this.button15.TabIndex = 19;
			this.button15.Text = "Phantom Forces GUI";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new global::System.EventHandler(this.button15_Click);
			this.button16.Location = new global::System.Drawing.Point(424, 130);
			this.button16.Name = "button16";
			this.button16.Size = new global::System.Drawing.Size(177, 23);
			this.button16.TabIndex = 20;
			this.button16.Text = "[OP] Strucid GUI\r\n";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new global::System.EventHandler(this.button16_Click);
			this.button17.Location = new global::System.Drawing.Point(242, 72);
			this.button17.Name = "button17";
			this.button17.Size = new global::System.Drawing.Size(85, 23);
			this.button17.TabIndex = 21;
			this.button17.Text = "OwlHub";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new global::System.EventHandler(this.button17_Click);
			this.button19.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.button19.Location = new global::System.Drawing.Point(242, 188);
			this.button19.Name = "button19";
			this.button19.Size = new global::System.Drawing.Size(85, 23);
			this.button19.TabIndex = 23;
			this.button19.Text = "Ctrl + Click TP";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += new global::System.EventHandler(this.button19_Click);
			this.button7.Location = new global::System.Drawing.Point(424, 159);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(177, 23);
			this.button7.TabIndex = 24;
			this.button7.Text = "Bee Swarm Simulator GUI";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click_3);
			this.button20.Location = new global::System.Drawing.Point(424, 188);
			this.button20.Name = "button20";
			this.button20.Size = new global::System.Drawing.Size(177, 23);
			this.button20.TabIndex = 25;
			this.button20.Text = "Funky Friday GUI";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new global::System.EventHandler(this.button20_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
			base.ClientSize = new global::System.Drawing.Size(601, 379);
			base.Controls.Add(this.button20);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.button16);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.button14);
			base.Controls.Add(this.button13);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "ScriptHub";
			this.Text = "ScriptHub";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000022 RID: 34
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button button11;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Button button12;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button button13;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button button14;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button button15;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Button button16;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button button17;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button button19;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button button20;
	}
}
