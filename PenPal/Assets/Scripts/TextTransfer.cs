using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTransfer : MonoBehaviour
{
    public string text;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreLetter(){
        text = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = text;
    }

    public void clearText(){
        // textDisplay.GetComponent<Text>().text = "";
        text = "";
        text = inputField.GetComponent<Text>().text;


    }
}
