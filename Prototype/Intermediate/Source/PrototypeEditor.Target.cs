using UnrealBuildTool;

public class PrototypeEditorTarget : TargetRules
{
	public PrototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Prototype");
	}
}
