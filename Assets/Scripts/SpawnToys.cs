using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnToys : MonoBehaviour
{
    [SerializeField] private float SpawnCooldown = 7f;
    private float canSpawn = -1f;
    [SerializeField] private int cantidad = 1;
    [SerializeField] private GameObject toy1;
    [SerializeField] public int x, y, z;
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        //Tiempo();
    }
/*
    void Tiempo()
    {
        //Debug.Log("Time: " + Time.time);
        if (canSpawn < Time.time)
        {
            canSpawn = Time.time + SpawnCooldown;
            
        }
    }*/

    void Spawner()
    {
        Instantiate(toy1, transform.position, transform.rotation);
    }

    private void FixedUpdate()
    {
        Vector3 vex = new Vector3(x, y, z);
        transform.Translate(vex * speed * Time.deltaTime);
        //transform.Translate(x, y, z);
    }
}
