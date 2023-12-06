using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private TextMeshProUGUI textRegalos;
    private string valor;
    private List<string> RegalosRecoger;
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
    public void LoadRegalosUI(List<string> regalos)
    {
        getRegalos(regalos);
        writeRegalos();

    }
    public void TacharRegaloUI(string regaloRecogido)
    {
    
        if (RegalosRecoger.Contains(regaloRecogido)){
        int index = RegalosRecoger.IndexOf(regaloRecogido);
        if (index != -1)
        {
            //RegalosRecoger[index] = "R" + RegalosRecoger[index];
            //RegalosRecoger.Remove(regaloRecogido);
            writeRegalos();
        }}

    }
    public void getRegalos(List<string> regalos)
    {
        RegalosRecoger = regalos;
    }
    public void writeRegalos()
    {
        textRegalos.text = "Regalos: " + "\n";
        foreach (var regalo in RegalosRecoger)
        {
            if (regalo == "ToyBall")
            {
                valor = "Pelota";
            }
            else if (regalo == "ToySkate")
            {
                valor = "Skate";
            }
            else if (regalo == "ToyBear")
            {
                valor = "Oso de peluche";
            }
            else if (regalo == "ToyCar")
            {
                valor = "Carro";
            }
            else if (regalo == "RToyBall")
            {
                valor = StrikeThrough("Pelota");
            }
            else if (regalo == "RToySkate")
            {
                valor = StrikeThrough("Skate");
            }
            else if (regalo == "RToyBear")
            {
                valor = StrikeThrough("Oso de peluche");
            }
            else if (regalo == "RToyCar")
            {
                valor = "Carro";
            }
            else
            {
                valor = "valornoexistente";
            }
            textRegalos.text += "-" + valor + "\n";
        }
    }
    public string StrikeThrough(string value)
    {
        string word = "";
        foreach (var character in value)
            word += character + "\u0336";

        return word;
    }
}
