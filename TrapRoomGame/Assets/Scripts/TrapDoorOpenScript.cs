using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorOpenScript : MonoBehaviour
{
    public GameObject doorObj;
    [SerializeField]

    public bool m_bDoorOpenActivateFlag = false;

    private const float m_fWaitLiftTime = 0.0001f;
    private const float m_fBoostSpeedMove = 5.0f;

    void OnTriggerEnter()
    {
        m_bDoorOpenActivateFlag = true;
        StartCoroutine("LiftMove");
    }

    IEnumerator LiftMove()
    {
        for(;;)
        {
            if(m_bDoorOpenActivateFlag)
            {
                doorObj.transform.position += Vector3.down * m_fBoostSpeedMove * Time.deltaTime;
                yield return new WaitForSeconds(m_fWaitLiftTime);

                // TODO stop platform
            }
        }
    }
}
