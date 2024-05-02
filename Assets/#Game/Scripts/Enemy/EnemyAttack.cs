using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void OnDamageTaken()
    {
        Debug.Log(name + "I also know that we took damage");
    }

    public void AttackHitEvent()
    {
        if (target == null)
        {
            return;
        }
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
        Debug.Log("bang bang");
    }
}
