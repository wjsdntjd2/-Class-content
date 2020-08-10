using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FX_Serialize : MonoBehaviour
{
    public ParticleSystem[] m_Effect;
    public Button m_StartBtn;
    public Button m_StopBtn;
    public float m_BaseTime;
    public float m_min;
    public float m_max;
    public float m_PlayTime;
    public bool m_AutoHide;
    float m_PlayingTime;
    bool m_isPlaying;
    int m_Count;

    IEnumerator PlayEffect()
    {
        m_Count = 0;
        while (m_Count < m_Effect.Length)
        {
            m_Effect[m_Count].gameObject.SetActive(true);
            m_Count++;
            yield return new WaitForSeconds(m_BaseTime + Random.Range(m_min, m_max));
        }
    }

    private void Start()
    {
        m_StartBtn.onClick.AddListener(OnClickStart);
        m_StopBtn.onClick.AddListener(OnClickStop);
    }

    void OnClickStart()
    {
        m_isPlaying = true;
        StopAllCoroutines();
        for (int i = 0; i < m_Effect.Length; i++)
        {
            m_Effect[i].gameObject.SetActive(false);
        }
        StartCoroutine(PlayEffect());
    }

    private void Update()
    {
        if (m_isPlaying && m_AutoHide)
        {
            m_PlayingTime += Time.deltaTime;
            if(m_PlayTime <= m_PlayingTime)
            {
                m_PlayingTime = 0;
                m_isPlaying = false;
                OnClickStop();
            }
        }
    }

    void OnClickStop()
    {
        StopAllCoroutines();
        for (int i = 0; i < m_Effect.Length; i++)
        {
            m_Effect[i].gameObject.SetActive(false);
        }
    }

    bool IsPlayFx()
    {
        for (int i = 0; i < m_Effect.Length; i++)
        {
            if(m_Effect[i].IsAlive())
            {
                return true;
            }
        }
        return false;
    }
}
