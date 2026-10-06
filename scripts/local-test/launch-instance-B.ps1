# 同机双实例测试：可传 -GameDir，或用 STS2_DIR 指定游戏目录。
param([string]$GameDir = $env:STS2_DIR)

$ErrorActionPreference = 'Stop'
if ([string]::IsNullOrWhiteSpace($GameDir)) {
    $GameDir = 'C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2'
}
if (!(Test-Path -LiteralPath (Join-Path $GameDir 'SlayTheSpire2.exe'))) {
    throw '找不到游戏，请传 -GameDir 或设置 STS2_DIR。'
}
$previousLog = $env:TOWERMASTER_LOG_FILE
try {
    $env:TOWERMASTER_LOG_FILE = Join-Path $PSScriptRoot 'TowerMaster-B.log'
    $gameLog = Join-Path $PSScriptRoot 'game-B.log'
    Start-Process -FilePath (Join-Path $gameDir 'SlayTheSpire2.exe') -WorkingDirectory $gameDir -ArgumentList @('--force-steam', 'off', '--clientId', '100002', '--windowed', '--log-file', ('"' + $gameLog + '"'))
} finally {
    $env:TOWERMASTER_LOG_FILE = $previousLog
}
