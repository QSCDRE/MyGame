using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Podscaska : MonoBehaviour
{
    public GameObject zvuk1;
    public GameObject zvuk2;
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q11;
    public GameObject q12;
    public GameObject q13;
    public GameObject q14;
    public GameObject q15;
    private int q;

    public void Update()
    {

        if (q11 == null && q12 == null && q13 == null && q14 == null && q15 == null)
        {
            zvuk2.SetActive(true);
            q2.SetActive(false);
            q3.SetActive(true);

        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        zvuk1.SetActive(true);
        Destroy(gameObject);
        q1.SetActive(false);
        q2.SetActive(true);
        

        




            

    }
}
