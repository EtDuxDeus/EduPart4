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
                Image gameImage = game.GetComponent<Image>();
                gameImage.sprite = i.screenshots[0];
                TextMeshProUGUI gameTitle = game.GetComponentInChildren<TextMeshProUGUI>();
                gameTitle.text = i.title;
            }
        }


        private void ChangeSizeOfContentHolder()
        {
            _contentHolder.sizeDelta = new Vector2(750 * transform.childCount, _contentHolder.rect.height);
        }
    }
}
