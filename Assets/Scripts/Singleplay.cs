using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleplay : MonoBehaviour
{

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CampaignButton()
    {
        SceneManager.LoadScene("Campaign");
    }

    public void TrainingButton()
    {
        SceneManager.LoadScene("Training");
    }
}
