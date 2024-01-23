using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes_Blinking : MonoBehaviour
{
    // Start is called before the first frame update


    private float TimerT = 0f;
    
    [SerializeField] float Time_Delay = 1f;

   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        TimerT += Time.deltaTime;
        if (TimerT > Time_Delay)
        {
            if (TimerT > Time_Delay + 0.5f)
            {
                transform.localScale += new Vector3(0f, 1f * Time.deltaTime, 0f);
                if (TimerT > Time_Delay + 1f)
                {
                    TimerT = 0f;
                }
            }
            else
                transform.localScale += new Vector3(0f, -1f * Time.deltaTime, 0f);
        }
        
        
    }
}
