using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAreaFilter : MonoBehaviour
{
    public RectTransform rectTransform;


    private void Update()
    {
        AdaptUI();
    }


    private void AdaptUI()
    {
        Rect safeArea = Screen.safeArea;
        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = anchorMin + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
    }
}
