@echo off
REM Script para verificar que el Pull fue exitoso
REM Ejecutar en PowerShell o CMD después de hacer git pull

echo.
echo ====================================================
echo  VERIFICACION POST-PULL - IlkaPoint
echo ====================================================
echo.

REM Verificar que el proyecto compile
echo [1/4] Limpiando carpetas de compilacion...
if exist bin rd /s /q bin
if exist obj rd /s /q obj
echo      ? Carpetas limpias

echo.
echo [2/4] Buscando archivos criticos...

REM Buscar que Form1v2 exista correctamente
if exist "Forms Oficiales\Form1v2.cs" (
    echo      ? Form1v2.cs encontrado
) else (
    echo      ? ERRO: Form1v2.cs NO encontrado
    exit /b 1
)

REM Buscar FormsPrueba\Form1Backup.cs
if exist "FormsPrueba\Form1Backup.cs" (
    echo      ? FormsPrueba\Form1Backup.cs encontrado
) else (
    echo      ? ERROR: FormsPrueba\Form1Backup.cs NO encontrado
    exit /b 1
)

echo.
echo [3/4] Verificando contenido de archivos...

REM Verificar que Form1v2.cs tiene el namespace correcto
findstr /M "public partial class Form1v2" "Forms Oficiales\Form1v2.cs" >nul
if %errorlevel% equ 0 (
    echo      ? Form1v2.cs tiene el nombre correcto
) else (
    echo      ? ERROR: Form1v2.cs contiene "Form1Backup" en lugar de "Form1v2"
    exit /b 1
)

REM Verificar que FormsPrueba\Form1Backup tiene el namespace correcto
findstr /M "namespace IlkaPoint.FormsPrueba" "FormsPrueba\Form1Backup.cs" >nul
if %errorlevel% equ 0 (
    echo      ? FormsPrueba\Form1Backup.cs tiene namespace correcto
) else (
    echo      ? ERROR: FormsPrueba\Form1Backup.cs no tiene namespace IlkaPoint.FormsPrueba
    exit /b 1
)

echo.
echo [4/4] Intentando compilar el proyecto...
echo.

REM Intentar compilar
dotnet build IlkaPoint.csproj >nul 2>&1

if %errorlevel% equ 0 (
    echo      ? COMPILACION EXITOSA!
    echo.
    echo ====================================================
    echo  ? TODO ESTA BIEN - El Pull fue exitoso!
    echo ====================================================
    echo.
) else (
    echo      ? ERROR en la compilacion
    echo.
    echo      Por favor:
    echo      1. Cierra Visual Studio
    echo      2. Borra las carpetas 'bin' y 'obj'
    echo      3. Abre el proyecto nuevamente
    echo      4. Intenta Build > Rebuild Solution
    echo.
    exit /b 1
)

pause
