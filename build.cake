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

var workingDir = "working";
var publishDir = System.IO.Path.Combine("working","publish");

Task("Build-Rpm").Does(() => {
    CreateDirectory(workingDir);
    CopyFiles("MyWeb.spec", workingDir);
    var dir = new System.IO.DirectoryInfo(".").FullName;
    PS.StartProcess(string.Join("", new [] {
        "docker run",
        $"-v {dir}/working:/working",
    }));
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
        Runtime = "rhel-x64"
    });
});

var target = Argument("target", "Pack");
RunTarget(target);