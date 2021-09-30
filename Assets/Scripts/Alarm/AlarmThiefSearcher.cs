using UnityEngine;

public class AlarmThiefSearcher : MonoBehaviour
{
    [SerializeField] private ThiefDirectionChanger _thief;
    [SerializeField] private Transform _moneybagPoint;
    [SerializeField] private Transform _escapePoint;

    private bool _isAlarmActive = false;

    public bool IsAlarmActive => _isAlarmActive;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _thief.gameObject && _thief.TargetPoint == _moneybagPoint)
        {
            _isAlarmActive = true;
        }
        else if (collision.gameObject == _thief.gameObject && _thief.TargetPoint == _escapePoint)
        {
            _isAlarmActive = false;
        }
    }
}
