using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CDownRoomTrap
{
    public void AnimationTrapActivate(GameObject trapObj)
    {
        trapObj.GetComponent<Animation>().Play("CylinderRightLeftMoveAnim");
    }
}

public class DownRoomTrapsAnimActivate : MonoBehaviour
{
    private void Update()
    {
        //if ()
        {
            CDownRoomTrap trap = new CDownRoomTrap();
            trap.AnimationTrapActivate(gameObject);
        }
    }
}
