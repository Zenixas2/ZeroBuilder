using System;
using System.Reflection;

// Token: 0x02000009 RID: 9
internal class Class2
{
	// Token: 0x0600001D RID: 29 RVA: 0x000047C4 File Offset: 0x000029C4
	internal static void H0SD36NNgk3Pi(int typemdt)
	{
		Type type = Class2.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class2.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000022EE File Offset: 0x000004EE
	public Class2()
	{
		Class3.QU7D36NzQAHi4();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002391 File Offset: 0x00000591
	static Class2()
	{
		Class3.QU7D36NzQAHi4();
		Class2.module_0 = typeof(Class2).Assembly.ManifestModule;
	}

	// Token: 0x0400001F RID: 31
	internal static Module module_0;

	// Token: 0x0200000A RID: 10
	// (Invoke) Token: 0x06000021 RID: 33
	internal delegate void Delegate0(object o);
}
