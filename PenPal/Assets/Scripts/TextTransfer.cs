using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TextTransfer : MonoBehaviour {
    string emailContent;
    public GameObject inputField;

    public void CreateText () {
        emailContent = inputField.GetComponent<Text> ().text;
        string path = Application.dataPath + "/Inbox/ReceivedLetter.txt";
        if (!File.Exists (path)) {
            File.AppendAllText (path, "Sent on:" + System.DateTime.Now + "\n\n");
            File.AppendAllText (path, emailContent);
        } else {
            File.WriteAllText (path, "");
            File.AppendAllText (path, "Sent on:" + System.DateTime.Now + "\n\n");
            File.AppendAllText (path, emailContent);
        }
    }

}