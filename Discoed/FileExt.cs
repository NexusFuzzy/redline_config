using System;
using System.IO;
using System.Text;

// Token: 0x0200001C RID: 28
public static class FileExt
{
	// Token: 0x060000B2 RID: 178 RVA: 0x00008D4C File Offset: 0x0000714C
	public static byte[] ReadFile(this string filename)
	{
		try
		{
			bool flag = File.Exists(filename);
			if (flag)
			{
				using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1251)))
					{
						return streamReader.CurrentEncoding.GetBytes(streamReader.ReadToEnd());
					}
				}
			}
		}
		catch
		{
		}
		return new byte[0];
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00008DE8 File Offset: 0x000071E8
	public static string ReadFileAsText(this string filename)
	{
		try
		{
			bool flag = File.Exists(filename);
			if (flag)
			{
				using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1251)))
					{
						return streamReader.ReadToEnd();
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}
}
