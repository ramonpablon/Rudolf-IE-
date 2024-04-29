using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamTrigger : MonoBehaviour
{
    public int triggMode;
    public float lerpSpeed;

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

    }

    private void OnTriggerStay2D(Collider2D trigg)
    {
        if (trigg.gameObject.tag.Equals("Player"))
        {
            switch (triggMode)
            {
                case 0:
                    print("inBossScene");
                    transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, new Vector3(7, 6, -30), Time.deltaTime * lerpSpeed);
                    break;
                case 1:
                    print("inGameScene");
                    transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, new Vector3(-4, 6, -30), Time.deltaTime * lerpSpeed);
                    break;
                case 2:
                    print("transitionToWife");
                    transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, new Vector3(-5.8f, 6, -30), Time.deltaTime * lerpSpeed);
                    break;
                case 3:
                    print("transitionToDog");
                    transposer.m_FollowOffset = Vector3.Lerp(transposer.m_FollowOffset, new Vector3(9f, 6, -30), Time.deltaTime * lerpSpeed);
                    break;
            }
        }
    }
}
