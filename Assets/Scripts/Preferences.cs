using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preferences : MonoBehaviour
{

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PreferencesWeaponsButton()
    {
        SceneManager.LoadScene("PreferencesWeapons");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }

    public void PreferencesClothesButton()
    {
        SceneManager.LoadScene("PreferencesClothes");
    }

    public void CharactersButton()
    {
        SceneManager.LoadScene("Characters");
    }
}
