using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject dollLeft;
    public GameObject dollRight;

    private Vector3 spawnLeft;
    private Vector3 spawnRight;

    // Start is called before the first frame update
    void Start()
    {
        spawnLeft  = new Vector3 (-11.6f, 3, 0.3f) ;
        spawnRight = new Vector3 (10.4f, 2.5f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        //Ik moet nog even kijken hoe ik void spawn wil aanspreken en hoevaak.
        //Ik moet nog even kijken hoe ik void spawn wil aanspreken en hoevaak.
        //Ik moet nog even kijken hoe ik void spawn wil aanspreken en hoevaak.
        //Ik moet nog even kijken hoe ik void spawn wil aanspreken en hoevaak.
        //Ik moet nog even kijken hoe ik void spawn wil aanspreken en hoevaak.
    }

    void spawn()
    {
        int ran = Random.Range(0, 5);

        if (ran == 1)
        {
            Instantiate(dollLeft, spawnLeft, Quaternion.identity);
            print("left1");
        }

        if (ran == 3)
        {
            Instantiate(dollRight, spawnRight, Quaternion.identity);
            print("right1");
        }

        if (ran == 5)
        {
            int man = Random.Range(0, 2);

            if (man == 1)
            {
                Instantiate(dollLeft, spawnLeft, Quaternion.identity);
                print("left2");
            }

            if (man == 2)
            {
                Instantiate(dollRight, spawnRight, Quaternion.identity);
                print("right1");
            }
        }
    }
}
