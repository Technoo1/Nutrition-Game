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
    public Flowchart leftoversFlowchart;
    public Flowchart vendingMachineFlowChart;
    public string chosenMeal;
    public string chosenLeftovers;
    public string chosenSnack;
    public int scoreSummary;

    void Start()
    {
        //finds the flowchart gameobjects
        dayFlowchart = GameObject.Find("DayFlowchart").GetComponent<Flowchart>();
        cookBookFlowchart = GameObject.Find("CookBookFlowchart").GetComponent<Flowchart>();
        leftoversFlowchart = GameObject.Find("LeftoversFlowchart").GetComponent<Flowchart>();
        vendingMachineFlowChart = GameObject.Find("VendingMachineFlowChart").GetComponent<Flowchart>();
    }
    public void UpdateVariables()
    {
        IntegerVariable currentDay = dayFlowchart.GetVariable<IntegerVariable>("CurrentDay");
        currentDay.Value = GameManager.instance.currentDay;
        IntegerVariable healthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy1");
        healthy1.Value = GameManager.instance.healthy1;
        IntegerVariable healthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy2");
        healthy2.Value = GameManager.instance.healthy2;
        IntegerVariable healthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy3");
        healthy3.Value = GameManager.instance.healthy3;
        IntegerVariable mid1 = leftoversFlowchart.GetVariable<IntegerVariable>("mid1");
        mid1.Value = GameManager.instance.mid1;
        IntegerVariable mid2 = leftoversFlowchart.GetVariable<IntegerVariable>("mid2");
        mid2.Value = GameManager.instance.mid2;
        IntegerVariable mid3 = leftoversFlowchart.GetVariable<IntegerVariable>("mid3");
        mid3.Value = GameManager.instance.mid3;
        IntegerVariable unhealthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy1");
        unhealthy1.Value = GameManager.instance.unhealthy1;
        IntegerVariable unhealthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy2");
        unhealthy2.Value = GameManager.instance.unhealthy2;
        IntegerVariable unhealthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy3");
        unhealthy3.Value = GameManager.instance.unhealthy3;
        Debug.Log("variables updated");
    }
    public void EndOfNight()
    {
        GameManager.instance.currentDay += 1;
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

    public void ScoreSummary()
    {
        IntegerVariable score = dayFlowchart.GetVariable<IntegerVariable>("ScoreSummary");
        scoreSummary = GameManager.instance.academicAbilty + GameManager.instance.health - GameManager.instance.stress + GameManager.instance.energy;
        score.Value = scoreSummary;

        if (scoreSummary >= 110)
        {
         
            Debug.Log("You Win");
        }
        else if (scoreSummary < 110)
        {
            Debug.Log("You Lose");
        }
               
    }

    public void EatLeftovers()
    {
        IntegerVariable sizeOfMeal = dayFlowchart.GetVariable<IntegerVariable>("SizeOfMeal");
        StringVariable recipiesSelected = leftoversFlowchart.GetVariable<StringVariable>("RecipieSelected");
        chosenLeftovers = recipiesSelected.Value;
        Debug.Log("Leftovers RecipieSelected: " + chosenLeftovers);

        switch (chosenLeftovers)
        {
            case "healthy1":
                GameManager.instance.energy += 10;
                GameManager.instance.health += 10;
                GameManager.instance.stress -= 10;
                GameManager.instance.hasEaten = true;
                IntegerVariable healthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy1");
                healthy1.Value -= 1;
                GameManager.instance.healthy1 -= 1;
                break;
            case "healthy2":
                GameManager.instance.energy += 8;
                GameManager.instance.health += 12;
                GameManager.instance.stress -= 10;
                GameManager.instance.hasEaten = true;
                IntegerVariable healthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy2");
                healthy2.Value -= 1;
                GameManager.instance.healthy2 -= 1;
                break;
            case "healthy3":
                GameManager.instance.energy += 12;
                GameManager.instance.health += 8;
                GameManager.instance.stress -= 10;
                GameManager.instance.hasEaten = true;
                IntegerVariable healthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy3");
                healthy3.Value -= 1;
                GameManager.instance.healthy3 -= 1;
                break;
            case "mid1":
                GameManager.instance.energy += 7;
                GameManager.instance.health += 7;
                GameManager.instance.stress -= 7;
                GameManager.instance.hasEaten = true;
                IntegerVariable mid1 = leftoversFlowchart.GetVariable<IntegerVariable>("mid1");
                mid1.Value -= 1;
                GameManager.instance.mid1 -= 1;
                break;
            case "mid2":
                GameManager.instance.energy += 9;
                GameManager.instance.health += 5;
                GameManager.instance.stress -= 7;
                GameManager.instance.hasEaten = true;
                IntegerVariable mid2 = leftoversFlowchart.GetVariable<IntegerVariable>("mid2");
                mid2.Value -= 1;
                GameManager.instance.mid2 -= 1;
                break;
            case "mid3":
                GameManager.instance.energy += 5;
                GameManager.instance.health += 9;
                GameManager.instance.stress -= 7;
                GameManager.instance.hasEaten = true;
                IntegerVariable mid3 = leftoversFlowchart.GetVariable<IntegerVariable>("mid3");
                mid3.Value -= 1;
                GameManager.instance.mid3 -= 1;
                break;
            case "unhealthy1":
                GameManager.instance.energy += 4;
                GameManager.instance.health += 4;
                GameManager.instance.hasEaten = true;
                IntegerVariable unhealthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy1");
                unhealthy1.Value -= 1;
                GameManager.instance.unhealthy1 -= 1;
                break;
            case "unhealthy2":
                GameManager.instance.energy += 6;
                GameManager.instance.health += 2;
                GameManager.instance.hasEaten = true;
                IntegerVariable unhealthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy2");
                unhealthy2.Value -= 1;
                GameManager.instance.unhealthy2 -= 1;
                break;
            case "unhealthy3":
                GameManager.instance.energy += 2;
                GameManager.instance.health += 6;
                GameManager.instance.hasEaten = true;
                IntegerVariable unhealthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy3");
                unhealthy3.Value -= 1;
                GameManager.instance.unhealthy3 -= 1;
                break;
            default:
                Debug.Log("something went wrong. chosenMeal = " + chosenMeal);
                break;
        }
    }
    public void CookMeal()
    {
        //finds what meal was selected in fungus dialogue, and if that meal is a fast meal, a big meal or leftovers (the sizeOfMeal variable)
        IntegerVariable sizeOfMeal = dayFlowchart.GetVariable<IntegerVariable>("SizeOfMeal");
        StringVariable recipiesSelected = cookBookFlowchart.GetVariable<StringVariable>("RecipieSelected");
        chosenMeal = recipiesSelected.Value;
        Debug.Log("CookBook RecipieSelected: " + chosenMeal);

        switch (chosenMeal)
        {
            case "healthy1":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 10;
                    GameManager.instance.health += 10;
                    GameManager.instance.stress -= 10;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                    IntegerVariable healthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy1");
                    healthy1.Value += 3;
                    GameManager.instance.healthy1 += 3;
                }
                break;
            case "healthy2":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 8;
                    GameManager.instance.health += 12;
                    GameManager.instance.stress -= 10;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                    IntegerVariable healthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy2");
                    healthy2.Value += 3;
                    GameManager.instance.healthy2 += 3;
                }
                break;
            case "healthy3":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 12;
                    GameManager.instance.health += 8;
                    GameManager.instance.stress -= 10;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 10 * sizeOfMeal.Value;
                    IntegerVariable healthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("healthy3");
                    healthy3.Value += 3;
                    GameManager.instance.healthy3 += 3;
                }
                break;
            case "mid1":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 7;
                    GameManager.instance.health += 7;
                    GameManager.instance.stress -= 7;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                    IntegerVariable mid1 = leftoversFlowchart.GetVariable<IntegerVariable>("mid1");
                    mid1.Value += 3;
                    GameManager.instance.mid1 += 3;
                }
                break;
            case "mid2":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 9;
                    GameManager.instance.health += 5;
                    GameManager.instance.stress -= 7;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                    IntegerVariable mid2 = leftoversFlowchart.GetVariable<IntegerVariable>("mid2");
                    mid2.Value += 3;
                    GameManager.instance.mid2 += 3;
                }
                break;
            case "mid3":
                if (sizeOfMeal.Value == 1)
                {
                    GameManager.instance.energy += 5;
                    GameManager.instance.health += 9;
                    GameManager.instance.stress -= 7;
                    GameManager.instance.hasEaten = true;
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                }
                else
                {
                    GameManager.instance.budget -= 7 * sizeOfMeal.Value;
                    IntegerVariable mid3 = leftoversFlowchart.GetVariable<IntegerVariable>("mid3");
                    mid3.Value += 3;
                    GameManager.instance.mid3 += 3;
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
                    IntegerVariable unhealthy1 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy1");
                    unhealthy1.Value += 3;
                    GameManager.instance.unhealthy1 += 3;
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
                    IntegerVariable unhealthy2 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy2");
                    unhealthy2.Value += 3;
                    GameManager.instance.unhealthy2 += 3;
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
                    IntegerVariable unhealthy3 = leftoversFlowchart.GetVariable<IntegerVariable>("unhealthy3");
                    unhealthy3.Value += 3;
                    GameManager.instance.unhealthy3 += 3;
                }
                break;
            default:
                Debug.Log("something went wrong. chosenMeal = " + chosenMeal);
                break;
        }

    }
    public void VendingMachineSnack()
    {
        StringVariable snackSelected = vendingMachineFlowChart.GetVariable<StringVariable>("Snack");
        chosenSnack = snackSelected.Value;
        Debug.Log("Snackselected: " + chosenSnack);

        switch (chosenSnack)
        {
            case "PacketOfChips":
                GameManager.instance.energy -= 1;
                GameManager.instance.health += 1;
                GameManager.instance.budget -= 2;
                break;
            case "Lollies":
                GameManager.instance.energy -= 2;
                GameManager.instance.health += 1;
                GameManager.instance.budget -= 2;
                GameManager.instance.stress += 1;
                break;
            case "EnergyDrink":
                GameManager.instance.energy += 5;
                GameManager.instance.health -= 5;
                GameManager.instance.budget -= 5;
                GameManager.instance.stress += 4;
                break;
            case "ChocolateBar":
                GameManager.instance.energy += 2;
                GameManager.instance.health += 1;
                GameManager.instance.budget -= 3;
                break;
            case "CupOfNoodles":
                GameManager.instance.energy += 1;
                GameManager.instance.health -= 5;
                GameManager.instance.health -= 0;
                break;
                    

        }


    }
}
