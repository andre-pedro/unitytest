using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintHello());
        StartCoroutine(UpTo30());
    }

    private IEnumerator PrintHello()
    {
        WaitForSeconds wfs = new WaitForSeconds(4);
        while(true)
        {
            Debug.Log("Hello");
            yield return wfs;
        }
    }
    private IEnumerator UpTo30()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        for (int i = 0; i <= 30; i++)
        {
            Debug.Log(i);
            yield return wfs;
        }
    }
}
