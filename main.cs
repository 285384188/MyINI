static class Program
{
	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		INIFile _ini = new INIFile(Application.StartupPath + @"\Settings.ini");
		
		_ini.Write("Settings","Value1","YepYep"); // Writing the ini file.
		string YepYep = _ini.Read("Settings","Value1") // Reading the ini file as String, you can override func given in the INIFýle Class
		
		
	}
}