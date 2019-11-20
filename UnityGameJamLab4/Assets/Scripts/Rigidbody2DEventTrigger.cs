using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rigidbody2DEventTrigger : MonoBehaviour
{
    [Header("On Collision Enter")]
    [SerializeField] private UnityEvent onCollisionEnter;
    [Header("On Collision Stay")]
    [SerializeField] private UnityEvent onCollisionStay;
    [Header("On Collision Exit")]
    [SerializeField] private UnityEvent onCollisionExit;
    [Header("On Trigger Enter")]
    [SerializeField] private UnityEvent onTriggerEnter;
    [Header("On Trigger Stay")]
    [SerializeField] private UnityEvent onTriggerStay;
    [Header("On Trigger Exit")]
    [SerializeField] private UnityEvent onTriggerExit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionEnter.Invoke();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        onCollisionStay.Invoke();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onCollisionExit.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        onTriggerStay.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onTriggerExit.Invoke();
    }
}
