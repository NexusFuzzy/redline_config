using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Discoed
{
	public static class UserExt
	{
		
		// Token: 0x06000114 RID: 276 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public static void PreCheck(this Entity_CollectedResults log)
		{
			try
			{
				foreach (PropertyInfo propertyInfo in log.GetType().GetProperties())
				{
					if (propertyInfo.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(propertyInfo.GetValue(log, null) as string))
					{
						propertyInfo.SetValue(log, new string(new char[]
						{
						'U',
						'N',
						'K',
						'N',
						'O',
						'W',
						'N'
						}), null);
					}
				}
			}
			catch
			{
			}
		}
	}
}
