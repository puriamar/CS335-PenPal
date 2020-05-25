using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager
{
    static string path = Application.streamingAssetsPath + "/Data/" + "userData" + ".txt";
    public static void Save(UserControl data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = new FileStream(path, FileMode.Create);

        bf.Serialize(file, data);

        file.Close();
    }

    public static UserControl Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);

            UserControl data = bf.Deserialize(file) as UserControl;

            file.Close();
            return data;
        }
        else
        {
            Debug.Log("File not found" + path);
            return null;
        }
    }
}


  

 
  