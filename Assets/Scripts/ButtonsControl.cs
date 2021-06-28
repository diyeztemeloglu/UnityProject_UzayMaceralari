using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsControl : MonoBehaviour
{
    public GameObject OpenObject;
    public GameObject OpenObject2;
    public GameObject CloseObject;
    public GameObject CloseObject2;
    public GameObject txt;
    public GameObject Fazladan;
    public GameObject Fazladan1;
    public Sprite background;
    string Name;
    GameObject backgroundObject;
    public bool isopen = true;
    public string KnowLedgeBox;

    private void Start()
    {
        backgroundObject = GameObject.Find("BackGround");
    }
    public void OpenCloseButton(int i)
    {
        CloseObject.SetActive(false);
        OpenObject.SetActive(true);
        txt.GetComponent<Text>().text = KnowLedgeBox;
        OpenObject2.SetActive(true);
        if (i == 1)
        {
            Fazladan.GetComponent<ButtonsControl>().isopen = true;
            Fazladan.GetComponent<ButtonsControl>().Settings();
        }
    }

    public void Settings()
    {
        isopen = !isopen;
        OpenObject.SetActive(isopen);
    }

    public void ChangeBackground()
    {
        backgroundObject.GetComponent<Image>().sprite = background;
    } 

    public void CharacterChoose(int xc)
    {
        PlayerPrefs.SetInt("Player", xc);
        CloseObject.SetActive(false);
        CloseObject2.SetActive(false);
        OpenObject.SetActive(true);
        OpenObject.transform.GetChild(xc).gameObject.SetActive(false);
    }

    public void Button01Evet(string txtbaloncuk)
    {
        gameObject.SetActive(false);
        OpenObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = txtbaloncuk;
        txt.GetComponent<Text>().text = KnowLedgeBox;
        OpenObject.SetActive(true);
        CloseObject.SetActive(true);
    }
    public void Button02Devam()
    {
        OpenObject.GetComponent<Text>().text = KnowLedgeBox;
        OpenObject2.SetActive(false);
        CloseObject.SetActive(true);
        txt.SetActive(false);
    }

    public void Names(string str)
    {
        OpenObject.GetComponent<Text>().text = KnowLedgeBox;
        OpenObject2.GetComponent<Text>().text = "Tanıştığıma Memnun oldum " + str;
        Fazladan.GetComponent<Text>().text = "SEVGİLİ " + str;
        CloseObject2.SetActive(true);
        txt.SetActive(true);
        Name = str;
        Destroy(gameObject, 0f);
    }

    public void Continue()
    {
        CloseObject.SetActive(false);
        OpenObject.SetActive(true);
        Fazladan1.GetComponent<Roket>().Level = 1;
        OpenObject2.GetComponent<Image>().sprite = background;
        txt.GetComponent<Text>().text = KnowLedgeBox;
        CloseObject2.SetActive(false);      
        Fazladan.SetActive(true);       
    }
}
