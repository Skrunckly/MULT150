using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int A = 2;
        int B = 4;
        int C = 8;
        int SUM = 14;
        SUM = A + B + C;
        SUM++;
        Debug.Log(SUM);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
