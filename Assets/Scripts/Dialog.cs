using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Dialog : MonoBehaviour
{
    public GameObject panel;
    public Text TextDialog;
    public string[] message;
    public bool StartDialog = false;
    public Animator anim;
    public Button button;


    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("SIT", true);

        message[0] = "Райден: Эй, куда так спешишь?";
        message[1] = "Алие:(Молчание...)";
        message[2] = "Райден: Язык проглатила?";
        message[3] = "Алие: Что? Вы кто вообще? Что вы забыли в 'Умершом Лесу'?";
        message[4] = "Райден: Страж, не должен, что-либо разъянять для простых смертных";
        message[5] = "Райден: А теперь идем за мной, покажу наши красоты";
        message[6] = "Алие: Какие красоты? Что ты несешь!?";
        message[7] = "Райден: У тебя уже нету выбора";
        message[8] = "Алие: Хммм...., а возможно и есть";


        panel.SetActive(false);
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("isGetUP1"); 
            panel.SetActive(true);
            TextDialog.text = message[0];
            StartDialog = true;
            anim.SetBool("SIT", false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        StartDialog = false;
    }
    private void Update()
    {
        if (StartDialog == true)
        {
            

        }
    }
}
