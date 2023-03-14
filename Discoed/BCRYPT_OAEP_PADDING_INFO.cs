using System;
using System.Runtime.InteropServices;

// Token: 0x0200002D RID: 45
public struct BCRYPT_OAEP_PADDING_INFO
{
	// Token: 0x06000109 RID: 265 RVA: 0x0000AC06 File Offset: 0x00009006
	public BCRYPT_OAEP_PADDING_INFO(string alg)
	{
		this.pszAlgId = alg;
		this.pbLabel = IntPtr.Zero;
		this.cbLabel = 0;
	}

	// Token: 0x04000042 RID: 66
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	// Token: 0x04000043 RID: 67
	public IntPtr pbLabel;

	// Token: 0x04000044 RID: 68
	public int cbLabel;
}
