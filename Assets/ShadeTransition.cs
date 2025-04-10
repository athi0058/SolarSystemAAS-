using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShadeTransition : MonoBehaviour
{
    public Image panelImage;
    public Color targetColor = Color.blue; // Final color
    public float transitionTime = 2f; // Time for transition

    void Start()
    {
        StartCoroutine(ShadeIn());
    }

    IEnumerator ShadeIn()
    {
        Color startColor = panelImage.color;
        float elapsedTime = 0f;

        while (elapsedTime < transitionTime)
        {
            elapsedTime += Time.deltaTime;
            panelImage.color = Color.Lerp(startColor, targetColor, elapsedTime / transitionTime);
            yield return null;
        }

        panelImage.color = targetColor;
    }
}
