
namespace Mahou
{
	partial class MahouUI
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tab_functions;
		private System.Windows.Forms.TabPage tab_layouts;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.TabPage tab_appearence;
		private System.Windows.Forms.TabPage tab_snippets;
		private System.Windows.Forms.TabPage tab_hotkeys;
		private System.Windows.Forms.TabPage tab_updates;
		private System.Windows.Forms.TabPage tab_about;
		private System.Windows.Forms.CheckBox chk_Logging;
		private System.Windows.Forms.CheckBox chk_StartupUpdatesCheck;
		private System.Windows.Forms.CheckBox chk_HighlightScroll;
		private System.Windows.Forms.CheckBox chk_CSLayoutSwitchingPlus;
		private System.Windows.Forms.CheckBox chk_AddOneSpace;
		private System.Windows.Forms.CheckBox chk_RePress;
		private System.Windows.Forms.CheckBox chk_ReSelect;
		private System.Windows.Forms.CheckBox chk_CSLayoutSwitching;
		private System.Windows.Forms.CheckBox chk_TrayIcon;
		private System.Windows.Forms.CheckBox chk_AutoStart;
		private System.Windows.Forms.Label lbl_EmuType;
		private System.Windows.Forms.ComboBox cbb_EmulateType;
		private System.Windows.Forms.TabPage tab_timings;
		private System.Windows.Forms.Label lbl_Arrow4;
		private System.Windows.Forms.Label lbl_Arrow3;
		private System.Windows.Forms.Label lbl_Arrow2;
		private System.Windows.Forms.Label lbl_Arrow1;
		private System.Windows.Forms.GroupBox grb_Layouts;
		public System.Windows.Forms.ComboBox cbb_Layout4;
		public System.Windows.Forms.ComboBox cbb_Layout3;
		public System.Windows.Forms.ComboBox cbb_Layout2;
		public System.Windows.Forms.ComboBox cbb_Layout1;
		private System.Windows.Forms.CheckBox chk_SpecificLS;
		private System.Windows.Forms.GroupBox grb_Keys;
		public System.Windows.Forms.ComboBox cbb_Key4;
		public System.Windows.Forms.ComboBox cbb_Key3;
		public System.Windows.Forms.ComboBox cbb_Key2;
		public System.Windows.Forms.ComboBox cbb_Key1;
		private System.Windows.Forms.CheckBox chk_EmulateLS;
		private System.Windows.Forms.Label lbl_LayoutNum2;
		public System.Windows.Forms.ComboBox cbb_MainLayout2;
		private System.Windows.Forms.Label lbl_LayoutNum1;
		public System.Windows.Forms.ComboBox cbb_MainLayout1;
		private System.Windows.Forms.CheckBox chk_SwitchBetweenLayouts;
		private System.Windows.Forms.GroupBox grb_LangTTAppearence;
		private System.Windows.Forms.GroupBox grb_LangTTSize;
		private System.Windows.Forms.Label lbl_LangTTHeight;
		private System.Windows.Forms.Label lbl_LangTTBackgroundColor;
		private System.Windows.Forms.Label lbl_LangTTForegroundColor;
		private System.Windows.Forms.CheckBox chk_LangTTTransparentColor;
		private System.Windows.Forms.Button btn_LangTTBackgroundColor;
		private System.Windows.Forms.Button btn_LangTTForegroundColor;
		private System.Windows.Forms.ListBox lsb_LangTTAppearenceForList;
		private System.Windows.Forms.CheckBox chk_LangTooltipCaret;
		private System.Windows.Forms.CheckBox chk_LangTooltipMouse;
		private System.Windows.Forms.GroupBox grb_LangTTPositon;
		private System.Windows.Forms.NumericUpDown nud_LangTTPositionY;
		private System.Windows.Forms.Label lbl_LangTTPositionY;
		private System.Windows.Forms.NumericUpDown nud_LangTTPositionX;
		private System.Windows.Forms.Label lbl_LangTTPositionX;
		private System.Windows.Forms.NumericUpDown nud_LangTTWidth;
		private System.Windows.Forms.Label lbl_LangTTWidth;
		private System.Windows.Forms.NumericUpDown nud_LangTTHeight;
		private System.Windows.Forms.Button btn_LangTTFont;
		private System.Windows.Forms.NumericUpDown nud_DoubleHK2ndPressWaitTime;
		private System.Windows.Forms.Label lbl_DoubleHK2ndPressWaitTime;
		private System.Windows.Forms.NumericUpDown nud_LangTTCaretRefreshRate;
		private System.Windows.Forms.Label lbl_LangTTCaretRefreshRate;
		private System.Windows.Forms.NumericUpDown nud_LangTTMouseRefreshRate;
		private System.Windows.Forms.Label lbl_LangTTMouseRefreshRate;
		private System.Windows.Forms.NumericUpDown nud_ScrollLockRefreshRate;
		private System.Windows.Forms.Label lbl_ScrollLockRefreshRate;
		private System.Windows.Forms.NumericUpDown nud_TrayFlagRefreshRate;
		private System.Windows.Forms.Label lbl_FlagTrayRefreshRate;
		private System.Windows.Forms.NumericUpDown nud_CapsLockRefreshRate;
		private System.Windows.Forms.Label lbl_CapsLockRefreshRate;
		private System.Windows.Forms.CheckBox chk_FlagsInTray;
		private System.Windows.Forms.CheckBox chk_CapsLockDTimer;
		private System.Windows.Forms.CheckBox chk_LangTTDiffLayoutColors;
		private System.Windows.Forms.CheckBox chk_LangTTCaretOnChange;
		private System.Windows.Forms.CheckBox chk_LangTTMouseOnChange;
		private System.Windows.Forms.TextBox txt_Snippets;
		private System.Windows.Forms.CheckBox chk_Snippets;
		private System.Windows.Forms.GroupBox grb_Hotkey;
		private System.Windows.Forms.CheckBox chk_DoubleHotkey;
		private System.Windows.Forms.CheckBox chk_HotKeyEnabled;
		private System.Windows.Forms.TextBox txt_Hotkey;
		private System.Windows.Forms.CheckBox chk_WinInHotKey;
		private System.Windows.Forms.ListBox lsb_Hotkeys;
		private System.Windows.Forms.GroupBox grb_DownloadUpdate;
		private System.Windows.Forms.ProgressBar prb_UpdateDownloadProgress;
		private System.Windows.Forms.Button btn_DownloadUpdate;
		private System.Windows.Forms.GroupBox grb_ProxyConfig;
		private System.Windows.Forms.TextBox txt_ProxyPassword;
		private System.Windows.Forms.Label lbl_ProxyPassword;
		private System.Windows.Forms.TextBox txt_ProxyLogin;
		private System.Windows.Forms.Label lbl_ProxyLogin;
		private System.Windows.Forms.TextBox txt_ProxyServerPort;
		private System.Windows.Forms.Label lbl_ProxyServerPort;
		private System.Windows.Forms.GroupBox grb_MahouReleaseTitle;
		private System.Windows.Forms.TextBox txt_UpdateDetails;
		private System.Windows.Forms.Button btn_CheckForUpdates;
		private System.Windows.Forms.LinkLabel lnk_Releases;
		private System.Windows.Forms.LinkLabel lnk_Email;
		private System.Windows.Forms.LinkLabel lnk_Wiki;
		private System.Windows.Forms.LinkLabel lnk_Site;
		private System.Windows.Forms.LinkLabel lnk_Repository;
		private System.Windows.Forms.TextBox txt_Help;
		private System.Windows.Forms.Button btn_DebugInfo;
		private System.Windows.Forms.CheckBox chk_BlockHKWithCtrl;
		private System.Windows.Forms.NumericUpDown nud_SelectedTextGetTriesCount;
		private System.Windows.Forms.CheckBox chk_SelectedTextGetMoreTries;
		private System.Windows.Forms.ComboBox cbb_Language;
		private System.Windows.Forms.Label lbl_Language;
		private System.Windows.Forms.ToolTip HelpMeUnderstand;
		private System.Windows.Forms.Label lbl_HotkeyHelp;
		private System.Windows.Forms.Label lbl_ExcludedPrograms;
		private System.Windows.Forms.TextBox txt_ExcludedPrograms;
		private System.Windows.Forms.LinkLabel lnk_plugin;
		private System.Windows.Forms.CheckBox chk_MCDS_support;
		private System.Windows.Forms.TextBox txt_LangTTText;
		private System.Windows.Forms.Label lbl_LangTTText;
		private System.Windows.Forms.CheckBox chk_OneLayoutWholeWord;
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tab_functions = new System.Windows.Forms.TabPage();
			this.chk_OneLayoutWholeWord = new System.Windows.Forms.CheckBox();
			this.lnk_plugin = new System.Windows.Forms.LinkLabel();
			this.chk_MCDS_support = new System.Windows.Forms.CheckBox();
			this.chk_BlockHKWithCtrl = new System.Windows.Forms.CheckBox();
			this.chk_FlagsInTray = new System.Windows.Forms.CheckBox();
			this.chk_CapsLockDTimer = new System.Windows.Forms.CheckBox();
			this.chk_Logging = new System.Windows.Forms.CheckBox();
			this.chk_StartupUpdatesCheck = new System.Windows.Forms.CheckBox();
			this.chk_HighlightScroll = new System.Windows.Forms.CheckBox();
			this.chk_CSLayoutSwitchingPlus = new System.Windows.Forms.CheckBox();
			this.chk_AddOneSpace = new System.Windows.Forms.CheckBox();
			this.chk_RePress = new System.Windows.Forms.CheckBox();
			this.chk_ReSelect = new System.Windows.Forms.CheckBox();
			this.chk_CSLayoutSwitching = new System.Windows.Forms.CheckBox();
			this.chk_TrayIcon = new System.Windows.Forms.CheckBox();
			this.chk_AutoStart = new System.Windows.Forms.CheckBox();
			this.tab_layouts = new System.Windows.Forms.TabPage();
			this.lbl_Arrow4 = new System.Windows.Forms.Label();
			this.lbl_Arrow3 = new System.Windows.Forms.Label();
			this.lbl_Arrow2 = new System.Windows.Forms.Label();
			this.lbl_Arrow1 = new System.Windows.Forms.Label();
			this.grb_Layouts = new System.Windows.Forms.GroupBox();
			this.cbb_Layout4 = new System.Windows.Forms.ComboBox();
			this.cbb_Layout3 = new System.Windows.Forms.ComboBox();
			this.cbb_Layout2 = new System.Windows.Forms.ComboBox();
			this.cbb_Layout1 = new System.Windows.Forms.ComboBox();
			this.chk_SpecificLS = new System.Windows.Forms.CheckBox();
			this.grb_Keys = new System.Windows.Forms.GroupBox();
			this.cbb_Key4 = new System.Windows.Forms.ComboBox();
			this.cbb_Key3 = new System.Windows.Forms.ComboBox();
			this.cbb_Key2 = new System.Windows.Forms.ComboBox();
			this.cbb_Key1 = new System.Windows.Forms.ComboBox();
			this.lbl_EmuType = new System.Windows.Forms.Label();
			this.cbb_EmulateType = new System.Windows.Forms.ComboBox();
			this.chk_EmulateLS = new System.Windows.Forms.CheckBox();
			this.lbl_LayoutNum2 = new System.Windows.Forms.Label();
			this.cbb_MainLayout2 = new System.Windows.Forms.ComboBox();
			this.lbl_LayoutNum1 = new System.Windows.Forms.Label();
			this.cbb_MainLayout1 = new System.Windows.Forms.ComboBox();
			this.chk_SwitchBetweenLayouts = new System.Windows.Forms.CheckBox();
			this.tab_appearence = new System.Windows.Forms.TabPage();
			this.cbb_Language = new System.Windows.Forms.ComboBox();
			this.lbl_Language = new System.Windows.Forms.Label();
			this.chk_LangTTDiffLayoutColors = new System.Windows.Forms.CheckBox();
			this.chk_LangTTCaretOnChange = new System.Windows.Forms.CheckBox();
			this.chk_LangTTMouseOnChange = new System.Windows.Forms.CheckBox();
			this.grb_LangTTAppearence = new System.Windows.Forms.GroupBox();
			this.txt_LangTTText = new System.Windows.Forms.TextBox();
			this.lbl_LangTTText = new System.Windows.Forms.Label();
			this.btn_LangTTFont = new System.Windows.Forms.Button();
			this.grb_LangTTPositon = new System.Windows.Forms.GroupBox();
			this.nud_LangTTPositionY = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTPositionY = new System.Windows.Forms.Label();
			this.nud_LangTTPositionX = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTPositionX = new System.Windows.Forms.Label();
			this.grb_LangTTSize = new System.Windows.Forms.GroupBox();
			this.nud_LangTTWidth = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTWidth = new System.Windows.Forms.Label();
			this.nud_LangTTHeight = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTHeight = new System.Windows.Forms.Label();
			this.lbl_LangTTBackgroundColor = new System.Windows.Forms.Label();
			this.lbl_LangTTForegroundColor = new System.Windows.Forms.Label();
			this.chk_LangTTTransparentColor = new System.Windows.Forms.CheckBox();
			this.btn_LangTTBackgroundColor = new System.Windows.Forms.Button();
			this.btn_LangTTForegroundColor = new System.Windows.Forms.Button();
			this.lsb_LangTTAppearenceForList = new System.Windows.Forms.ListBox();
			this.chk_LangTooltipCaret = new System.Windows.Forms.CheckBox();
			this.chk_LangTooltipMouse = new System.Windows.Forms.CheckBox();
			this.tab_timings = new System.Windows.Forms.TabPage();
			this.lbl_ExcludedPrograms = new System.Windows.Forms.Label();
			this.txt_ExcludedPrograms = new System.Windows.Forms.TextBox();
			this.nud_SelectedTextGetTriesCount = new System.Windows.Forms.NumericUpDown();
			this.chk_SelectedTextGetMoreTries = new System.Windows.Forms.CheckBox();
			this.nud_CapsLockRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_CapsLockRefreshRate = new System.Windows.Forms.Label();
			this.nud_ScrollLockRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_ScrollLockRefreshRate = new System.Windows.Forms.Label();
			this.nud_TrayFlagRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_FlagTrayRefreshRate = new System.Windows.Forms.Label();
			this.nud_DoubleHK2ndPressWaitTime = new System.Windows.Forms.NumericUpDown();
			this.lbl_DoubleHK2ndPressWaitTime = new System.Windows.Forms.Label();
			this.nud_LangTTCaretRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTCaretRefreshRate = new System.Windows.Forms.Label();
			this.nud_LangTTMouseRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.lbl_LangTTMouseRefreshRate = new System.Windows.Forms.Label();
			this.tab_snippets = new System.Windows.Forms.TabPage();
			this.txt_Snippets = new System.Windows.Forms.TextBox();
			this.chk_Snippets = new System.Windows.Forms.CheckBox();
			this.tab_hotkeys = new System.Windows.Forms.TabPage();
			this.grb_Hotkey = new System.Windows.Forms.GroupBox();
			this.lbl_HotkeyHelp = new System.Windows.Forms.Label();
			this.chk_DoubleHotkey = new System.Windows.Forms.CheckBox();
			this.chk_HotKeyEnabled = new System.Windows.Forms.CheckBox();
			this.txt_Hotkey = new System.Windows.Forms.TextBox();
			this.chk_WinInHotKey = new System.Windows.Forms.CheckBox();
			this.lsb_Hotkeys = new System.Windows.Forms.ListBox();
			this.tab_updates = new System.Windows.Forms.TabPage();
			this.grb_DownloadUpdate = new System.Windows.Forms.GroupBox();
			this.prb_UpdateDownloadProgress = new System.Windows.Forms.ProgressBar();
			this.btn_DownloadUpdate = new System.Windows.Forms.Button();
			this.grb_ProxyConfig = new System.Windows.Forms.GroupBox();
			this.txt_ProxyPassword = new System.Windows.Forms.TextBox();
			this.lbl_ProxyPassword = new System.Windows.Forms.Label();
			this.txt_ProxyLogin = new System.Windows.Forms.TextBox();
			this.lbl_ProxyLogin = new System.Windows.Forms.Label();
			this.txt_ProxyServerPort = new System.Windows.Forms.TextBox();
			this.lbl_ProxyServerPort = new System.Windows.Forms.Label();
			this.grb_MahouReleaseTitle = new System.Windows.Forms.GroupBox();
			this.txt_UpdateDetails = new System.Windows.Forms.TextBox();
			this.btn_CheckForUpdates = new System.Windows.Forms.Button();
			this.tab_about = new System.Windows.Forms.TabPage();
			this.btn_DebugInfo = new System.Windows.Forms.Button();
			this.txt_Help = new System.Windows.Forms.TextBox();
			this.lnk_Releases = new System.Windows.Forms.LinkLabel();
			this.lnk_Email = new System.Windows.Forms.LinkLabel();
			this.lnk_Wiki = new System.Windows.Forms.LinkLabel();
			this.lnk_Site = new System.Windows.Forms.LinkLabel();
			this.lnk_Repository = new System.Windows.Forms.LinkLabel();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.HelpMeUnderstand = new System.Windows.Forms.ToolTip(this.components);
			this.tabs.SuspendLayout();
			this.tab_functions.SuspendLayout();
			this.tab_layouts.SuspendLayout();
			this.grb_Layouts.SuspendLayout();
			this.grb_Keys.SuspendLayout();
			this.tab_appearence.SuspendLayout();
			this.grb_LangTTAppearence.SuspendLayout();
			this.grb_LangTTPositon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTPositionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTPositionX)).BeginInit();
			this.grb_LangTTSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTHeight)).BeginInit();
			this.tab_timings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_SelectedTextGetTriesCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_CapsLockRefreshRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_ScrollLockRefreshRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_TrayFlagRefreshRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_DoubleHK2ndPressWaitTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTCaretRefreshRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTMouseRefreshRate)).BeginInit();
			this.tab_snippets.SuspendLayout();
			this.tab_hotkeys.SuspendLayout();
			this.grb_Hotkey.SuspendLayout();
			this.tab_updates.SuspendLayout();
			this.grb_DownloadUpdate.SuspendLayout();
			this.grb_ProxyConfig.SuspendLayout();
			this.grb_MahouReleaseTitle.SuspendLayout();
			this.tab_about.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tab_functions);
			this.tabs.Controls.Add(this.tab_layouts);
			this.tabs.Controls.Add(this.tab_appearence);
			this.tabs.Controls.Add(this.tab_timings);
			this.tabs.Controls.Add(this.tab_snippets);
			this.tabs.Controls.Add(this.tab_hotkeys);
			this.tabs.Controls.Add(this.tab_updates);
			this.tabs.Controls.Add(this.tab_about);
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(567, 301);
			this.tabs.TabIndex = 0;
			// 
			// tab_functions
			// 
			this.tab_functions.Controls.Add(this.chk_OneLayoutWholeWord);
			this.tab_functions.Controls.Add(this.lnk_plugin);
			this.tab_functions.Controls.Add(this.chk_MCDS_support);
			this.tab_functions.Controls.Add(this.chk_BlockHKWithCtrl);
			this.tab_functions.Controls.Add(this.chk_FlagsInTray);
			this.tab_functions.Controls.Add(this.chk_CapsLockDTimer);
			this.tab_functions.Controls.Add(this.chk_Logging);
			this.tab_functions.Controls.Add(this.chk_StartupUpdatesCheck);
			this.tab_functions.Controls.Add(this.chk_HighlightScroll);
			this.tab_functions.Controls.Add(this.chk_CSLayoutSwitchingPlus);
			this.tab_functions.Controls.Add(this.chk_AddOneSpace);
			this.tab_functions.Controls.Add(this.chk_RePress);
			this.tab_functions.Controls.Add(this.chk_ReSelect);
			this.tab_functions.Controls.Add(this.chk_CSLayoutSwitching);
			this.tab_functions.Controls.Add(this.chk_TrayIcon);
			this.tab_functions.Controls.Add(this.chk_AutoStart);
			this.tab_functions.Location = new System.Drawing.Point(4, 24);
			this.tab_functions.Name = "tab_functions";
			this.tab_functions.Padding = new System.Windows.Forms.Padding(3);
			this.tab_functions.Size = new System.Drawing.Size(559, 273);
			this.tab_functions.TabIndex = 0;
			this.tab_functions.Text = "Functions";
			this.tab_functions.UseVisualStyleBackColor = true;
			// 
			// chk_OneLayoutWholeWord
			// 
			this.chk_OneLayoutWholeWord.AutoSize = true;
			this.chk_OneLayoutWholeWord.Location = new System.Drawing.Point(302, 116);
			this.chk_OneLayoutWholeWord.Name = "chk_OneLayoutWholeWord";
			this.chk_OneLayoutWholeWord.Size = new System.Drawing.Size(220, 19);
			this.chk_OneLayoutWholeWord.TabIndex = 15;
			this.chk_OneLayoutWholeWord.Text = "Use one layout for whole word in CS.";
			this.chk_OneLayoutWholeWord.UseVisualStyleBackColor = true;
			this.chk_OneLayoutWholeWord.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// lnk_plugin
			// 
			this.lnk_plugin.AutoSize = true;
			this.lnk_plugin.Location = new System.Drawing.Point(493, 92);
			this.lnk_plugin.Name = "lnk_plugin";
			this.lnk_plugin.Size = new System.Drawing.Size(63, 15);
			this.lnk_plugin.TabIndex = 14;
			this.lnk_plugin.TabStop = true;
			this.lnk_plugin.Text = "ST3 plugin";
			this.lnk_plugin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_pluginLinkClicked);
			// 
			// chk_MCDS_support
			// 
			this.chk_MCDS_support.AutoSize = true;
			this.chk_MCDS_support.Location = new System.Drawing.Point(302, 91);
			this.chk_MCDS_support.Name = "chk_MCDS_support";
			this.chk_MCDS_support.Size = new System.Drawing.Size(144, 19);
			this.chk_MCDS_support.TabIndex = 13;
			this.chk_MCDS_support.Text = "Enable MCDS support.";
			this.chk_MCDS_support.UseVisualStyleBackColor = true;
			// 
			// chk_BlockHKWithCtrl
			// 
			this.chk_BlockHKWithCtrl.AutoSize = true;
			this.chk_BlockHKWithCtrl.Location = new System.Drawing.Point(8, 216);
			this.chk_BlockHKWithCtrl.Name = "chk_BlockHKWithCtrl";
			this.chk_BlockHKWithCtrl.Size = new System.Drawing.Size(191, 19);
			this.chk_BlockHKWithCtrl.TabIndex = 12;
			this.chk_BlockHKWithCtrl.Text = "Block Mahou hotkeys with Ctrl.";
			this.chk_BlockHKWithCtrl.UseVisualStyleBackColor = true;
			// 
			// chk_FlagsInTray
			// 
			this.chk_FlagsInTray.AutoSize = true;
			this.chk_FlagsInTray.Location = new System.Drawing.Point(302, 41);
			this.chk_FlagsInTray.Name = "chk_FlagsInTray";
			this.chk_FlagsInTray.Size = new System.Drawing.Size(201, 19);
			this.chk_FlagsInTray.TabIndex = 11;
			this.chk_FlagsInTray.Text = "Display country flags in tray icon.";
			this.chk_FlagsInTray.UseVisualStyleBackColor = true;
			// 
			// chk_CapsLockDTimer
			// 
			this.chk_CapsLockDTimer.AutoSize = true;
			this.chk_CapsLockDTimer.Location = new System.Drawing.Point(302, 16);
			this.chk_CapsLockDTimer.Name = "chk_CapsLockDTimer";
			this.chk_CapsLockDTimer.Size = new System.Drawing.Size(204, 19);
			this.chk_CapsLockDTimer.TabIndex = 10;
			this.chk_CapsLockDTimer.Text = "Activate Caps Lock disabler timer.";
			this.chk_CapsLockDTimer.UseVisualStyleBackColor = true;
			this.chk_CapsLockDTimer.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// chk_Logging
			// 
			this.chk_Logging.AutoSize = true;
			this.chk_Logging.Location = new System.Drawing.Point(8, 241);
			this.chk_Logging.Name = "chk_Logging";
			this.chk_Logging.Size = new System.Drawing.Size(187, 19);
			this.chk_Logging.TabIndex = 9;
			this.chk_Logging.Text = "Enable logging for debugging.";
			this.chk_Logging.UseVisualStyleBackColor = true;
			// 
			// chk_StartupUpdatesCheck
			// 
			this.chk_StartupUpdatesCheck.AutoSize = true;
			this.chk_StartupUpdatesCheck.Location = new System.Drawing.Point(302, 66);
			this.chk_StartupUpdatesCheck.Name = "chk_StartupUpdatesCheck";
			this.chk_StartupUpdatesCheck.Size = new System.Drawing.Size(178, 19);
			this.chk_StartupUpdatesCheck.TabIndex = 8;
			this.chk_StartupUpdatesCheck.Text = "Check for updates at startup.";
			this.chk_StartupUpdatesCheck.UseVisualStyleBackColor = true;
			// 
			// chk_HighlightScroll
			// 
			this.chk_HighlightScroll.AutoSize = true;
			this.chk_HighlightScroll.Location = new System.Drawing.Point(8, 191);
			this.chk_HighlightScroll.Name = "chk_HighlightScroll";
			this.chk_HighlightScroll.Size = new System.Drawing.Size(263, 19);
			this.chk_HighlightScroll.TabIndex = 7;
			this.chk_HighlightScroll.Text = "Highlight Scroll-Lock when layout 1 is active.";
			this.chk_HighlightScroll.UseVisualStyleBackColor = true;
			this.chk_HighlightScroll.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// chk_CSLayoutSwitchingPlus
			// 
			this.chk_CSLayoutSwitchingPlus.AutoSize = true;
			this.chk_CSLayoutSwitchingPlus.Location = new System.Drawing.Point(8, 166);
			this.chk_CSLayoutSwitchingPlus.Name = "chk_CSLayoutSwitchingPlus";
			this.chk_CSLayoutSwitchingPlus.Size = new System.Drawing.Size(298, 19);
			this.chk_CSLayoutSwitchingPlus.TabIndex = 6;
			this.chk_CSLayoutSwitchingPlus.Text = "Convert selection layout switching+ (experimental).";
			this.chk_CSLayoutSwitchingPlus.UseVisualStyleBackColor = true;
			// 
			// chk_AddOneSpace
			// 
			this.chk_AddOneSpace.AutoSize = true;
			this.chk_AddOneSpace.Location = new System.Drawing.Point(8, 141);
			this.chk_AddOneSpace.Name = "chk_AddOneSpace";
			this.chk_AddOneSpace.Size = new System.Drawing.Size(172, 19);
			this.chk_AddOneSpace.TabIndex = 5;
			this.chk_AddOneSpace.Text = "Add one space to last word.";
			this.chk_AddOneSpace.UseVisualStyleBackColor = true;
			// 
			// chk_RePress
			// 
			this.chk_RePress.AutoSize = true;
			this.chk_RePress.Location = new System.Drawing.Point(8, 116);
			this.chk_RePress.Name = "chk_RePress";
			this.chk_RePress.Size = new System.Drawing.Size(229, 19);
			this.chk_RePress.TabIndex = 4;
			this.chk_RePress.Text = "Re-press modifiers after hotkey action.";
			this.chk_RePress.UseVisualStyleBackColor = true;
			// 
			// chk_ReSelect
			// 
			this.chk_ReSelect.AutoSize = true;
			this.chk_ReSelect.Location = new System.Drawing.Point(8, 91);
			this.chk_ReSelect.Name = "chk_ReSelect";
			this.chk_ReSelect.Size = new System.Drawing.Size(219, 19);
			this.chk_ReSelect.TabIndex = 3;
			this.chk_ReSelect.Text = "Re-select text after convert selection.";
			this.chk_ReSelect.UseVisualStyleBackColor = true;
			// 
			// chk_CSLayoutSwitching
			// 
			this.chk_CSLayoutSwitching.AutoSize = true;
			this.chk_CSLayoutSwitching.Location = new System.Drawing.Point(8, 66);
			this.chk_CSLayoutSwitching.Name = "chk_CSLayoutSwitching";
			this.chk_CSLayoutSwitching.Size = new System.Drawing.Size(211, 19);
			this.chk_CSLayoutSwitching.TabIndex = 2;
			this.chk_CSLayoutSwitching.Text = "Convert selection layout switching.";
			this.chk_CSLayoutSwitching.UseVisualStyleBackColor = true;
			this.chk_CSLayoutSwitching.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// chk_TrayIcon
			// 
			this.chk_TrayIcon.AutoSize = true;
			this.chk_TrayIcon.Location = new System.Drawing.Point(8, 41);
			this.chk_TrayIcon.Name = "chk_TrayIcon";
			this.chk_TrayIcon.Size = new System.Drawing.Size(107, 19);
			this.chk_TrayIcon.TabIndex = 1;
			this.chk_TrayIcon.Text = "Show tray icon.";
			this.chk_TrayIcon.UseVisualStyleBackColor = true;
			// 
			// chk_AutoStart
			// 
			this.chk_AutoStart.AutoSize = true;
			this.chk_AutoStart.Location = new System.Drawing.Point(8, 16);
			this.chk_AutoStart.Name = "chk_AutoStart";
			this.chk_AutoStart.Size = new System.Drawing.Size(131, 19);
			this.chk_AutoStart.TabIndex = 0;
			this.chk_AutoStart.Text = "Start with Windows.";
			this.chk_AutoStart.UseVisualStyleBackColor = true;
			this.chk_AutoStart.CheckedChanged += new System.EventHandler(this.Chk_AutoStartCheckedChanged);
			// 
			// tab_layouts
			// 
			this.tab_layouts.Controls.Add(this.lbl_Arrow4);
			this.tab_layouts.Controls.Add(this.lbl_Arrow3);
			this.tab_layouts.Controls.Add(this.lbl_Arrow2);
			this.tab_layouts.Controls.Add(this.lbl_Arrow1);
			this.tab_layouts.Controls.Add(this.grb_Layouts);
			this.tab_layouts.Controls.Add(this.chk_SpecificLS);
			this.tab_layouts.Controls.Add(this.grb_Keys);
			this.tab_layouts.Controls.Add(this.lbl_EmuType);
			this.tab_layouts.Controls.Add(this.cbb_EmulateType);
			this.tab_layouts.Controls.Add(this.chk_EmulateLS);
			this.tab_layouts.Controls.Add(this.lbl_LayoutNum2);
			this.tab_layouts.Controls.Add(this.cbb_MainLayout2);
			this.tab_layouts.Controls.Add(this.lbl_LayoutNum1);
			this.tab_layouts.Controls.Add(this.cbb_MainLayout1);
			this.tab_layouts.Controls.Add(this.chk_SwitchBetweenLayouts);
			this.tab_layouts.Location = new System.Drawing.Point(4, 24);
			this.tab_layouts.Name = "tab_layouts";
			this.tab_layouts.Padding = new System.Windows.Forms.Padding(3);
			this.tab_layouts.Size = new System.Drawing.Size(559, 273);
			this.tab_layouts.TabIndex = 1;
			this.tab_layouts.Text = "Layouts";
			this.tab_layouts.UseVisualStyleBackColor = true;
			// 
			// lbl_Arrow4
			// 
			this.lbl_Arrow4.AutoSize = true;
			this.lbl_Arrow4.Location = new System.Drawing.Point(272, 232);
			this.lbl_Arrow4.Name = "lbl_Arrow4";
			this.lbl_Arrow4.Size = new System.Drawing.Size(20, 15);
			this.lbl_Arrow4.TabIndex = 16;
			this.lbl_Arrow4.Text = "->";
			// 
			// lbl_Arrow3
			// 
			this.lbl_Arrow3.AutoSize = true;
			this.lbl_Arrow3.Location = new System.Drawing.Point(272, 203);
			this.lbl_Arrow3.Name = "lbl_Arrow3";
			this.lbl_Arrow3.Size = new System.Drawing.Size(20, 15);
			this.lbl_Arrow3.TabIndex = 15;
			this.lbl_Arrow3.Text = "->";
			// 
			// lbl_Arrow2
			// 
			this.lbl_Arrow2.AutoSize = true;
			this.lbl_Arrow2.Location = new System.Drawing.Point(272, 174);
			this.lbl_Arrow2.Name = "lbl_Arrow2";
			this.lbl_Arrow2.Size = new System.Drawing.Size(20, 15);
			this.lbl_Arrow2.TabIndex = 14;
			this.lbl_Arrow2.Text = "->";
			// 
			// lbl_Arrow1
			// 
			this.lbl_Arrow1.AutoSize = true;
			this.lbl_Arrow1.Location = new System.Drawing.Point(272, 145);
			this.lbl_Arrow1.Name = "lbl_Arrow1";
			this.lbl_Arrow1.Size = new System.Drawing.Size(20, 15);
			this.lbl_Arrow1.TabIndex = 1;
			this.lbl_Arrow1.Text = "->";
			// 
			// grb_Layouts
			// 
			this.grb_Layouts.Controls.Add(this.cbb_Layout4);
			this.grb_Layouts.Controls.Add(this.cbb_Layout3);
			this.grb_Layouts.Controls.Add(this.cbb_Layout2);
			this.grb_Layouts.Controls.Add(this.cbb_Layout1);
			this.grb_Layouts.Location = new System.Drawing.Point(294, 113);
			this.grb_Layouts.Name = "grb_Layouts";
			this.grb_Layouts.Size = new System.Drawing.Size(262, 154);
			this.grb_Layouts.TabIndex = 12;
			this.grb_Layouts.TabStop = false;
			this.grb_Layouts.Text = "Layouts";
			// 
			// cbb_Layout4
			// 
			this.cbb_Layout4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Layout4.FormattingEnabled = true;
			this.cbb_Layout4.Location = new System.Drawing.Point(6, 115);
			this.cbb_Layout4.Name = "cbb_Layout4";
			this.cbb_Layout4.Size = new System.Drawing.Size(250, 23);
			this.cbb_Layout4.TabIndex = 7;
			// 
			// cbb_Layout3
			// 
			this.cbb_Layout3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Layout3.FormattingEnabled = true;
			this.cbb_Layout3.Location = new System.Drawing.Point(6, 86);
			this.cbb_Layout3.Name = "cbb_Layout3";
			this.cbb_Layout3.Size = new System.Drawing.Size(250, 23);
			this.cbb_Layout3.TabIndex = 6;
			// 
			// cbb_Layout2
			// 
			this.cbb_Layout2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Layout2.FormattingEnabled = true;
			this.cbb_Layout2.Location = new System.Drawing.Point(6, 57);
			this.cbb_Layout2.Name = "cbb_Layout2";
			this.cbb_Layout2.Size = new System.Drawing.Size(250, 23);
			this.cbb_Layout2.TabIndex = 5;
			// 
			// cbb_Layout1
			// 
			this.cbb_Layout1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Layout1.FormattingEnabled = true;
			this.cbb_Layout1.Location = new System.Drawing.Point(6, 28);
			this.cbb_Layout1.Name = "cbb_Layout1";
			this.cbb_Layout1.Size = new System.Drawing.Size(250, 23);
			this.cbb_Layout1.TabIndex = 4;
			// 
			// chk_SpecificLS
			// 
			this.chk_SpecificLS.AutoSize = true;
			this.chk_SpecificLS.Location = new System.Drawing.Point(8, 88);
			this.chk_SpecificLS.Name = "chk_SpecificLS";
			this.chk_SpecificLS.Size = new System.Drawing.Size(205, 19);
			this.chk_SpecificLS.TabIndex = 13;
			this.chk_SpecificLS.Text = "Change to specific layout by keys:";
			this.chk_SpecificLS.UseVisualStyleBackColor = true;
			this.chk_SpecificLS.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// grb_Keys
			// 
			this.grb_Keys.Controls.Add(this.cbb_Key4);
			this.grb_Keys.Controls.Add(this.cbb_Key3);
			this.grb_Keys.Controls.Add(this.cbb_Key2);
			this.grb_Keys.Controls.Add(this.cbb_Key1);
			this.grb_Keys.Location = new System.Drawing.Point(6, 113);
			this.grb_Keys.Name = "grb_Keys";
			this.grb_Keys.Size = new System.Drawing.Size(262, 154);
			this.grb_Keys.TabIndex = 11;
			this.grb_Keys.TabStop = false;
			this.grb_Keys.Text = "Keys";
			// 
			// cbb_Key4
			// 
			this.cbb_Key4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Key4.FormattingEnabled = true;
			this.cbb_Key4.Items.AddRange(new object[] {
			"None",
			"Caps Lock",
			"Left Control",
			"Right Control",
			"Left Shift",
			"Right Shift",
			"Left Alt",
			"Right Alt"});
			this.cbb_Key4.Location = new System.Drawing.Point(6, 115);
			this.cbb_Key4.Name = "cbb_Key4";
			this.cbb_Key4.Size = new System.Drawing.Size(250, 23);
			this.cbb_Key4.TabIndex = 3;
			this.cbb_Key4.SelectedIndexChanged += new System.EventHandler(this.Cbb_KeySelectedIndexChanged);
			// 
			// cbb_Key3
			// 
			this.cbb_Key3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Key3.FormattingEnabled = true;
			this.cbb_Key3.Items.AddRange(new object[] {
			"None",
			"Caps Lock",
			"Left Control",
			"Right Control",
			"Left Shift",
			"Right Shift",
			"Left Alt",
			"Right Alt"});
			this.cbb_Key3.Location = new System.Drawing.Point(6, 86);
			this.cbb_Key3.Name = "cbb_Key3";
			this.cbb_Key3.Size = new System.Drawing.Size(250, 23);
			this.cbb_Key3.TabIndex = 2;
			this.cbb_Key3.SelectedIndexChanged += new System.EventHandler(this.Cbb_KeySelectedIndexChanged);
			// 
			// cbb_Key2
			// 
			this.cbb_Key2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Key2.FormattingEnabled = true;
			this.cbb_Key2.Items.AddRange(new object[] {
			"None",
			"Caps Lock",
			"Left Control",
			"Right Control",
			"Left Shift",
			"Right Shift",
			"Left Alt",
			"Right Alt"});
			this.cbb_Key2.Location = new System.Drawing.Point(6, 57);
			this.cbb_Key2.Name = "cbb_Key2";
			this.cbb_Key2.Size = new System.Drawing.Size(250, 23);
			this.cbb_Key2.TabIndex = 1;
			this.cbb_Key2.SelectedIndexChanged += new System.EventHandler(this.Cbb_KeySelectedIndexChanged);
			// 
			// cbb_Key1
			// 
			this.cbb_Key1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Key1.FormattingEnabled = true;
			this.cbb_Key1.Items.AddRange(new object[] {
			"None",
			"Caps Lock",
			"Left Control",
			"Right Control",
			"Left Shift",
			"Right Shift",
			"Left Alt",
			"Right Alt"});
			this.cbb_Key1.Location = new System.Drawing.Point(6, 28);
			this.cbb_Key1.Name = "cbb_Key1";
			this.cbb_Key1.Size = new System.Drawing.Size(250, 23);
			this.cbb_Key1.TabIndex = 0;
			this.cbb_Key1.SelectedIndexChanged += new System.EventHandler(this.Cbb_KeySelectedIndexChanged);
			// 
			// lbl_EmuType
			// 
			this.lbl_EmuType.AutoSize = true;
			this.lbl_EmuType.Location = new System.Drawing.Point(322, 65);
			this.lbl_EmuType.Name = "lbl_EmuType";
			this.lbl_EmuType.Size = new System.Drawing.Size(90, 15);
			this.lbl_EmuType.TabIndex = 10;
			this.lbl_EmuType.Text = "Emulation type:";
			// 
			// cbb_EmulateType
			// 
			this.cbb_EmulateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_EmulateType.FormattingEnabled = true;
			this.cbb_EmulateType.Items.AddRange(new object[] {
			"Alt+Shift",
			"Ctrl+Shift",
			"Win+Space"});
			this.cbb_EmulateType.Location = new System.Drawing.Point(418, 61);
			this.cbb_EmulateType.Name = "cbb_EmulateType";
			this.cbb_EmulateType.Size = new System.Drawing.Size(131, 23);
			this.cbb_EmulateType.TabIndex = 9;
			// 
			// chk_EmulateLS
			// 
			this.chk_EmulateLS.AutoSize = true;
			this.chk_EmulateLS.Location = new System.Drawing.Point(8, 63);
			this.chk_EmulateLS.Name = "chk_EmulateLS";
			this.chk_EmulateLS.Size = new System.Drawing.Size(162, 19);
			this.chk_EmulateLS.TabIndex = 8;
			this.chk_EmulateLS.Text = "Emulate layout switching.";
			this.chk_EmulateLS.UseVisualStyleBackColor = true;
			this.chk_EmulateLS.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// lbl_LayoutNum2
			// 
			this.lbl_LayoutNum2.AutoSize = true;
			this.lbl_LayoutNum2.Location = new System.Drawing.Point(274, 34);
			this.lbl_LayoutNum2.Name = "lbl_LayoutNum2";
			this.lbl_LayoutNum2.Size = new System.Drawing.Size(20, 15);
			this.lbl_LayoutNum2.TabIndex = 7;
			this.lbl_LayoutNum2.Text = "#2";
			// 
			// cbb_MainLayout2
			// 
			this.cbb_MainLayout2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_MainLayout2.FormattingEnabled = true;
			this.cbb_MainLayout2.Location = new System.Drawing.Point(300, 31);
			this.cbb_MainLayout2.Name = "cbb_MainLayout2";
			this.cbb_MainLayout2.Size = new System.Drawing.Size(249, 23);
			this.cbb_MainLayout2.TabIndex = 6;
			// 
			// lbl_LayoutNum1
			// 
			this.lbl_LayoutNum1.AutoSize = true;
			this.lbl_LayoutNum1.Location = new System.Drawing.Point(8, 34);
			this.lbl_LayoutNum1.Name = "lbl_LayoutNum1";
			this.lbl_LayoutNum1.Size = new System.Drawing.Size(20, 15);
			this.lbl_LayoutNum1.TabIndex = 5;
			this.lbl_LayoutNum1.Text = "#1";
			// 
			// cbb_MainLayout1
			// 
			this.cbb_MainLayout1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_MainLayout1.FormattingEnabled = true;
			this.cbb_MainLayout1.Location = new System.Drawing.Point(34, 31);
			this.cbb_MainLayout1.Name = "cbb_MainLayout1";
			this.cbb_MainLayout1.Size = new System.Drawing.Size(234, 23);
			this.cbb_MainLayout1.TabIndex = 4;
			// 
			// chk_SwitchBetweenLayouts
			// 
			this.chk_SwitchBetweenLayouts.AutoSize = true;
			this.chk_SwitchBetweenLayouts.Location = new System.Drawing.Point(8, 6);
			this.chk_SwitchBetweenLayouts.Name = "chk_SwitchBetweenLayouts";
			this.chk_SwitchBetweenLayouts.Size = new System.Drawing.Size(153, 19);
			this.chk_SwitchBetweenLayouts.TabIndex = 2;
			this.chk_SwitchBetweenLayouts.Text = "Switch between layouts:";
			this.chk_SwitchBetweenLayouts.UseVisualStyleBackColor = true;
			this.chk_SwitchBetweenLayouts.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// tab_appearence
			// 
			this.tab_appearence.Controls.Add(this.cbb_Language);
			this.tab_appearence.Controls.Add(this.lbl_Language);
			this.tab_appearence.Controls.Add(this.chk_LangTTDiffLayoutColors);
			this.tab_appearence.Controls.Add(this.chk_LangTTCaretOnChange);
			this.tab_appearence.Controls.Add(this.chk_LangTTMouseOnChange);
			this.tab_appearence.Controls.Add(this.grb_LangTTAppearence);
			this.tab_appearence.Controls.Add(this.chk_LangTooltipCaret);
			this.tab_appearence.Controls.Add(this.chk_LangTooltipMouse);
			this.tab_appearence.Location = new System.Drawing.Point(4, 24);
			this.tab_appearence.Name = "tab_appearence";
			this.tab_appearence.Padding = new System.Windows.Forms.Padding(3);
			this.tab_appearence.Size = new System.Drawing.Size(559, 273);
			this.tab_appearence.TabIndex = 2;
			this.tab_appearence.Text = "Appearence";
			this.tab_appearence.UseVisualStyleBackColor = true;
			// 
			// cbb_Language
			// 
			this.cbb_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Language.FormattingEnabled = true;
			this.cbb_Language.Items.AddRange(new object[] {
			"Русский",
			"English"});
			this.cbb_Language.Location = new System.Drawing.Point(435, 54);
			this.cbb_Language.Name = "cbb_Language";
			this.cbb_Language.Size = new System.Drawing.Size(117, 23);
			this.cbb_Language.TabIndex = 15;
			// 
			// lbl_Language
			// 
			this.lbl_Language.AutoSize = true;
			this.lbl_Language.Location = new System.Drawing.Point(367, 57);
			this.lbl_Language.Name = "lbl_Language";
			this.lbl_Language.Size = new System.Drawing.Size(62, 15);
			this.lbl_Language.TabIndex = 14;
			this.lbl_Language.Text = "Language:";
			// 
			// chk_LangTTDiffLayoutColors
			// 
			this.chk_LangTTDiffLayoutColors.AutoSize = true;
			this.chk_LangTTDiffLayoutColors.Location = new System.Drawing.Point(8, 56);
			this.chk_LangTTDiffLayoutColors.Name = "chk_LangTTDiffLayoutColors";
			this.chk_LangTTDiffLayoutColors.Size = new System.Drawing.Size(219, 19);
			this.chk_LangTTDiffLayoutColors.TabIndex = 13;
			this.chk_LangTTDiffLayoutColors.Text = "Use different appearence for layouts.";
			this.chk_LangTTDiffLayoutColors.UseVisualStyleBackColor = true;
			// 
			// chk_LangTTCaretOnChange
			// 
			this.chk_LangTTCaretOnChange.AutoSize = true;
			this.chk_LangTTCaretOnChange.Location = new System.Drawing.Point(361, 32);
			this.chk_LangTTCaretOnChange.Name = "chk_LangTTCaretOnChange";
			this.chk_LangTTCaretOnChange.Size = new System.Drawing.Size(188, 19);
			this.chk_LangTTCaretOnChange.TabIndex = 12;
			this.chk_LangTTCaretOnChange.Text = "Display only on layout change.";
			this.chk_LangTTCaretOnChange.UseVisualStyleBackColor = true;
			// 
			// chk_LangTTMouseOnChange
			// 
			this.chk_LangTTMouseOnChange.AutoSize = true;
			this.chk_LangTTMouseOnChange.Location = new System.Drawing.Point(361, 6);
			this.chk_LangTTMouseOnChange.Name = "chk_LangTTMouseOnChange";
			this.chk_LangTTMouseOnChange.Size = new System.Drawing.Size(188, 19);
			this.chk_LangTTMouseOnChange.TabIndex = 11;
			this.chk_LangTTMouseOnChange.Text = "Display only on layout change.";
			this.chk_LangTTMouseOnChange.UseVisualStyleBackColor = true;
			// 
			// grb_LangTTAppearence
			// 
			this.grb_LangTTAppearence.Controls.Add(this.txt_LangTTText);
			this.grb_LangTTAppearence.Controls.Add(this.lbl_LangTTText);
			this.grb_LangTTAppearence.Controls.Add(this.btn_LangTTFont);
			this.grb_LangTTAppearence.Controls.Add(this.grb_LangTTPositon);
			this.grb_LangTTAppearence.Controls.Add(this.grb_LangTTSize);
			this.grb_LangTTAppearence.Controls.Add(this.lbl_LangTTBackgroundColor);
			this.grb_LangTTAppearence.Controls.Add(this.lbl_LangTTForegroundColor);
			this.grb_LangTTAppearence.Controls.Add(this.chk_LangTTTransparentColor);
			this.grb_LangTTAppearence.Controls.Add(this.btn_LangTTBackgroundColor);
			this.grb_LangTTAppearence.Controls.Add(this.btn_LangTTForegroundColor);
			this.grb_LangTTAppearence.Controls.Add(this.lsb_LangTTAppearenceForList);
			this.grb_LangTTAppearence.Location = new System.Drawing.Point(7, 75);
			this.grb_LangTTAppearence.Name = "grb_LangTTAppearence";
			this.grb_LangTTAppearence.Size = new System.Drawing.Size(545, 192);
			this.grb_LangTTAppearence.TabIndex = 2;
			this.grb_LangTTAppearence.TabStop = false;
			this.grb_LangTTAppearence.Text = "Language tooltip appearence";
			// 
			// txt_LangTTText
			// 
			this.txt_LangTTText.Location = new System.Drawing.Point(368, 77);
			this.txt_LangTTText.Name = "txt_LangTTText";
			this.txt_LangTTText.Size = new System.Drawing.Size(117, 23);
			this.txt_LangTTText.TabIndex = 10;
			this.txt_LangTTText.TextChanged += new System.EventHandler(this.Txt_LangTTTextTextChanged);
			// 
			// lbl_LangTTText
			// 
			this.lbl_LangTTText.AutoSize = true;
			this.lbl_LangTTText.Location = new System.Drawing.Point(211, 80);
			this.lbl_LangTTText.Name = "lbl_LangTTText";
			this.lbl_LangTTText.Size = new System.Drawing.Size(74, 15);
			this.lbl_LangTTText.TabIndex = 9;
			this.lbl_LangTTText.Text = "Tootltip text:";
			// 
			// btn_LangTTFont
			// 
			this.btn_LangTTFont.Location = new System.Drawing.Point(368, 18);
			this.btn_LangTTFont.Name = "btn_LangTTFont";
			this.btn_LangTTFont.Size = new System.Drawing.Size(117, 23);
			this.btn_LangTTFont.TabIndex = 8;
			this.btn_LangTTFont.Text = "Font";
			this.btn_LangTTFont.UseVisualStyleBackColor = true;
			this.btn_LangTTFont.Click += new System.EventHandler(this.Btn_LangTTFontClick);
			// 
			// grb_LangTTPositon
			// 
			this.grb_LangTTPositon.Controls.Add(this.nud_LangTTPositionY);
			this.grb_LangTTPositon.Controls.Add(this.lbl_LangTTPositionY);
			this.grb_LangTTPositon.Controls.Add(this.nud_LangTTPositionX);
			this.grb_LangTTPositon.Controls.Add(this.lbl_LangTTPositionX);
			this.grb_LangTTPositon.Location = new System.Drawing.Point(351, 106);
			this.grb_LangTTPositon.Name = "grb_LangTTPositon";
			this.grb_LangTTPositon.Size = new System.Drawing.Size(134, 79);
			this.grb_LangTTPositon.TabIndex = 7;
			this.grb_LangTTPositon.TabStop = false;
			this.grb_LangTTPositon.Text = "Position";
			// 
			// nud_LangTTPositionY
			// 
			this.nud_LangTTPositionY.Location = new System.Drawing.Point(73, 48);
			this.nud_LangTTPositionY.Name = "nud_LangTTPositionY";
			this.nud_LangTTPositionY.Size = new System.Drawing.Size(45, 23);
			this.nud_LangTTPositionY.TabIndex = 3;
			this.nud_LangTTPositionY.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
			// 
			// lbl_LangTTPositionY
			// 
			this.lbl_LangTTPositionY.AutoSize = true;
			this.lbl_LangTTPositionY.Location = new System.Drawing.Point(12, 52);
			this.lbl_LangTTPositionY.Name = "lbl_LangTTPositionY";
			this.lbl_LangTTPositionY.Size = new System.Drawing.Size(17, 15);
			this.lbl_LangTTPositionY.TabIndex = 2;
			this.lbl_LangTTPositionY.Text = "Y:";
			// 
			// nud_LangTTPositionX
			// 
			this.nud_LangTTPositionX.Location = new System.Drawing.Point(73, 19);
			this.nud_LangTTPositionX.Name = "nud_LangTTPositionX";
			this.nud_LangTTPositionX.Size = new System.Drawing.Size(45, 23);
			this.nud_LangTTPositionX.TabIndex = 1;
			this.nud_LangTTPositionX.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
			// 
			// lbl_LangTTPositionX
			// 
			this.lbl_LangTTPositionX.AutoSize = true;
			this.lbl_LangTTPositionX.Location = new System.Drawing.Point(12, 23);
			this.lbl_LangTTPositionX.Name = "lbl_LangTTPositionX";
			this.lbl_LangTTPositionX.Size = new System.Drawing.Size(17, 15);
			this.lbl_LangTTPositionX.TabIndex = 0;
			this.lbl_LangTTPositionX.Text = "X:";
			// 
			// grb_LangTTSize
			// 
			this.grb_LangTTSize.Controls.Add(this.nud_LangTTWidth);
			this.grb_LangTTSize.Controls.Add(this.lbl_LangTTWidth);
			this.grb_LangTTSize.Controls.Add(this.nud_LangTTHeight);
			this.grb_LangTTSize.Controls.Add(this.lbl_LangTTHeight);
			this.grb_LangTTSize.Location = new System.Drawing.Point(211, 106);
			this.grb_LangTTSize.Name = "grb_LangTTSize";
			this.grb_LangTTSize.Size = new System.Drawing.Size(134, 79);
			this.grb_LangTTSize.TabIndex = 6;
			this.grb_LangTTSize.TabStop = false;
			this.grb_LangTTSize.Text = "Size";
			// 
			// nud_LangTTWidth
			// 
			this.nud_LangTTWidth.Location = new System.Drawing.Point(76, 48);
			this.nud_LangTTWidth.Name = "nud_LangTTWidth";
			this.nud_LangTTWidth.Size = new System.Drawing.Size(45, 23);
			this.nud_LangTTWidth.TabIndex = 3;
			this.nud_LangTTWidth.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
			// 
			// lbl_LangTTWidth
			// 
			this.lbl_LangTTWidth.AutoSize = true;
			this.lbl_LangTTWidth.Location = new System.Drawing.Point(14, 51);
			this.lbl_LangTTWidth.Name = "lbl_LangTTWidth";
			this.lbl_LangTTWidth.Size = new System.Drawing.Size(42, 15);
			this.lbl_LangTTWidth.TabIndex = 2;
			this.lbl_LangTTWidth.Text = "Width:";
			// 
			// nud_LangTTHeight
			// 
			this.nud_LangTTHeight.Location = new System.Drawing.Point(76, 19);
			this.nud_LangTTHeight.Name = "nud_LangTTHeight";
			this.nud_LangTTHeight.Size = new System.Drawing.Size(45, 23);
			this.nud_LangTTHeight.TabIndex = 1;
			this.nud_LangTTHeight.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
			// 
			// lbl_LangTTHeight
			// 
			this.lbl_LangTTHeight.AutoSize = true;
			this.lbl_LangTTHeight.Location = new System.Drawing.Point(13, 22);
			this.lbl_LangTTHeight.Name = "lbl_LangTTHeight";
			this.lbl_LangTTHeight.Size = new System.Drawing.Size(46, 15);
			this.lbl_LangTTHeight.TabIndex = 0;
			this.lbl_LangTTHeight.Text = "Height:";
			// 
			// lbl_LangTTBackgroundColor
			// 
			this.lbl_LangTTBackgroundColor.AutoSize = true;
			this.lbl_LangTTBackgroundColor.Location = new System.Drawing.Point(210, 53);
			this.lbl_LangTTBackgroundColor.Name = "lbl_LangTTBackgroundColor";
			this.lbl_LangTTBackgroundColor.Size = new System.Drawing.Size(104, 15);
			this.lbl_LangTTBackgroundColor.TabIndex = 5;
			this.lbl_LangTTBackgroundColor.Text = "Background color:";
			// 
			// lbl_LangTTForegroundColor
			// 
			this.lbl_LangTTForegroundColor.AutoSize = true;
			this.lbl_LangTTForegroundColor.Location = new System.Drawing.Point(210, 23);
			this.lbl_LangTTForegroundColor.Name = "lbl_LangTTForegroundColor";
			this.lbl_LangTTForegroundColor.Size = new System.Drawing.Size(102, 15);
			this.lbl_LangTTForegroundColor.TabIndex = 4;
			this.lbl_LangTTForegroundColor.Text = "Foreground color:";
			// 
			// chk_LangTTTransparentColor
			// 
			this.chk_LangTTTransparentColor.AutoSize = true;
			this.chk_LangTTTransparentColor.Location = new System.Drawing.Point(368, 52);
			this.chk_LangTTTransparentColor.Name = "chk_LangTTTransparentColor";
			this.chk_LangTTTransparentColor.Size = new System.Drawing.Size(119, 19);
			this.chk_LangTTTransparentColor.TabIndex = 3;
			this.chk_LangTTTransparentColor.Text = "Transparent color";
			this.chk_LangTTTransparentColor.UseVisualStyleBackColor = true;
			this.chk_LangTTTransparentColor.CheckedChanged += new System.EventHandler(this.Chk_LangTTTransparentColorCheckedChanged);
			// 
			// btn_LangTTBackgroundColor
			// 
			this.btn_LangTTBackgroundColor.Location = new System.Drawing.Point(319, 48);
			this.btn_LangTTBackgroundColor.Name = "btn_LangTTBackgroundColor";
			this.btn_LangTTBackgroundColor.Size = new System.Drawing.Size(25, 25);
			this.btn_LangTTBackgroundColor.TabIndex = 2;
			this.btn_LangTTBackgroundColor.UseVisualStyleBackColor = true;
			this.btn_LangTTBackgroundColor.Click += new System.EventHandler(this.Btn_ColorSelectionClick);
			// 
			// btn_LangTTForegroundColor
			// 
			this.btn_LangTTForegroundColor.Location = new System.Drawing.Point(319, 18);
			this.btn_LangTTForegroundColor.Name = "btn_LangTTForegroundColor";
			this.btn_LangTTForegroundColor.Size = new System.Drawing.Size(25, 25);
			this.btn_LangTTForegroundColor.TabIndex = 1;
			this.btn_LangTTForegroundColor.UseVisualStyleBackColor = true;
			this.btn_LangTTForegroundColor.Click += new System.EventHandler(this.Btn_ColorSelectionClick);
			// 
			// lsb_LangTTAppearenceForList
			// 
			this.lsb_LangTTAppearenceForList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lsb_LangTTAppearenceForList.FormattingEnabled = true;
			this.lsb_LangTTAppearenceForList.ItemHeight = 15;
			this.lsb_LangTTAppearenceForList.Items.AddRange(new object[] {
			"Layout 1",
			"Layout 2",
			"Around mouse",
			"Around caret"});
			this.lsb_LangTTAppearenceForList.Location = new System.Drawing.Point(6, 18);
			this.lsb_LangTTAppearenceForList.Name = "lsb_LangTTAppearenceForList";
			this.lsb_LangTTAppearenceForList.Size = new System.Drawing.Size(176, 167);
			this.lsb_LangTTAppearenceForList.TabIndex = 0;
			this.lsb_LangTTAppearenceForList.SelectedIndexChanged += new System.EventHandler(this.Lsb_LangTTAppearenceForListSelectedIndexChanged);
			// 
			// chk_LangTooltipCaret
			// 
			this.chk_LangTooltipCaret.AutoSize = true;
			this.chk_LangTooltipCaret.Location = new System.Drawing.Point(8, 31);
			this.chk_LangTooltipCaret.Name = "chk_LangTooltipCaret";
			this.chk_LangTooltipCaret.Size = new System.Drawing.Size(268, 19);
			this.chk_LangTooltipCaret.TabIndex = 1;
			this.chk_LangTooltipCaret.Text = "Display current language tooltip around caret.";
			this.chk_LangTooltipCaret.UseVisualStyleBackColor = true;
			this.chk_LangTooltipCaret.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// chk_LangTooltipMouse
			// 
			this.chk_LangTooltipMouse.AutoSize = true;
			this.chk_LangTooltipMouse.Location = new System.Drawing.Point(8, 6);
			this.chk_LangTooltipMouse.Name = "chk_LangTooltipMouse";
			this.chk_LangTooltipMouse.Size = new System.Drawing.Size(278, 19);
			this.chk_LangTooltipMouse.TabIndex = 0;
			this.chk_LangTooltipMouse.Text = "Display current language tooltip around mouse.";
			this.chk_LangTooltipMouse.UseVisualStyleBackColor = true;
			this.chk_LangTooltipMouse.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// tab_timings
			// 
			this.tab_timings.Controls.Add(this.lbl_ExcludedPrograms);
			this.tab_timings.Controls.Add(this.txt_ExcludedPrograms);
			this.tab_timings.Controls.Add(this.nud_SelectedTextGetTriesCount);
			this.tab_timings.Controls.Add(this.chk_SelectedTextGetMoreTries);
			this.tab_timings.Controls.Add(this.nud_CapsLockRefreshRate);
			this.tab_timings.Controls.Add(this.lbl_CapsLockRefreshRate);
			this.tab_timings.Controls.Add(this.nud_ScrollLockRefreshRate);
			this.tab_timings.Controls.Add(this.lbl_ScrollLockRefreshRate);
			this.tab_timings.Controls.Add(this.nud_TrayFlagRefreshRate);
			this.tab_timings.Controls.Add(this.lbl_FlagTrayRefreshRate);
			this.tab_timings.Controls.Add(this.nud_DoubleHK2ndPressWaitTime);
			this.tab_timings.Controls.Add(this.lbl_DoubleHK2ndPressWaitTime);
			this.tab_timings.Controls.Add(this.nud_LangTTCaretRefreshRate);
			this.tab_timings.Controls.Add(this.lbl_LangTTCaretRefreshRate);
			this.tab_timings.Controls.Add(this.nud_LangTTMouseRefreshRate);
			this.tab_timings.Controls.Add(this.lbl_LangTTMouseRefreshRate);
			this.tab_timings.Location = new System.Drawing.Point(4, 24);
			this.tab_timings.Name = "tab_timings";
			this.tab_timings.Padding = new System.Windows.Forms.Padding(3);
			this.tab_timings.Size = new System.Drawing.Size(559, 273);
			this.tab_timings.TabIndex = 7;
			this.tab_timings.Text = "Timings";
			this.tab_timings.UseVisualStyleBackColor = true;
			// 
			// lbl_ExcludedPrograms
			// 
			this.lbl_ExcludedPrograms.AutoSize = true;
			this.lbl_ExcludedPrograms.Location = new System.Drawing.Point(218, 204);
			this.lbl_ExcludedPrograms.Name = "lbl_ExcludedPrograms";
			this.lbl_ExcludedPrograms.Size = new System.Drawing.Size(111, 15);
			this.lbl_ExcludedPrograms.TabIndex = 22;
			this.lbl_ExcludedPrograms.Text = "Excluded programs:";
			// 
			// txt_ExcludedPrograms
			// 
			this.txt_ExcludedPrograms.Location = new System.Drawing.Point(8, 225);
			this.txt_ExcludedPrograms.Multiline = true;
			this.txt_ExcludedPrograms.Name = "txt_ExcludedPrograms";
			this.txt_ExcludedPrograms.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_ExcludedPrograms.Size = new System.Drawing.Size(541, 42);
			this.txt_ExcludedPrograms.TabIndex = 21;
			this.txt_ExcludedPrograms.Text = "LA.exe SomeProgram.exe";
			// 
			// nud_SelectedTextGetTriesCount
			// 
			this.nud_SelectedTextGetTriesCount.Location = new System.Drawing.Point(429, 181);
			this.nud_SelectedTextGetTriesCount.Maximum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.nud_SelectedTextGetTriesCount.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.nud_SelectedTextGetTriesCount.Name = "nud_SelectedTextGetTriesCount";
			this.nud_SelectedTextGetTriesCount.Size = new System.Drawing.Size(120, 23);
			this.nud_SelectedTextGetTriesCount.TabIndex = 17;
			this.nud_SelectedTextGetTriesCount.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			// 
			// chk_SelectedTextGetMoreTries
			// 
			this.chk_SelectedTextGetMoreTries.AutoSize = true;
			this.chk_SelectedTextGetMoreTries.Location = new System.Drawing.Point(8, 182);
			this.chk_SelectedTextGetMoreTries.Name = "chk_SelectedTextGetMoreTries";
			this.chk_SelectedTextGetMoreTries.Size = new System.Drawing.Size(206, 19);
			this.chk_SelectedTextGetMoreTries.TabIndex = 16;
			this.chk_SelectedTextGetMoreTries.Text = "Use more tries to get selected text:";
			this.chk_SelectedTextGetMoreTries.UseVisualStyleBackColor = true;
			this.chk_SelectedTextGetMoreTries.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// nud_CapsLockRefreshRate
			// 
			this.nud_CapsLockRefreshRate.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_CapsLockRefreshRate.Location = new System.Drawing.Point(429, 152);
			this.nud_CapsLockRefreshRate.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_CapsLockRefreshRate.Name = "nud_CapsLockRefreshRate";
			this.nud_CapsLockRefreshRate.Size = new System.Drawing.Size(120, 23);
			this.nud_CapsLockRefreshRate.TabIndex = 13;
			// 
			// lbl_CapsLockRefreshRate
			// 
			this.lbl_CapsLockRefreshRate.AutoSize = true;
			this.lbl_CapsLockRefreshRate.Location = new System.Drawing.Point(8, 154);
			this.lbl_CapsLockRefreshRate.Name = "lbl_CapsLockRefreshRate";
			this.lbl_CapsLockRefreshRate.Size = new System.Drawing.Size(151, 15);
			this.lbl_CapsLockRefreshRate.TabIndex = 12;
			this.lbl_CapsLockRefreshRate.Text = "Caps Lock update rate(ms):";
			// 
			// nud_ScrollLockRefreshRate
			// 
			this.nud_ScrollLockRefreshRate.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_ScrollLockRefreshRate.Location = new System.Drawing.Point(429, 122);
			this.nud_ScrollLockRefreshRate.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_ScrollLockRefreshRate.Name = "nud_ScrollLockRefreshRate";
			this.nud_ScrollLockRefreshRate.Size = new System.Drawing.Size(120, 23);
			this.nud_ScrollLockRefreshRate.TabIndex = 11;
			// 
			// lbl_ScrollLockRefreshRate
			// 
			this.lbl_ScrollLockRefreshRate.AutoSize = true;
			this.lbl_ScrollLockRefreshRate.Location = new System.Drawing.Point(8, 125);
			this.lbl_ScrollLockRefreshRate.Name = "lbl_ScrollLockRefreshRate";
			this.lbl_ScrollLockRefreshRate.Size = new System.Drawing.Size(153, 15);
			this.lbl_ScrollLockRefreshRate.TabIndex = 10;
			this.lbl_ScrollLockRefreshRate.Text = "Scroll Lock refresh rate(ms):";
			// 
			// nud_TrayFlagRefreshRate
			// 
			this.nud_TrayFlagRefreshRate.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_TrayFlagRefreshRate.Location = new System.Drawing.Point(429, 93);
			this.nud_TrayFlagRefreshRate.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_TrayFlagRefreshRate.Name = "nud_TrayFlagRefreshRate";
			this.nud_TrayFlagRefreshRate.Size = new System.Drawing.Size(120, 23);
			this.nud_TrayFlagRefreshRate.TabIndex = 9;
			// 
			// lbl_FlagTrayRefreshRate
			// 
			this.lbl_FlagTrayRefreshRate.AutoSize = true;
			this.lbl_FlagTrayRefreshRate.Location = new System.Drawing.Point(8, 96);
			this.lbl_FlagTrayRefreshRate.Name = "lbl_FlagTrayRefreshRate";
			this.lbl_FlagTrayRefreshRate.Size = new System.Drawing.Size(185, 15);
			this.lbl_FlagTrayRefreshRate.TabIndex = 8;
			this.lbl_FlagTrayRefreshRate.Text = "Flags in tray icon refresh rate(ms):";
			// 
			// nud_DoubleHK2ndPressWaitTime
			// 
			this.nud_DoubleHK2ndPressWaitTime.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_DoubleHK2ndPressWaitTime.Location = new System.Drawing.Point(429, 64);
			this.nud_DoubleHK2ndPressWaitTime.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_DoubleHK2ndPressWaitTime.Name = "nud_DoubleHK2ndPressWaitTime";
			this.nud_DoubleHK2ndPressWaitTime.Size = new System.Drawing.Size(120, 23);
			this.nud_DoubleHK2ndPressWaitTime.TabIndex = 5;
			// 
			// lbl_DoubleHK2ndPressWaitTime
			// 
			this.lbl_DoubleHK2ndPressWaitTime.AutoSize = true;
			this.lbl_DoubleHK2ndPressWaitTime.Location = new System.Drawing.Point(8, 67);
			this.lbl_DoubleHK2ndPressWaitTime.Name = "lbl_DoubleHK2ndPressWaitTime";
			this.lbl_DoubleHK2ndPressWaitTime.Size = new System.Drawing.Size(252, 15);
			this.lbl_DoubleHK2ndPressWaitTime.TabIndex = 4;
			this.lbl_DoubleHK2ndPressWaitTime.Text = "Double hotkey wait time for second press(ms):";
			// 
			// nud_LangTTCaretRefreshRate
			// 
			this.nud_LangTTCaretRefreshRate.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_LangTTCaretRefreshRate.Location = new System.Drawing.Point(429, 35);
			this.nud_LangTTCaretRefreshRate.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_LangTTCaretRefreshRate.Name = "nud_LangTTCaretRefreshRate";
			this.nud_LangTTCaretRefreshRate.Size = new System.Drawing.Size(120, 23);
			this.nud_LangTTCaretRefreshRate.TabIndex = 3;
			// 
			// lbl_LangTTCaretRefreshRate
			// 
			this.lbl_LangTTCaretRefreshRate.AutoSize = true;
			this.lbl_LangTTCaretRefreshRate.Location = new System.Drawing.Point(8, 38);
			this.lbl_LangTTCaretRefreshRate.Name = "lbl_LangTTCaretRefreshRate";
			this.lbl_LangTTCaretRefreshRate.Size = new System.Drawing.Size(256, 15);
			this.lbl_LangTTCaretRefreshRate.TabIndex = 2;
			this.lbl_LangTTCaretRefreshRate.Text = "Language tooltip around caret refresh rate(ms):";
			// 
			// nud_LangTTMouseRefreshRate
			// 
			this.nud_LangTTMouseRefreshRate.Increment = new decimal(new int[] {
			25,
			0,
			0,
			0});
			this.nud_LangTTMouseRefreshRate.Location = new System.Drawing.Point(429, 6);
			this.nud_LangTTMouseRefreshRate.Maximum = new decimal(new int[] {
			2000,
			0,
			0,
			0});
			this.nud_LangTTMouseRefreshRate.Name = "nud_LangTTMouseRefreshRate";
			this.nud_LangTTMouseRefreshRate.Size = new System.Drawing.Size(120, 23);
			this.nud_LangTTMouseRefreshRate.TabIndex = 1;
			// 
			// lbl_LangTTMouseRefreshRate
			// 
			this.lbl_LangTTMouseRefreshRate.AutoSize = true;
			this.lbl_LangTTMouseRefreshRate.Location = new System.Drawing.Point(8, 9);
			this.lbl_LangTTMouseRefreshRate.Name = "lbl_LangTTMouseRefreshRate";
			this.lbl_LangTTMouseRefreshRate.Size = new System.Drawing.Size(266, 15);
			this.lbl_LangTTMouseRefreshRate.TabIndex = 0;
			this.lbl_LangTTMouseRefreshRate.Text = "Language tooltip around mouse refresh rate(ms):";
			// 
			// tab_snippets
			// 
			this.tab_snippets.Controls.Add(this.txt_Snippets);
			this.tab_snippets.Controls.Add(this.chk_Snippets);
			this.tab_snippets.Location = new System.Drawing.Point(4, 24);
			this.tab_snippets.Name = "tab_snippets";
			this.tab_snippets.Padding = new System.Windows.Forms.Padding(3);
			this.tab_snippets.Size = new System.Drawing.Size(559, 273);
			this.tab_snippets.TabIndex = 3;
			this.tab_snippets.Text = "Snippets";
			this.tab_snippets.UseVisualStyleBackColor = true;
			// 
			// txt_Snippets
			// 
			this.txt_Snippets.Location = new System.Drawing.Point(8, 31);
			this.txt_Snippets.Multiline = true;
			this.txt_Snippets.Name = "txt_Snippets";
			this.txt_Snippets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_Snippets.Size = new System.Drawing.Size(541, 236);
			this.txt_Snippets.TabIndex = 1;
			this.txt_Snippets.Text = "->mahou\r\n====>Mahou (魔法) - Magical layout switcher.<====\r\n->eml\r\n====>BladeMight@" +
	"gmail.com<====";
			// 
			// chk_Snippets
			// 
			this.chk_Snippets.AutoSize = true;
			this.chk_Snippets.Location = new System.Drawing.Point(8, 6);
			this.chk_Snippets.Name = "chk_Snippets";
			this.chk_Snippets.Size = new System.Drawing.Size(111, 19);
			this.chk_Snippets.TabIndex = 0;
			this.chk_Snippets.Text = "Enable snippets.";
			this.chk_Snippets.UseVisualStyleBackColor = true;
			this.chk_Snippets.CheckedChanged += new System.EventHandler(this.Chk_CheckedChanged);
			// 
			// tab_hotkeys
			// 
			this.tab_hotkeys.Controls.Add(this.grb_Hotkey);
			this.tab_hotkeys.Controls.Add(this.lsb_Hotkeys);
			this.tab_hotkeys.Location = new System.Drawing.Point(4, 24);
			this.tab_hotkeys.Name = "tab_hotkeys";
			this.tab_hotkeys.Padding = new System.Windows.Forms.Padding(3);
			this.tab_hotkeys.Size = new System.Drawing.Size(559, 273);
			this.tab_hotkeys.TabIndex = 4;
			this.tab_hotkeys.Text = "Hotkeys";
			this.tab_hotkeys.UseVisualStyleBackColor = true;
			// 
			// grb_Hotkey
			// 
			this.grb_Hotkey.Controls.Add(this.lbl_HotkeyHelp);
			this.grb_Hotkey.Controls.Add(this.chk_DoubleHotkey);
			this.grb_Hotkey.Controls.Add(this.chk_HotKeyEnabled);
			this.grb_Hotkey.Controls.Add(this.txt_Hotkey);
			this.grb_Hotkey.Controls.Add(this.chk_WinInHotKey);
			this.grb_Hotkey.Location = new System.Drawing.Point(260, 0);
			this.grb_Hotkey.Name = "grb_Hotkey";
			this.grb_Hotkey.Size = new System.Drawing.Size(289, 265);
			this.grb_Hotkey.TabIndex = 1;
			this.grb_Hotkey.TabStop = false;
			this.grb_Hotkey.Text = "Hotkey";
			// 
			// lbl_HotkeyHelp
			// 
			this.lbl_HotkeyHelp.Location = new System.Drawing.Point(9, 172);
			this.lbl_HotkeyHelp.Name = "lbl_HotkeyHelp";
			this.lbl_HotkeyHelp.Size = new System.Drawing.Size(274, 81);
			this.lbl_HotkeyHelp.TabIndex = 7;
			// 
			// chk_DoubleHotkey
			// 
			this.chk_DoubleHotkey.AutoSize = true;
			this.chk_DoubleHotkey.Location = new System.Drawing.Point(6, 98);
			this.chk_DoubleHotkey.Name = "chk_DoubleHotkey";
			this.chk_DoubleHotkey.Size = new System.Drawing.Size(103, 19);
			this.chk_DoubleHotkey.TabIndex = 6;
			this.chk_DoubleHotkey.Text = "Double hotkey";
			this.chk_DoubleHotkey.UseVisualStyleBackColor = true;
			this.chk_DoubleHotkey.CheckedChanged += new System.EventHandler(this.ChkUpdateHotkeyTemps_CheckedChanged);
			// 
			// chk_HotKeyEnabled
			// 
			this.chk_HotKeyEnabled.AutoSize = true;
			this.chk_HotKeyEnabled.Location = new System.Drawing.Point(6, 73);
			this.chk_HotKeyEnabled.Name = "chk_HotKeyEnabled";
			this.chk_HotKeyEnabled.Size = new System.Drawing.Size(68, 19);
			this.chk_HotKeyEnabled.TabIndex = 5;
			this.chk_HotKeyEnabled.Text = "Enabled";
			this.chk_HotKeyEnabled.UseVisualStyleBackColor = true;
			this.chk_HotKeyEnabled.CheckedChanged += new System.EventHandler(this.ChkUpdateHotkeyTemps_CheckedChanged);
			// 
			// txt_Hotkey
			// 
			this.txt_Hotkey.AcceptsTab = true;
			this.txt_Hotkey.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Hotkey.Location = new System.Drawing.Point(59, 121);
			this.txt_Hotkey.Multiline = true;
			this.txt_Hotkey.Name = "txt_Hotkey";
			this.txt_Hotkey.ReadOnly = true;
			this.txt_Hotkey.Size = new System.Drawing.Size(224, 23);
			this.txt_Hotkey.TabIndex = 4;
			this.txt_Hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_HotkeyKeyDown);
			// 
			// chk_WinInHotKey
			// 
			this.chk_WinInHotKey.AutoSize = true;
			this.chk_WinInHotKey.Location = new System.Drawing.Point(6, 123);
			this.chk_WinInHotKey.Name = "chk_WinInHotKey";
			this.chk_WinInHotKey.Size = new System.Drawing.Size(47, 19);
			this.chk_WinInHotKey.TabIndex = 3;
			this.chk_WinInHotKey.Text = "Win";
			this.chk_WinInHotKey.UseVisualStyleBackColor = true;
			this.chk_WinInHotKey.CheckedChanged += new System.EventHandler(this.ChkUpdateHotkeyTemps_CheckedChanged);
			// 
			// lsb_Hotkeys
			// 
			this.lsb_Hotkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lsb_Hotkeys.FormattingEnabled = true;
			this.lsb_Hotkeys.ItemHeight = 15;
			this.lsb_Hotkeys.Items.AddRange(new object[] {
			"Toggle settings window",
			"Convert last word",
			"Convert selected text",
			"Convert last line",
			"Convert specific last words count",
			"Toggle symbol ignore mode",
			"Selected text words to Title Case",
			"Selected text words to RanDoM cASe",
			"Selected text words to sWAP cASE",
			"Selected text transliteration",
			"Exit Mahou"});
			this.lsb_Hotkeys.Location = new System.Drawing.Point(8, 8);
			this.lsb_Hotkeys.Name = "lsb_Hotkeys";
			this.lsb_Hotkeys.Size = new System.Drawing.Size(246, 257);
			this.lsb_Hotkeys.TabIndex = 0;
			this.lsb_Hotkeys.SelectedIndexChanged += new System.EventHandler(this.Lsb_HotkeysSelectedIndexChanged);
			// 
			// tab_updates
			// 
			this.tab_updates.Controls.Add(this.grb_DownloadUpdate);
			this.tab_updates.Controls.Add(this.grb_ProxyConfig);
			this.tab_updates.Controls.Add(this.grb_MahouReleaseTitle);
			this.tab_updates.Controls.Add(this.btn_CheckForUpdates);
			this.tab_updates.Location = new System.Drawing.Point(4, 24);
			this.tab_updates.Name = "tab_updates";
			this.tab_updates.Padding = new System.Windows.Forms.Padding(3);
			this.tab_updates.Size = new System.Drawing.Size(559, 273);
			this.tab_updates.TabIndex = 5;
			this.tab_updates.Text = "Updates";
			this.tab_updates.UseVisualStyleBackColor = true;
			// 
			// grb_DownloadUpdate
			// 
			this.grb_DownloadUpdate.Controls.Add(this.prb_UpdateDownloadProgress);
			this.grb_DownloadUpdate.Controls.Add(this.btn_DownloadUpdate);
			this.grb_DownloadUpdate.Enabled = false;
			this.grb_DownloadUpdate.Location = new System.Drawing.Point(310, 32);
			this.grb_DownloadUpdate.Name = "grb_DownloadUpdate";
			this.grb_DownloadUpdate.Size = new System.Drawing.Size(243, 120);
			this.grb_DownloadUpdate.TabIndex = 3;
			this.grb_DownloadUpdate.TabStop = false;
			this.grb_DownloadUpdate.Text = "Download update";
			// 
			// prb_UpdateDownloadProgress
			// 
			this.prb_UpdateDownloadProgress.Location = new System.Drawing.Point(7, 69);
			this.prb_UpdateDownloadProgress.Name = "prb_UpdateDownloadProgress";
			this.prb_UpdateDownloadProgress.Size = new System.Drawing.Size(230, 23);
			this.prb_UpdateDownloadProgress.TabIndex = 6;
			// 
			// btn_DownloadUpdate
			// 
			this.btn_DownloadUpdate.Location = new System.Drawing.Point(6, 40);
			this.btn_DownloadUpdate.Name = "btn_DownloadUpdate";
			this.btn_DownloadUpdate.Size = new System.Drawing.Size(231, 23);
			this.btn_DownloadUpdate.TabIndex = 5;
			this.btn_DownloadUpdate.Text = "Update Mahou to <version>";
			this.btn_DownloadUpdate.UseVisualStyleBackColor = true;
			this.btn_DownloadUpdate.Click += new System.EventHandler(this.Btn_DownloadUpdateClick);
			// 
			// grb_ProxyConfig
			// 
			this.grb_ProxyConfig.Controls.Add(this.txt_ProxyPassword);
			this.grb_ProxyConfig.Controls.Add(this.lbl_ProxyPassword);
			this.grb_ProxyConfig.Controls.Add(this.txt_ProxyLogin);
			this.grb_ProxyConfig.Controls.Add(this.lbl_ProxyLogin);
			this.grb_ProxyConfig.Controls.Add(this.txt_ProxyServerPort);
			this.grb_ProxyConfig.Controls.Add(this.lbl_ProxyServerPort);
			this.grb_ProxyConfig.Location = new System.Drawing.Point(310, 158);
			this.grb_ProxyConfig.Name = "grb_ProxyConfig";
			this.grb_ProxyConfig.Size = new System.Drawing.Size(246, 109);
			this.grb_ProxyConfig.TabIndex = 2;
			this.grb_ProxyConfig.TabStop = false;
			this.grb_ProxyConfig.Text = "Proxy configuration";
			// 
			// txt_ProxyPassword
			// 
			this.txt_ProxyPassword.Location = new System.Drawing.Point(117, 80);
			this.txt_ProxyPassword.Name = "txt_ProxyPassword";
			this.txt_ProxyPassword.PasswordChar = '~';
			this.txt_ProxyPassword.Size = new System.Drawing.Size(122, 23);
			this.txt_ProxyPassword.TabIndex = 5;
			// 
			// lbl_ProxyPassword
			// 
			this.lbl_ProxyPassword.AutoSize = true;
			this.lbl_ProxyPassword.Location = new System.Drawing.Point(7, 84);
			this.lbl_ProxyPassword.Name = "lbl_ProxyPassword";
			this.lbl_ProxyPassword.Size = new System.Drawing.Size(60, 15);
			this.lbl_ProxyPassword.TabIndex = 4;
			this.lbl_ProxyPassword.Text = "Password:";
			// 
			// txt_ProxyLogin
			// 
			this.txt_ProxyLogin.Location = new System.Drawing.Point(117, 51);
			this.txt_ProxyLogin.Name = "txt_ProxyLogin";
			this.txt_ProxyLogin.Size = new System.Drawing.Size(122, 23);
			this.txt_ProxyLogin.TabIndex = 3;
			// 
			// lbl_ProxyLogin
			// 
			this.lbl_ProxyLogin.AutoSize = true;
			this.lbl_ProxyLogin.Location = new System.Drawing.Point(7, 55);
			this.lbl_ProxyLogin.Name = "lbl_ProxyLogin";
			this.lbl_ProxyLogin.Size = new System.Drawing.Size(40, 15);
			this.lbl_ProxyLogin.TabIndex = 2;
			this.lbl_ProxyLogin.Text = "Login:";
			// 
			// txt_ProxyServerPort
			// 
			this.txt_ProxyServerPort.Location = new System.Drawing.Point(117, 22);
			this.txt_ProxyServerPort.Name = "txt_ProxyServerPort";
			this.txt_ProxyServerPort.Size = new System.Drawing.Size(122, 23);
			this.txt_ProxyServerPort.TabIndex = 1;
			// 
			// lbl_ProxyServerPort
			// 
			this.lbl_ProxyServerPort.AutoSize = true;
			this.lbl_ProxyServerPort.Location = new System.Drawing.Point(7, 26);
			this.lbl_ProxyServerPort.Name = "lbl_ProxyServerPort";
			this.lbl_ProxyServerPort.Size = new System.Drawing.Size(64, 15);
			this.lbl_ProxyServerPort.TabIndex = 0;
			this.lbl_ProxyServerPort.Text = "Server:Port";
			// 
			// grb_MahouReleaseTitle
			// 
			this.grb_MahouReleaseTitle.Controls.Add(this.txt_UpdateDetails);
			this.grb_MahouReleaseTitle.Location = new System.Drawing.Point(3, 32);
			this.grb_MahouReleaseTitle.Name = "grb_MahouReleaseTitle";
			this.grb_MahouReleaseTitle.Size = new System.Drawing.Size(301, 235);
			this.grb_MahouReleaseTitle.TabIndex = 1;
			this.grb_MahouReleaseTitle.TabStop = false;
			this.grb_MahouReleaseTitle.Text = "<Mahou release title>";
			// 
			// txt_UpdateDetails
			// 
			this.txt_UpdateDetails.BackColor = System.Drawing.Color.White;
			this.txt_UpdateDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_UpdateDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_UpdateDetails.Location = new System.Drawing.Point(3, 19);
			this.txt_UpdateDetails.Multiline = true;
			this.txt_UpdateDetails.Name = "txt_UpdateDetails";
			this.txt_UpdateDetails.ReadOnly = true;
			this.txt_UpdateDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_UpdateDetails.Size = new System.Drawing.Size(295, 213);
			this.txt_UpdateDetails.TabIndex = 0;
			// 
			// btn_CheckForUpdates
			// 
			this.btn_CheckForUpdates.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_CheckForUpdates.Location = new System.Drawing.Point(3, 3);
			this.btn_CheckForUpdates.Name = "btn_CheckForUpdates";
			this.btn_CheckForUpdates.Size = new System.Drawing.Size(553, 23);
			this.btn_CheckForUpdates.TabIndex = 0;
			this.btn_CheckForUpdates.Text = "Check for updates";
			this.btn_CheckForUpdates.UseVisualStyleBackColor = true;
			this.btn_CheckForUpdates.Click += new System.EventHandler(this.Btn_CheckForUpdatesClick);
			// 
			// tab_about
			// 
			this.tab_about.Controls.Add(this.btn_DebugInfo);
			this.tab_about.Controls.Add(this.txt_Help);
			this.tab_about.Controls.Add(this.lnk_Releases);
			this.tab_about.Controls.Add(this.lnk_Email);
			this.tab_about.Controls.Add(this.lnk_Wiki);
			this.tab_about.Controls.Add(this.lnk_Site);
			this.tab_about.Controls.Add(this.lnk_Repository);
			this.tab_about.Location = new System.Drawing.Point(4, 24);
			this.tab_about.Name = "tab_about";
			this.tab_about.Padding = new System.Windows.Forms.Padding(3);
			this.tab_about.Size = new System.Drawing.Size(559, 273);
			this.tab_about.TabIndex = 6;
			this.tab_about.Text = "About";
			this.tab_about.UseVisualStyleBackColor = true;
			// 
			// btn_DebugInfo
			// 
			this.btn_DebugInfo.Location = new System.Drawing.Point(353, 248);
			this.btn_DebugInfo.Name = "btn_DebugInfo";
			this.btn_DebugInfo.Size = new System.Drawing.Size(200, 23);
			this.btn_DebugInfo.TabIndex = 6;
			this.btn_DebugInfo.Text = "Debug info";
			this.btn_DebugInfo.UseVisualStyleBackColor = true;
			this.btn_DebugInfo.Click += new System.EventHandler(this.Btn_DebugInfoClick);
			// 
			// txt_Help
			// 
			this.txt_Help.BackColor = System.Drawing.Color.White;
			this.txt_Help.Location = new System.Drawing.Point(0, 0);
			this.txt_Help.Multiline = true;
			this.txt_Help.Name = "txt_Help";
			this.txt_Help.ReadOnly = true;
			this.txt_Help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_Help.Size = new System.Drawing.Size(559, 246);
			this.txt_Help.TabIndex = 5;
			// 
			// lnk_Releases
			// 
			this.lnk_Releases.AutoSize = true;
			this.lnk_Releases.Location = new System.Drawing.Point(154, 250);
			this.lnk_Releases.Name = "lnk_Releases";
			this.lnk_Releases.Size = new System.Drawing.Size(51, 15);
			this.lnk_Releases.TabIndex = 4;
			this.lnk_Releases.TabStop = true;
			this.lnk_Releases.Text = "Releases";
			this.lnk_Releases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_ReleasesLinkClicked);
			// 
			// lnk_Email
			// 
			this.lnk_Email.AutoSize = true;
			this.lnk_Email.Location = new System.Drawing.Point(211, 250);
			this.lnk_Email.Name = "lnk_Email";
			this.lnk_Email.Size = new System.Drawing.Size(136, 15);
			this.lnk_Email.TabIndex = 3;
			this.lnk_Email.TabStop = true;
			this.lnk_Email.Text = "BladeMight@gmail.com";
			this.lnk_Email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_EmailLinkClicked);
			// 
			// lnk_Wiki
			// 
			this.lnk_Wiki.AutoSize = true;
			this.lnk_Wiki.Location = new System.Drawing.Point(118, 250);
			this.lnk_Wiki.Name = "lnk_Wiki";
			this.lnk_Wiki.Size = new System.Drawing.Size(30, 15);
			this.lnk_Wiki.TabIndex = 2;
			this.lnk_Wiki.TabStop = true;
			this.lnk_Wiki.Text = "Wiki";
			this.lnk_Wiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_WikiLinkClicked);
			// 
			// lnk_Site
			// 
			this.lnk_Site.AutoSize = true;
			this.lnk_Site.Location = new System.Drawing.Point(86, 250);
			this.lnk_Site.Name = "lnk_Site";
			this.lnk_Site.Size = new System.Drawing.Size(26, 15);
			this.lnk_Site.TabIndex = 1;
			this.lnk_Site.TabStop = true;
			this.lnk_Site.Text = "Site";
			this.lnk_Site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_SiteLinkClicked);
			// 
			// lnk_Repository
			// 
			this.lnk_Repository.AutoSize = true;
			this.lnk_Repository.Location = new System.Drawing.Point(8, 250);
			this.lnk_Repository.Name = "lnk_Repository";
			this.lnk_Repository.Size = new System.Drawing.Size(72, 15);
			this.lnk_Repository.TabIndex = 0;
			this.lnk_Repository.TabStop = true;
			this.lnk_Repository.Text = "Source code";
			this.lnk_Repository.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_RepositoryLinkClicked);
			// 
			// btn_OK
			// 
			this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_OK.Location = new System.Drawing.Point(0, 303);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(121, 27);
			this.btn_OK.TabIndex = 1;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.Btn_OKClick);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(444, 303);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(121, 27);
			this.btn_Cancel.TabIndex = 2;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
			// 
			// btn_Apply
			// 
			this.btn_Apply.Location = new System.Drawing.Point(222, 303);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(121, 27);
			this.btn_Apply.TabIndex = 3;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.UseVisualStyleBackColor = true;
			this.btn_Apply.Click += new System.EventHandler(this.Btn_ApplyClick);
			// 
			// HelpMeUnderstand
			// 
			this.HelpMeUnderstand.AutoPopDelay = 20000;
			this.HelpMeUnderstand.InitialDelay = 500;
			this.HelpMeUnderstand.ReshowDelay = 100;
			this.HelpMeUnderstand.ShowAlways = true;
			this.HelpMeUnderstand.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.HelpMeUnderstand.Popup += new System.Windows.Forms.PopupEventHandler(this.HelpMeUnderstandPopup);
			// 
			// MahouUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 331);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.tabs);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::Mahou.Properties.Resources.Mahou;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MahouUI";
			this.Text = "MahouUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MahouUIFormClosing);
			this.tabs.ResumeLayout(false);
			this.tab_functions.ResumeLayout(false);
			this.tab_functions.PerformLayout();
			this.tab_layouts.ResumeLayout(false);
			this.tab_layouts.PerformLayout();
			this.grb_Layouts.ResumeLayout(false);
			this.grb_Keys.ResumeLayout(false);
			this.tab_appearence.ResumeLayout(false);
			this.tab_appearence.PerformLayout();
			this.grb_LangTTAppearence.ResumeLayout(false);
			this.grb_LangTTAppearence.PerformLayout();
			this.grb_LangTTPositon.ResumeLayout(false);
			this.grb_LangTTPositon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTPositionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTPositionX)).EndInit();
			this.grb_LangTTSize.ResumeLayout(false);
			this.grb_LangTTSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTHeight)).EndInit();
			this.tab_timings.ResumeLayout(false);
			this.tab_timings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_SelectedTextGetTriesCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_CapsLockRefreshRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_ScrollLockRefreshRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_TrayFlagRefreshRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_DoubleHK2ndPressWaitTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTCaretRefreshRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_LangTTMouseRefreshRate)).EndInit();
			this.tab_snippets.ResumeLayout(false);
			this.tab_snippets.PerformLayout();
			this.tab_hotkeys.ResumeLayout(false);
			this.grb_Hotkey.ResumeLayout(false);
			this.grb_Hotkey.PerformLayout();
			this.tab_updates.ResumeLayout(false);
			this.grb_DownloadUpdate.ResumeLayout(false);
			this.grb_ProxyConfig.ResumeLayout(false);
			this.grb_ProxyConfig.PerformLayout();
			this.grb_MahouReleaseTitle.ResumeLayout(false);
			this.grb_MahouReleaseTitle.PerformLayout();
			this.tab_about.ResumeLayout(false);
			this.tab_about.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}