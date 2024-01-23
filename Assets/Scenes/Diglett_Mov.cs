using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diglett_Mov : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 1f;
    [SerializeField] private float time_delay = 1f;

    private float TimerT = 0f;
    private Vector3 Origin;
   


    void Start()
    {
        Origin = new Vector3(0,0,0); 
    }

    // Update is called once per frame
    void Update()
    {
        TimerT += Time.deltaTime;
        transform.position += Origin + new Vector3(0, 20 * speed * Time.deltaTime, 0);
        if(TimerT > time_delay)
        {
            transform.position += new Vector3(0,-20 * speed * Time.deltaTime,0); 
        }
        


    }
}
