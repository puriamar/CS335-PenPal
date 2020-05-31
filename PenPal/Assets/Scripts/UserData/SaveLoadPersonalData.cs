using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadPersonalData
{
    public static PersonalData personalDataSave;

    public static void SaveData (PersonalData personalDataSave)
    {
        string path = Path.Combine(Application.persistentDataPath, "personalDataSave.json");
        string data = JsonUtility.ToJson(personalDataSave);
        File.WriteAllText(path, data);

        Debug.Log("Saving Data");
    }

    public static PersonalData LoadData()
    {
        string path = Path.Combine(Application.persistentDataPath, "personalDataSave.json");
        string data = File.ReadAllText(path);
        Debug.Log("Loading Data");


        return JsonUtility.FromJson<PersonalData>(data);
    }
}
