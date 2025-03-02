using UnrealBuildTool;

public class PrototypeServerTarget : TargetRules
{
	public PrototypeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Prototype");
	}
}
