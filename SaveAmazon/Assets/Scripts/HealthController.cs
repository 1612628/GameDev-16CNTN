using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class HealthController : MonoBehaviour
{
    public Animator animator;
    public Slider healthBar;

    public UnityEvent unityEnvent;

    private int health = 100;
    private bool animationPlayed = false;

    private void Start()
    {
        if(unityEnvent == null)
        {
            unityEnvent = new UnityEvent();
        }
        healthBar.value = health;
    }

    public void Damage(int hitpoint)
    {
        health -= hitpoint;
        if (health <= 0)
        {
            health = 0;
            animator.SetBool("IsDead", true);
            if (!animationPlayed)
            {
                animator.Play("Fall", -1, 0f);
                animationPlayed = true;
            }


        }
        healthBar.value = health;

    }

    private void Update()
    {
        if(health <= 0)
        {
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.99f && animator.GetCurrentAnimatorStateInfo(0).IsName("Fall"))
            {
                //Time.timeScale = 0f;
                unityEnvent.Invoke();

            }
        }
    }
}
