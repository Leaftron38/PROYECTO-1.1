using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject objeto;
    public float MinRangeX;
    public float MaxRangeX;
    public float MinRangeY;
    public float MaxRangeY;
    private Vector3 vectorZero = new Vector3(0, 0, 0);
    public float velocityCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(objeto != null)
        {
            
            float positionX = Mathf.Clamp(objeto.transform.position.x, MinRangeX, MaxRangeX);
            float positionY = Mathf.Clamp(objeto.transform.position.y, MinRangeY, MaxRangeY);
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(positionX, positionY, -10), ref vectorZero, velocityCamera);
        }
    }
}
