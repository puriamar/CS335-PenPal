using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[System.Serializable]
public struct DirectoryStructure
{
   public string[] directories;
}

public class DirectoryManager : MonoBehaviour
{
    public DirectoryStructure fileStruct;
    public static bool structureOk = false;


    // Start is called before the first frame update
    void Awake()
    {
        fileStruct = JsonUtility.FromJson<DirectoryStructure>(JsonFileUtility.LoadJsonFromFile("DirectoryStructure.json", true));
        DirectoryManager.CheckDirectoryStructure(fileStruct.directories);
        bool checkPass = DirectoryManager.CheckDirectoryStructure(fileStruct.directories);
        if (!checkPass)
        {
            Debug.LogWarning("Directory " + checkPass + " was not found!");
            Application.Quit();
        }

    }

    public static bool CheckDirectoryStructure(string[] directories)
    {
        structureOk = true;
        foreach(string directory in directories)
        {
            if(!Directory.Exists(Application.persistentDataPath + "/" + directory))
            {
                try
                {
                    Directory.CreateDirectory(Application.persistentDataPath + "/" + directory);
                }
                catch  (Exception exception)
                {
                    structureOk = true;
                }
            }
        }
        return structureOk;

    }
}
