using System;
using System.Globalization;

// Token: 0x02000020 RID: 32
public static class EnvironmentChecker
{
	// Token: 0x060000BB RID: 187 RVA: 0x00009160 File Offset: 0x00007560
	public static bool Check()
	{
		try
		{
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			string name = (currentCulture != null) ? currentCulture.ToString() : null;
			RegionInfo regionInfo = new RegionInfo(name);
			TimeZoneInfo local = TimeZoneInfo.Local;
			string[] regionsCountry = EnvironmentChecker.RegionsCountry;
			int i = 0;
			while (i < regionsCountry.Length)
			{
				string text = regionsCountry[i];
				if (text.Contains(regionInfo.EnglishName))
				{
					goto IL_6C;
				}
				string text2 = text;
				CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
				if (text2.Contains((currentUICulture != null) ? currentUICulture.EnglishName : null))
				{
					goto IL_6C;
				}
				bool flag = local.Id.Contains(text);
				IL_6D:
				bool flag2 = flag;
				if (flag2)
				{
					return true;
				}
				i++;
				continue;
				IL_6C:
				flag = true;
				goto IL_6D;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	// Token: 0x04000015 RID: 21
	private static readonly string[] RegionsCountry = new string[]
	{
		"Armenia",
		"Azerbaijan",
		"Belarus",
		"Kazakhstan",
		"Kyrgyzstan",
		"Moldova",
		"Tajikistan",
		"Uzbekistan",
		"Ukraine",
		"Russia"
	};
}
