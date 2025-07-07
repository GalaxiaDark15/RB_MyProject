using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPlayerPrefs : MonoBehaviour
{
    public TMP_InputField inputField;
    
    public TMPro.TextMeshProUGUI textComp;

    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerInput"))
        {
            inputField.text = PlayerPrefs.GetString("PlayerInput");
        }
    }

    public void OnValueChanged()
    {
        Debug.Log("Text Value Changed: " + inputField.text);
    }

    public void OnSubmitClicked()
    {
        string value = inputField.text;
        PlayerPrefs.SetString("PlayerInput", value);
        PlayerPrefs.Save();
        Debug.Log("Submitted! Saved value: " + value);
        textComp.text = value;
        inputField.text = "";
    }

    public void OnDeleteClicked()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Debug.Log("Deleted all Player Prefs");
        textComp.text = "";
        inputField.text = "";
    }
}
