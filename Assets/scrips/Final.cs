using UnityEngine;
using System.Collections;

public class Final : MonoBehaviour
{
    public GameObject DopppedObject1;
    public GameObject DopppedObject2;
    public GameObject DopppedObject3;
    public GameObject DopppedObject4;
    public GameObject DopppedObject5;
    public GameObject Sound1;
    public GameObject Sound2;
    public GameObject Sound3;
    public GameObject Sound4;
    public GameObject Sound5;
    public float speed = 2;

    bool Enter = false;

    void Start()
    {
        Sound1.SetActive(false);
        Sound2.SetActive(false);
        Sound3.SetActive(false);
        Sound4.SetActive(false);
        Sound5.SetActive(false);
    }

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
            Sound1.SetActive(true);
            Sound2.SetActive(true);
            Sound3.SetActive(true);
            Sound4.SetActive(true);
            Sound5.SetActive(true);
        }
    }
}