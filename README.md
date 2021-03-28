# Gravatar

| Package |  Version | Downloads |
| ------- | ----- | ----- |
| `Gravatar` | [![NuGet](https://img.shields.io/nuget/v/Gravatar-t5.svg)](https://nuget.org/packages/Gravatar-t5) | [![Nuget](https://img.shields.io/nuget/dt/Gravatar-t5.svg)](https://nuget.org/packages/Gravatar-t5) |


````powershell

PS D:\Proj\Gravatar> dotnet new Gravatar
PS D:\Proj\Gravatar> dotnet new classlib -o Gravatar
PS D:\Proj\Gravatar> dotnet new mstest -o Gravatar.Test
PS D:\Proj\Gravatar> dotnet new sln
PS D:\Proj\Gravatar> dotnet sln add .\Gravatar\
PS D:\Proj\Gravatar> dotnet sln add .\Gravatar.Test\    
PS D:\Proj\Gravatar> dotnet new gitignore
PS D:\Proj\Gravatar> code .
PS D:\Proj\Gravatar> dotnet build
* create tests
PS D:\Proj\Gravatar> dotnet test
PS D:\Proj\Gravatar\Gravatar.Tests> dotnet add reference ..\Gravatar\
PS D:\Proj\Gravatar> dotnet build
PS D:\Proj\Gravatar> dotnet build --configuration Release 
PS D:\Proj\Gravatar> dotnet pack --configuration Release
* add on git
PS D:\Proj\Gravatar> git init
PS D:\Proj\Gravatar> git add --all 
PS D:\Proj\Gravatar> git commit -m 'init commit'
PS D:\Proj\Gravatar> git branch -M main
PS D:\Proj\Gravatar> git remote add origin https://github.com/felipementel/Gravatar
PS D:\Proj\Gravatar> git push -u origin main
*
fatal: refusing to merge unrelated histories
PS D:\Proj\Gravatar> git pull origin main --allow-unrelated-histories
# o seu repositório local já possuí um histórico de commits (branchs são commits, ok?), diferente do que está no repositório remoto.
*
PS D:\Proj\Gravatar> dotnet nuget push "./Gravatar/bin/Release/*.nupkg" -k ${{ secret.NUGET_TOKEN }} -s https://api.nuget.org/v3/index.json

````