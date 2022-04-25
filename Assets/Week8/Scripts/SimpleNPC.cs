using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthComponent))]

public class SimpleNPC : MonoBehaviour
{

    public delegate void PlayerFunDelegate(string x);
    public static event PlayerFunDelegate OnPlayerFun;

    HealthComponent healthComponent;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        healthComponent = GetComponent<HealthComponent>();
        healthComponent.OnHealthHitZero += HealthHitZero;
     
    }

    public void HealthHitZero()
    {
        Debug.LogWarning("PLAYER HEALTH HAS HIT ZERO!");
        spriteRenderer.color = Color.red;
    }

    IEnumerator WaitRoutine()
    {
        yield return new WaitForSeconds(1.0f);
        OnPlayerFun?.Invoke("This is a message");
    }

}
