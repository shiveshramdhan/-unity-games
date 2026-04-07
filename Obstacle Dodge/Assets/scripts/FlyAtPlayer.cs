using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 Playerposition;
    void Start()
    {
        
    }

    
    void Update()
    {
        Transform.Position = Vector3.MoveTowards(Transform.Position, Playerposition, 1f);
    }
}
