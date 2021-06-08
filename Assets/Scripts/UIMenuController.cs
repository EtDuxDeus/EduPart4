using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI
{
    public class UIMenuController : MonoBehaviour
    {
        public Animator ContentPanel;


        public void ToggleMenu()
        {
            ContentPanel.enabled = true;

            bool isHidden = ContentPanel.GetBool("IsHidden");
            ContentPanel.SetBool("IsHidden", !isHidden);
        }


    }
}
