using System.Collections;
using System.Collections.Generic;
using UnityEditor;using UnityEditor.SearchService;
using UnityEngine;


public class ManageScenes : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Settings;
    public GameObject Play;
    
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
    
    public void MenuToPlay()
    {
        Play.SetActive(true);
        Menu.SetActive(false);
    }
    
    public void PlayToMenu()
    {
        Menu.SetActive(true);
        Play.SetActive(false);
    }
}
