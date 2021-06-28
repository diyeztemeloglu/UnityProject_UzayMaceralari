using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opener : MonoBehaviour
{
    public int isopen = 0;
    public GameObject OpenObject;
    public GameObject KnowledgeBox;
    public GameObject CloseObject;
    public GameObject CloseObject2;
    public GameObject obje1;
    public GameObject obje2;
    public GameObject obje3;
    public GameObject obje4;
    public GameObject obje5;
    public InputField InputFieldRef;

    public GameObject Clean;
    public GameObject Clean2;
    public string text1;

    int i = 0;
    public bool Raporbool = false;

    public void Termometre()
    {
        if (isopen == 1)
        {
            isopen = 0;
            //clean
            Clean2.GetComponent<Text>().text = "";
            InputFieldRef.text = "";
            //sss
            obje1.SetActive(true);
            obje2.SetActive(false);
            CloseObject2.GetComponent<ButtonsControl>().isopen = true;
            CloseObject2.GetComponent<ButtonsControl>().Settings();
            obje3.SetActive(false);
            OpenObject.SetActive(true);
            CloseObject.SetActive(false);
            KnowledgeBox.SetActive(true);
            KnowledgeBox.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
            i++;
        }
    }

    public void Rapor()
    {
        if(isopen == 1)
        {
            Raporbool = !Raporbool;
            OpenObject.SetActive(Raporbool);
        }

    }

    public void Metre()
    {
        if(isopen == 1)
        {
            isopen = 0;
            Clean.SetActive(false);
            Clean2.GetComponent<ButtonsControl>().isopen = true;
            Clean2.GetComponent<ButtonsControl>().Settings();
            OpenObject.SetActive(true);
            CloseObject.SetActive(false);
            CloseObject2.transform.localPosition = new Vector3(-75,0,0);
            obje1.SetActive(true);
            KnowledgeBox.GetComponent<Text>().text = "Haydi çevrenin kaç km ölçüldüğünü rapora not et.";
        }
        if(isopen == 2)
        {
            isopen = 0;
            Clean2.GetComponent<ButtonsControl>().isopen = true;
            Clean2.GetComponent<ButtonsControl>().Settings();
            obje2.SetActive(true);
            obje3.SetActive(true);
            KnowledgeBox.GetComponent<Text>().text = "Okuduğun değeri rapora eklemeyi unutma.";
        }
        if(isopen == 3)
        {
            isopen = 0;
            Clean2.GetComponent<ButtonsControl>().isopen = true;
            Clean2.GetComponent<ButtonsControl>().Settings();
            obje4.SetActive(true);
            obje5.SetActive(true);
            KnowledgeBox.GetComponent<Text>().text = "Okuduğun değeri rapora eklemeyi unutma.";

        }
    }
    public void Yardım()
    {
        if(isopen == 1)
        {
            obje4.SetActive(true);
            obje1.SetActive(false);
            obje2.SetActive(true);
            Clean.GetComponent<Opener>().isopen = 1;
            Clean2.SetActive(true);
            Clean2.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
            isopen = 0;
        }
        if(isopen == 2)
        {
            OpenObject.SetActive(true);
            obje1.SetActive(false);
            obje2.SetActive(true);
            obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dünyada nefes almamızı Atmosfer sağlıyor. Bu durumda Ayda atmosfer olup olmadığına bakabilirsin";
            OpenObject.SetActive(true);
            isopen = 0;
        }
        if(isopen == 3)
        {
            CloseObject.SetActive(false);
            CloseObject2.SetActive(true);
            KnowledgeBox.GetComponent<Text>().text = "Makineye tıkla ve gazları ölçmeye başla.";
            obje3.GetComponent<Opener>().isopen = 1;
            isopen = 0;
        }
    }

    public void Kask()
    {
        if(isopen == 1)
        {
            isopen = 0;
            obje4.SetActive(false);
            obje5.GetComponent<ButtonsControl>().isopen = true;
            obje5.GetComponent<ButtonsControl>().Settings();
            OpenObject.SetActive(true);
            CloseObject.SetActive(false);
            Clean2.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
            CloseObject2.SetActive(false);
            obje3.SetActive(true);
            obje1.SetActive(false);
            obje2.SetActive(true);          
        }
    }

    public void Kaskdevam()
    {
        CloseObject2.SetActive(true);
        CloseObject2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "TUE başkanının bu konuda bir fikri var.";
        Clean2.SetActive(false);
        Clean.SetActive(false);
        obje2.GetComponent<Opener>().isopen = 2;
        gameObject.SetActive(false);
    }

    public void Makine()
    {
        if (isopen == 1)
        {
            CloseObject2.SetActive(false);
            CloseObject.GetComponent<ButtonsControl>().isopen = true;
            CloseObject.GetComponent<ButtonsControl>().Settings();
            KnowledgeBox.GetComponent<Text>().text = "Atmosferde bulunan gazların isimlerini gir ve Ayda bu gazlardan olup olmadığını makinadan öğren.";
            OpenObject.SetActive(true);
            obje1.SetActive(true);
            obje2.GetComponent<Opener>().isopen = 3;
            isopen = 0;
        }
    }

    public void AnaMakine()
    {
        if(isopen == 1)
        {
            isopen = 0;
            OpenObject.SetActive(true);
            CloseObject.SetActive(false);
            KnowledgeBox.GetComponent<Text>().text =  "Gazların ismini sırasıyla üst kutucukta yazıyor. Ölçüm yap butonuna bastıktan sonra makina sana gazın bulunma oranını  alt taraftaki kutucukta verecek.";

        }
    }
}
