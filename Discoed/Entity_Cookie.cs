using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity10", Namespace = "Entity")]
public class Entity_Cookie
{
	public Entity_Cookie()
	{
	}

	public Entity_Cookie(string expires)
	{
		this.expires_utc = long.Parse(expires);
	}

	[DataMember(Name = "Id1")]
	public string host_key { get; set; }

	[DataMember(Name = "Id2")]
	public bool also_host_key { get; set; }

	[DataMember(Name = "Id3")]
	public string path { get; set; }

	[DataMember(Name = "Id4")]
	public bool is_secure { get; set; }

	[DataMember(Name = "Id5")]
	public long expires_utc { get; set; }

	[DataMember(Name = "Id6")]
	public string name { get; set; }

	[DataMember(Name = "Id7")]
	public string encrypted_value { get; set; }
}
