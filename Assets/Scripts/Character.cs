using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public UnityEvent Click;
    [SerializeField] private ParticleSystem particleSystem;

    public void Play() => particleSystem.Play();

    private void OnMouseDown()
    {
        Click.Invoke();
    }
}
