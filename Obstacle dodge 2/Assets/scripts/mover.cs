using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yvalue = 0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue,yvalue,zvalue);
    }
}
