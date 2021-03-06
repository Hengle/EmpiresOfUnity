﻿using UnityEngine;
using System.Collections.Generic;

public class Settings : MonoBehaviour 
{
    public ControllSettings settingsData;
    public List<KeyCode> PrimaryControlls, SecondaryControlls;
    private void OnGUI()
    {
        
        Vector2 size = new Vector2(1920, 1080);

        float left = Screen.width / size.x * 350f;
        float top = Screen.height / size.y * 100f;
        float topPlus = Screen.width / size.x * 100f;
        float width = Screen.width / size.x * 400f;
        float height = Screen.width / size.x * 80f;

        if (GUI.Button(new Rect(left, top + topPlus * 2, width, height), "Save Settings"))
        {
            settingsData = ScriptableObject.CreateInstance<ControllSettings>();
            settingsData.copyLists(PrimaryControlls, SecondaryControlls);
            settingsData.SaveSettings();
        }
        if (GUI.Button(new Rect(left, top + topPlus * 3, width, height), "Homepage"))
        {
            Application.OpenURL("http://media.giphy.com/media/gU25raLP4pUu4/giphy.gif");
        }
        if (GUI.Button(new Rect(left, top + topPlus * 4, width, height), "Back"))
        {
            Application.LoadLevel("MainMenu");
        }
        
    }
}
