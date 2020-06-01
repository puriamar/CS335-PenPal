using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISaveLoad : MonoBehaviour
{
    [SerializeField] Text nameText;

    [SerializeField] Text bioText;

    [SerializeField] Text interestsText;

    // [SerializeField] Text tagsText;

    [SerializeField] PersonalData currentPersonalData = new PersonalData();

    
    public void SaveData()
    {
        SaveLoadPersonalData.SaveData(currentPersonalData);
        Debug.Log("Saving");
    }

    public void LoadData()
    {
        currentPersonalData = SaveLoadPersonalData.LoadData();
        Debug.Log("Loading");

        nameText.text = currentPersonalData.userName;
        bioText.text = currentPersonalData.userBio;
        interestsText.text = currentPersonalData.userInterests;

        
    }

    public void SetUserName(string name)
    {
        currentPersonalData.userName = name;
    }

    public void SetUserBio(string bio)
    {
        currentPersonalData.userBio = bio;
    }

    public void SetUserInterests(string interests)
    {
        currentPersonalData.userInterests = interests;
    }


   

    public void Start()
    {
        LoadData();
    }
}
