using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizButton : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject StartPanel;
    public Button Self;

    public QuizScripts Qs;

    public void OnClick()
    {
        GamePanel.SetActive(false);
        string[] quiz = new string[50];
        string[] answer = new string[50];

        switch (Self.GetComponentsInChildren<Text>()[0].text)
        {
            case "X":
                StartPanel.SetActive(true);
                break;
            case "역사":
                Qs.Parse(quiz, answer, "history");

                break;
            case "넌센스":
                Qs.Parse(quiz, answer, "nonsense");

                break;
            case "상식":
                Qs.Parse(quiz, answer, "commonsense");

                break;
            case "동물":
                Qs.Parse(quiz, answer, "animal");

                break;
        }
    }
    public void OnClickExit()
    {
        SceneManager.LoadScene("MainSeokMin");
    }
}
