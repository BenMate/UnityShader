using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public GameObject fireEffect;
    public GameObject pauseMenu;

    public GameObject cube;
    public Material rimLight;
    public Material electricity;

    MeshRenderer mesh;
    InputManagerTPS inputs;

    void Start()
    {
        inputs = InputManagerTPS.instance;
        mesh = cube.GetComponent<MeshRenderer>();
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
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        //lock the mouse if the game is paused
        Cursor.lockState = pauseMenu.gameObject.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
       
    }

    public void ToggleFirePitParticles()
    {
        fireEffect.SetActive(!fireEffect.activeSelf);
    }

    public void ChangeMatToElectricity()
    {
        mesh.material = electricity;
    }

    public void ChangeMatToRimLight()
    {
        mesh.material = rimLight;
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
