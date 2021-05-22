using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float speed;
    [SerializeField]
    float cameraZDistance = -10f;

    Vector3 newPosition = new Vector3 (0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.x = target.position.x;
        newPosition.y = target.position.y;
        newPosition.z = cameraZDistance;
        
        transform.position = newPosition;     
    }
}
