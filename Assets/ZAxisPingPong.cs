// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class ZAxisPingPong : MonoBehaviour
{
    [SerializeField] private float positionExtent = 1f;
    [SerializeField] private float flipPeriod = 1f;

    private void Update()
    {
        var normalizedPosition = Mathf.PingPong(Time.time, flipPeriod) / flipPeriod;
        var pos = Mathf.Lerp(-positionExtent, positionExtent, normalizedPosition) * Vector3.forward;

        transform.localPosition = pos;
    }
}
