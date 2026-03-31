using UnityEngine;

public class Dropper : MonoBehaviour
{
   [SerializeField] float dropTime = 2f;
   MeshRenderer mymeshRenderer;
   Rigidbody myRigidbody;
    void Start()
    {
        mymeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        mymeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > dropTime)
        {
             mymeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
