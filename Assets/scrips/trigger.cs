using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject[] lims;
    public float speed = 2;

    public bool OnEnter = false;
            bool Enter = false;

    void OnTriggerExit(Collider other)
    {
        Enter = true;
        Debug.Log("Enter");
    }

    void OnTriggerEnter(Collider other)
    {
        Enter = true;
        Debug.Log("Enter");
    }

    void Update()
    {
        if (Enter==true && OnEnter)
        {
            foreach (GameObject limb in lims)
            {
                limb.transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
            }
        }

        if (Enter==true && !OnEnter)
        {
            foreach (GameObject limb in lims)
            {
                limb.transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
            }
        }
    }
}

//lims[4].transform.Rotate(Vector3.forward * speed * -1* Time.deltaTime);
