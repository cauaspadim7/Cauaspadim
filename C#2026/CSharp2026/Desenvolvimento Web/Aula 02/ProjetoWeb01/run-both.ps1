<#
Script PowerShell para iniciar a API (ProjetoWeb01) e o app desktop (AplicativoDesktop01)
Execute a partir da raiz do workspace (ou dê duplo-clique no arquivo).

Funcionalidades adicionadas:
- atraso configurável antes de iniciar o app desktop
- abrir o navegador na URL da API automaticamente
#>

param(
    [int]$DelayBeforeDesktop = 6,            # segundos a aguardar após iniciar a API
    [string]$ApiUrl = 'http://localhost:5000' # URL para abrir no navegador (ajuste se necessário)
)

Write-Host "Iniciando API (ProjetoWeb01)..." -ForegroundColor Cyan
Start-Process powershell -ArgumentList '-NoExit','-Command','dotnet run --project ".\ProjetoWeb01\ProjetoWeb01.csproj"'

# Pequena espera para permitir que o processo dotnet comece
Start-Sleep -Seconds 2

Write-Host "Abrindo o navegador em: $ApiUrl" -ForegroundColor Cyan
try {
    Start-Process $ApiUrl
} catch {
    Write-Warning "Não foi possível abrir o navegador automaticamente: $_"
}

Write-Host "Aguardando $DelayBeforeDesktop segundos antes de iniciar o app desktop..." -ForegroundColor Cyan
Start-Sleep -Seconds $DelayBeforeDesktop

Write-Host "Iniciando Aplicativo Desktop (AplicativoDesktop01)..." -ForegroundColor Cyan
Start-Process powershell -ArgumentList '-NoExit','-Command','dotnet run --project ".\AplicativoDesktop01\AplicativoDesktop01.csproj"'

Write-Host "Comandos iniciados: API e Aplicativo Desktop. Verifique as janelas PowerShell abertas." -ForegroundColor Green
