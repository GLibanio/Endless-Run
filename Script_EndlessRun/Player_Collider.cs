using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player_Collider : MonoBehaviour
{
    Animator Anim;
    public TextMeshProUGUI moedas;
    public TextMeshProUGUI moedas_Totais;
    public int moeda;
    

    private void Start()
    {
        Anim = GetComponent<Animator>();
        GetComponent<Player_Movement>().perdeu = false;
        Anim.SetBool("Bater", false);
    }
    void Update()
    {
        moedas.text = moeda.ToString();
        moedas_Totais.text = GameController. Moeda_Total.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            moeda += 1;
            GameController.Moeda_Total += 1;
        }
        if (other.gameObject.CompareTag("Obstaculo"))
        {
            GetComponent<Player_Movement>().perdeu = true;
            Anim.SetBool("Bater", true);
            Invoke("Resetar", 3f);
        }
    }

    void Resetar()
    {
        SceneManager.LoadScene(0);
    }
}
