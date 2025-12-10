using UnityEditor.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{

public GameObject PauseMenu;
public GameObject player;
public GameObject UIcam;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseMenu.SetActive(false);
        player.SetActive(true);
        UIcam.SetActive(false);
        
    }


    public void Reset()
    {
        Debug.Log("brrrrrrrrrrrr");
        SceneManager.LoadScene("Level Horror");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
            player.SetActive(false);
            UIcam.SetActive(true);
            
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Level Horror");
            Time.timeScale = 1;
        }
    }
}
