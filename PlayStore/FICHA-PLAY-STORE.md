# Ficha de Play Store — Navecita

Datos para crear y completar la app en Play Console.

---

## 1. Crear app

| Campo | Valor |
|---|---|
| Nombre de la app | `Navecita` |
| Idioma predeterminado | Español (Latinoamérica) — `es-419` |
| Tipo | Juego |
| Gratis o de pago | Gratis |
| Nombre de paquete | `com.bellseboss.navecita` |

---

## 2. Ficha de Play Store (es-419)

### Nombre (máx. 30)
```
Navecita
```

### Descripción corta (máx. 80 — son 78)
```
Shooter vertical arcade. Formaciones, jefe con haz tractor y récords globales.
```

### Descripción completa (máx. 4000 — son ~1.500)
```
Navecita es un shooter vertical arcade hecho para partidas cortas: entrás, jugás tres minutos y te vas con ganas de revancha.

LA INVASIÓN BAJA EN PICADA
Las formaciones enemigas se mantienen en la grilla hasta que rompen fila y caen sobre vos. Cada oleada baja más rápido y ataca con más precisión.

UN JEFE QUE TE ROBA LA NAVE
Cuando menos lo esperás, el jefe engancha tu nave con su haz tractor y se la queda. Si lo bajás mientras la tiene, la recuperás y salís con doble disparo. Si no, volvés a un solo cañón.

CONTROLES DE UN DEDO
Arrastrás el dedo para mover la nave y el disparo es automático. Nada de botones: solo esquivar y elegir a quién bajar primero.

PUNTAJE QUE PREMIA EL RIESGO
Un enemigo quieto en la grilla paga poco. El mismo enemigo en plena picada paga el triple. La diferencia entre jugar seguro y jugar bien está en el número final.

RÉCORDS GLOBALES
Cada partida compite contra los mejores jugadores en la tabla global.

POWER-UPS
Más balas y más velocidad de movimiento: elegí cómo romper la formación.

• Partidas de 1 a 3 minutos.
• Dificultad balanceada que sube nivel a nivel.
• Un solo dedo, cero tutorial.

Navecita es un arcade vertical de naves: simple de entender, difícil de dominar.
```

### Categoría
Juegos → **Arcade**

---

## 3. Gráficos

| Elemento | Especificación |
|---|---|
| Ícono | `512×512` PNG 32-bit (con alpha) |
| Gráfico de funciones | `1024×500` PNG o JPEG, **sin alpha** |
| Capturas de teléfono | mínimo 2, máximo 8 · `1080×1920` (9:16) · mín 320px, máx 3840px |
| Capturas tablet | opcional, recomendado |
| Video promocional | YouTube, opcional |

Las capturas deben ser del juego **ya rebrandeado**. Si aparece una sola referencia a Galaga, se repite el problema original.

---

## 4. Seguridad de los datos

| Pregunta | Respuesta |
|---|---|
| ¿Recopila o comparte datos? | **Sí** |
| Tipo | Información personal → **Nombre** |
| Tipo | Actividad en la app → **Otras acciones** (puntaje) |
| Finalidad | **Funcionalidad de la app** (tabla de clasificación) |
| ¿Se comparte con terceros? | **No** |
| ¿Cifrado en tránsito? | **Sí** (HTTPS) |
| ¿Eliminación a pedido? | **Sí** — `info@bellseboss.com` |
| ¿Obligatorio? | **Opcional** (el juego funciona sin enviar el récord) |

---

## 5. Anuncios, público y clasificación

| Campo | Valor |
|---|---|
| ¿Contiene anuncios? | **No** |
| Compras dentro de la app | **No** |
| Público objetivo | **13+** (no elegir menores de 13: activa política de Familias) |
| Acceso a la app | Todas las funcionalidades disponibles (sin login) |
| Categoría IARC | Juegos · violencia de fantasía leve · sin sangre, lenguaje, drogas ni apuestas |

---

## 6. Firma y versión

| Campo | Valor |
|---|---|
| Firma | Play App Signing con keystore nueva |
| Keystore local | `E:/Bellseboss/Keystores/Navecitas/navecita.keystore` |
| Alias | `navecita` |
| versionCode | `1` |
| versionName | `0.0.1` |

---

## 7. Contacto y política

| Campo | Valor |
|---|---|
| Email | `info@bellseboss.com` |
| Sitio web | `https://luisplata.github.io/navecita/` |
| Política de privacidad | `https://luisplata.github.io/navecita/privacy-policy.html` |

Verificar que ambas URLs respondan antes de pegarlas. Al renombrar el repo, la ruta de GitHub Pages pasó de `/galaga1981/` a `/navecita/` y Pages **no redirige**.

---

## 8. Checklist antes de enviar a revisión

- [ ] Keystore nueva subida como secrets de GitHub
- [ ] AAB firmado subido a Play Console
- [ ] Ícono, gráfico de funciones y capturas del juego rebrandeado
- [ ] Descripciones sin ninguna mención a Galaga, Namco o Bandai
- [ ] Política de privacidad accesible y **coherente con la declaración de datos**
- [ ] Formulario de seguridad de datos completo
- [ ] Clasificación de contenido (IARC) completa
- [ ] MissileCommand1980 borrada de Play Console

---

## 9. Riesgos conocidos

1. **Política de privacidad desalineada.** Es un template de generador y no describe la recolección de nombre y puntaje. Puede provocar rechazo por inconsistencia con la declaración de datos.
2. **Nombres de usuario en el ranking.** Contenido generado por el usuario mostrado públicamente. La política de UGC de Play exige un mecanismo de reporte; hoy el único canal es el email de contacto.
3. **Dos backends distintos.** `Score.cs` apunta a `juegos.luisplata.co`; el resto a `juegos.peryloth.com`. Si uno cae, el juego muestra error.
