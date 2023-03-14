using System;

// Token: 0x0200001E RID: 30
public static class StringExt
{
	// Token: 0x060000B7 RID: 183 RVA: 0x00008F18 File Offset: 0x00007318
	public static T ChangeType<T>(this object @this)
	{
		return (T)((object)Convert.ChangeType(@this, typeof(T)));
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00008F40 File Offset: 0x00007340
	public static string StripQuotes(this string value)
	{
		return value.Replace("\"", string.Empty);
	}
}
