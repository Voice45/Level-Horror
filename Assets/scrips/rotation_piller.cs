using UnityEngine;


public class rotation_piller : MonoBehaviour
{
    public bool X = false;
    public bool Y = false;
    public bool Z = true;
    public bool ChildPlayer = false;
    public float speed=10;
    void Start()
    {
        
    }

    void Update()
    {
        if(Z)
        transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
        else if (Y)
        transform.Rotate(Vector3.up * -speed * Time.deltaTime);
        else if (X)
        transform.Rotate(Vector3.right * -speed * Time.deltaTime);
        else
            Debug.Log("Rotation is wrong");
    }

    private Transform originalParent;

    void OnTriggerEnter(Collider col)
    {
        if (ChildPlayer && col.CompareTag("Player"))
        {
            // Store original parent so we can restore later
            originalParent = col.transform.parent;

            // Parent player to this object
            col.transform.SetParent(transform, true); // true = keep world position
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (ChildPlayer && col.CompareTag("Player"))
        {
            // Restore original parent
            col.transform.SetParent(originalParent, true);
        }
    }
}
