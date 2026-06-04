using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstructions();
    }

    
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys to move the player around.");
        Debug.Log("Avoid obstacles and reach the goal to win!");
    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yvalue = 0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue,yvalue,zvalue);
    }

}
