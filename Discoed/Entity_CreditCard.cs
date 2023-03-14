using System;
using System.Runtime.Serialization;


[DataContract(Name = "Entity11", Namespace = "Entity")]
public class Entity_CreditCard
{
	[DataMember(Name = "Id1")]
	public string NameOnCard { get; set; }

	[DataMember(Name = "Id2")]
	public int Expiration_Month { get; set; }

	[DataMember(Name = "Id3")]
	public int Expiration_Year { get; set; }

	[DataMember(Name = "Id4")]
	public string CardNumber { get; set; }
}
