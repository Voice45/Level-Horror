using UnityEngine;
using System.Collections;

public class armTrigger : MonoBehaviour
{
   

    public GameObject UpperArm;
    public GameObject LowerArm;
    public GameObject Hand;
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
            UpperArm.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            LowerArm.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            Hand.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
        }
    }

}
