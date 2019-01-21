#addin "wk.StartProcess"
#addin "wk.ProjectParser"
#r "nuget:wk.StartProcess"

using PS = StartProcess.Processor;
using ProjectParser;
using PS = StartProcess.Processor;

var nugetToken = EnvironmentVariable("npi");
var name = "MyWeb";

var currentDir = new DirectoryInfo(".").FullName;
var info = Parser.Parse($"src/{name}/{name}.csproj");

var workingDir = ".working";
var publishDir = System.IO.Path.Combine(workingDir,"publish");

Task("Prepare").Does(() => {
    CreateDirectory(workingDir);
    CopyFiles("rpm/*", workingDir);
    CopyDirectory("rpm/root", workingDir);
});

Task("Pack").Does(() => {
    CleanDirectory(publishDir);
    DotNetCorePack($"src/{name}", new DotNetCorePackSettings {
        OutputDirectory = publishDir
    });
});

Task("Publish-Redhat").Does(() => {
    CleanDirectory(publishDir);
    DotNetCorePublish($"src/{name}", new DotNetCorePublishSettings {
        OutputDirectory = publishDir,
        // Runtime = "rhel-x64"
    });
});

var target = Argument("target", "Pack");
RunTarget(target);