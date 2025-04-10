using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image image;
    public Color hoverColor = Color.green;
    private Color originalColor;

    void Start()
    {
        originalColor = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = hoverColor; // Change color on hover
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = originalColor; // Restore original color
    }
}
