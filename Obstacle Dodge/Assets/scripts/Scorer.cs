using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int Hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        Hits++;
        Debug.Log("You bumped into things this many times: " + Hits );
    }
}
