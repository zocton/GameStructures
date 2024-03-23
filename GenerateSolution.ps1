dotnet new sln --name GameStructures
Get-ChildItem -Recurse *.csproj | ForEach { dotnet sln add $_.FullName }