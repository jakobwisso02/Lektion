using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    public bool ifBool;
    public int value;



    void Start()
    {
        if (ifBool == true)
        {
            print("Ja");
        }
        else
        {
            print("Nej");
        }



        /* if (value == 5)
         {
             print("hejsan");
         }

         else if (value == 4)
         {
             print("Hallå");
         }

         else if (value == 3)
         {
             print("hej");
         }

         else
         {
             print("tough luck");
         }*/




    }

    // Update is called once per frame
    void Update()
    {

        // != inte like med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och
        // || eller (alt gr <)

        if (Input.GetKeyDown(KeyCode.E))
        {
            value = (Random.Range(0, 10));
            print("Du tryckte på 'E'");
        }

        //if (value != 5)
        //{
        //    if(ifBool == true)
        //    {
        //        print("hejsan");
        //    }

        //}



        //    else if (value == 4)
        //    {
        //        print("Hallå");
        //    }

        //    else if (value == 3)
        //    {
        //        print("hej");
        //    }

        //    else
        //    {
        //        print("tough luck");
        //    }

    }
}
