using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Forms;

// Token: 0x02000021 RID: 33
public static class GdiHelper
{
	// Token: 0x060000BD RID: 189 RVA: 0x00009280 File Offset: 0x00007680
	public static Size GetVirtualDisplaySize()
	{
		Size result;
		try
		{
			result = new Size((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
		}
		catch
		{
			result = Screen.PrimaryScreen.Bounds.Size;
		}
		return result;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000092CC File Offset: 0x000076CC
	public static byte[] GetImageBase()
	{
		byte[] result;
		try
		{
			Size blockRegionSize = new Size((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
			Bitmap bitmap = new Bitmap(blockRegionSize.Width, blockRegionSize.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.Bicubic;
				graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
				graphics.SmoothingMode = SmoothingMode.HighSpeed;
				graphics.CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
			}
			result = GdiHelper.ConvertToBytes(bitmap);
		}
		catch (Exception ex)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00009374 File Offset: 0x00007774
	private static byte[] ConvertToBytes(Image img)
	{
		byte[] result;
		try
		{
			bool flag = img == null;
			if (flag)
			{
				result = null;
			}
			else
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					img.Save(memoryStream, ImageFormat.Png);
					result = memoryStream.ToArray();
				}
			}
		}
		catch (Exception ex)
		{
			result = null;
		}
		return result;
	}
}
