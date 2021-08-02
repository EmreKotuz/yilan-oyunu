using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elma : MonoBehaviour
{

    public TMPro.TextMeshProUGUI skor_txt;
    public TMPro.TextMeshProUGUI skop_finish;
    int skor = 10;
    public GameObject elma_hareketi;

    public TMPro.TextMeshProUGUI skorText;


    hareket kuyruk_olustur;

    private void Start()
    {
        kuyruk_olustur = GameObject.Find("bas").GetComponent<hareket>();

        //elmanın kordinatını vermeye yarıyor.
        kordinat_degistir();

    }

    //z 2,6 x 1,6
    private void OnTriggerEnter(Collider other)
    {

  


        if (other.gameObject.name == "bas")//çarpılan nesneye değdiğinde
        {
            //skoru 10 puan yükseltsin.
            skor += 10; 
            skor_txt.text = "SKOR " + skor;

            kordinat_degistir();
            kuyruk_olustur.kuyruk_artir();

            skop_finish.text=skor_txt.text;

        }

        if (other.gameObject.tag == "engel")//çarpılan nesneye değdiğinde
        {
            //skoru 10 puan yükseltsin.
            skor -= 10;
            skorText.text = "SKOR " + skor;

            kordinat_degistir();

            skop_finish.text = skor_txt.text;

        }

    
    }
    void kordinat_degistir()
    {
        //elmanın kordinatını vermeye yarıyor.
        float x_deger = Random.Range(-6.0f, 2.0f);
        float z_deger = Random.Range(-7.0f, 0.0f);

        transform.position = new Vector3(x_deger, 3.43f, z_deger);
    }



    private void Update()
    {
        transform.Rotate(0, 3, 0);


        if (skor <= 1)
        {
            Time.timeScale = 0.0f;
        }

    }


}
