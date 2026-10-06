param(
    [string]$AssemblyPath = 'C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\data_sts2_windows_x86_64\sts2.dll',
    [string]$OutputDir = (Join-Path $PSScriptRoot '..\docs\game-api\signatures'),
    [string]$Dotnet = 'dotnet',
    [string]$DecompiledRoot = (Join-Path $PSScriptRoot '..\decompiled\sts2'),
    [string]$GameVersion = 'v0.111.0'
)
$ErrorActionPreference = 'Stop'
if (!(Test-Path -LiteralPath $AssemblyPath)) { throw "找不到程序集：$AssemblyPath" }
# MetadataLoadContext 只读元数据，不执行游戏代码；要求 .NET 9 SDK。
# 当前版本状态牌类型由构造参数而非 Type 覆写定义；只读本机反编译文件识别名字。
$statusNames = @(Get-ChildItem -LiteralPath (Join-Path $DecompiledRoot 'MegaCrit.Sts2.Core.Models.Cards') -Filter '*.cs' |
    Where-Object { (Get-Content -LiteralPath $_.FullName -Raw) -match ':\s*base\([^;{}]*CardType\.Status' } |
    ForEach-Object { $_.BaseName }) -join ','
& $Dotnet run --project (Join-Path $PSScriptRoot 'api-dump\ApiDump.csproj') -- $AssemblyPath $OutputDir $statusNames $GameVersion
if ($LASTEXITCODE -ne 0) { throw "API 导出失败：$LASTEXITCODE" }
