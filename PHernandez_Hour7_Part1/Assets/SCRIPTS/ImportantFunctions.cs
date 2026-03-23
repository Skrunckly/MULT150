using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour

    
{
    // Start is called before the first frame update
    void Start()
    {

        int damage = 30;
        float speed = 10.0f;
        double rocketSpeed = 1004.4324243;
        bool gameOver = false;
        char someCharacter = 'A';
        string manyCharacters = " The night is dark and full of terrors";

        Debug.Log("damage value is" + damage);
        Debug.Log("speed:" + speed);
        Debug.Log("rocketSpeed:" + rocketSpeed);
        Debug.Log("is this game over?" + gameOver);
        Debug.Log("someCharacter:" + someCharacter);
        Debug.Log("manyCharacters:" + manyCharacters);

        

        int health;
        health = 100;

        int potion = 20;

        health = health - 30;// health -= 30;
        health = health + potion;// health += potion;

        Debug.Log("health is" + health);
        //Debug.Log("potion is" + potion); 
    }

// Update is called once per frame
void Update()
    {
        
    }
}
