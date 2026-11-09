using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Captura screenshots listos para Play Store mientras jugás en el editor.
/// Salida: PlayStore/Capturas/navecita_01.png, 02, ...
/// Captura el framebuffer del Game view, así que incluye la UI (marcador, vidas, menús).
/// </summary>
public static class PlayStoreCapture
{
    const string CounterKey = "PlayStoreCapture.Counter";

    static string Folder =>
        Path.GetFullPath(Path.Combine(Application.dataPath, "../PlayStore/Capturas"));

    [MenuItem("Navecita/Capturar screenshot %#s")]
    public static void Capture()
    {
        if (!EditorApplication.isPlaying)
        {
            EditorUtility.DisplayDialog(
                "Capturas",
                "Entrá en Play Mode antes de capturar.\n\nLas capturas del editor en modo edición no muestran el juego real.",
                "Ok");
            return;
        }

        Directory.CreateDirectory(Folder);

        int n = EditorPrefs.GetInt(CounterKey, 1);
        string file = Path.Combine(Folder, $"navecita_{n:00}.png");

        ScreenCapture.CaptureScreenshot(file);
        EditorPrefs.SetInt(CounterKey, n + 1);

        float ratio = (float)Screen.height / Screen.width;
        string aviso = Mathf.Abs(ratio - (1920f / 1080f)) > 0.01f
            ? $"  ⚠ ratio {Screen.width}x{Screen.height} no es 9:16 — Play pide 9:16 o 16:9"
            : string.Empty;

        Debug.Log($"[Captura] navecita_{n:00}.png · {Screen.width}x{Screen.height}{aviso}");
    }

    [MenuItem("Navecita/Abrir carpeta de capturas")]
    public static void OpenFolder()
    {
        Directory.CreateDirectory(Folder);
        EditorUtility.RevealInFinder(Folder);
    }

    [MenuItem("Navecita/Reiniciar numeración de capturas")]
    public static void ResetCounter()
    {
        EditorPrefs.DeleteKey(CounterKey);
        Debug.Log("[Captura] Numeración reiniciada a 01.");
    }

    [MenuItem("Navecita/Ver resolución actual del Game view")]
    public static void ReportResolution()
    {
        float ratio = (float)Screen.width / Screen.height;
        Debug.Log($"[Captura] Game view: {Screen.width}x{Screen.height} (aspecto {ratio:0.000}). " +
                  "Para Play Store necesitás 1080x1920 (9:16).");
    }
}
