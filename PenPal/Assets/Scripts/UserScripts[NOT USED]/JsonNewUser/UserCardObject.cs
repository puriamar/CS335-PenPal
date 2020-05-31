using UnityEngine;
using UnityEngine.UI;

public class UserCardObject : ScriptableObject
{
    public GameObject prefab;
    public GameObject userName;
    public GameObject userBio;
    public GameObject userInterests;

    public int userID;
    //public GameObject userID;
    //public GameObject PanelOpen;
    // public GameObject PanelClose;

    private string UserName;
    private string UserBio;
    private string UserInterests;
    //private int UserID;

    //public Button saveBtn;

    void Update()
    {
        UserName = userName.GetComponent<InputField>().text;
        UserBio = userBio.GetComponent<InputField>().text;
        UserInterests = userInterests.GetComponent<InputField>().text;

        // saveBtn = userID.GetComponent<Button>();
        // saveBtn.onClick.AddListener(ValidateNewUser);

    }
}
