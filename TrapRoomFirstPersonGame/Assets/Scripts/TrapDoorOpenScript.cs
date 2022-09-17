using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorOpenScript : MonoBehaviour
{
    public GameObject doorObj;

    public bool b_onAnimationTrapsDownRoomOn = false;
    [SerializeField]

    void OnTriggerEnter()
    {
        doorObj.GetComponent<Animation>().Play("TrapDoorDownAnim");

        b_onAnimationTrapsDownRoomOn = true;
    }
}
