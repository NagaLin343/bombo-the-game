using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysController : MonoBehaviour
{
    [SerializeField]
    public AudioSource m_mainMenuMys;
    [SerializeField]
    public AudioSource m_gameMys;
    [SerializeField]
    public AudioSource m_impactSound;

    public void SetMainMenuVibe()
    {
        m_mainMenuMys.Play();
        m_gameMys.Stop();
    }

    public void SetGameVibe()
    {
        m_mainMenuMys.Stop();
        m_gameMys.Play();
    }

    public void PlayImpactSound()
    {
        m_impactSound.Play();
    }
}

