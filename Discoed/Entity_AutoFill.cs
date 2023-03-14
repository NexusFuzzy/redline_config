using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity8", Namespace = "Entity")]
public class Entity_AutoFill
{
	[DataMember(Name = "Id1")]
	public string Name { get; set; }

	[DataMember(Name = "Id2")]
	public string Value { get; set; }
}
