using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using LightX.Properties;
using WeAreDevs_API;

namespace LightX
{
	// Token: 0x02000006 RID: 6
	public partial class ScriptHub : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003C49 File Offset: 0x00001E49
		public ScriptHub()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003C6C File Offset: 0x00001E6C
		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C78 File Offset: 0x00001E78
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/ZRnkw6tc");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003CA8 File Offset: 0x00001EA8
		private void button2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/1322re6a");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003CD8 File Offset: 0x00001ED8
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/WdW0KKQz");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003D08 File Offset: 0x00001F08
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/WrLnxyee");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003D38 File Offset: 0x00001F38
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/cd8cEvnM");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D68 File Offset: 0x00001F68
		private void button6_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/H4CnKr3s");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003D98 File Offset: 0x00001F98
		private void button9_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/5Zc0Nz8N");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003DC8 File Offset: 0x00001FC8
		private void button7_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/DohmBoyOG/Script-Dump/main/OPSkywarsGUI_NolixXDohmScripts_Public.lua");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/Y2GnC2uq");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003E28 File Offset: 0x00002028
		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://cdn.wearedevs.net/scripts/Gravity Switch.txt");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003E58 File Offset: 0x00002058
		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://cdn.wearedevs.net/scripts/WRD ESP.txt");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E88 File Offset: 0x00002088
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://cdn.wearedevs.net/scripts/Dex Explorer V2.txt");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003EB8 File Offset: 0x000020B8
		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/sannin9000/scripts/main/kinglegacy.lua");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003EE8 File Offset: 0x000020E8
		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/si1nnx/psxx/main/g");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003F18 File Offset: 0x00002118
		private void button15_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/Herrtt/Phantom-Forces-Cheat/main/Main.lua");
			this.module.SendLuaScript(text);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003F48 File Offset: 0x00002148
		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/iNRrxa0R");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003F78 File Offset: 0x00002178
		private void button17_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003FA8 File Offset: 0x000021A8
		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/9dKfeXbF");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003FD8 File Offset: 0x000021D8
		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://cdn.wearedevs.net/scripts/Click%20Teleport.txt");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004005 File Offset: 0x00002205
		private void button7_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004008 File Offset: 0x00002208
		private void button7_Click_3(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/not-weuz/Lua/main/bsstrainer.lua");
			this.module.SendLuaScript(text);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004038 File Offset: 0x00002238
		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://raw.githubusercontent.com/wally-rblx/funky-friday-autoplay/main/main.lua");
			this.module.SendLuaScript(text);
		}

		// Token: 0x04000021 RID: 33
		private ExploitAPI module = new ExploitAPI();
	}
}
