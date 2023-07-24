using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class speedBoost : MonoBehaviour, IPointerClickHandler
{
    public cardManager manager;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        StartCoroutine(SpeedBoost());

        manager.CycleCards();
    }

    IEnumerator SpeedBoost()
    {
        Movement player = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player").GetComponent<Movement>();
        player.speed *= 1.5f;
        yield return new WaitForSeconds(5f);
        player.speed /= 1.5f;
    }
}
