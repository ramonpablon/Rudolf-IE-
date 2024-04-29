using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class teste : MonoBehaviour
{

    public CinemachineConfiner confiner;
    public Collider asd;
    public Collider dsa;

    public CinemachineVirtualCamera vcam;

    private CinemachineTransposer transposer;

    // Start is called before the first frame update
    void Start()
    {
        transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            confiner.m_BoundingVolume = asd;
            transposer.m_FollowOffset = new Vector3(-5.8f, 6, -30);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            confiner.m_BoundingVolume = dsa;
            transposer.m_FollowOffset = new Vector3(-8, 6, -20);
        }
    }
}
