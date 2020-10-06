#load nuget:?package=Cake.Recipe&version=2.0.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src",
                            solutionFilePath: "./Gazorator.sln",
                            title: "Gazorator",
                            repositoryOwner: "mholo65",
                            repositoryName: "gazorator",
                            appVeyorAccountName: "mholo65",
                            shouldRunDupFinder: false,
                            shouldRunInspectCode: false,
                            shouldRunDotNetCorePack: true,
                            shouldUseDeterministicBuilds: true,
                            preferredBuildAgentOperatingSystem: PlatformFamily.Windows,
                            preferredBuildProviderType: BuildProviderType.GitHubActions);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                            dupFinderExcludePattern: new string[] {
                                BuildParameters.RootDirectoryPath + "/src/Gazorator/**/*.AssemblyInfo.cs"});

Build.RunDotNetCore();
