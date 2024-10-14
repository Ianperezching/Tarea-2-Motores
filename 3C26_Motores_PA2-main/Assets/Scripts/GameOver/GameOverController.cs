using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour
{
    public Button btnPlay;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => ReturnMenu());
        audioSource.Play();
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
