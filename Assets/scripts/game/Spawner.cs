using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject AiLeft;
    public GameObject AiRight;

    private Vector3 LocLeft;
    private Vector3 LocRight;

    void Start()
    {
        LocLeft  = new Vector3(16, 4, 0); 
        LocRight = new Vector3(-18, 4, 0);

        invoke();
    }

    private void invoke() 
    {
        Invoke("spawn", 1f);
        Invoke("Return", 1f);
    }

    void Return() 
    {
        invoke();
    }

    void spawn()
    {       
        int ran = Random.Range(0, 5);

        if (ran == 1)
        {
            print("1");

            int Amount = Random.Range(0, 3);

            for (int i = 0; i < Amount; i++)
            {
                Instantiate(AiLeft, LocLeft, Quaternion.identity);
            }
        }

        if (ran == 3)
        {
            print("2");

            int Amount = Random.Range(0, 3);

            for (int i = 0; i < Amount; i++)
            {
                Instantiate(AiRight, LocRight, Quaternion.identity);
            }
        }

        if (ran == 5)
        {
            print("5");

            int Three = Random.Range(0, 2);
            int Amount = Random.Range(0, 3);

            if (Three == 1) 
            {
                for (int i = 0; i < Amount; i++)
                {
                    Instantiate(AiLeft, LocLeft, Quaternion.identity);
                }
            }

            if (Three == 1)
            {
                for (int i = 0; i < Amount; i++)
                {
                    Instantiate(AiRight, LocRight, Quaternion.identity);
                }
            }

            if (ran == 2 || ran == 4) 
            {
                print("niks");
            }
        }
    }  
}
