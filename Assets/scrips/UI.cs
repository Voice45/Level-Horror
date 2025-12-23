using UnityEditor.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.SceneManagement;

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

    void Update()
    {

    }
}
