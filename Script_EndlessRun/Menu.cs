using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Menu_GO;
    public GameObject Shop_GO;
    void Start()
    {
        Menu_GO.SetActive(true);
        Shop_GO.SetActive(false);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu_GO.SetActive(true);
            Shop_GO.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void Comecar()
    {
        Menu_GO.SetActive(false);
        Time.timeScale = 1;
    }

    public void Shop()
    {
        Shop_GO.SetActive(true);
        Menu_GO.SetActive(false);
    }

    public void voltar()
    {
        Menu_GO.SetActive(true);
        Shop_GO.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
