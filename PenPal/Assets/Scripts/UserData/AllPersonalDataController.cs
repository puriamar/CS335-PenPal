using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//recall: GameData == HolderAllPersonalData
//recall: RoundData == AllPersonalData
public class AllPersonalDataController : MonoBehaviour
{
    private AllPersonalData[] allPersonalData;
    private string userDataFileName = "allUserData.json";

    private void Start()
    {
        //DontDestroyOnLoad();
        LoadAllUserData();
    }

    private void LoadAllUserData()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, userDataFileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            HolderAllPersonalData loadedUserData = JsonUtility.FromJson<HolderAllPersonalData>(dataAsJson);

            allPersonalData = loadedUserData.allPersonalData;

        }
        else
        {
            Debug.LogError("User Data could not be loaded!");
        }
    }
}
