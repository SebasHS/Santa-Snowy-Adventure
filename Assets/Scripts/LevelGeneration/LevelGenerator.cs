using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Terreno;
    private float index = 0;
    float yNewPosition = -100.5f;
    float xNewPosition = -300;


    private void Awake()
    {
        //Aparecer los terrenos iniciales
        SpawnTerreno(Terreno, new Vector3(0, 0, 0));
        //SpawnTerreno(Terreno, new Vector3(-300, -100, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x >= index)
        {
            Debug.Log("crear terreno");
            SpawnTerreno(Terreno, new Vector3(-299.5f, yNewPosition, 0));
            index += 300;
            xNewPosition -= 300;
            yNewPosition -= 100.5f;
            //Debug.Log("Nivel generate: " + );
            if (ToyManager.Instance.nivel != 3)
            {
                ToyManager.Instance.StormDisable();
            }
            else
            {
                ToyManager.Instance.StormEnable();
            }
        }
    }
    private void SpawnTerreno(GameObject terreno, Vector3 position)
    {
        GameObject terrenoCreado = Instantiate(terreno, transform);
        terrenoCreado.transform.position = position;
        //Debug.Log("Nivel generate: " + ToyManager.Instance.nivel);
        /**/
    }
}
