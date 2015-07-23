namespace UnrealBuildTool.Rules
{
	public class CustomAssetEditor : ModuleRules
	{
		public CustomAssetEditor(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[] {
					"CustomAssetEditor/Public"
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					"CustomAssetEditor/Private",
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
                    "CoreUObject",
				    "Engine",
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
                    "UnrealEd",
                    "Slate",
				    "SlateCore",
					"CustomAsset",
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
		}
	}
}