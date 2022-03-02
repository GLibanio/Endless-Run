using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button_Shop : MonoBehaviour
{
    public List<GameObject> player_Male;
    public List<GameObject> player_Female;
    public List<TextMeshProUGUI> Textos;
    public List<bool> Comprado;

    public void Male1()
    {
        if(GameController.Moeda_Total >= 1000 && !Comprado[0])
        {
            GameController.Moeda_Total -= 1000;
            Comprado[0] = true;
        }

        if(Comprado[0])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
                if (Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[0].text = "Selecionado";

            player_Male[0].SetActive(true);
            player_Male[1].SetActive(false);
            player_Male[2].SetActive(false);
            player_Female[0].SetActive(false);
            player_Female[1].SetActive(false);
            player_Female[2].SetActive(false);
        }
    }

    public void Male3()
    {
        if (GameController.Moeda_Total >= 2000 && !Comprado[1])
        {
            GameController.Moeda_Total -= 2000;
            Comprado[1] = true;
        }

        if (Comprado[1])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
                if (Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[1].text = "Selecionado";

            player_Male[0].SetActive(false);
            player_Male[1].SetActive(true);
            player_Male[2].SetActive(false);
            player_Female[0].SetActive(false);
            player_Female[1].SetActive(false);
            player_Female[2].SetActive(false);
        }
    }
    public void Male5()
    {
        if (GameController.Moeda_Total >= 5000 && !Comprado[2])
        {
            GameController.Moeda_Total -= 5000;
            Comprado[2] = true;
        }

        if (Comprado[2])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
               if (Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[2].text = "Selecionado";

            player_Male[0].SetActive(false);
            player_Male[1].SetActive(false);
            player_Male[2].SetActive(true);
            player_Female[0].SetActive(false);
            player_Female[1].SetActive(false);
            player_Female[2].SetActive(false);
        }
        
    }
    public void Female4()
    {
        if (GameController.Moeda_Total >= 1500 && !Comprado[3])
        {
            GameController.Moeda_Total -= 1500;
            Comprado[3] = true;
        }  
        if (Comprado[3])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
                if(Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[3].text = "Selecionado";

            player_Male[0].SetActive(false);
            player_Male[1].SetActive(false);
            player_Male[2].SetActive(false);
            player_Female[0].SetActive(true);
            player_Female[1].SetActive(false);
            player_Female[2].SetActive(false);
        }
    }
    public void Female5()
    {
        Comprado[4] = true;
        
        if(Comprado[4])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
                if (Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[4].text = "Selecionado";

            player_Male[0].SetActive(false);
            player_Male[1].SetActive(false);
            player_Male[2].SetActive(false);
            player_Female[0].SetActive(false);
            player_Female[1].SetActive(true);
            player_Female[2].SetActive(false);
        }
    }
    public void Female6()
    {
        if (GameController.Moeda_Total >= 3000 && !Comprado[5])
        {
            GameController.Moeda_Total -= 3000;
            Comprado[5] = true;
        }

        if(Comprado[5])
        {
            for (int i = 0; i < Textos.Count; i++)
            {
                if (Textos[i].text == "Selecionado")
                    Textos[i].text = "Selecionar";
            }
            Textos[5].text = "Selecionado";

            player_Male[0].SetActive(false);
            player_Male[1].SetActive(false);
            player_Male[2].SetActive(false);
            player_Female[0].SetActive(false);
            player_Female[1].SetActive(false);
            player_Female[2].SetActive(true);
        }
    }
}
