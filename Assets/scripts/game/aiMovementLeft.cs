using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiMovementLeft : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.005f, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destoy")
        {
            Destroy(this.gameObject, 0.4f);
        }
    }
}
