using System;
using System.Runtime.Serialization;

// Token: 0x0200003C RID: 60
[DataContract(Name = "LocalState")]
public class LocalState
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060001AF RID: 431 RVA: 0x0000B560 File Offset: 0x00009960
	// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000B568 File Offset: 0x00009968
	[DataMember(Name = "os_crypt")]
	public OsCrypt os_crypt { get; set; }
}
