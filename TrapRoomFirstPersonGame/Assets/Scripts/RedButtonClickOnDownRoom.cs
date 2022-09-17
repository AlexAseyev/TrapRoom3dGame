using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonClickOnDownRoom : MonoBehaviour
{
    public GameObject buttonObj;
    public GameObject doorObj;

    public GameObject trapDoorTriger;
    public GameObject respawnPoint;
    [SerializeField]

    void OnTriggerEnter()
    {
        buttonObj.GetComponent<Animation>().Play("RedBtnDownAnim"); // red button anim
        doorObj.GetComponent<Animation>().Play("TrapDoorUpAnim"); // lift up anim

        respawnPoint.transform.position = transform.position; // move respawn point

        Destroy(trapDoorTriger); // remove
    }
}
