using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI
{
    public class UIMenuController : MonoBehaviour
    {
        public Animator ContentPanel;

        private readonly int _hashOpenTrigger = Animator.StringToHash("IsHidden");

        public void ToggleMenu()
        {
            ContentPanel.enabled = true;

            bool isHidden = ContentPanel.GetBool("IsHidden");
            ContentPanel.SetBool(_hashOpenTrigger, !isHidden);
        }


    }
}
