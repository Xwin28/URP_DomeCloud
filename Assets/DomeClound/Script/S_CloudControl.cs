using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class S_CloudControl : MonoBehaviour
{

    public Material m_LowCloud;
    Sequence m_CloudSequece;
    public CloudData m_ClearSky;
    public CloudData m_Cloudy;
    public CloudData m_CloudRain;
    public GameObject m_RainVFX;

    public void Func_ClearSky()
    {
        m_RainVFX.SetActive(false);
        if (m_CloudSequece.IsActive()) m_CloudSequece.Kill();
        m_CloudSequece = DOTween.Sequence();
        //Set Property of material
        //DENSITY
        float _CurrenDensity = m_LowCloud.GetFloat("_Density");
        float _Duration = 10;
        if (_CurrenDensity != m_ClearSky.m_Density)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenDensity, x => _CurrenDensity = x, m_ClearSky.m_Density, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Density", _CurrenDensity);
                })
                );
        }
        //DENSITY
        float _CurrenSpeed = m_LowCloud.GetFloat("_Speed");
        if (_CurrenSpeed != m_ClearSky.m_Speed)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenSpeed, x => _CurrenSpeed = x, m_ClearSky.m_Speed, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Speed", _CurrenSpeed);
                })
                );
        }
        //Color
        Color32 _CurrenColor = m_LowCloud.GetColor("_Color");
        if (!_CurrenColor.Equals(m_ClearSky.m_Color))
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenColor, x => _CurrenColor = x, m_ClearSky.m_Color, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetColor("_Color", _CurrenColor);
                })
                );
        }

    }

    public void Func_Cloudy()
    {
        m_RainVFX.SetActive(false);
        if (m_CloudSequece.IsActive()) m_CloudSequece.Kill();
        m_CloudSequece = DOTween.Sequence();
        //Set Property of material
        //DENSITY
        float _CurrenDensity = m_LowCloud.GetFloat("_Density");
        float _Duration = 10;
        if(_CurrenDensity != m_Cloudy.m_Density)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenDensity, x => _CurrenDensity = x, m_Cloudy.m_Density, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Density", _CurrenDensity);
                })
                );
        }
        //DENSITY
        float _CurrenSpeed = m_LowCloud.GetFloat("_Speed");
        if (_CurrenSpeed != m_Cloudy.m_Speed)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenSpeed, x => _CurrenSpeed = x, m_Cloudy.m_Speed, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Speed", _CurrenSpeed);
                })
                );
        }
        //Color
        Color32 _CurrenColor = m_LowCloud.GetColor("_Color");
        if (!_CurrenColor.Equals(m_Cloudy.m_Color))
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenColor, x => _CurrenColor = x, m_Cloudy.m_Color, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetColor("_Color", _CurrenColor);
                })
                );
        }

    }

    public void Func_CloudRain()
    {
        if (m_CloudSequece.IsActive()) m_CloudSequece.Kill();
        m_CloudSequece = DOTween.Sequence();
        //Set Property of material
        //DENSITY
        float _CurrenDensity = m_LowCloud.GetFloat("_Density");
        float _Duration = 10;
        if (_CurrenDensity != m_CloudRain.m_Density)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenDensity, x => _CurrenDensity = x, m_CloudRain.m_Density, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Density", _CurrenDensity);
                })
                );
        }
        //DENSITY
        float _CurrenSpeed = m_LowCloud.GetFloat("_Speed");
        if (_CurrenSpeed != m_CloudRain.m_Speed)
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenSpeed, x => _CurrenSpeed = x, m_CloudRain.m_Speed, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetFloat("_Speed", _CurrenSpeed);
                })
                );
        }
        //Color
        Color32 _CurrenColor = m_LowCloud.GetColor("_Color");
        if (!_CurrenColor.Equals(m_CloudRain.m_Color))
        {
            m_CloudSequece.Join(
                DOTween.To(() => _CurrenColor, x => _CurrenColor = x, m_CloudRain.m_Color, _Duration)
                .OnUpdate(() =>
                {

                    m_LowCloud.SetColor("_Color", _CurrenColor);
                })
                );
        }

        m_CloudSequece.OnComplete(() =>
        {
            m_RainVFX.SetActive(true);
        });
    }
}
