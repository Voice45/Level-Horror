using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour
{
    public GameObject DopppedObject;
    public float speed = 2;

    bool Exit = false;


    void OnTriggerExit(Collider other)
    {
        Exit = true;
        Debug.Log("Still Works");
    }

    void Update()
    {
        if (Exit)
        DopppedObject.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}