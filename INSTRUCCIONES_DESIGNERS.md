# ?? INSTRUCCIONES PARA DESIGNERS - POST PULL

## ¿QUÉ PASÓ?

Adrián hizo cambios importantes en los **Forms Oficiales** para que funcionen correctamente sin conflictos. Ahora necesitas hacer pull de esos cambios.

---

## ?? PASOS A SEGUIR (MUY IMPORTANTE)

### Paso 1: Hacer Pull
```bash
git pull origin feature-InventarioDB
```

### Paso 2: Limpiar y Reconstruir
1. **Cierra Visual Studio completamente**
2. **Borra estas carpetas** en tu proyecto:
   - `bin/`
   - `obj/`
3. **Abre Visual Studio nuevamente**
4. Ve a **Build ? Rebuild Solution**

### Paso 3: Verificar que todo esté bien
Ejecuta este archivo (haz doble click):
```
verificar_pull.bat
```

Si ves ? en verde, ¡todo está bien!

---

## ?? CAMBIOS QUE HIZO ADRIÁN

| Archivo | Cambio |
|---------|--------|
| `Form1v2.cs` | Cambió `Form1Backup` ? `Form1v2` (nombre de clase) |
| `Form1v2.Designer.cs` | Cambió `Form1Backup` ? `Form1v2` (nombre de clase) |
| `Tarjeta de Ventas.cs` | Actualizó referencias `Form1Backup` ? `Form1v2` |
| `Program.cs` | Cambió el form de inicio a `Form1v2` |
| `FormsPrueba/Form1Backup.cs` | Corrigió namespace a `IlkaPoint.FormsPrueba` |

---

## ? IMPORTANTE PARA DESIGNERS

? **PUEDES SEGUIR HACIENDO:**
- Diseñar en los Forms Oficiales normalmente
- Modificar colores, estilos, controles
- Trabajar en `Tarjeta de Ventas.Designer.cs`

? **NO CAMBIES:**
- El nombre de la clase `Form1v2` (debe ser así)
- El namespace de `Form1v2` (debe ser `IlkaPoint`)
- Las referencias a `Form1v2.AzulMenu`, `Form1v2.AzulClaroTarjetas`, etc.

---

## ?? SI ALGO FALLA

**Opción 1 (Rápida):**
```bash
git checkout -- .
git pull origin feature-InventarioDB
```
Luego cierra VS, borra `bin` y `obj`, abre VS de nuevo.

**Opción 2 (Si persiste el error):**
1. Cierra Visual Studio
2. Borra las carpetas `bin` y `obj`
3. En Git Bash:
   ```bash
   git clean -fd
   git pull origin feature-InventarioDB
   ```
4. Abre VS y haz `Build > Rebuild Solution`

---

## ? COMPROBACIÓN FINAL

Después de hacer los pasos, verifica:
- [ ] El proyecto abre sin errores
- [ ] El proyecto compila (`Build > Rebuild Solution`)
- [ ] Se ejecuta correctamente
- [ ] Ves los Forms Oficiales (Form1v2) cuando la app inicia

Si todo está bien, ¡ya puedes seguir diseñando! ??

---

**¿Preguntas?** Contacta a Adrián

