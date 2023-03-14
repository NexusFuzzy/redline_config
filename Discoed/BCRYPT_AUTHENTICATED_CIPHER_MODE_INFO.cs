using System;
using System.Runtime.InteropServices;

// Token: 0x0200002B RID: 43
public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
{
	// Token: 0x06000106 RID: 262 RVA: 0x0000AA78 File Offset: 0x00008E78
	public BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag)
	{
		this = default(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
		this.dwInfoVersion = BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.BCRYPT_INIT_AUTH_MODE_INFO_VERSION;
		this.cbSize = Marshal.SizeOf(typeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO));
		bool flag = iv != null;
		if (flag)
		{
			this.cbNonce = iv.Length;
			this.pbNonce = Marshal.AllocHGlobal(this.cbNonce);
			Marshal.Copy(iv, 0, this.pbNonce, this.cbNonce);
		}
		bool flag2 = aad != null;
		if (flag2)
		{
			this.cbAuthData = aad.Length;
			this.pbAuthData = Marshal.AllocHGlobal(this.cbAuthData);
			Marshal.Copy(aad, 0, this.pbAuthData, this.cbAuthData);
		}
		bool flag3 = tag != null;
		if (flag3)
		{
			this.cbTag = tag.Length;
			this.pbTag = Marshal.AllocHGlobal(this.cbTag);
			Marshal.Copy(tag, 0, this.pbTag, this.cbTag);
			this.cbMacContext = tag.Length;
			this.pbMacContext = Marshal.AllocHGlobal(this.cbMacContext);
		}
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000AB70 File Offset: 0x00008F70
	public void Dispose()
	{
		bool flag = this.pbNonce != IntPtr.Zero;
		if (flag)
		{
			Marshal.FreeHGlobal(this.pbNonce);
		}
		bool flag2 = this.pbTag != IntPtr.Zero;
		if (flag2)
		{
			Marshal.FreeHGlobal(this.pbTag);
		}
		bool flag3 = this.pbAuthData != IntPtr.Zero;
		if (flag3)
		{
			Marshal.FreeHGlobal(this.pbAuthData);
		}
		bool flag4 = this.pbMacContext != IntPtr.Zero;
		if (flag4)
		{
			Marshal.FreeHGlobal(this.pbMacContext);
		}
	}

	// Token: 0x04000031 RID: 49
	public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION = 1;

	// Token: 0x04000032 RID: 50
	public int cbSize;

	// Token: 0x04000033 RID: 51
	public int dwInfoVersion;

	// Token: 0x04000034 RID: 52
	public IntPtr pbNonce;

	// Token: 0x04000035 RID: 53
	public int cbNonce;

	// Token: 0x04000036 RID: 54
	public IntPtr pbAuthData;

	// Token: 0x04000037 RID: 55
	public int cbAuthData;

	// Token: 0x04000038 RID: 56
	public IntPtr pbTag;

	// Token: 0x04000039 RID: 57
	public int cbTag;

	// Token: 0x0400003A RID: 58
	public IntPtr pbMacContext;

	// Token: 0x0400003B RID: 59
	public int cbMacContext;

	// Token: 0x0400003C RID: 60
	public int cbAAD;

	// Token: 0x0400003D RID: 61
	public long cbData;

	// Token: 0x0400003E RID: 62
	public int dwFlags;
}
