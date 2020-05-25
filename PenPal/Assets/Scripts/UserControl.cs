using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class UserControl
{
    public List<string> txtInput;
    private List<string> temp;

    public UserControl(List<string> txtInput)
    { 
        this.txtInput = txtInput;
    }
}



