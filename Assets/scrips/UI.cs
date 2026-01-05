using UnityEngine.SceneManagement;
using UnityEngine;


public class UI : MonoBehaviour
{

    void Start()
    {
        
    }

    public void Reset()
    {
        SceneManager.LoadScene("Level Horror");
        //EditorSceneManager.OpenScene("Level Horror");
    }

    public void Exit()
    {  
        //EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    void Update()
    {

    }
}
