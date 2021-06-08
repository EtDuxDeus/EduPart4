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
        public Image ScreenshotPrefab;
        public Game gameRef;


        public void ShowGameInfo()
        {
            ClearAllData();
            FillFieldsOfDescription();
            AddGameScreenshots();
            ChangeSizeOfScreenshotHolder();
        }


        private void FillFieldsOfDescription()
        {
            Icon.sprite = gameRef.Icon;
            Title.text = gameRef.Title;
            Description.text = gameRef.Description;
            DescriptionCanvas.gameObject.SetActive(true);
        }


        private void AddGameScreenshots()
        {
            foreach (var i in gameRef.Screenshots)
            {
                Image screenshot = Instantiate(ScreenshotPrefab, ScreenshotHolder.content.transform);
                screenshot.sprite = i;
            }
        }


        private void ChangeSizeOfScreenshotHolder()
        {
            ScreenshotHolder.content.sizeDelta = new Vector2(750 * gameRef.Screenshots.Count, ScreenshotHolder.content.rect.height);
        }


        private void ClearAllData()
        {
            for (int i = 0; i < ScreenshotHolder.content.childCount; i++)
            {
                Destroy(ScreenshotHolder.content.GetChild(i).gameObject, 0f);
            }
        }
    }
}
