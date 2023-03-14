using System;
using System.Runtime.InteropServices;

// Token: 0x0200002E RID: 46
public struct BCRYPT_PSS_PADDING_INFO
{
	// Token: 0x0600010A RID: 266 RVA: 0x0000AC22 File Offset: 0x00009022
	public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
	{
		this.pszAlgId = pszAlgId;
		this.cbSalt = cbSalt;
	}

	// Token: 0x04000045 RID: 69
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	// Token: 0x04000046 RID: 70
	public int cbSalt;
}
