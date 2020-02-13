using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class QuizScripts : MonoBehaviour
{
    string m_strPath = "Assets/Resources/";

    public void WriteData(string strData)
    {
        FileStream f = new FileStream(m_strPath + "Data.txt", FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);
        writer.WriteLine(strData);
        writer.Close();
    }

    static public Dictionary<string, string> Parse(Dictionary<string, string> quiz, string cat)
    {
        TextAsset data = Resources.Load(cat, typeof(TextAsset)) as TextAsset;
        string wholeString = data.text + "";
        int num = 0;

        string[] set = wholeString.Split(',');
        set = ArrayShuffle(set);

        //Debug.Log(wholeString);

        for (int i = 0; i < set.Length; i++)
        {
            string[] temp2 = set[i].Split(':');
            quiz.Add(temp2[0], temp2[1]);
            num++;
        }

        return quiz;
    }

    //배열 셔플
    static public string[] ArrayShuffle(string[] temp)
    {
        int[] arrNum = new int[temp.Length];
        string[] quizArr = new string[temp.Length];

	    for (int i = 0; i < arrNum.Length; i++)
       	{
            int count = Random.Range(0, temp.Length);
            arrNum[i] = count;

            for (int j = 0; j < i; j++)
           	{
             	if (count == arrNum[j])
              	{
                    i--;
                    break;
                }
            }
        }

        for(int k = 0; k < quizArr.Length; k++)
        {
            quizArr[k] = temp[arrNum[k]];
        }
        return quizArr;
    }
}