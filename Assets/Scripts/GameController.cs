using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Security.Cryptography;


namespace TurnBasedGame
{
    public class GameController : MonoBehaviour
    {
        //element references
        [SerializeField] private GameObject player = null;
        [SerializeField] private GameObject enemy = null;
        //hp and mana references
        [SerializeField] private Slider playerHealth = null;
        [SerializeField] private Slider playerMana = null;
        [SerializeField] private Slider enemyHealth = null;
        //buttons
        [SerializeField] private Button buttonAttack = null;
        [SerializeField] private Button buttonHeal = null;

        //hp text
        [SerializeField] private TMP_Text playerHPText = null;
        [SerializeField] private TMP_Text enemyHPText = null;
        [SerializeField] private TMP_Text playerManaText = null;
        private int pHPAmount;
        private int pManaAmount;
        private int eHPAmount;

        //selection buttons
        [SerializeField] private GameObject choice;

        [SerializeField] private TMP_Text textDesc = null;


        private bool isPlayerTurn = true;

        void Update()
        {
            PlayerHPSetValue();
            
        }

        private void PlayerHPSetValue()
        {
            pHPAmount = playerHealth.value.ConvertTo<int>();
            eHPAmount = enemyHealth.value.ConvertTo<int>();
            pManaAmount = playerMana.value.ConvertTo<int>();

            playerHPText.text = pHPAmount.ToString();
            playerManaText.text = pManaAmount.ToString();
            enemyHPText.text = eHPAmount.ToString();

        }

        private void Attack(GameObject target, int damage)
        {
            if (target == enemy)
            {
                enemyHealth.value -= damage;
                textDesc.text = "Player uses Attack!";

            }
            else
            {
                playerHealth.value -= damage;
                textDesc.text = "Enemy used Attack!";


            }

            ChangeTurn();
        }

        private void Heal(GameObject target, int amount, int mana)
        {
            if (target == enemy)
            {
                enemyHealth.value += amount;
                textDesc.text = "Enemy used Heal!";
            }
            else
            {
                playerHealth.value += amount;
                playerMana.value -= mana;
                textDesc.text = "Player used Heal!";
            }

            ChangeTurn();
        }


        public void BtnAttack()
        {
            Attack(enemy, 12);
        }

        public void Heal()
        {
            Heal(player, 6, 12);
        }

        public void ChangeTurn()
        {
            isPlayerTurn = !isPlayerTurn;

            if (!isPlayerTurn)
            {
                choice.gameObject.SetActive(false);
                buttonAttack.interactable = false;
                buttonHeal.interactable = false;




                StartCoroutine(EnemyTurn());
            }
            else
            {
                choice.gameObject.SetActive(true);
                buttonAttack.interactable = true;
                buttonHeal.interactable = true;




            }

        }




        private IEnumerator EnemyTurn()
        {
            yield return new WaitForSeconds(2);

            int random = 0;
            random = Random.Range(1, 3);



            if (random == 1)
            {
                Attack(player, 8);
            }
            else
            {
                Heal(enemy, 12, 0);
            }


        }

        

    }
}

