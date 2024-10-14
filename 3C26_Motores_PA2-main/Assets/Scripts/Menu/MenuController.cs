using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button btnPlay;
    public GameObject SonidoMenu;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => Play());
        audioSource.Play();
    }

    void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void About()
    {
        SonidoMenu.SetActive(true);
    }
    public void Aboutclose()
    {
        SonidoMenu.SetActive(false);
    }
}
