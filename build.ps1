<#
.SYNOPSIS

Builds and runs tests for the Complex Calculator project
#>
if (-not (Get-Command MsBuild -ErrorAction SilentlyContinue))
{
	Get-VsVars32
}

MSBuild .\src\ComplexCalculator\ComplexCalculator.sln

if ($LASTEXITCODE -eq 0)
{
	.\src\ComplexCalculator\packages\xunit.runner.console.2.3.0-beta3-build3705\tools\net452\xunit.console.exe .\src\ComplexCalculator.Tests\bin\Debug\ComplexCalculator.Tests.dll
}

exit $LASTEXITCODE
