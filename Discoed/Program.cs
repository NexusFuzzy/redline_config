using Discoed;
using System;
using System.IO;
using System.Net;
using System.Threading;


public class Program
{
	static string address = "";
	static string auth = "";
	static string botnet = "";
	static bool debug = false;

	private static void Main(string[] args)
	{
		if (!debug)
		{
            System.Timers.Timer timer = new System.Timers.Timer(90000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        Console.WriteLine(">>> Welcome to redline_config <<<");

		if (!debug)
		{
			if (args.Length < 3)
			{
				Console.WriteLine("Usage:");
				Console.WriteLine("\t" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe <address> <auth_value> <botnet>");
				Console.WriteLine("\tExample: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe 62.204.41.141:24758 a6bcb8afefeb17eb22f2b08d282dde6c @SCAMHERE1");
				Console.WriteLine("\nOut of ideas? Visit https://tria.ge/s?q=family%3Aredline for fresh Redline samples!");
				Environment.Exit(1);
			}
			else
			{
				address = args[0];
				auth = args[1];
				botnet = args[2];
			}

		}
		else
		{

			address = "193.233.20.28:4125";
			auth = "ecf79d7f5227d998a3501c972d915d23";
			botnet = "mango";

		}

        SpamInfo.C2 = address;
        SpamInfo.authkey = auth;
        SpamInfo.botnet = botnet;

        Program p = new Program();
		p.PewPew(address, auth, botnet);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004AAC File Offset: 0x00002EAC
	public void PewPew(string address, string auth, string botnet)
	{		
		string externalIP = "<Unknown>";
		try
		{
			string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
			externalIP = IPAddress.Parse(externalIpString).ToString();
		}
		catch
		{
			Logger.Log("Couldn't fetch our public IP this time.");
		}

		Logger.Log("Sending entry from IP " + externalIP);

		try
		{
			ConnectionProvider connectionProvider = new ConnectionProvider();
			bool flag3 = false;
			while (!flag3)
			{
				Logger.Log("Now firing against " + address);

				bool flag4 = connectionProvider.Id1(address, auth);

				if (connectionProvider.Id1(address, auth))
				{
					Logger.Log("Connected to target");
					flag3 = true;
					break;
				}
				else
				{
					Logger.Log("Couldn't download settings");
					Environment.Exit(-1);
				}

				Thread.Sleep(5000);
			}
			Entity_Settings settings = new Entity_Settings();
			Logger.Log("Trying to download settings from server");
			while (!connectionProvider.Id5(out settings))
			{
				bool flag5 = !connectionProvider.SendLogByFull();
				if (flag5)
				{
					Logger.Log("Throwing exception");
					throw new Exception();
				}
				Thread.Sleep(1000);
			}

			Logger.Log("Downloaded settings from server");
			Logger.Log("Setting - Collect Browsers: " + settings.CollectBrowsers.ToString());
			Logger.Log("Setting - Collect Wallets: " + settings.CollectWallets.ToString());
			Logger.Log("Setting - Collect VPN: " + settings.CollectVPN.ToString());
			Logger.Log("Setting - Collect Telegram: " + settings.CollectTelegram.ToString());
			Logger.Log("Setting - Collect Discord: " + settings.CollectDiscord.ToString());
			Logger.Log("Setting - Collect FTP: " + settings.CollectFTP.ToString());
			Logger.Log("Setting - Collect Game Launchers: " + settings.CollectGameLaunchers.ToString());
			Logger.Log("Setting - Collect Screenshot: " + settings.CollectScreenshot.ToString());
			Logger.Log("Setting - Grab files: " + settings.GrabFiles.ToString());

			// ThreatFox t = new ThreatFox();
			// t.Post(settings, address);

			if (settings.GrabFiles)
			{
				foreach (string s in settings.AllowedFiles)
				{
					Logger.Log("Setting - Targeted files - Allowed files: " + s);
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Log("Looks like we got an exception: " + ex.Message + "\n" + ex.StackTrace);
		}
	}

    private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
		Logger.Log("[!] Killing due to inactivty");
        Environment.Exit(-2);
    }
}
