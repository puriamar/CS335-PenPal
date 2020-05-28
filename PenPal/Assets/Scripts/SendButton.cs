using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendButton : MonoBehaviour {

    public GameObject panelToOpen;
    public GameObject panelToClose;

    private void OpenPanel () {
        if (panelToOpen != null) {
            panelToOpen.SetActive (true);
        }
    }

    public void ClosePanel () {
        Invoke ("MyCoroutine", 0.45f);
    }

    private void MyCoroutine () {
        if (panelToClose != null) {
            panelToClose.SetActive (false);
        }
        OpenPanel ();
    }
}