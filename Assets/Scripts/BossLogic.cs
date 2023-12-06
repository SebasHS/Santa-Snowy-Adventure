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


}
