using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public InputField userName, userBio;

    public DataManager dataManager;

    void start()
    {
        dataManager.Load();
        userName.text = dataManager.data.name;
        userBio.text = dataManager.data.bio;

    }
    public void EditName()
    {
        dataManager.data.name = text;
    }

    public void EditBio()
    {
        dataManager.data.bio = text;
    }

    public void ClickSave()
    {
        dataManager.Save();
    }
}

