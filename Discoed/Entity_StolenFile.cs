using System;
using System.IO;
using System.Runtime.Serialization;

[DataContract(Name = "Entity5", Namespace = "Entity")]
public class Entity_StolenFile
{	
	public Entity_StolenFile()
	{
	}

	public Entity_StolenFile(string filename)
	{
		this.FileName = new FileInfo(filename).Name;
		this.Content = filename.ReadFile();
	}

	[DataMember(Name = "Id1")]
	public string FileName { get; set; }

	[DataMember(Name = "Id2")]
	public string CompletePath { get; set; }

	[DataMember(Name = "Id3")]
	public byte[] Content { get; set; }

	[DataMember(Name = "Id4")]
	public string Path { get; set; }

	[DataMember(Name = "Id5")]
	public string Id5 { get; set; }
}
