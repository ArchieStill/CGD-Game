using UnrealBuildTool;

public class PrototypeClientTarget : TargetRules
{
	public PrototypeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Prototype");
	}
}
