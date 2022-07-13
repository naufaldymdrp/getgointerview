var target = Argument("target", "Publish");
var configuration = Argument("configuration", "Release");
var debugConfiguration = Argument("configuration", "Debug");
var solutionFolder = "./";
var outputFolder = "./publish";

Task("Clean")
    .Does(() => {
        CleanDirectory(outputFolder);
    });

Task("Restore")
    .Does(() => {
        DotNetRestore(solutionFolder);
    });

Task("DebugBuild")
    .IsDependentOn("Restore")
    .Does(() => {
        DotNetBuild(solutionFolder, new DotNetBuildSettings {
            NoRestore = true,
            Configuration = debugConfiguration
        });
    });

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() => {
        DotNetBuild(solutionFolder, new DotNetBuildSettings {
            NoRestore = true,
            Configuration = configuration
        });
    });

Task("DebugTest")
    .IsDependentOn("DebugBuild")
    .Does(() => {
        
    });

Task("Test")
    .IsDependentOn("Build")
    .Does(() => {
        DotNetTest(solutionFolder, new DotNetTestSettings {
            NoRestore = true,
            NoBuild = true,
            Configuration = configuration
        });
    });

Task("Publish")
    .IsDependentOn("Test")
    .Does(() => {
        DotNetPublish(solutionFolder, new DotNetPublishSettings {
            NoRestore = true,
            NoBuild = true,
            Configuration = configuration,
            OutputDirectory = outputFolder
        });
    });

RunTarget(target);