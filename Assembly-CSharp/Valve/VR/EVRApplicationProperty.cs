namespace Valve.VR
{
	public enum EVRApplicationProperty
	{
		Name_String = 0,
		LaunchType_String = 11,
		WorkingDirectory_String = 12,
		BinaryPath_String = 13,
		Arguments_String = 14,
		URL_String = 0xF,
		Description_String = 50,
		NewsURL_String = 51,
		ImagePath_String = 52,
		Source_String = 53,
		IsDashboardOverlay_Bool = 60,
		IsTemplate_Bool = 61,
		IsInstanced_Bool = 62,
		IsInternal_Bool = 0x3F,
		LastLaunchTime_Uint64 = 70
	}
}
