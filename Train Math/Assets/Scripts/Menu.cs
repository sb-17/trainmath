using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Menu : MonoBehaviour
{
    public string gameId = "3936473";
    public string placementId = "Android_Banner";
    public bool testMode = false;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());

        if (PlayerPrefs.GetInt("Level") == 0)
        {
            PlayerPrefs.SetInt("Level", 1);
        }
    }

    public void Addition()
    {
        Advertisement.Banner.Hide();

        PlayerPrefs.SetInt("Game", 1);
        SceneManager.LoadScene("Game");
    }

    public void Subtraction()
    {
        Advertisement.Banner.Hide();

        PlayerPrefs.SetInt("Game", 2);
        SceneManager.LoadScene("Game");
    }

    public void Multiplication()
    {
        Advertisement.Banner.Hide();

        PlayerPrefs.SetInt("Game", 3);
        SceneManager.LoadScene("Game");
    }

    public void Division()
    {
        Advertisement.Banner.Hide();

        PlayerPrefs.SetInt("Game", 4);
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(placementId);
    }
}
