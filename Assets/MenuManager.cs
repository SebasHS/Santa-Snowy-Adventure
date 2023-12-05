using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject inicioButton;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ButtonAppear", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonAppear(){
        inicioButton.SetActive(true);
    }
}
