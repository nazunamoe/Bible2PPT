<#
.SYNOPSIS
    성경2PPT 릴리스 빌드를 만들고 zip으로 묶습니다.

.DESCRIPTION
    .github/workflows/deploy.yml과 같은 옵션으로 런타임별 단일 exe를 publish한 뒤
    publish\Bible2PPT-<버전>-<런타임>.zip 으로 압축합니다.
    PowerPoint COM 참조 때문에 dotnet build 대신 Visual Studio(Build Tools)의 MSBuild를 사용합니다.

.EXAMPLE
    .\build-release.ps1 -Version 2.1.0

.EXAMPLE
    .\build-release.ps1 -Version 2.1.0 -Runtimes win-x64
#>
param(
    [Parameter(Mandatory = $true)]
    [ValidatePattern('^\d+\.\d+\.\d+(-[0-9A-Za-z.-]+)?$')]
    [string]$Version,

    [ValidateSet('win-x86', 'win-x64')]
    [string[]]$Runtimes = @('win-x86', 'win-x64'),

    [string]$OutputDir = (Join-Path $PSScriptRoot 'publish')
)

$ErrorActionPreference = 'Stop'

$root = $PSScriptRoot
$project = Join-Path $root 'Bible2PPT'
$publishRoot = [System.IO.Path]::GetFullPath($OutputDir)

# MSBuild 찾기
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
if (-not (Test-Path $vswhere)) {
    throw 'Visual Studio(Build Tools)가 설치되어 있지 않습니다.'
}
$msbuild = & $vswhere -products * -latest -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
if (-not $msbuild) {
    throw 'MSBuild.exe를 찾을 수 없습니다.'
}
Write-Host "MSBuild: $msbuild"

New-Item -ItemType Directory -Force $publishRoot | Out-Null

foreach ($runtime in $Runtimes) {
    Write-Host ''
    Write-Host "=== $runtime 빌드 (v$Version) ===" -ForegroundColor Cyan

    $publishDir = Join-Path $publishRoot $runtime
    if (Test-Path $publishDir) {
        Remove-Item -Recurse -Force $publishDir
    }

    & $msbuild $root -t:Restore "-p:RuntimeIdentifier=$runtime" -v:minimal -nologo
    if ($LASTEXITCODE -ne 0) { throw "$runtime 패키지 복원에 실패했습니다." }

    & $msbuild $project -p:Configuration=Release -t:publish `
        "-p:Version=$Version" "-p:PublishDir=$publishDir\" -p:ErrorOnDuplicatePublishOutputFiles=false `
        "-p:RuntimeIdentifier=$runtime" -p:PublishSingleFile=true -v:minimal -nologo
    if ($LASTEXITCODE -ne 0) { throw "$runtime 빌드에 실패했습니다." }

    $zip = Join-Path $publishRoot "Bible2PPT-$Version-$runtime.zip"
    Compress-Archive -Path (Join-Path $publishDir '*') -DestinationPath $zip -Force
    Write-Host "완료: $zip" -ForegroundColor Green
}
