using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class killbox : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inplayer)
        {
            time += Time.deltaTime;
        }
    }

    public GameObject wef;
    bool inplayer = false;
    public float time = 0;

    public GameObject sound;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            inplayer = true;

            if (time >= 10)
            {
                sound.SetActive(true);
            }
            if (time >= 11)
            {
                SceneManager.LoadScene("Level Horror");
            }
        } 
    }
}
