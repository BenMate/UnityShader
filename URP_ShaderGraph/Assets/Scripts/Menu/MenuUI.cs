using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public GameObject fireEffect;
    public GameObject pauseMenu;

    bool isPMActive;
    bool isPitActive;

    InputManagerTPS inputs;

    

    void Start()
    {
        isPMActive = false;
        isPitActive = true;

        inputs = InputManagerTPS.instance;
    }

    void Update()
    {
        if (inputs.pause)
        {
            //if the player pressed escape Toggle PauseMenu
            TogglePauseMenu();
            inputs.pause = false;
        }
                
    }

    public void TogglePauseMenu()
    {
        isPMActive = !isPMActive;
        pauseMenu.SetActive(isPMActive);

        //lock the mouse if the game is paused
        Cursor.lockState = pauseMenu.gameObject.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
       
    }

    public void ToggleFirePitParticles()
    {
        isPitActive = !isPitActive;
        fireEffect.SetActive(isPitActive);
    }

}
