using UnityEngine;
using System.IO;
using System.Text;
//using UTF8Encoding;

public class JsonFileUtility 
{
    public static string LoadJsonFromFile(string path, bool isResource)
    {
        if (isResource)
        {
            return LoadJsonAsResource(path);
        }
        else
        {
            return LoadJsonAsExternalResource(path);
        }
    }
    public static string LoadJsonAsResource(string path)
    {
        /*
         * Here we are sending a specific file that we want to load. Then its taking that file and loading it as a 
         * textAsset and then we are storing that in loadedJsonFile. After that we are returning it.
         */
        //this finds the .json and removes and then this becomes our filepath. We then pass this string in and use it
        // to find our textAsset
        string jsonFilePath = path.Replace(".json", "");
        //string jsonFilePath = path.Replace(".txt", "");
        //Here we are loading from the resources folder
        TextAsset loadedJsonFile = Resources.Load<TextAsset>(jsonFilePath); //b/c load is a method we pass it the path
        return loadedJsonFile.text;
    }

    public static string LoadJsonAsExternalResource(string path)
    {
        path = Application.persistentDataPath + "/" + path;
        if (!File.Exists(path))
        {
            return null;
        }
        StreamReader reader = new StreamReader(path);
        string response = "";
        while (!reader.EndOfStream)
        {
            response += reader.ReadLine();
        }
        return response;
    }

    public static void WriteJsonToExternalResource(string path, string content)
    {
        path = Application.persistentDataPath + "/" + path;
        FileStream stream = File.Create(path);
        Debug.Log(stream);
        byte[] contentBytes = new UTF8Encoding(true).GetBytes(content);
        stream.Write(contentBytes, 0, contentBytes.Length);
    }

}
