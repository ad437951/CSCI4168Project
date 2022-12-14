using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 20;
    public int currentHealth;
    public int statusEffect;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            // Generate a new run
            SceneManager.LoadScene("Level1SpaceShip");
        }

    }
    public void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }

    public void Heal(int healAmount) {
        if (currentHealth < maxHealth) {
            currentHealth += healAmount;
            healthBar.setHealth(currentHealth);
        }
    }

    public void shockDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);

        transform.Find("shockEffect").gameObject.SetActive(true);
        Invoke("Recover", 3f);
    }

    public void Recover()
    {
        healthBar.setHealth(currentHealth);
        transform.Find("shockEffect").gameObject.SetActive(false);
    }

}
