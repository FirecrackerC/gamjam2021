using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiMovementRight : MonoBehaviour
{
    public float ran;

    void Start()
    {
        ran = Random.Range(0.003, 0.007);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ran, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destoy") 
        {
            Destroy(this.gameObject, 0.4f);
        }
    }
}
