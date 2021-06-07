using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class GameDescription : MonoBehaviour
    {
        public Image Icon;
        public TextMeshProUGUI Title;
        public ScrollRect ScreenshotHolder;
        public TextMeshProUGUI Description;
        public Canvas DescriptionCanvas;
        public Image ScrenshotPrefab;
        public Game gameRef;

        public void ShowGameInfo()
        {
            ClearAllData();
            Icon.sprite = gameRef.Icon;
            Title.text = gameRef.Title;
            Description.text = gameRef.Description;
            DescriptionCanvas.gameObject.SetActive(true);
        }


        public void ClearAllData()
        {
        }
    }
}
