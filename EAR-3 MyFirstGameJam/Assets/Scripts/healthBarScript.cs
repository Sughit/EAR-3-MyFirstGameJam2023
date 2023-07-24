using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarScript : MonoBehaviour
{
    public Camera camera;
    [SerializeField] private Slider slider;
    public Transform target;
    public Vector3 offset;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = (currentValue / maxValue)*100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation =camera.transform.rotation;
        transform.position =target.position + offset;
    }

}
