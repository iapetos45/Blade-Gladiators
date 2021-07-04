using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Market : MonoBehaviour
{

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void MarketWeaponsButton()
    {
        SceneManager.LoadScene("MarketWeapons");
    }

    public void MarketClothesButton()
    {
        SceneManager.LoadScene("MarketClothes");
    }
}
