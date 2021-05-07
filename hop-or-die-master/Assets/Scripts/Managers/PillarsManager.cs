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
        var alignment = 0;

        // create starting pillars
        for (var i = 0; i < _totalPillars; i++)
        {
            var pillar = Instantiate(_pillarPrefab);

            alignment = Random.Range(0, 3); // left, center, right

            switch (alignment)
            {
                case 0:
                    xPosition = -_horizontalDistance;

                    break;
                case 1:
                    xPosition = 0f;

                    break;
                case 2:
                    xPosition = _horizontalDistance;

                    break;
            }

            //pillar.transform.position = new Vector3(xPosition, 0f, zPosition);
            pillar.GetComponent<Pillar>().Show(true, xPosition, zPosition);
            zPosition += _forwardDistance;

            yield return new WaitForSeconds(_pillarsSpawnInterval);
        }
    }
}
