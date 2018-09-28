using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovning : MonoBehaviour
{
    //uppgift1
    public int userValue;

    //uppgift2
    public int value;
    public int value2;
    public int absoluteValue;

    //uppgift3
    public int dragonHealth;
    public int playerHealth = 100;
    public int dragonDamage;
    public int playerDamage;
    public int dragonHit;

    //uppgift4
    public int dragonDoubleHp;
    public int playerCritChance;

    // Use this for initialization
    void Start()
    {
        //uppgift4
        dragonHealth = Random.Range(100, 151);
        dragonDoubleHp = Random.Range(1, 11);


        //Drakens chans att få 2x hp
        if (dragonDoubleHp == 1)
        {
            dragonHealth = dragonHealth * 2;
            Debug.Log("The dragon dabbed on the haters and is now two times as powerful.");            
        }

        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Random.Range(min, max)
        //Input.GetKeyDown(key)

        
        
        //uppgift1
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            userValue = userValue + 2;
            Debug.Log("Uppgift 1a: " + userValue);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            userValue = userValue / 2;
            Debug.Log("Uppgift 1b: " + userValue);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            userValue = userValue;
            Debug.Log("Uppgift 1c: " + userValue);
        }

        
        
        //uppgift2
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Uppgift 2: Tärningsspel");
            value = Random.Range(1, 7);
            value2 = Random.Range(1, 7);
            absoluteValue = absoluteValue + (value - value2);
            Debug.Log("Dice 1: " + value);
            Debug.Log("Dice 2: " + value2);
            Debug.Log("Sum: " + absoluteValue);

            if (absoluteValue >= 20)
            {
                Debug.Log("You win!");
            }

            if (absoluteValue <= 0)
            {
                Debug.Log("Game Over");
            }
        }

        
        
        //uppgift3-4
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHealth = playerHealth;
            dragonDamage = Random.Range(10, 21);
            playerDamage = Random.Range(5, 26);
            dragonHit = Random.Range(1, 3);



            //Drakens hits
            if (dragonHit == 1)
            {
                Debug.Log("The dragon hit the player for " + dragonDamage + " damage. The player's health is now " + (playerHealth = (playerHealth - dragonDamage)));
            }

            else
            {
                Debug.Log("The dragon missed. The player's health is now " + playerHealth);
                dragonDamage = 0;
            }



            //Spelarens hits
            Debug.Log("The player hit the dragon for " + playerDamage +
                " damage. The dragon's health is now " + (dragonHealth = (dragonHealth - playerDamage)));



            //Resultat
            if (dragonHealth <= 0)
            {
                Debug.Log("The player has slain the dragon.You win!");
            }

            if (playerHealth <= 0)
            {
                Debug.Log("The player was killed by the dragon... Game Over.");
            }

        }

    }
}
