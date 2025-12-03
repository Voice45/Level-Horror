using UnityEditor.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{

public GameObject PauseMenu;
public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseMenu.SetActive(false);
        GameObject player = GameObject.Find("player");
        player.GetComponent<FirstPersonController>().enabled = true;
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
            FirstPersonController fpc = player.GetComponent<FirstPersonController>();
            fpc.lockCursor = false;
        }
    }
}
