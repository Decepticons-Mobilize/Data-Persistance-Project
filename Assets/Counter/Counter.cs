using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;
    string[] strings = new string[3];

    
    private void Start()
    {
        Count = 0;
        StartCoroutine(MyCoroutine());
    }

    private IEnumerator MyCoroutine() 
    { 
            yield return new WaitForSeconds(5);
        Debug.Log("Nice");
        StartCoroutine(MyCoroutine());
    }
    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }
}
