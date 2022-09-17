using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogFivePerson : MonoBehaviour
{
    public GameObject PanelDialog;
    public Text Dialog;
    public string[] Message;
    public bool DialogStart = false;
    void Start()
    {
        Message[0] = "Беги к другим скорее!!!";
        Message[1] = "Скорее им нужна помощь!";
        PanelDialog.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            PanelDialog.SetActive(true);
            Dialog.text = Message[0];
            DialogStart = true;

        }
    }
    private void OnTriggerExit(Collider collision)
    {
        PanelDialog.SetActive(false);
        DialogStart = false;
    }



    void Update()
    {

        if (DialogStart == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Dialog.text = Message[1];
            }          
        }
    }
}
