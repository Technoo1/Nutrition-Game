using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject CustomSayDialoguePanel;
    public CanvasGroup canvasGroup;
    public bool isPaused = false;
    private Vector3 originalPosition;
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
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            DisableDialogue();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            EnableDialogue();
        }
    }

    public void DisableDialogue()
    {
        // Store the original position
        originalPosition = CustomSayDialoguePanel.GetComponent<RectTransform>().anchoredPosition;

        CustomSayDialogue.GetComponent<DialogInput>().clickMode = ClickMode.Disabled;
        StartCoroutine(MoveObject(CustomSayDialoguePanel.GetComponent<RectTransform>(), new Vector3(-750f, -3f, 0), 0.25f));
        isPaused = true;
    }
    public void EnableDialogue()
    {
        CustomSayDialogue.GetComponent<DialogInput>().clickMode = ClickMode.ClickAnywhere;
        StartCoroutine(MoveObject(CustomSayDialoguePanel.GetComponent<RectTransform>(), originalPosition, 0.25f));
        isPaused = false;
    }
    IEnumerator MoveObject(RectTransform objectToMove, Vector3 targetPosition, float duration)
    {
        float elapsed = 0;
        Vector3 startingPosition = objectToMove.anchoredPosition;

        while (elapsed < duration)
        {
            objectToMove.anchoredPosition = Vector3.Lerp(startingPosition, targetPosition, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        objectToMove.anchoredPosition = targetPosition;
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void Test()
    {
        Debug.Log("Logged");
    }
}
    // Add your methods and functionality her


