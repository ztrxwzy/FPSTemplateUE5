// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CShooter : ModuleRules
{
	public CShooter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput",
			"HeadMountedDisplay",
			"Niagara",
			"AIModule",
			"NavigationSystem",
			"GameplayTask",
			"UMG"
		});
	}
}
