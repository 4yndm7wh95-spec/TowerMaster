# 同机双实例测试：可传 -GameDir，或用 STS2_DIR 指定游戏目录。
# -BridgePort：TowerMaster 测试接口端口（给 testing/mcp 的测试助手用），0 表示不开。令牌用环境变量 TOWERMASTER_BRIDGE_TOKEN（可不设）。
param([string]$GameDir = $env:STS2_DIR, [int]$BridgePort = 47102)

$ErrorActionPreference = 'Stop'
if ([string]::IsNullOrWhiteSpace($GameDir)) {
    $GameDir = 'C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2'
}
if (!(Test-Path -LiteralPath (Join-Path $GameDir 'SlayTheSpire2.exe'))) {
    throw '找不到游戏，请传 -GameDir 或设置 STS2_DIR。'
}
$names = 'TOWERMASTER_LOG_FILE', 'TOWERMASTER_GAME_LOG', 'TOWERMASTER_INSTANCE', 'TOWERMASTER_BRIDGE_PORT', 'TOWERMASTER_BRIDGE_SHOTS'
$previous = @{}
foreach ($n in $names) { $previous[$n] = [Environment]::GetEnvironmentVariable($n, 'Process') }
try {
    $gameLog = Join-Path $PSScriptRoot 'game-B.log'
    $env:TOWERMASTER_LOG_FILE = Join-Path $PSScriptRoot 'TowerMaster-B.log'
    $env:TOWERMASTER_GAME_LOG = $gameLog
    $env:TOWERMASTER_INSTANCE = 'B'
    $env:TOWERMASTER_BRIDGE_SHOTS = Join-Path $PSScriptRoot 'screenshots-B'
    if ($BridgePort -gt 0) { $env:TOWERMASTER_BRIDGE_PORT = "$BridgePort" } else { $env:TOWERMASTER_BRIDGE_PORT = $null }
    Start-Process -FilePath (Join-Path $GameDir 'SlayTheSpire2.exe') -WorkingDirectory $GameDir -ArgumentList @('--force-steam', 'off', '--clientId', '100002', '--windowed', '--log-file', ('"' + $gameLog + '"'))
} finally {
    foreach ($n in $names) { [Environment]::SetEnvironmentVariable($n, $previous[$n], 'Process') }
}
