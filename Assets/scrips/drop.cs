using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour
{
    public GameObject DopppedObject;
    public AudioClip DropSound;
    public float speed = 1;

    bool Exit = false;


    void OnTriggerEnter(Collider other)
    {
        Exit = true;
        GetComponent<AudioSource>().PlayOneShot(DropSound);
    }

    void Update()
    {
        if (Exit)
        DopppedObject.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}