using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private List<GameObject> _heart = new List<GameObject>();
    public void OnDamage()
    {
        GameObject _last = _heart[_heart.Count - 1];
        _last.SetActive(false);
        _heart.Remove(_last);
    } 
}
