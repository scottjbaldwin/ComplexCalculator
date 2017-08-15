var target = Argument("target", "Default");
var configuration = Argument("configuration", "Debug");
var buildDir = Directory("./src/ComplexCalculator/bin") + Directory(configuration);
var testPath = "./src/ComplexCalculator.Tests/bin/"+ configuration + "/*.Tests.dll";
var solutionPath = "src/ComplexCalculator/ComplexCalculator.sln";

Task("Clean")
	.Does(() =>
	{
		CleanDirectory(buildDir);
	});

Task("Restore-Nuget-Packages")
	.IsDependentOn("Clean")
	.Does(() =>
	{
		NuGetRestore(solutionPath);
	});

Task("Build")
	.IsDependentOn("Restore-Nuget-Packages")
	.Does(() =>
	{
		MSBuild(solutionPath, settings => settings.SetConfiguration(configuration));
		
	});

Task("Run-Unit-Tests")
	.IsDependentOn("Build")
	.Does(() =>
	{
		MSTest(testPath);
	});

Task("Default")
	.IsDependentOn("Run-Unit-Tests");

RunTarget(target);
