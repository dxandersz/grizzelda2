using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Satchel contains a limited number (default 5) of ingredients
    public int satchelCapacity = 5;
    public int needleCount = 1;
    // pouches and flasks hold powder and liquid poisons respectively
    public int pouchCapacity = 1;
    public int flaskCapacity = 2;

    private List<Ingredient> satchel = new List<Ingredient>();


    public bool AddIngredient(Ingredient ingredient)
    {
        if (satchel.Count < satchelCapacity)
        {
            satchel.Add(ingredient);
            return true;
        }
        else
        {
            Debug.Log("Inventory is full. oops!");
            return false;
        }
    }

    public void RemoveSatchelItem(Ingredient ingredient)
    {
        satchel.Remove(ingredient);
    }
    public void PrintSatchelContents()
    {
        foreach (Ingredient ingredient in satchel)
        {
            Debug.Log("Item: " + ingredient.name);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

public class Ingredient : MonoBehaviour
{
    public string itemName;
    public string effect;
    public string description;

    public string charges;
}
