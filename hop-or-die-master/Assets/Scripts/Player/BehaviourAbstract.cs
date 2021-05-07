using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public abstract class BehaviourAbstract : MonoBehaviour
{
    [SerializeField]
    private List<MonoBehaviour>
        _disabledScripts;

    protected Rigidbody
        _rb;

    protected InputState
        _inputState;

    protected PlayerState
        _playerState;

    protected virtual void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _inputState = GetComponent<InputState>();
        _playerState = GetComponent<PlayerState>();
    }

    protected virtual void Start() { }

    protected virtual void Update() { }

    protected virtual void FixedUpdate() { }

    protected virtual void LateUpdate() { }

    protected virtual void OnEnable() { }

    protected virtual void OnDisable() { }

    protected void ToggleScripts(bool enable)
    {
        foreach (var item in _disabledScripts)
            item.enabled = enable;
    }
}
