using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] private List<Image> _heart = new List<Image>();
    public void OnDamage()
    {
        Image last = _heart[_heart.Count - 1];
        last.sprite = _sprite;
        _heart.Remove(last);
    } 
}
