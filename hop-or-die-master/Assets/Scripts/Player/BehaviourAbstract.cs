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

    protected CollisionState
        _collisionState;

    protected PlayerState
        _playerState;

    protected Animator
        _animator;

    protected virtual void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _collisionState = GetComponent<CollisionState>();
        _playerState = GetComponent<PlayerState>();
        _animator = GetComponent<Animator>();
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
