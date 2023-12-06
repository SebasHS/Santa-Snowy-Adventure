using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
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
        if (collision.name == "Santa")
        {
            Debug.Log("Hit: " + this.name);
            ToyManager.Instance.gotHit();
            Debug.Log("Destroy -----> " + this.name);
            Destroy(gameObject);
        }
    }
}
