using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000007 RID: 7
public static class CryptoHelper
{
	// Token: 0x06000024 RID: 36 RVA: 0x0000420C File Offset: 0x0000260C
	public static string GetDecoded(string EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		return Encoding.UTF8.GetString(CryptoHelper.DecryptBlob(Encoding.GetEncoding(new string(new char[]
		{
			'w',
			'i',
			'n',
			'd',
			'o',
			'w',
			's',
			'-',
			'1',
			'2',
			'5',
			'1'
		})).GetBytes(EncryptedData), dataProtectionScope, entropy));
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00004254 File Offset: 0x00002654
	public static byte[] DecryptBlob(byte[] EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		byte[] result;
		try
		{
			bool flag = EncryptedData == null || EncryptedData.Length == 0;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = ProtectedData.Unprotect(EncryptedData, entropy, dataProtectionScope);
			}
		}
		catch (Exception ex)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000429C File Offset: 0x0000269C
	public static string GetMd5Hash(string source)
	{
		MD5 md = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(source);
		return CryptoHelper.GetHexString(md.ComputeHash(bytes)).Replace("-", string.Empty);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000042DC File Offset: 0x000026DC
	private static string GetHexString(IList<byte> bt)
	{
		string text = string.Empty;
		for (int i = 0; i < bt.Count; i++)
		{
			byte b = bt[i];
			int num = (int)b;
			int num2 = num & 15;
			int num3 = num >> 4 & 15;
			bool flag = num3 > 9;
			if (flag)
			{
				text += ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				text += num3.ToString(CultureInfo.InvariantCulture);
			}
			bool flag2 = num2 > 9;
			if (flag2)
			{
				text += ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				text += num2.ToString(CultureInfo.InvariantCulture);
			}
			bool flag3 = i + 1 != bt.Count && (i + 1) % 2 == 0;
			if (flag3)
			{
				text += "-";
			}
		}
		return text;
	}
}
