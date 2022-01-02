using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField additionMax;
    public InputField subtractionMax;
    public InputField multiplicationMax;
    public InputField divisionMax;

    void Start()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            PlayerPrefs.SetInt("Level", 1);
        }
        if (PlayerPrefs.GetInt("AdditionMax") == 0)
        {
            PlayerPrefs.SetInt("AdditionMax", 100);
        }
        if (PlayerPrefs.GetInt("SubtractionMax") == 0)
        {
            PlayerPrefs.SetInt("SubtractionMax", 100);
        }
        if (PlayerPrefs.GetInt("MultiplicationMax") == 0)
        {
            PlayerPrefs.SetInt("MultiplicationMax", 100);
        }
        if (PlayerPrefs.GetInt("DivisionMax") == 0)
        {
            PlayerPrefs.SetInt("DivisionMax", 100);
        }
    }

    public void Addition()
    {
        PlayerPrefs.SetInt("Game", 1);
        SceneManager.LoadScene("Game");
    }

    public void Subtraction()
    {
        PlayerPrefs.SetInt("Game", 2);
        SceneManager.LoadScene("Game");
    }

    public void Multiplication()
    {
        PlayerPrefs.SetInt("Game", 3);
        SceneManager.LoadScene("Game");
    }

    public void Division()
    {
        PlayerPrefs.SetInt("Game", 4);
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        additionMax.text = PlayerPrefs.GetInt("AdditionMax").ToString();
        subtractionMax.text = PlayerPrefs.GetInt("SubtractionMax").ToString();
        multiplicationMax.text = PlayerPrefs.GetInt("MultiplicationMax").ToString();
        divisionMax.text = PlayerPrefs.GetInt("DivisionMax").ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("AdditionMax", int.Parse(additionMax.text));
        PlayerPrefs.SetInt("SubtractionMax", int.Parse(subtractionMax.text));
        PlayerPrefs.SetInt("MultiplicationMax", int.Parse(multiplicationMax.text));
        PlayerPrefs.SetInt("DivisionMax", int.Parse(divisionMax.text));
    }

    public void Quit()
    {
        Application.Quit();
    }
}
