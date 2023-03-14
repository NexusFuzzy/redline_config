using System;
using System.Runtime.Serialization;

[DataContract(Name = "Entity4", Namespace = "Entity")]
public class BrowserInfo
{
	[DataMember(Name = "Id1")]
	public string Name { get; set; }

	[DataMember(Name = "Id2")]
	public string version { get; set; }

	[DataMember(Name = "Id3")]
	public string Path { get; set; }
}
