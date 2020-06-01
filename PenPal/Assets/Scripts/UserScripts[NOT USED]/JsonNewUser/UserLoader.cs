using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserLoader : MonoBehaviour
{
    /*
    public Dictionary<int, User> userData;
    public List<User> userList; // change this later because it uses double the memory
    //called before start
    //this way we are initializing before anything can use it
    void Awake()
    {
        userData = new Dictionary<int, User>();
        //creating the dictionary to store userData
        UserDictionary dictionary = JsonUtility.FromJson<UserDictionary>(JsonFileReader.LoadJsonAsResource("Users/UserDictionary.json"));
        //iterating over our array which is now store in our UserDictionary in a string of userData
        foreach (string dictionaryUser in dictionary.userData)
        {
            LoadUser(dictionaryUser);
        }

        foreach (KeyValuePair<int, User> entry in userData)
        {
            User temp = entry.Value;
            userList.Add(temp);
        }
    }

    public void LoadUser(string path)
    {
        string loadedUserData = JsonFileReader.LoadJsonAsResource(path);
        // here you are grabbing the json text, then parsing it as a User into userData
        //userData = JsonUtility.FromJson<User>(loadedUserData);
        User newUser = JsonUtility.FromJson<User>(loadedUserData);

        if (userData.ContainsKey(newUser.userID))
        {
            Debug.LogWarning("User " + newUser.userName + " Key already exists as " + userData[newUser.userID].userName);
            userData[newUser.userID] = newUser;
        }
        else
        {
            userData.Add(newUser.userID, newUser);
        }
      
    }
    */
}

