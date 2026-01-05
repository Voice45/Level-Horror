using UnityEngine;
using System.Collections;

public class LegTrigger : MonoBehaviour
{
    public GameObject UpperLeg;
    public GameObject LowerLeg;
    public GameObject Foot;
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
            UpperLeg.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            LowerLeg.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
            Foot.transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
        }
    }
}
