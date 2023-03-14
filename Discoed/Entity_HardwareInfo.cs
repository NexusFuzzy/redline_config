using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity3", Namespace = "Entity")]
public class Entity_HardwareInfo
{	
	[DataMember(Name = "Id1")]
	public string name { get; set; }

	[DataMember(Name = "Id2")]
	public string value { get; set; }

	[DataMember(Name = "Id3")]
	public Entity_HardwareType Id3 { get; set; }
}
