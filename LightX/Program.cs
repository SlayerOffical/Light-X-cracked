using System;
using System.Windows.Forms;

namespace LightX
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003C2E File Offset: 0x00001E2E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LightX());
		}
	}
}
