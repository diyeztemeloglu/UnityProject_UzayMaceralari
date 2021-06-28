using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isin : MonoBehaviour
{
    public int numb;
    public string Name;
    public string Name0;
    public string Name1;
    public string Name2;
    public string Name3;
    public string Name4;
    public string Name5;
    public string Name6;

    private void Start()
    {
        if (numb == 1)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
            Name2 = gameObject.transform.GetChild(2).gameObject.GetComponent<isin>().Name;
        }
        if(numb == 2)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
        }
        if(numb == 3)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
            Name2 = gameObject.transform.GetChild(2).gameObject.GetComponent<isin>().Name;
            Name3 = gameObject.transform.GetChild(3).gameObject.GetComponent<isin>().Name;
            Name4 = gameObject.transform.GetChild(4).gameObject.GetComponent<isin>().Name;
            Name5 = gameObject.transform.GetChild(5).gameObject.GetComponent<isin>().Name;
            Name6 = gameObject.transform.GetChild(6).gameObject.GetComponent<isin>().Name;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!(collision.gameObject.GetComponent<Surukle>().isin))
        {
            if (Name.Equals(""))
            {
                collision.gameObject.transform.position = gameObject.transform.position;
                Name = collision.gameObject.name;
                if (collision.gameObject.GetComponent<Surukle>().Boyut)
                {
                    collision.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, gameObject.GetComponent<RectTransform>().rect.width);
                    collision.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, gameObject.GetComponent<RectTransform>().rect.width);
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals(Name))
        {
            Name = "";
        }
    }

    public void Update()
    {
        if (numb == 1)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
            Name2 = gameObject.transform.GetChild(2).gameObject.GetComponent<isin>().Name;
        }
        if (numb == 2)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
        }
        if (numb == 3)
        {
            Name0 = gameObject.transform.GetChild(0).gameObject.GetComponent<isin>().Name;
            Name1 = gameObject.transform.GetChild(1).gameObject.GetComponent<isin>().Name;
            Name2 = gameObject.transform.GetChild(2).gameObject.GetComponent<isin>().Name;
            Name3 = gameObject.transform.GetChild(3).gameObject.GetComponent<isin>().Name;
            Name4 = gameObject.transform.GetChild(4).gameObject.GetComponent<isin>().Name;
            Name5 = gameObject.transform.GetChild(5).gameObject.GetComponent<isin>().Name;
            Name6 = gameObject.transform.GetChild(6).gameObject.GetComponent<isin>().Name;
        }
    }
}
