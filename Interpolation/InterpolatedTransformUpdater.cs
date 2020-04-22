using UnityEngine;
using System.Collections;

public class InterpolatedTransformUpdater : MonoBehaviour
{
    private InterpolatedTransform m_interpolatedTransform;

    void Awake()
    {
        m_interpolatedTransform = GetComponent<InterpolatedTransform>();
    }

    void FixedUpdate()
    {
        m_interpolatedTransform.LateFixedUpdate();
    }
}