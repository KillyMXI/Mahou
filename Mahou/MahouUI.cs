using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Net;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Mahou {
	public partial class MahouUI : Form {
		#region Variables
		// Hotkeys, HKC => HotKey Convert
		public Hotkey Mainhk, ExitHk, HKCLast, HKCSelection, HKCLine, HKSymIgn, HKConMorWor,
			  	      HKTitleCase, HKRandomCase, HKSwapCase, HKTransliteration;
		/// <summary>
		/// Directory where Mahou.exe is.
		/// </summary>
		public static string nPath = AppDomain.CurrentDomain.BaseDirectory;
		public static bool LoggingEnabled;
		static string[] UpdInfo;
		static bool updating, was, isold = true, checking;
		static Timer tmr = new Timer();
		static Timer old = new Timer();
		static Timer animate = new Timer();
		static Timer showUpdWnd = new Timer();
		static int progress = 0, _progress = 0;
		int titlebar = 12;
		public static int AtUpdateShow;
		public int DoubleHKInterval = 200, SelectedTextGetMoreTriesCount;
		#region Temporary variables
		/// <summary>
		/// In memory settings, for timers/hooks.
		/// </summary>
		public bool DiffAppearenceForLayouts, LDForCaretOnChange, LDForMouseOnChange, ScrollTip, AddOneSpace,
					TrayFlags, SymIgnEnabled, TrayIconVisible, SnippetsEnabled, ChangeLayouByKey, EmulateLS,
					RePress, BlockHKWithCtrl, blueIcon, SwitchBetweenLayouts, SelectedTextGetMoreTries, ReSelect,
					ConvertSelectionLS, ConvertSelectionLSPlus, MCDSSupport, OneLayoutWholeWord;
		/// <summary>
		/// Temporary modifiers of hotkeys.
		/// </summary>
		string Mainhk_tempMods, ExitHk_tempMods, HKCLast_tempMods, HKCSelection_tempMods, 
			    HKCLine_tempMods, HKSymIgn_tempMods, HKConMorWor_tempMods, HKTitleCase_tempMods,
 				HKRandomCase_tempMods, HKSwapCase_tempMods, HKTransliteration_tempMods, HKRestart_tempMods;
		/// <summary>
		/// Temporary key of hotkeys.
		/// </summary>
		int Mainhk_tempKey, ExitHk_tempKey, HKCLast_tempKey, HKCSelection_tempKey,
			    HKCLine_tempKey, HKSymIgn_tempKey, HKConMorWor_tempKey, HKTitleCase_tempKey,
 				HKRandomCase_tempKey, HKSwapCase_tempKey, HKTransliteration_tempKey, HKRestart_tempKey;
		/// <summary>
		/// Temporary Enabled of hotkeys.
		/// </summary>
		bool Mainhk_tempEnabled, ExitHk_tempEnabled, HKCLast_tempEnabled, HKCSelection_tempEnabled,
			    HKCLine_tempEnabled, HKSymIgn_tempEnabled, HKConMorWor_tempEnabled, HKTitleCase_tempEnabled,
 				HKRandomCase_tempEnabled, HKSwapCase_tempEnabled, HKTransliteration_tempEnabled, HKRestart_tempEnabled;
		/// <summary>
		/// Temporary Double of hotkeys.
		/// </summary>
		bool Mainhk_tempDouble, ExitHk_tempDouble, HKCLast_tempDouble, HKCSelection_tempDouble,
			    HKCLine_tempDouble, HKSymIgn_tempDouble, HKConMorWor_tempDouble, HKTitleCase_tempDouble,
 				HKRandomCase_tempDouble, HKSwapCase_tempDouble, HKTransliteration_tempDouble;
		/// <summary>
		/// Temporary colors of LangDisplays appearece.
		/// </summary>
		public Color LDMouseFore_temp, LDCaretFore_temp, LDMouseBack_temp, LDCaretBack_temp, 
		 	  Layout1Fore_temp, Layout2Fore_temp, Layout1Back_temp, Layout2Back_temp;
		/// <summary>
		/// Temporary fonts of LangDisplays appearece.
		/// </summary>
		public Font LDMouseFont_temp, LDCaretFont_temp, Layout1Font_temp, Layout2Font_temp;
		/// <summary>
		/// Temporary transparent backgrounds of LangDisplays appearece.
		/// </summary>
		public bool LDMouseTransparentBack_temp, LDCaretTransparentBack_temp,
     		 Layout1TransparentBack_temp, Layout2TransparentBack_temp;
		/// <summary>
		/// Temporary positions of LangDisplays appearece.
		/// </summary>
		public int LDMouseY_Pos_temp, LDCaretY_Pos_temp, LDMouseX_Pos_temp, LDCaretX_Pos_temp, 
		 	  Layout1Y_Pos_temp, Layout2Y_Pos_temp, Layout1X_Pos_temp, Layout2X_Pos_temp,
		 	  MCDS_Xpos_temp, MCDS_Ypos_temp, MCDS_TopIndent_temp, MCDS_BottomIndent_temp;
		/// <summary>
		/// Temporary sizes of LangDisplays appearece.
		/// </summary>
		public int LDMouseHeight_temp, LDCaretHeight_temp, LDMouseWidth_temp, LDCaretWidth_temp, 
		 	  Layout1Height_temp, Layout2Height_temp, Layout1Width_temp, Layout2Width_temp;
		/// <summary>
		/// Temporary hotkey key of hotkey in txt_Hotkey.
		/// </summary>
		int txt_Hotkey_tempKey;
		/// <summary>
		/// Temporary hotkey modifiers of hotkey in txt_Hotkey.
		/// </summary>
		string txt_Hotkey_tempModifiers;
		/// <summary>
		/// Temporary layouts, etc..
		/// </summary>
		public string Layout1, Layout2, Layout3, Layout4, 
			MainLayout1, MainLayout2, EmulateLSType, ExcludedPrograms, Layout1TText, Layout2TText;
		/// <summary>
		/// Temporary specific keys.
		/// </summary>
		public int Key1, Key2, Key3, Key4;
		#endregion
		public TrayIcon icon;
		public Timer ICheck = new Timer();
		public Timer ScrlCheck = new Timer();
		public Timer crtCheck = new Timer();
		public Timer capsCheck = new Timer();
		public Timer flagsCheck = new Timer();
		public LangDisplay mouseLangDisplay = new LangDisplay();
		public LangDisplay caretLangDisplay = new LangDisplay();
		uint latestL = 0, latestCL = 0;
		public uint currentLayout = 0;
		bool onepass = true, onepassC = true;
		string latestSwitch = "null";
		public Timer res = new Timer();
		// From more configs
		ColorDialog clrd = new ColorDialog();
		FontDialog fntd = new FontDialog();
		public static FontConverter fcv = new FontConverter();
		public static string snipfile = Path.Combine(MahouUI.nPath, "snippets.txt");
		#endregion
		public MahouUI() {
			InitializeComponent();
			InitializeTrayIcon();
			LoadConfigs();
			InitializeListBoxes();
		    nud_CapsLockRefreshRate.Minimum = nud_DoubleHK2ndPressWaitTime.Minimum =
		        nud_LangTTCaretRefreshRate.Minimum = nud_LangTTMouseRefreshRate.Minimum = 
		    	nud_ScrollLockRefreshRate.Minimum = nud_TrayFlagRefreshRate.Minimum = 1;
			Text = "Mahou " + Assembly.GetExecutingAssembly().GetName().Version;
			nud_LangTTPositionX.Minimum = nud_LangTTPositionY.Minimum = -100;
			RegisterRestartHotkey();
			RefreshAllIcons();
			//Background startup check for updates
			if (MMain.MyConfs.ReadBool("Functions", "StartupUpdatesCheck")) {
				var uche = new System.Threading.Thread(StartupCheck);
				uche.Name = "Startup Check";
				uche.Start();
				showUpdWnd.Tick += (_, __) => {
					if (AtUpdateShow == 1) {
						tabs.SelectedIndex = 6;
						SetUInfo();
						Visible = TopMost = true;
						grb_DownloadUpdate.Enabled = true;
						btn_DownloadUpdate.PerformClick();
						showUpdWnd.Stop();
						showUpdWnd.Dispose();
					}
					if (AtUpdateShow == 2) {
						showUpdWnd.Stop();
						showUpdWnd.Dispose();
					}
				};
				showUpdWnd.Interval = 1000;
				showUpdWnd.Start();
			} else { showUpdWnd.Dispose(); }
			Memory.Flush();
		}
		#region WndProc & Functions
		protected override void WndProc(ref Message m) {
			if (m.Msg == MMain.ao) { // ao = Already Opened
				ToggleVisibility();
        		Logging.Log("Another instance detected, closing it.");
			}
			if (m.Msg == WinAPI.WM_HOTKEY && m.WParam.ToInt32() == 7) {
				int MahouPID = Process.GetCurrentProcess().Id;
				MMain.mahou.icon.Hide();
				//Batch script to restart Mahou.
				var restartMahou =
					@"@ECHO OFF
REM You should never see this file, if you are it means during restarting Mahou something went wrong. 
chcp 65001
SET MAHOUDIR=" + nPath + @"
TASKKILL /PID " + MahouPID + @" /F
TASKKILL /IM Mahou.exe /F
START """" ""%MAHOUDIR%Mahou.exe""
DEL %MAHOUDIR%RestartMahou.cmd";
				Logging.Log("Writing restart script.");
				File.WriteAllText(Path.Combine(new string[] {
					nPath,
					"RestartMahou.cmd"
				}), restartMahou);
				var piRestartMahou = new ProcessStartInfo();
				piRestartMahou.FileName = Path.Combine(new string[] {
					nPath,
					"RestartMahou.cmd"
				});
				piRestartMahou.WindowStyle = ProcessWindowStyle.Hidden;
				Logging.Log("Starting restart script.");
				Process.Start(piRestartMahou);
			}
			base.WndProc(ref m);
		}
		/// <summary>
		/// Restores temporary variables from settings.
		/// </summary>
		void LoadTemps() {
			//This creates(silently) new config file if existed one disappeared o_O
			// Restores temps
			#region Hotkey enableds
			Mainhk_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ToggleMainWindow_Enabled");
			HKCLast_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastWord_Enabled");
			HKCSelection_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ConvertSelectedText_Enabled");
			HKCLine_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastLine_Enabled");
			HKConMorWor_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastWords_Enabled");
			HKSymIgn_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ToggleSymbolIgnoreMode_Enabled");
			HKTitleCase_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToTitleCase_Enabled");
			HKRandomCase_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToRandomCase_Enabled");
			HKSwapCase_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToSwapCase_Enabled");
			HKTransliteration_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextTransliteration_Enabled");
			ExitHk_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "ExitMahou_Enabled");
			HKRestart_tempEnabled = MMain.MyConfs.ReadBool("Hotkeys", "RestartMahou_Enabled");
			#endregion
			#region Hotkey doubles
			Mainhk_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ToggleMainWindow_Double");
			HKCLast_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastWord_Double");
			HKCSelection_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ConvertSelectedText_Double");
			HKCLine_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastLine_Double");
			HKConMorWor_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ConvertLastWords_Double");
			HKSymIgn_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ToggleSymbolIgnoreMode_Double");
			HKTitleCase_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToTitleCase_Double");
			HKRandomCase_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToRandomCase_Double");
			HKSwapCase_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextToSwapCase_Double");
			HKTransliteration_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "SelectedTextTransliteration_Double");
			ExitHk_tempDouble = MMain.MyConfs.ReadBool("Hotkeys", "ExitMahou_Double");
			#endregion
			#region Hotkey modifiers
			Mainhk_tempMods = MMain.MyConfs.Read("Hotkeys", "ToggleMainWindow_Modifiers");
			HKCLast_tempMods = MMain.MyConfs.Read("Hotkeys", "ConvertLastWord_Modifiers");
			HKCSelection_tempMods = MMain.MyConfs.Read("Hotkeys", "ConvertSelectedText_Modifiers");
			HKCLine_tempMods = MMain.MyConfs.Read("Hotkeys", "ConvertLastLine_Modifiers");
			HKConMorWor_tempMods = MMain.MyConfs.Read("Hotkeys", "ConvertLastWords_Modifiers");
			HKSymIgn_tempMods = MMain.MyConfs.Read("Hotkeys", "ToggleSymbolIgnoreMode_Modifiers");
			HKTitleCase_tempMods = MMain.MyConfs.Read("Hotkeys", "SelectedTextToTitleCase_Modifiers");
			HKRandomCase_tempMods = MMain.MyConfs.Read("Hotkeys", "SelectedTextToRandomCase_Modifiers");
			HKSwapCase_tempMods = MMain.MyConfs.Read("Hotkeys", "SelectedTextToSwapCase_Modifiers");
			HKTransliteration_tempMods = MMain.MyConfs.Read("Hotkeys", "SelectedTextTransliteration_Modifiers");
			ExitHk_tempMods = MMain.MyConfs.Read("Hotkeys", "ExitMahou_Modifiers");
			HKRestart_tempMods = MMain.MyConfs.Read("Hotkeys", "RestartMahou_Modifiers");
			#endregion
			#region Hotkey keys
			Mainhk_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ToggleMainWindow_Key");
			HKCLast_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ConvertLastWord_Key");
			HKCSelection_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ConvertSelectedText_Key");		
			HKCLine_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ConvertLastLine_Key");
			HKConMorWor_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ConvertLastWords_Key");
			HKSymIgn_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ToggleSymbolIgnoreMode_Key");
			HKTitleCase_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "SelectedTextToTitleCase_Key");
			HKRandomCase_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "SelectedTextToRandomCase_Key");
			HKSwapCase_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "SelectedTextToSwapCase_Key");
			HKTransliteration_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "SelectedTextTransliteration_Key");
			ExitHk_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "ExitMahou_Key");
			HKRestart_tempKey = MMain.MyConfs.ReadInt("Hotkeys", "RestartMahou_Key");
			#endregion
			#region Lang Display colors
			LDMouseFore_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "MouseLTForeColor"));
			LDCaretFore_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "CaretLTForeColor"));
			LDMouseBack_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "MouseLTBackColor"));
			LDCaretBack_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "CaretLTBackColor"));
			Layout1Fore_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "Layout1ForeColor"));
			Layout2Fore_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "Layout2ForeColor"));
			Layout1Back_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "Layout1BackColor"));
			Layout2Back_temp = ColorTranslator.FromHtml(MMain.MyConfs.Read("Appearence", "Layout2BackColor"));
			LDMouseFont_temp = (Font)fcv.ConvertFromString(MMain.MyConfs.Read("Appearence", "MouseLTFont"));
			LDCaretFont_temp = (Font)fcv.ConvertFromString(MMain.MyConfs.Read("Appearence", "CaretLTFont"));
			Layout1Font_temp = (Font)fcv.ConvertFromString(MMain.MyConfs.Read("Appearence", "Layout1Font"));
			Layout2Font_temp = (Font)fcv.ConvertFromString(MMain.MyConfs.Read("Appearence", "Layout2Font"));
			// Transparent background colors
			LDMouseTransparentBack_temp = MMain.MyConfs.ReadBool("Appearence", "MouseLTTransparentBackColor");
			LDCaretTransparentBack_temp = MMain.MyConfs.ReadBool("Appearence", "CaretLTTransparentBackColor");
			Layout1TransparentBack_temp = MMain.MyConfs.ReadBool("Appearence", "Layout1TransparentBackColor");
			Layout2TransparentBack_temp = MMain.MyConfs.ReadBool("Appearence", "Layout2TransparentBackColor");
			#endregion
			#region Lang Display poisitions & sizes
			LDMouseY_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "MouseLTPositionY");
			LDCaretY_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "CaretLTPositionY");
			LDMouseX_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "MouseLTPositionX");
			LDCaretX_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "CaretLTPositionX");
		    Layout1Y_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "Layout1PositionY");
			Layout2Y_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "Layout2PositionY");
			Layout1X_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "Layout1PositionX");
			Layout2X_Pos_temp = MMain.MyConfs.ReadInt("Appearence", "Layout2PositionX");
			
			LDMouseHeight_temp = MMain.MyConfs.ReadInt("Appearence", "MouseLTHeight");		
			LDCaretHeight_temp = MMain.MyConfs.ReadInt("Appearence", "CaretLTHeight");
			LDMouseWidth_temp = MMain.MyConfs.ReadInt("Appearence", "MouseLTWidth");
			LDCaretWidth_temp = MMain.MyConfs.ReadInt("Appearence", "MouseLTWidth");
		    Layout1Height_temp = MMain.MyConfs.ReadInt("Appearence", "Layout1Height");
			Layout2Height_temp = MMain.MyConfs.ReadInt("Appearence", "Layout2Height");
			Layout1Width_temp = MMain.MyConfs.ReadInt("Appearence", "Layout1Width");
			Layout2Width_temp = MMain.MyConfs.ReadInt("Appearence", "Layout2Width");
			// MCDS
			MCDS_Xpos_temp = MMain.MyConfs.ReadInt("Appearence", "MCDS_Pos_X");
			MCDS_Ypos_temp = MMain.MyConfs.ReadInt("Appearence", "MCDS_Pos_Y");
			MCDS_TopIndent_temp = MMain.MyConfs.ReadInt("Appearence", "MCDS_Top");
			MCDS_BottomIndent_temp = MMain.MyConfs.ReadInt("Appearence", "MCDS_Bottom");
			// Diff text for layouts
			Layout1TText = MMain.MyConfs.Read("Appearence", "Layout1LTText");
			Layout2TText = MMain.MyConfs.Read("Appearence", "Layout2LTText");
			#endregion
		}
		void SaveFromTemps() {
			UpdateHotkeyTemps();
			#region Hotkey enableds
			MMain.MyConfs.Write("Hotkeys", "ToggleMainWindow_Enabled", Mainhk_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWord_Enabled", HKCLast_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertSelectedText_Enabled", HKCSelection_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastLine_Enabled", HKCLine_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWords_Enabled", HKConMorWor_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ToggleSymbolIgnoreMode_Enabled", HKSymIgn_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToTitleCase_Enabled", HKTitleCase_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToRandomCase_Enabled", HKRandomCase_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToSwapCase_Enabled", HKSwapCase_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextTransliteration_Enabled", HKTransliteration_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "ExitMahou_Enabled", ExitHk_tempEnabled.ToString());
			MMain.MyConfs.Write("Hotkeys", "RestartMahou_Enabled", HKRestart_tempEnabled.ToString());
			#endregion
			#region Hotkey doubles
			MMain.MyConfs.Write("Hotkeys", "ToggleMainWindow_Double", Mainhk_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWord_Double", HKCLast_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertSelectedText_Double", HKCSelection_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastLine_Double", HKCLine_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWords_Double", HKConMorWor_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ToggleSymbolIgnoreMode_Double", HKSymIgn_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToTitleCase_Double", HKTitleCase_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToRandomCase_Double", HKRandomCase_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToSwapCase_Double", HKSwapCase_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextTransliteration_Double", HKTransliteration_tempDouble.ToString());
			MMain.MyConfs.Write("Hotkeys", "ExitMahou_Double", ExitHk_tempDouble.ToString());
			#endregion
			#region Hotkey modifiers
			MMain.MyConfs.Write("Hotkeys", "ToggleMainWindow_Modifiers", Mainhk_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWord_Modifiers", HKCLast_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ConvertSelectedText_Modifiers", HKCSelection_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ConvertLastLine_Modifiers", HKCLine_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWords_Modifiers", HKConMorWor_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ToggleSymbolIgnoreMode_Modifiers", HKSymIgn_tempMods);
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToTitleCase_Modifiers", HKTitleCase_tempMods);
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToRandomCase_Modifiers", HKRandomCase_tempMods);
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToSwapCase_Modifiers", HKSwapCase_tempMods);
			MMain.MyConfs.Write("Hotkeys", "SelectedTextTransliteration_Modifiers", HKTransliteration_tempMods);
			MMain.MyConfs.Write("Hotkeys", "ExitMahou_Modifiers", ExitHk_tempMods);
			MMain.MyConfs.Write("Hotkeys", "RestartMahou_Modifiers", HKRestart_tempMods);
			#endregion
			#region Hotkey keys
			MMain.MyConfs.Write("Hotkeys", "ToggleMainWindow_Key", Mainhk_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWord_Key", HKCLast_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertSelectedText_Key", HKCSelection_tempKey.ToString());		
			MMain.MyConfs.Write("Hotkeys", "ConvertLastLine_Key", HKCLine_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "ConvertLastWords_Key", HKConMorWor_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "ToggleSymbolIgnoreMode_Key", HKSymIgn_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToTitleCase_Key", HKTitleCase_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToRandomCase_Key", HKRandomCase_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextToSwapCase_Key", HKSwapCase_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "SelectedTextTransliteration_Key", HKTransliteration_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "ExitMahou_Key", ExitHk_tempKey.ToString());
			MMain.MyConfs.Write("Hotkeys", "RestartMahou_Key", HKRestart_tempKey.ToString());
			#endregion
			UpdateLangDisplayTemps();
			#region Lang Display colors
			MMain.MyConfs.Write("Appearence", "MouseLTForeColor", ColorTranslator.ToHtml(LDMouseFore_temp));
			MMain.MyConfs.Write("Appearence", "CaretLTForeColor", ColorTranslator.ToHtml(LDCaretFore_temp));
			MMain.MyConfs.Write("Appearence", "MouseLTBackColor", ColorTranslator.ToHtml(LDMouseBack_temp));
			MMain.MyConfs.Write("Appearence", "CaretLTBackColor", ColorTranslator.ToHtml(LDCaretBack_temp));
			MMain.MyConfs.Write("Appearence", "Layout1ForeColor", ColorTranslator.ToHtml(Layout1Fore_temp));
			MMain.MyConfs.Write("Appearence", "Layout2ForeColor", ColorTranslator.ToHtml(Layout2Fore_temp));
			MMain.MyConfs.Write("Appearence", "Layout1BackColor", ColorTranslator.ToHtml(Layout1Back_temp));
			MMain.MyConfs.Write("Appearence", "Layout2BackColor", ColorTranslator.ToHtml(Layout2Back_temp));
			MMain.MyConfs.Write("Appearence", "MouseLTFont", fcv.ConvertToString(LDMouseFont_temp));
			MMain.MyConfs.Write("Appearence", "CaretLTFont", fcv.ConvertToString(LDCaretFont_temp));
			MMain.MyConfs.Write("Appearence", "Layout1Font", fcv.ConvertToString(Layout1Font_temp));
			MMain.MyConfs.Write("Appearence", "Layout2Font", fcv.ConvertToString(Layout2Font_temp));
			// Transparent background colors
			MMain.MyConfs.Write("Appearence", "MouseLTTransparentBackColor", LDMouseTransparentBack_temp.ToString());
			MMain.MyConfs.Write("Appearence", "CaretLTTransparentBackColor", LDCaretTransparentBack_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout1TransparentBackColor", Layout1TransparentBack_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout2TransparentBackColor", Layout2TransparentBack_temp.ToString());
			#endregion
			#region Lang Display poisitions & sizes
			MMain.MyConfs.Write("Appearence", "MouseLTPositionY", LDMouseY_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "CaretLTPositionY", LDCaretY_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MouseLTPositionX", LDMouseX_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "CaretLTPositionX", LDCaretX_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout1PositionY", Layout1Y_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout2PositionY", Layout2Y_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout1PositionX", Layout1X_Pos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout2PositionX", Layout2X_Pos_temp.ToString());
			
			MMain.MyConfs.Write("Appearence", "MouseLTHeight", LDMouseHeight_temp.ToString());		
			MMain.MyConfs.Write("Appearence", "CaretLTHeight", LDCaretHeight_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MouseLTWidth", LDMouseWidth_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MouseLTWidth", LDCaretWidth_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout1Height", Layout1Height_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout2Height", Layout2Height_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout1Width", Layout1Width_temp.ToString());
			MMain.MyConfs.Write("Appearence", "Layout2Width", Layout2Width_temp.ToString());
			// MCDS
			MMain.MyConfs.Write("Appearence", "MCDS_Pos_X", MCDS_Xpos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MCDS_Pos_Y", MCDS_Ypos_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MCDS_Top", MCDS_TopIndent_temp.ToString());
			MMain.MyConfs.Write("Appearence", "MCDS_Bottom", MCDS_BottomIndent_temp.ToString());
			// Diff text for layouts
			MMain.MyConfs.Write("Appearence", "Layout1LTText", Layout1TText);
			MMain.MyConfs.Write("Appearence", "Layout2LTText", Layout2TText);
			#endregion
			Logging.Log("Saved from temps.");
		}
		/// <summary>
		/// Saves current settings to INI.
		/// </summary>
		void SaveConfigs() {
			var tmpLangTTAppearenceIndex = lsb_LangTTAppearenceForList.SelectedIndex;
			var tmpHotkeysIndex = lsb_Hotkeys.SelectedIndex;
			#region Functions
			MMain.MyConfs.Write("Functions", "TrayIconVisible", chk_TrayIcon.Checked.ToString());
			MMain.MyConfs.Write("Functions", "ConvertSelectionLayoutSwitching", chk_CSLayoutSwitching.Checked.ToString());
			MMain.MyConfs.Write("Functions", "ReSelect", chk_ReSelect.Checked.ToString());
			MMain.MyConfs.Write("Functions", "RePress", chk_RePress.Checked.ToString());
			MMain.MyConfs.Write("Functions", "AddOneSpaceToLastWord", chk_AddOneSpace.Checked.ToString());
			MMain.MyConfs.Write("Functions", "ConvertSelectionLayoutSwitchingPlus", chk_CSLayoutSwitchingPlus.Checked.ToString());
			MMain.MyConfs.Write("Functions", "ScrollTip", chk_HighlightScroll.Checked.ToString());
			MMain.MyConfs.Write("Functions", "StartupUpdatesCheck", chk_StartupUpdatesCheck.Checked.ToString());
			MMain.MyConfs.Write("Functions", "Logging", chk_Logging.Checked.ToString());
			MMain.MyConfs.Write("Functions", "TrayFlags", chk_FlagsInTray.Checked.ToString());
			MMain.MyConfs.Write("Functions", "CapsLockTimer", chk_CapsLockDTimer.Checked.ToString());
			MMain.MyConfs.Write("Functions", "BlockMahouHotkeysWithCtrl", chk_BlockHKWithCtrl.Checked.ToString());
			MMain.MyConfs.Write("Functions", "MCDServerSupport", chk_MCDS_support.Checked.ToString());
			MMain.MyConfs.Write("Functions", "OneLayoutWholeWord", chk_OneLayoutWholeWord.Checked.ToString());
			#endregion
			#region Layouts
			MMain.MyConfs.Write("Layouts", "SwitchBetweenLayouts", chk_SwitchBetweenLayouts.Checked.ToString());
			MMain.MyConfs.Write("Layouts", "EmulateLayoutSwitch", chk_EmulateLS.Checked.ToString());
			MMain.MyConfs.Write("Layouts", "ChangeToSpecificLayoutByKey", chk_SpecificLS.Checked.ToString());
			// Keys
			MMain.MyConfs.Write("Layouts", "SpecificKey1", cbb_Key1.SelectedIndex.ToString());
			MMain.MyConfs.Write("Layouts", "SpecificKey2", cbb_Key2.SelectedIndex.ToString());
			MMain.MyConfs.Write("Layouts", "SpecificKey3", cbb_Key3.SelectedIndex.ToString());
			MMain.MyConfs.Write("Layouts", "SpecificKey4", cbb_Key4.SelectedIndex.ToString());
			try {
				try { MMain.MyConfs.Write("Layouts", "EmulateLayoutSwitchType", cbb_EmulateType.SelectedItem.ToString()); } catch { }
				// Main Layouts
				try { MMain.MyConfs.Write("Layouts", "MainLayout1", cbb_MainLayout1.SelectedItem.ToString()); } catch { }
				try { MMain.MyConfs.Write("Layouts", "MainLayout2", cbb_MainLayout2.SelectedItem.ToString()); } catch { }
				// Layouts
				try { MMain.MyConfs.Write("Layouts", "SpecificLayout1", cbb_Layout1.SelectedItem.ToString()); } catch { }
				try { MMain.MyConfs.Write("Layouts", "SpecificLayout2", cbb_Layout2.SelectedItem.ToString()); } catch { }
				try { MMain.MyConfs.Write("Layouts", "SpecificLayout3", cbb_Layout3.SelectedItem.ToString()); } catch { }
				try { MMain.MyConfs.Write("Layouts", "SpecificLayout4", cbb_Layout4.SelectedItem.ToString()); } catch { }
			} catch { Logging.Log("Some settings in layouts tab failed to save, they are skipped."); }
			#endregion
			#region Appearence
			MMain.MyConfs.Write("Appearence", "DisplayLangTooltipForMouse", chk_LangTooltipMouse.Checked.ToString());
			MMain.MyConfs.Write("Appearence", "DisplayLangTooltipForCaret", chk_LangTooltipCaret.Checked.ToString());
			MMain.MyConfs.Write("Appearence", "DisplayLangTooltipForMouseOnChange", chk_LangTTMouseOnChange.Checked.ToString());
			MMain.MyConfs.Write("Appearence", "DisplayLangTooltipForCaretOnChange", chk_LangTTCaretOnChange.Checked.ToString());
			MMain.MyConfs.Write("Appearence", "DifferentColorsForLayouts", chk_LangTTDiffLayoutColors.Checked.ToString());
			try {
			MMain.MyConfs.Write("Appearence", "Language", cbb_Language.SelectedItem.ToString());
			} catch { 
				Logging.Log("Language saving failed, restored to English.");
				MMain.MyConfs.Write("Appearence", "Language", "English");
			}
			#endregion
			#region Timings
			MMain.MyConfs.Write("Timings", "LangTooltipForMouseRefreshRate", nud_LangTTMouseRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "LangTooltipForCaretRefreshRate", nud_LangTTCaretRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "DoubleHotkey2ndPressWait", nud_DoubleHK2ndPressWaitTime.Value.ToString());
			MMain.MyConfs.Write("Timings", "FlagsInTrayRefreshRate", nud_TrayFlagRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "ScrollLockStateRefreshRate", nud_ScrollLockRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "CapsLockDisableRefreshRate", nud_CapsLockRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "ScrollLockStateRefreshRate", nud_ScrollLockRefreshRate.Value.ToString());
			MMain.MyConfs.Write("Timings", "SelectedTextGetMoreTries", chk_SelectedTextGetMoreTries.Checked.ToString());
			MMain.MyConfs.Write("Timings", "SelectedTextGetMoreTriesCount", nud_SelectedTextGetTriesCount.Value.ToString());
			MMain.MyConfs.Write("Timings", "ExcludedPrograms", txt_ExcludedPrograms.Text);
			#endregion
			#region Snippets
			MMain.MyConfs.Write("Snippets", "SnippetsEnabled", chk_Snippets.Checked.ToString());
			if (chk_Snippets.Checked)
				File.WriteAllText(snipfile, txt_Snippets.Text);
			#endregion
			#region Appearence & Hotkeys
			SaveFromTemps();
			#endregion
			#region Proxy
			MMain.MyConfs.Write("Proxy", "ServerPort", txt_ProxyServerPort.Text);
			MMain.MyConfs.Write("Proxy", "UserName", txt_ProxyLogin.Text);
			MMain.MyConfs.Write("Proxy", "Password", Convert.ToBase64String(Encoding.Unicode.GetBytes(txt_ProxyPassword.Text)));
			#endregion
			Logging.Log("All configurations saved.");
			LoadConfigs();
			lsb_LangTTAppearenceForList.SelectedIndex = tmpLangTTAppearenceIndex;
			lsb_Hotkeys.SelectedIndex = tmpHotkeysIndex;
		}
		/// <summary>
		/// Refresh all controls state from configs.
		/// </summary>
		void LoadConfigs() {
			InitLanguage();
			RefreshLanguage();
			#region Functions
			chk_AutoStart.Checked = File.Exists(Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.Startup),
				"Mahou.lnk")) ? true : false;
			TrayIconVisible = chk_TrayIcon.Checked = MMain.MyConfs.ReadBool("Functions", "TrayIconVisible");
			ConvertSelectionLS = chk_CSLayoutSwitching.Checked = MMain.MyConfs.ReadBool("Functions", "ConvertSelectionLayoutSwitching");
			ReSelect = chk_ReSelect.Checked = MMain.MyConfs.ReadBool("Functions", "ReSelect");
			RePress = chk_RePress.Checked = MMain.MyConfs.ReadBool("Functions", "RePress");
			AddOneSpace = chk_AddOneSpace.Checked = MMain.MyConfs.ReadBool("Functions", "AddOneSpaceToLastWord");
			ConvertSelectionLSPlus = chk_CSLayoutSwitchingPlus.Checked = MMain.MyConfs.ReadBool("Functions", "ConvertSelectionLayoutSwitchingPlus");
			ScrollTip = chk_HighlightScroll.Checked = MMain.MyConfs.ReadBool("Functions", "ScrollTip");
			chk_StartupUpdatesCheck.Checked = MMain.MyConfs.ReadBool("Functions", "StartupUpdatesCheck");
			LoggingEnabled = chk_Logging.Checked = MMain.MyConfs.ReadBool("Functions", "Logging");
			TrayFlags = chk_FlagsInTray.Checked = MMain.MyConfs.ReadBool("Functions", "TrayFlags");
			chk_CapsLockDTimer.Checked = MMain.MyConfs.ReadBool("Functions", "CapsLockTimer");
			BlockHKWithCtrl = chk_BlockHKWithCtrl.Checked = MMain.MyConfs.ReadBool("Functions", "BlockMahouHotkeysWithCtrl");
			SymIgnEnabled = MMain.MyConfs.ReadBool("Functions", "SymbolIgnoreModeEnabled");
			MCDSSupport = chk_MCDS_support.Checked = MMain.MyConfs.ReadBool("Functions", "MCDServerSupport");
			OneLayoutWholeWord = chk_OneLayoutWholeWord.Checked = MMain.MyConfs.ReadBool("Functions", "OneLayoutWholeWord");
			#endregion
			#region Layouts
			SwitchBetweenLayouts = chk_SwitchBetweenLayouts.Checked = MMain.MyConfs.ReadBool("Layouts", "SwitchBetweenLayouts");
			EmulateLS = chk_EmulateLS.Checked = MMain.MyConfs.ReadBool("Layouts", "EmulateLayoutSwitch");
			ChangeLayouByKey = chk_SpecificLS.Checked = MMain.MyConfs.ReadBool("Layouts", "ChangeToSpecificLayoutByKey");
			MainLayout1 = MMain.MyConfs.Read("Layouts", "MainLayout1");
			MainLayout2 = MMain.MyConfs.Read("Layouts", "MainLayout2");
			Layout1 = MMain.MyConfs.Read("Layouts", "SpecificLayout1");
			Layout2 = MMain.MyConfs.Read("Layouts", "SpecificLayout2");
			Layout3 = MMain.MyConfs.Read("Layouts", "SpecificLayout3");
			Layout4 = MMain.MyConfs.Read("Layouts", "SpecificLayout4");
			Key1 = MMain.MyConfs.ReadInt("Layouts", "SpecificKey1");
			Key2 = MMain.MyConfs.ReadInt("Layouts", "SpecificKey2");
			Key3 = MMain.MyConfs.ReadInt("Layouts", "SpecificKey3");
			Key4 = MMain.MyConfs.ReadInt("Layouts", "SpecificKey4");
			RefreshComboboxes();
			#endregion
			#region Appearence
			chk_LangTooltipMouse.Checked = MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForMouse");
			chk_LangTooltipCaret.Checked = MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForCaret");
			LDForMouseOnChange = chk_LangTTMouseOnChange.Checked = MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForMouseOnChange");
			LDForCaretOnChange = chk_LangTTCaretOnChange.Checked = MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForCaretOnChange");
			DiffAppearenceForLayouts = chk_LangTTDiffLayoutColors.Checked = MMain.MyConfs.ReadBool("Appearence", "DifferentColorsForLayouts");
			#endregion
			#region Timings
			nud_LangTTMouseRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "LangTooltipForMouseRefreshRate");
			nud_LangTTCaretRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "LangTooltipForCaretRefreshRate");
			nud_DoubleHK2ndPressWaitTime.Value = DoubleHKInterval =  MMain.MyConfs.ReadInt("Timings", "DoubleHotkey2ndPressWait");
			nud_TrayFlagRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "FlagsInTrayRefreshRate");
			nud_ScrollLockRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "ScrollLockStateRefreshRate");
			nud_CapsLockRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "CapsLockDisableRefreshRate");
			nud_ScrollLockRefreshRate.Value = MMain.MyConfs.ReadInt("Timings", "ScrollLockStateRefreshRate");
			SelectedTextGetMoreTries = chk_SelectedTextGetMoreTries.Checked = MMain.MyConfs.ReadBool("Timings", "SelectedTextGetMoreTries");
			nud_SelectedTextGetTriesCount.Value = MMain.MyConfs.ReadInt("Timings", "SelectedTextGetMoreTriesCount");
			ExcludedPrograms = txt_ExcludedPrograms.Text = MMain.MyConfs.Read("Timings", "ExcludedPrograms");
			SelectedTextGetMoreTriesCount = (int)nud_SelectedTextGetTriesCount.Value;
			#endregion
			#region Snippets
			SnippetsEnabled = chk_Snippets.Checked = MMain.MyConfs.ReadBool("Snippets", "SnippetsEnabled");
			if (File.Exists(snipfile)) {
				txt_Snippets.Text = File.ReadAllText(snipfile);
				KMHook.ReInitSnippets();
			}
			#endregion
			#region Appearence & Hotkeys
			LoadTemps();
			UpdateLangDisplayControlsSwitch();
			UpdateHotkeyControlsSwitch();
			#endregion
			#region Proxy
			txt_ProxyServerPort.Text = MMain.MyConfs.Read("Proxy", "ServerPort");
			txt_ProxyLogin.Text = MMain.MyConfs.Read("Proxy", "UserName");
			try {
				txt_ProxyPassword.Text = Encoding.Unicode.GetString(Convert.FromBase64String(MMain.MyConfs.Read("Proxy", "Password")));
			} catch { Logging.Log("Password invalidly encoded, reset to none.", 2); }
			#endregion
			InitializeHotkeys();
			InitializeTimers();
			ToggleDependentControlsEnabledState();
			RefreshAllIcons();
			// Unregister Restart Hotkey
			WinAPI.UnregisterHotKey(Handle, 7);
			RegisterRestartHotkey();
			Memory.Flush();
			Logging.Log("All configurations loaded.");
		}
		/// <summary>
		/// Refreshes comboboxes items.
		/// </summary>
		void RefreshComboboxes() {
			Locales.IfLessThan2();
			MMain.locales = Locales.AllList();
			cbb_Layout1.Items.Clear();
			cbb_Layout2.Items.Clear();
			cbb_Layout3.Items.Clear();
			cbb_Layout4.Items.Clear();
			cbb_MainLayout1.Items.Clear();
			cbb_MainLayout2.Items.Clear();
			MMain.lcnmid.Clear();
			cbb_Layout1.Items.Add(MMain.Lang[Languages.Element.SwitchBetween]);
			cbb_Layout2.Items.Add(MMain.Lang[Languages.Element.SwitchBetween]);
			cbb_Layout3.Items.Add(MMain.Lang[Languages.Element.SwitchBetween]);
			cbb_Layout4.Items.Add(MMain.Lang[Languages.Element.SwitchBetween]);
			foreach (Locales.Locale lc in MMain.locales) {
				cbb_Layout1.Items.Add(lc.Lang + "(" + lc.uId + ")");
				cbb_Layout2.Items.Add(lc.Lang + "(" + lc.uId + ")");
				cbb_Layout3.Items.Add(lc.Lang + "(" + lc.uId + ")");
				cbb_Layout4.Items.Add(lc.Lang + "(" + lc.uId + ")");
				cbb_MainLayout1.Items.Add(lc.Lang + "(" + lc.uId + ")");
				cbb_MainLayout2.Items.Add(lc.Lang + "(" + lc.uId + ")");
				MMain.lcnmid.Add(lc.Lang + "(" + lc.uId + ")");
			}
			try {
				cbb_Language.SelectedIndex = cbb_Language.Items.IndexOf(MMain._language);
				EmulateLSType = MMain.MyConfs.Read("Layouts", "EmulateLayoutSwitchType");
				cbb_EmulateType.SelectedIndex = cbb_EmulateType.Items.IndexOf(EmulateLSType);
				cbb_Layout1.SelectedIndex = cbb_Layout1.Items.IndexOf(Layout1);
				cbb_Layout2.SelectedIndex = cbb_Layout2.Items.IndexOf(Layout2);
				cbb_Layout3.SelectedIndex = cbb_Layout3.Items.IndexOf(Layout3);
				cbb_Layout4.SelectedIndex = cbb_Layout4.Items.IndexOf(Layout4);
				cbb_Key1.SelectedIndex = Key1;
				cbb_Key2.SelectedIndex = Key2;
				cbb_Key3.SelectedIndex = Key3;
				cbb_Key4.SelectedIndex = Key4;
				cbb_MainLayout1.SelectedIndex = MMain.lcnmid.IndexOf(MainLayout1);
				cbb_MainLayout2.SelectedIndex = MMain.lcnmid.IndexOf(MainLayout2);
			} catch (Exception e){
//				MessageBox.Show(MMain.Msgs[9], MMain.Msgs[5], MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				RefreshComboboxes();
				cbb_MainLayout1.SelectedIndex = 0;
				cbb_MainLayout2.SelectedIndex = 1;
				Logging.Log("Locales indexes select failed, error message:\n" + e.Message +"\n"+e.StackTrace+"\n", 1);
			}
			Logging.Log("Locales for ALL comboboxes refreshed.");
		}
		/// <summary>
		/// Toggles some controls enabled state based on some checkboxes checked state. 
		/// </summary>
		void ToggleDependentControlsEnabledState() {
			// Functions tab
			chk_CSLayoutSwitchingPlus.Enabled = chk_CSLayoutSwitching.Checked;
			chk_OneLayoutWholeWord.Enabled = !chk_CSLayoutSwitching.Checked;
			// Layouts tab
			grb_Keys.Enabled = grb_Layouts.Enabled = chk_SpecificLS.Checked;
			cbb_MainLayout1.Enabled = cbb_MainLayout2.Enabled = 
				lbl_LayoutNum1.Enabled = lbl_LayoutNum2.Enabled = chk_SwitchBetweenLayouts.Checked;
			lbl_EmuType.Enabled = cbb_EmulateType.Enabled = chk_SwitchBetweenLayouts.Enabled = chk_EmulateLS.Checked;
			if (chk_EmulateLS.Checked) {
				chk_SwitchBetweenLayouts.Enabled = chk_SwitchBetweenLayouts.Checked = false;
			} else { chk_SwitchBetweenLayouts.Enabled = true; }
			// Appearence tab
			chk_LangTTMouseOnChange.Enabled = chk_LangTooltipMouse.Checked;
			chk_LangTTCaretOnChange.Enabled = chk_LangTooltipCaret.Checked;
			lbl_LangTTBackgroundColor.Enabled = btn_LangTTBackgroundColor.Enabled = 
				!chk_LangTTTransparentColor.Checked;
			// Snippets tab
			txt_Snippets.Enabled = chk_Snippets.Checked;
			// Hotkeys tab
			chk_DoubleHotkey.Enabled = chk_WinInHotKey.Enabled = txt_Hotkey.Enabled = chk_HotKeyEnabled.Checked;
			chk_DoubleHotkey.Enabled = lsb_Hotkeys.SelectedIndex != 11;
			// Timings tab
			nud_SelectedTextGetTriesCount.Enabled = chk_SelectedTextGetMoreTries.Checked;
			lbl_ScrollLockRefreshRate.Enabled = nud_ScrollLockRefreshRate.Enabled = chk_HighlightScroll.Checked;
			lbl_CapsLockRefreshRate.Enabled = nud_CapsLockRefreshRate.Enabled = chk_CapsLockDTimer.Checked;
			lbl_FlagTrayRefreshRate.Enabled = nud_TrayFlagRefreshRate.Enabled = chk_FlagsInTray.Checked;
			lbl_LangTTCaretRefreshRate.Enabled = nud_LangTTCaretRefreshRate.Enabled = chk_LangTooltipCaret.Checked;
			lbl_LangTTMouseRefreshRate.Enabled = nud_LangTTMouseRefreshRate.Enabled = chk_LangTooltipMouse.Checked;
		}
		/// <summary>
		/// Toggles visibility of main window.
		/// </summary>
		public void ToggleVisibility() {
			Logging.Log("Mahou Main window visibility changed to ["+!Visible+"].");
			if (Visible) {
				Visible = false;
			} else {
				TopMost = Visible = true;
				TopMost = false;
			}
			// Sometimes when logging is enabled, hooks may die without error...
			// This fixes it, but you need manually to show/hide main window:
			// 1. Click tray icon. 2. Start Mahou.exe
			// This bug is under look...			
			if (MMain.MyConfs.ReadBool("Functions", "Logging")) {
				MMain.StopHook();MMain.StartHook();
				KMHook.win = KMHook.alt = KMHook.shift = KMHook.ctrl = false;
			}
			Memory.Flush();
		}
		/// <summary>
		/// Refreshes all icon's images and tray icon visibility.
		/// </summary>
		public void RefreshAllIcons() {
			if (TrayFlags) {
				ChangeTrayIconToFlag();
			} else {
				if (HKSymIgn_tempEnabled && SymIgnEnabled && icon.trIcon.Icon != Properties.Resources.MahouSymbolIgnoreMode)
					icon.trIcon.Icon = Properties.Resources.MahouSymbolIgnoreMode;
				else if (HKSymIgn_tempEnabled && SymIgnEnabled && icon.trIcon.Icon != Properties.Resources.MahouTrayHD)
					icon.trIcon.Icon = Properties.Resources.MahouTrayHD;
			}
			if (!blueIcon && HKSymIgn_tempEnabled && SymIgnEnabled) {
				blueIcon = true;
				Icon = Properties.Resources.MahouSymbolIgnoreMode;
			}
			else if (blueIcon && HKSymIgn_tempEnabled && !SymIgnEnabled ) {
				Icon = Properties.Resources.MahouTrayHD;
				blueIcon = false;
			}
			if (TrayIconVisible && !icon.trIcon.Visible) {
				icon.Show();
			} else if(!TrayIconVisible && icon.trIcon.Visible) {
				icon.Hide();
			}
		}
		/// <summary>
		/// Changes tray icon image to country flag based on current layout.
		/// </summary>
		void ChangeTrayIconToFlag() {
			int lcid = 0;
			if (currentLayout == 0)
				lcid = (int)(Locales.GetCurrentLocale() & 0xffff);
			else 
				lcid = (int)(currentLayout & 0xffff);
			if (lcid > 0) {
				var flagname = "jp";
				var clangname = new CultureInfo(lcid);
				flagname = clangname.ThreeLetterISOLanguageName.Substring(0, 2).ToLower();
//				Debug.WriteLine(flagname+" "+currentLayout+" "+lcid);
				var flag = Path.Combine(MahouUI.nPath, "Flags\\" + flagname + ".png");
				Icon flagicon = null;
				if (flagname != latestSwitch) {
					if (File.Exists(flag))
						flagicon = Icon.FromHandle(((Bitmap)Image.FromFile(flag)).GetHicon());
					else
						switch (flagname) {
							case "ru":
								flagicon = Icon.FromHandle(Properties.Resources.ru.GetHicon());
								break;
							case "en":
								flagicon = Icon.FromHandle(Properties.Resources.en.GetHicon());
								break;
							case "jp":
								flagicon = Icon.FromHandle(Properties.Resources.jp.GetHicon());
								break;
							case "bu":
								flagicon = Icon.FromHandle(Properties.Resources.bu.GetHicon());
								break;
							case "uk":
								flagicon = Icon.FromHandle(Properties.Resources.uk.GetHicon());
								break;
							case "po":
								flagicon = Icon.FromHandle(Properties.Resources.po.GetHicon());
								break;
							case "sw":
								flagicon = Icon.FromHandle(Properties.Resources.sw.GetHicon());
								break;
							case "zh":
								flagicon = Icon.FromHandle(Properties.Resources.zh.GetHicon());
								break;
							case "be":
								flagicon = Icon.FromHandle(Properties.Resources.be.GetHicon());
								break;
							case "de":
								flagicon = Icon.FromHandle(Properties.Resources.de.GetHicon());
								break;
							case "sp":
								flagicon = Icon.FromHandle(Properties.Resources.sp.GetHicon());
								break;
							case "it":
								flagicon = Icon.FromHandle(Properties.Resources.it.GetHicon());
								break;
							case "fr":
								flagicon = Icon.FromHandle(Properties.Resources.fr.GetHicon());
								break;
							default:
								flagicon = Icon;
								break;
						}
					latestSwitch = flagname;
					icon.trIcon.Icon = flagicon;
				}
			} else {
				Logging.Log("Layout id was ["+lcid+"].", 2);
			}
		}
		/// <summary>
		/// Initializes UI language.
		/// </summary>
		public static void InitLanguage() {
			MMain._language = MMain.MyConfs.Read("Appearence", "Language");
			if (MMain._language == "English")
				MMain.Lang = Languages.English;
			else if (MMain._language == "Русский")
				MMain.Lang = Languages.Russian;
		}
		/// <summary>
		/// Initializes language tooltips.
		/// </summary>
		public void InitLangDisplays() {
			mouseLangDisplay = new LangDisplay();
			caretLangDisplay = new LangDisplay();
			mouseLangDisplay.mouseDisplay = true;
			caretLangDisplay.caretDisplay = true;
			caretLangDisplay.AddOwnedForm(mouseLangDisplay); //Prevents flickering when tooltips are one on another 
		}
		/// <summary>
		/// Initializes tray icon.
		/// </summary>
		void InitializeTrayIcon() {
			icon = new TrayIcon(MMain.MyConfs.ReadBool("Functions", "TrayIconVisible"));
			icon.Exit += (_, __) => ExitProgram();
			icon.ShowHide += (_, __) => ToggleVisibility();
		}
		/// <summary>
		/// Initializes list boxes.
		/// </summary>
		void InitializeListBoxes() {
			lsb_Hotkeys.SelectedIndex = 0;
			lsb_LangTTAppearenceForList.SelectedIndex = 0;
		}
		/// <summary>
		/// Initializes all hotkeys.
		/// </summary>
		public void InitializeHotkeys() {
			Mainhk = new Hotkey(Mainhk_tempEnabled, Mainhk_tempKey, 
				Hotkey.GetMods(Mainhk_tempMods), Mainhk_tempDouble);
			HKCLast = new Hotkey(HKCLast_tempEnabled, HKCLast_tempKey, 
				Hotkey.GetMods(HKCLast_tempMods), HKCLast_tempDouble);			
			HKCSelection = new Hotkey(HKCSelection_tempEnabled, HKCSelection_tempKey, 
				Hotkey.GetMods(HKCSelection_tempMods), HKCSelection_tempDouble);			
			HKCLine = new Hotkey(HKCLine_tempEnabled, HKCLine_tempKey, 
				Hotkey.GetMods(HKCLine_tempMods), HKCLine_tempDouble);			
			HKSymIgn = new Hotkey(HKSymIgn_tempEnabled, HKSymIgn_tempKey, 
				Hotkey.GetMods(HKSymIgn_tempMods), HKSymIgn_tempDouble);			
			HKConMorWor = new Hotkey(HKConMorWor_tempEnabled, HKConMorWor_tempKey, 
				Hotkey.GetMods(HKConMorWor_tempMods), HKConMorWor_tempDouble);			
			HKTitleCase = new Hotkey(HKTitleCase_tempEnabled, HKTitleCase_tempKey, 
				Hotkey.GetMods(HKTitleCase_tempMods), HKTitleCase_tempDouble);			
			HKRandomCase = new Hotkey(HKRandomCase_tempEnabled, HKRandomCase_tempKey, 
				Hotkey.GetMods(HKRandomCase_tempMods), HKRandomCase_tempDouble);			
			HKSwapCase = new Hotkey(HKSwapCase_tempEnabled, HKSwapCase_tempKey,
				Hotkey.GetMods(HKSwapCase_tempMods), HKSwapCase_tempDouble);			
			HKTransliteration = new Hotkey(HKTransliteration_tempEnabled, HKTransliteration_tempKey, 
				Hotkey.GetMods(HKTransliteration_tempMods), HKTransliteration_tempDouble);
			ExitHk = new Hotkey(ExitHk_tempEnabled, ExitHk_tempKey, 
			    Hotkey.GetMods(ExitHk_tempMods), ExitHk_tempDouble);
			Logging.Log("Hotkeys initialized.");
		}
		/// <summary>
		/// Initializes timers.
		/// </summary>
		void InitializeTimers() {
			#region Reset Timers
			crtCheck.Stop();
			ICheck.Stop();
			ScrlCheck.Stop();
			res.Stop();
			old.Stop();
			capsCheck.Stop();
			flagsCheck.Stop();
			ICheck = new Timer();
			crtCheck = new Timer();
			ScrlCheck = new Timer();
			res = new Timer();
			capsCheck = new Timer();
			flagsCheck = new Timer();
			old = new Timer();
			KMHook.doublekey = new Timer();
			#endregion
			crtCheck.Interval = MMain.MyConfs.ReadInt("Timings", "LangTooltipForCaretRefreshRate");
			crtCheck.Tick += (_, __) => {
				var crtOnly = new Point(0,0);
				var curCrtPos = CaretPos.GetCaretPointToScreen(out crtOnly);
				uint cLuid = 0;
				var notTwo = false;
				if (LDForCaretOnChange || DiffAppearenceForLayouts)
					cLuid = Locales.GetCurrentLocale();
				if (DiffAppearenceForLayouts && cLuid != 0) {
					if (cLuid == Locales.GetLocaleFromString(MainLayout1).uId) {
						caretLangDisplay.Location = new Point(curCrtPos.X + Layout1X_Pos_temp, 
						                                      curCrtPos.Y + Layout1Y_Pos_temp);
					} else if (cLuid == Locales.GetLocaleFromString(MainLayout2).uId) {
						caretLangDisplay.Location = new Point(curCrtPos.X + Layout2X_Pos_temp, 
						                                      curCrtPos.Y + Layout2Y_Pos_temp);
					} else notTwo = true;
				} else notTwo = true;
				if (notTwo)
					caretLangDisplay.Location = new Point(curCrtPos.X + LDCaretX_Pos_temp, 
					                                      curCrtPos.Y + LDCaretY_Pos_temp);
				if (LDForCaretOnChange && cLuid != 0) {
					if (onepassC) {
						latestCL = cLuid;
						onepassC = false;
					}
					if (latestCL != cLuid) {
						caretLangDisplay.ShowInactiveTopmost();
						res.Start();
					}
				} else {
				if (crtOnly.X != 77777 && crtOnly.Y != 77777) // 77777x77777 is null/none point
					caretLangDisplay.ShowInactiveTopmost();
//				else if (caretLangDisplay.Visible)
//					caretLangDisplay.HideWnd();
				caretLangDisplay.RefreshLang();
				}
			};
			ICheck.Interval = MMain.MyConfs.ReadInt("Timings", "LangTooltipForMouseRefreshRate");
			ICheck.Tick += (_, __) => {
				if (LDForMouseOnChange) {
					var cLuid = Locales.GetCurrentLocale();
					if (onepass) {
						latestL = cLuid;
						onepass = false;
					}
					if (latestL != cLuid) {
						mouseLangDisplay.ShowInactiveTopmost();
						res.Start();
					}
				} else {
					if (ICheckings.IsICursor())
						mouseLangDisplay.ShowInactiveTopmost();
					else
						mouseLangDisplay.HideWnd();
				}
				mouseLangDisplay.Location = new Point(Cursor.Position.X + LDMouseX_Pos_temp, Cursor.Position.Y + LDMouseY_Pos_temp);
				mouseLangDisplay.RefreshLang();
			};
			res.Interval = (ICheck.Interval + crtCheck.Interval) * 2;
			res.Tick += (_, __) => {
				onepass = true;
				onepassC = true;
				caretLangDisplay.HideWnd();
				mouseLangDisplay.HideWnd();
				res.Stop();
			};
			ScrlCheck.Interval = MMain.MyConfs.ReadInt("Timings", "ScrollLockStateRefreshRate");
			ScrlCheck.Tick += (_, __) => {
				if (ScrollTip && !KMHook.self && !KMHook.alt) {
					KMHook.self = true;
					if (Locales.GetCurrentLocale() == 
					    Locales.GetLocaleFromString(MainLayout1).uId) {
						if (!Control.IsKeyLocked(Keys.Scroll)) { // Turn on 
							KMHook.KeybdEvent(Keys.Scroll, 0);
							KMHook.KeybdEvent(Keys.Scroll, 2);
						}
					} else {
						if (Control.IsKeyLocked(Keys.Scroll)) {
							KMHook.KeybdEvent(Keys.Scroll, 0);
							KMHook.KeybdEvent(Keys.Scroll, 2);
						}
					}
					KMHook.self = false;
				}
			};
			capsCheck.Tick += (_, __) => {
				KMHook.self = true;
				if (Control.IsKeyLocked(Keys.CapsLock)) {
					KMHook.KeybdEvent(Keys.CapsLock, 0);
					KMHook.KeybdEvent(Keys.CapsLock, 2);
				}
				KMHook.self = false;
			};
			capsCheck.Interval = MMain.MyConfs.ReadInt("Timings", "CapsLockDisableRefreshRate");
			KMHook.doublekey.Tick += (_, __) => {
				if (KMHook.hklOK)
					KMHook.hklOK = false;
				if (KMHook.hksOK)
					KMHook.hksOK = false;
				if (KMHook.hklineOK)
					KMHook.hklineOK = false;
				if (KMHook.hkSIOK)
					KMHook.hkSIOK = false;
				if (KMHook.hkShWndOK)
					KMHook.hkShWndOK = false;
				if (KMHook.hkExitOK)
					KMHook.hkExitOK = false;
				if (KMHook.hkcwdsOK)
					KMHook.hkcwdsOK = false;
				if (KMHook.hksTRCOK)
					KMHook.hksTRCOK = false;
				if (KMHook.hksTrslOK)
					KMHook.hksTrslOK = false;
				if (KMHook.hksTTCOK)
					KMHook.hksTTCOK = false;
				if (KMHook.hksTSCOK)
					KMHook.hksTSCOK = false;
				KMHook.doublekey.Stop();
			};
			flagsCheck.Interval = MMain.MyConfs.ReadInt("Timings", "FlagsInTrayRefreshRate");
			flagsCheck.Tick += (_,__) => RefreshAllIcons();			
			titlebar = RectangleToScreen(ClientRectangle).Top - Top;
			animate.Interval = 2500;
			tmr.Interval = 3000;
			old.Interval = 7500;
			old.Tick += (_, __) => { isold = !isold; };			
			InitLangDisplays();
			ToggleTimers();
		}
		/// <summary>
		/// Toggles timers state.
		/// </summary>
		public void ToggleTimers() {
			if (MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForMouse"))
				ICheck.Start();
			if (MMain.MyConfs.ReadBool("Functions", "ScrollTip"))
				ScrlCheck.Start();
			if (MMain.MyConfs.ReadBool("Appearence", "DisplayLangTooltipForCaret"))
				crtCheck.Start();
			if (MMain.MyConfs.ReadBool("Functions", "CapsLockTimer"))
				capsCheck.Start();
			if (MMain.MyConfs.ReadBool("Functions", "TrayFlags"))
				flagsCheck.Start();
		}
		/// <summary>
		/// Creates startup shortcut v2.0.(now not uses com. So whole project not need the Windows SDK :p)
		/// </summary>
		void CreateShortcut() {
			var exelocation = Assembly.GetExecutingAssembly().Location;
			var shortcutLocation = Path.Combine(
				                       Environment.GetFolderPath(Environment.SpecialFolder.Startup),
				                       "Mahou.lnk");
			if (File.Exists(shortcutLocation))
				return;
			Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //Windows Script Host Shell Object
			dynamic shell = Activator.CreateInstance(t);
			try {
				var lnk = shell.CreateShortcut(shortcutLocation);
				try {
					lnk.TargetPath = exelocation;
					lnk.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
					lnk.IconLocation = exelocation + ", 0";
					lnk.Description = "Mahou - Magic layout switcher";
					lnk.Save();
				} finally {
					Marshal.FinalReleaseComObject(lnk);
				}
			} finally {
				Marshal.FinalReleaseComObject(shell);
			}
			Logging.Log("Startup shortcut created.");
		}
		/// <summary>
		/// Deletes startup shortcut.
		/// </summary>
		void DeleteShortcut() {
			if (File.Exists(Path.Combine(
				    Environment.GetFolderPath(Environment.SpecialFolder.Startup),
				    "Mahou.lnk"))) {
				File.Delete(Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.Startup),
					"Mahou.lnk"));
			}
			Logging.Log("Startup shortcut removed.");
		}
		/// <summary>
		/// Exits Mahou.
		/// </summary>
		public void ExitProgram() {
			Logging.Log("Exit by user demand.");
			icon.Hide();
			Application.Exit();
		}
		public void RegisterRestartHotkey() {
			uint mods = 0;
			if (HKRestart_tempMods.Contains("Shift")) 
				mods += WinAPI.MOD_SHIFT;
			if (HKRestart_tempMods.Contains("Alt")) 
				mods += WinAPI.MOD_ALT;
			if (HKRestart_tempMods.Contains("Control")) 
				mods += WinAPI.MOD_CONTROL;
			if (HKRestart_tempMods.Contains("Win")) 
				mods += WinAPI.MOD_WIN;
//			int hash = HKRestart_tempKey.GetHashCode() ^ mods.GetHashCode();
			if (HKRestart_tempEnabled)
				WinAPI.RegisterHotKey(Handle, 7, mods, HKRestart_tempKey); 
		}
		/// <summary>
		/// Converts some special keys to readable string.
		/// </summary>
		/// <param name="k">Key to be converted.</param>
		/// <param name="oninit">On initialize.</param>
		/// <returns>string</returns>
		public string Remake(Keys k, bool oninit = false, bool Double = false) {
			if (Double || oninit) {
				switch (k) {
					case Keys.ShiftKey:
						return "Shift";
					case Keys.Menu:
						return "Alt";
					case Keys.ControlKey:
						return "Control";
				}
			}
			switch (k) {
				case Keys.Cancel:
					return k.ToString().Replace("Cancel", "Pause");
				case Keys.Scroll:
					return k.ToString().Replace("Cancel", "Scroll");
				case Keys.ShiftKey:
				case Keys.Menu:
				case Keys.ControlKey:
				case Keys.LWin:
				case Keys.RWin:
					return "";
				case Keys.D0:
				case Keys.D1:
				case Keys.D2:
				case Keys.D3:
				case Keys.D4:
				case Keys.D5:
				case Keys.D6:
				case Keys.D7:
				case Keys.D8:
				case Keys.D9:
					return k.ToString().Replace("D", "");
				case Keys.Capital:
					return "Caps Lock";
				default:
					return k.ToString();
			}
		}
		/// <summary>
		/// Converts Oem Keys string to readable string.
		/// </summary>
		/// <param name="inpt">String with oem keys.</param>
		/// <returns>string</returns>
		public string OemReadable(string inpt) {
			return inpt
                  .Replace("Oemtilde", "`")
                  .Replace("OemMinus", "-")
                  .Replace("Oemplus", "+")
                  .Replace("OemBackslash", "\\")
                  .Replace("Oem5", "\\")
                  .Replace("OemOpenBrackets", "{")
                  .Replace("OemCloseBrackets", "}")
                  .Replace("Oem6", "}")
                  .Replace("OemSemicolon", ";")
                  .Replace("Oem1", ";")
                  .Replace("OemQuotes", "\"")
                  .Replace("Oem7", "\"")
                  .Replace("OemPeriod", ".")
                  .Replace("Oemcomma", ",")
                  .Replace("OemQuestion", "/");
		}
		/// <summary>
		/// Calls UpdateLangDisplayControls() which updates lang display controls based on selected [layout appearence]. 
		/// </summary>
		void UpdateLangDisplayControlsSwitch() {
			if (lsb_LangTTAppearenceForList.SelectedIndex < 4) {
				if (lsb_LangTTAppearenceForList.SelectedIndex > 1)
					txt_LangTTText.Enabled = lbl_LangTTText.Enabled = false;
				else
					txt_LangTTText.Enabled = lbl_LangTTText.Enabled = true;
				chk_LangTTTransparentColor.Enabled = btn_LangTTFont.Enabled = btn_LangTTForegroundColor.Enabled = 
					btn_LangTTBackgroundColor.Enabled = lbl_LangTTBackgroundColor.Enabled = lbl_LangTTForegroundColor.Enabled = true;
				grb_LangTTSize.Text = MMain.Lang[Languages.Element.LDSize];
				lbl_LangTTWidth.Text = MMain.Lang[Languages.Element.LDWidth];
				lbl_LangTTHeight.Text = MMain.Lang[Languages.Element.LDHeight];
			} else {
				chk_LangTTTransparentColor.Enabled = btn_LangTTFont.Enabled = btn_LangTTForegroundColor.Enabled = 
					btn_LangTTBackgroundColor.Enabled = lbl_LangTTBackgroundColor.Enabled = lbl_LangTTForegroundColor.Enabled = false;
				grb_LangTTSize.Text =  MMain.Lang[Languages.Element.LDPosition];
				lbl_LangTTWidth.Text =  MMain.Lang[Languages.Element.MCDSTopIndent];
				lbl_LangTTHeight.Text =  MMain.Lang[Languages.Element.MCDSBottomIndent];
			}
			lbl_LangTTWidth.Text += ":";
			lbl_LangTTHeight.Text += ":";
			switch (lsb_LangTTAppearenceForList.SelectedIndex) {
				case 0:
					UpdateLangDisplayControls(Layout1Fore_temp, Layout1Back_temp, Layout1TransparentBack_temp,
					                          Layout1Font_temp, Layout1X_Pos_temp, Layout1Y_Pos_temp, Layout1Width_temp,
					                          Layout1Height_temp, Layout1TText);
					break;
				case 1:
					UpdateLangDisplayControls(Layout2Fore_temp, Layout2Back_temp, Layout2TransparentBack_temp,
					                          Layout2Font_temp, Layout2X_Pos_temp, Layout2Y_Pos_temp, Layout2Width_temp,
					                          Layout2Height_temp, Layout2TText);
					break;
				case 2:
					UpdateLangDisplayControls(LDMouseFore_temp, LDMouseBack_temp, LDMouseTransparentBack_temp,
					                          LDMouseFont_temp, LDMouseX_Pos_temp, LDMouseY_Pos_temp, LDMouseWidth_temp,
					                          LDMouseHeight_temp);
					break;
				case 3:
					UpdateLangDisplayControls(LDCaretFore_temp, LDCaretBack_temp, LDCaretTransparentBack_temp,
					                          LDCaretFont_temp, LDCaretX_Pos_temp, LDCaretY_Pos_temp, LDCaretWidth_temp,
					                          LDCaretHeight_temp);
					break;
				case 4:
					UpdateLangDisplayControls(LDCaretFore_temp, LDCaretBack_temp, LDCaretTransparentBack_temp,
					                          LDCaretFont_temp, MCDS_Xpos_temp, MCDS_Ypos_temp, MCDS_TopIndent_temp,
					                          MCDS_BottomIndent_temp);
					break;
			}
		}
		/// <summary>
		/// Updates lang display controls.
		/// </summary>
		/// <param name="FGcolor">Foreground color.</param>
		/// <param name="BGColor">Background color.</param>
		/// <param name="TransparentBG">Transparent background color.</param>
		/// <param name="font">Font.</param>
		/// <param name="posX">Position x.</param>
		/// <param name="posY">Position y.</param>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		void UpdateLangDisplayControls(Color FGcolor, Color BGColor, bool TransparentBG, Font font,
		                               int posX, int posY, int width, int height, string TTText = "") {
			btn_LangTTForegroundColor.BackColor = FGcolor;
			btn_LangTTBackgroundColor.BackColor = BGColor;
			chk_LangTTTransparentColor.Checked = TransparentBG;
			btn_LangTTFont.Font = font;
			nud_LangTTPositionX.Value = posX;
			nud_LangTTPositionY.Value = posY;
			nud_LangTTWidth.Value = width;
			nud_LangTTHeight.Value = height;
			txt_LangTTText.Text = TTText;
		}
		/// <summary>
		/// Updates Lang Display temporary variables based on selected [layout appearence]. 
		/// </summary>
		void UpdateLangDisplayTemps() {
			switch (lsb_LangTTAppearenceForList.SelectedIndex) {
				case 0:
					Layout1Fore_temp = btn_LangTTForegroundColor.BackColor;
					Layout1Back_temp = btn_LangTTBackgroundColor.BackColor;
					Layout1Font_temp = btn_LangTTFont.Font;
					Layout1X_Pos_temp = (int)nud_LangTTPositionX.Value;
					Layout1Y_Pos_temp = (int)nud_LangTTPositionY.Value;
					Layout1Width_temp = (int)nud_LangTTWidth.Value;
					Layout1Height_temp = (int)nud_LangTTHeight.Value;
					Layout1TransparentBack_temp = chk_LangTTTransparentColor.Checked;
					Layout1TText = txt_LangTTText.Text;
					break;
				case 1:
					Layout2Fore_temp = btn_LangTTForegroundColor.BackColor;
					Layout2Back_temp = btn_LangTTBackgroundColor.BackColor;
					Layout2Font_temp = btn_LangTTFont.Font;
					Layout2X_Pos_temp = (int)nud_LangTTPositionX.Value;
					Layout2Y_Pos_temp = (int)nud_LangTTPositionY.Value;
					Layout2Width_temp = (int)nud_LangTTWidth.Value;
					Layout2Height_temp = (int)nud_LangTTHeight.Value;
					Layout2TransparentBack_temp = chk_LangTTTransparentColor.Checked;
					Layout2TText = txt_LangTTText.Text;
					break;
				case 2:
					LDMouseFore_temp = btn_LangTTForegroundColor.BackColor;
					LDMouseBack_temp = btn_LangTTBackgroundColor.BackColor;
					LDMouseFont_temp = btn_LangTTFont.Font;
					LDMouseX_Pos_temp = (int)nud_LangTTPositionX.Value;
					LDMouseY_Pos_temp = (int)nud_LangTTPositionY.Value;
					LDMouseWidth_temp = (int)nud_LangTTWidth.Value;
					LDMouseHeight_temp = (int)nud_LangTTHeight.Value;
					LDMouseTransparentBack_temp = chk_LangTTTransparentColor.Checked;
					break;
				case 3:
					LDCaretFore_temp = btn_LangTTForegroundColor.BackColor;
					LDCaretBack_temp = btn_LangTTBackgroundColor.BackColor;
					LDCaretFont_temp = btn_LangTTFont.Font;
					LDCaretX_Pos_temp = (int)nud_LangTTPositionX.Value;
					LDCaretY_Pos_temp = (int)nud_LangTTPositionY.Value;
					LDCaretWidth_temp = (int)nud_LangTTWidth.Value;
					LDCaretHeight_temp = (int)nud_LangTTHeight.Value;
					LDCaretTransparentBack_temp = chk_LangTTTransparentColor.Checked;
					break;
				case 4:
					MCDS_Xpos_temp = (int)nud_LangTTPositionX.Value;
					MCDS_Ypos_temp = (int)nud_LangTTPositionY.Value;
					MCDS_TopIndent_temp = (int)nud_LangTTWidth.Value;
					MCDS_BottomIndent_temp = (int)nud_LangTTHeight.Value;
					break;
			}
		}
		/// <summary>
		/// Calls UpdateHotkeyControls() which updates hotkey controls based on selected [layout appearence]. 
		/// </summary>
		void UpdateHotkeyControlsSwitch() {
			chk_DoubleHotkey.Enabled = lsb_Hotkeys.SelectedIndex != 11;
			switch(lsb_Hotkeys.SelectedIndex) {
				case 0:
					UpdateHotkeyControls(Mainhk_tempEnabled, Mainhk_tempDouble, Mainhk_tempMods, Mainhk_tempKey);
					break;
				case 1:
					UpdateHotkeyControls(HKCLast_tempEnabled, HKCLast_tempDouble, HKCLast_tempMods, HKCLast_tempKey);
					break;
				case 2:
					UpdateHotkeyControls(HKCSelection_tempEnabled, HKCSelection_tempDouble, HKCSelection_tempMods, HKCSelection_tempKey);
					break;
				case 3:
					UpdateHotkeyControls(HKCLine_tempEnabled, HKCLine_tempDouble, HKCLine_tempMods, HKCLine_tempKey);
					break;
				case 4:
					UpdateHotkeyControls(HKConMorWor_tempEnabled, HKConMorWor_tempDouble, HKConMorWor_tempMods, HKConMorWor_tempKey);
					break;
				case 5:
					UpdateHotkeyControls(HKSymIgn_tempEnabled, HKSymIgn_tempDouble, HKSymIgn_tempMods, HKSymIgn_tempKey);
					break;
				case 6:
					UpdateHotkeyControls(HKTitleCase_tempEnabled, HKTitleCase_tempDouble, HKTitleCase_tempMods, HKTitleCase_tempKey);
					break;
				case 7:
					UpdateHotkeyControls(HKRandomCase_tempEnabled, HKRandomCase_tempDouble, HKTitleCase_tempMods, HKRandomCase_tempKey);
					break;
				case 8:
					UpdateHotkeyControls(HKSwapCase_tempEnabled, HKSwapCase_tempDouble, HKSwapCase_tempMods, HKSwapCase_tempKey);
					break;
				case 9:
					UpdateHotkeyControls(HKTransliteration_tempEnabled, HKTransliteration_tempDouble, HKTransliteration_tempMods, HKTransliteration_tempKey);
					break;
				case 10:
					UpdateHotkeyControls(ExitHk_tempEnabled, ExitHk_tempDouble, ExitHk_tempMods, ExitHk_tempKey);
					break;
				case 11:
					UpdateHotkeyControls(HKRestart_tempEnabled, false, HKRestart_tempMods, HKRestart_tempKey);
					break;
			}
		}
		/// <summary>
		/// Updates hotkey controls.
		/// </summary>
		void UpdateHotkeyControls(bool enabled, bool Double, string modifiers, int key) {
			chk_HotKeyEnabled.Checked = enabled;
			chk_DoubleHotkey.Checked = Double;
			txt_Hotkey.Text = Regex.Replace(OemReadable(modifiers.Replace(",", " +") +
			                                            " + " + Remake((Keys)key, true, Double)), 
			                                            @"Win\s?\+?\s?|\s?\+?\s?None\s?\+?\s?|^[ +]+|\s?\+\s?$", "", RegexOptions.Multiline);
			chk_WinInHotKey.Checked = modifiers.Contains("Win");
			txt_Hotkey_tempKey = key;
			txt_Hotkey_tempModifiers = Regex.Replace(modifiers.Replace("Win",""), @"^[ +]+", "", RegexOptions.Multiline);
			// Debug.WriteLine(txt_Hotkey_tempModifiers);
		}
		
		/// <summary>
		/// Updates Hotkey temporary variables based on selected [layout appearence]. 
		/// </summary>
		void UpdateHotkeyTemps() {
			switch (lsb_Hotkeys.SelectedIndex) {
				case 0:
					Mainhk_tempEnabled = chk_HotKeyEnabled.Checked;
					Mainhk_tempDouble = chk_DoubleHotkey.Checked;
					Mainhk_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					Mainhk_tempKey = txt_Hotkey_tempKey;
					break;
				case 1:
					HKCLast_tempEnabled = chk_HotKeyEnabled.Checked;
					HKCLast_tempDouble = chk_DoubleHotkey.Checked;
					HKCLast_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKCLast_tempKey = txt_Hotkey_tempKey;
					break;
				case 2:
					HKCSelection_tempEnabled = chk_HotKeyEnabled.Checked;
					HKCSelection_tempDouble = chk_DoubleHotkey.Checked;
					HKCSelection_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKCSelection_tempKey = txt_Hotkey_tempKey;
					break;
				case 3:
					HKCLine_tempEnabled = chk_HotKeyEnabled.Checked;
					HKCLine_tempDouble = chk_DoubleHotkey.Checked;
					HKCLine_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKCLine_tempKey = txt_Hotkey_tempKey;
					break;
				case 4:
					HKConMorWor_tempEnabled = chk_HotKeyEnabled.Checked;
					HKConMorWor_tempDouble = chk_DoubleHotkey.Checked;
					HKConMorWor_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKConMorWor_tempKey = txt_Hotkey_tempKey;
					break;
				case 5:
					HKSymIgn_tempEnabled = chk_HotKeyEnabled.Checked;
					HKSymIgn_tempDouble = chk_DoubleHotkey.Checked;
					HKSymIgn_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKSymIgn_tempKey = txt_Hotkey_tempKey;
					break;
				case 6:
					HKTitleCase_tempEnabled = chk_HotKeyEnabled.Checked;
					HKTitleCase_tempDouble = chk_DoubleHotkey.Checked;
					HKTitleCase_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKTitleCase_tempKey = txt_Hotkey_tempKey;
					break;
				case 7:
					HKRandomCase_tempEnabled = chk_HotKeyEnabled.Checked;
					HKRandomCase_tempDouble = chk_DoubleHotkey.Checked;
					HKRandomCase_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKRandomCase_tempKey = txt_Hotkey_tempKey;
					break;
				case 8:
					HKSwapCase_tempEnabled = chk_HotKeyEnabled.Checked;
					HKSwapCase_tempDouble = chk_DoubleHotkey.Checked;
					HKSwapCase_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKSwapCase_tempKey = txt_Hotkey_tempKey;
					break;
				case 9:
					HKTransliteration_tempEnabled = chk_HotKeyEnabled.Checked;
					HKTransliteration_tempDouble = chk_DoubleHotkey.Checked;
					HKTransliteration_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKTransliteration_tempKey = txt_Hotkey_tempKey;
					break;
				case 10:
					ExitHk_tempEnabled = chk_HotKeyEnabled.Checked;
					ExitHk_tempDouble = chk_DoubleHotkey.Checked;
					ExitHk_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					ExitHk_tempKey = txt_Hotkey_tempKey;
					break;
				case 11:
					HKRestart_tempEnabled = chk_HotKeyEnabled.Checked;
					HKRestart_tempMods = (chk_WinInHotKey.Checked ? "Win + " : "") + txt_Hotkey_tempModifiers;
					HKRestart_tempKey = txt_Hotkey_tempKey;
					break;
			}
		}
		/// <summary>
		/// Returns selected hotkey's Double bool.
		/// </summary>
		bool GetSelectedHotkeyDoubleTemp() {
			switch (lsb_Hotkeys.SelectedIndex) {				
				case 0:
					return Mainhk_tempDouble;
				case 1:
					return HKCLast_tempDouble;
				case 2:
					return HKCSelection_tempDouble;
				case 3:
					return HKCLine_tempDouble;
				case 4:
					return HKConMorWor_tempDouble;
				case 5:
					return HKSymIgn_tempDouble;
				case 6:
					return HKTitleCase_tempDouble;
				case 7:
					return HKRandomCase_tempDouble;
				case 8:
					return HKSwapCase_tempDouble;
				case 9:
					return HKTransliteration_tempDouble;
				case 10:
					return ExitHk_tempDouble;
				case 11:
					return false;
			}
			return false;
		}
		#region Updates functions
		void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
			if (isold)
				_progress = e.ProgressPercentage;
			prb_UpdateDownloadProgress.Value = progress = e.ProgressPercentage;
			//Below in "if" is AUTO-UPDATE feature ;)
			if (e.ProgressPercentage == 100 && !was) {
				Logging.Log("Download of Mahou update [" + UpdInfo[3] +"] finished.");
				int MahouPID = Process.GetCurrentProcess().Id;
				//Downloaded archive
				var arch = Regex.Match(UpdInfo[3], @"[^\\\/]+$").Groups[0].Value;
				//This prevent Mahou icon from stucking in tray
				MMain.mahou.icon.Hide();
				//Batch script to create other script o.0,
				//which shutdown running Mahou,
				//delete old version,
				//unzip downloaded one, and start it.
				var UpdateMahou =
					@"@ECHO OFF
chcp 65001
SET MAHOUDIR=" + nPath + @"
TASKKILL /PID " + MahouPID + @" /F
TASKKILL /IM Mahou.exe /F
DEL /Q /F /A """ + nPath + @"" + AppDomain.CurrentDomain.FriendlyName + @"""
DEL /Q /F /A """ + nPath + @"" + AppDomain.CurrentDomain.FriendlyName + @"""
DEL /Q /F /A """ + nPath + @"" + AppDomain.CurrentDomain.FriendlyName + @"""
ECHO With CreateObject(""Shell.Application"") > ""%MAHOUDIR%unzip.vbs""
ECHO    .NameSpace(WScript.Arguments(1)).CopyHere .NameSpace(WScript.Arguments(0)).items, 16 >> ""%MAHOUDIR%unzip.vbs""
ECHO End With >> ""%MAHOUDIR%unzip.vbs""

CSCRIPT ""%MAHOUDIR%unzip.vbs"" ""%MAHOUDIR%" + arch + @""" ""%MAHOUDIR%""

START """" ""%MAHOUDIR%Mahou.exe"" ""_!_updated_!_""
DEL ""%MAHOUDIR%" + arch + @"""
DEL ""%MAHOUDIR%unzip.vbs""
DEL ""%MAHOUDIR%UpdateMahou.cmd""";
				//Save Batch script
				Logging.Log("Writing update script.");
				File.WriteAllText(Path.Combine(new string[] {
					nPath,
					"UpdateMahou.cmd"
				}), UpdateMahou);
				var piUpdateMahou = new ProcessStartInfo();
				piUpdateMahou.FileName = Path.Combine(new string[] {
					nPath,
					"UpdateMahou.cmd"
				});
				//Make UpdateMahou.cmd's startup hidden
				piUpdateMahou.WindowStyle = ProcessWindowStyle.Hidden;
				//Start updating(unzipping)
				Logging.Log("Starting update script.");
				Process.Start(piUpdateMahou);
				was = true;
			}
		}
		/// <summary>
		/// Gets update info, and sets it to static [UpdInfo] string.
		/// </summary>
		void GetUpdateInfo() {
			var Info = new List<string>(); // Update info
			try {
				// Latest Mahou release url
				const string url = "https://github.com/BladeMight/Mahou/releases/latest";
				var request = (HttpWebRequest)WebRequest.Create(url);
				// For proxy
				if (!String.IsNullOrEmpty(txt_ProxyLogin.Text)) {
					request.Proxy = MakeProxy();
				}
				request.ServicePoint.SetTcpKeepAlive(true, 5000, 1000);
                var response = (HttpWebResponse)System.Threading.Tasks.Task.Factory
                    .FromAsync<WebResponse>(request.BeginGetResponse,request.EndGetResponse, null).Result;
				//Console.WriteLine(response.StatusCode)
                if (response.StatusCode == HttpStatusCode.OK)
                {
					var data = new StreamReader(response.GetResponseStream(), true).ReadToEnd();
					response.Close();
					// Below are REGEX HTML PARSES!!
					// I'm not kidding...
					// They really works :)
					var Title = Regex.Match(data,
						            "<h1 class=\"release-title\">\n.*<a href=\".*\">(.*)</a>").Groups[1].Value;
					var Description = Regex.Replace(Regex.Match(data,
                                           //These looks unsafe, but really they works!
						                  "<div class=\"markdown-body\">\n\\s+(.+?)[\\n\\s]+</div>",
						                  RegexOptions.IgnoreCase | RegexOptions.Singleline).Groups[1].Value, "<[^>]*>", "");
					var Version = Regex.Match(data, "<span class=\"css-truncate-target\">(.*)</span>").Groups[1].Value;
					var Link = "https://github.com" + Regex.Match(data,
						           "<ul class=\"release-downloads\">\n.*<li>\n.+href=\"(/.*\\.\\w{3})").Groups[1].Value;
//					Debug.WriteLine(Title);
//					Debug.WriteLine(Description);
					Info.Add(Title);
					Info.Add(Regex.Replace(Description, "\n", "\r\n")); // Regex needed to properly display new lines.
					Info.Add(Version);
					Info.Add(Link);
					Logging.Log("Check for updates succeded, GitHub version: "+ Version + ".");
				} else {
				   response.Close();
				}
			} catch {
				Logging.Log("Check for updates failed, error message:", 1);
				Info = new List<string>{
						MMain.Lang[Languages.Element.Error],
						MMain.Lang[Languages.Element.NetError],
						MMain.Lang[Languages.Element.Error]
				};
			}
			UpdInfo = Info.ToArray();
		}
		/// <summary>
		/// Creates proxy from proxy controls(server/name/pass) text.
		/// </summary>
		/// <returns>WebProxy</returns>
		WebProxy MakeProxy() {
			Logging.Log("Creating proxy...");
			var myProxy = new WebProxy();
			try {
				var newUri = new Uri("http://" + txt_ProxyServerPort.Text);
				Logging.Log("Proxy is " + newUri + ", port is " + newUri.Port + ".");
				myProxy.Address = newUri;
			} catch {
//				grb_ProxyConfig.Text = MMain.UI[51];
				tmr.Interval = 3000;
				tmr.Tick += (___, ____) => {
					grb_ProxyConfig.Text = "Proxy configuration";
					tmr.Stop();
				};
				tmr.Start();
			}
			if (!String.IsNullOrEmpty(txt_ProxyLogin.Text) || !String.IsNullOrEmpty(txt_ProxyPassword.Text))
				myProxy.Credentials = new NetworkCredential(txt_ProxyLogin.Text, txt_ProxyPassword.Text); 
			return myProxy;
		}
		/// <summary>
		/// Check for updates at Mahou startup.
		/// </summary>
		public void StartupCheck() {
			Logging.Log("Startup check for updates.");
			System.Threading.Tasks.Task.Factory.StartNew(GetUpdateInfo).Wait();
			SetUInfo();
			try {
				if (flVersion("v" + Application.ProductVersion) < flVersion(UpdInfo[2])) {
					Logging.Log("New version available, showing dialog...");
					if (MessageBox.Show(new Form() { TopMost = false, Visible = false }, UpdInfo[1], UpdInfo[0],
						     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK) {
						AtUpdateShow = 1;
					} else { AtUpdateShow = 2; }
				}
			} catch(Exception e) {
				Logging.Log("Unexpected error: \n" + e.Message +"\n" + e.StackTrace);
			}
		}
		/// <summary>
		/// Sets UI info controls(version/title/description) text.
		/// </summary>
		void SetUInfo() {
			grb_MahouReleaseTitle.Text = UpdInfo[0];
			txt_UpdateDetails.Text = UpdInfo[1];
			btn_DownloadUpdate.Text = Regex.Replace(btn_DownloadUpdate.Text, @"\<.+?\>", UpdInfo[2]);
		}
		#endregion
		/// <summary>
		/// Refreshes language.
		/// </summary>
		void RefreshLanguage() {
			#region Tabs
			tab_functions.Text = MMain.Lang[Languages.Element.tab_Functions];
			tab_layouts.Text = MMain.Lang[Languages.Element.tab_Layouts];
			tab_appearence.Text = MMain.Lang[Languages.Element.tab_Appearence];
			tab_timings.Text = MMain.Lang[Languages.Element.tab_Timings];
			tab_snippets.Text = MMain.Lang[Languages.Element.tab_Snippets];
			tab_hotkeys.Text = MMain.Lang[Languages.Element.tab_Hotkeys];
			tab_updates.Text = MMain.Lang[Languages.Element.tab_Updates];
			tab_about.Text = MMain.Lang[Languages.Element.tab_About];
			lnk_plugin.Text = "ST3 " + MMain.Lang[Languages.Element.Plugin];
			chk_OneLayoutWholeWord.Text = MMain.Lang[Languages.Element.OneLayoutWholeWord];
			#endregion
			#region Functions
			chk_AutoStart.Text = MMain.Lang[Languages.Element.AutoStart];
			chk_TrayIcon.Text = MMain.Lang[Languages.Element.TrayIcon];
			chk_CSLayoutSwitching.Text = MMain.Lang[Languages.Element.ConvertSelectionLS];
			chk_ReSelect.Text = MMain.Lang[Languages.Element.ReSelect];
			chk_RePress.Text = MMain.Lang[Languages.Element.RePress];
			chk_AddOneSpace.Text = MMain.Lang[Languages.Element.Add1Space];
			chk_CSLayoutSwitchingPlus.Text = MMain.Lang[Languages.Element.ConvertSelectionLSPlus];
			chk_HighlightScroll.Text = MMain.Lang[Languages.Element.HighlightScroll];
			chk_StartupUpdatesCheck.Text = MMain.Lang[Languages.Element.UpdatesCheck];
			chk_Logging.Text = MMain.Lang[Languages.Element.Logging];
			chk_CapsLockDTimer.Text = MMain.Lang[Languages.Element.CapsTimer];
			chk_FlagsInTray.Text = MMain.Lang[Languages.Element.ContryFlags];
			chk_BlockHKWithCtrl.Text = MMain.Lang[Languages.Element.BlockCtrlHKs];
			chk_MCDS_support.Text = MMain.Lang[Languages.Element.MCDSSupport];
			#endregion
			#region Layouts
			chk_SwitchBetweenLayouts.Text = MMain.Lang[Languages.Element.SwitchBetween]+":";
			chk_EmulateLS.Text = MMain.Lang[Languages.Element.EmulateLS];
			lbl_EmuType.Text = MMain.Lang[Languages.Element.EmulateType];
			chk_SpecificLS.Text = MMain.Lang[Languages.Element.ChangeLayoutBy1Key];
			grb_Layouts.Text = MMain.Lang[Languages.Element.Layouts];
			grb_Keys.Text = MMain.Lang[Languages.Element.Keys];
			#endregion
			#region Appearence
			chk_LangTooltipMouse.Text = MMain.Lang[Languages.Element.LDMouseDisplay];
			chk_LangTooltipCaret.Text = MMain.Lang[Languages.Element.LDCaretDisplay];
			chk_LangTTCaretOnChange.Text = chk_LangTTMouseOnChange.Text = MMain.Lang[Languages.Element.LDOnlyOnChange];
			lbl_Language.Text = MMain.Lang[Languages.Element.Language];
			chk_LangTTDiffLayoutColors.Text = MMain.Lang[Languages.Element.LDDifferentAppearence];
			grb_LangTTAppearence.Text = MMain.Lang[Languages.Element.LDAppearence];
			btn_LangTTFont.Text = MMain.Lang[Languages.Element.LDFont];
			lbl_LangTTForegroundColor.Text = MMain.Lang[Languages.Element.LDFore];
			lbl_LangTTBackgroundColor.Text = MMain.Lang[Languages.Element.LDBack];
			lbl_LangTTText.Text = MMain.Lang[Languages.Element.LDText];
			grb_LangTTSize.Text = MMain.Lang[Languages.Element.LDSize];
			grb_LangTTPositon.Text = MMain.Lang[Languages.Element.LDPosition];
			lbl_LangTTHeight.Text = MMain.Lang[Languages.Element.LDHeight];
			lbl_LangTTWidth.Text = MMain.Lang[Languages.Element.LDWidth];
			chk_LangTTTransparentColor.Text = MMain.Lang[Languages.Element.LDTransparentBG];
			lsb_LangTTAppearenceForList.Items.Clear();
			lsb_LangTTAppearenceForList.Items.AddRange(new [] {
														MMain.Lang[Languages.Element.Layout] + " 1",
														MMain.Lang[Languages.Element.Layout] + " 2",
														MMain.Lang[Languages.Element.LDAroundMouse],
														MMain.Lang[Languages.Element.LDAroundCaret],
														"MCDS"
														});
			#endregion
			#region Timings
			lbl_LangTTMouseRefreshRate.Text = MMain.Lang[Languages.Element.LDForMouseRefreshRate];
			lbl_LangTTCaretRefreshRate.Text = MMain.Lang[Languages.Element.LDForCaretRefreshRate];
			lbl_DoubleHK2ndPressWaitTime.Text = MMain.Lang[Languages.Element.DoubleHKDelay];
			lbl_FlagTrayRefreshRate.Text = MMain.Lang[Languages.Element.ContryFlags];
			lbl_ScrollLockRefreshRate.Text = MMain.Lang[Languages.Element.ScrollLockRefreshRate];
			lbl_CapsLockRefreshRate.Text = MMain.Lang[Languages.Element.CapsLockRefreshRate];
			chk_SelectedTextGetMoreTries.Text = MMain.Lang[Languages.Element.MoreTriesToGetSelectedText];
			lbl_ExcludedPrograms.Text =  MMain.Lang[Languages.Element.ExcludedPrograms];
			#endregion
			#region Snippets
			chk_Snippets.Text = MMain.Lang[Languages.Element.SnippetsEnabled];
			#endregion
			#region Hotkeys
			grb_Hotkey.Text = MMain.Lang[Languages.Element.Hotkey];
			chk_HotKeyEnabled.Text = MMain.Lang[Languages.Element.Enabled];
			chk_DoubleHotkey.Text = MMain.Lang[Languages.Element.DoubleHK];
			lsb_Hotkeys.Items.Clear();
			lsb_Hotkeys.Items.AddRange(new []{
										MMain.Lang[Languages.Element.ToggleMainWnd],
										MMain.Lang[Languages.Element.ConvertLast],
										MMain.Lang[Languages.Element.ConvertSelected],
										MMain.Lang[Languages.Element.ConvertLine],
										MMain.Lang[Languages.Element.ConvertWords],
										MMain.Lang[Languages.Element.ToggleSymbolIgnore],
										MMain.Lang[Languages.Element.SelectedToTitleCase],
										MMain.Lang[Languages.Element.SelectedToRandomCase],
										MMain.Lang[Languages.Element.SelectedToSwapCase],
										MMain.Lang[Languages.Element.SelectedTransliteration],
										MMain.Lang[Languages.Element.ExitMahou],
										MMain.Lang[Languages.Element.RestartMahou]
										});
			#endregion
			#region Updtaes
			btn_CheckForUpdates.Text = MMain.Lang[Languages.Element.CheckForUpdates];
			btn_DownloadUpdate.Text = MMain.Lang[Languages.Element.UpdateMahou];
			grb_DownloadUpdate.Text = MMain.Lang[Languages.Element.DownloadUpdate];
			grb_ProxyConfig.Text = MMain.Lang[Languages.Element.ProxyConfig];
			lbl_ProxyServerPort.Text = MMain.Lang[Languages.Element.ProxyServer];
			lbl_ProxyLogin.Text = MMain.Lang[Languages.Element.ProxyLogin];
			lbl_ProxyPassword.Text = MMain.Lang[Languages.Element.ProxyPass];
			#endregion
			#region About
			btn_DebugInfo.Text = MMain.Lang[Languages.Element.DbgInf];
			lnk_Site.Text = MMain.Lang[Languages.Element.Site];
			lnk_Releases.Text = MMain.Lang[Languages.Element.Releases];
			txt_Help.Text = MMain.Lang[Languages.Element.Mahou] + "\r\n" + MMain.Lang[Languages.Element.About];
			#endregion
			#region Buttons
			btn_Apply.Text = MMain.Lang[Languages.Element.ButtonApply];
			btn_Cancel.Text = MMain.Lang[Languages.Element.ButtonCancel];
			btn_OK.Text = MMain.Lang[Languages.Element.ButtonOK];
			#endregion
			#region Misc
			icon.RefreshText(MMain.Lang[Languages.Element.Mahou], MMain.Lang[Languages.Element.ShowHide], MMain.Lang[Languages.Element.ExitMahou]);
			#endregion
			Logging.Log("Language changed.");
			SetTooltips();
		}
		#region Tooltips
		void SetTooltips() {
			HelpMeUnderstand.SetToolTip(chk_CSLayoutSwitching, MMain.Lang[Languages.Element.TT_ConvertSelectionSwitch]);
			HelpMeUnderstand.SetToolTip(chk_ReSelect, MMain.Lang[Languages.Element.TT_ReSelect]);
			HelpMeUnderstand.SetToolTip(chk_RePress, MMain.Lang[Languages.Element.TT_RePress]);
			HelpMeUnderstand.SetToolTip(chk_AddOneSpace, MMain.Lang[Languages.Element.TT_Add1Space]);
			HelpMeUnderstand.SetToolTip(chk_CSLayoutSwitchingPlus, MMain.Lang[Languages.Element.TT_ConvertSelectionSwitchPlus]);
			HelpMeUnderstand.SetToolTip(chk_HighlightScroll, MMain.Lang[Languages.Element.TT_ScrollTip]);
			HelpMeUnderstand.SetToolTip(chk_Logging, MMain.Lang[Languages.Element.TT_Logging]);
			HelpMeUnderstand.SetToolTip(chk_CapsLockDTimer, MMain.Lang[Languages.Element.TT_CapsDis]);
			HelpMeUnderstand.SetToolTip(chk_FlagsInTray, MMain.Lang[Languages.Element.TT_CountryFlags]);
			HelpMeUnderstand.SetToolTip(chk_BlockHKWithCtrl, MMain.Lang[Languages.Element.TT_BlockCtrl]);
			HelpMeUnderstand.SetToolTip(chk_MCDS_support, MMain.Lang[Languages.Element.TT_MCDSSupport]);
			HelpMeUnderstand.SetToolTip(chk_OneLayoutWholeWord, MMain.Lang[Languages.Element.TT_OneLayoutWholeWordCS]);
			HelpMeUnderstand.SetToolTip(chk_SwitchBetweenLayouts, MMain.Lang[Languages.Element.TT_SwitchBetween]);
			HelpMeUnderstand.SetToolTip(chk_EmulateLS, MMain.Lang[Languages.Element.TT_EmulateLS]);
			HelpMeUnderstand.SetToolTip(chk_LangTooltipCaret, MMain.Lang[Languages.Element.TT_LDForCaret]);
			HelpMeUnderstand.SetToolTip(chk_LangTooltipMouse, MMain.Lang[Languages.Element.TT_LDForMouse]);
			HelpMeUnderstand.SetToolTip(chk_LangTTCaretOnChange, MMain.Lang[Languages.Element.TT_LDOnlyOnChange]);
			HelpMeUnderstand.SetToolTip(chk_LangTTMouseOnChange, MMain.Lang[Languages.Element.TT_LDOnlyOnChange]);
			HelpMeUnderstand.SetToolTip(txt_LangTTText, MMain.Lang[Languages.Element.TT_LDText]);
			HelpMeUnderstand.SetToolTip(chk_LangTTDiffLayoutColors, MMain.Lang[Languages.Element.TT_LDDifferentAppearence]);
			HelpMeUnderstand.SetToolTip(chk_Snippets, MMain.Lang[Languages.Element.TT_Snippets]);
			HelpMeUnderstand.SetToolTip(lbl_ExcludedPrograms, MMain.Lang[Languages.Element.TT_ExcludedPrograms]);
		}
		void HelpMeUnderstandPopup(object sender, PopupEventArgs e) {
			HelpMeUnderstand.ToolTipTitle = e.AssociatedControl.Text;
		}
		#endregion
		/// <summary>
		/// Converts Mahou version string to float.
		/// </summary>
		/// <param name="ver">Mahou version string.</param>
		/// <returns>float</returns>
		public static float flVersion(string ver) {
			var justdigs = Regex.Replace(ver, "\\D", "");
			return float.Parse(justdigs[0] + "." + justdigs.Substring(1), CultureInfo.InvariantCulture);
		}
		#endregion
		#region Links
		void Lnk_RepositoryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("http://github.com/BladeMight/Mahou");
			} catch (Exception ex) { Logging.Log("No program to open http:// opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		void Lnk_SiteLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("http://blademight.github.io/Mahou/");
			} catch (Exception ex) { Logging.Log("No program to open http:// opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		void Lnk_WikiLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("http://github.com/BladeMight/Mahou/wiki");
			} catch (Exception ex) { Logging.Log("No program to open http:// opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		void Lnk_ReleasesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("http://github.com/BladeMight/Mahou/releases");
			} catch (Exception ex) { Logging.Log("No program to open http:// opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		void Lnk_EmailLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("mailto:BladeMight@gmail.com");
			} catch (Exception ex) { Logging.Log("No program to open mailto: opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		void Lnk_pluginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Process.Start("http://github.com/BladeMight/MahouCaretDisplayServer");
			} catch (Exception ex) { Logging.Log("No program to open http:// opening skiped. Details:\r\n"+ex.Message + "\r\n" + ex.StackTrace, 2); }
		}
		#endregion
		#region Mahou UI controls events
		void Chk_CheckedChanged(object sender, EventArgs e) {
			ToggleDependentControlsEnabledState();
		}
		void ChkUpdateHotkeyTemps_CheckedChanged(object sender, EventArgs e) {
			ToggleDependentControlsEnabledState();
			UpdateHotkeyTemps();
		}
		void Chk_AutoStartCheckedChanged(object sender, EventArgs e) {
			if (chk_AutoStart.Checked)
				CreateShortcut();
			else
				DeleteShortcut();
		}
		void Btn_DebugInfoClick(object sender, EventArgs e) {
			try {
				string debuginfo = "<details><summary>MAHOU DEBUG INFO</summary>\r\n\r\n";
				debuginfo += "<details><summary>Environment info</summary>\r\n\r\n";
				debuginfo += "\r\n" + "- " + Text;
				debuginfo += "\r\n" + "- OS = [" + Environment.OSVersion + "]";
				debuginfo += "\r\n" + "- x64 = [" + Environment.Is64BitOperatingSystem + "]";
				debuginfo += "\r\n" + "- .Net = [" + Environment.Version +"]";
				debuginfo += "\r\n</details>";
				debuginfo += "\r\n" + "<details><summary>All installed layouts</summary>\r\n\r\n";
				foreach (var l in MMain.lcnmid) {
					debuginfo += l + "\r\n";
				}
				debuginfo += "\r\n</details>";
				debuginfo += "<details><summary>Mahou.ini</summary>\r\n\r\n```ini\r\n" + 
					Regex.Match(File.ReadAllText(Path.Combine(nPath, "Mahou.ini")), @"(.*?)\[Proxy.+", RegexOptions.Singleline).Groups[1].Value +
					"```";
				debuginfo += "\r\n</details>";
				if (File.Exists(Path.Combine(nPath, "snippets.txt")))
				    debuginfo += "\r\n" + "<details><summary>Snippets</summary>\r\n\r\n```\r\n" + File.ReadAllText(Path.Combine(nPath, "snippets.txt")) + "\r\n```";
				debuginfo += "\r\n</details>";
				if (Directory.Exists(Path.Combine(nPath, "Flags"))) {
				    	debuginfo += "\r\n" + "<details><summary>Additional flags in Flags directory</summary>\r\n\r\n";
				    	foreach (var flg in Directory.GetFiles(Path.Combine(nPath, "Flags"))) {
				    		debuginfo += "- " + Path.GetFileName(flg) + "\r\n";
				    	}
				    	debuginfo += "\r\n";
						debuginfo += "\r\n</details>";
	             }
				debuginfo += "\r\n</details>";
				Clipboard.SetText(debuginfo);
				var btDgtTxtWas = btn_DebugInfo.Text;
				btn_DebugInfo.Text = MMain.Lang[Languages.Element.DbgInf_Copied];
				var tmr = new Timer();
				tmr.Tick += (_,__) => { 
					btn_DebugInfo.Text = btDgtTxtWas;
					tmr.Stop();
				};
				tmr.Interval = 2000;
				tmr.Start(); 
				Logging.Log("Debug info copied.");
			}
			catch(Exception er) {
				MessageBox.Show("Error during dgbcopy" + er.StackTrace);
				Logging.Log("Error during DEBUG INFO copy, details:\r\n" +er.Message +"\r\n"+er.StackTrace);
			}
		}
		void Btn_OKClick(object sender, EventArgs e) {
			ToggleVisibility();
			SaveConfigs();
		}
		void Btn_ApplyClick(object sender, EventArgs e) {
			SaveConfigs();
		}
		void Btn_CancelClick(object sender, EventArgs e) {
			ToggleVisibility();
			LoadConfigs();
		}
		void Cbb_KeySelectedIndexChanged(object sender, EventArgs e) {
			cbb_Layout1.Enabled = cbb_Key1.SelectedIndex != 0;
			cbb_Layout2.Enabled = cbb_Key2.SelectedIndex != 0;
			cbb_Layout3.Enabled = cbb_Key3.SelectedIndex != 0;
			cbb_Layout4.Enabled = cbb_Key4.SelectedIndex != 0;
		}
		void MahouUIFormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				e.Cancel = true;
				ToggleVisibility();
				LoadConfigs();
			}
		}
		void Lsb_HotkeysSelectedIndexChanged(object sender, EventArgs e) {
			UpdateHotkeyControlsSwitch();
			UpdateHotkeyTemps();
			switch (lsb_Hotkeys.SelectedIndex) {
				case 4:
					lbl_HotkeyHelp.Text = MMain.Lang[Languages.Element.TT_ConvertWords];
					break;
				case 5:
					lbl_HotkeyHelp.Text = MMain.Lang[Languages.Element.TT_SymbolIgnore];
					break;
				default:
					lbl_HotkeyHelp.Text = "";
					break;
			}
		}
		void Txt_HotkeyKeyDown(object sender, KeyEventArgs e) {
			if (GetSelectedHotkeyDoubleTemp()) {
				txt_Hotkey.Text = OemReadable(Remake(e.KeyCode, false, true));
				txt_Hotkey_tempModifiers = "None";
				txt_Hotkey_tempKey = (int)e.KeyCode;				
			} else {
				txt_Hotkey.Text = OemReadable((e.Modifiers.ToString().Replace(",", " +") + " + " +
											  Remake(e.KeyCode)).Replace("None + ", ""));
				txt_Hotkey_tempModifiers = e.Modifiers.ToString().Replace(",", " +");
				switch ((int)e.KeyCode) {
					case 16:
					case 17:
					case 18:
						txt_Hotkey_tempKey = 0;
						break;
					default:
						txt_Hotkey_tempKey = (int)e.KeyCode;
						break;
				}
			}
			UpdateHotkeyTemps();
		}
		void Lsb_LangTTAppearenceForListSelectedIndexChanged(object sender, EventArgs e) {
			UpdateLangDisplayControlsSwitch();
			UpdateLangDisplayTemps();
		}
		void Btn_ColorSelectionClick(object sender, EventArgs e) {
			var btn = sender as Button;
			if (clrd.ShowDialog() == DialogResult.OK)
				btn.BackColor = clrd.Color;
			UpdateLangDisplayTemps();
		}
		void Nud_ValueChanged(object sender, EventArgs e) {
			UpdateLangDisplayTemps();
		}
		void Chk_LangTTTransparentColorCheckedChanged(object sender, EventArgs e) {
			ToggleDependentControlsEnabledState();
			UpdateLangDisplayTemps();
		}
		void Txt_LangTTTextTextChanged(object sender, EventArgs e) {
			UpdateLangDisplayTemps();
		}
		void Btn_LangTTFontClick(object sender, EventArgs e) {
			var btn = sender as Button;
			fntd.Font = btn.Font;
			if (fntd.ShowDialog() == DialogResult.OK)
				btn.Font = fntd.Font;
			UpdateLangDisplayTemps();
		}
		void Btn_CheckForUpdatesClick(object sender, EventArgs e) {
			if (!checking) {
				checking = true;
				var btChkTextWas = btn_CheckForUpdates.Text;
				btn_CheckForUpdates.Text = MMain.Lang[Languages.Element.CheckingForUpdates];
				UpdInfo = null;
				System.Threading.Tasks.Task.Factory.StartNew(GetUpdateInfo).Wait();
				tmr.Tick += (_, __) => {
					btn_CheckForUpdates.Text = btChkTextWas;
					SetUInfo();
					checking = false;
					tmr.Interval = 3000;
					tmr.Stop();
				};
				if (UpdInfo[2] == MMain.Lang[Languages.Element.Error]) {
					tmr.Interval = 1000;
					tmr.Start();
				} else {
					if (flVersion("v" + Application.ProductVersion) <
					   flVersion(UpdInfo[2])) {
						btn_CheckForUpdates.Text = MMain.Lang[Languages.Element.TimeToUpdate];
						tmr.Start();
						SetUInfo();
						grb_DownloadUpdate.Enabled = true;
					} else {
						btn_CheckForUpdates.Text = MMain.Lang[Languages.Element.YouHaveLatest];
						tmr.Start();
						grb_DownloadUpdate.Enabled = false;
						SetUInfo();
					}
				}
			}
		}
		void Btn_DownloadUpdateClick(object sender, EventArgs e) {
			if (!updating && UpdInfo != null) {
				updating = true;
				//Downloads latest Mahou
				using (var wc = new WebClient()) {
					wc.DownloadProgressChanged += wc_DownloadProgressChanged;
					// Gets filename from url
					var BDMText = btn_DownloadUpdate.Text;
					var fn = Regex.Match(UpdInfo[3], @"[^\\\/]+$").Groups[0].Value;
					if (!String.IsNullOrEmpty(txt_ProxyServerPort.Text)) {
						wc.Proxy = MakeProxy();
					}
					Logging.Log("Downloading Mahou update: "+UpdInfo[3]);
					wc.DownloadFileAsync(new Uri(UpdInfo[3]), Path.Combine(new [] { nPath, fn }));
					btn_DownloadUpdate.Text = "Downloading " + fn;
					animate.Tick += (_, __) => { btn_DownloadUpdate.Text += "."; };
					animate.Start();
					btn_DownloadUpdate.Enabled = false;
					tmr.Tick += (_, __) => {
						// Checks if progress changed?
						if (progress == _progress) {
							old.Stop();
							isold = true;
							btn_DownloadUpdate.Enabled = true;
							animate.Stop();
							prb_UpdateDownloadProgress.Value = progress = _progress = 0;
							wc.CancelAsync();
							updating = false;
							btn_DownloadUpdate.Text = "Error...";
							tmr.Tick += (o, oo) => {
								btn_DownloadUpdate.Text = BDMText;
								tmr.Stop();
							};
							tmr.Interval = 3000;
							tmr.Start();
						} else {
							tmr.Stop();
						}
					};
					old.Start();
					tmr.Interval = 15000;
					tmr.Start();
				}
			}
		}
		#endregion
	}
}
