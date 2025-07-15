using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISaveAndLoad : MonoBehaviour
{
    [System.Serializable]
    public class SaveData
    {
        public int playerLevel;
    }

    public TMPro.TextMeshProUGUI playerLevelText;

    int levelValue;

    void Start()
    {
        loadGame();
    }

    public void saveGame()
    {
        SaveData data = new SaveData();
        data.playerLevel = levelValue;
        string json = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Saving Game...");
    }

    public void loadGame()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (System.IO.File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            levelValue = data.playerLevel;
            UpdateLevelText();
            Debug.Log("Loading Game...");
        }
        else
        {
            Debug.Log("No save file found.");
        }
    }

    public void increaseLevel()
    {
        levelValue++;
        UpdateLevelText();
    }

    public void decreaseLevel()
    {
        levelValue--;
        UpdateLevelText();
    }

    void UpdateLevelText()
    {
        playerLevelText.text = $"PlayerLevel: {levelValue}";
    }
}
