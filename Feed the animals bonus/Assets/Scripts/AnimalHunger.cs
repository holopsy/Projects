using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int abountToBeFed;

    private int currentFedAmount = 0;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerSlider.maxValue = abountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.value = currentFedAmount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        if (currentFedAmount >= abountToBeFed)
        {
            gameManager.AddScore(abountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
