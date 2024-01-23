using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Camera_Rot : MonoBehaviour
{
    // Start is called before the first frame update

    private float TimerT = 0f;
    [SerializeField] private float Camera_Delay;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerT += Time.deltaTime;
        if (TimerT > Camera_Delay)
        {
            transform.eulerAngles += new Vector3(0, 90f * Time.deltaTime, 0);
        }
        if(TimerT > Camera_Delay + 1f)
        {
            transform.eulerAngles += new Vector3(0, -90f * Time.deltaTime, 0f);
        }
        if (TimerT > Camera_Delay + 5f)
        {
            transform.eulerAngles += new Vector3(0, -90f * Time.deltaTime, 0f);
        }

        if (TimerT > Camera_Delay + 6f)
        {
            transform.eulerAngles += new Vector3(0, 90f * Time.deltaTime, 0f);
        }
        if (TimerT > Camera_Delay + 10f)
            TimerT = 0f;
    }
}
