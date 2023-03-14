using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity12", Namespace = "Entity")]
public class Entity_LoginData
{
	[DataMember(Name = "Id1")]
	public string URL { get; set; }

	[DataMember(Name = "Id2")]
	public string Username { get; set; }

	[DataMember(Name = "Id3")]
	public string Password { get; set; }
}
