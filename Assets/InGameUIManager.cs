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
        string gax ="";
        foreach (var regalo in RegalosRecoger)
        {
           gax +=  regalo + ",";
        }
        Debug.Log(gax);
        Debug.Log(regaloRecogido);
        Debug.Log(RegalosRecoger.Contains(regaloRecogido)); 
        if (RegalosRecoger.Contains(regaloRecogido)){
        int index = RegalosRecoger.IndexOf(regaloRecogido);
        Debug.Log(index);
        Debug.Log(RegalosRecoger[index]);
        if (index != -1)
        {
            RegalosRecoger[index] = "R" + RegalosRecoger[index];
            Debug.Log(RegalosRecoger[index]);
            writeRegalos();
        }}

    }
    public void getRegalos(List<string> regalos)
    {
        RegalosRecoger = regalos;
        string gax ="";
        foreach (var regalo in RegalosRecoger)
        {
           gax +=  regalo + ",";
        }
Debug.Log(gax);
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
