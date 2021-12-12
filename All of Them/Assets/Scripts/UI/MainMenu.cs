using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public static int alo;

    void Update()
    {
        Debug.Log(alo);
    }
    // *Set the Slider Volume
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volumeMaster", volume);
    }

    // *Go to LobbyScene
    public void goLobby() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    // *Quit the Game
    public void QuitGame()
    {
        Application.Quit();
    }

    
}
