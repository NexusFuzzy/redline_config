using System;
using System.Runtime.Serialization;

// Token: 0x0200003D RID: 61
[DataContract(Name = "OsCrypt")]
public class OsCrypt
{
	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000B57A File Offset: 0x0000997A
	// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000B582 File Offset: 0x00009982
	[DataMember(Name = "encrypted_key")]
	public string encrypted_key { get; set; }
}
