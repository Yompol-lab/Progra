using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;
    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString(); 


    }




    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene("VictoryScreen");
            Debug.Log("No quedan frutas ganaste");
        }



    }








}
