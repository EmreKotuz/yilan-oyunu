using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelHareket : MonoBehaviour
{
    public GameObject engel_hareketi;
    hareket kuyruk_olustur;

    public TMPro.TextMeshProUGUI skor_eksilen;
    public TMPro.TextMeshProUGUI skop_finish;



    elma nesne;
    private void Start()
    {


        //elmanın kordinatını vermeye yarıyor.

        engel_kordinatı();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bas")//çarpılan nesneye değdiğinde
        {
            engel_kordinatı();

        }


        if (other.gameObject.tag == "kuyruk")//çarpılan nesneye değdiğinde
        {

            engel_kordinatı();

        }


    }

    void engel_kordinatı()
    {
        //engel kordinatını vermeye yarıyor.
        float x_deger = Random.Range(-6.0f, 2.0f);
        float z_deger = Random.Range(-7.0f, 0.0f);

        transform.position = new Vector3(x_deger, 3.43f, z_deger);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);

    }
}
