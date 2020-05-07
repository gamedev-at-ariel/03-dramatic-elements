using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawyerScript : MonoBehaviour
{
    private Animator _anim;
    private SpriteRenderer _sr;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        if (direction < 0)
        {
            _sr.flipX = true;
        }
        else if (direction > 0)
        {
            _sr.flipX = false;
        }
        bool movment = false;
        if (Mathf.Abs(direction) == 0)
        {
            movment = false;
        }
        else
        {
            movment = true;
        }
        _anim.SetBool("movment", movment);
    }

}
