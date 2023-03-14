using System;
using System.Web.Script.Serialization;

// Token: 0x0200001D RID: 29
public static class Json
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00008E74 File Offset: 0x00007274
	public static JavaScriptSerializer JSON
	{
		get
		{
			JavaScriptSerializer result;
			if ((result = Json.json) == null)
			{
				JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
				javaScriptSerializer.MaxJsonLength = int.MaxValue;
				javaScriptSerializer.RecursionLimit = int.MaxValue;
				result = javaScriptSerializer;
				Json.json = javaScriptSerializer;
			}
			return result;
		}
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00008EB4 File Offset: 0x000072B4
	public static T FromJSON<T>(this string @this)
	{
		T result;
		try
		{
			result = Json.JSON.Deserialize<T>(@this.Trim());
		}
		catch (Exception ex)
		{
			result = default(T);
		}
		return result;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00008EF8 File Offset: 0x000072F8
	public static string ToJSON(this object @this)
	{
		return Json.JSON.Serialize(@this);
	}

	// Token: 0x04000014 RID: 20
	private static JavaScriptSerializer json;
}
