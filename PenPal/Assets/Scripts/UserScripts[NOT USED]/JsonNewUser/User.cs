using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class User
{
    /*
    public string userName;
    public string userBio;
    public string userInterests;
    public int userID;

    */

    public GameObject userName;
    public GameObject userBio;
    public GameObject userInterests;
    //public GameObject prefab;

    public int userID;

    //[SerializeField] public string UserName, UserBio, UserInterests;
    public string UserName;
    public string UserBio;
    public string UserInterests;
    //private int UserID;


    public void Update()
    {
        UserName = userName.GetComponent<InputField>().text;
        UserBio = userBio.GetComponent<InputField>().text;
        UserInterests = userInterests.GetComponent<InputField>().text;

    }
}

 

