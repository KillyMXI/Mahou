using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Mahou
{
	class MMain
	{
		#region DLLs
		[DllImport("user32.dll")]
		public static extern uint RegisterWindowMessage(string message);
		#endregion
		#region Prevent another instance variables
		public const string appGUid = "ec511418-1d57-4dbe-a0c3-c6022b33735b";
		public static uint ao = RegisterWindowMessage("AlderyOpenedMahou!");
		#endregion
		#region All Main variables, arrays etc.
		public static List<KMHook.YuKey> c_word = new List<KMHook.YuKey>();
		public static List<List<KMHook.YuKey>> c_words = new List<List<KMHook.YuKey>>();
		public static IntPtr _hookID = IntPtr.Zero;
		public static IntPtr _mouse_hookID = IntPtr.Zero;
		public static WinAPI.LowLevelProc _proc = KMHook.HookCallback;
		public static WinAPI.LowLevelProc _mouse_proc = KMHook.MouseHookCallback;
		public static Locales.Locale[] locales = Locales.AllList();
		public static string _language = "";
		public static Dictionary<Languages.Element, string> Lang = Languages.English;
		public static Configs MyConfs = new Configs();
		public static MahouUI mahou;
		public static List<string> lcnmid = new List<string>();
		#endregion
		[STAThread] //DO NOT REMOVE THIS
        public static void Main(string[] args)
		{
			Logging.Log("Mahou started.");
			//Catch any error during program runtime
			AppDomain.CurrentDomain.UnhandledException += (obj, arg) => {
				var e = (Exception)arg.ExceptionObject;
				Logging.Log("Unexpected error occurred, Mahou exited, error details:\r\n" + e.Message+"\r\n" + e.StackTrace, 1);
			};
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			using (var mutex = new Mutex(false, "Global\\" + appGUid)) {
				if (!mutex.WaitOne(0, false)) {
					WinAPI.PostMessage((IntPtr)0xffff, ao, 0, 0);
					return;
				}
				if (locales.Length < 2) {
					Logging.Log("Too less layouts/locales. Program will exit.");
					Locales.IfLessThan2();
				} else {
					if (MyConfs.ReadBool("FirstStart", "First")) {
						if (System.Globalization.CultureInfo.InstalledUICulture.TwoLetterISOLanguageName == "ru") {
							MyConfs.Write("Appearence", "Language", "Русский");
    						MahouUI.InitLanguage();
							MyConfs.Write("Layouts", "SpecificLayout1", Lang[Languages.Element.SwitchBetween]);
							MyConfs.Write("FirstStart", "First", "False");
						}
					} else {
						MahouUI.InitLanguage();}
					mahou = new MahouUI();
					//Refreshes icon text language at startup
//					mahou.icon.RefreshText(MMain.UI[44], MMain.UI[42], MMain.UI[43]);
					KMHook.ReInitSnippets();
					Application.EnableVisualStyles(); // Huh i did not noticed that it was missing... '~'
					if (args.Length != 0)
					if (args[0] == "_!_updated_!_") {
						Logging.Log("Mahou updated.");
						mahou.ToggleVisibility();
						MessageBox.Show(Lang[Languages.Element.UpdateComplete], Lang[Languages.Element.UpdateComplete], MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					StartHook();
					foreach (Locales.Locale lc in MMain.locales) {	
						MMain.lcnmid.Add(lc.Lang + "(" + lc.uId + ")");
					}
					//for first run, add your locale 1 & locale 2 to settings
					if (MyConfs.Read("Layouts", "MainLayout1") == "" && MyConfs.Read("Layouts", "MainLayout2") == "") {
						Logging.Log("Initializing locales.");
						MyConfs.Write("Layouts", "MainLayout1", lcnmid[0]);
						MyConfs.Write("Layouts", "MainLayout2", lcnmid[1]);
						mahou.cbb_MainLayout1.SelectedIndex = 0;
						mahou.cbb_MainLayout2.SelectedIndex = 1;
					}
					Application.Run();
					StopHook();
				}
			}
		}
		#region Actions with hooks
		public static void StartHook()
		{
			if (!CheckHook()) {
				return;
			}
			_mouse_hookID = KMHook.SetHook(_mouse_proc, WinAPI.WH_MOUSE_LL);
			_hookID = KMHook.SetHook(_proc, WinAPI.WH_KEYBOARD_LL);
			Thread.Sleep(10); //Give some time for it to apply
			Logging.Log("Global hooks started.");
		}
		public static void StopHook()
		{
			if (CheckHook()) {
				return;
			}
			WinAPI.UnhookWindowsHookEx(_hookID);
			WinAPI.UnhookWindowsHookEx(_mouse_hookID);
			_hookID = _mouse_hookID = IntPtr.Zero;
			Thread.Sleep(10); //Give some time for it to apply
			Logging.Log("Global hooks stopped.");
		}
		public static bool CheckHook()
		{
			return _hookID == IntPtr.Zero;
		}
		public static bool MahouActive()
		{
			var ActHandle = WinAPI.GetForegroundWindow();
			if (ActHandle == IntPtr.Zero) {
				return false;
			}
			var active = mahou.Handle == ActHandle;
			Logging.Log("Mahou is active = ["+active+"]" + ", Mahou handle [" + mahou.Handle +"], fore win handle ["+ActHandle+"]");
			return active;
		}
		#endregion
	}
}