using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Pillar : MonoBehaviour
{
    [SerializeField]
    private float
        _minY = -2.5f,
        _maxY = 2.5f,
        _timeToMove = 1f;

    private IEnumerator ShowCo(bool isShow, float xPosition, float zPosition)
    {
        var timer = 0f;

        while(timer < _timeToMove)
        {
            timer += Time.deltaTime;
            transform.position = new Vector3(xPosition, Mathf.SmoothStep(_minY, _maxY, timer / _timeToMove), zPosition);

            yield return null;
        }

        transform.position = new Vector3(transform.position.x, _maxY, transform.position.z);
    }

    public void Show(bool isShow, float xPosition, float zPosition)
    {
        StartCoroutine(ShowCo(isShow, xPosition, zPosition));
    }
}
