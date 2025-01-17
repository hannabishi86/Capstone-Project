using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace First.Dialogue
{
    public class PlayerConversant : MonoBehaviour
    {
        [SerializeField] Dialogue currentDialogue;

        public string GetText()
        {
            if (currentDialogue == null)
            {
                return "";
            }

            return currentDialogue.GetRootNode().GetText();
        }
    }
}
