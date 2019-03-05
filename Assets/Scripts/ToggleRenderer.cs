using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleRenderer : MonoBehaviour
{
    GameObject[] foods;
    int currentFood = 0;
    readonly List<string> edibles = new List<string>() { "Ham", "Wine Bottle", "Fish", "Beer", "Pie", "Stew", "Cake" };
    public Dropdown dropdown;


    public void Awake() => foods = GameObject.FindGameObjectsWithTag("Food");
    public void ToggleVisibilityPrevious()
    {
        if (currentFood != dropdown.value)
            currentFood = dropdown.value;
        ToggleOff();
        currentFood = (currentFood + 6) % 7;
        foreach (Renderer component in foods[currentFood].GetComponentsInChildren<Renderer>())
            component.enabled = true;
        dropdown.value = currentFood;
        dropdown.RefreshShownValue();
    }
    public void ToggleVisibilityNext()
    {
        if (currentFood != dropdown.value)
            currentFood = dropdown.value;
        ToggleOff();
        currentFood = (currentFood + 1) % 7;
        foreach (Renderer component in foods[currentFood].GetComponentsInChildren<Renderer>())
            component.enabled = true;
        dropdown.value = currentFood;
        dropdown.RefreshShownValue();
    }

    public void ToggleOff()
    {
        foreach (GameObject food in foods)
            foreach (Renderer component in food.GetComponentsInChildren<Renderer>())
                component.enabled = false;
    }
}
