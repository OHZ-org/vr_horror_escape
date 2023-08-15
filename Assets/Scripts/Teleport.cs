using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject target;
    public GameObject dest;
    public GameObject dest2;
    private bool triedtel;
    private bool triedtel2;
    public Fadeinout fade;
    // Start is called before the first frame update
    void Start()
    {
        fade= GetComponent<Fadeinout>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Door1.opened&&!triedtel)
        {
            StartCoroutine(telpo1to2());
            fade.Fade();
        }
        else if(Door2.opened&&!triedtel2)
        {
            StartCoroutine(telpo2to3());
            fade.Fade(); 
        }
    }

    IEnumerator telpo1to2()
    {   
        yield return new WaitForSeconds(1f);
        target.transform.position=dest.transform.position;
        triedtel = true;
    }
    IEnumerator telpo2to3()
    {
        yield return new WaitForSeconds(1f);
        target.transform.position = dest2.transform.position;
        triedtel2 = true;
    }
}
