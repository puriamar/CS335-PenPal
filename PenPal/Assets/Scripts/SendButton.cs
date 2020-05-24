using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendButton : MonoBehaviour {

    public GameObject Panel;
    public GameObject Panel2;

    private void OpenPanel () {
        if (Panel2 != null) {
            Panel2.SetActive (true);
        }
    }

    public void ClosePanel () {
        Invoke ("MyCoroutine", 0.5f);
    }

    private void MyCoroutine () {
        if (Panel != null) {
            Panel.SetActive (false);
        }
        OpenPanel ();
    }
}
