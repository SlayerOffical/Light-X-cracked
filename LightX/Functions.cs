using System;
using System.IO;
using System.Windows.Forms;

namespace LightX
{
	// Token: 0x02000002 RID: 2
	internal class Functions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileInfo[] files = directoryInfo.GetFiles(FileType);
			foreach (FileInfo fileInfo in files)
			{
				lsb.Items.Add(fileInfo.Name);
			}
		}
	}
}
