using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Alarm))]
public class AlarmAnimator : MonoBehaviour
{
    private string _isAlarmActive = "IsAlarmActive";

    private Animator _animator;
    private Alarm _alarm;

    private void Start()
    {
        _alarm = GetComponent<Alarm>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool(_isAlarmActive, _alarm.IsAlarmActive);
    }
}