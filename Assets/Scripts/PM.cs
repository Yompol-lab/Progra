using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float fuerzaSalto = 5f;
    public bool tocandoPiso;



    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocandoPiso)
        {

            playerRB.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            tocandoPiso = false;


        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        tocandoPiso = true;

    }
}
