using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000033 RID: 51
public abstract class Extractor
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B086 File Offset: 0x00009486
	// (set) Token: 0x0600011A RID: 282 RVA: 0x0000B08E File Offset: 0x0000948E
	public string Id1 { get; set; }

	// Token: 0x0600011B RID: 283
	public abstract string Id2(Entity_FileSearchInformation scannerArg, FileInfo filePath);

	// Token: 0x0600011C RID: 284
	public abstract IEnumerable<Entity_FileSearchInformation> Id3();
}
