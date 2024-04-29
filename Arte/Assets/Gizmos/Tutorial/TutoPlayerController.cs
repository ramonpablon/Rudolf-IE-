using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoPlayerController : MonoBehaviour
{
    public static TutoPlayerController Instance;


    Animator anim;
    public float move;
    public float speedMul = 1.2f;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        speedMul = 1.2f;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * speedMul;
        SpeedMultiplier();


        if(anim.GetCurrentAnimatorClipInfo(0).Length >= 0)
            anim.SetFloat("Speed", move);
    }


    void SpeedMultiplier()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (speedMul < 4.2f)
                speedMul++;

            TutoCanvasController.Instance.ShowSpeedText();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (speedMul > 1f)
                speedMul--;

            TutoCanvasController.Instance.ShowSpeedText();
        }
    }
}
