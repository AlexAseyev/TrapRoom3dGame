using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRespawnDownRoom : MonoBehaviour
{
    [SerializeField] public GameObject m_RespawnPoint;
    [SerializeField] public GameObject m_Player;

    void OnTriggerEnter()
    {
        m_Player.transform.position = m_RespawnPoint.transform.position;
    }
}
