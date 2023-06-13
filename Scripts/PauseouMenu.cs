using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseouMenu : MonoBehaviour
{
    public GameObject Win;
    public GameObject Pause;
    public GameObject Lost;
    public GameObject Config;

    void Update()
    {
        AbreFechapause();
    }

    void AbreFechapause() 
    {
        if(Player.perder == true && Playbut.losted == false) {
            Lost.SetActive(true);
            Playbut.losted = true;
            Playbut.jogocomeco = false;
        } else if (Playbut.jogocomeco == true) {
            if (Pontuação.pontos == 28) {
            Win.SetActive(true);
            Time.timeScale = 0f;
            Playbut.paused = true;
        } else if(Input.GetKeyDown(KeyCode.A) && Playbut.paused == false) {
            Pause.SetActive(true);
            Time.timeScale = 0f;
            Playbut.paused = true;
        } else if(Input.GetKeyDown(KeyCode.A) ) {
            Pause.SetActive(false);
            Win.SetActive(false);
            Config.SetActive(false);
            if (Playbut.jogocomeco == true) {
            Time.timeScale = 1f;
            }
            Playbut.paused = false;
        }
        }
    }
}
