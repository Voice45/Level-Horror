using UnityEngine;
using System.Collections;

public class endgame : MonoBehaviour
{
    public GameObject EndScren;
    public GameObject Endcam;
    public GameObject player;
    public GameObject DropIt;
    bool GameEnd = false;

    void Start()
    {
        EndScren.SetActive(false);
        player.SetActive(true);
        Endcam.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        EndScren.SetActive(true);
        player.SetActive(false);
        Endcam.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        GameEnd = true;

    }

    void Update()
    {
        if (GameEnd)
            DropIt.transform.Translate(Vector3.down * 5 * Time.deltaTime, Space.World);
    }
}
