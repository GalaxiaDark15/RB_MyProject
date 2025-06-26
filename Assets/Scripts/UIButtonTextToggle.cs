using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonTextToggle : MonoBehaviour
{
    
    [SerializeField] private TMPro.TextMeshProUGUI _textComp;

    public void OnButtonClicked()
    {
        Debug.Log(message: "Button Clicked!");

        _textComp.text = _textComp.text == "Hello" ? "Goodbye" : "Hello";
    }
}
