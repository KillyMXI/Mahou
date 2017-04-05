using System;
using System.IO;
using System.Text;

namespace Mahou
{
    class Configs
    {
        /// <summary>
        /// Mahou.ini file path.
        /// </summary>
        public static readonly string filePath = Path.Combine(MahouUI.nPath, "Mahou.ini");
        /// <summary>
        /// Initializes settings, if some of values or settings file, not exists it creates them with default value.
        /// </summary>
        public Configs()
        {
        	if (!File.Exists(filePath)) { //Create an UTF-16 configuration file
                File.WriteAllText(filePath, "!Unicode(✔), Mahou settings file", Encoding.Unicode);
            }
        	#region FirstStart section
            CheckBool("FirstStart", "First", "true");
        	#endregion
            #region Functions section
            CheckBool("Functions", "TrayIconVisible", "true");
            CheckBool("Functions", "ConvertSelectionLayoutSwitching", "false");
            CheckBool("Functions", "ReSelect", "true");
            CheckBool("Functions", "RePress", "true");
            CheckBool("Functions", "AddOneSpaceToLastWord", "false");
            CheckBool("Functions", "ConvertSelectionLayoutSwitchingPlus", "false");
            CheckBool("Functions", "ScrollTip", "false");
            CheckBool("Functions", "StartupUpdatesCheck", "false");
            CheckBool("Functions", "Logging", "false");
            CheckBool("Functions", "CapsLockTimer", "true");
            CheckBool("Functions", "TrayFlags", "true");
            CheckBool("Functions", "BlockMahouHotkeysWithCtrl", "false");
            CheckBool("Functions", "SymbolIgnoreModeEnabled", "false");
            CheckBool("Functions", "MCDServerSupport", "false");
            CheckBool("Functions", "OneLayoutWholeWord", "true");
            #endregion
			#region Layouts section
			CheckBool("Layouts", "SwitchBetweenLayouts", "true");
			CheckBool("Layouts", "EmulateLayoutSwitch", "false");
            CheckString("Layouts", "EmulateLayoutSwitchType", "Alt+Shift");
			CheckBool("Layouts", "ChangeToSpecificLayoutByKey", "true");
			CheckString("Layouts", "MainLayout1", "");
			CheckString("Layouts", "MainLayout2", "");
			CheckInt("Layouts", "SpecificKey1", "1");
			CheckInt("Layouts", "SpecificKey2", "0");
			CheckInt("Layouts", "SpecificKey3", "0");
			CheckInt("Layouts", "SpecificKey4", "0");
			CheckString("Layouts", "SpecificLayout1", Languages.English[Languages.Element.SwitchBetween]);
			CheckString("Layouts", "SpecificLayout2", "");
			CheckString("Layouts", "SpecificLayout3", "");
			CheckString("Layouts", "SpecificLayout4", "");
			#endregion
			#region Appearence section
            CheckBool("Appearence", "DisplayLangTooltipForMouse", "false");
            CheckBool("Appearence", "DisplayLangTooltipForMouseOnChange", "false");
            CheckBool("Appearence", "DisplayLangTooltipForCaret", "false");
            CheckBool("Appearence", "DisplayLangTooltipForCaretOnChange", "false");
            CheckBool("Appearence", "DifferentColorsForLayouts", "false");
			CheckString("Appearence", "Language", "English");
			// Language tooltip appearence for Layout 1
			CheckString("Appearence", "Layout1ForeColor", "#000000");
			CheckString("Appearence", "Layout1BackColor", "#FFFFFF");
            CheckBool("Appearence", "Layout1TransparentBackColor", "false");
			CheckString("Appearence", "Layout1Font", "Georgia; 8pt");
			CheckInt("Appearence", "Layout1Height", "14");
			CheckInt("Appearence", "Layout1Width", "26");
			CheckInt("Appearence", "Layout1PositionX", "8");
			CheckInt("Appearence", "Layout1PositionY", "0");
			// Language tooltip appearence for Layout 2
			CheckString("Appearence", "Layout2ForeColor", "#000000");
			CheckString("Appearence", "Layout2BackColor", "#FFFFFF");
            CheckBool("Appearence", "Layout2TransparentBackColor", "false");
			CheckString("Appearence", "Layout2Font", "Georgia; 8pt");
			CheckInt("Appearence", "Layout2Height", "14");
			CheckInt("Appearence", "Layout2Width", "26");
			CheckInt("Appearence", "Layout2PositionX", "8");
			CheckInt("Appearence", "Layout2PositionY", "0");
			// Language tooltip appearence for Mouse Language Tooltip
			CheckString("Appearence", "MouseLTForeColor", "#000000");
			CheckString("Appearence", "MouseLTBackColor", "#FFFFFF");
            CheckBool("Appearence", "MouseLTTransparentBackColor", "false");
			CheckString("Appearence", "MouseLTFont", "Georgia; 8pt");
			CheckInt("Appearence", "MouseLTHeight", "14");
			CheckInt("Appearence", "MouseLTWidth", "26");
			CheckInt("Appearence", "MouseLTPositionX", "8");
			CheckInt("Appearence", "MouseLTPositionY", "0");
			// Language tooltip appearence for Caret Language Tooltip
			CheckString("Appearence", "CaretLTForeColor", "#000000");
			CheckString("Appearence", "CaretLTBackColor", "#FFFFFF");
            CheckBool("Appearence", "MouseLTTransparentBackColor", "false");
            CheckBool("Appearence", "CaretLTTransparentBackColor", "false");
			CheckString("Appearence", "CaretLTFont", "Georgia; 8pt");
			CheckInt("Appearence", "CaretLTHeight", "14");
			CheckInt("Appearence", "CaretLTWidth", "26");
			CheckInt("Appearence", "CaretLTPositionX", "8");
			CheckInt("Appearence", "CaretLTPositionY", "12");
			// Language tooltip positions for Mahou Cared Display Server
			CheckInt("Appearence", "MCDS_Pos_X", "58");
			CheckInt("Appearence", "MCDS_Pos_Y", "13");
			CheckInt("Appearence", "MCDS_Top", "60");
			CheckInt("Appearence", "MCDS_Bottom", "45");
			// Different text for layouts
			CheckString("Appearence", "Layout1LTText", "");
			CheckString("Appearence", "Layout2LTText", "");
			#endregion
			#region Timings section
			CheckInt("Timings", "LangTooltipForMouseRefreshRate", "25");
			CheckInt("Timings", "LangTooltipForCaretRefreshRate", "25");
			CheckInt("Timings", "DoubleHotkey2ndPressWait", "350");
			CheckInt("Timings", "FlagsInTrayRefreshRate", "100");
			CheckInt("Timings", "ScrollLockStateRefreshRate", "100");
			CheckInt("Timings", "CapsLockDisableRefreshRate", "100");
			CheckBool("Timings", "SelectedTextGetMoreTries", "false");
			CheckInt("Timings", "SelectedTextGetMoreTriesCount", "5");
			CheckString("Timings", "ExcludedPrograms", "LA.exe SomeProg.exe");
			#endregion
			#region Snippets section
			CheckBool("Snippets", "SnippetsEnabled", "false");
			#endregion
			#region Hotkeys section
			// Toggle main window hotkey
			CheckBool("Hotkeys", "ToggleMainWindow_Enabled", "true");
			CheckBool("Hotkeys", "ToggleMainWindow_Double", "false");
			CheckString("Hotkeys", "ToggleMainWindow_Modifiers", "Win + Control + Shift + Alt");
			CheckInt("Hotkeys", "ToggleMainWindow_Key", "45");
			// Convert last word hotkey
			CheckBool("Hotkeys", "ConvertLastWord_Enabled", "true");
			CheckBool("Hotkeys", "ConvertLastWord_Double", "false");
			CheckString("Hotkeys", "ConvertLastWord_Modifiers", "");
			CheckInt("Hotkeys", "ConvertLastWord_Key", "19");
			// Convert selected text hotkey
			CheckBool("Hotkeys", "ConvertSelectedText_Enabled", "true");
			CheckBool("Hotkeys", "ConvertSelectedText_Double", "false");
			CheckString("Hotkeys", "ConvertSelectedText_Modifiers", "");
			CheckInt("Hotkeys", "ConvertSelectedText_Key", "145");
			// Convert last line hotkey
			CheckBool("Hotkeys", "ConvertLastLine_Enabled", "true");
			CheckBool("Hotkeys", "ConvertLastLine_Double", "false");
			CheckString("Hotkeys", "ConvertLastLine_Modifiers", "Shift");
			CheckInt("Hotkeys", "ConvertLastLine_Key", "19");
			// Convert last words hotkey
			CheckBool("Hotkeys", "ConvertLastWords_Enabled", "true");
			CheckBool("Hotkeys", "ConvertLastWords_Double", "false");
			CheckString("Hotkeys", "ConvertLastWords_Modifiers", "Shift");
			CheckInt("Hotkeys", "ConvertLastWords_Key", "122");
			// Toggle symbol ignore mode hotkey
			CheckBool("Hotkeys", "ToggleSymbolIgnoreMode_Enabled", "true");
			CheckBool("Hotkeys", "ToggleSymbolIgnoreMode_Double", "false");
			CheckString("Hotkeys", "ToggleSymbolIgnoreMode_Modifiers", "Shift + Control");
			CheckInt("Hotkeys", "ToggleSymbolIgnoreMode_Key", "122");
			// Selected text to title case hotkey
			CheckBool("Hotkeys", "SelectedTextToTitleCase_Enabled", "false");
			CheckBool("Hotkeys", "SelectedTextToTitleCase_Double", "true");
			CheckString("Hotkeys", "SelectedTextToTitleCase_Modifiers", "Shift");
			CheckInt("Hotkeys", "SelectedTextToTitleCase_Key", "16");
			// Selected text To random case hotkey
			CheckBool("Hotkeys", "SelectedTextToRandomCase_Enabled", "false");
			CheckBool("Hotkeys", "SelectedTextToRandomCase_Double", "true");
			CheckString("Hotkeys", "SelectedTextToRandomCase_Modifiers", "Alt");
			CheckInt("Hotkeys", "SelectedTextToRandomCase_Key", "17");
			// Selected text to swap case hotkey
			CheckBool("Hotkeys", "SelectedTextToSwapCase_Enabled", "false");
			CheckBool("Hotkeys", "SelectedTextToSwapCase_Double", "false");
			CheckString("Hotkeys", "SelectedTextToSwapCase_Modifiers", "Win");
			CheckInt("Hotkeys", "SelectedTextToSwapCase_Key", "19");
			// Selected text Transliteration hotkey
			CheckBool("Hotkeys", "SelectedTextTransliteration_Enabled", "false");
			CheckBool("Hotkeys", "SelectedTextTransliteration_Double", "false");
			CheckString("Hotkeys", "SelectedTextTransliteration_Modifiers", "Win");
			CheckInt("Hotkeys", "SelectedTextTransliteration_Key", "191");
			// Exit Mahou hotkey
			CheckBool("Hotkeys", "ExitMahou_Enabled", "true");
			CheckBool("Hotkeys", "ExitMahou_Double", "false");
			CheckString("Hotkeys", "ExitMahou_Modifiers", "Win + Control + Shift + Alt");
			CheckInt("Hotkeys", "ExitMahou_Key", "123");
			// Restart Mahou hotkey
			CheckBool("Hotkeys", "RestartMahou_Enabled", "true");
			CheckString("Hotkeys", "RestartMahou_Modifiers", "Win + Shift + Alt");
			CheckInt("Hotkeys", "RestartMahou_Key", "33");
			#endregion
            #region Proxy section
            CheckString("Proxy", "ServerPort", "");
            CheckString("Proxy", "UserName", "");
            CheckString("Proxy", "Password", "");
            #endregion
        }
        void CheckBool(string section, string key, string default_value) {
            bool bt = false; //bool temp
            if (!Boolean.TryParse(Read(section, key), out bt))
                Write(section, key, default_value);
        }
        void CheckInt(string section, string key, string default_value) {
            int it = 0; //int temp
            if (!Int32.TryParse(Read(section, key), out it))
                Write(section, key, default_value);
        }
        void CheckString(string section, string key, string default_value) {
            if (String.IsNullOrEmpty(Read(section, key)))
                Write(section, key, default_value);
        }
        /// <summary>
        /// Writes "value" to "key" in "section" in INI configuration.
        /// </summary>
        /// <param name="section">Section name in which key will be written.</param>
        /// <param name="key">Key name to be written.</param>
        /// <param name="value">Key's value to be written.</param>
        public void Write(string section, string key, string value) {
            WinAPI.WritePrivateProfileString(section, key, value, filePath);
        }
        /// <summary>
        /// Reads "value" from "key" in "section" from INI configuration.
        /// </summary>
        /// <param name="section">Section name in which key will be read.</param>
        /// <param name="key">Key's name in which value will be read.</param>
        /// <returns>string</returns>
        public string Read(string section, string key) {
            var SB = new StringBuilder(255);
            int i = WinAPI.GetPrivateProfileString(section, key, "", SB, 255, filePath);
            return SB.ToString();
        }
        /// <summary>
        /// Reads "value" as int from "key" in "section" from INI configuration.
        /// </summary>
        /// <param name="section">Section name in which key will be read.</param>
        /// <param name="key">Key's name in which value will be read.</param>
        /// <returns>int</returns>
        public int ReadInt(string section, string key) {
            var SB = new StringBuilder(255);
            int i = WinAPI.GetPrivateProfileString(section, key, "", SB, 255, filePath);
            return Int32.Parse(SB.ToString());
        }
        /// <summary>
        /// Reads "value" as bool from "key" in "section" from INI configuration.
        /// </summary>
        /// <param name="section">Section name in which key will be read.</param>
        /// <param name="key">Key's name in which value will be read.</param>
        /// <returns>bool</returns>
        public bool ReadBool(string section, string key) {
            var SB = new StringBuilder(255);
            int i = WinAPI.GetPrivateProfileString(section, key, "", SB, 255, filePath);
            return Boolean.Parse(SB.ToString().ToLower());
        }
    }
}
