using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Canvas overlayCanvas;
    public Button Backpack;

    void Start()
    {
        if (Backpack != null)
        {
            Backpack.onClick.AddListener(EnableOverlayCanvas);
        }
        else
        {
            Debug.LogError("Trigger button not assigned!");
        }
    }

    void EnableOverlayCanvas()
    {
        if (overlayCanvas != null)
        {
            overlayCanvas.enabled = true;
        }
        else
        {
            Debug.LogError("Overlay canvas not assigned!");
        }
    }
}
