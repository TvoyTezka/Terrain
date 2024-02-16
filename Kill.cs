using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public AudioSource AudioDeath;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        AudioDeath.Play();
    }
}
