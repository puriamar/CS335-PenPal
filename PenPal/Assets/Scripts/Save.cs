using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public string textName;
    public InputField inputField_Name;


    public string textBio;
    public InputField inputField_Bio;


    public string textInterests;
    public InputField inputField_Interests;

    private void Start()
    {
        textName = PlayerPrefs.GetString("textNameKey", textName);
        inputField_Name.text = textName;

        textBio = PlayerPrefs.GetString("textBioKey", textBio);
        inputField_Bio.text = textName;

        textInterests = PlayerPrefs.GetString("textInterestsKey", textInterests);
        inputField_Interests.text = textInterests;
    }

    public void SaveData()
    {
        textName = inputField_Name.text;
        PlayerPrefs.SetString("textNameKey", textName);

        textBio = inputField_Bio.text;
        PlayerPrefs.SetString("textBioKey", textBio);

        textInterests = inputField_Interests.text;
        PlayerPrefs.SetString("textInterestsKey", textInterests);
    }
    public void NextPanel()
    {

    }
    
}
