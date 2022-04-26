using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public float health = 20f;
    public Animator animComponent;
    public AudioClip dieSound;
    public bool isDead
    {

        get
        {
            return health == 0;
        }
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health == 10f)
        {
            animComponent.SetTrigger("shot");
            animComponent.SetTrigger("un-shot");
        }
        if (isDead)
        {
            animComponent.SetTrigger("death");
        }

        if (health <= 0f)
        {
            Die();
            AudioSource.PlayClipAtPoint(dieSound, transform.position);
        }
    }
    void Die()
    {
        var destroyTime = 2;
        Destroy(gameObject,destroyTime);
    }
}
