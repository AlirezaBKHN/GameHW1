using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour

{

    public static FuelScript instance;
    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f,5f)] private float _fuelDarinSpeed = 5f;
    [SerializeField] private float _maxFuelAmount = 100f;
    [SerializeField] private Gradient _fuelGradient;
    private float _currentFuelAmount;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
    }

    private void Start()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUI();
    }
    private void Update()
    {
        _currentFuelAmount -= Time.deltaTime * _fuelDarinSpeed;
        UpdateUI();
        if(_currentFuelAmount <= 0f)
        {
            GameManager.Instance.GameOver();
        }
    }

    public void FillFuel()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUI();
    }
    private void UpdateUI()
    {
        _fuelImage.fillAmount = (_currentFuelAmount / _maxFuelAmount);
        _fuelImage.color = _fuelGradient.Evaluate(_fuelImage.fillAmount);
    }
}
