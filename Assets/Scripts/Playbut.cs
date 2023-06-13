using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playbut : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Lost;
    public GameObject Config;
    public GameObject Menu;
    public GameObject Ponts;
    public static bool paused = false;
    public static bool jogocomeco;
    public static bool reinicio = false;
    public static bool losted;
    public Button Play1, Play2, Restart, Config2, Config1, Config3, Exitconfig, Exit1, Exit2, Exit3;
    // Start is called before the first frame update
    void Start()
    {
        Config1.onClick.AddListener(Configclicked);
        Config2.onClick.AddListener(Configclicked);
        Config3.onClick.AddListener(Configclicked);
        Exitconfig.onClick.AddListener(exitconfiged);
        Exit1.onClick.AddListener(Exitclicked);
        Exit2.onClick.AddListener(Exitclicked);
        Exit3.onClick.AddListener(Exitclicked);
        Play1.onClick.AddListener(Playclicked);
        Play2.onClick.AddListener(Playclicked);
        Restart.onClick.AddListener(Restartcliclked);
        paused = false;
        
    }

    void Configclicked() 
    {
        Lost.SetActive(false);
        Config.SetActive(true);
        Pause.SetActive(false);
        Menu.SetActive(false);
    }

    void exitconfiged() 
    {
        Config.SetActive(false);
        if ( losted == true) {
            Lost.SetActive(true);
        } else if ( jogocomeco == false) {
            Menu.SetActive(true);
        } else {
            Pause.SetActive(true);
        }
    }

    void Exitclicked() 
    {
        Debug.Log("saiu do jogo");
    }

    void Playclicked() 
    {
        if (paused == true) {
            Pause.SetActive(false);
            paused = false;
        }
        Menu.SetActive(false);
        Time.timeScale = 1f;
        reinicio = false;
        jogocomeco = true;
        Ponts.SetActive(true);
    }

    void Restartcliclked() 
    {
        reinicio = true;
        jogocomeco = false;
        Player.perder = false;
        losted = false;
        Lost.SetActive(false);
        Config.SetActive(false);
        Pause.SetActive(false);
        Menu.SetActive(true);
        Debug.Log("Reiniciou o jogo");
    }
}
