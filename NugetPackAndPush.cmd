@echo off
cls
notepad Helpers.nuspec
echo Edit the NuSpec file as needed then
@echo off
pause
nuget pack "Helpers.csproj" -symbols -outputDirectory "C:\Users\cverburgh\OneDrive - Comtek Advanced Structures\nuget"
pause
NugetPackAndPush