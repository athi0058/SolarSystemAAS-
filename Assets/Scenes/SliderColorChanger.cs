using UnityEngine;
using UnityEngine.UI;

public class SliderColorChanger : MonoBehaviour
{
    public Slider colorSlider;
    public Image panelImage;

    void Start()
    {
        if (colorSlider == null || panelImage == null)
        {
            Debug.LogError("Slider or Panel Image not assigned!");
            return;
        }

        colorSlider.onValueChanged.RemoveAllListeners();
        colorSlider.onValueChanged.AddListener(ChangePanelColor);
    }

    public void ChangePanelColor(float value)
    {
        if (panelImage != null)
        {
            panelImage.color = Color.Lerp(Color.red, Color.blue, value);
        }
    }
}
