using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter : MonoBehaviour
{
    public Sprite Erkek;
    public Sprite Kız;

    private void Update()
    {
        if (PlayerPrefs.HasKey("Player"))
        {
            if (PlayerPrefs.GetInt("Player") == 0)
            {
                gameObject.GetComponent<Image>().sprite = Erkek;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = Kız;
            }
        }
    }
}
