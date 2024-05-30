using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemies", menuName = "ScriptableObjects/Enemies/Enemy")]
public class EnemyLists : ScriptableObject
{
    public string enemyName;
    public int enemyHp;
    public DefenseTypes enemyDefense;
    public DamageTypes enemyAttack;
    public DamageTypes enemtMagicAtk;
    public DefenseTypes enemyMagicDefense;
    public int enemySpd;
    public Sprite enemySprite;

}
