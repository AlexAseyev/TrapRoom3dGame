using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonClickOnDownRoom : MonoBehaviour
{
    public GameObject buttonObj;
    public GameObject doorObj;
    [SerializeField]

    void OnTriggerEnter()
    {
        //buttonObj.GetComponent<Animation>().Play("ButtonDownAnim");
        doorObj.GetComponent<Animation>().Play("TrapDoorUpAnim");
    }
}
