using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity16", Namespace = "Entity")]
public class Entity_FileSearchInformation
{
	
	[DataMember(Name = "Id5")]
	public string Id5 { get; set; }

	[DataMember(Name = "Id1")]
	public string Id1 { get; set; }

	[DataMember(Name = "Id2")]
	public string Id2 { get; set; }

	[DataMember(Name = "Id3")]
	public bool Id3 { get; set; }
}
