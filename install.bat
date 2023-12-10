dotnet new sln -n CircleApp

dotnet new classlib -o CircleHesaplama
dotnet new webapi -o CircleApi

dotnet sln CircleApp.sln add CircleHesaplama
dotnet sln CircleApp.sln add CircleApi

dotnet add CircleApi reference CircleHesaplama

code .