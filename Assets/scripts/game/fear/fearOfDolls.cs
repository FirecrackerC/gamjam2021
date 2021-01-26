using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fearOfDolls : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "FDoll")
        {
            Destroy(this.gameObject);
        }
    }
}
