using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class PillarsManager : Singleton<PillarsManager>
{
    protected PillarsManager() { }

    [SerializeField]
    private GameObject
        _pillarPrefab;

    [SerializeField]
    private float
        _horizontalDistance,
        _forwardDistance,
        _totalPillars,
        _pillarsSpawnInterval;

    private void Start()
    {
        StartCoroutine(ShowPillarsCo());
    }

    private IEnumerator ShowPillarsCo()
    {
        var zPosition = _forwardDistance;
        var xPosition = 0f;
        var isLeft = false;

        // create starting pillars
        for (var i = 0; i < _totalPillars; i++)
        {
            var pillar = Instantiate(_pillarPrefab);

            isLeft = Random.Range(0, 2) == 0;
            xPosition = isLeft ? -(_horizontalDistance / 2f) : _horizontalDistance / 2f;

            //pillar.transform.position = new Vector3(xPosition, 0f, zPosition);
            pillar.GetComponent<Pillar>().Show(true, xPosition, zPosition);
            zPosition += _forwardDistance;

            yield return new WaitForSeconds(_pillarsSpawnInterval);
        }
    }

    public void OnHop()
    {
        // add pillar
        var pillar = Instantiate(_pillarPrefab);
        var isLeft = Random.Range(0, 2) == 0;

        pillar.GetComponent<Pillar>().Show(true, isLeft ? -(_horizontalDistance / 2f) : _horizontalDistance / 2f, _forwardDistance * _totalPillars);
    }
}
