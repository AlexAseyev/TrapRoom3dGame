using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorOpenScript : MonoBehaviour
{
    [SerializeField] public GameObject doorObj;

    public bool b_onAnimationTrapsDownRoomOn = false;

    void OnTriggerEnter()
    {
        Animation liftAnim = doorObj.GetComponent<Animation>();

        if (!b_onAnimationTrapsDownRoomOn)
        {
            liftAnim.Play("TrapDoorDownAnim");
            b_onAnimationTrapsDownRoomOn = true;
        }
        else
        {
            liftAnim.Stop();

            // destroy down room
            GameObject ObjDownRoom = GameObject.Find("DownRoom");
            Destroy(ObjDownRoom);
        }
    }
}
