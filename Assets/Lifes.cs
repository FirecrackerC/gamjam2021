using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifes : MonoBehaviour
{
    public int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    private void Update()
    {
        if (lives == 0) 
        {
            //restart
            //quit
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Doll") 
        {
            lives--;
        }
    }
}
