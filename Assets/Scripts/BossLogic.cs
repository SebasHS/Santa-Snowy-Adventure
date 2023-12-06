using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject santa;
    public int x, y, z;

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
        Debug.Log("Grinch hit: " + collision.name);
        if(collision.name == "Bomb(Clone)")
        {
            ToyManager.Instance.grinchHealth--;
            if(ToyManager.Instance.grinchHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
