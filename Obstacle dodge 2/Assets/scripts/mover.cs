using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] float xvalue = 0f;
   [SerializeField] float yvalue = 0.01f;
    [SerializeField] float zvalue = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(xvalue,yvalue,zvalue);
    }
}
