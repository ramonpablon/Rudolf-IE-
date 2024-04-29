using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public static CanvasController Instance;

    Animator anim;

    float time = 0;

    public TextMeshProUGUI speedText;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        speedText = GetComponentInChildren<TextMeshProUGUI>();
        anim.Play("On");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.Instance.move == 0)
        {
            time += Time.deltaTime;
        }

        if (PlayerController.Instance.move != 0)
        {
            time = 0;
        }

        if (time > 2)
        {
            anim.Play("On");
        }
        if (time == 0)
        {
            anim.Play("Off");
        }


        if (GameManager.Instance.isTimelinePart2)
        {
            anim.Play("CanvasTimeline2");
        }
    }

    void GoToTimeline2()
    {
        GameManager.Instance.isTimelinePart2 = true;
    }

    public void ShowSpeedText()
    {
        speedText.text = "Velocidade " + PlayerController.Instance.speedMul.ToString("0") + "X";
        anim.Play("speedAmount", 4, 0f);
    }




    public void OpenNews31()
    {
        Application.OpenURL("https://sway.office.com/LJFbxW0nHiRjBK1W?ref=Link");
    }
    public void OpenNews36()
    {
        Application.OpenURL("https://sway.office.com/IsdmCuLLd1vn7Fg3?ref=Link");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
