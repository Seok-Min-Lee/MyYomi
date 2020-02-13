using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizButton : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject StartPanel;
    public GameObject QuizPanel;
    Dictionary<string, string> quiz;

    public void OnClickBack()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true); //gamepanel
        GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(false); //startpanel
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(false); //quizpanel
    }
    public void OnClickHistory()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false); //gamepanel
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true); //quizpanel

        quiz = QuizScripts.Parse(quiz, "history");
    }
    public void OnClickNonSense()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false); //gamepanel
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true); //quizpanel

        quiz = QuizScripts.Parse(quiz, "nonsense");
    }
    public void OnClickCommonSense()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false); //gamepanel
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true); //quizpanel

        quiz = QuizScripts.Parse(quiz, "commonsence");
    }
    public void OnClickAnimal()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false); //gamepanel
        GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(true); //quizpanel

        quiz = QuizScripts.Parse(quiz, "animal");
    }
    public void OnClickExit()
    {
        SceneManager.LoadScene("MainSeokMin");
    }
}
