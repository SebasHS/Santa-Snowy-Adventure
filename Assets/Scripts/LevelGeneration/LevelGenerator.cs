using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Terreno;
    private float index = 0;


    private void Awake()
    {
        //Aparecer los terrenos iniciales
        SpawnTerreno(Terreno, new Vector3(0, 0, 0));
        SpawnTerreno(Terreno, new Vector3(-300, -100, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnTerreno(GameObject terreno, Vector3 position)
    {
        Instantiate(terreno);
        terreno.transform.position = position;
    }
}
