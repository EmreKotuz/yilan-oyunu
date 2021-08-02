using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denemeCode : MonoBehaviour
{
    int hiz = 1;
    public GameObject arabaa;
    public GameObject jantÖn;
    public GameObject jantÖnn;
    public GameObject jantBir;
    public GameObject jantİki;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "duvar")
        {
            arabaa.transform.Rotate(0, 0, 0);

        }

    }

    // Update is called once per frame
    void Update()
    {
        arabaa.transform.Rotate(0, 2, 0);
        arabaa.transform.Translate(0,0,hiz*Time.deltaTime);
        jantBir.transform.Rotate(20, 0, 0);
        jantİki.transform.Rotate(20, 0, 0);
        jantÖn.transform.Rotate(5, 0, 0);
        jantÖnn.transform.Rotate(5, 0, 0);




    }
}
