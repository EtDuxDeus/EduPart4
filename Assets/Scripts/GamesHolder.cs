using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [CreateAssetMenu(fileName = "GameList", menuName = "Create Game List")]
    public class GamesHolder : ScriptableObject
    {
        public List<Game> GameList;
    }
}