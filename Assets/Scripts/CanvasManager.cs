using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Canvas overlayCanvas;
    public Button triggerButton;

    void Start()
    {
        if (triggerButton != null)
        {
            triggerButton.onClick.AddListener(EnableOverlayCanvas);
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
