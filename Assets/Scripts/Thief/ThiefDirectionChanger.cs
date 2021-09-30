using UnityEngine;

public class ThiefDirectionChanger : MonoBehaviour
{
    [SerializeField] private float _timeBeforeEscape;

    [SerializeField] private Alarm _alarm;
    [SerializeField] private Transform _escapePoint;
    [SerializeField] private Transform _moneybagPoint;

    private float _timePassed;

    private Vector3 _thiefLooksLeft;
    private Transform _targetPoint;

    public Transform TargetPoint => _targetPoint;

    private void Start()
    {
        _targetPoint = _moneybagPoint;
        _thiefLooksLeft = new Vector3(-1, 1, 1);
    }

    private void Update()
    {
        if (_alarm.IsAlarmActive && _timeBeforeEscape > _timePassed)
        {
            _timePassed += Time.deltaTime;
        }
        else if (_alarm.IsAlarmActive && _timeBeforeEscape <= _timePassed)
        {
            _targetPoint = _escapePoint;
            transform.localScale = _thiefLooksLeft;
        }
    }
}
