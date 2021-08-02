using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //sahneyi tekrar eklemeye yarıyor.
public class hareket : MonoBehaviour
{

    public GameObject kuyruk;
    List<GameObject> kuyruklar;
    public GameObject bitti_pnl;
    public GameObject ayarlarText;

    Vector3 eski_koordinat;
    GameObject eski_kuyruk;

    float hiz =18.0f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duvar")
        {
            bitti_pnl.SetActive(true);
            Time.timeScale=0.0f;
        }
        
        /*
        if (other.gameObject.tag == "kuyruk")
        {
            bitti_pnl.SetActive(true);
            Time.timeScale = 0.0f;
        }*/


    }

    public void ayarlar()
    {
        Time.timeScale = 0.0f;
        ayarlarText.SetActive(true);

    }
    public void devamEt()
    {
        Time.timeScale = 1.0f;
        ayarlarText.SetActive(false);
    }


    public void tekrar_oyna()
    {
        //hızını ve sahneyi eklemeye yarıyor.
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/giris"); 
    }

    // Start is called before the first frame update
    void Start()
    {

        kuyruklar = new List<GameObject>();

        //5 tane kuyruk ekleme kodu.
        for(int i = 0; i < 5; i++)
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);

            kuyruklar.Add(yeni_kuyruk);
        }

        InvokeRepeating("hareket_et", 0.0f, 0.1f); 
        
    }

    void hareket_et()
    {

        eski_koordinat = transform.position;
        transform.Translate(0,0, hiz * Time.deltaTime);
        //kuyrukları takip etmesini sağlıyor.
        kuyruk_takip();

    }
    void kuyruk_takip()
    {
        kuyruklar[0].transform.position = eski_koordinat;       //başının eski kordinatına gelmesini sağlıyor.
        eski_kuyruk = kuyruklar[0];
        kuyruklar.RemoveAt(0);
        kuyruklar.Add(eski_kuyruk);

    }

    public void kuyruk_artir()
    {
        //kuyruk artırmaya yarıyor
        GameObject yeni_kuyruk = Instantiate(kuyruk, transform.position, Quaternion.identity);

        kuyruklar.Add(yeni_kuyruk);
    }

    public void dondur(float aci)   
    {
        transform.Rotate(0, aci, 0);
    }

}
