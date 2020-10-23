SET MSBUILD="c:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\msbuild.exe"
SET PROJECT="Application.Web\Application.Web.csproj"

%MSBUILD% %PROJECT% /t:"Package" /p:nowarn=1591 /p:Configuration="Release" /m:1 /p:UseSharedCompilation=false /p:TreatWarningsAsErrors=true /warnaserror /p:langversion=latest