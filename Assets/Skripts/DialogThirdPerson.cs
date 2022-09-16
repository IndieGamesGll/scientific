using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DialogThirdPerson : MonoBehaviour
{
    public GameObject PanelDialog;
    public Text Dialog;
    public string[] Message;
    public bool DialogStart = false;
    void Start()
    {
        Message[0] = "Ох уж эти гейзеры!";
        Message[1] = "Помоги с Водой!";
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
                SceneManager.LoadScene("Experience 3");
            }
        }
    }
}
