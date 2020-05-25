using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendControl : MonoBehaviour
{
    public GameObject scroll;
    float scrollPos = 0;
    float[] temp;

    private void Update()
    {
        temp = new float[transform.childCount];
        float _length = 1f / (temp.Length - 1f);
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = _length * i;
        }

        if (Input.GetMouseButton(0))
        {
            scrollPos = scroll.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (scrollPos < temp[i] + (_length / 2) && scrollPos > temp[i] - (_length / 2))
                {
                    scroll.GetComponent<Scrollbar>().value = Mathf.Lerp(scroll.GetComponent<Scrollbar>().value, temp[i], 0.1f);
                }
            }
        }

        for (int i = 0; i < temp.Length; i++)
        {
            if (scrollPos < temp[i] + (_length / 2) && scrollPos > temp[i] - (_length / 2))
            {
                // scroll.GetComponent<Scrollbar>().value = Mathf.Lerp(scroll.GetComponent<Scrollbar>().value, temp[i], 0.1f);
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
                for (int x = 0; x < temp.Length; x++)
                {
                    if (x != i)
                    {
                        transform.GetChild(x).localScale = Vector2.Lerp(transform.GetChild(x).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
            }
        }
    }
}

