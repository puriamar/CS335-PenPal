using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Controller : MonoBehaviour
{ 
    public void SaveData()
    {
        List<string> text = new List<string>();
        foreach (InputField inputField in FindObjectsOfType<InputField>())
            text.Add(inputField.text);

        UserControl data = new UserControl(text);

        SaveManager.Save(data);
    }
    public void Load()
    {
   
        UserControl data = SaveManager.Load();

        
       Text[] txt = FindObjectsOfType<Text>();
        //Text[] reverseTxt = new Text[txt.Length];
        for (var i = 0; i < txt.Length; i++)
            txt[i].text = data.txtInput[i];

        // reverseTxt[txt.Length - 1 - i].text = data.txtInput[i];
        // txt[i].text = data.txtInput[i];

    }
}




