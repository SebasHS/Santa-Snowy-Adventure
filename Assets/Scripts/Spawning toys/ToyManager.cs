using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ToyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> listaObtenida = new List<string>();
    public List<string> listaPorObtener = new List<string>();
    public int nivel = 0;
    public int vida = 3;
    public Image[] hearts;
    public Sprite fullHeart;

    public AudioSource hurt;
    public AudioSource getGift;
    public AudioSource EatCookie;
    public AudioSource nextLevel;

    public GameObject grinch;
    public GameObject CanvasUI;

    public int grinchHealth;
    public GameObject[] miniStorms;


    public static ToyManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
        nextNivel();
    }

    void Start()
    {
        StormDisable();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < vida)
            {
                hearts[i].sprite = fullHeart;
                hearts[i].color = new Color32(255, 255, 225, 255);
            }
            else
            {
                hearts[i].color = new Color32(255, 255, 225, 0);
            }
        }
    }

    public void StormDisable()
    {
        miniStorms = GameObject.FindGameObjectsWithTag("Storm");
        for (int i = 0; i < miniStorms.Length; i++)
        {
            miniStorms[i].SetActive(false);
        }
    }

    public void StormEnable()
    {
        //miniStorms = GameObject.FindGameObjectsWithTag("Storm");
        for (int i = 0; i < miniStorms.Length; i++)
        {
            miniStorms[i].SetActive(true);
        }
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
                grinchHealth = 100; //20 hits
                StormEnable();
                break;
            default:
                break;
        }
        CanvasUI.GetComponent<InGameUIManager>().LoadLevelUI();
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
        if (listaPorObtener.Count == 0 && nivel != 3)
        {
            Debug.Log("Next level!");
            nextNivel();
        }
    }

    public void OneUP()
    {
        EatCookie.Play();
        if (vida < 3)
        {
            vida++;
        }
    }

    public void gotHit()
    {
        hurt.Play();
        vida--;

        if (vida == 0)
        {
            //ANGELO AQUI PANTALLA DE MUERTE
            Debug.Log("Death");
        }
    }


}
