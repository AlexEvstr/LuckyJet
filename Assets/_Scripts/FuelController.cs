using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    [SerializeField] private Image _fuelBar;

    [SerializeField] private GameObject _warning;
    [SerializeField] private GameObject _lightning;

    public static float FuelQuantity;
    private float _totalFuel;

    private void Start()
    {
        FuelQuantity = 1.0f;
        _totalFuel = 1.0f;
    }

    private void Update()
    {
        _fuelBar.fillAmount = FuelQuantity / _totalFuel;
        if (FuelQuantity <= 0.25f)
        {
            ShowWarning();
        }
        else
        {
            ShowLightning();
        }
    }

    private void ShowWarning()
    {
        _lightning.SetActive(false);
        _warning.SetActive(true);
    }

    private void ShowLightning()
    {
        _warning.SetActive(false);
        _lightning.SetActive(true);
    }
}
