namespace Mahou
{
	public class Hotkey
	{
		public readonly bool enabled;
		public readonly int keyCode;
		public readonly bool[] modifs;
		public readonly bool Double;
		/// <summary>
		/// Initializes an hotkey, modifs are [ctrl, shift, alt, win].
		/// </summary>
		public Hotkey(bool enabled, int keyCode, bool[] modifs, bool Double = false)
		{
			this.enabled = enabled;
			this.keyCode = keyCode;
			this.modifs = modifs;
			this.Double = Double;
		}
		/// <summary>
		/// Checks equality of two Hotkeys.
		/// </summary>
		/// <param name="o">Hotkey as object.</param>
		/// <returns>bool</returns>
		public override bool Equals(object o)
		{
			return o is Hotkey && ((Hotkey)o).keyCode == keyCode &&
				((Hotkey)o).modifs[0] == modifs[0] &&
				((Hotkey)o).modifs[1] == modifs[1] &&
				((Hotkey)o).modifs[2] == modifs[2] &&
				((Hotkey)o).modifs[3] == modifs[3];
		}
		/// <summary>
		/// Gets hotkey hash code.
		/// </summary>
		/// <returns>int</returns>
		public override int GetHashCode()
		{
			return this.keyCode.GetHashCode() + this.modifs.GetHashCode();
		}
		/// <summary>
		/// Gets all modifiers in hotkey.
		/// </summary>
		/// <param name="hkmods">Hotkey modifiers string.</param>
		/// <returns></returns>
		public static bool[] GetMods(string hkmods)
		{
			return new bool[] { hkmods.Contains("Control"), hkmods.Contains("Shift"), hkmods.Contains("Alt"), hkmods.Contains("Win") };
		}
	}
}
