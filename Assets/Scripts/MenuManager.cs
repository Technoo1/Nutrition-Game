using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using static UnityEngine.EventSystems.EventTrigger;


[System.Serializable]
public class Meal
{
    public string name;
    public Sprite picture;
    public string description;
    public Dictionary<string, int> stats;
}
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mealButtonPrefab;
    [SerializeField] private Transform mealListParent;
    [SerializeField] private Image mealImage;
    [SerializeField] private TMP_Text mealDescription;
    [SerializeField] private TMP_Text mealStats;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider stressSlider;
    [SerializeField] private Slider energySlider;


    [SerializeField] private Button applyStatsButton;
    private Meal selectedMeal;

    [SerializeField] private List<Meal> meals;

    public Sprite pizzaSprite;
    public Sprite saladSprite;
    public Sprite spaghettiSprite;
    public Sprite roastChickenSprite;
    public Sprite pumpkinSoupSprite;
    public Sprite fishSprite;
    public Sprite fastFoodSprite;
    public Sprite steakMealSprite;
    public Sprite pancakeSprite;

    public int sizeOfMeal = 1;
    public Flowchart flowchart;

    private void Start()
    {
        meals = new List<Meal>();

        meals.Add(new Meal
        {
            name = "Pizza",
            picture = pizzaSprite,
            description = "The delicious disc of culinary harmony where gooey cheese,saucy tomato swirls,and a symphony of toppings come together to form a slice of pure joy",
            stats = new Dictionary<string, int> { { "Cost", 4*sizeOfMeal}, { "Health", +4 }, { "Stress", -4 }, { "Energy", +4 } }
        });
        meals.Add(new Meal
        {
            name = "Salad",
            picture = saladSprite,
            description = "A colorful confetti of crisp veggies, leafy greens, and tantalizing textures, tossed with a splash of dressing, inviting you to embrace the refreshing side of edible art.",
            stats = new Dictionary<string, int> { { "Cost", 10 * sizeOfMeal}, { "Health", +10 }, { "Stress", -10 }, { "Energy", +10 } }
        });
        meals.Add(new Meal
        {
            name = "Spaghetti",
            picture = spaghettiSprite,
            description = "The tangled embrace of tender pasta strands, coated in a luscious tango of savory sauce, promising a delicious dance for your taste buds.",
            stats = new Dictionary<string, int> { { "Cost", 7 * sizeOfMeal }, { "Health", +7 }, { "Stress", -7 }, { "Energy", +7 } }
        });
        meals.Add(new Meal
        {
            name = "Pumpkin Soup",
            picture = pumpkinSoupSprite,
            description = "A velvety cauldron of autumn's warmth, blending the earthy sweetness of pumpkins with aromatic spices, granting your spoon a ticket to cozy comfort.",
            stats = new Dictionary<string, int> { { "Cost", 10 * sizeOfMeal }, { "Health", +8 }, { "Stress", -10 }, { "Energy", +12 } }
        });
        meals.Add(new Meal
        {
            name = "Fish",
            picture = fishSprite,
            description = "A marine masterpiece where flaky fillets, kissed by the sea, swim in a symphony of flavors, leaving your palate hooked on its delicate yet satisfying taste.",
            stats = new Dictionary<string, int> { { "Cost", 10 * sizeOfMeal }, { "Health", +12 }, { "Stress", -10 }, { "Energy", +8 } }
        });
        meals.Add(new Meal
        {
            name = "Fast Food",
            picture = fastFoodSprite,
            description = "Featuring a juicy burger nestled between fluffy buns, golden fries that crunch with every bite, and a refreshing cola that fizzes its way to pure satisfaction, delivering a fast-paced feast for your senses.",
            stats = new Dictionary<string, int> { { "Cost", 4 * sizeOfMeal }, { "Health", +2 }, { "Stress", -4 }, { "Energy", +6 } }
        });
        meals.Add(new Meal
        {
            name = "Steak Meal",
            picture = steakMealSprite,
            description = "A carnivorous delight where succulent cuts of perfectly seared meat, oozing with juicy tenderness, take center stage, accompanied by a chorus of sizzling flavors, ensuring each mouthful is a carnivore's dream come true.",
            stats = new Dictionary<string, int> { { "Cost", 7 * sizeOfMeal }, { "Health", +9 }, { "Stress", -7 }, { "Energy", +5 } }
        });
        meals.Add(new Meal
        {
            name = "Roast Chicken",
            picture = roastChickenSprite,
            description = "The epitome of comfort and tradition, where golden-brown skin encases tender and succulent meat, unveiling a symphony of savory aromas that transport you to a warm and nostalgic embrace of home-cooked goodness.",
            stats = new Dictionary<string, int> { { "Cost", 7 * sizeOfMeal }, { "Health", +5 }, { "Stress", -7 }, { "Energy", +9 } }
        });
        meals.Add(new Meal
        {
            name = "Pancakes",
            picture = pancakeSprite,
            description = "Heavenly circles of fluffy delight, kissed by golden perfection, gracefully stacked and adorned with a cascade of syrup, promising a breakfast symphony that flips your taste buds into pure bliss.",
            stats = new Dictionary<string, int> { { "Cost", 4 * sizeOfMeal }, { "Health", +6 }, { "Stress", -4 }, { "Energy", +2 } }
        });


        foreach (Meal meal in meals)
        {
            GameObject button = Instantiate(mealButtonPrefab, mealListParent);
            button.GetComponentInChildren<TMP_Text>().text = meal.name;
            button.GetComponent<Button>().onClick.AddListener(() => ShowMealDetails(meal));
        }

        applyStatsButton.onClick.AddListener(() => ApplyMealStats(selectedMeal));

    }

    public void ShowMealDetails(Meal meal)
    {
        selectedMeal = meal;
        mealImage.sprite = meal.picture;
        mealDescription.text = meal.description;

        /*mealStats.text = "";
        foreach (KeyValuePair<string, int> stat in meal.stats)
        {
            mealStats.text += $"{stat.Key}: {stat.Value}\n";
        }*/
        mealStats.text = "Cost: $" + meal.stats["Cost"]*sizeOfMeal + "\n" + "Health: " + "\n" + "Stress: " + "\n" + "Energy: ";

        healthSlider.value = (float)meal.stats["Health"] / 12;
        stressSlider.value = (meal.stats["Stress"] + 15) / 15f;
        energySlider.value = (float)meal.stats["Energy"] / 12;
    }

    public void ApplyMealStats(Meal meal)
    {
        if (meal == null)
        {
            Debug.LogWarning("No meal selected!");
            return;
        }

        foreach (KeyValuePair<string, int> stat in meal.stats)
        {
            switch (stat.Key)
            {
                case "Cost":
                    GameManager.instance.budget -= stat.Value * sizeOfMeal;
                    break;
                case "Health":
                    GameManager.instance.health += stat.Value;
                    break;
                case "Stress":
                    GameManager.instance.stress += stat.Value;
                    break;
                case "Energy":
                    GameManager.instance.energy += stat.Value;
                    break;
                    // Add additional cases here for other stat types
            }
        }
        if(sizeOfMeal == 1)
        {
            flowchart.ExecuteBlock("results");
            TurnOffMenu();
        }
        else if(sizeOfMeal == 2)
        {
            switch (selectedMeal.name)
            {
                case "Salad":
                    GameManager.instance.healthy1 += 3;
                    break;
                case "Fish":
                    GameManager.instance.healthy2 += 3;
                    break;
                case "Pumpkin Soup":
                    GameManager.instance.healthy3 += 3;
                    break;
                case "Spaghetti":
                    GameManager.instance.mid1 += 3;
                    break;
                case "Roast Chicken":
                    GameManager.instance.mid2 += 3;
                    break;
                case "Steak Meal":
                    GameManager.instance.mid3 += 3;
                    break;
                case "Pizza":
                    GameManager.instance.unhealthy1 += 3;
                    break;
                case "Fast Food":
                    GameManager.instance.unhealthy2 += 3;
                    break;
                case "Pancakes":
                    GameManager.instance.unhealthy3 += 3;
                    break;
            }
            flowchart.ExecuteBlock("results");
            TurnOffMenu();
        }

    }

    public void TurnOnMenu()
    {
        GetComponent<Canvas>().enabled = true;
    }
    public void TurnOffMenu() 
    { 
        GetComponent<Canvas>().enabled = false; 
    }
    public void FastMeal()
    {
        sizeOfMeal = 1;
        TurnOnMenu();
    }
    public void BigMeal()
    {
        sizeOfMeal = 2;
        TurnOnMenu();
    }
}



