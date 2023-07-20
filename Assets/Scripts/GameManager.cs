using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Add your variables here
    public int currentDay = 1;
    public int health = 10;
    public int stress = 10;
    public int energy = 10;
    public int academicAbilty = 10;
    public float budget = 50.00f;
    public bool hasEaten = false;

    public int healthy1 = 0;
    public int healthy2 = 0;
    public int healthy3 = 0;
    public int mid1 = 0;
    public int mid2 = 0;
    public int mid3 = 0;
    public int unhealthy1 = 0;
    public int unhealthy2 = 0;
    public int unhealthy3 = 0;

    public string packetOfChips;
    public string Lollies;
    public string energyDrink;
    public string chocolateBar;
    public string cupNoodles;

    public int finalScore;

    public GameObject CustomSayDialogue;
    public CanvasGroup canvasGroup;
    //public DialogInput dialogInput;

    public Flowchart ActiveFlowchart { get; private set; }

    public Dictionary<string, int> meals = new Dictionary<string, int>();

    private void Awake()
    {
        // Ensure only one instance of the GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DisableDialogue();
        }
    }

    public void DisableDialogue()
    {
        //canvasGroup.alpha = 0;
        CustomSayDialogue.GetComponent<DialogInput>().clickMode = ClickMode.Disabled;
        StartCoroutine(MoveObject(CustomSayDialogue.transform, new Vector3(-750f, -3f, 0), 1f));
    }
    public void EnableDialogue()
    {
        CustomSayDialogue.GetComponent<DialogInput>().clickMode = ClickMode.ClickAnywhere;
    }
    IEnumerator MoveObject(Transform objectToMove, Vector3 targetPosition, float duration)
    {
        float elapsed = 0;
        Vector3 startingPosition = objectToMove.localPosition;

        while (elapsed < duration)
        {
            objectToMove.localPosition = Vector3.Lerp(startingPosition, targetPosition, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        objectToMove.localPosition = targetPosition;
        
    }

    public void Test()
    {
        Debug.Log("Logged");
    }
}
    // Add your methods and functionality her


