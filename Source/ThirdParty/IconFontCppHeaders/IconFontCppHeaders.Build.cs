using UnrealBuildTool;

public class IconFontCppHeaders : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public IconFontCppHeaders(ReadOnlyTargetRules Target) : base(Target)
#else
	public IconFontCppHeaders(TargetInfo Target)
#endif
	{
		Type = ModuleType.External;
	}
}
