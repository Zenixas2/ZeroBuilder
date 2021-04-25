using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WebhookStealer.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000022EE File Offset: 0x000004EE
		internal Resources()
		{
			Class3.QU7D36NzQAHi4();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002317 File Offset: 0x00000517
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					Resources.resourceManager_0 = new ResourceManager("WebhookStealer.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002344 File Offset: 0x00000544
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000234C File Offset: 0x0000054C
		internal static string smethod_0()
		{
			return Resources.ResourceManager_0.GetString("Code", Resources.cultureInfo_0);
		}

		// Token: 0x0400001C RID: 28
		private static ResourceManager resourceManager_0;

		// Token: 0x0400001D RID: 29
		private static CultureInfo cultureInfo_0;
	}
}
