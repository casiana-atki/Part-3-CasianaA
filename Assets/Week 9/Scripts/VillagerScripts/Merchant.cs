using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By putting Villager, MechantBeh derives all the behaviour from Villager, and Villager derives from MonoBehaviour 
public class Merchant : Villager
{
    public override ChestType CanOpen()
    {
        return ChestType.Merchant;
    }
}
