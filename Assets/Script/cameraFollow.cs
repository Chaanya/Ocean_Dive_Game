using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject target;

    public Vector3 offset;

    public float Smoothness = 0.125f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 camPos = transform.position;
            Vector3 PlayerPos = target.transform.position;
            Vector3 desiredPosition = PlayerPos;
            Vector3 smoothedPos = Vector3.Lerp(camPos, desiredPosition, Smoothness);

            transform.position = smoothedPos + offset;
        }
    }
}
