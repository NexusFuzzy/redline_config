using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


[DataContract(Name = "Entity17", Namespace = "Entity")]
public class Entity_CryptoWallet
{
	[DataMember(Name = "Id1")]
	public string Id1 { get; set; }

	[DataMember(Name = "Id2")]
	public string Id2 { get; set; }

	[DataMember(Name = "Id3")]
	public IEnumerable<Entity_FileSearchInformation> Id3 { get; set; }
}
