using UnrealBuildTool;

public class PrototypeTarget : TargetRules
{
	public PrototypeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Prototype");
	}
}
