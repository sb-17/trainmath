using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Text example;
    public Text level;
    public InputField answer;

    int currentAnswer;

    void Start()
    {
        currentAnswer = 0;

        level.text = "Level " + PlayerPrefs.GetInt("Level").ToString();

        if (PlayerPrefs.GetInt("Game") == 1)
        {
            int max = PlayerPrefs.GetInt("AdditionMax");

            int num1 = Random.Range(1, max);
            int num2 = Random.Range(1, max);

            example.text = num1.ToString() + " + " + num2.ToString();

            currentAnswer = num1 + num2;
        }
        else if (PlayerPrefs.GetInt("Game") == 2)
        {
            int max = PlayerPrefs.GetInt("SubtractionMax");

            int num1 = Random.Range(3, max);
            int num2 = Random.Range(1, num1);

            example.text = num1.ToString() + " - " + num2.ToString();

            currentAnswer = num1 - num2;
        }
        else if (PlayerPrefs.GetInt("Game") == 3)
        {
            int max = PlayerPrefs.GetInt("MultiplicationMax");

            int num1 = Random.Range(1, max);
            int num2 = Random.Range(1, max);

            example.text = num1.ToString() + " x " + num2.ToString();

            currentAnswer = num1 * num2;

        }
        else if (PlayerPrefs.GetInt("Game") == 4)
        {
            int max = PlayerPrefs.GetInt("DivisionMax");

            int num1 = Random.Range(1, max);
            int num2 = Random.Range(1, max);
            int num3 = num1 * num2;

            example.text = num3.ToString() + " / " + num1.ToString();

            currentAnswer = num2;
        }
    }

    public void CheckAnswer()
    {
        if (int.Parse(answer.text) == currentAnswer)
        {
            answer.text = "";
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
            SceneManager.LoadScene("Game");
        }
        else
        {
            answer.text = "";
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }
}
