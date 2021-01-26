using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fearOfSpiders : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FSpider")
        {
            Destroy(this.gameObject);
        }
    }
}
