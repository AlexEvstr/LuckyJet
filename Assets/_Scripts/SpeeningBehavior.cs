using UnityEngine;

public class SpeeningBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _circle;

    [SerializeField] private GameObject _magnetGift;
    [SerializeField] private GameObject _bombGift;
    [SerializeField] private GameObject _x2Gift;

    [SerializeField] private GameObject _cantSpeen;
    [SerializeField] private GameObject _speeningPanel;
    

    private float _speed;
    private bool _mark;

    private void Start()
    {
        _mark = false;
        _speed = Random.Range(1, 4);
    }

    private void Update()
    {
        if (_speed >= 0.001)
        {
            _circle.transform.transform.Rotate(0, 0, 360 * _speed * Time.deltaTime);
            _speed -= 0.001f;
        }
        if (_speed < 0.001f && _mark == false)
        {
            CheckPrize();
            _mark = true;
        }
    }

    private void CheckPrize()
    {
        if ((_circle.transform.localEulerAngles.z <= 12 && _circle.transform.localEulerAngles.z >= 0) ||
            (_circle.transform.localEulerAngles.z <= 365 && _circle.transform.localEulerAngles.z >= 348) ||
            (_circle.transform.localEulerAngles.z <= 237 && _circle.transform.localEulerAngles.z >= 213))
        {
            _bombGift.SetActive(true);
        }
        else if ((_circle.transform.localEulerAngles.z <= 103 && _circle.transform.localEulerAngles.z >= 78) ||
                (_circle.transform.localEulerAngles.z <= 192 && _circle.transform.localEulerAngles.z >= 168) ||
                (_circle.transform.localEulerAngles.z <= 326 && _circle.transform.localEulerAngles.z >= 302))
        {
            _magnetGift.SetActive(true);
        }
        else if ((_circle.transform.localEulerAngles.z <= 57 && _circle.transform.localEulerAngles.z >= 34) ||
                (_circle.transform.localEulerAngles.z <= 148 && _circle.transform.localEulerAngles.z >= 123) ||
                (_circle.transform.localEulerAngles.z <= 282 && _circle.transform.localEulerAngles.z >= 258))
        {
            _x2Gift.SetActive(true);
        }
        else
        {
            TurnOnCantSpin();
        }
    }

    public void ClaimMagnet()
    {
        GameData.MagnetBonus++;
        _magnetGift.SetActive(false);
        TurnOnCantSpin();
    }

    public void ClaimBomb()
    {
        GameData.BombBonus++;
        _bombGift.SetActive(false);
        TurnOnCantSpin();
    }

    public void ClaimX2()
    {
        GameData.X2Bonus++;
        _x2Gift.SetActive(false);
        TurnOnCantSpin();
    }

    private void TurnOnCantSpin()
    {
        _cantSpeen.SetActive(true);
        _speeningPanel.SetActive(false);
    }
}