using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private int currentLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoadLevelUI()
    {
        textLevel.text = "Level " + ToyManager.Instance.nivel;
    }
}
