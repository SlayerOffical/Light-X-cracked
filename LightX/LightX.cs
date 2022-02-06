using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using LightX.Properties;
using WeAreDevs_API;

namespace LightX
{
	// Token: 0x02000003 RID: 3
	public partial class LightX : Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020A1 File Offset: 0x000002A1
		public LightX()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020C4 File Offset: 0x000002C4
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020C7 File Offset: 0x000002C7
		private void button2_Click(object sender, EventArgs e)
		{
			this.module.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020E1 File Offset: 0x000002E1
		private void button9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020EA File Offset: 0x000002EA
		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020F5 File Offset: 0x000002F5
		private void LightX_Load(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002135 File Offset: 0x00000335
		private void button5_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002144 File Offset: 0x00000344
		private void button1_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002154 File Offset: 0x00000354
		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000219A File Offset: 0x0000039A
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000219D File Offset: 0x0000039D
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021B8 File Offset: 0x000003B8
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000221C File Offset: 0x0000041C
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.fastColoredTextBox1.Text);
					}
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022A0 File Offset: 0x000004A0
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022C9 File Offset: 0x000004C9
		private void button6_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000230C File Offset: 0x0000050C
		private void button8_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002333 File Offset: 0x00000533
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002338 File Offset: 0x00000538
		private void button10_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
			LXAdapt lxadapt = new LXAdapt();
			lxadapt.Show();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002360 File Offset: 0x00000560
		private void button4_Click_1(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
				this.module.SendLuaScript(this.fastColoredTextBox1.Text);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023CC File Offset: 0x000005CC
		private void button12_Click_1(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
			ScriptMaker scriptMaker = new ScriptMaker();
			scriptMaker.Show();
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI module = new ExploitAPI();

		// Token: 0x04000002 RID: 2
		private Point lastPoint;
	}
}
