using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target; // Reference to the ball or object to follow
    public float smoothSpeed = 5f; // Adjust this to control the smoothness of the camera movement
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Example offset

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.fixedDeltaTime);
            transform.position = smoothedPosition;
        }
    }
}
