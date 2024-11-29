using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionplayer : MonoBehaviour
{
    private Vector3 objetivo;
    [SerializeField] private Camera camara;

    void Start()
    {
        camara = Camera.main;
    }

    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloradianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float angulogrados = (180 / Mathf.PI) * anguloradianes - 75;
        transform.rotation = Quaternion.Euler(0, 0, angulogrados);
    }
}
