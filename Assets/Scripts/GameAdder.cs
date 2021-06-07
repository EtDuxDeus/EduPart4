using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UI
{
    public class GameAdder : MonoBehaviour
    {
        [SerializeField]
        private GamesHolder _gameData;
        [SerializeField]
        private GameObject _gamePrefab;
        private RectTransform _contentHolder;
        [SerializeField]
        private Image _descriptiptionIcon;
        [SerializeField]
        private TextMeshProUGUI _descriptionTitle;
        [SerializeField]
        private ScrollRect _desctriptionScreenshotHolder;
        [SerializeField]
        private TextMeshProUGUI _descriptionText;
        [SerializeField]
        private Canvas _descriptionCanvas;


        void Start()
        {
            _contentHolder = GetComponent<RectTransform>();
            AddGamesToMenu();
            ChangeSizeOfContentHolder();
        }


        private void AddGamesToMenu()
        {
            foreach (var i in _gameData.GameList)
            {
                GameObject game = Instantiate(_gamePrefab, transform);
                GameDescription description = game.GetComponent<GameDescription>();
                description.Description = _descriptionText;
                description.Title = _descriptionTitle;
                description.Icon = _descriptiptionIcon;
                description.ScreenshotHolder = _desctriptionScreenshotHolder;
                description.gameRef = i;
                description.DescriptionCanvas = _descriptionCanvas;
                Image gameImage = game.GetComponent<Image>();
                gameImage.sprite = i.Screenshots[0];
                TextMeshProUGUI gameTitle = game.GetComponentInChildren<TextMeshProUGUI>();
                gameTitle.text = i.Title;
            }
        }


        private void ChangeSizeOfContentHolder()
        {
            _contentHolder.sizeDelta = new Vector2(750 * transform.childCount, _contentHolder.rect.height);
        }
    }
}
