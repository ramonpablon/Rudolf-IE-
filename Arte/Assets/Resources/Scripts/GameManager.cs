using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isTimelinePart2;
    [Space]
    public PlayerController rudolf;


    public GameObject Taxi;
    public GameObject quadro1;
    public GameObject postevermelin;
    public GameObject posteverdin;
    public GameObject vermelhao;
    public GameObject papelada;
    public GameObject pano;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimelinePart2)
            rudolf.anim.SetBool("isTimelinePart2", isTimelinePart2);

        if (isTimelinePart2)
            TimelinePart2();
        else
            TimelinePart1();
    }

    public void TimelinePart2()
    {
        Taxi.SetActive(false);
        //quadro1.SetActive(false);
        posteverdin.SetActive(true);
        postevermelin.SetActive(false);
        vermelhao.SetActive(false);
        papelada.SetActive(false);
        pano.SetActive(false);
    }

    public void TimelinePart1()
    {
        Taxi.SetActive(true);
        //quadro1.SetActive(true);
        posteverdin.SetActive(false);
        postevermelin.SetActive(true);
        vermelhao.SetActive(true);
        papelada.SetActive(true);
        pano.SetActive(true);
    }
}
