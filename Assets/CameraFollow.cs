using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // Reference to the player's transform
    public Vector3 offset;      // Offset distance between the player and camera

    void Start()
    {
        // Optionally, initialize the offset if not set in the Inspector
        if (offset == Vector3.zero)
        {
            //offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // Update the camera's position to follow the player with the offset
         transform.position = player.position +  new Vector3(0,0,-10);
    }
}
