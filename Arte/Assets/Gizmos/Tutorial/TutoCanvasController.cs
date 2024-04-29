using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TutoCanvasController : MonoBehaviour
{
    public static TutoCanvasController Instance;

    Animator anim;

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
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowSpeedText()
    {
        speedText.text = "Velocidade " + TutoPlayerController.Instance.speedMul.ToString("0") + "X";
        anim.Play("tutospeedAmount", 0, 0f);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(1);
    }
}
