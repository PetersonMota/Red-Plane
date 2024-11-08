using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public PlayerController player;
    public GameObject menu;
    public GameObject hud;
    public GameObject credits;
    public GameObject gameEnvironemt;
    public GameObject pauseMenu;

    [Space]
    public Button startButton;
    public Button quitGameButton;
    public Button creditsButton;
    public Button quitCreditsButton;


    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.SetActive(false);
        hud.gameObject.SetActive(false);
        gameEnvironemt.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
        
        startButton.onClick.AddListener(StartGame);
        quitGameButton.onClick.AddListener(Quit);
        creditsButton.onClick.AddListener(Credits);
        quitCreditsButton.onClick.AddListener(QuitCredits);
    }

    void StartGame()

    {
        player.gameObject.SetActive(true);
        menu.gameObject.SetActive(false );
        hud.gameObject.SetActive(true);
        gameEnvironemt.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive (true);
    }

    void Quit()
    {
        Application.Quit();
    }

    void Credits ()
    { 
        credits.gameObject.SetActive (true);
        menu.gameObject.SetActive(false);
    }

    void QuitCredits()
    {
        credits.gameObject.SetActive (false);
        menu.gameObject.SetActive (true);
    }
}


