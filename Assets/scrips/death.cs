using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject wef;

    void OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag=="Player")
            SceneManager.LoadScene("Level Horror");
    }
}
