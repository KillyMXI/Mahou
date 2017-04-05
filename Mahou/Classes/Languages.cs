using System.Collections.Generic;
public class Languages
{
	public enum Element { 
		#region Tabs
		tab_Functions,
		tab_Layouts,
		tab_Appearence,
		tab_Timings,
		tab_Snippets,
		tab_Hotkeys,
		tab_Updates,
		tab_About,
		#endregion
		#region Functions
		AutoStart,
		TrayIcon,
		ConvertSelectionLS,
		ReSelect,
		RePress,
		Add1Space,
		ConvertSelectionLSPlus,
		HighlightScroll,
		UpdatesCheck,
		Logging,
		CapsTimer,
		ContryFlags,
		BlockCtrlHKs,
		MCDSSupport,
		OneLayoutWholeWord,
		#endregion
		#region Layouts
		SwitchBetween,
		EmulateLS,
		EmulateType,
		ChangeLayoutBy1Key,
		#endregion
		#region Appearence
		LDMouseDisplay,
		LDCaretDisplay,
		LDOnlyOnChange,
		LDDifferentAppearence,
		Language,
		LDAppearence,
		LDAroundMouse,
		LDAroundCaret,
		LDTransparentBG,
		LDFont,
		LDFore,
		LDBack,
		LDText,
		LDSize,
		LDPosition,
		LDWidth,
		LDHeight,
		MCDSTopIndent,
		MCDSBottomIndent,
		#endregion
		#region Timings
		LDForMouseRefreshRate,
		LDForCaretRefreshRate,
		DoubleHKDelay,
		TrayFlagsRefreshRate,
		ScrollLockRefreshRate,
		CapsLockRefreshRate,
		MoreTriesToGetSelectedText,
		ExcludedPrograms,
		#endregion
		#region Snippets
		SnippetsEnabled,
		#endregion
		#region Hotkeys
		ToggleMainWnd,
		ConvertLast,
		ConvertSelected,
		ConvertLine,
		ConvertWords,
		ToggleSymbolIgnore,
		SelectedToTitleCase,
		SelectedToRandomCase,
		SelectedToSwapCase,
		SelectedTransliteration,
		ExitMahou,
		RestartMahou,
		Enabled,
		DoubleHK,
		#endregion
		#region Updates
		CheckForUpdates,
		CheckingForUpdates,
		YouHaveLatest,
		TimeToUpdate,
		UpdateMahou,
		DownloadUpdate,
		ProxyConfig,
		ProxyServer,
		ProxyLogin,
		ProxyPass,
		Error,
		NetError,
		#endregion
		#region About
		DbgInf,
		DbgInf_Copied,
		Site,
		Releases,
		About,
		#endregion
		#region Misc
		Keys,
		Key_Left,
		Key_Right,
		Layouts,
		Plugin,
		Layout,
		Hotkey,
		UpdateFound,
		UpdateComplete,
		ShowHide,
		Mahou,
		#endregion
		#region Buttons
		ButtonOK,
		ButtonApply,
		ButtonCancel,
		#endregion
		#region Tooltips
		TT_SwitchBetween,
		TT_ConvertSelectionSwitch,
		TT_BlockCtrl,
		TT_CapsDis,
		TT_EmulateLS,
		TT_RePress,
		TT_Add1Space,
		TT_ReSelect,
		TT_ScrollTip,
		TT_LDOnlyOnChange,
		TT_ConvertSelectionSwitchPlus,
		TT_LDForMouse,
		TT_LDForCaret,
		TT_Snippets,
		TT_Logging,
		TT_LDDifferentAppearence,
		TT_CountryFlags,
		TT_SymbolIgnore,
		TT_ConvertWords,
		TT_ExcludedPrograms,
		TT_MCDSSupport,
		TT_LDText,
		TT_OneLayoutWholeWordCS,
		#endregion
		#region Messages
		MSG_SnippetsError
		#endregion
	}
	public static Dictionary<Element, string> English = new Dictionary<Element, string>() { 
		#region Tabs
		{ Element.tab_Functions, "Functions" }, 
		{ Element.tab_Layouts, "Layouts" }, 
		{ Element.tab_Appearence, "Appearence" }, 
		{ Element.tab_Timings, "Timings" }, 
		{ Element.tab_Snippets, "Snippets" }, 
		{ Element.tab_Hotkeys, "Hotkeys" }, 
		{ Element.tab_Updates, "Updates" }, 
		{ Element.tab_About, "About" }, 
		#endregion
		#region Functions
		{ Element.AutoStart, "Start with Windows." }, 
		{ Element.TrayIcon, "Show tray icon." }, 
		{ Element.ConvertSelectionLS, "Convert selection layout switching." }, 
		{ Element.ReSelect, "Re-select text after conversion." }, 
		{ Element.RePress, "Re-press modifiers after hotkey action." }, 
		{ Element.Add1Space, "Add one space to last word." }, 
		{ Element.ConvertSelectionLSPlus, "Convert selection layout switching+ (experimental)." }, 
		{ Element.HighlightScroll, "Highlight Scroll-Lock when layout 1 is active." }, 
		{ Element.UpdatesCheck, "Check for updates at startup." }, 
		{ Element.Logging, "Enable logging for debugging." }, 
		{ Element.CapsTimer, "Activate Caps Lock disabler timer." }, 
		{ Element.ContryFlags, "Display country flags in tray icon." }, 
		{ Element.BlockCtrlHKs, "Block Mahou hotkeys with Ctrl." }, 
		{ Element.MCDSSupport, "Enable MCDS support." }, 
		{ Element.OneLayoutWholeWord, "Use layout for whole word in CS." }, 
		#endregion
		#region Layouts
		{ Element.SwitchBetween, "Switch between layouts" }, 
		{ Element.EmulateLS, "Emulate layout switching." }, 
		{ Element.EmulateType, "Emulation type:" }, 
		{ Element.ChangeLayoutBy1Key, "Change to specific layout by keys:" }, 
		#endregion
		#region Appearence
		{ Element.LDMouseDisplay, "Display current language tooltip around mouse." }, 
		{ Element.LDCaretDisplay, "Display current language tooltip around caret." }, 
		{ Element.LDOnlyOnChange, "Display only on layout change." }, 
		{ Element.LDDifferentAppearence, "Use different appearence for layouts." }, 
		{ Element.Language, "Language:" }, 
		{ Element.LDAppearence, "Language tooltip appearence" }, 
		{ Element.LDAroundMouse, "Around mouse" }, 
		{ Element.LDAroundCaret, "Around caret" }, 
		{ Element.LDTransparentBG, "Transparent color" }, 
		{ Element.LDFont, "Font" }, 
		{ Element.LDFore, "Foreground color:" }, 
		{ Element.LDBack, "Background color:" }, 
		{ Element.LDText, "Tooltip text:" }, 
		{ Element.LDSize, "Size" }, 
		{ Element.LDPosition, "Position" }, 
		{ Element.LDWidth, "Width" }, 
		{ Element.LDHeight, "Height" }, 
		{ Element.MCDSTopIndent, "Top" }, 
		{ Element.MCDSBottomIndent, "Bottom" }, 
		#endregion
		#region Timings
		{ Element.LDForMouseRefreshRate, "Language tooltip around mouse refresh rate(ms):" }, 
		{ Element.LDForCaretRefreshRate, "Language tooltip around caret refresh rate(ms):" }, 
		{ Element.DoubleHKDelay, "Double hotkey wait time for second press(ms):" }, 
		{ Element.TrayFlagsRefreshRate, "Flags in tray icon refresh rate(ms):" }, 
		{ Element.ScrollLockRefreshRate, "Scroll Lock refresh rate(ms):" }, 
		{ Element.CapsLockRefreshRate, "Caps Lock update rate(ms):" }, 
		{ Element.MoreTriesToGetSelectedText, "Use more tries to get selected text:" }, 
		{ Element.ExcludedPrograms, "Excluded programs:" }, 
		#endregion
		#region Snippets
		{ Element.SnippetsEnabled, "Enable snippets." }, 
		#endregion
		#region Hotkeys
		{ Element.ToggleMainWnd, "Toggle settings window" }, 
		{ Element.ConvertLast, "Convert last word" }, 
		{ Element.ConvertSelected, "Convert selected text" }, 
		{ Element.ConvertLine, "Convert last line" }, 
		{ Element.ConvertWords, "Convert specific last words count" }, 
		{ Element.ToggleSymbolIgnore, "Toggle symbol ignore mode" }, 
		{ Element.SelectedToTitleCase, "Selected text words to Title Case" }, 
		{ Element.SelectedToRandomCase, "Selected text words to RanDoM cASe" }, 
		{ Element.SelectedToSwapCase, "Selected text words to sWAP cASE" }, 
		{ Element.SelectedTransliteration, "Selected text transliteration" }, 
		{ Element.ExitMahou, "Exit" }, 
		{ Element.RestartMahou, "Restart" }, 
		{ Element.Enabled, "Enabled" }, 
		{ Element.DoubleHK, "Double hotkey" }, 
		#endregion
		#region Updates
		{ Element.CheckForUpdates, "Check for updates:" }, 
		{ Element.CheckingForUpdates, "Checking..." }, 
		{ Element.YouHaveLatest, "You have latest version." }, 
		{ Element.TimeToUpdate, "I think it is time to update." }, 
		{ Element.UpdateMahou, "Update Mahou to <version>" }, 
		{ Element.DownloadUpdate, "Download update" }, 
		{ Element.ProxyConfig, "Proxy configuration" }, 
		{ Element.ProxyServer, "Server:Port" }, 
		{ Element.ProxyLogin, "Login:" }, 
		{ Element.ProxyPass, "Password:" }, 
		{ Element.Error, "Error..." }, 
		{ Element.NetError, "Connection to github.com can't be established, check your network connection or proxy settings..." },
		#endregion
		#region About
		{ Element.DbgInf, "Debug info" }, 
		{ Element.DbgInf_Copied, "Copied!" }, 
		{ Element.Site, "Site" }, 
		{ Element.Releases, "Releases" }, 
		{ Element.About, "Hotkeys:\r\n"+"Press Pause (by Default) to convert last inputted word.\r\n" + 
			"Press Scroll Lock (by Default) while selected text is focused to convert it.\r\n"+
			"Press Shift+Pause (by Default) to convert last inputted line.\r\n"+
            "Press Ctrl+Alt+Win+Shift+Insert to show Mahou main window.\r\n"+
			"Press Ctrl+Alt+Win+Shift+F12 to shutdown Mahou.\r\n\r\n"+
			"*Note that if you typing in not of selected in settings layouts,"+
			" conversion will switch typed text to Language 1 (Ignored if Switch between layouts is OFF).\r\n\r\n"+
            "**If you have problems with symbols conversion (selection) try enabling function \"Use layout for whole word in CS\", "+
			" or \"switching languages (1=>2 & 2=>1)\""+
			" or \"Convert selection layout switching\" or Plus option." +
			"***If you have problems with selection conversion try inreasing tries to get selected text in Timings tab." +
			"\r\n\r\nRegards." },
		#endregion
		#region Misc
		{ Element.Keys, "Keys" }, 
		{ Element.Key_Left, "Left" }, 
		{ Element.Key_Right, "Right" }, 
		{ Element.Layouts, "Layouts" }, 
		{ Element.Plugin, "plugin" }, 
		{ Element.Layout, "Layout" }, 
		{ Element.Hotkey, "Hotkey" }, 
		{ Element.UpdateFound, "New version avaible!" }, 
		{ Element.UpdateComplete, "Mahou succesfully updated!" }, 
		{ Element.ShowHide, "Show/Hide" }, 
		{ Element.Mahou, "Mahou(魔法) - magic layout switcher." }, 
		#endregion
		#region Buttons
		{ Element.ButtonOK, "OK" }, 
		{ Element.ButtonApply, "Apply" }, 
		{ Element.ButtonCancel, "Cancel" }, 
		#endregion
		#region Tooltips
		{ Element.TT_SwitchBetween, "While this option disabled, [Convert word] and [Convert line] and [Convert selection with \"Convert selection layout switching\" enabled]\n" + 
		                                  "will just cycle between all locales instead of switching between selected in settings."+
		                                  "If there is program in which [Convert word] or [Convert line] or [Convert selection with \"CS-Switch\" enabled] not work,\ntry with this option enabled.\n" },
		{ Element.TT_ConvertSelectionSwitch, "If enabled, Convers selection will use layout switching.\nAll symbols will be written as the must(if layout before switching was the one where they are written it).\nThere also a plus version of that function." }, 
		{ Element.TT_BlockCtrl, "Blocks hotkeys that use Control,\nwhen \"Switch layout by key\" is set to Left/Right Control." }, 
		{ Element.TT_CapsDis, "If enabled, timer which disables CapsLock(led) will work." }, 
		{ Element.TT_EmulateLS, "If enabled, layout switching will emulate press of keys selected on right." }, 
		{ Element.TT_RePress, "If enabled, modifiers(Ctrl/Alt/Shift/Win) will be pressed again conversion(recommended?),\r\n"+
				"although with a very small probability (less than 0.01%) modifiers may stuck...))." },
		{ Element.TT_Add1Space, "If enabled, ONE space will be adding to last word." }, 
		{ Element.TT_ReSelect, "If enabled, any \"Convert selected\" will select text again after conversion." }, 
		{ Element.TT_ScrollTip, "Highlight Scroll Lock when active language 1, selected in Layouts tab.\nUnnesesary to keep enabled \"Switch between layouts\" function enabled for this function to work, just select layout #1 below it and the disable it if you need to." }, 
		{ Element.TT_LDOnlyOnChange, "Display language tooltip only on layout change.\nDisplay time - 2x[Refresh rate for mouse + for caret]." }, 
		{ Element.TT_ConvertSelectionSwitchPlus, "Combines some abilities of Convert selection with enabled \"Convert selection layout switching\" and when it disabled." +
										"\nIt can:"+
										"\n1.Conversion text from different layouts to different layouts at once."+
										"\n2.gnore symbols feature work in it."+
										"\n3.Auto get layout of text (symbols, that exist in both layouts are not supported)."+
										"\n4.Convert unsupported symbols differently, if you change layout before conversion." }, 
		{ Element.TT_LDForMouse, "If enabled, when hovering text form with, around mouse will be displayed language tooltip." }, 
		{ Element.TT_LDForCaret, "If enabled, around caret will be displayed language tooltip." }, 
		{ Element.TT_Snippets, "If enabled, pressing SPACE will expand small (which starts with \"->\") word, to big (which is between \"====>\" and \"<====\") word/text fragment." }, 
		{ Element.TT_Logging, "Designed ONLY to search for errors, BIG PERFORMANCE IMPACT, logs are saved in Mahou's folder, in folder Logs." }, 
		{ Element.TT_LDDifferentAppearence, "If enabled, you can select different appearence for main layouts(1&2), for others will be used from \"around mouse\" or \"around caret\"." }, 
		{ Element.TT_CountryFlags, "If enabled, tray icon will display country flags." }, 
		{ Element.TT_SymbolIgnore, "If enabled, symbols []{};':\"./<>? will be ignored.\nWorks in Convert last word, line, selection with  \"Conver selection layout switching\" enabled or plus.\n" +
										"WON'T WORK IF YOU HAVE MORE THAN 2 LAYOUTS AND FUNCTION \"Switch between layouts\" disabled!" }, 
		{ Element.TT_ConvertWords, "Allow to convert specific last word count by pressing hotkey and then 0-9 (0 = 10) on keyboard." }, 
		{ Element.TT_ExcludedPrograms, "Programs(excluded) in which convert hotkeys won't work.\nSeperators - any symbols including a space.." }, 
		{ Element.TT_MCDSSupport, "Add ability to display language tooltip around caret in Sublime Text 3.\nFor it to work yout need to install plugin, link on right.\nSettings avaible in appearence tab:\nTop: Your ST3 titlebar + tab bar height,\nBottom: Your y pixels to ST3 console edit box(ctrl+`).\nFor different windows/themes settings will be different!" }, 
		{ Element.TT_LDText, "Leave empty for auto-detect." }, 
		{ Element.TT_OneLayoutWholeWordCS, "Use one layout for whole word in Convert Selection,\r\n"+
				"this feature uses quantity of rightly recognized chars in two selected layouts to indicate layout of whole word,"+
				"\r\nthis feature works PERFECTLY with words that have symbols around them, but word lenght must be greater that 1 char for this feature to work properly." },
		#endregion
		#region Messages
		{ Element.MSG_SnippetsError, "Snippets contains error in syntax, check if there are errors, details on snippets syntax you can find on Wiki." }
		#endregion
	};
	/// <summary>
	/// Russian language for MahouUI.
	/// </summary>
	public static Dictionary<Element, string> Russian = new Dictionary<Element, string>() {
		#region Tabs
		{ Element.tab_Functions, "Функции" }, 
		{ Element.tab_Layouts, "Раскладки" }, 
		{ Element.tab_Appearence, "Вид" }, 
		{ Element.tab_Timings, "Тайминги" }, 
		{ Element.tab_Snippets, "Сниппеты" }, 
		{ Element.tab_Hotkeys, "Горячие клавиши" }, 
		{ Element.tab_Updates, "Обновления" }, 
		{ Element.tab_About, "О..." }, 
		#endregion
		#region Functions
		{ Element.AutoStart, "Запускать вместе с Windows." }, 
		{ Element.TrayIcon, "Показывать иконку в трее." }, 
		{ Element.ConvertSelectionLS, "Смена раскладки в Конверт выделения." }, 
		{ Element.ReSelect, "Выделять заново текст после конвертации." }, 
		{ Element.RePress, "Нажимать снова модификаторы горячих клавиш." }, 
		{ Element.Add1Space, "Добавлять 1 пробел в текущее слово." }, 
		{ Element.ConvertSelectionLSPlus, "Смена раскладки в Конверт выделения+ (экспереметнально)." }, 
		{ Element.HighlightScroll, "Подсвечивать Scroll-Lock когда раскладка 1 активна." }, 
		{ Element.UpdatesCheck, "Проверять обновления при запуске." }, 
		{ Element.Logging, "Включить журналирование действий для поиска ошибок." }, 
		{ Element.CapsTimer, "Включит таймер отключатель Caps-Lock." }, 
		{ Element.ContryFlags, "Отображать флаги стран в трее." }, 
		{ Element.BlockCtrlHKs, "Блокировать горячие клавиши Mahou содержащие Ctrl." }, 
		{ Element.MCDSSupport, "Включить поддержку MCDS." }, 
		{ Element.OneLayoutWholeWord, "Считать раскладку для всего слова в КВ." }, 
		#endregion
		#region Layouts
		{ Element.SwitchBetween, "Переключать между раскладками" }, 
		{ Element.EmulateLS, "Эмулировать переключение раскладки." }, 
		{ Element.EmulateType, "Тип эмуляции:" }, 
		{ Element.ChangeLayoutBy1Key, "Переключать раскладки по клавишам:" }, 
		#endregion
		#region Appearence
		{ Element.LDMouseDisplay, "Отображать подсказку текущего языка рядом с мышью." }, 
		{ Element.LDCaretDisplay, "Отображать подсказку текущего языка рядом с кареткой." }, 
		{ Element.LDOnlyOnChange, "Отображать только при смене." }, 
		{ Element.LDDifferentAppearence, "Использовать разный вид для раскладок." }, 
		{ Element.Language, "Язык:" }, 
		{ Element.LDAppearence, "Вид подсказки языка" }, 
		{ Element.LDAroundMouse, "Возле мыши" }, 
		{ Element.LDAroundCaret, "Возле каретки" }, 
		{ Element.LDTransparentBG, "Прозрачный цвет" }, 
		{ Element.LDFont, "Шрифт" }, 
		{ Element.LDFore, "Цвет текста:" }, 
		{ Element.LDBack, "Цвет фона:" }, 
		{ Element.LDText, "Текст подсказки:" }, 
		{ Element.LDSize, "Размер" }, 
		{ Element.LDPosition, "Позиция" }, 
		{ Element.LDWidth, "Ширина" }, 
		{ Element.LDHeight, "Высота" }, 
		{ Element.MCDSTopIndent, "Сверху" }, 
		{ Element.MCDSBottomIndent, "Снизу" }, 
		#endregion
		#region Timings
		{ Element.LDForMouseRefreshRate, "Скорость обновления подсказки языка возле мыши(мс):" }, 
		{ Element.LDForCaretRefreshRate, "Скорость обновления подсказки языка возле каретки(мс)" }, 
		{ Element.DoubleHKDelay, "Время ожидания следующего нажатия двойных горячих клавиш(мс):" }, 
		{ Element.TrayFlagsRefreshRate, "Скорость обновления флагов в трее(мс):" }, 
		{ Element.ScrollLockRefreshRate, "Скорость обновления Scroll Lock(мс):" }, 
		{ Element.CapsLockRefreshRate, "Скорость обновления Caps Lock(ms):" }, 
		{ Element.MoreTriesToGetSelectedText, "Использовать больше попыток взятия текста:" }, 
		{ Element.ExcludedPrograms, "Программы исключения:" }, 
		#endregion
		#region Snippets
		{ Element.SnippetsEnabled, "Включить сниппеты." }, 
		#endregion
		#region Hotkeys
		{ Element.ToggleMainWnd, "Переключить видимость главного окна" }, 
		{ Element.ConvertLast, "Конвертация последнего слова" }, 
		{ Element.ConvertSelected, "Конвертация выделенного текста" }, 
		{ Element.ConvertLine, "Конвертация последней линии" }, 
		{ Element.ConvertWords, "Конвертация нескольких слов" }, 
		{ Element.ToggleSymbolIgnore, "Переключить игнорование символов" }, 
		{ Element.SelectedToTitleCase, "Выделенные слов в Заглавный регистр" }, 
		{ Element.SelectedToRandomCase, "Выделенные слов в СЛУчАйнЫй регистр" }, 
		{ Element.SelectedToSwapCase, "Выделенные слов в оБРАТЫНЙ регистр" }, 
		{ Element.SelectedTransliteration, "Транслитерация выледенного текста" }, 
		{ Element.ExitMahou, "Выход" }, 
		{ Element.RestartMahou, "Перезапустить" }, 
		{ Element.Enabled, "Включена" }, 
		{ Element.DoubleHK, "Двойная горячая клавиша" }, 
		#endregion
		#region Updates
		{ Element.CheckForUpdates, "Проверить обновления:" }, 
		{ Element.CheckingForUpdates, "Проверяю..." }, 
		{ Element.YouHaveLatest, "У Вас последняя версия." }, 
		{ Element.TimeToUpdate, "Думаю пора обновиться." }, 
		{ Element.UpdateMahou, "Обновить Mahou к <версии>" }, 
		{ Element.DownloadUpdate, "Скачать обновление" }, 
		{ Element.ProxyConfig, "Конфигурация прокси" }, 
		{ Element.ProxyServer, "Сервер:порт" }, 
		{ Element.ProxyLogin, "Логин:" }, 
		{ Element.ProxyPass, "Пароль:" }, 
		{ Element.Error, "Ошибка..." }, 
		{ Element.NetError, "Соединение с github.com не может быть установлено, " +
			"проверьте подключение к интернету или ваши настройки прокси..."}, 
		#endregion
		#region About
		{ Element.DbgInf, "Отладочная информация" }, 
		{ Element.DbgInf_Copied, "Скопировано!" }, 
		{ Element.Site, "Сайт" }, 
		{ Element.Releases, "Релизы" }, 
		{ Element.About, "Горячие клавиши:\r\nНажмите Pause (по умолчанию) для конвертации последнего введённого слова.\r\n" +
			"Нажмите Scroll (по умолчанию) пока выделенный текст в фокусе чтобы конвертировать его.\r\n"+
			"Нажмите Shift+Pause (по умолчанию) для конвертации последней введённой линии.\r\n"+
            "Нажмите Ctrl+Alt+Win+Shift+Insert чтобы показать/скрыть главное окно.\r\n"+
			"Нажмите Ctrl+Alt+Win+Shift+F12 чтобы завершить Mahou.\r\n"+
			"\r\n*Заметьте что если you вводите текст не из выбранных раскладок в настройках, то конвертация конвертирует текст в Язык 1 (Не актуально если включён Циклич. режим).\r\n\r\n"+
            "**Если у Вас проблемы с символами при Конвертации выделения, включите функцию(рекомендуется) \"Считать раскладку для всего слова в КВ\", еще можете попробовать \"переключить языки местами (1=>2 & 2=>1)\" или включите \"Смена раскладки в конверт выделенния\" или плюс.\r\n"+
			"***Если у Вас проблемы при Конвертации выделения попробуйте увеличить количество попыток взятия текста во вкладке Тайминги." +
			"\r\nУдачи."}, 
		#endregion
		#region Misc
		{ Element.Keys, "Клавиши" }, 
		{ Element.Key_Left, "Левый" }, 
		{ Element.Key_Right, "Правый" }, 
		{ Element.Layouts, "Раскладки" }, 
		{ Element.Layout, "Раскладка" }, 
		{ Element.Plugin, "плагин" }, 
		{ Element.Hotkey, "Горячая клавиша" }, 
		{ Element.UpdateFound, "Новая версия доступна!" }, 
		{ Element.UpdateComplete, "Mahou успешно обновлен!" }, 
		{ Element.ShowHide, "Показать/Скрыть" }, 
		{ Element.Mahou, "Mahou(魔法) - волшебный переключатель раскладок." }, 
		#endregion
		#region Buttons
		{ Element.ButtonOK, "ОК" }, 
		{ Element.ButtonApply, "Применить" }, 
		{ Element.ButtonCancel, "Отмена" }, 
		#endregion
		#region Tooltips
		{ Element.TT_SwitchBetween, "Пока включена, [Конверт слова] and [Конверт линии] and [Конверт выделения с \"Смена раскладки в конверт выделенния\" включённой]\n" +
		                                  "будет переключать раскладку циклично, вместо переключения между выбранными в настройках." +
		                                  "Если есть программа в которой [Конверт слова] или [Конверт линии] или [Конверт выделения с \"Смена раскладки в конверт выделенния\" включённой] не работают,\nто попробуйте включить эту функцию.\n" }, 
		{ Element.TT_ConvertSelectionSwitch, "Если включена, Конверт выделения Будет использовать переключение раскладки.\nВсе символы будут напечатаны правильно(если перед переключением стояла раскладка в которой они были написаны).\nТакже есть улучшение функции, \"плюс\"." }, 
		{ Element.TT_BlockCtrl, "Блокирует горячие клавиши содержащие Control,\nможет быть полезно если \"Переключать язык клавишей\" установлен на Left/Right Control." }, 
		{ Element.TT_CapsDis, "Если включено, то будет работать таймер который будет выключать CapsLock(лампочку)." }, 
		{ Element.TT_EmulateLS, "Если включено, переключение раскладку будет эмулировать нажатие клавиш выбранный правее для переключения раскладки." }, 
		{ Element.TT_RePress, "Если включено, то модификаторы(Ctrl/Alt/Shift/Win) будут нажаты заново после действия горячей клавиши.(рекомендуется?),\r\n"+
							  "хотя с очень маленькой вероятностью (менее 0.01%) могут залипнуть модификаторы...)." },
		{ Element.TT_Add1Space, "Если включено, то ОДИН пробел будет добавлятся в последнее слово." }, 
		{ Element.TT_ReSelect, "Если включено, любые \"Конверт выделения\" будут выделять тескт заново." }, 
		{ Element.TT_ScrollTip, "Подсвечивать лампочку Scroll Lock когда активна раскладка 1, выбранная во вкладке Раскладки.\nНе обязательно оставлять включенным функцию \"Переключать между раскладками\", нужно просто выбрать раскладку #1 ниже неё." }, 
		{ Element.TT_LDOnlyOnChange, "Отображать подсказку языка только при смене раскладки.\nВремя оторбражения - 2x[Скорость обновления возле каретки + возле мыши]." }, 
		{ Element.TT_ConvertSelectionSwitchPlus, "Совмещает способности Конверт выделения с включенным \"Смена раскладки в Конверт выделения\" и когда она выключена." +
										"\nВозможности:"+
										"\n1.Конвертировать текст с разных языков на разные языки за 1 конвертацию."+
										"\n2.Игнорирование символов работает здесь."+
										"\n3.Авто-разпознавание раскладки текста(символы которые есть в обоих раскладках не поддерживаются)"+
										"\n4.Конвертировать не поддерживаемые символы по разному если менять раскладку перед конвертацией." }, 
		{ Element.TT_LDForMouse, "Если включена, то при наведении на текстовую форму мышью будет отображаться подсказка языка." }, 
		{ Element.TT_LDForCaret, "Если включена, то возле текстового курсора будет отображаться подсказка языка." }, 
		{ Element.TT_Snippets, "Если включено, нажатие ПРОБЕЛА увеличит маленькое слово(которое имеет суффикс \"->\"), в большой кусок текста(который между \"====>\" и \"<====\")." }, 
		{ Element.TT_Logging, "Создано ТОЛЬКО поиска ошибок, БОЛЬШОЕ ВЛИЯНИЕ НА СКОРОСТЬ РАБОТЫ, журналы сохраняются в папке где Mahou.exe в папке \"Logs\"." }, 
		{ Element.TT_LDDifferentAppearence, "Если включено то вы сможете выбрать разный вид для двух раскладок(1&2), для других будут использоваться стандартные из \"возле мыши\" или \"возле каретки\"." }, 
		{ Element.TT_CountryFlags, "Если включено, иконка в трее будет показывать флаги стран." }, 
		{ Element.TT_SymbolIgnore, "Если включено, символы []{};':\"./<>? будут проигнорированы.\nРаботает в Конверт слова, линии, выделения с включенным \"Смена раскладки в Конверт выделения\" или плюс.\n" +
										"НЕ БУДЕТ РАБОТАТЬ если у Вас больше 2 раскладок и функция \"Преключать между раскладками\" выключена!" }, 
		{ Element.TT_ConvertWords, "Дает возможность конвертировать специфическое количество последних слов, после горячей клавиши нажмите 0-9(0 = 10) на клавиатуре." }, 
		{ Element.TT_ExcludedPrograms, "Программы(исключения) в которых горячие клавиши Конвертирования не будут работать.\nРазделители - любые символы включая пробел." }, 
		{ Element.TT_MCDSSupport, "Дает возможность отображения подсказки текущего языка возле каретки в Sublime Text 3.\nДля его работы нужно установить плагин, ссылка с права.\nНастройки во вкладке Вид.\nСверху: Высота заголовка окна + высота панели вкладок ST3,\nСнизу: Ваши y пиксели от конца окна до формы ввода консоли ST3(ctrl+`).\nДля разных Windows/Тем будут нужны разные настройки!" }, 
		{ Element.TT_LDText, "Оставьте пустым для авто-определения." }, 
		{ Element.TT_OneLayoutWholeWordCS, "Использовать одну раскладку для целого слова в Конверт Выделения,\r\n"+
				"эта функция использует количество правильно распознанных букв в двух раскладках чтобы определить раскладку слова,\r\n"+
				"эта функция ПРЕКРАСНО работает с словами которые имеют рядом символы, но длинна слова должна быть больше 1(не включая символы) чтобы функция нормально работала." },
		#endregion
		#region Messages
		{ Element.MSG_SnippetsError, "Сниппеты содержат ошибки в синтаксисе, проверьте ваши сниппеты, детали синтаксиса можете найти на Wiki." }
		#endregion
	};
}