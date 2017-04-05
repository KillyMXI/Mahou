using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
namespace Mahou
{
	public static class CaretPos
	{
		public static Point _CaretST3 = new Point(0,0);
		public static int SidebarWidth = 0, viewID = 0;
		public static uint lastAttachedThread = 0;
		
		public static int GetMCDSValue(string type, string input) {
			return Int32.Parse(Regex.Match(input, type + @"->(\d+)").Groups[1].Value);
		}
		public static void GetDataFromMCDS() {  
			try {
				TcpClient sock = new TcpClient();  
				sock.Connect("127.0.0.1", 7777);
				var resp = new byte[1024];
				sock.Client.Receive(resp);
				var info = Encoding.UTF8.GetString(resp, 0, resp.Length).TrimEnd(new [] { (char)0 });
				if (resp.Length > 1) {
					_CaretST3 = new Point(GetMCDSValue("C", info) * GetMCDSValue("CW", info), 
					                      GetMCDSValue("L", info) * GetMCDSValue("LH", info));
					SidebarWidth = GetMCDSValue("SBW", info);
					viewID = GetMCDSValue("VID", info);
				}
			} catch (Exception e) {  
				Logging.Log("Error during GetDataFromMCDS, details\r\b:" + e.Message + "\r\n" + e.StackTrace + "\r\n");
			}
		}
		/// <summary>
		/// Gets caret position from focused window or from focused control in window.
		/// </summary>
		/// <returns>Point</returns>
		public static Point GetCaretPointToScreen(out Point caretOnlyPos)
		{
			var LuckyNone = new Point(77777,77777);
			caretOnlyPos = LuckyNone;
			var _cThr_id = WinAPI.GetCurrentThreadId();
			var _pntCR = new Point(0, 0);
			var _fwFCS_Re = new WinAPI.RECT(0, 0, 0, 0);
			var _fw = WinAPI.GetForegroundWindow();
			uint dummy = 0; 
			var _fwThr_id = WinAPI.GetWindowThreadProcessId(_fw, out dummy);
			IntPtr _fwFCS = IntPtr.Zero;
			var _clsNMb = new StringBuilder(256);
			string _clsNMfw = "";
			Logging.Log("_c HWND: [" +MMain.mahou.Handle+ "], _c ThrId: ["+_cThr_id+"], "+"_fw HWND: ["+_fw+"]"+", _fw ThrId: "+_fwThr_id+".");
			if (_fwThr_id != _cThr_id) {
				if (lastAttachedThread != _fwThr_id && lastAttachedThread != 0) {
					WinAPI.AttachThreadInput(lastAttachedThread, _cThr_id, false);
					Logging.Log("Detaching from thread: ["+lastAttachedThread+"].");
					Logging.Log("Attaching to thread: ["+_cThr_id+"].");
				}
				if (!WinAPI.AttachThreadInput(_fwThr_id, _cThr_id, true))
					return LuckyNone;
				_fwFCS = WinAPI.GetFocus();
				WinAPI.GetClassName(_fw, _clsNMb, _clsNMb.Capacity);
				_clsNMfw = _clsNMb.ToString();
				if (_fwFCS != IntPtr.Zero && _fwFCS != _fw) {
					Logging.Log("_fcs: ["+_fwFCS+"]."+"_fw classname = ["+_clsNMb+"].");
					WinAPI.GetClassName(_fwFCS, _clsNMb, _clsNMb.Capacity);
					Logging.Log("_fcs classname = ["+_clsNMb+"].");
					WinAPI.GetWindowRect(_fwFCS, out _fwFCS_Re);
					WinAPI.GetCaretPos(out _pntCR);
				} else {
					WinAPI.GetCaretPos(out _pntCR);
					WinAPI.GetWindowRect(_fw, out _fwFCS_Re);
				}
				lastAttachedThread = _fwThr_id;
				if (_clsNMfw == "PX_WINDOW_CLASS" && MMain.mahou.MCDSSupport) {
					System.Threading.Tasks.Task.Factory.StartNew(GetDataFromMCDS);
					var CaretToScreen = new Point(_fwFCS_Re.Left, _fwFCS_Re.Top);
					CaretToScreen.X += _CaretST3.X + SidebarWidth + MMain.mahou.MCDS_Xpos_temp;
					if (viewID == 4) {
						WinAPI.RECT clts = new WinAPI.RECT(0,0,0,0);
						WinAPI.GetWindowRect(WinAPI.GetForegroundWindow(), out clts);
						CaretToScreen.Y = clts.Bottom - MMain.mahou.MCDS_BottomIndent_temp - 45 + MMain.mahou.MCDS_Ypos_temp;
						CaretToScreen.X -= 20;
					} else 
						CaretToScreen.Y += _CaretST3.Y + MMain.mahou.MCDS_TopIndent_temp + MMain.mahou.MCDS_Ypos_temp;
					caretOnlyPos = _CaretST3;
					return CaretToScreen;
				} else {
					if (_pntCR.Equals(new Point(0,0)))
						return LuckyNone;
					Logging.Log("CaretPos = x["+_pntCR.X+"], y["+_pntCR.Y+"].");	
					// Do not display caret for these classes:
					var _clsNM = _clsNMb.ToString();
					if (new Regex("[L][I][S][T][B][O][X]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[B][U][T][T][O][N]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
				  	    new Regex("[C][H][E][C][K][B][O][X]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[C][O][M][B][O][B][O][X]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[L][I][S][T][V][I][E][W]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[P][A][G][E][C][O][N][T][r][o][l]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    (new Regex("[W][I][N][D][O][W]", RegexOptions.IgnoreCase).IsMatch(_clsNM) && _clsNM != "MozillaWindowClass") ||
					    new Regex("[S][Y][S][L][I][N][K]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[T][R][E][E]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[H][E][L][P][F][O][R][M]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[T][M][A][I][N][F][O][R][M]", RegexOptions.IgnoreCase).IsMatch(_clsNM) ||
					    new Regex("[B][T][N]", RegexOptions.IgnoreCase).IsMatch(_clsNM) || _clsNM.Contains("Afx:") || 
					    _clsNM == "msctls_trackbar32"|| _clsNM.Contains("wxWindow") ||
					    _clsNM == "SysTabControl32" || _clsNM == "DirectUIHWND" ||
					    _clsNM == "Static" ||  _clsNM == "NetUIHWND" || _clsNMfw == "MSPaintApp" ||
						_clsNM == "PotPlayer" || _clsNM == "MDIClient")
						return LuckyNone;
					if (_clsNM.Contains("SharpDevelop.exe")) {
						_pntCR.Y += 28; _pntCR.X += 3;
					}
					Logging.Log("Get caret position finished successfully.", 0);
					caretOnlyPos = _pntCR;
					return new Point(_fwFCS_Re.Left + _pntCR.X, _fwFCS_Re.Top + _pntCR.Y);
				}
			}
			return LuckyNone;
		}
	}
}