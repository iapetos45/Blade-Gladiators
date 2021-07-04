using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void MarketButton()
    {
        SceneManager.LoadScene("Market");
    }

    public void PreferencesButton()
    {
        SceneManager.LoadScene("Preferences");
    }

    public void MultiplayButton()
    {
        SceneManager.LoadScene("Multiplay");
    }

    public void SingleplayButton()
    {
        SceneManager.LoadScene("Singleplay");
    }
}
