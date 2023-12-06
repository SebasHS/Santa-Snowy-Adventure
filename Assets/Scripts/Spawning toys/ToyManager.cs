using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> listaObtenida = new List<string>();
    public List<string> listaPorObtener = new List<string>();
    public int nivel = 0;
    public int vida = 3;

    public static ToyManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        nextNivel();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void nextNivel()
    {
        nivel++;
        listaObtenida.Clear();
        switch (nivel)
        {
            case 1:
                listaPorObtener = new List<string> { "ToyBall(Clone)", "ToyBall(Clone)", "ToySkate(Clone)", "ToyBear(Clone)" };
                break;
            case 2:
                listaPorObtener = new List<string> { "ToySkate(Clone)", "ToyBear(Clone)", "ToySkate(Clone)", "ToyBear(Clone)", "ToyBall(Clone)" };
                break;
            default:
                break;
        }
    }

    public void QuitardeLista(string toy)
    {
        if (listaPorObtener.Contains(toy))
        {
            Debug.Log("Grabbed: " + toy);
            listaPorObtener.Remove(toy);
            listaObtenida.Add(toy);
        }
        if(listaPorObtener.Count == 0)
        {
            Debug.Log("Next level!");
            nextNivel();
        }
    }

    public void OneUP()
    {
        if(vida < 3)
        {
            vida++;
        }
    }

    public void gotHit()
    {
        vida--;
        if(vida == 0)
        {
            //ANGELO AQUI PANTALLA DE MUERTE
            Debug.Log("Death");
        }
    }


}
