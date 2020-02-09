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

    public void Parse(string[] quizT, string[] answerT, string cat)
    {
        TextAsset data = Resources.Load(cat, typeof(TextAsset)) as TextAsset;
        StringReader sr = new StringReader(data.text);

        // 먼저 한줄을 읽는다. 
        string source = sr.ReadLine();
        string[] quiz = new string[50];
        string[] answer = new string[50];
        string[] temp = new string[50];
        int num = 0;

        while (source != null)
        {
            temp = ArrayShuffle(source.Split(','));

            for (int i = 0; i < temp.Length; i++)
            {
                string[] temp2 = temp[i].Split(':');
                quiz[num] = temp2[0];
                answer[num] = temp2[1];
                num++;
            }

            if (temp.Length == 0)
            {
                sr.Close();
                quizT = quiz;
                answerT = answer;
                return;
            }
            source = sr.ReadLine();    // 한줄 읽는다.
        }
    }

    //배열 셔플
    public string[] ArrayShuffle(string[] temp)
    {
        int[] arrNum = new int[50];
        string[] quizArr = new string[50];

	    for (int i = 0; i < arrNum.Length; i++)
       	{
            int count = Random.Range(0, 50);
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