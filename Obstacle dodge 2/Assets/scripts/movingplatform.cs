using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;
    public float speed = 2;

    void Update()
    {
        transform.position =
            Vector3.Lerp(startPos,endPos,
            Mathf.PingPong(Time.time * speed,1));
    }
}