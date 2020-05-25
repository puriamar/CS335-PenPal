using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class UserControl
{
    public List<string> txtInput;

    public UserControl(List<string> txtInput)
    {
        this.txtInput = txtInput;
    }
}



