using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int d =1; d <=31; d++)
        {
            if (d == 24)
            {
                Debug.Log("It's my birthday!!! C:  ");
            }
            Debug.Log(d);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
