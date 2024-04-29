using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPController : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isTimelinePart2)
        {
            anim.Play("PostProcessTimeline2");
        }
    }
}
