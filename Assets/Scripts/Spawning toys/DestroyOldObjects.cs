using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOldObjects : MonoBehaviour
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
        if(collision.tag == "errores" || collision.tag == "Obstacles" )
        {
            Debug.Log("Destroy");
            Destroy(collision.gameObject);
        }
    }
}
