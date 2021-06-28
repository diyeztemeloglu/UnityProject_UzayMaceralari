using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsControl2 : MonoBehaviour
{
    public GameObject Obje1;
    public GameObject Obje2;
    public GameObject Obje3;
    public GameObject Obje4;
    public GameObject Obje5;
    public GameObject Obje6;
    public GameObject Obje7;
    public GameObject Obje8;
    public GameObject obje9;
    public GameObject obje10;
    public GameObject obje11;
    public GameObject obje12;
    public InputField IF;
    public string text1;
    public string text2;
    public string text3;
    public Sprite sprite;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public int Objectnumb;
    public bool Start = false;
    int rety = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Objectnumb == 0)
        {
            Obje6.SetActive(true);
            gameObject.SetActive(false);
        }
        if (Objectnumb == 1)
        {
            Obje1.SetActive(true);
        }
        if (Objectnumb == 2)
        {
            Obje1.SetActive(true);
            Destroy(gameObject, 0f);
        }
        if(Objectnumb == 3)
        {
            Obje1.SetActive(true);
        }
        if(Objectnumb == 4)
        {
            Obje1.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    // 0 numara
    public void levelOpenbutton1()
    {
        Obje1.SetActive(false);
        Obje2.SetActive(true);
        Obje3.GetComponent<Text>().text = text1;
        gameObject.SetActive(false);
    }
    public void levelopenbutton2()
    {
        Obje3.SetActive(true);
        Obje1.GetComponent<Text>().text = text1;
        Obje2.SetActive(true);
        Obje2.GetComponent<Roket>().Level = 1;
        gameObject.SetActive(false);
    }
    //1 numara
    public void LevelContinuebutton1()
    {
        Obje2.SetActive(true);
        Obje3.GetComponent<Text>().text = text1;
        Obje4.SetActive(false);
        Obje1.SetActive(false);
    }
    public void LevelContinuebutton2()
    {
        Obje3.GetComponent<Text>().text = text1;
        Obje5.SetActive(true);
        Obje6.GetComponent<Opener>().isopen = 1;
        Obje7.SetActive(true);
        gameObject.SetActive(false);
    }

    //2 numara
    public void Moon2Button()
    {
        if (rety == 0)
        {
            rety++;
            Obje1.SetActive(true);
            Obje4.GetComponent<Roket>().Level = 1;
            Obje5.SetActive(true);
            Obje5.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
            Obje2.SetActive(false);
        }
        else if(rety == 1)
        {
            Obje6.SetActive(true);
            Obje2.SetActive(false);
        }
    }

    //3 numara
    public void Moon3Button()
    {
            Obje1.SetActive(true);
            Obje3.GetComponent<Image>().sprite = sprite;
            Obje4.SetActive(false);
            Obje2.SetActive(false);
    }

    //20 numara
    public void StoryManagerbutton()
    {
        if(rety == 1)
        {
            rety++;
            Obje1.SetActive(false);
            Obje2.SetActive(true);
            Obje3.GetComponent<Opener>().isopen = 1;
            gameObject.SetActive(false);
        }
        if(rety == 0)
        {
            Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yardım et!!";
            rety++;
        }
    }

    public void olcum()
    {
        Text tx = Obje1.GetComponent<Text>();

        if ((tx.text.Equals("4.KATMAN") || tx.text.Equals("4. Katman") || tx.text.Equals("4. katman") || tx.text.Equals("4. KATMAN") || tx.text.Equals("4 katman") || tx.text.Equals("4 Katman") || tx.text.Equals("4 KATMAN") || tx.text.Equals("4.katman") || tx.text.Equals("4katman") || tx.text.Equals("katman 4") || tx.text.Equals("katman4") || tx.text.Equals("Katman 4") || tx.text.Equals("KATMAN 4")) && Objectnumb == 1 && rety == 3)
        {
            rety++;
            Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Haydi sıcaklığın kaç derece ölçüldüğünü rapora not et";
            Obje3.GetComponent<Text>().text = "12 milyon °C";
            Obje4.SetActive(true);
            gameObject.SetActive(false);
        }
        else if ((tx.text.Equals("3.KATMAN") || tx.text.Equals("3. Katman") || tx.text.Equals("3. katman") || tx.text.Equals("3. KATMAN") || tx.text.Equals("3 katman") || tx.text.Equals("3 Katman") || tx.text.Equals("3 KATMAN") || tx.text.Equals("3.katman") || tx.text.Equals("3katman") || tx.text.Equals("katman 3") || tx.text.Equals("katman3") || tx.text.Equals("Katman 3") || tx.text.Equals("KATMAN 3")) && Objectnumb == 1 && rety == 2)
        {
            rety++;
            Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Haydi sıcaklığın kaç derece ölçüldüğünü rapora not et";
            Obje3.GetComponent<Text>().text = "8 milyon °C";
            Obje4.SetActive(true);
            gameObject.SetActive(false);
        }
        else if ((tx.text.Equals("2.KATMAN") || tx.text.Equals("2. Katman") || tx.text.Equals("2. katman") || tx.text.Equals("2. KATMAN") || tx.text.Equals("2 katman") || tx.text.Equals("2 Katman") || tx.text.Equals("2 KATMAN") || tx.text.Equals("2.katman") || tx.text.Equals("2katman") || tx.text.Equals("katman 2") || tx.text.Equals("katman2") || tx.text.Equals("Katman 2") || tx.text.Equals("KATMAN 2")) && Objectnumb == 1 && rety == 1)
        {
            rety++;
            Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Haydi sıcaklığın kaç derece ölçüldüğünü rapora not et";
            Obje3.GetComponent<Text>().text = "1 milyon °C";
            Obje4.SetActive(true);
            gameObject.SetActive(false);
        }
        else if ((tx.text.Equals("1.KATMAN") || tx.text.Equals("1. Katman") || tx.text.Equals("1. katman") || tx.text.Equals("1. KATMAN") || tx.text.Equals("1 katman") || tx.text.Equals("1 Katman") || tx.text.Equals("1 KATMAN") || tx.text.Equals("1.katman") || tx.text.Equals("1katman") || tx.text.Equals("katman 1") || tx.text.Equals("katman1") || tx.text.Equals("Katman 1") || tx.text.Equals("KATMAN 1")) && Objectnumb == 1 && rety == 0)
        {
            rety++;
            Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Haydi sıcaklığın kaç derece ölçüldüğünü rapora not et";
            Obje3.GetComponent<Text>().text = "6000 °C";
            Obje4.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            Obje5.SetActive(true);
        }
    }

    public void Kaydet()
    {
        Obje1.SetActive(true);
        Obje1.transform.GetChild(2).gameObject.SetActive(true);
        Obje2.SetActive(false);

        if(Objectnumb == 1)
        {
            Obje3.SetActive(false);
            Obje6.SetActive(false);
            Text text = Obje4.GetComponent<Text>();
            text.text = "Güneşin çevresi: 4.379.000 km";

        }
        if (Objectnumb == 2)
        {
            Obje3.SetActive(true);
            Obje3.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Güneşle ilgili bilgileri raporladık. Şimdi Ay hakkında bilgi toplama zamanı. Hazırsan ikinci görev başlıyor.";
            Obje5.GetComponent<Opener>().isopen = 0;
            Obje6.SetActive(false);
            Obje7.SetActive(true);
            rety = 4;
        }

        if (Objectnumb == 0)
        {
            Obje3.SetActive(false);
            Text text = Obje4.GetComponent<Text>();
            if (rety == 3)
            {
                Obje5.SetActive(false);
                text.text = "1. Katmanın sıcaklığı: 6000°C        2.Katmanın sıcaklığı: 1 milyon°C      3.Katmanın sıcaklığı: 8 milyon °C      4.Katmanın sıcaklığı: 12 milyon °C";
                rety++;
            }
            if (rety == 2)
            {
                text.text = "1. Katmanın sıcaklığı: 6000°C        2.Katmanın sıcaklığı: 1 milyon°C      3.Katmanın sıcaklığı: 8 milyon °C";
                rety++;
            }
            if (rety == 1)
            {
                text.text = "1. Katmanın sıcaklığı: 6000°C        2.Katmanın sıcaklığı: 1 milyon°C";
                rety++;
            }
            if (rety == 0)
            {
                text.text = "1. Katmanın sıcaklığı: 6000°C";
                rety++;
            }
        }
    }

    public void Close()
    {      
        if (Objectnumb == 8)
        {
            if(rety == 3)
            {
                obje11.GetComponent<Image>().sprite = sprite;
                Obje5.SetActive(false);
                obje9.SetActive(true);
                obje10.SetActive(false);
            }
            else if (rety == 2)
            {
                rety++;
                Obje8.GetComponent<Text>().text = "Tebrikler tüm bilgileri doğru girdin ve Atmosferde bulunan gazların Ay’da bulunmadığını yani Ay’da atmosfer olmadığını kanıtlamış oldun.";
            }
            else if(rety == 1 || rety == 0)
            {
                Obje7.SetActive(false);
                Obje6.GetComponent<Text>().text = "";
                Obje5.SetActive(true);
                Obje5.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Gazların ismini sırasıyla üst kutucukta yazıyor. Ölçüm yap butonuna bastıktan sonra makina sana gazın bulunma oranını  alt taraftaki kutucukta verecek.";
                if (rety == 0) Obje4.GetComponent<Text>().text = "Azot";
                if (rety == 1) Obje4.GetComponent<Text>().text = "Karbondioksit";
                Obje3.SetActive(false);
                Obje2.SetActive(true);
                rety++;
                Obje1.SetActive(false);
            }
        }
        else if (Objectnumb == 6)
        {
            Obje1.SetActive(false);
        }
        else if (Objectnumb == 7)
        {
            Obje1.SetActive(true);
            Obje2.GetComponent<Text>().text = text1;
            Obje3.SetActive(false);
        }
        else if (Objectnumb == 5)
        {
            Obje5.SetActive(true);
            Obje2.SetActive(true);
            Obje3.GetComponent<Text>().text = text1;
            Obje4.GetComponent<Opener>().isopen = 1;
            Obje1.SetActive(false);
        }
        else if(Objectnumb == 4)
        {
            Obje4.SetActive(false);
            Obje3.GetComponent<Image>().sprite = sprite;
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
        else if(Objectnumb == 3)
        {
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
        else if(Objectnumb == 2)
        {
            if (rety == 0)
            {
                rety++;
                Obje1.GetComponent<Text>().text = "✓";
                Obje2.SetActive(true);
                Obje3.SetActive(true);
                Obje4.SetActive(true);
                Obje5.GetComponent<Text>().text = "Büyük okların üzerinde yazan zaman diliminden yardım alabilirsin.";
                Obje6.GetComponent<Text>().text = "Tebrikler 2 hafta ilerledin ve ekibin hangi evreye kadar yiyeceklerinin yeteceğini bulmuş oldun. Çarpıya bas ve  bilgiyi Rapora ekleme bölümün geç";
                Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Öğrendiğimiz bir diğer bilgi de ekibin yiyeceklerinin yalnızca 14 gün yetebileceğiydi. Bakalım 14 gün sonra ayın hangi evresinde oluyorlar.";
                gameObject.transform.parent.gameObject.SetActive(false);
            }
            else if(rety == 1)
            {
                Obje1.SetActive(true);
                Obje3.SetActive(true);
                gameObject.transform.parent.gameObject.SetActive(false);
            }
        }
        else if(Objectnumb == 1)
        {
            Obje2.SetActive(true);
            Obje3.GetComponent<Image>().sprite = sprite;
            Obje4.SetActive(false);
            Obje1.SetActive(false);
        }
        else if(Objectnumb == 0)
        {
            if (rety == 4)
            {
                rety++;
                Obje7.SetActive(true);
                Obje7.transform.GetChild(2).gameObject.GetComponent<Roket>().Level = 2;
                Obje8.SetActive(true);
                Obje6.SetActive(false);
            }
            if (rety == 3)
            {
                rety++;
                Obje2.SetActive(true);
                Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Şimdi de raporu düzenli bir hale getirelim ki bizden sonra araştırma yapanlara kolaylık olsun.";
                Obje5.SetActive(true);
                Obje3.SetActive(false);
            }
            if (rety == 2)
            {
                rety++;
                Obje1.SetActive(true);
                Obje2.SetActive(true);
                Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "4.KATMAN";
                Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = text3;
                Obje1.transform.localPosition = new Vector3(81, 40, 0);
                Obje4.SetActive(true);
                Obje3.SetActive(false);
            }

            if (rety == 1)
            {
                rety++;
                Obje1.SetActive(true);
                Obje2.SetActive(true);
                Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "3.KATMAN";
                Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = text2;
                Obje1.transform.localPosition = new Vector3(123, 76, 0);
                Obje4.SetActive(true);
                Obje3.SetActive(false);
            }

            if (rety == 0)
            {
                rety++;
                Obje1.SetActive(true);
                Obje2.SetActive(true);
                Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "2.KATMAN";
                Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
                Obje1.transform.localPosition = new Vector3(138, 119, 0);
                Obje4.SetActive(true);
                Obje3.SetActive(false);
            }
        }

    }

    public void Tamam()
    {
        Obje1.SetActive(false);
        Obje2.GetComponent<Text>().text = text1;
        Obje3.GetComponent<Opener>().isopen = 1;
        gameObject.SetActive(false);
    }

    public void RaporD()
    {
        Obje2.SetActive(true);
        Obje1.GetComponent<Text>().text = text1;
        if (Objectnumb == 1)
        {
            Obje3.SetActive(false);
        }
        else gameObject.SetActive(false);
    }

    public void check()
    {
        if (text2.Equals("1"))
        {
            isin sss = Obje1.GetComponent<isin>();
            if (sss.Name.Equals("Katman4") && sss.Name0.Equals("Katman3") && sss.Name1.Equals("Katman2") && sss.Name2.Equals("Katman1"))
            {
                Obje2.SetActive(true);
                gameObject.SetActive(false);
            }
            else
            {
                Obje3.SetActive(true);
            }
        }
        if (text2.Equals("2"))
        {
            isin sss = Obje1.GetComponent<isin>();
            if (sss.Name.Equals("Sun") && sss.Name0.Equals("World") && sss.Name1.Equals("Moon"))
            {
                Obje2.SetActive(true);
                gameObject.SetActive(false);
            }
            else
            {
                Obje3.SetActive(true);
            }
        }
        if (text2.Equals("3"))
        {
            isin sss = Obje1.GetComponent<isin>();
            if (sss.Name.Equals("ilkdordun") && sss.Name0.Equals("siskinay") && sss.Name1.Equals("Dolunay") && sss.Name2.Equals("siskinay2") && sss.Name3.Equals("sondordun") && sss.Name4.Equals("Hilal") && sss.Name5.Equals("YeniAy") && sss.Name6.Equals("Hilal2"))
            {
                Obje2.SetActive(true);
                Obje4.GetComponent<Text>().text = "Tüm Görevleri başarıyla tamamladın bize bu görevde yardımcı olduğun için çok teşekkür ederiz. (Çarpı'ya bas)";
                gameObject.SetActive(false);
            }
            else
            {
                Obje3.SetActive(true);
                if(rety == 0)
                {
                    rety++;
                    Obje4.GetComponent<Text>().text = "Haydi sağ tarafta verilen Ay’ın evrelerini sürükleyerek Dünya çevresindeki uygun yerlere yerleştir.";

                }
                else if (rety == 1)
                {
                    rety++;
                    Obje4.GetComponent<Text>().text = "Sana bir ipucu verelim. Hazır olarak yerleşmiş evreler saat yönünün tersinde sırasıyla Ay’ın ana fazları olan İlk Dördün, Dolunay, Son Dördün ve Yeni Ay. Ara fazlar ise sağ tarafta.Onları sürükleyerek Ay’ın evreleri modelini tamamla.";

                }
                else if(rety == 2)
                {
                    rety = 0;
                    Obje4.GetComponent<Text>().text = "Son bir ipucu da Ay’ın Dünya’dan görünen yüzü hep aynı yüz olsa da görünürlüğü gittikçe artıyor. Yani gittikçe beyaz kısım büyüyor.";
                }
            }
        }
    }

    public void yolculuk()
    {
        Obje1.SetActive(true);
        Obje1.transform.GetChild(0).gameObject.GetComponent<Roket>().Level = 1;
        Obje2.SetActive(true);
        Obje2.transform.GetChild(0).gameObject.GetComponent<Text>().text = " İkinci görevimiz için Ay’a doğru yola çıktık. Ay’a daha önce ayak basanlar oldu bu sebepten Güneş’i incelerken yaptığımız gibi robot göndermemize gerek yok bizzat biz gidebiliriz.";
        Obje3.SetActive(false);
    }

    public void DevamMoon()
    {
        Obje1.GetComponent<Image>().sprite = sprite;
        Obje3.SetActive(true);
        Obje4.SetActive(true);
        Obje4.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Atmosfer katmanının olup olmadığını bulmak için gaz ölçüm aracını kullanmalısın. (Gaz Ölçüm Aracı araç-gereçlerin içinde";
        Obje5.GetComponent<Opener>().isopen = 1;
        Obje6.SetActive(true);
        Obje2.SetActive(false);
    }

    public void MoonOlcum()
    {
        if (rety == 2)
        {
            rety++;
            Obje3.GetComponent<Text>().text = "%0";
            Obje4.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Oran yazan yere ölçtüğün sonucu yaz ve bilgiyi rapora ekle";
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
        if (rety == 1)
        {
            rety++;
            Obje3.GetComponent<Text>().text = "%0";
            Obje4.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Oran yazan yere ölçtüğün sonucu yaz ve bilgiyi rapora ekle";
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
        if (rety == 0)
        {
            rety++;
            Obje4.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Oran yazan yere ölçtüğün sonucu yaz ve bilgiyi rapora ekle";
            Obje3.GetComponent<Text>().text = "%0";
            obje9.SetActive(true);
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
    }

    public void MoonKaydet()
    {
        Text tx = Obje5.GetComponent<Text>();

        if (rety == 2)
        {
            if (tx.text.Equals("0") || tx.text.Equals("sıfır") || tx.text.Equals("%0") || tx.text.Equals("0%") || tx.text.Equals("yüzde sıfır") || tx.text.Equals("Yüzde Sıfır") || tx.text.Equals("yüzde Sıfır") || tx.text.Equals("Yüzde sıfır") || tx.text.Equals("YÜZDE SIFIR"))
            {
                rety++;
                Obje4.GetComponent<Text>().text = "Oksijen Miktarı: %0     Azot Miktarı: %0     Karbondioksit Miktarı: %0";
                Obje3.SetActive(true);
                Obje3.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Evet, Aydaki karbondioksit miktarı da yaklaşık %0’dır";
                IF.text = "";
                Obje1.SetActive(false);
            }
            else
            {
                Obje6.SetActive(true);
            }
        }
        if (rety == 1)
        {
            if (tx.text.Equals("0") || tx.text.Equals("sıfır") || tx.text.Equals("%0") || tx.text.Equals("0%") || tx.text.Equals("yüzde sıfır") || tx.text.Equals("Yüzde Sıfır") || tx.text.Equals("yüzde Sıfır") || tx.text.Equals("Yüzde sıfır") || tx.text.Equals("YÜZDE SIFIR"))
            {
                rety++;
                Obje4.GetComponent<Text>().text = "Oksijen Miktarı: %0     Azot Miktarı: %0";
                Obje3.SetActive(true);
                Obje3.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Evet, Aydaki azot miktarı da yaklaşık %0’dır";
                IF.text = "";
                Obje1.SetActive(false);
            }
            else
            {
                Obje6.SetActive(true);
            }
        }
        if (rety == 0)
        {
            if (tx.text.Equals("0") || tx.text.Equals("sıfır") || tx.text.Equals("%0") || tx.text.Equals("0%") || tx.text.Equals("yüzde sıfır") || tx.text.Equals("Yüzde Sıfır") || tx.text.Equals("yüzde Sıfır") || tx.text.Equals("Yüzde sıfır") || tx.text.Equals("YÜZDE SIFIR"))
            {
                rety++;
                Obje4.GetComponent<Text>().text = "Oksijen Miktarı: %0";
                Obje3.SetActive(true);
                IF.text = "";
                Obje2.SetActive(false);
                Obje1.SetActive(false);
            }
            else
            {
                Obje6.SetActive(true);
            }
        }
    }

    public void DevamMoonMetre()
    {
        Obje1.SetActive(true);
        Obje3.SetActive(true);
        Obje3.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ayın çevresini ölçmek için metreyi al. (Araç Gereçlerin içinde)";
        Obje4.GetComponent<Image>().sprite = sprite;
        Obje5.GetComponent<Opener>().isopen = 2;
        Obje2.SetActive(false);
    }

    public void RaporMoonMetre()
    {
        Obje3.SetActive(false);
        Obje1.GetComponent<Text>().text = text1;
        Obje5.SetActive(false);
        Obje2.SetActive(true);
        Obje4.SetActive(false);
        gameObject.SetActive(false);
    }

    public void closer(int i)
    {
        if (i == 0)
        {
            Obje2.SetActive(true);
            Obje1.SetActive(false);
        }
        if (i == 1)
        {
            if(rety == 1)
            {
                Obje3.GetComponent<Opener>().isopen = 3;
                Obje4.SetActive(true);
                Obje4.transform.GetChild(0).gameObject.GetComponent<Text>().text = text1;
                Obje5.SetActive(false);
            }
            if (rety == 0)
            {
                rety++;
                Obje1.GetComponent<Text>().text = "Son olarak da Dünya’nın çevresini ölçelim de raporumuzu düzenlerken her şey çok daha kolay olsun.";
            }
            
        }
        if (i == 2)
        {
            Obje1.SetActive(true);
            Obje3.GetComponent<Text>().text = "Harikasın Görevleri Başarıyla tamamladın";
            Obje2.SetActive(false);
        }
        if(i == 3)
        {
            Obje1.SetActive(true);
            Obje2.GetComponent<Text>().text = "Şimdi de raporların özetini çıkarsak iyi olur. Senden sonra gelecek arkadaşların çok işine yarar.";
            Obje3.SetActive(true);
            Obje4.SetActive(false);
            Obje5.SetActive(false);
        }
        if(i == 4)
        {
            Obje2.SetActive(true);
            Obje2.transform.GetChild(2).gameObject.GetComponent<Roket>().Level = 3;
            Obje2.transform.GetChild(4).gameObject.SetActive(false);
            Obje2.transform.GetChild(5).gameObject.SetActive(true);
            Obje1.SetActive(false);
        }
    }

    public void SıralaBuyukluk()
    {
        Obje1.GetComponent<Text>().text = text1;
        Obje2.SetActive(true);
        Obje3.SetActive(false);
    }

    public void StoryManagemenet()
    {
        if(rety == 0)
        {
            rety++;
            Obje1.SetActive(true);
            Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Devam tuşuna tıklayarak dialoğu ilerletebilirsin.";
            Obje2.GetComponent<Text>().text = "Profesör ne oldu neden bu kadar endişelisiniz?";
        }
        else if(rety == 1)
        {
            rety++;
            Obje1.SetActive(false);
            Obje2.transform.parent.gameObject.SetActive(false);
            Obje3.SetActive(true);
        }
        else if(rety == 2)
        {
            rety++;
            Obje3.SetActive(false);
            Obje2.transform.parent.gameObject.SetActive(true);
            Obje2.transform.parent.gameObject.transform.parent.gameObject.transform.localPosition = new Vector3(-200,-108,0);
            Obje2.transform.parent.gameObject.transform.parent.gameObject.GetComponent<RectTransform>().rotation = new Quaternion(0, 0, 0, 0);
            Obje2.GetComponent<RectTransform>().rotation = new Quaternion(0,0,0,0);
            Obje2.GetComponent<Text>().text = "Bu problemi çözmemde yardım eder misin?";
            Obje4.GetComponent<Text>().text = "Evet, Olur";
        }
        else if(rety == 3)
        {
            rety++;
            Obje4.GetComponent<Text>().text = "Devam et";
            Obje5.GetComponent<Image>().sprite = sprite;
            Obje2.transform.parent.gameObject.SetActive(false);
            Obje2.transform.parent.gameObject.transform.parent.gameObject.transform.localPosition = new Vector3(149, 19, 0);
            Obje2.transform.parent.gameObject.transform.parent.gameObject.GetComponent<RectTransform>().rotation = new Quaternion(0, 180, 0, 0);
            Obje2.GetComponent<RectTransform>().rotation = new Quaternion(0, 180, 0, 0);
            Obje3.SetActive(true);
            Obje3.transform.localPosition = new Vector3(-180, 0, 0);
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yardım etmeyi kabul ettiğin için teşekkür ederiz.";
            Obje3.GetComponent<Image>().sprite = sprite2;
        }
        else if(rety == 4)
        {
            rety++;
            Obje2.GetComponent<RectTransform>().localRotation = new Quaternion(0, 180, 0, 0);
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sorun şu ki Aydaki ekibimizle iletişim ağımız koptu.";
        }
        else if(rety == 5)
        {
            rety++;
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yiyeceklerinin yeterli olup olmadığını bilmiyoruz.";
        }
        else if (rety == 6)
        {
            rety++;
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Biz son konuştuğumuzda Ay Dolunay evresindeydi.";
        }
        else if (rety == 7)
        {
            rety++;
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ve plana göre Ay Yeni Ay evresindeyken buraya geleceklerdi.";
        }
        else if (rety == 8)
        {
            rety++;
            Obje3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "14 günlük yiyeceklerinin kaldığını söylediler. Yiyecekler onlara yeter mi?";
        }
        else if (rety == 9)
        {
            rety++;
            Obje3.transform.GetChild(0).gameObject.SetActive(false);
            Obje2.transform.parent.gameObject.SetActive(true);
            Obje2.GetComponent<Text>().text = "Bu biraz karmaşık bir soru üstünde çalışayım cevabını vereceğim";
        }
        else if (rety == 10)
        {
            rety++;
            Obje3.SetActive(false);
            Obje2.GetComponent<Text>().text = "Bu sorunun cevabı için simülasyon odasına geldim. Ay simülasyonunu takip ederek bu görevi başarabileceğimize inanıyorum.";
            Obje2.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 95);
            Obje2.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 235);
            Obje2.transform.localPosition = new Vector3(0, 3.4f, 0);
            Obje2.transform.parent.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 160);
            Obje2.transform.parent.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 390);
            Obje2.transform.parent.gameObject.transform.localPosition = new Vector3(205, 145, 0);
            Obje5.GetComponent<Image>().sprite = sprite3;
            Obje2.transform.parent.gameObject.transform.parent.gameObject.transform.localPosition = new Vector3(75, -130, 0);
        }
        else if(rety == 11)
        {
            rety ++;
            Obje2.GetComponent<Text>().text = "Sen de hazırsan simülasyona başlayalım.";
            Obje4.GetComponent<Text>().text = "Simülasyona Başla";
        }
        else if(rety == 12)
        {
            Obje7.SetActive(true);
            Obje5.GetComponent<Image>().sprite = sprite4;
            Obje1.SetActive(true);
            Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Bu simülasyonda Ayın Evreleri’ni inceleyeceğiz. Ay’ı ok yönünde ve Dünya’nın etrafında ‘ilerle’ ve ‘dur’ butonlarını kullanarak hareket ettirebilirsin. Aynı zamanda Ay’ın üzerine tıklarsan Ay’ın o evresinin ismini de görebilirsin.";
            Obje1.transform.GetChild(0).gameObject.GetComponent<Text>().fontSize = 13;
            Obje6.SetActive(false);
            Obje8.SetActive(true);
            obje9.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 250);
            obje9.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 320);
            obje9.transform.localPosition = new Vector3(154,-28,0);
            obje10.GetComponent<Text>().text = "";
        }
    }

    public void moonevre()
    {
        if(rety == 0)
        {
            rety++;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if(rety == 1)
        {
            rety--;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void mooncontinue()
    {
        if(rety == 0)
        {
            rety++;
            Obje1.SetActive(true);
            Obje2.SetActive(true);
            Obje3.GetComponent<Text>().text = "SEÇ";
            Obje4.GetComponent<Text>().text = "Ekiple son konuştuğumuzda Ay Dolunay evresindeymiş. O zaman öncelikle simülasyondan Dolunay evresini bulalım. Haydi ilerlet butonuna tıkla ve Dolunay evresine gelince dur ve SEÇ.";

        }
        else if(rety == 1)
        {
            if(Obje1.GetComponent<ButtonsControl2>().rety == 2)
            {
                rety++;
                Obje6.SetActive(true);
                obje12.GetComponent<Opener>().Raporbool = false;
                obje12.GetComponent<Opener>().Rapor();
                Obje3.GetComponent<Text>().text = "Devam";
                Obje1.GetComponent<ButtonsControl2>().Start = true;
                Obje2.GetComponent<ButtonsControl2>().Start = true;
                Obje1.SetActive(false);
                Obje2.SetActive(false);
                Obje4.transform.parent.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
            else
            {
                Obje5.SetActive(true);
            }
        }
        else if(rety == 2)
        {
            rety++;
            Obje1.SetActive(true);
            Obje2.SetActive(true);
            Obje3.GetComponent<Text>().text = "SEÇ";
            Obje4.GetComponent<Text>().text = "Dolunay evresinden 14 gün ilerlersek hangi evreyi bulmuş oluruz? Evreyi Bul ve SEÇ butonuna tıkla.";
        }
        else if(rety == 3)
        {
            if (Obje1.GetComponent<ButtonsControl2>().rety == 6)
            {
                rety++;
                Obje1.SetActive(false);
                Obje2.SetActive(false);
                Obje6.SetActive(true);
                Obje3.GetComponent<Text>().text = "Bilgiyi Rapora Ekle";
                gameObject.SetActive(false);
            }
            else if(Obje1.GetComponent<ButtonsControl2>().rety > 6)
            {
                Obje5.SetActive(true);
                Obje5.transform.GetChild(0).gameObject.GetComponent<Text>().text = "2 hafta çoktan doldu bence geri butonunu kullanmalısın.";
            }
            else if(Obje1.GetComponent<ButtonsControl2>().rety < 2)
            {
                Obje5.SetActive(true);
                Obje5.transform.GetChild(0).gameObject.GetComponent<Text>().text = "2 hafta çoktan doldu bence geri butonunu kullanmalısın.";
            }
            else
            {
                Obje5.SetActive(true);
                Obje5.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Hayır, henüz 2 hafta olmadı. Biz 2 hafta ilerlemek istiyoruz çünkü ekibin tam 2 haftalık yiyeceği kalmıştı. Hadi ilerle butonuna tıklamaya devam et.";
            }
        }
        else if(rety == 4)
        {
            rety++;
            Obje3.GetComponent<Text>().text = "Rapora Eklemeye devam et";
            obje12.GetComponent<Opener>().Raporbool = false;
            obje12.GetComponent<Opener>().Rapor();
            Obje7.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "✓";
            Obje4.transform.parent.gameObject.SetActive(true);
            Obje4.GetComponent<Text>().text = "Onlar buraya geldiğinde Yeni Ay evresi olacaktı ve biz yiyecek onlara Yeni Ay evresine kadar yetebileceğini  bulduk. Bu durumda onlara yiyecek yetiyor!";
        }
        else if(rety == 5)
        {
            rety++;
            Obje3.GetComponent<Text>().text = "Devam";
            obje12.GetComponent<Opener>().Raporbool = false;
            obje12.GetComponent<Opener>().Rapor();
            Obje7.SetActive(true);
            Obje8.SetActive(true);
            obje9.SetActive(true);
            Obje4.transform.parent.gameObject.SetActive(false);
        }
        else if(rety == 6)
        {
            obje10.SetActive(true);
            obje11.GetComponent<Image>().sprite = sprite;
            gameObject.transform.parent.gameObject.SetActive(false);
        }
    }

    public void StoryManagement2()
    {
        if(rety == 0)
        {
            rety++;
            Obje1.GetComponent<Text>().text = "Sizin de gördüğünüz gibi Dolunaydan Yeni Ay evresine geçerken 14 günlük zaman dilimi var.";
        }
        else if (rety == 1)
        {
            rety++;
            Obje1.GetComponent<Text>().text = "Yani ekibin yiyecekleri onlar buraya gelene kadar yetecek. Endişelenecek hiçbir durum yok.";
        }
        else if (rety == 2)
        {
            rety++;
            Obje2.SetActive(false);
            Obje3.SetActive(true);
            Obje3.transform.parent.gameObject.GetComponent<Image>().sprite = sprite;
            Obje3.transform.parent.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 170);

        }
        else if(rety == 3)
        {
            rety++;
            Obje2.SetActive(true);
            Obje1.GetComponent<Text>().text = "Profesöre iyi haberleri verdik,şimdi de aynı sorunlar yaşanırsa onların kendi başına halledebilmesi için Ay’ın evrelerini içeren bir rapor hazırlayalım.";
            Obje1.GetComponent<Text>().fontSize = 12;
            gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Raporu Düzenle";
            Obje3.transform.parent.gameObject.SetActive(false);
        }
        else if(rety == 4)
        {
            Obje5.SetActive(true);
            Obje6.GetComponent<Image>().sprite = sprite2;
            Obje7.transform.parent.gameObject.SetActive(true);
            Obje7.GetComponent<Text>().text = "Sana bir ipucu verelim. Hazır olarak yerleşmiş evreler saat yönünün tersinde sırasıyla Ay’ın ana fazları olan İlk Dördün, Dolunay, Son Dördün ve Yeni Ay. Ara fazlar ise sağ tarafta.Onları sürükleyerek Ay’ın evreleri modelini tamamla.";
            Obje4.SetActive(false);
        }
    }

    public void ilerigeri(bool ileri)
    {
        if (rety != 2 || !Start)
        {
            Obje1.transform.GetChild(rety).gameObject.SetActive(false);
        }
        if (ileri)
        {
            if (rety < 7)
            {
                rety++;
            }
            else
            {
                rety = 0;
            }
        }
        else
        {
            if (rety > 0)
            {
                rety--;
            }
            else
            {
                rety = 7;
            }
        }
        Obje1.transform.GetChild(rety).gameObject.SetActive(true);
        Obje2.GetComponent<ButtonsControl2>().rety = rety;
    }

    public void Exıt()
    {
        Application.Quit();
    }
}
