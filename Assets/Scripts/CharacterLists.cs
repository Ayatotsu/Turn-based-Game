using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterLists", menuName = "ScriptableObjects/Characters/CharacterLists")]
public class CharacterLists : ScriptableObject
{

    public string charName;
    public int charHp;
    public DefenseTypes charDefense;
    public DamageTypes charAttack;
    public DamageTypes charMagicAtk;
    public DefenseTypes charMagicDefense;
    public int charSpd;
    public Sprite charImage;

}
