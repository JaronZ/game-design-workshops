using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZombieAnimator : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAttack()
    {
        Debug.Log("Mouse Clicked");
        Debug.Log(_animator.GetBool("Walking"));
        _animator.SetBool("Walking", !_animator.GetBool("Walking"));
    }

    // void FixedUpdate()
    // {
    //     if ()
    //     {
    //         _animator.SetBool("Walking", true);
    //     }
    //     else
    //     {
    //         _animator.SetBool("Walking", false);
    //     }
    // }
}
