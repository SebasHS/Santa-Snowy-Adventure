using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> listaObtenida = new List<string>();
    public List<string> listaPorObtener = new List<string>();
    public int nivel = 0;
    public int vida = 3;

    public AudioSource hurt;
    public AudioSource getGift;
    public AudioSource EatCookie;
    public AudioSource nextLevel;
     
    public GameObject grinch;

    public int grinchHealth;
    

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
        nextLevel.Play();
        listaObtenida.Clear();
        switch (nivel)
        {
            case 1:
                listaPorObtener = new List<string> { "ToyBall", "ToyBall", "ToySkate", "ToyBear" };
                break;
            case 2:
                listaPorObtener = new List<string> { "ToySkate", "ToyBear", "ToySkate", "ToyBear", "ToyBall" };
                break;
            case 3:
                grinch.SetActive(true);
                grinchHealth = 20; //20 hits
                break;
            default:
                break;
        }
    }

    public void QuitardeLista(string toy)
    {
        getGift.Play();
        if (listaPorObtener.Contains(toy))
        {
            Debug.Log("Grabbed: " + toy);
            listaPorObtener.Remove(toy);
            listaObtenida.Add(toy);
        }
        if(listaPorObtener.Count == 0 && nivel != 3)
        {
            Debug.Log("Next level!");
            nextNivel();
        }
    }

    public void OneUP()
    {
        EatCookie.Play();
        if(vida < 3)
        {
            vida++;
        }
    }

    public void gotHit()
    {
        hurt.Play();
        vida--;
        if(vida == 0)
        {
            //ANGELO AQUI PANTALLA DE MUERTE
            Debug.Log("Death");
        }
    }


}
