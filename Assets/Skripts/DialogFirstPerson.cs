using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DialogFirstPerson : MonoBehaviour
{
    public GameObject PanelDialog;
    public Text Dialog;
    public string[] Message;
    public bool DialogStart = false;



    void Start()
    {
        Message[0] = "Нам нужна помощь с огнем!";
        Message[1] = "Помоги!";
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Experience 1");
            }
        }
    }
}
