using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using JsonSerializeModule;
//using UnityEngine.JSONSerializeModule;


public class DataManager : MonoBehaviour
{
	public UserData data;
	private string file = "user.txt";

	public void Save()
	{
		string json = JsonUtility.ToJson(data);
		WriteToFile(file, json);
	}

	public void Load()
	{
		data = new UserData();
		string json = ReadFromFile(file);
		JsonUtility.FromJsonOverwrite(json, data);
	}

	private void WriteToFile(string fileName, string json)
	{
		string path = GetFilePath(fileName);
		FileStream fileStream = new FileStream(path, FileMode.Create);

		using (StreamWriter writer = new StreamWriter(FileStream))
		{
			writer.Write(json);
		}
	}

	private string ReadFromFile(string fileName)
	{
		string path = GetFilePath(fileName);
		if (File.Exists(path))
		{
			using (StreamReader reader = new StreamReader(path))
			{
				string json = reader.ReaderToEnd();
				return json;
			}
		}
		else
		{
			Debug.LogWarning("File not found!");

			return "";
		}
	}

	private string GetFilePath(string fileName)
	{
		return Applicaiton.persistentDataPath + "/" + fileName;
	}
}