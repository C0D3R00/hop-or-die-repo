using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class Hop : BehaviourAbstract
{
    [SerializeField]
    private Transform
        _body;

    [SerializeField]
    private float
        _timeToHop;

    //private IEnumerator HopCo()
    //{
    //    var startPosition = transform.position;
    //    var targetPosition = -transform.forward * _flyAwayDistance;
    //    var timer = 0f;

    //    while (timer < _timeToFlyAway)
    //    {
    //        timer += Time.deltaTime;

    //        var parabola = MathParabola.Parabola(startPosition, targetPosition, _flyAwayHeight, timer / _timeToFlyAway);
    //        var rotation = Quaternion.LookRotation(parabola - transform.position) * Quaternion.Euler(new Vector3(90f, 0f, 0f));

    //        transform.rotation = rotation;
    //        transform.position = parabola;

    //        _body.Rotate(new Vector3(0f, _flyAwayRotationSpeed * Time.deltaTime, 0f));

    //        yield return null;
    //    }

    //    _head.SetActive(false);
    //    _head.transform.SetParent(null);

    //    transform.SetParent(null);
    //    gameObject.SetActive(false);
    //}
}
