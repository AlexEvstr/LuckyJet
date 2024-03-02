using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    [SerializeField] private Image _fuelBar;

    public static float FuelQuantity;
    private float _totalFuel;

    private void Start()
    {
        FuelQuantity = 1.0f;
        _totalFuel = 1.0f;
        //StartCoroutine(FuelDecrease());
    }

    private void Update()
    {
        _fuelBar.fillAmount = FuelQuantity / _totalFuel;
    }
}
