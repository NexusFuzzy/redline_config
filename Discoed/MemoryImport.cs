using System;
using System.Runtime.InteropServices;

// Token: 0x02000023 RID: 35
public static class MemoryImport
{
	// Token: 0x060000C3 RID: 195
	[DllImport("kernel32.dll", EntryPoint = "LoadLibraryA", SetLastError = true)]
	public static extern IntPtr LoadLibrary(string fileName);

	// Token: 0x060000C4 RID: 196
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	// Token: 0x060000C5 RID: 197 RVA: 0x00009650 File Offset: 0x00007A50
	public static T Func<T>(IntPtr arg1) where T : class
	{
		return Marshal.GetDelegateForFunctionPointer(arg1, typeof(T)) as T;
	}
}
