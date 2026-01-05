using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour
{
    public GameObject DopppedObject;
    public AudioClip DropSound;
    public float speed = 2;

    bool Exit = false;


    void OnTriggerExit(Collider other)
    {
        Exit = true;
        GetComponent<AudioSource>().PlayOneShot(DropSound);
        Debug.Log("Still Works");
    }

    void Update()
    {
        if (Exit)
        DopppedObject.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}