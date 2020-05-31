using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//IMPORTANT MAX you need to do a better job of labeling your shite!!!

/*
 * Dictionaries don't serialize from the to and from json serilization thats built into unity
 * thats why we use a list
 * So we are going to use a list of userdata and then after we have loaded the list we are going to
 * take the userdata out and then store them into the data dictionary.
 */

//public struct SaveData
[System.Serializable]
public struct UserData
{
    public List<UserData> listData;

    public string userName_;
    public string userInterests_;
    public string userBio_;
    //The user ID is what we are saving, b/c each ID is unique. When we load the userData from the file
    //we are going to parse the userID into the dictionary as the dictionary key.
    public int userID_;
    //public GameObject prefab_;

}

[System.Serializable]
public struct DataController
{
    public List<UserData> listData;
}


public class JsonTest : MonoBehaviour
{
    //public SaveData saveData;
    Dictionary<int, UserData> dictionaryData;

    private void Start()
    {
        dictionaryData = new Dictionary<int, UserData>();

        //dictionaryData.Add(0, new UserData() { userID_ = 0, userName_ = "Naruto", userInterests_ = "", userBio_ = ""});
        //dictionaryData.Add(1, new UserData() { userID_ = 1, userName_ = "Saskue", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(2, new UserData() { userID_ = 2, userName_ = "Itachi", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(3, new UserData() { userID_ = 3, userName_ = "Minato", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(4, new UserData() { userID_ = 4, userName_ = "Lee", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(5, new UserData() { userID_ = 5, userName_ = "Brooklyn", userInterests_ = "", userBio_ = "" });
       
        SaveData();
        /*
        LoadData();
        List<int> userKeys = new List<int>(dictionaryData.Keys);
        foreach (int key in userKeys)
        {
            Debug.Log("User ID: " + dictionaryData[key].userID_ + " userName: " + dictionaryData[key].userName_ + " userInterests: " + dictionaryData[key].userInterests_ + " userBio: " + dictionaryData[key].userBio_);
        }
        */
    }

        /*
        string saveDataString = JsonUtility.ToJson(saveData);
        JsonFileUtility.WriteJsonToExternalResource("Save.json", saveDataString);
        //Debug.Log(Application.persistentDataPath);
        // saveData = JsonUtility.FromJson<SaveData>(JsonFileUtility.LoadJsonFromFile("Save.json", false));
        //saveData = JsonUtility.FromJson<SaveData>(JsonFileUtility.LoadJsonFromFile("Save.json", false));
        */
    

    public void LoadData()
    {
        DataController controlLoad = JsonUtility.FromJson<DataController>(JsonFileUtility.LoadJsonFromFile("DataController.json", false));
        
        //Here we are iterating over our data list
        foreach (UserData _data in controlLoad.listData)
        {
            //this allows us to reference  data = new Dictionary<int, UserData>();
            this.dictionaryData.Add(_data.userID_, _data);
        }

    }
    public void SaveData()
    {
        List<int> userKeys = new List<int>(dictionaryData.Keys);
        List<UserData> controlSaveList = new List<UserData>();
        foreach(int key in userKeys)
        {
            controlSaveList.Add(dictionaryData[key]);
        }
        DataController controlSave = new DataController() { listData = controlSaveList };
        string jsonString = JsonUtility.ToJson(controlSave);
        Debug.Log(jsonString);
        JsonFileUtility.WriteJsonToExternalResource("DataController.json", jsonString);
        Debug.Log("DataController.json");
    }

    
}
