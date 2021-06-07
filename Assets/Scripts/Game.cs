using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [System.Serializable]
    public class Game
    {
        public string Title;
        public string Description;
        public Sprite Icon;
        public List<Sprite> Screenshots;
    }
}
