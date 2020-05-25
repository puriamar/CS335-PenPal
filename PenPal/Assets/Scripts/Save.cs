using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
   
    public InputField inputField_Name;
    public InputField inputField_Bio;
    public InputField inputField_Interests;

    public void Name()
    {
        PlayerPrefs.SetString("textNameKey", inputField_Name.text);
    }

    public void Bio()
    {
        PlayerPrefs.SetString("textBioKey", inputField_Bio.text);
    }

    public void interests()
    {
        PlayerPrefs.SetString("textInterestsKey", inputField_Interests.text);
    }


    private void Start()
    {
        if (PlayerPrefs.HasKey("textNameKey"))
        {
            inputField_Name.text = PlayerPrefs.GetString("textNameKey");
        }

        if (PlayerPrefs.HasKey("textBioKey"))
        {
            inputField_Bio.text = PlayerPrefs.GetString("textBioKey");
        }
        if (PlayerPrefs.HasKey("textInterestsKey"))
        {
            inputField_Interests.text = PlayerPrefs.GetString("textInterestsKey");
        }
    }
}


       
     

