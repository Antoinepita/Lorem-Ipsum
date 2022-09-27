using System.Collections;
using System.Collections.Generic;
using UnityEditor;using UnityEditor.SearchService;
using UnityEngine;


public class SceneManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Settings;
    
    public void MenuToSettings()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }
    
    public void SettingsToMenu()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }
}
