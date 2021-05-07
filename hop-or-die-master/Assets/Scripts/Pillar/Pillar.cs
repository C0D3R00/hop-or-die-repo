using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Pillar : MonoBehaviour
{
    [SerializeField]
    private float
        _minY = -2.5f,
        _maxY = 2.5f,
        _timeToMove = 1f,
        _movementSpeed;

    private float
        _targetPositionZ;

    private void Start()
    {
        _targetPositionZ = transform.position.z;
    }

    private void Update()
    {
        if (Mathf.Abs(transform.position.z - _targetPositionZ) > 0.01f && gameObject.activeInHierarchy)
        {
            var positionZ = Mathf.Lerp(transform.localPosition.z, _targetPositionZ, _movementSpeed * Time.deltaTime);

            transform.localPosition = new Vector3(transform.position.x, transform.position.y, positionZ);
        }

        if (_targetPositionZ <= -1f && gameObject.activeInHierarchy)
        {
            StartCoroutine(ShowCo(false, transform.position.x, transform.position.z));
        }
    }

    private IEnumerator ShowCo(bool isShow, float xPosition, float zPosition)
    {
        var timer = 0f;
        var minY = isShow ? _minY : _maxY;
        var maxY = isShow ? _maxY : _minY;

        while(timer < _timeToMove)
        {
            timer += Time.deltaTime;
            transform.position = new Vector3(xPosition, Mathf.SmoothStep(minY, maxY, timer / _timeToMove), zPosition);

            yield return null;
        }

        transform.position = new Vector3(transform.position.x, maxY, transform.position.z);

        if (!isShow)
        {
            // disable to return to pool
            gameObject.SetActive(false);
        }
    }

    public void OnHop()
    {
        _targetPositionZ--;
    }

    public void Show(bool isShow, float xPosition, float zPosition)
    {
        StartCoroutine(ShowCo(isShow, xPosition, zPosition));
    }
}
