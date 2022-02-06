using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace LightX.Properties
{
	// Token: 0x02000008 RID: 8
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000058F8 File Offset: 0x00003AF8
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00005904 File Offset: 0x00003B04
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("LightX.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000594C File Offset: 0x00003B4C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005963 File Offset: 0x00003B63
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000596C File Offset: 0x00003B6C
		internal static Bitmap download__1_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("download (1)", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000599C File Offset: 0x00003B9C
		internal static Bitmap LX
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("LX", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000059CC File Offset: 0x00003BCC
		internal static Bitmap lx2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("lx2", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000059FC File Offset: 0x00003BFC
		internal static Bitmap Remove_background
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Remove background", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000043 RID: 67
		private static ResourceManager resourceMan;

		// Token: 0x04000044 RID: 68
		private static CultureInfo resourceCulture;
	}
}
