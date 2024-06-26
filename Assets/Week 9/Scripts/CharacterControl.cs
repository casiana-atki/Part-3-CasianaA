using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI whichVillager;
    public static CharacterControl Instance; 

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.whichVillager.text = villager.ToString();

    }
    private void Start()
    {
        Instance = this;
    }
/* The addition of the line "Instance.whichVillager.text = villager.ToString();" replaces this
   private void Update()
    {
        if (SelectedVillager != null)   whichVillager.text = SelectedVillager.CanOpen().ToString();
        else whichVillager.text = "No one";
    }
*/

}
