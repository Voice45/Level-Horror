using UnityEngine;
using System.Collections;

public class Final : MonoBehaviour
{
    public GameObject DopppedObject1;
    public GameObject DopppedObject2;
    public GameObject DopppedObject3;
    public GameObject DopppedObject4;
    public GameObject DopppedObject5;
    public float speed = 2;

    bool Enter = false;

    void OnTriggerEnter(Collider other)
    {
        Enter = true;
        Debug.Log("Enter");
    }

    void Update()
    {
        if (Enter==true)
        {
            DopppedObject1.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            DopppedObject2.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            DopppedObject3.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            DopppedObject4.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            DopppedObject5.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        }
    }
}