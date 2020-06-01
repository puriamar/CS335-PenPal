using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

//recall: GameData == HolderAllPersonalData
//recall: RoundData == AllPersonalData
public class UserDataEditor : EditorWindow
{
    public HolderAllPersonalData holderAllPersonalData;

    private string allUserDataHolderFilePath = "/StreamingAssets/allUserData.json";

    [MenuItem("Window/User Data Editor")]
    static void Init()
    {
        EditorWindow.GetWindow(typeof(UserDataEditor)).Show();
    }

    private void OnGUI()
    {
        if(holderAllPersonalData != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("holderAllPersonalData");
            EditorGUILayout.PropertyField(serializedProperty, true);

            serializedObject.ApplyModifiedProperties();

            if(GUILayout.Button("Save all user data"))
            {
                SaveAllUserData();
            }
        }

        if(GUILayout.Button("Load all user data"))
        {
            LoadAllUserData();
        }
    }

    private void LoadAllUserData()
    {
        string filePath = Application.dataPath + allUserDataHolderFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            holderAllPersonalData = JsonUtility.FromJson<HolderAllPersonalData>(dataAsJson);

            if(holderAllPersonalData == null)
            {
                holderAllPersonalData = new HolderAllPersonalData();
            }
        }
        else
        {
            holderAllPersonalData = new HolderAllPersonalData();
        }
    }

    private void SaveAllUserData()
    {
        string dataAsJson = JsonUtility.ToJson(holderAllPersonalData);

        string filePath = Application.dataPath + allUserDataHolderFilePath;
        File.WriteAllText(filePath, dataAsJson);
    }
}
