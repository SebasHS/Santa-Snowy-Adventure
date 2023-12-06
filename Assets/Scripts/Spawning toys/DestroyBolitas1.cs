using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBolitas1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bomb(Clone)")
        {
            Debug.Log("Destroy: " + collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }
}
