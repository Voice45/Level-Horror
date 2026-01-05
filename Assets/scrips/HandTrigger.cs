using UnityEngine;
using System.Collections;

public class HandTrigger : MonoBehaviour
{


    public GameObject puthmOrSomthing;
    public GameObject pointerfinger;
    public GameObject mittlefinger;
    public GameObject ringfinger;
    public GameObject littelfinger;
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
            puthmOrSomthing.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            pointerfinger.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            mittlefinger.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            ringfinger.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            littelfinger.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
        }
    }

}
