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
        m_Player.transform.position = m_RespawnPoint.transform.position;
    }
}
