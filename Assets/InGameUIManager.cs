using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private TextMeshProUGUI textRegalos;
    private string valor;
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
    public void LoadRegalosUI(List<string> ga){
        textRegalos.text = "Regalos: " + "\n";
        foreach(var i in ga){
            if(i =="ToyBall"){
                valor="Pelota";
            }else if(i == "ToySkate"){
                valor ="Skate";
            }else if(i == "ToyBear"){
                valor= "Oso de peluche";
            }else{
                valor="valornoexistente";
            }
            textRegalos.text += "-"+valor +"\n";
        }
    }
}
