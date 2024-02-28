using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent enter;
    public UnityEvent stay;

    private void OnTriggerEnter(Collider other)
    {
        enter.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        stay.Invoke();
    }
}
