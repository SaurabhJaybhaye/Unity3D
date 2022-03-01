using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public HudManager hudManager;
    public float speed;
    public Transform leftWall;
    public Transform rightWall;

    private Stats m_Stats;

    private void Awake()
    {
        m_Stats = GetComponent<Stats>();
        hudManager.UpdateHealthText(m_Stats.health);
        hudManager.UpdateFoodText(m_Stats.Food);

    }

    // Update is called once per frame
    void Update()
    {
        if(m_Stats.health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalPosition = transform.position.x + horizontalInput * speed * Time.deltaTime;
        float playerSize = transform.localScale.x / 2;
        
        if(horizontalPosition - playerSize <= leftWall.position.x + leftWall.localScale.x/2)
        {
            return;
        }

        if (horizontalPosition + playerSize >= rightWall.position.x - rightWall.localScale.x / 2)
        {
            return;
        }

        transform.position = new Vector3(
            horizontalPosition,
            1,
            transform.position.z);
    }

    public void ReceiveDamage()
    {
        m_Stats.UpdateHealth(10);
        hudManager.UpdateHealthText(m_Stats.health);
    }

    public void ReceiveFood()
    {
        m_Stats.UpdateFood(1);
        hudManager.UpdateFoodText(m_Stats.Food);
    }
}
