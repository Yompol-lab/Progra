using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    
    public float fallThreshold = -10f;


  

    void Update()
    {
        CheckFall();
    }


    void CheckFall()
    {
        if (transform.position.y < fallThreshold)
        {
            ShowDeathMessage();

        }
    }


    void ShowDeathMessage()
    {

        


        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


        Destroy(gameObject);



        SceneManager.LoadScene("Moriste");

    }



}