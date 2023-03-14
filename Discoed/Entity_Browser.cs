using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


[DataContract(Name = "Entity9", Namespace = "Entity")]
public class Entity_Browser
{
	[DataMember(Name = "Id1")]
	public string NameOfBrowser { get; set; }

	[DataMember(Name = "Id2")]
	public string ProfileOfBrowser { get; set; }

	[DataMember(Name = "Id3")]
	public IList<Entity_LoginData> LoginData { get; set; }

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600014B RID: 331 RVA: 0x0000349B File Offset: 0x0000169B
	// (set) Token: 0x0600014C RID: 332 RVA: 0x000034A3 File Offset: 0x000016A3
	[DataMember(Name = "Id4")]
	public IList<Entity_AutoFill> AutoFill { get; set; }

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600014D RID: 333 RVA: 0x000034AC File Offset: 0x000016AC
	// (set) Token: 0x0600014E RID: 334 RVA: 0x000034B4 File Offset: 0x000016B4
	[DataMember(Name = "Id5")]
	public IList<Entity_CreditCard> CreditCard { get; set; }

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600014F RID: 335 RVA: 0x000034BD File Offset: 0x000016BD
	// (set) Token: 0x06000150 RID: 336 RVA: 0x000034C5 File Offset: 0x000016C5
	[DataMember(Name = "Id6")]
	public IList<Entity_Cookie> Cookies { get; set; }

	// Token: 0x06000151 RID: 337 RVA: 0x0000B25C File Offset: 0x0000945C
	public bool Id7()
	{
		bool result = true;
		IList<Entity_AutoFill> id = this.AutoFill;
		if (id != null && id.Count > 0)
		{
			result = false;
		}
		IList<Entity_Cookie> id2 = this.Cookies;
		if (id2 != null && id2.Count > 0)
		{
			result = false;
		}
		IList<Entity_CreditCard> id3 = this.CreditCard;
		if (id3 != null && id3.Count > 0)
		{
			result = false;
		}
		IList<Entity_LoginData> id4 = this.LoginData;
		if (id4 != null && id4.Count > 0)
		{
			result = false;
		}
		return result;
	}
}
