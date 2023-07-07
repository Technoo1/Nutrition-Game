using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ActivityScript : MonoBehaviour
{
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
    public void Healthy1()
    {
        GameManager.instance.energy += 10;
        GameManager.instance.health += 10;
    }
}
