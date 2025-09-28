using UnityEngine;

public class PanelFader : MonoBehaviour
{
    public CanvasGroup group;

    void Awake() { if (!group) group = GetComponent<CanvasGroup>(); }

    // call this from a Button to hide instantly
    public void HideInstant()
    {
        group.alpha = 0f;
        group.interactable = false;   // stops receiving clicks
        group.blocksRaycasts = false; // lets clicks pass through
    }

    // optional: show it again instantly
    public void ShowInstant()
    {
        group.alpha = 1f;
        group.interactable = true;
        group.blocksRaycasts = true;
    }
}
