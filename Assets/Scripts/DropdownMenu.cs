using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownMenu : MonoBehaviour
{
    GameObject[] foods;
    readonly List<string> food = new List<string>() { "Ham", "Wine Bottle", "Fish", "Beer", "Pie", "Stew", "Cake" };

    public Dropdown dropdown;

    private void Start()
    {
        foods = GameObject.FindGameObjectsWithTag("Food");
        dropdown.AddOptions(food);
    }

    public void Dropdown_IndexChanged(int index)
    {
        foreach (GameObject food in foods)
            foreach (Renderer component in food.GetComponentsInChildren<Renderer>())
                component.enabled = false;
        foreach (Renderer component in foods[index].GetComponentsInChildren<Renderer>())
            component.enabled = true;
    }
}
