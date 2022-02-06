using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace LightX
{
	// Token: 0x02000007 RID: 7
	public partial class ScriptMaker : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004F10 File Offset: 0x00003110
		public ScriptMaker()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004F33 File Offset: 0x00003133
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Text = File.ReadAllText(string.Format("./ScriptMaker/SavedScripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004F5C File Offset: 0x0000315C
		private void button10_Click(object sender, EventArgs e)
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

		// Token: 0x0600003B RID: 59 RVA: 0x00004FE0 File Offset: 0x000031E0
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005026 File Offset: 0x00003226
		private void button2_Click(object sender, EventArgs e)
		{
			this.module.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005040 File Offset: 0x00003240
		private void button6_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./ScriptMaker/SavedScripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./ScriptMaker/SavedScripts", "*.lua");
		}

		// Token: 0x04000039 RID: 57
		private ExploitAPI module = new ExploitAPI();
	}
}
