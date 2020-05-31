using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct SaveInfo
{
    public string userName_;
    public string userInterests_;
    public string userBio_;
    public int userID_;
}

public class NewJsonTest : MonoBehaviour
{
    public SaveInfo saveInfo;

    private void Start()
    {
        string saveInfoString = JsonUtility.ToJson(saveInfo);
        JsonFileUtility.WriteJsonToExternalResource("Save.json", saveInfoString);
        Debug.Log(Application.persistentDataPath);
        saveInfo = JsonUtility.FromJson<SaveInfo>(JsonFileUtility.LoadJsonFromFile("Save.json", false));
        saveInfo = JsonUtility.FromJson<SaveInfo>(JsonFileUtility.LoadJsonFromFile("Save.json", false));
    }
}
        //dictionaryData.Add(0, new UserData() { userID_ = 0, userName_ = "Naruto", userInterests_ = "", userBio_ = ""});
        //dictionaryData.Add(1, new UserData() { userID_ = 1, userName_ = "Saskue", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(2, new UserData() { userID_ = 2, userName_ = "Itachi", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(3, new UserData() { userID_ = 3, userName_ = "Minato", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(4, new UserData() { userID_ = 4, userName_ = "Lee", userInterests_ = "", userBio_ = "" });
        // dictionaryData.Add(5, new UserData() { userID_ = 5, userName_ = "Brooklyn", userInterests_ = "", userBio_ = "" });
        /*
            //SaveData();
            LoadData();
            List<int> userKeys = new List<int>(dictionaryData.Keys);
            foreach (int key in userKeys)
            {
                Debug.Log("User ID: " + dictionaryData[key].userID_ + " userName: " + dictionaryData[key].userName_ + " userInterests: " + dictionaryData[key].userInterests_ + " userBio: " + dictionaryData[key].userBio_);
            }
        }
        */




