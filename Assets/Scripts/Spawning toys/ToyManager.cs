using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> listaObtenida = new List<string>();
    public List<string> listaPorObtener = new List<string>();

    public static ToyManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitardeLista(string toy)
    {
        Debug.Log("Grabbed: " + toy);
        //listaPorObtener.Remove(toy);
        listaObtenida.Add(toy);
    }

}
