using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBolitas : MonoBehaviour
{
    public GameObject santa;
    [SerializeField] public int x, y, z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = santa.transform.TransformPoint(x, y, z);
    }

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Eliminate hit: " + collision.name);
        if (collision.gameObject.name == "Bomb(Clone)")
        {
            Debug.Log("Destroy: " + collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }
}
