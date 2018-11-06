using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : CharactorPart {

    public Action<DamageArea> OnEnter;

    public Action<DamageArea> OnStay;

    public Action<DamageArea> OnExit;

    private void OnTriggerEnter(Collider other)
    {
        DamageArea damage = other.GetComponent<DamageArea>();
        OnEnter?.Invoke(damage);
    }

    private void OnTriggerStay(Collider other)
    {
        DamageArea damage = other.GetComponent<DamageArea>();
        OnStay?.Invoke(damage);
    }

    private void OnTriggerExit(Collider other)
    {
        DamageArea damage = other.GetComponent<DamageArea>();
        OnExit?.Invoke(damage);
    }
}
