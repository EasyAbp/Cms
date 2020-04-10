# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of projects
$projects = (

    "src/EasyAbp.Cms.Application",
    "src/EasyAbp.Cms.Application.Contracts",
    "src/EasyAbp.Cms.Domain",
    "src/EasyAbp.Cms.Domain.Shared",
    "src/EasyAbp.Cms.EntityFrameworkCore",
    "src/EasyAbp.Cms.HttpApi",
    "src/EasyAbp.Cms.HttpApi.Client",
    "src/EasyAbp.Cms.MongoDB",
    "src/EasyAbp.Cms.Web"
)