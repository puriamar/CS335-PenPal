﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    [SerializeField] Text txt_letter;
    string[] temp;
    string myfilepath, fileName;
    // Start is called before the first frame update
    void Start()
    {
        fileName = "Letter1.txt";
        myfilepath = Application.dataPath + "/" + fileName;

    }

    void DisplayLetter()
    {
        foreach (string line in temp)
        {
            txt_letter.text += line + "\n";
            //txt_letter2.text += line + "\n";
        }

    }

    public void ReadFromTheFile()
    {
        temp = File.ReadAllLines(myfilepath);
        DisplayLetter();
    }
}