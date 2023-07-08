using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Fungus;
using static UnityEngine.EventSystems.EventTrigger;

public class ActivityScript : MonoBehaviour
{
    public Flowchart dayFlowchart;
    public Flowchart cookBookFlowchart;
    public string chosenMeal;

    void Start()
    {
        dayFlowchart = GameObject.Find("DayFlowchart").GetComponent<Flowchart>();
        cookBookFlowchart = GameObject.Find("CookBookFlowchart").GetComponent<Flowchart>();
        
    }
    public void Study()
    {
        GameManager.instance.academicAbilty += 10;
        Debug.Log("+10 to academic ability");
        Debug.Log("Your academic ability is: " + GameManager.instance.academicAbilty);
    }
    public void Relax()
    {
        GameManager.instance.stress -= 10;
        GameManager.instance.energy += 10;
        Debug.Log("-10 to stress");
        Debug.Log("Your stress is " + GameManager.instance.stress);
        Debug.Log("+10 to energy");
        Debug.Log("Your energy is " + GameManager.instance.energy);
    }
    public void DidntEat()
    {
        GameManager.instance.stress += 10;
        GameManager.instance.energy -= 10;
        GameManager.instance.health -= 10;
    }
    public void CookMeal()
    {
        StringVariable recipiesSelected = cookBookFlowchart.GetVariable<StringVariable>("RecipieSelected");
        chosenMeal = recipiesSelected.ToString();
        IntegerVariable sizeOfMeal = dayFlowchart.GetVariable<IntegerVariable>("SizeOfMeal");

        switch (chosenMeal)
        {
            case "healthy1":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 10;
                    GameManager.instance.health += 10;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                break;
            case "healthy2":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 8;
                    GameManager.instance.health += 12;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                break;
            case "healthy3":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 12;
                    GameManager.instance.health += 8;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                break;
            case "mid1":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 7;
                    GameManager.instance.health += 7;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                break;
            case "mid2":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 9;
                    GameManager.instance.health += 5;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                break;
            case "mid3":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 5;
                    GameManager.instance.health += 9;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                break;
            case "unhealthy1":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 4;
                    GameManager.instance.health += 4;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                break;
            case "unhealthy2":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 6;
                    GameManager.instance.health += 2;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                break;
            case "unhealthy3":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 2;
                    GameManager.instance.health += 6;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 4 * sizeOfMeal.Value;
                }
                break;
        }
    }
}
