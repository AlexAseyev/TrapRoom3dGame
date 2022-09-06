using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRespawnDownRoom : MonoBehaviour
{
    public GameObject m_RespawnPoint;
    public GameObject m_Player;
    [SerializeField]

    void OnTriggerEnter()
    {
        print("respawn");

        Vector3 pos = m_RespawnPoint.transform.position;
        m_Player.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
