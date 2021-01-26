using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiMovementLeft : MonoBehaviour
{
    private bool Walk;

    void Start()
    {
        Walk = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Walk)
        {
            transform.Translate(-0.005f, 0, 0);
        }

        if (Walk)
        {
            transform.Translate(0, 0.015f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destoy")
        {
            Destroy(this.gameObject, 0.4f);
        }

        if (other.gameObject.tag == "Stair")
        {
            Walk = true;
        }
    }
}
