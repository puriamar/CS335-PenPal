using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    [SerializeField] Text txt_letter, txt_letter2;
    string[] temp;
    string myfilepath, fileName;
    // Start is called before the first frame update
    void Start()
    {
        fileName = "ReceivedLetter.txt";
        myfilepath = Application.dataPath + "/Inbox/" + fileName;

    }

    void DisplayLetter()
    {
        txt_letter.text = "";
        txt_letter2.text = "";
        foreach (string line in temp)
        {
            txt_letter.text += line + "\n";
            txt_letter2.text += line + "\n";
        }

    }

    public void ReadFromTheFile()
    {
        temp = File.ReadAllLines(myfilepath);
        DisplayLetter();
    }
}
