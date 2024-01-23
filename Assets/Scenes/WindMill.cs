using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WindMill : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(6.0f * speed * Time.deltaTime, 0, 0);
    }
}
