using UnityEngine;

public class AlarmThiefSearcher : MonoBehaviour
{
    [SerializeField] private ThiefDirectionChanger _thief;
    [SerializeField] private Transform _moneybagPoint;
    [SerializeField] private Transform _escapePoint;

    private float _raycastDistance = 10;
    private bool _isAlarmActive = false;

    private Vector2 _transformDown;

    public bool IsAlarmActive => _isAlarmActive;

    private void Start()
    {
        _transformDown = transform.up * -1;
    }

    private void FixedUpdate()
    {
        var hit = Physics2D.Raycast(transform.position, _transformDown, _raycastDistance);

        if (hit.collider.gameObject == _thief.gameObject && _thief.TargetPoint == _moneybagPoint)
        {
            _isAlarmActive = true;
        }
        else if (hit.collider.gameObject == _thief.gameObject && _thief.TargetPoint == _escapePoint)
        {
            _isAlarmActive = false;
        }
    }
}
