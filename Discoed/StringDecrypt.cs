using System;
using System.Text;

// Token: 0x02000008 RID: 8
public static class StringDecrypt
{
	// Token: 0x06000028 RID: 40 RVA: 0x000043D4 File Offset: 0x000027D4
	public static string Xor(string input, string stringKey)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < input.Length; i++)
		{
			int utf = (int)(input[i] ^ stringKey[i % stringKey.Length]);
			stringBuilder.AppendFormat("{0}", char.ConvertFromUtf32(utf));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00004434 File Offset: 0x00002834
	private static string FromBase64(string base64str)
	{
		return StringDecrypt.BytesToStringConverted(Convert.FromBase64CharArray(base64str.ToCharArray(), 0, base64str.Length));
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00004460 File Offset: 0x00002860
	private static string BytesToStringConverted(byte[] bytes)
	{
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00004480 File Offset: 0x00002880
	public static string Read(string b64, string stringKey)
	{
		string result;
		try
		{
			bool flag = string.IsNullOrWhiteSpace(b64);
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string input = StringDecrypt.FromBase64(b64);
				result = StringDecrypt.FromBase64(StringDecrypt.Xor(input, stringKey));
			}
		}
		catch
		{
			result = b64;
		}
		return result;
	}
}
