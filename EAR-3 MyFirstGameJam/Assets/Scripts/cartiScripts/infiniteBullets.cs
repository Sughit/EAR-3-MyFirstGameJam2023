using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infiniteBullets : MonoBehaviour
{
    public useCardIII card;
    public float boostDuration;
    public scriptWeapon weapon;

    public Image ammoPanel;
    public Image boostAmmoPanel;

    void Update()
    {
        ammoPanel = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/Canvas/ammoPanel").GetComponent<Image>();
        weapon = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/arma").GetComponent<scriptWeapon>();
        if(card.cardUsed)
        {
            Debug.Log("ammo card used");
            StartCoroutine(InfiniteAmmo());
        }
    }

    IEnumerator InfiniteAmmo()
    {
        Debug.Log("ammo effect is on");
        float currentAmmo = weapon.ammo;
        ammoPanel.gameObject.SetActive(false);
        boostAmmoPanel.gameObject.SetActive(true);
        weapon.ammo = 10000f;
        yield return new WaitForSeconds(boostDuration);
        weapon.ammo = currentAmmo;
        ammoPanel.gameObject.SetActive(true);
        boostAmmoPanel.gameObject.SetActive(false);
    }
}
