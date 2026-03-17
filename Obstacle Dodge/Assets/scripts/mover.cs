using UnityEngine;

public class mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
 void Start() 
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Moveplayer();
   
    }


        void PrintInstruction()
    {
        Debug.Log("Welkom to the game!");
        Debug.Log("Move arround wiht arrow keys or WASD");
        Debug.Log("Don't bump into the objects!");
    }

    void Moveplayer()
    {
       float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
