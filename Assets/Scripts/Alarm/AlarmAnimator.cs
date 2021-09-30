using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AlarmThiefSearcher))]
public class AlarmAnimator : MonoBehaviour
{
    private string _isAlarmActive = "IsAlarmActive";

    private Animator _animator;
    private AlarmThiefSearcher _alarmThiefSearcher;

    private void Start()
    {
        _alarmThiefSearcher = GetComponent<AlarmThiefSearcher>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool(_isAlarmActive, _alarmThiefSearcher.IsAlarmActive);
    }
}