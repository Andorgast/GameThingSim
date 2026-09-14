using System.Security.Cryptography;
using UnityEngine;


public class FoodManager : MonoBehaviour
{
    private int currentDay = 0;

    private int currentFood = 20;
    
    private int currentWater = 20;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewDay()
    {
        currentDay += 1;
        currentFood -= 1;
        currentWater -= 1;
    }

    // void FoundNewFood()
    // {
    //     currentFood += rng.
    // }
}
