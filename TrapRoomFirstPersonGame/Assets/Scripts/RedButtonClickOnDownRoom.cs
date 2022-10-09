using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonClickOnDownRoom : MonoBehaviour
{
    [SerializeField] public GameObject buttonObj;
    [SerializeField]  public GameObject doorObj;

    [SerializeField] public GameObject trapDoorTriger;
    [SerializeField] public GameObject respawnPoint;

    void OnTriggerEnter()
    {
        buttonObj.GetComponent<Animation>().Play("RedBtnDownAnim"); // red button anim
        doorObj.GetComponent<Animation>().Play("TrapDoorUpAnim"); // lift up anim

        respawnPoint.transform.position = transform.position; // move respawn point
    }
}
